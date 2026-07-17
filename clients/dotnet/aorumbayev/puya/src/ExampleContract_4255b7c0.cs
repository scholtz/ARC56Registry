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

namespace Arc56.Generated.aorumbayev.puya.ExampleContract_4255b7c0
{


    public class ExampleContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ExampleContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class UserStruct : AVMObjectType
            {
                public string Name { get; set; }

                public ulong Id { get; set; }

                public ulong Asset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UserStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new UserStruct();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UserStruct);
                }
                public bool Equals(UserStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UserStruct left, UserStruct right)
                {
                    return EqualityComparer<UserStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(UserStruct left, UserStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> UserStruct</param>
        public async Task AddUser(Structs.UserStruct user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 133, 52, 189 };

            var result = await base.CallApp(new List<object> { abiHandle, user }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddUser_Transactions(Structs.UserStruct user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 133, 52, 189 };

            return await base.MakeTransactionList(new List<object> { abiHandle, user }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user_id"> </param>
        /// <param name="asset"> </param>
        public async Task AttachAssetToUser(ulong asset, ulong user_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 78, 180, 233, 241 };
            var user_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); user_idAbi.From(user_id);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, user_idAbi, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AttachAssetToUser_Transactions(ulong asset, ulong user_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 78, 180, 233, 241 };
            var user_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); user_idAbi.From(user_id);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, user_idAbi, assetRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user_id"> </param>
        public async Task<Structs.UserStruct> GetUser(ulong user_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 84, 88, 128 };
            var user_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); user_idAbi.From(user_id);

            var result = await base.CallApp(new List<object> { abiHandle, user_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.UserStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUser_Transactions(ulong user_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 84, 88, 128 };
            var user_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); user_idAbi.From(user_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, user_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXhhbXBsZUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlVzZXJTdHJ1Y3QiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJhZGRfdXNlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoc3RyaW5nLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVXNlclN0cnVjdCIsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImF0dGFjaF9hc3NldF90b191c2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VzZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlcl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVXNlclN0cnVjdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE2LDE0NV0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMsNjcsODhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjRdLCJlcnJvck1lc3NhZ2UiOiJVc2VyIHdpdGggaWQgbXVzdCBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzgsMTYwXSwiZXJyb3JNZXNzYWdlIjoiVXNlciB3aXRoIHRoYXQgaWQgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDhdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0Niw3MCw5MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4Q2lBZ0lDQXZMeUJ6ZEhKMVkzUmZhVzVmWW05NEwyTnZiblJ5WVdOMExuQjVPakV3Q2lBZ0lDQXZMeUJqYkdGemN5QkZlR0Z0Y0d4bFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEE0Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WkdFNE5UTTBZbVFnTUhnMFpXSTBaVGxtTVNBd2VERTJOVFExT0Rnd0lDOHZJRzFsZEdodlpDQWlZV1JrWDNWelpYSW9LSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwS1NsMmIybGtJaXdnYldWMGFHOWtJQ0poZEhSaFkyaGZZWE56WlhSZmRHOWZkWE5sY2loMWFXNTBOalFzWVhOelpYUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYM1Z6WlhJb2RXbHVkRFkwS1NoemRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyRmtaRjkxYzJWeVgzSnZkWFJsUURNZ2JXRnBibDloZEhSaFkyaGZZWE56WlhSZmRHOWZkWE5sY2w5eWIzVjBaVUEwSUcxaGFXNWZaMlYwWDNWelpYSmZjbTkxZEdWQU5Rb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5T2dvZ0lDQWdMeThnYzNSeWRXTjBYMmx1WDJKdmVDOWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnWTJ4aGMzTWdSWGhoYlhCc1pVTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vYVc1MElEQWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOTFjMlZ5WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6ZEhKMVkzUmZhVzVmWW05NEwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpkSEoxWTNSZmFXNWZZbTk0TDJOdmJuUnlZV04wTG5CNU9qRXdDaUFnSUNBdkx5QmpiR0Z6Y3lCRmVHRnRjR3hsUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITjBjblZqZEY5cGJsOWliM2d2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MWMyVnlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllYUjBZV05vWDJGemMyVjBYM1J2WDNWelpYSmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITjBjblZqZEY5cGJsOWliM2d2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOMGNuVmpkRjlwYmw5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRBS0lDQWdJQzh2SUdOc1lYTnpJRVY0WVcxd2JHVkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYTnpaWFJ6Q2lBZ0lDQXZMeUJ6ZEhKMVkzUmZhVzVmWW05NEwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCaGRIUmhZMmhmWVhOelpYUmZkRzlmZFhObGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aFpHUmZkWE5sY2w5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzNSeWRXTjBYMmx1WDJKdmVDOWpiMjUwY21GamRDNXdlVG96TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjM1J5ZFdOMFgybHVYMkp2ZUM5amIyNTBjbUZqZEM1d2VUb3hNQW9nSUNBZ0x5OGdZMnhoYzNNZ1JYaGhiWEJzWlVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpkSEoxWTNSZmFXNWZZbTk0TDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJoWkdSZmRYTmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBT0RvS0lDQWdJQzh2SUhOMGNuVmpkRjlwYmw5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TVRBS0lDQWdJQzh2SUdOc1lYTnpJRVY0WVcxd2JHVkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGVHRnRjR3hsY3k1emRISjFZM1JmYVc1ZlltOTRMbU52Ym5SeVlXTjBMa1Y0WVcxd2JHVkRiMjUwY21GamRDNWhaR1JmZFhObGNpaDFjMlZ5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWVdSa1gzVnpaWEk2Q2lBZ0lDQXZMeUJ6ZEhKMVkzUmZhVzVmWW05NEwyTnZiblJ5WVdOMExuQjVPak13TFRNeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHRmtaRjkxYzJWeUtITmxiR1lzSUhWelpYSTZJRlZ6WlhKVGRISjFZM1FwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITjBjblZqZEY5cGJsOWliM2d2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdjMlZzWmk1aWIzaGZaWGhwYzNSektIVnpaWEl1YVdRcExDQWlWWE5sY2lCM2FYUm9JR2xrSUcxMWMzUWdibTkwSUdWNGFYTjBJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURJZ09DQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOMGNuVmpkRjlwYmw5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUY5a1lYUmhMQ0JsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0hWelpYSmZhV1F1WW5sMFpYTXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzNSeWRXTjBYMmx1WDJKdmVDOWpiMjUwY21GamRDNXdlVG96TWdvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCelpXeG1MbUp2ZUY5bGVHbHpkSE1vZFhObGNpNXBaQ2tzSUNKVmMyVnlJSGRwZEdnZ2FXUWdiWFZ6ZENCdWIzUWdaWGhwYzNRaUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWWE5sY2lCM2FYUm9JR2xrSUcxMWMzUWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpkSEoxWTNSZmFXNWZZbTk0TDJOdmJuUnlZV04wTG5CNU9qSXdMVEl4Q2lBZ0lDQXZMeUFqSUVSbGJHVjBaU0JsZUdsemRHbHVaeUJrWVhSaExDQnpieUIzWlNCa2IyNG5kQ0JvWVhabElIUnZJSGR2Y25KNUlHRmliM1YwSUhKbGMybDZhVzVuSUhSb1pTQmliM2dLSUNBZ0lDOHZJRzl3TGtKdmVDNWtaV3hsZEdVb1ltOTRYMnRsZVNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemRISjFZM1JmYVc1ZlltOTRMMk52Ym5SeVlXTjBMbkI1T2pJekNpQWdJQ0F2THlCdmNDNUNiM2d1Y0hWMEtHSnZlRjlyWlhrc0lIVnpaWEl1WW5sMFpYTXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR1Y0WVcxd2JHVnpMbk4wY25WamRGOXBibDlpYjNndVkyOXVkSEpoWTNRdVJYaGhiWEJzWlVOdmJuUnlZV04wTG1GMGRHRmphRjloYzNObGRGOTBiMTkxYzJWeUtIVnpaWEpmYVdRNklHSjVkR1Z6TENCaGMzTmxkRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BoZEhSaFkyaGZZWE56WlhSZmRHOWZkWE5sY2pvS0lDQWdJQzh2SUhOMGNuVmpkRjlwYmw5aWIzZ3ZZMjl1ZEhKaFkzUXVjSGs2TXpVdE16WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdZWFIwWVdOb1gyRnpjMlYwWDNSdlgzVnpaWElvYzJWc1ppd2dkWE5sY2w5cFpEb2dZWEpqTkM1VlNXNTBOalFzSUdGemMyVjBPaUJCYzNObGRDa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzNSeWRXTjBYMmx1WDJKdmVDOWpiMjUwY21GamRDNXdlVG94TXdvZ0lDQWdMeThnWW05NFgyUmhkR0VzSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb2RYTmxjbDlwWkM1aWVYUmxjeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnYzNSeWRXTjBYMmx1WDJKdmVDOWpiMjUwY21GamRDNXdlVG94TkFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbFZ6WlhJZ2QybDBhQ0IwYUdGMElHbGtJR1J2WlhNZ2JtOTBJR1Y0YVhOMElnb2dJQ0FnWVhOelpYSjBJQzh2SUZWelpYSWdkMmwwYUNCMGFHRjBJR2xrSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpkSEoxWTNSZmFXNWZZbTk0TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QjFjMlZ5TG1GemMyVjBJRDBnWVhKak5DNVZTVzUwTmpRb1lYTnpaWFF1YVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREV3Q2lBZ0lDQXZMeUJ6ZEhKMVkzUmZhVzVmWW05NEwyTnZiblJ5WVdOMExuQjVPakU1Q2lBZ0lDQXZMeUJpYjNoZmEyVjVJRDBnZFhObGNpNXBaQzVpZVhSbGN3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnT0NBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE4wY25WamRGOXBibDlpYjNndlkyOXVkSEpoWTNRdWNIazZNakF0TWpFS0lDQWdJQzh2SUNNZ1JHVnNaWFJsSUdWNGFYTjBhVzVuSUdSaGRHRXNJSE52SUhkbElHUnZiaWQwSUdoaGRtVWdkRzhnZDI5eWNua2dZV0p2ZFhRZ2NtVnphWHBwYm1jZ2RHaGxJR0p2ZUFvZ0lDQWdMeThnYjNBdVFtOTRMbVJsYkdWMFpTaGliM2hmYTJWNUtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITjBjblZqZEY5cGJsOWliM2d2WTI5dWRISmhZM1F1Y0hrNk1qTUtJQ0FnSUM4dklHOXdMa0p2ZUM1d2RYUW9ZbTk0WDJ0bGVTd2dkWE5sY2k1aWVYUmxjeWtLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdWNFlXMXdiR1Z6TG5OMGNuVmpkRjlwYmw5aWIzZ3VZMjl1ZEhKaFkzUXVSWGhoYlhCc1pVTnZiblJ5WVdOMExtZGxkRjkxYzJWeUtIVnpaWEpmYVdRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBYM1Z6WlhJNkNpQWdJQ0F2THlCemRISjFZM1JmYVc1ZlltOTRMMk52Ym5SeVlXTjBMbkI1T2pReExUUXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5MWMyVnlLSE5sYkdZc0lIVnpaWEpmYVdRNklHRnlZelF1VlVsdWREWTBLU0F0UGlCVmMyVnlVM1J5ZFdOME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6ZEhKMVkzUmZhVzVmWW05NEwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJpYjNoZlpHRjBZU3dnWlhocGMzUnpJRDBnYjNBdVFtOTRMbWRsZENoMWMyVnlYMmxrTG1KNWRHVnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQXZMeUJ6ZEhKMVkzUmZhVzVmWW05NEwyTnZiblJ5WVdOMExuQjVPakUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlWWE5sY2lCM2FYUm9JSFJvWVhRZ2FXUWdaRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JoYzNObGNuUWdMeThnVlhObGNpQjNhWFJvSUhSb1lYUWdhV1FnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITjBjblZqZEY5cGJsOWliM2d2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbkpsWVdSZlpuSnZiVjlpYjNnb2RYTmxjbDlwWkNrS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFURWJRUUJiZ2dNRTJvVTB2UVJPdE9ueEJCWlVXSUEyR2dDT0F3QXdBQnNBQTRFQVF6RVpGRVF4R0VRMkdnR0lBR1dBQkJVZmZIVk1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnSVh3RENJQURFaVF6RVpGRVF4R0VRMkdnR0lBQTBpUXpFWlFQKzhNUmdVUkNKRGlnRUFpLzlYQWdoSnZrVUJGRVJKdkVpTC83K0ppZ0lBaS82K1JJdi9GbHdLU1ZjQ0NFbThTRXkvaVlvQkFZdi92a1NKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
