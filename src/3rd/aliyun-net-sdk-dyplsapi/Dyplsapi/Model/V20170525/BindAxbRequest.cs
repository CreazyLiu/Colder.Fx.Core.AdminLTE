/*
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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dyplsapi.Transform;
using Aliyun.Acs.Dyplsapi.Transform.V20170525;
using System.Collections.Generic;

namespace Aliyun.Acs.Dyplsapi.Model.V20170525
{
    public class BindAxbRequest : RpcAcsRequest<BindAxbResponse>
    {
        public BindAxbRequest()
            : base("Dyplsapi", "2017-05-25", "BindAxb")
        {
        }

		private string expectCity;

		private string phoneNoX;

		private string accessKeyId;

		private string resourceOwnerAccount;

		private string expiration;

		private bool? isRecordingEnabled;

		private string phoneNoB;

		private string action;

		private string phoneNoA;

		private long? resourceOwnerId;

		private string poolKey;

		private long? ownerId;

		private string outId;

		public string ExpectCity
		{
			get
			{
				return expectCity;
			}
			set	
			{
				expectCity = value;
				DictionaryUtil.Add(QueryParameters, "ExpectCity", value);
			}
		}

		public string PhoneNoX
		{
			get
			{
				return phoneNoX;
			}
			set	
			{
				phoneNoX = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNoX", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string Expiration
		{
			get
			{
				return expiration;
			}
			set	
			{
				expiration = value;
				DictionaryUtil.Add(QueryParameters, "Expiration", value);
			}
		}

		public bool? IsRecordingEnabled
		{
			get
			{
				return isRecordingEnabled;
			}
			set	
			{
				isRecordingEnabled = value;
				DictionaryUtil.Add(QueryParameters, "IsRecordingEnabled", value.ToString());
			}
		}

		public string PhoneNoB
		{
			get
			{
				return phoneNoB;
			}
			set	
			{
				phoneNoB = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNoB", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string PhoneNoA
		{
			get
			{
				return phoneNoA;
			}
			set	
			{
				phoneNoA = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNoA", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string PoolKey
		{
			get
			{
				return poolKey;
			}
			set	
			{
				poolKey = value;
				DictionaryUtil.Add(QueryParameters, "PoolKey", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(QueryParameters, "OutId", value);
			}
		}

        public override BindAxbResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return BindAxbResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}