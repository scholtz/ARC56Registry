using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.StructInBoxMap_508553b3
{


    public class StructInBoxMapProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StructInBoxMapProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class User : AVMObjectType
            {
                public ulong Id { get; set; }

                public string Name { get; set; }

                public ulong Age { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAge.From(Age);
                    ret.AddRange(vAge.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static User Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new User();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAge.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAge = vAge.ToValue();
                    if (valueAge is ulong vAgeValue) { ret.Age = vAgeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as User);
                }
                public bool Equals(User? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(User left, User right)
                {
                    return EqualityComparer<User>.Default.Equals(left, right);
                }
                public static bool operator !=(User left, User right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        /// <param name="user"> User</param>
        public async Task<bool> CreateNewUser(ulong id, Structs.User user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 61, 204, 112 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi, user }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateNewUser_Transactions(ulong id, Structs.User user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 61, 204, 112 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi, user }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task<Structs.User> GetUser(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 20, 59, 209 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.SimApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.User.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUser_Transactions(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 20, 59, 209 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task<bool> CheckUserExists(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 196, 193, 31 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.SimApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CheckUserExists_Transactions(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 196, 193, 31 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        /// <param name="name"> </param>
        /// <param name="age"> </param>
        public async Task<bool> UpdateUserNameAndAge(ulong id, string name, ulong age, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 53, 81, 206 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ageAbi.From(age);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi, nameAbi, ageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UpdateUserNameAndAge_Transactions(ulong id, string name, ulong age, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 53, 81, 206 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var ageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ageAbi.From(age);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi, nameAbi, ageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RydWN0SW5Cb3hNYXAiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVXNlciI6W3sibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWdlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVOZXdVc2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHN0cmluZyx1aW50NjQpIiwic3RydWN0IjoiVXNlciIsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IlVzZXIiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrVXNlckV4aXN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVVzZXJOYW1lQW5kQWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjUsMTgwXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTEsMjI4XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXJ0IHRhcmdldCBpcyBtYXRjaCBmb3IgY29uZGl0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBeE1DQTRJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJblZ6WlhKeklpQXdlREUxTVdZM1l6YzFPREFnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFOMGNuVmpkRWx1UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklHVjRjRzl5ZENCa1pXWmhkV3gwSUdOc1lYTnpJRk4wY25WamRFbHVRbTk0VFdGd0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV4Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURjNE0yUmpZemN3SURCNE9UTXhORE5pWkRFZ01IZ3lZbU0wWXpFeFppQXdlRE5oTXpVMU1XTmxJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxUbVYzVlhObGNpaDFhVzUwTmpRc0tIVnBiblEyTkN4emRISnBibWNzZFdsdWREWTBLU2xpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJWYzJWeUtIVnBiblEyTkNrb2RXbHVkRFkwTEhOMGNtbHVaeXgxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0pqYUdWamExVnpaWEpGZUdsemRITW9kV2x1ZERZMEtXSnZiMndpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVlZ6WlhKT1lXMWxRVzVrUVdkbEtIVnBiblEyTkN4emRISnBibWNzZFdsdWREWTBLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWT1pYZFZjMlZ5SUdkbGRGVnpaWElnWTJobFkydFZjMlZ5UlhocGMzUnpJSFZ3WkdGMFpWVnpaWEpPWVcxbFFXNWtRV2RsQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXhPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMU4wY25WamRFbHVRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklGTjBjblZqZEVsdVFtOTRUV0Z3SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200Z0x5OGdiMjRnWlhKeWIzSTZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQWdKaVlnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2dvS0x5OGdZMjl1ZEhKaFkzUnpMMU4wY25WamRFbHVRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xOMGNuVmpkRWx1UW05NFRXRndMbU55WldGMFpVNWxkMVZ6WlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWT1pYZFZjMlZ5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFOMGNuVmpkRWx1UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1ZPWlhkVmMyVnlLR2xrT2lCMWFXNTBOalFzSUhWelpYSTZJRlZ6WlhJcE9pQmliMjlzWldGdUlIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVRkSEoxWTNSSmJrSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUIwYUdsekxuVnpaWEp6S0dsa0tTNTJZV3gxWlNBOUlHTnNiMjVsS0hWelpYSXBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVM1J5ZFdOMFNXNUNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1ZYTmxjajRvZXlCclpYbFFjbVZtYVhnNklDZDFjMlZ5Y3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnpaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUzUnlkV04wU1c1Q2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdkR2hwY3k1MWMyVnljeWhwWkNrdWRtRnNkV1VnUFNCamJHOXVaU2gxYzJWeUtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlUZEhKMVkzUkpia0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkxURTVDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2gwYUdsekxuVnpaWEp6S0dsa0tTNTJZV3gxWlN3Z2V3b2dJQ0FnTHk4Z0lDQnVZVzFsT2lCMWMyVnlMbTVoYldVc0NpQWdJQ0F2THlBZ0lHRm5aVG9nZFhObGNpNWhaMlVzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREV3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVRkSEoxWTNSSmJrSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJoWjJVNklIVnpaWEl1WVdkbExBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxTjBjblZqZEVsdVFtOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl0TVRrS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tIUm9hWE11ZFhObGNuTW9hV1FwTG5aaGJIVmxMQ0I3Q2lBZ0lDQXZMeUFnSUc1aGJXVTZJSFZ6WlhJdWJtRnRaU3dLSUNBZ0lDOHZJQ0FnWVdkbE9pQjFjMlZ5TG1GblpTd0tJQ0FnSUM4dklIMHBDaUFnSUNBOVBRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMU4wY25WamRFbHVRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVk9aWGRWYzJWeUtHbGtPaUIxYVc1ME5qUXNJSFZ6WlhJNklGVnpaWElwT2lCaWIyOXNaV0Z1SUhzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12VTNSeWRXTjBTVzVDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlUzUnlkV04wU1c1Q2IzaE5ZWEF1WjJWMFZYTmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGVnpaWEk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VTNSeWRXTjBTVzVDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5DMHlOUW9nSUNBZ0x5OGdRSEpsWVdSdmJteDVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBWWE5sY2locFpEb2dkV2x1ZERZMEtUb2dWWE5sY2lCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUzUnlkV04wU1c1Q2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZFhObGNuTW9hV1FwTG5aaGJIVmxDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVM1J5ZFdOMFNXNUNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1ZYTmxjajRvZXlCclpYbFFjbVZtYVhnNklDZDFjMlZ5Y3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnpaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUzUnlkV04wU1c1Q2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZFhObGNuTW9hV1FwTG5aaGJIVmxDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMU4wY25WamRFbHVRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpRdE1qVUtJQ0FnSUM4dklFQnlaV0ZrYjI1c2VRb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGVnpaWElvYVdRNklIVnBiblEyTkNrNklGVnpaWElnZXdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlUZEhKMVkzUkpia0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVGRISjFZM1JKYmtKdmVFMWhjQzVqYUdWamExVnpaWEpGZUdsemRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYUdWamExVnpaWEpGZUdsemRITTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVM1J5ZFdOMFNXNUNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1Mwek1Bb2dJQ0FnTHk4Z1FISmxZV1J2Ym14NUNpQWdJQ0F2THlCd2RXSnNhV01nWTJobFkydFZjMlZ5UlhocGMzUnpLR2xrT2lCMWFXNTBOalFwT2lCaWIyOXNaV0Z1SUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5VGRISjFZM1JKYmtKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTUxYzJWeWN5aHBaQ2t1WlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVM1J5ZFdOMFNXNUNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1ZYTmxjajRvZXlCclpYbFFjbVZtYVhnNklDZDFjMlZ5Y3ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnpaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUzUnlkV04wU1c1Q2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZFhObGNuTW9hV1FwTG1WNGFYTjBjd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUzUnlkV04wU1c1Q2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPUzB6TUFvZ0lDQWdMeThnUUhKbFlXUnZibXg1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMmhsWTJ0VmMyVnlSWGhwYzNSektHbGtPaUIxYVc1ME5qUXBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlUzUnlkV04wU1c1Q2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVM1J5ZFdOMFNXNUNiM2hOWVhBdWRYQmtZWFJsVlhObGNrNWhiV1ZCYm1SQloyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVlZjMlZ5VG1GdFpVRnVaRUZuWlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5VGRISjFZM1JKYmtKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QndkV0pzYVdNZ2RYQmtZWFJsVlhObGNrNWhiV1ZCYm1SQloyVW9hV1E2SUhWcGJuUTJOQ3dnYm1GdFpUb2djM1J5YVc1bkxDQmhaMlU2SUhWcGJuUTJOQ2s2SUdKdmIyeGxZVzRnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZVM1J5ZFdOMFNXNUNiM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnZEdocGN5NTFjMlZ5Y3locFpDa3VkbUZzZFdVdWJtRnRaU0E5SUc1aGJXVUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFOMGNuVmpkRWx1UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklIQjFZbXhwWXlCMWMyVnljeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRlZ6WlhJK0tIc2dhMlY1VUhKbFptbDRPaUFuZFhObGNuTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMU4wY25WamRFbHVRbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUhSb2FYTXVkWE5sY25Nb2FXUXBMblpoYkhWbExtNWhiV1VnUFNCdVlXMWxDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5VGRISjFZM1JKYmtKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBhR2x6TG5WelpYSnpLR2xrS1M1MllXeDFaUzVoWjJVZ1BTQmhaMlVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERXdDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12VTNSeWRXTjBTVzVDYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29kR2hwY3k1MWMyVnljeWhwWkNrdWRtRnNkV1VzSUhzS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlUzUnlkV04wU1c1Q2IzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQzAwTVFvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2RHaHBjeTUxYzJWeWN5aHBaQ2t1ZG1Gc2RXVXNJSHNLSUNBZ0lDOHZJQ0FnYm1GdFpTd0tJQ0FnSUM4dklDQWdZV2RsTEFvZ0lDQWdMeThnZlNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklERXdDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFOMGNuVmpkRWx1UW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIQjFZbXhwWXlCMWNHUmhkR1ZWYzJWeVRtRnRaVUZ1WkVGblpTaHBaRG9nZFdsdWREWTBMQ0J1WVcxbE9pQnpkSEpwYm1jc0lHRm5aVG9nZFdsdWREWTBLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRb0lBQ1lEQlhWelpYSnpCUlVmZkhXQUJCVWZmSFV4RzBFQUt6RVpGRVF4R0VTQ0JBUjRQY3h3QkpNVU85RUVLOFRCSHdRNk5WSE9OaG9BamdRQUNRQXJBRHNBVXdBeEdSUXhHQlFRUXpZYUFSYzJHZ0pNRmloTVVFbThTRWxMQXI4akpMb1hUQ05iRWlJUVJDbXdJa00yR2dFWEZpaE1VTDVFS2t4UXNDSkROaG9CRnhZb1RGQzlSUUdBQVFBbFR3SlVLa3hRc0NKRE5ob0JGellhQWtsWEFnQTJHZ05KRjA4RUZpaE1VRW0rUkVra1dTVk1XRThGVUVzQnZFaExBVXkvU1NOUEJMdEp2a2hKSkZsTEFSVlNWd0lBVHdNU1RDTWt1aGRQQWhJUVJDbXdJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
