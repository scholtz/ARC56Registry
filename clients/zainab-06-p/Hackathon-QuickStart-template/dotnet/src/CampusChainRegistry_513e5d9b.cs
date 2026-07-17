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

namespace Arc56.Generated.zainab_06_p.Hackathon_QuickStart_template.CampusChainRegistry_513e5d9b
{


    //
    // 
    //    Registry contract storing app IDs for fundraising campaigns and ticketing events.
    //    Uses box storage to handle large lists (>128 items).
    //    Boxes are auto-created on first registration - no initialization needed.
    //    
    //
    public class CampusChainRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CampusChainRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetTotalCountsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetTotalCountsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetTotalCountsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetTotalCountsReturn);
                }
                public bool Equals(GetTotalCountsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetTotalCountsReturn left, GetTotalCountsReturn right)
                {
                    return EqualityComparer<GetTotalCountsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetTotalCountsReturn left, GetTotalCountsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Register a new fundraising campaign app ID.
        ///Can only be called by the app creator (prevents spam).
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task RegisterFundraiser(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 186, 3, 62 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterFundraiser_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 186, 3, 62 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new ticketing event app ID.
        ///Can only be called by the app creator (prevents spam).
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task RegisterTicketing(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 203, 109, 224 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterTicketing_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 203, 109, 224 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all registered fundraiser app IDs.
        ///Frontend calls this to discover all campaigns.
        ///</summary>
        public async Task<ulong[]> GetFundraisers(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 2, 212, 104 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetFundraisers_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 2, 212, 104 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all registered ticketing event app IDs.
        ///Frontend calls this to discover all events.
        ///</summary>
        public async Task<ulong[]> GetTicketing(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 216, 62, 66 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> GetTicketing_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 216, 62, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total count of registered fundraisers and events.
        ///Useful for debugging and statistics.
        ///</summary>
        public async Task<Structs.GetTotalCountsReturn> GetTotalCounts(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 36, 97, 83 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetTotalCountsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTotalCounts_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 36, 97, 83 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FtcHVzQ2hhaW5SZWdpc3RyeSIsImRlc2MiOiJcbiAgICBSZWdpc3RyeSBjb250cmFjdCBzdG9yaW5nIGFwcCBJRHMgZm9yIGZ1bmRyYWlzaW5nIGNhbXBhaWducyBhbmQgdGlja2V0aW5nIGV2ZW50cy5cbiAgICBVc2VzIGJveCBzdG9yYWdlIHRvIGhhbmRsZSBsYXJnZSBsaXN0cyAoPjEyOCBpdGVtcykuXG4gICAgQm94ZXMgYXJlIGF1dG8tY3JlYXRlZCBvbiBmaXJzdCByZWdpc3RyYXRpb24gLSBubyBpbml0aWFsaXphdGlvbiBuZWVkZWQuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFRvdGFsQ291bnRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVnaXN0ZXJfZnVuZHJhaXNlciIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyBmdW5kcmFpc2luZyBjYW1wYWlnbiBhcHAgSUQuXG5DYW4gb25seSBiZSBjYWxsZWQgYnkgdGhlIGFwcCBjcmVhdG9yIChwcmV2ZW50cyBzcGFtKS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX3RpY2tldGluZyIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyB0aWNrZXRpbmcgZXZlbnQgYXBwIElELlxuQ2FuIG9ubHkgYmUgY2FsbGVkIGJ5IHRoZSBhcHAgY3JlYXRvciAocHJldmVudHMgc3BhbSkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZnVuZHJhaXNlcnMiLCJkZXNjIjoiR2V0IGFsbCByZWdpc3RlcmVkIGZ1bmRyYWlzZXIgYXBwIElEcy5cbkZyb250ZW5kIGNhbGxzIHRoaXMgdG8gZGlzY292ZXIgYWxsIGNhbXBhaWducy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RpY2tldGluZyIsImRlc2MiOiJHZXQgYWxsIHJlZ2lzdGVyZWQgdGlja2V0aW5nIGV2ZW50IGFwcCBJRHMuXG5Gcm9udGVuZCBjYWxscyB0aGlzIHRvIGRpc2NvdmVyIGFsbCBldmVudHMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9jb3VudHMiLCJkZXNjIjoiR2V0IHRvdGFsIGNvdW50IG9mIHJlZ2lzdGVyZWQgZnVuZHJhaXNlcnMgYW5kIGV2ZW50cy5cblVzZWZ1bCBmb3IgZGVidWdnaW5nIGFuZCBzdGF0aXN0aWNzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRUb3RhbENvdW50c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNTcsMzYxXSwiZXJyb3JNZXNzYWdlIjoiQXBwIElEIGFscmVhZHkgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0NCwzNDhdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyLDExMywxMjksMTQ1LDE2MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1LDExNiwxMzIsMTQ4LDE2NF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQTRNVGt5Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TmpZM05UWmxOalEzTWpZeE5qazNNelkxTnpJM015QXdlRGMwTmprMk16WmlOalUzTkRZNU5tVTJOeUF3ZURBd01EQWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUzQ2lBZ0lDQXZMeUJqYkdGemN5QkRZVzF3ZFhORGFHRnBibEpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UQUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3hNbUpoTURNelpTQXdlREZqWTJJMlpHVXdJREI0Tm1Fd01tUTBOamdnTUhoa1lXUTRNMlUwTWlBd2VHUm1NalEyTVRVeklDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZablZ1WkhKaGFYTmxjaWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVm5hWE4wWlhKZmRHbGphMlYwYVc1bktIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZlpuVnVaSEpoYVhObGNuTW9LWFZwYm5RMk5GdGRJaXdnYldWMGFHOWtJQ0puWlhSZmRHbGphMlYwYVc1bktDbDFhVzUwTmpSYlhTSXNJRzFsZEdodlpDQWlaMlYwWDNSdmRHRnNYMk52ZFc1MGN5Z3BLSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5eVpXZHBjM1JsY2w5bWRXNWtjbUZwYzJWeVgzSnZkWFJsUURNZ2JXRnBibDl5WldkcGMzUmxjbDkwYVdOclpYUnBibWRmY205MWRHVkFOQ0J0WVdsdVgyZGxkRjltZFc1a2NtRnBjMlZ5YzE5eWIzVjBaVUExSUcxaGFXNWZaMlYwWDNScFkydGxkR2x1WjE5eWIzVjBaVUEySUcxaGFXNWZaMlYwWDNSdmRHRnNYMk52ZFc1MGMxOXliM1YwWlVBM0NncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUdOc1lYTnpJRU5oYlhCMWMwTm9ZV2x1VW1WbmFYTjBjbmtvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYM1J2ZEdGc1gyTnZkVzUwYzE5eWIzVjBaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjkwYjNSaGJGOWpiM1Z1ZEhNS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZkR2xqYTJWMGFXNW5YM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzUnBZMnRsZEdsdVp3b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZablZ1WkhKaGFYTmxjbk5mY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOW1kVzVrY21GcGMyVnljd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXlaV2RwYzNSbGNsOTBhV05yWlhScGJtZGZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVGNLSUNBZ0lDOHZJR05zWVhOeklFTmhiWEIxYzBOb1lXbHVVbVZuYVhOMGNua29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJ5WldkcGMzUmxjbDkwYVdOclpYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjbVZuYVhOMFpYSmZablZ1WkhKaGFYTmxjbDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnWTJ4aGMzTWdRMkZ0Y0hWelEyaGhhVzVTWldkcGMzUnllU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhKbFoybHpkR1Z5WDJaMWJtUnlZV2x6WlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUzQ2lBZ0lDQXZMeUJqYkdGemN5QkRZVzF3ZFhORGFHRnBibEpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1RFlXMXdkWE5EYUdGcGJsSmxaMmx6ZEhKNUxuSmxaMmx6ZEdWeVgyWjFibVJ5WVdselpYSW9ZWEJ3WDJsa09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuSmxaMmx6ZEdWeVgyWjFibVJ5WVdselpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNalF0TWpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnlaV2RwYzNSbGNsOW1kVzVrY21GcGMyVnlLSE5sYkdZc0lHRndjRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pNQzB6TVFvZ0lDQWdMeThnSXlCTWIyRmtJR1Y0YVhOMGFXNW5JR1oxYm1SeVlXbHpaWElnYkdsemRDQm1jbTl0SUdKdmVDQW9ZM0psWVhSbElHbG1JR1J2WlhOdUozUWdaWGhwYzNRcENpQWdJQ0F2THlCbWRXNWtjbUZwYzJWeVgySnZlQ0E5SUVKdmVGSmxaaWhyWlhrOVlpSm1kVzVrY21GcGMyVnljeUlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpZM05UWmxOalEzTWpZeE5qazNNelkxTnpJM013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qTXpMVE0wQ2lBZ0lDQXZMeUFqSUVOb1pXTnJJR2xtSUdKdmVDQmxlR2x6ZEhNc0lHbG1JRzV2ZENCamNtVmhkR1VnYVhRS0lDQWdJQzh2SUdWNGFYTjBhVzVuWDJKNWRHVnpMQ0JpYjNoZlpYaHBjM1J6SUQwZ1puVnVaSEpoYVhObGNsOWliM2d1YldGNVltVW9LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNMUNpQWdJQ0F2THlCcFppQnViM1FnWW05NFgyVjRhWE4wY3pvS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5bWRXNWtjbUZwYzJWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNd0xUTXhDaUFnSUNBdkx5QWpJRXh2WVdRZ1pYaHBjM1JwYm1jZ1puVnVaSEpoYVhObGNpQnNhWE4wSUdaeWIyMGdZbTk0SUNoamNtVmhkR1VnYVdZZ1pHOWxjMjRuZENCbGVHbHpkQ2tLSUNBZ0lDOHZJR1oxYm1SeVlXbHpaWEpmWW05NElEMGdRbTk0VW1WbUtHdGxlVDFpSW1aMWJtUnlZV2x6WlhKeklpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJOamMxTm1VMk5EY3lOakUyT1Rjek5qVTNNamN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TXpZdE16Y0tJQ0FnSUM4dklDTWdRM0psWVhSbElHSnZlQ0IzYVhSb0lHVnRjSFI1SUdGeWNtRjVJRzl1SUdacGNuTjBJSEpsWjJsemRISmhkR2x2YmdvZ0lDQWdMeThnWm5WdVpISmhhWE5sY2w5aWIzZ3VZM0psWVhSbEtITnBlbVU5T0RFNU1pa2dJQ01nT0V0Q0lHSnZlQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ3hPVElLSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QmxiWEIwZVY5aGNuSmhlU0E5SUVSNWJtRnRhV05CY25KaGVWdEJVa00wVlVsdWREWTBYU2dwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMUNncHlaV2RwYzNSbGNsOW1kVzVrY21GcGMyVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBNeTAwTkFvZ0lDQWdMeThnSXlCQlpHUWdibVYzSUdGd2NDQkpSQ0FvY0hKbGRtVnVkQ0JrZFhCc2FXTmhkR1Z6S1FvZ0lDQWdMeThnWVhCd1gybGtYMkZ5WXpRZ1BTQkJVa00wVlVsdWREWTBLR0Z3Y0Y5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EWXRORGNLSUNBZ0lDOHZJQ01nUTJobFkyc2dhV1lnWVd4eVpXRmtlU0J5WldkcGMzUmxjbVZrSUNoc2FXNWxZWElnYzJWaGNtTm9JQzBnWVdOalpYQjBZV0pzWlNCbWIzSWdiVzlrWlhKaGRHVWdiR2x6ZEhNcENpQWdJQ0F2THlCaGJISmxZV1I1WDNKbFoybHpkR1Z5WldRZ1BTQkdZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalE0Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9ablZ1WkhKaGFYTmxjbDlzYVhOMExteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbkpsWjJsemRHVnlYMloxYm1SeVlXbHpaWEpmWm05eVgyaGxZV1JsY2tBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb1puVnVaSEpoYVhObGNsOXNhWE4wTG14bGJtZDBhQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUR3S0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHSjZJSEpsWjJsemRHVnlYMloxYm1SeVlXbHpaWEpmWVdaMFpYSmZabTl5UURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2FXWWdablZ1WkhKaGFYTmxjbDlzYVhOMFcybGRJRDA5SUdGd2NGOXBaRjloY21NME9nb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJSEpsWjJsemRHVnlYMloxYm1SeVlXbHpaWEpmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJR0ZzY21WaFpIbGZjbVZuYVhOMFpYSmxaQ0E5SUZSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0NuSmxaMmx6ZEdWeVgyWjFibVJ5WVdselpYSmZZV1owWlhKZlptOXlRRGc2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUdGc2NtVmhaSGxmY21WbmFYTjBaWEpsWkN3Z0lrRndjQ0JKUkNCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRaUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRWEJ3SUVsRUlHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVTFMVFUyQ2lBZ0lDQXZMeUFqSUVGd2NHVnVaQ0J1WlhjZ1lYQndJRWxFQ2lBZ0lDQXZMeUJtZFc1a2NtRnBjMlZ5WDJ4cGMzUXVZWEJ3Wlc1a0tHRndjRjlwWkY5aGNtTTBLUW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pNQzB6TVFvZ0lDQWdMeThnSXlCTWIyRmtJR1Y0YVhOMGFXNW5JR1oxYm1SeVlXbHpaWElnYkdsemRDQm1jbTl0SUdKdmVDQW9ZM0psWVhSbElHbG1JR1J2WlhOdUozUWdaWGhwYzNRcENpQWdJQ0F2THlCbWRXNWtjbUZwYzJWeVgySnZlQ0E5SUVKdmVGSmxaaWhyWlhrOVlpSm1kVzVrY21GcGMyVnljeUlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpZM05UWmxOalEzTWpZeE5qazNNelkxTnpJM013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVTRMVFU1Q2lBZ0lDQXZMeUFqSUZOaGRtVWdZbUZqYXlCMGJ5QmliM2dLSUNBZ0lDOHZJR1oxYm1SeVlXbHpaWEpmWW05NExuQjFkQ2htZFc1a2NtRnBjMlZ5WDJ4cGMzUXVZbmwwWlhNcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ25KbFoybHpkR1Z5WDJaMWJtUnlZV2x6WlhKZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRNENpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvWm5WdVpISmhhWE5sY2w5c2FYTjBMbXhsYm1kMGFDazZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1lpQnlaV2RwYzNSbGNsOW1kVzVrY21GcGMyVnlYMlp2Y2w5b1pXRmtaWEpBTXdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNURZVzF3ZFhORGFHRnBibEpsWjJsemRISjVMbkpsWjJsemRHVnlYM1JwWTJ0bGRHbHVaeWhoY0hCZmFXUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSmZkR2xqYTJWMGFXNW5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPall4TFRZeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdjbVZuYVhOMFpYSmZkR2xqYTJWMGFXNW5LSE5sYkdZc0lHRndjRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzJOeTAyT0FvZ0lDQWdMeThnSXlCTWIyRmtJR1Y0YVhOMGFXNW5JSFJwWTJ0bGRHbHVaeUJzYVhOMElHWnliMjBnWW05NElDaGpjbVZoZEdVZ2FXWWdaRzlsYzI0bmRDQmxlR2x6ZENrS0lDQWdJQzh2SUhScFkydGxkR2x1WjE5aWIzZ2dQU0JDYjNoU1pXWW9hMlY1UFdJaWRHbGphMlYwYVc1bklpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzNORFk1TmpNMllqWTFOelEyT1RabE5qY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzNNQzAzTVFvZ0lDQWdMeThnSXlCRGFHVmpheUJwWmlCaWIzZ2daWGhwYzNSekxDQnBaaUJ1YjNRZ1kzSmxZWFJsSUdsMENpQWdJQ0F2THlCbGVHbHpkR2x1WjE5aWVYUmxjeXdnWW05NFgyVjRhWE4wY3lBOUlIUnBZMnRsZEdsdVoxOWliM2d1YldGNVltVW9LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCcFppQnViM1FnWW05NFgyVjRhWE4wY3pvS0lDQWdJR0p1ZWlCeVpXZHBjM1JsY2w5MGFXTnJaWFJwYm1kZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpjdE5qZ0tJQ0FnSUM4dklDTWdURzloWkNCbGVHbHpkR2x1WnlCMGFXTnJaWFJwYm1jZ2JHbHpkQ0JtY205dElHSnZlQ0FvWTNKbFlYUmxJR2xtSUdSdlpYTnVKM1FnWlhocGMzUXBDaUFnSUNBdkx5QjBhV05yWlhScGJtZGZZbTk0SUQwZ1FtOTRVbVZtS0d0bGVUMWlJblJwWTJ0bGRHbHVaeUlwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TnpRMk9UWXpObUkyTlRjME5qazJaVFkzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpNdE56UUtJQ0FnSUM4dklDTWdRM0psWVhSbElHSnZlQ0IzYVhSb0lHVnRjSFI1SUdGeWNtRjVJRzl1SUdacGNuTjBJSEpsWjJsemRISmhkR2x2YmdvZ0lDQWdMeThnZEdsamEyVjBhVzVuWDJKdmVDNWpjbVZoZEdVb2MybDZaVDA0TVRreUtTQWdJeUE0UzBJZ1ltOTRDaUFnSUNCcGJuUmpYek1nTHk4Z09ERTVNZ29nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklHVnRjSFI1WDJGeWNtRjVJRDBnUkhsdVlXMXBZMEZ5Y21GNVcwRlNRelJWU1c1ME5qUmRLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0NuSmxaMmx6ZEdWeVgzUnBZMnRsZEdsdVoxOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9EQXRPREVLSUNBZ0lDOHZJQ01nUVdSa0lHNWxkeUJoY0hBZ1NVUWdLSEJ5WlhabGJuUWdaSFZ3YkdsallYUmxjeWtLSUNBZ0lDOHZJR0Z3Y0Y5cFpGOWhjbU0wSUQwZ1FWSkRORlZKYm5RMk5DaGhjSEJmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pnekxUZzBDaUFnSUNBdkx5QWpJRU5vWldOcklHbG1JR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZV3h5WldGa2VWOXlaV2RwYzNSbGNtVmtJRDBnUm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hScFkydGxkR2x1WjE5c2FYTjBMbXhsYm1kMGFDazZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LQ25KbFoybHpkR1Z5WDNScFkydGxkR2x1WjE5bWIzSmZhR1ZoWkdWeVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaDBhV05yWlhScGJtZGZiR2x6ZEM1c1pXNW5kR2dwT2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNBOENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQmllaUJ5WldkcGMzUmxjbDkwYVdOclpYUnBibWRmWVdaMFpYSmZabTl5UURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z2FXWWdkR2xqYTJWMGFXNW5YMnhwYzNSYmFWMGdQVDBnWVhCd1gybGtYMkZ5WXpRNkNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSTlQUW9nSUNBZ1lub2djbVZuYVhOMFpYSmZkR2xqYTJWMGFXNW5YMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QmhiSEpsWVdSNVgzSmxaMmx6ZEdWeVpXUWdQU0JVY25WbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2dweVpXZHBjM1JsY2w5MGFXTnJaWFJwYm1kZllXWjBaWEpmWm05eVFEZzZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR0ZzY21WaFpIbGZjbVZuYVhOMFpYSmxaQ3dnSWtGd2NDQkpSQ0JoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FYQndJRWxFSUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2preUxUa3pDaUFnSUNBdkx5QWpJRUZ3Y0dWdVpDQnVaWGNnWVhCd0lFbEVDaUFnSUNBdkx5QjBhV05yWlhScGJtZGZiR2x6ZEM1aGNIQmxibVFvWVhCd1gybGtYMkZ5WXpRcENpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZM0xUWTRDaUFnSUNBdkx5QWpJRXh2WVdRZ1pYaHBjM1JwYm1jZ2RHbGphMlYwYVc1bklHeHBjM1FnWm5KdmJTQmliM2dnS0dOeVpXRjBaU0JwWmlCa2IyVnpiaWQwSUdWNGFYTjBLUW9nSUNBZ0x5OGdkR2xqYTJWMGFXNW5YMkp2ZUNBOUlFSnZlRkpsWmloclpYazlZaUowYVdOclpYUnBibWNpS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURjME5qazJNelppTmpVM05EWTVObVUyTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prMUxUazJDaUFnSUNBdkx5QWpJRk5oZG1VZ1ltRmpheUIwYnlCaWIzZ0tJQ0FnSUM4dklIUnBZMnRsZEdsdVoxOWliM2d1Y0hWMEtIUnBZMnRsZEdsdVoxOXNhWE4wTG1KNWRHVnpLUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNncHlaV2RwYzNSbGNsOTBhV05yWlhScGJtZGZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2RHbGphMlYwYVc1blgyeHBjM1F1YkdWdVozUm9LVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F6Q2lBZ0lDQmlJSEpsWjJsemRHVnlYM1JwWTJ0bGRHbHVaMTltYjNKZmFHVmhaR1Z5UURNS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRMkZ0Y0hWelEyaGhhVzVTWldkcGMzUnllUzVuWlhSZlpuVnVaSEpoYVhObGNuTW9LU0F0UGlCaWVYUmxjem9LWjJWMFgyWjFibVJ5WVdselpYSnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPams0TFRrNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYMloxYm1SeVlXbHpaWEp6S0hObGJHWXBJQzArSUVSNWJtRnRhV05CY25KaGVWdEJVa00wVlVsdWREWTBYVG9LSUNBZ0lIQnliM1J2SURBZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXdOQW9nSUNBZ0x5OGdablZ1WkhKaGFYTmxjbDlpYjNnZ1BTQkNiM2hTWldZb2EyVjVQV0lpWm5WdVpISmhhWE5sY25NaUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTJOelUyWlRZME56STJNVFk1TnpNMk5UY3lOek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUdWNGFYTjBhVzVuWDJKNWRHVnpMQ0JpYjNoZlpYaHBjM1J6SUQwZ1puVnVaSEpoYVhObGNsOWliM2d1YldGNVltVW9LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd05nb2dJQ0FnTHk4Z2FXWWdZbTk0WDJWNGFYTjBjem9LSUNBZ0lHSjZJR2RsZEY5bWRXNWtjbUZwYzJWeWMxOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnY21WMGRYSnVJRVI1Ym1GdGFXTkJjbkpoZVZ0QlVrTTBWVWx1ZERZMFhTNW1jbTl0WDJKNWRHVnpLR1Y0YVhOMGFXNW5YMko1ZEdWektRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0taMlYwWDJaMWJtUnlZV2x6WlhKelgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3T1MweE1UQUtJQ0FnSUM4dklDTWdVbVYwZFhKdUlHVnRjSFI1SUdGeWNtRjVJR2xtSUdKdmVDQmtiMlZ6YmlkMElHVjRhWE4wSUhsbGRBb2dJQ0FnTHk4Z2NtVjBkWEp1SUVSNWJtRnRhV05CY25KaGVWdEJVa00wVlVsdWREWTBYU2dwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5KbFoybHpkSEo1TG1OdmJuUnlZV04wTGtOaGJYQjFjME5vWVdsdVVtVm5hWE4wY25rdVoyVjBYM1JwWTJ0bGRHbHVaeWdwSUMwK0lHSjVkR1Z6T2dwblpYUmZkR2xqYTJWMGFXNW5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TWkweE1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmZEdsamEyVjBhVzVuS0hObGJHWXBJQzArSUVSNWJtRnRhV05CY25KaGVWdEJVa00wVlVsdWREWTBYVG9LSUNBZ0lIQnliM1J2SURBZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdkR2xqYTJWMGFXNW5YMkp2ZUNBOUlFSnZlRkpsWmloclpYazlZaUowYVdOclpYUnBibWNpS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURjME5qazJNelppTmpVM05EWTVObVUyTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeE9Rb2dJQ0FnTHk4Z1pYaHBjM1JwYm1kZllubDBaWE1zSUdKdmVGOWxlR2x6ZEhNZ1BTQjBhV05yWlhScGJtZGZZbTk0TG0xaGVXSmxLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qQUtJQ0FnSUM4dklHbG1JR0p2ZUY5bGVHbHpkSE02Q2lBZ0lDQmllaUJuWlhSZmRHbGphMlYwYVc1blgyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdSSGx1WVcxcFkwRnljbUY1VzBGU1F6UlZTVzUwTmpSZExtWnliMjFmWW5sMFpYTW9aWGhwYzNScGJtZGZZbmwwWlhNcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncG5aWFJmZEdsamEyVjBhVzVuWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXlNeTB4TWpRS0lDQWdJQzh2SUNNZ1VtVjBkWEp1SUdWdGNIUjVJR0Z5Y21GNUlHbG1JR0p2ZUNCa2IyVnpiaWQwSUdWNGFYTjBJSGxsZEFvZ0lDQWdMeThnY21WMGRYSnVJRVI1Ym1GdGFXTkJjbkpoZVZ0QlVrTTBWVWx1ZERZMFhTZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsWjJsemRISjVMbU52Ym5SeVlXTjBMa05oYlhCMWMwTm9ZV2x1VW1WbmFYTjBjbmt1WjJWMFgzUnZkR0ZzWDJOdmRXNTBjeWdwSUMwK0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwblpYUmZkRzkwWVd4ZlkyOTFiblJ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU5pMHhNamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJuWlhSZmRHOTBZV3hmWTI5MWJuUnpLSE5sYkdZcElDMCtJSFIxY0d4bFcxVkpiblEyTkN3Z1ZVbHVkRFkwWFRvS0lDQWdJSEJ5YjNSdklEQWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV6TWdvZ0lDQWdMeThnWm5WdVpISmhhWE5sY2w5aWIzZ2dQU0JDYjNoU1pXWW9hMlY1UFdJaVpuVnVaSEpoYVhObGNuTWlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFkyTnpVMlpUWTBOekkyTVRZNU56TTJOVGN5TnpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE16VXRNVE0yQ2lBZ0lDQXZMeUFqSUVoaGJtUnNaU0JpYjNobGN5QjBhR0YwSUdSdmJpZDBJR1Y0YVhOMElIbGxkQW9nSUNBZ0x5OGdablZ1WkhKaGFYTmxjbDlpZVhSbGN5d2dablZ1WkhKaGFYTmxjbDlsZUdsemRITWdQU0JtZFc1a2NtRnBjMlZ5WDJKdmVDNXRZWGxpWlNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVE16Q2lBZ0lDQXZMeUIwYVdOclpYUnBibWRmWW05NElEMGdRbTk0VW1WbUtHdGxlVDFpSW5ScFkydGxkR2x1WnlJcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE56UTJPVFl6Tm1JMk5UYzBOamsyWlRZM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UTTNDaUFnSUNBdkx5QjBhV05yWlhScGJtZGZZbmwwWlhNc0lIUnBZMnRsZEdsdVoxOWxlR2x6ZEhNZ1BTQjBhV05yWlhScGJtZGZZbTk0TG0xaGVXSmxLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJR1oxYm1SeVlXbHpaWEpmWTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFF3Q2lBZ0lDQXZMeUIwYVdOclpYUnBibWRmWTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFF5Q2lBZ0lDQXZMeUJwWmlCbWRXNWtjbUZwYzJWeVgyVjRhWE4wY3pvS0lDQWdJR0o2SUdkbGRGOTBiM1JoYkY5amIzVnVkSE5mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFEwQ2lBZ0lDQXZMeUJtZFc1a2NtRnBjMlZ5WDJOdmRXNTBJRDBnWm5WdVpISmhhWE5sY2w5c2FYTjBMbXhsYm1kMGFBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlluVnllU0F6Q2dwblpYUmZkRzkwWVd4ZlkyOTFiblJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TkRZS0lDQWdJQzh2SUdsbUlIUnBZMnRsZEdsdVoxOWxlR2x6ZEhNNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbm9nWjJWMFgzUnZkR0ZzWDJOdmRXNTBjMTloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJSFJwWTJ0bGRHbHVaMTlqYjNWdWRDQTlJSFJwWTJ0bGRHbHVaMTlzYVhOMExteGxibWQwYUFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDZ3BuWlhSZmRHOTBZV3hmWTI5MWJuUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQW9ablZ1WkhKaGFYTmxjbDlqYjNWdWRDd2dkR2xqYTJWMGFXNW5YMk52ZFc1MEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFFSWdFQW1CQXRtZFc1a2NtRnBjMlZ5Y3dsMGFXTnJaWFJwYm1jQ0FBQUVGUjk4ZFRFYlFRQ0JnZ1VFRXJvRFBnUWN5MjNnQkdvQzFHZ0UydGcrUWdUZkpHRlROaG9BamdVQVJ3QTNBQ2NBRndBQ0lrTXhHUlJFTVJoRWlBRkVUQlpNRmxBclRGQ3dJME14R1JSRU1SaEVpQUVnSzB4UXNDTkRNUmtVUkRFWVJJZ0JBU3RNVUxBalF6RVpGRVF4R0VRMkdnRVhpQUNGSTBNeEdSUkVNUmhFTmhvQkY0Z0FEU05ETVJsQS82UXhHQlJFSTBPS0FRQWlnQUJIQXlpK1FBQUhLQ1c1U0NxTUJZdi9Gb3dBSW93Qml3VWlXWXdFSW93RGl3T0xCQXlMQVl3Q1FRQVVpd1ZYQWdDTEF5UUxKRmlMQUtoQkFCMGpqQUtMQWhSRWl3VlhBZ0NMQUZCSkZTUUtGbGNHQWt4UUtFeS9pWXNESXdpTUEwTC92WW9CQUNLQUFFY0RLYjVBQUFjcEpibElLb3dGaS84V2pBQWlqQUdMQlNKWmpBUWlqQU9MQTRzRURJc0JqQUpCQUJTTEJWY0NBSXNESkFza1dJc0FxRUVBSFNPTUFvc0NGRVNMQlZjQ0FJc0FVRWtWSkFvV1Z3WUNURkFwVEwrSml3TWpDSXdEUXYrOWlnQUJLTDVCQUFTTEFFeUpLa3lKaWdBQktiNUJBQVNMQUV5SktreUppZ0FDS0w0cHZrNENUQ0pNSWt4QkFBYUxBQ0paakFPTEFVRUFCb3NDSWxtTUJJc0Rpd1NNQVl3QWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
