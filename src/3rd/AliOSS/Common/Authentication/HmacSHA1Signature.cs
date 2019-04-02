/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 * 
 */

using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Aliyun.OSS.Common.Authentication
{
    internal class HmacSha1Signature : ServiceSignature
    {
        private static readonly Encoding Encoding = Encoding.UTF8;
        public override string SignatureMethod
        {
            get { return "HmacSHA1"; }
        }

        public override string SignatureVersion
        {
            get { return "1"; }
        }

        protected override string ComputeSignatureCore(string key, string data)
        {
            Debug.Assert(!string.IsNullOrEmpty(data));

            using (var algorithm = CreateAlgorithm(SignatureMethod.ToUpperInvariant(), Encoding.GetBytes(key.ToCharArray())))
            {
                return Convert.ToBase64String(algorithm.ComputeHash(Encoding.GetBytes(data.ToCharArray())));
            }

            //using (var algorithm = KeyedHashAlgorithm.Create(SignatureMethod.ToUpperInvariant()))
            //{
            //    algorithm.Key = Encoding.GetBytes(key.ToCharArray());
            //    return Convert.ToBase64String(
            //        algorithm.ComputeHash(Encoding.GetBytes(data.ToCharArray())));
            //}
        }


        private HMAC CreateAlgorithm(string method, byte[] key)
        {
            method = method.ToUpper();
            switch (method)
            {
                case "RS256":
                    return new HMACSHA256(key);
                case "HS384":
                    return new HMACSHA384(key);
                case "HS512":
                    return new HMACSHA512(key);
                case "HMACSHA1":
                    return new HMACSHA1(key);
                default:
                    return new HMACSHA256(key);
            }
        }
    }
}
