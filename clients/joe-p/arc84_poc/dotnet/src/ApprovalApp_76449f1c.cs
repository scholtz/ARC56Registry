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

namespace Arc56.Generated.joe_p.arc84_poc.ApprovalApp_76449f1c
{


    public class ApprovalAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ApprovalAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AddressToken : AVMObjectType
            {
                public Algorand.Address Addr { get; set; }

                public ulong App { get; set; }

                public ulong Id { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddr.From(Addr);
                    ret.AddRange(vAddr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApp.From(App);
                    ret.AddRange(vApp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AddressToken Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AddressToken();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddr = vAddr.ToValue();
                    if (valueAddr is Algorand.Address vAddrValue) { ret.Addr = vAddrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AddressToken);
                }
                public bool Equals(AddressToken? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AddressToken left, AddressToken right)
                {
                    return EqualityComparer<AddressToken>.Default.Equals(left, right);
                }
                public static bool operator !=(AddressToken left, AddressToken right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="addrToken"> AddressToken</param>
        public async Task<bool> ApproveRequest(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 71, 14, 64 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            var result = await base.CallApp(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApproveRequest_Transactions(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 71, 14, 64 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="addrToken"> AddressToken</param>
        public async Task<bool> ApproveRequestRemoval(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 151, 146, 217 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            var result = await base.CallApp(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApproveRequestRemoval_Transactions(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 151, 146, 217 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="addrToken"> AddressToken</param>
        public async Task<bool> ApproveDeclaration(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 138, 105, 184 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            var result = await base.CallApp(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApproveDeclaration_Transactions(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 138, 105, 184 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="addrToken"> AddressToken</param>
        public async Task<bool> ApproveDeclarationRemoval(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 113, 213, 1 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            var result = await base.CallApp(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApproveDeclarationRemoval_Transactions(Algorand.Address sender, Structs.AddressToken addrToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 113, 213, 1 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderAbi, addrToken }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBcHByb3ZhbEFwcCIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWRkcmVzc1Rva2VuIjpbeyJuYW1lIjoiYWRkciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYXBwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJhcHByb3ZlUmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFkZHJlc3NUb2tlbiIsIm5hbWUiOiJhZGRyVG9rZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImFwcHJvdmVSZXF1ZXN0UmVtb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFkZHJlc3NUb2tlbiIsIm5hbWUiOiJhZGRyVG9rZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImFwcHJvdmVEZWNsYXJhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFkZHJlc3NUb2tlbiIsIm5hbWUiOiJhZGRyVG9rZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImFwcHJvdmVEZWNsYXJhdGlvblJlbW92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBZGRyZXNzVG9rZW4iLCJuYW1lIjoiYWRkclRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzEsMiwzLDQsNSw2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzcsOCw5LDEwLDExLDEyLDEzLDE0LDE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzE2LDE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOlsxOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTEifSx7InBjIjpbMTksMjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzIxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOlsyMiwyM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTEifSx7InBjIjpbMjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5LDQwLDQxLDQyLDQzLDQ0LDQ1LDQ2LDQ3LDQ4LDQ5LDUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOls1MV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMyJ9LHsicGMiOls1Myw1NCw1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzMsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6WzU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMyJ9LHsicGMiOls1OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMCAoYWRkclRva2VuKSBmb3IgYXBwcm92ZVJlcXVlc3QgbXVzdCBiZSBhIChhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwidGVhbCI6NDAsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbNjEsNjIsNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQzLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6WzY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMyJ9LHsicGMiOls2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDUsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ2LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6WzY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Nywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMyJ9LHsicGMiOls2OF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDEgKHNlbmRlcikgZm9yIGFwcHJvdmVSZXF1ZXN0IG11c3QgYmUgYSBhZGRyZXNzIiwidGVhbCI6NTAsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbNjksNzAsNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUzLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMyJ9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbNzQsNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMyJ9LHsicGMiOls3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU5LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6Wzc5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMyJ9LHsicGMiOls4MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbODEsODIsODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjEzIn0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxNCJ9LHsicGMiOls4NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzAsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTMifSx7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6Wzg3LDg4LDg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOls5MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzksInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTgifSx7InBjIjpbOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgwLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOls5M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODIsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTgifSx7InBjIjpbOTRdLCJlcnJvck1lc3NhZ2UiOiJhcmd1bWVudCAwIChhZGRyVG9rZW4pIGZvciBhcHByb3ZlUmVxdWVzdFJlbW92YWwgbXVzdCBiZSBhIChhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwidGVhbCI6ODUsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTgifSx7InBjIjpbOTUsOTYsOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg4LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4OSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOls5OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTAsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTgifSx7InBjIjpbMTAwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkyLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6WzEwMl0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDEgKHNlbmRlcikgZm9yIGFwcHJvdmVSZXF1ZXN0UmVtb3ZhbCBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjk1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6WzEwMywxMDQsMTA1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk5LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6WzEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAwLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6WzEwOCwxMDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMiwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNiwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxOCJ9LHsicGMiOlsxMTUsMTE2LDExN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEwLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6WzExOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE0LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE5In0seyJwYyI6WzExOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjE4In0seyJwYyI6WzEyMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIwLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzEyMSwxMjIsMTIzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjMsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjIifSx7InBjIjpbMTI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjQsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjIifSx7InBjIjpbMTI1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjUsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjIifSx7InBjIjpbMTI2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjYsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjIifSx7InBjIjpbMTI3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjcsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjIifSx7InBjIjpbMTI4XSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMCAoYWRkclRva2VuKSBmb3IgYXBwcm92ZURlY2xhcmF0aW9uIG11c3QgYmUgYSAoYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInRlYWwiOjEzMCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxMjksMTMwLDEzMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMzLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzEzMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM0LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzEzNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM2LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzEzNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM3LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzEzNl0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDEgKHNlbmRlcikgZm9yIGFwcHJvdmVEZWNsYXJhdGlvbiBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjE0MCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxMzcsMTM4LDEzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQzLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzE0MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ0LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzE0MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzE0MiwxNDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0Niwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0Nywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0OCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0OSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxNDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1MCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1MSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxNDksMTUwLDE1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjIyIn0seyJwYyI6WzE1MiwxNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1OSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMyJ9LHsicGMiOlsxNTQsMTU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNjAsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjMifSx7InBjIjpbMTU2LDE1NywxNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2MSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMyJ9LHsicGMiOlsxNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2Miwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMyJ9LHsicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2Mywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyMiJ9LHsicGMiOlsxNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2OCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxNjIsMTYzLDE2NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcxLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcyLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTczLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTc0LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE2OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTc1LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE2OV0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGFkZHJUb2tlbikgZm9yIGFwcHJvdmVEZWNsYXJhdGlvblJlbW92YWwgbXVzdCBiZSBhIChhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwidGVhbCI6MTc4LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE3MCwxNzEsMTcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxODEsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjYifSx7InBjIjpbMTczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxODIsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjYifSx7InBjIjpbMTc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxODMsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjYifSx7InBjIjpbMTc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxODQsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjYifSx7InBjIjpbMTc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxODUsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjYifSx7InBjIjpbMTc3XSwiZXJyb3JNZXNzYWdlIjoiYXJndW1lbnQgMSAoc2VuZGVyKSBmb3IgYXBwcm92ZURlY2xhcmF0aW9uUmVtb3ZhbCBtdXN0IGJlIGEgYWRkcmVzcyIsInRlYWwiOjE4OCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxNzgsMTc5LDE4MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTkxLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTkyLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTkzLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE4MywxODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5NCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5NSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5Niwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5Nywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5OCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5OSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsxOTAsMTkxLDE5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAzLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjI2In0seyJwYyI6WzE5MywxOTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwNywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNyJ9LHsicGMiOlsxOTUsMTk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMDgsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MjcifSx7InBjIjpbMTk3LDE5OCwxOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwOSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNyJ9LHsicGMiOlsyMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxMCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNyJ9LHsicGMiOlsyMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxMSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoyNiJ9LHsicGMiOlsyMDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxNCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOlsyMDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxNSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOlsyMDQsMjA1LDIwNiwyMDcsMjA4LDIwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjE4LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzIxMCwyMTEsMjEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMTksInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTEifSx7InBjIjpbMjEzLDIxNCwyMTUsMjE2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMjAsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTEifSx7InBjIjpbMjE3XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6MjIzLCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzIxOCwyMTksMjIwLDIyMSwyMjIsMjIzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMjYsInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTEifSx7InBjIjpbMjI0LDIyNSwyMjYsMjI3LDIyOCwyMjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIyNywic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOlsyMzAsMjMxLDIzMiwyMzMsMjM0LDIzNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjI4LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn0seyJwYyI6WzIzNiwyMzcsMjM4LDIzOSwyNDAsMjQxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMjksInNvdXJjZSI6ImNvbnRyYWN0cy9EZWNsYXJhdGlvblJlZ2lzdHJ5LmFsZ28udHM6MTEifSx7InBjIjpbMjQyLDI0MywyNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIzMCwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOlsyNDUsMjQ2LDI0NywyNDgsMjQ5LDI1MCwyNTEsMjUyLDI1MywyNTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIzMSwic291cmNlIjoiY29udHJhY3RzL0RlY2xhcmF0aW9uUmVnaXN0cnkuYWxnby50czoxMSJ9LHsicGMiOlsyNTVdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6MjM0LCJzb3VyY2UiOiJjb250cmFjdHMvRGVjbGFyYXRpb25SZWdpc3RyeS5hbGdvLnRzOjExIn1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElEQWdNeklnTkRnS1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJREI0TURBS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTJMak1LTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLbU55WldGMFpWOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJBb0tLazVQVkY5SlRWQk1SVTFGVGxSRlJEb0tDUzh2SUZSb1pTQnlaWEYxWlhOMFpXUWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdseklHTnZiblJ5WVdOMExpQkJjbVVnZVc5MUlIVnphVzVuSUhSb1pTQmpiM0p5WldOMElFOXVRMjl0Y0d4bGRHVS9JRVJwWkNCNWIzVWdjMlYwSUhsdmRYSWdZWEJ3SUVsRVB3b0paWEp5Q2dvdkx5QmhjSEJ5YjNabFVtVnhkV1Z6ZENoaFpHUnlaWE56TENoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBLV0p2YjJ3S0ttRmlhVjl5YjNWMFpWOWhjSEJ5YjNabFVtVnhkV1Z6ZERvS0NTOHZJRlJvWlNCQlFra2djbVYwZFhKdUlIQnlaV1pwZUFvSllubDBaV01nTUNBdkx5QXdlREUxTVdZM1l6YzFDZ29KTHk4Z1lXUmtjbFJ2YTJWdU9pQW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1FvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29KWkhWd0NnbHNaVzRLQ1dsdWRHTWdNeUF2THlBME9Bb0pQVDBLQ2drdkx5QmhjbWQxYldWdWRDQXdJQ2hoWkdSeVZHOXJaVzRwSUdadmNpQmhjSEJ5YjNabFVtVnhkV1Z6ZENCdGRYTjBJR0psSUdFZ0tHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2tLQ1dGemMyVnlkQW9LQ1M4dklITmxibVJsY2pvZ1lXUmtjbVZ6Y3dvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9KWkhWd0NnbHNaVzRLQ1dsdWRHTWdNaUF2THlBek1nb0pQVDBLQ2drdkx5QmhjbWQxYldWdWRDQXhJQ2h6Wlc1a1pYSXBJR1p2Y2lCaGNIQnliM1psVW1WeGRXVnpkQ0J0ZFhOMElHSmxJR0VnWVdSa2NtVnpjd29KWVhOelpYSjBDZ29KTHk4Z1pYaGxZM1YwWlNCaGNIQnliM1psVW1WeGRXVnpkQ2hoWkdSeVpYTnpMQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcEtXSnZiMndLQ1dOaGJHeHpkV0lnWVhCd2NtOTJaVkpsY1hWbGMzUUtDV0o1ZEdWaklERWdMeThnTUhnd01Bb0phVzUwWXlBeElDOHZJREFLQ1hWdVkyOTJaWElnTWdvSmMyVjBZbWwwQ2dsamIyNWpZWFFLQ1d4dlp3b0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z1lYQndjbTkyWlZKbGNYVmxjM1FvYzJWdVpHVnlPaUJCWkdSeVpYTnpMQ0JoWkdSeVZHOXJaVzQ2SUVGa1pISmxjM05VYjJ0bGJpazZJR0p2YjJ4bFlXNEtZWEJ3Y205MlpWSmxjWFZsYzNRNkNnbHdjbTkwYnlBeUlERUtDZ2t2THlCamIyNTBjbUZqZEhNdlJHVmpiR0Z5WVhScGIyNVNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTBDZ2t2THlCeVpYUjFjbTRnZEhKMVpUc0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUnpkV0lLQ2k4dklHRndjSEp2ZG1WU1pYRjFaWE4wVW1WdGIzWmhiQ2hoWkdSeVpYTnpMQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcEtXSnZiMndLS21GaWFWOXliM1YwWlY5aGNIQnliM1psVW1WeGRXVnpkRkpsYlc5MllXdzZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDV0o1ZEdWaklEQWdMeThnTUhneE5URm1OMk0zTlFvS0NTOHZJR0ZrWkhKVWIydGxiam9nS0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5Da0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0NXUjFjQW9KYkdWdUNnbHBiblJqSURNZ0x5OGdORGdLQ1QwOUNnb0pMeThnWVhKbmRXMWxiblFnTUNBb1lXUmtjbFJ2YTJWdUtTQm1iM0lnWVhCd2NtOTJaVkpsY1hWbGMzUlNaVzF2ZG1Gc0lHMTFjM1FnWW1VZ1lTQW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1FvSllYTnpaWEowQ2dvSkx5OGdjMlZ1WkdWeU9pQmhaR1J5WlhOekNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsa2RYQUtDV3hsYmdvSmFXNTBZeUF5SUM4dklETXlDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREVnS0hObGJtUmxjaWtnWm05eUlHRndjSEp2ZG1WU1pYRjFaWE4wVW1WdGIzWmhiQ0J0ZFhOMElHSmxJR0VnWVdSa2NtVnpjd29KWVhOelpYSjBDZ29KTHk4Z1pYaGxZM1YwWlNCaGNIQnliM1psVW1WeGRXVnpkRkpsYlc5MllXd29ZV1JrY21WemN5d29ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NsaWIyOXNDZ2xqWVd4c2MzVmlJR0Z3Y0hKdmRtVlNaWEYxWlhOMFVtVnRiM1poYkFvSllubDBaV01nTVNBdkx5QXdlREF3Q2dscGJuUmpJREVnTHk4Z01Bb0pkVzVqYjNabGNpQXlDZ2x6WlhSaWFYUUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJoY0hCeWIzWmxVbVZ4ZFdWemRGSmxiVzkyWVd3b2MyVnVaR1Z5T2lCQlpHUnlaWE56TENCaFpHUnlWRzlyWlc0NklFRmtaSEpsYzNOVWIydGxiaWs2SUdKdmIyeGxZVzRLWVhCd2NtOTJaVkpsY1hWbGMzUlNaVzF2ZG1Gc09nb0pjSEp2ZEc4Z01pQXhDZ29KTHk4Z1kyOXVkSEpoWTNSekwwUmxZMnhoY21GMGFXOXVVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hPUW9KTHk4Z2NtVjBkWEp1SUhSeWRXVTdDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBjM1ZpQ2dvdkx5QmhjSEJ5YjNabFJHVmpiR0Z5WVhScGIyNG9ZV1JrY21WemN5d29ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NsaWIyOXNDaXBoWW1sZmNtOTFkR1ZmWVhCd2NtOTJaVVJsWTJ4aGNtRjBhVzl1T2dvSkx5OGdWR2hsSUVGQ1NTQnlaWFIxY200Z2NISmxabWw0Q2dsaWVYUmxZeUF3SUM4dklEQjRNVFV4Wmpkak56VUtDZ2t2THlCaFpHUnlWRzlyWlc0NklDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXpJQzh2SURRNENnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElEQWdLR0ZrWkhKVWIydGxiaWtnWm05eUlHRndjSEp2ZG1WRVpXTnNZWEpoZEdsdmJpQnRkWE4wSUdKbElHRWdLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNrS0NXRnpjMlZ5ZEFvS0NTOHZJSE5sYm1SbGNqb2dZV1JrY21WemN3b0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlpIVndDZ2xzWlc0S0NXbHVkR01nTWlBdkx5QXpNZ29KUFQwS0Nna3ZMeUJoY21kMWJXVnVkQ0F4SUNoelpXNWtaWElwSUdadmNpQmhjSEJ5YjNabFJHVmpiR0Z5WVhScGIyNGdiWFZ6ZENCaVpTQmhJR0ZrWkhKbGMzTUtDV0Z6YzJWeWRBb0tDUzh2SUdWNFpXTjFkR1VnWVhCd2NtOTJaVVJsWTJ4aGNtRjBhVzl1S0dGa1pISmxjM01zS0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5Da3BZbTl2YkFvSlkyRnNiSE4xWWlCaGNIQnliM1psUkdWamJHRnlZWFJwYjI0S0NXSjVkR1ZqSURFZ0x5OGdNSGd3TUFvSmFXNTBZeUF4SUM4dklEQUtDWFZ1WTI5MlpYSWdNZ29KYzJWMFltbDBDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWVhCd2NtOTJaVVJsWTJ4aGNtRjBhVzl1S0hObGJtUmxjam9nUVdSa2NtVnpjeXdnWVdSa2NsUnZhMlZ1T2lCQlpHUnlaWE56Vkc5clpXNHBPaUJpYjI5c1pXRnVDbUZ3Y0hKdmRtVkVaV05zWVhKaGRHbHZiam9LQ1hCeWIzUnZJRElnTVFvS0NTOHZJR052Ym5SeVlXTjBjeTlFWldOc1lYSmhkR2x2YmxKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpNS0NTOHZJSEpsZEhWeWJpQnpaVzVrWlhJZ1BUMDlJR0ZrWkhKVWIydGxiaTVoWkdSeU93b0pabkpoYldWZlpHbG5JQzB4SUM4dklITmxibVJsY2pvZ1FXUmtjbVZ6Y3dvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdGa1pISlViMnRsYmpvZ1FXUmtjbVZ6YzFSdmEyVnVDZ2xsZUhSeVlXTjBJREFnTXpJS0NUMDlDZ2x5WlhSemRXSUtDaTh2SUdGd2NISnZkbVZFWldOc1lYSmhkR2x2YmxKbGJXOTJZV3dvWVdSa2NtVnpjeXdvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTbGliMjlzQ2lwaFltbGZjbTkxZEdWZllYQndjbTkyWlVSbFkyeGhjbUYwYVc5dVVtVnRiM1poYkRvS0NTOHZJRlJvWlNCQlFra2djbVYwZFhKdUlIQnlaV1pwZUFvSllubDBaV01nTUNBdkx5QXdlREUxTVdZM1l6YzFDZ29KTHk4Z1lXUmtjbFJ2YTJWdU9pQW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1FvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29KWkhWd0NnbHNaVzRLQ1dsdWRHTWdNeUF2THlBME9Bb0pQVDBLQ2drdkx5QmhjbWQxYldWdWRDQXdJQ2hoWkdSeVZHOXJaVzRwSUdadmNpQmhjSEJ5YjNabFJHVmpiR0Z5WVhScGIyNVNaVzF2ZG1Gc0lHMTFjM1FnWW1VZ1lTQW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1FvSllYTnpaWEowQ2dvSkx5OGdjMlZ1WkdWeU9pQmhaR1J5WlhOekNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsa2RYQUtDV3hsYmdvSmFXNTBZeUF5SUM4dklETXlDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREVnS0hObGJtUmxjaWtnWm05eUlHRndjSEp2ZG1WRVpXTnNZWEpoZEdsdmJsSmxiVzkyWVd3Z2JYVnpkQ0JpWlNCaElHRmtaSEpsYzNNS0NXRnpjMlZ5ZEFvS0NTOHZJR1Y0WldOMWRHVWdZWEJ3Y205MlpVUmxZMnhoY21GMGFXOXVVbVZ0YjNaaGJDaGhaR1J5WlhOekxDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwS1dKdmIyd0tDV05oYkd4emRXSWdZWEJ3Y205MlpVUmxZMnhoY21GMGFXOXVVbVZ0YjNaaGJBb0pZbmwwWldNZ01TQXZMeUF3ZURBd0NnbHBiblJqSURFZ0x5OGdNQW9KZFc1amIzWmxjaUF5Q2dselpYUmlhWFFLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCaGNIQnliM1psUkdWamJHRnlZWFJwYjI1U1pXMXZkbUZzS0hObGJtUmxjam9nUVdSa2NtVnpjeXdnWVdSa2NsUnZhMlZ1T2lCQlpHUnlaWE56Vkc5clpXNHBPaUJpYjI5c1pXRnVDbUZ3Y0hKdmRtVkVaV05zWVhKaGRHbHZibEpsYlc5MllXdzZDZ2x3Y205MGJ5QXlJREVLQ2drdkx5QmpiMjUwY21GamRITXZSR1ZqYkdGeVlYUnBiMjVTWldkcGMzUnllUzVoYkdkdkxuUnpPakkzQ2drdkx5QnlaWFIxY200Z2MyVnVaR1Z5SUQwOVBTQmhaR1J5Vkc5clpXNHVZV1JrY2pzS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCelpXNWtaWEk2SUVGa1pISmxjM01LQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJoWkdSeVZHOXJaVzQ2SUVGa1pISmxjM05VYjJ0bGJnb0paWGgwY21GamRDQXdJRE15Q2drOVBRb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlRGsyTkRjd1pUUXdJQzh2SUcxbGRHaHZaQ0FpWVhCd2NtOTJaVkpsY1hWbGMzUW9ZV1JrY21WemN5d29ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NsaWIyOXNJZ29KY0hWemFHSjVkR1Z6SURCNFpqWTVOemt5WkRrZ0x5OGdiV1YwYUc5a0lDSmhjSEJ5YjNabFVtVnhkV1Z6ZEZKbGJXOTJZV3dvWVdSa2NtVnpjeXdvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTbGliMjlzSWdvSmNIVnphR0o1ZEdWeklEQjRaVE00WVRZNVlqZ2dMeThnYldWMGFHOWtJQ0poY0hCeWIzWmxSR1ZqYkdGeVlYUnBiMjRvWVdSa2NtVnpjeXdvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTbGliMjlzSWdvSmNIVnphR0o1ZEdWeklEQjRNMk0zTVdRMU1ERWdMeThnYldWMGFHOWtJQ0poY0hCeWIzWmxSR1ZqYkdGeVlYUnBiMjVTWlcxdmRtRnNLR0ZrWkhKbGMzTXNLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNrcFltOXZiQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZZWEJ3Y205MlpWSmxjWFZsYzNRZ0ttRmlhVjl5YjNWMFpWOWhjSEJ5YjNabFVtVnhkV1Z6ZEZKbGJXOTJZV3dnS21GaWFWOXliM1YwWlY5aGNIQnliM1psUkdWamJHRnlZWFJwYjI0Z0ttRmlhVjl5YjNWMFpWOWhjSEJ5YjNabFJHVmpiR0Z5WVhScGIyNVNaVzF2ZG1Gc0Nnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTmhiR3dnVG05UGNBb0paWEp5IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVFBZ01DWUNCQlVmZkhVQkFERVlGSUVHQ3pFWkNJME1BS2NBQUFBQUFBQUFBQUFBQUprQUFBQUFBQUFBQUFBQUFDZzJHZ0pKRlNVU1JEWWFBVWtWSkJKRWlBQUpLU05QQWxSUXNDSkRpZ0lCSW9rb05ob0NTUlVsRWtRMkdnRkpGU1FTUklnQUNTa2pUd0pVVUxBaVE0b0NBU0tKS0RZYUFra1ZKUkpFTmhvQlNSVWtFa1NJQUFrcEkwOENWRkN3SWtPS0FnR0wvNHYrVndBZ0Vva29OaG9DU1JVbEVrUTJHZ0ZKRlNRU1JJZ0FDU2tqVHdKVVVMQWlRNG9DQVl2L2kvNVhBQ0FTaVNKRGdBUzRSSHMyTmhvQWpnSC84UUNBQkpaSERrQ0FCUGFYa3RtQUJPT0thYmlBQkR4eDFRRTJHZ0NPQlA4MS8xZi9lZitpQUE9PSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
