﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Security.Cryptography;
using System.Text;

namespace Aliyun.Acs.Core.Auth
{
    public class ShaHmac256 : ISigner
    {

        public override string SignerName
        {
            get
            {
                return "HMAC-SHA256";
            }
        }

        public override string SignerVersion
        {
            get
            {
                return "1.0";
            }
        }

        public override String SignString(String source, String accessSecret)
        {
            //using (var algorithm = KeyedHashAlgorithm.Create("HMACSHA256"))
            //{
            //    algorithm.Key = Encoding.UTF8.GetBytes(accessSecret.ToCharArray());
            //    return Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(source.ToCharArray())));
            //}

            using (var algorithm = ShaHmacHelper.CreateAlgorithm("HMACSHA256", Encoding.UTF8.GetBytes(accessSecret.ToCharArray())))
            {
                return Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(source.ToCharArray())));
            }
        }
    }
}
