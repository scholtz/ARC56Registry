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

namespace Arc56.Generated.Danish0703.ComplianceAudit.AlertEngine_e2f08a22
{


    public class AlertEngineProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlertEngineProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetLatestAlertReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public string Field1 { get; set; }

                public string Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetLatestAlertReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetLatestAlertReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetLatestAlertReturn);
                }
                public bool Equals(GetLatestAlertReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetLatestAlertReturn left, GetLatestAlertReturn right)
                {
                    return EqualityComparer<GetLatestAlertReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetLatestAlertReturn left, GetLatestAlertReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="low"> </param>
        /// <param name="medium"> </param>
        /// <param name="high"> </param>
        public async Task ConfigureThresholds(ulong low, ulong medium, ulong high, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 47, 127, 34 };
            var lowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lowAbi.From(low);
            var mediumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mediumAbi.From(medium);
            var highAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); highAbi.From(high);

            var result = await base.CallApp(new List<object> { abiHandle, lowAbi, mediumAbi, highAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfigureThresholds_Transactions(ulong low, ulong medium, ulong high, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 47, 127, 34 };
            var lowAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lowAbi.From(low);
            var mediumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); mediumAbi.From(medium);
            var highAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); highAbi.From(high);

            return await base.MakeTransactionList(new List<object> { abiHandle, lowAbi, mediumAbi, highAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="score"> </param>
        /// <param name="reason"> </param>
        public async Task<string> EmitAlert(Address wallet, ulong score, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 197, 216, 49, 159 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            var result = await base.CallApp(new List<object> { abiHandle, walletRefIndex, scoreAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmitAlert_Transactions(Address wallet, ulong score, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 197, 216, 49, 159 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex, scoreAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<ulong> GetAlertCount(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 89, 10, 143, 135 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAlertCount_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 89, 10, 143, 135 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.GetLatestAlertReturn> GetLatestAlert(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 66, 198, 126, 209 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetLatestAlertReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetLatestAlert_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 66, 198, 126, 209 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxlcnRFbmdpbmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0TGF0ZXN0QWxlcnRSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY29uZmlndXJlX3RocmVzaG9sZHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG93IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZWRpdW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhpZ2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW1pdF9hbGVydCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29yZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FsZXJ0X2NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9sYXRlc3RfYWxlcnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiR2V0TGF0ZXN0QWxlcnRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzU2XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCB0aHJlc2hvbGQgb3JkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjAsMjI4LDI1MSwyOTFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGNvbmZpZ3VyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4Ml0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gZW1pdCBhbGVydHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTFdLCJlcnJvck1lc3NhZ2UiOiJSZWFzb24gcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODddLCJlcnJvck1lc3NhZ2UiOiJTY29yZSBvdXQgb2YgcmFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjMsMjMxLDI1NCwyOTRdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5oaWdoX3RocmVzaG9sZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxvd190aHJlc2hvbGQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tZWRpdW1fdGhyZXNob2xkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bGNuUmZaVzVuYVc1bExtTnZiblJ5WVdOMExrRnNaWEowUlc1bmFXNWxMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUNBeE1EQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lteHZkMTkwYUhKbGMyaHZiR1FpSUNKdFpXUnBkVzFmZEdoeVpYTm9iMnhrSWlBaWFHbG5hRjkwYUhKbGMyaHZiR1FpSURCNE1UVXhaamRqTnpVZ0ltRmxYMk52ZFc1MFh5SWdJbUZsWDNOamIzSmxYeUlnSW1GbFgzSmxZWE52Ymw4aUlDSmhaVjl6WlhaZklnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdjMlZzWmk1c2IzZGZkR2h5WlhOb2IyeGtJRDBnVlVsdWREWTBLRE13S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYkc5M1gzUm9jbVZ6YUc5c1pDSUtJQ0FnSUhCMWMyaHBiblFnTXpBZ0x5OGdNekFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3hsY25SZlpXNW5hVzVsTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QnpaV3htTG0xbFpHbDFiVjkwYUhKbGMyaHZiR1FnUFNCVlNXNTBOalFvTmpBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdFpXUnBkVzFmZEdoeVpYTm9iMnhrSWdvZ0lDQWdjSFZ6YUdsdWRDQTJNQ0F2THlBMk1Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHVnlkRjlsYm1kcGJtVXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUhObGJHWXVhR2xuYUY5MGFISmxjMmh2YkdRZ1BTQlZTVzUwTmpRb09EQXBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSm9hV2RvWDNSb2NtVnphRzlzWkNJS0lDQWdJSEIxYzJocGJuUWdPREFnTHk4Z09EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1FXeGxjblJGYm1kcGJtVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1tTXlaamRtTWpJZ01IaGpOV1E0TXpFNVppQXdlRFU1TUdFNFpqZzNJREI0TkRKak5qZGxaREVnTHk4Z2JXVjBhRzlrSUNKamIyNW1hV2QxY21WZmRHaHlaWE5vYjJ4a2N5aDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmxiV2wwWDJGc1pYSjBLR0ZqWTI5MWJuUXNkV2x1ZERZMExITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGOWhiR1Z5ZEY5amIzVnVkQ2hoWTJOdmRXNTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDJ4aGRHVnpkRjloYkdWeWRDaGhZMk52ZFc1MEtTaDFhVzUwTmpRc2MzUnlhVzVuTEhOMGNtbHVaeWtpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk52Ym1acFozVnlaVjkwYUhKbGMyaHZiR1J6WDNKdmRYUmxRRFVnYldGcGJsOWxiV2wwWDJGc1pYSjBYM0p2ZFhSbFFEWWdiV0ZwYmw5blpYUmZZV3hsY25SZlkyOTFiblJmY205MWRHVkFOeUJ0WVdsdVgyZGxkRjlzWVhSbGMzUmZZV3hsY25SZmNtOTFkR1ZBT0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJCYkdWeWRFVnVaMmx1WlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYkdGMFpYTjBYMkZzWlhKMFgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bGNuUmZaVzVuYVc1bEwyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHVnlkRjlsYm1kcGJtVXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdRV3hsY25SRmJtZHBibVVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeGxjblJmWlc1bmFXNWxMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjlzWVhSbGMzUmZZV3hsY25RS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdZd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERXlJQzh2SURFeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5aGJHVnlkRjlqYjNWdWRGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1pYSjBYMlZ1WjJsdVpTOWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeGxjblJmWlc1bmFXNWxMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRUZzWlhKMFJXNW5hVzVsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvME1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWVd4bGNuUmZZMjkxYm5RS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWlcxcGRGOWhiR1Z5ZEY5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUb3lOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR1Z5ZEY5bGJtZHBibVV2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUVd4bGNuUkZibWRwYm1Vb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRveU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdWdGFYUmZZV3hsY25RS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk52Ym1acFozVnlaVjkwYUhKbGMyaHZiR1J6WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3hsY25SZlpXNW5hVzVsTDJOdmJuUnlZV04wTG5CNU9qRTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJCYkdWeWRFVnVaMmx1WlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRveE9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUdOdmJtWnBaM1Z5WlY5MGFISmxjMmh2YkdSekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJCYkdWeWRFVnVaMmx1WlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3hsY25SZlpXNW5hVzVsTG1OdmJuUnlZV04wTGtGc1pYSjBSVzVuYVc1bExtTnZibVpwWjNWeVpWOTBhSEpsYzJodmJHUnpLR3h2ZHpvZ2RXbHVkRFkwTENCdFpXUnBkVzA2SUhWcGJuUTJOQ3dnYUdsbmFEb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGpiMjVtYVdkMWNtVmZkR2h5WlhOb2IyeGtjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR1Z5ZEY5bGJtZHBibVV2WTI5dWRISmhZM1F1Y0hrNk1Ua3RNakFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHTnZibVpwWjNWeVpWOTBhSEpsYzJodmJHUnpLSE5sYkdZc0lHeHZkem9nVlVsdWREWTBMQ0J0WldScGRXMDZJRlZKYm5RMk5Dd2dhR2xuYURvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeGxjblJmWlc1bmFXNWxMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVQyNXNlU0JqY21WaGRHOXlJR05oYmlCamIyNW1hV2QxY21VaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCamIyNW1hV2QxY21VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZNaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQnNiM2NnUENCdFpXUnBkVzBnWVc1a0lHMWxaR2wxYlNBOElHaHBaMmdnWVc1a0lHaHBaMmdnUEQwZ1ZVbHVkRFkwS0RFd01Da3NJQ0pKYm5aaGJHbGtJSFJvY21WemFHOXNaQ0J2Y21SbGNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0E4Q2lBZ0lDQmllaUJqYjI1bWFXZDFjbVZmZEdoeVpYTm9iMnhrYzE5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E4Q2lBZ0lDQmllaUJqYjI1bWFXZDFjbVZmZEdoeVpYTm9iMnhrYzE5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFd01Bb2dJQ0FnUEQwS0lDQWdJR0o2SUdOdmJtWnBaM1Z5WlY5MGFISmxjMmh2YkdSelgySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtDbU52Ym1acFozVnlaVjkwYUhKbGMyaHZiR1J6WDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHVnlkRjlsYm1kcGJtVXZZMjl1ZEhKaFkzUXVjSGs2TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0JzYjNjZ1BDQnRaV1JwZFcwZ1lXNWtJRzFsWkdsMWJTQThJR2hwWjJnZ1lXNWtJR2hwWjJnZ1BEMGdWVWx1ZERZMEtERXdNQ2tzSUNKSmJuWmhiR2xrSUhSb2NtVnphRzlzWkNCdmNtUmxjaUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lIUm9jbVZ6YUc5c1pDQnZjbVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdjMlZzWmk1c2IzZGZkR2h5WlhOb2IyeGtJRDBnYkc5M0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKc2IzZGZkR2h5WlhOb2IyeGtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRveU5Bb2dJQ0FnTHk4Z2MyVnNaaTV0WldScGRXMWZkR2h5WlhOb2IyeGtJRDBnYldWa2FYVnRDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnRaV1JwZFcxZmRHaHlaWE5vYjJ4a0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1pYSjBYMlZ1WjJsdVpTOWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnYzJWc1ppNW9hV2RvWDNSb2NtVnphRzlzWkNBOUlHaHBaMmdLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbWhwWjJoZmRHaHlaWE5vYjJ4a0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ3BqYjI1bWFXZDFjbVZmZEdoeVpYTm9iMnhrYzE5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCamIyNW1hV2QxY21WZmRHaHlaWE5vYjJ4a2MxOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXeGxjblJmWlc1bmFXNWxMbU52Ym5SeVlXTjBMa0ZzWlhKMFJXNW5hVzVsTG1WdGFYUmZZV3hsY25Rb2QyRnNiR1YwT2lCaWVYUmxjeXdnYzJOdmNtVTZJSFZwYm5RMk5Dd2djbVZoYzI5dU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtVnRhWFJmWVd4bGNuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeGxjblJmWlc1bmFXNWxMMk52Ym5SeVlXTjBMbkI1T2pJM0xUSTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCbGJXbDBYMkZzWlhKMEtITmxiR1lzSUhkaGJHeGxkRG9nUVdOamIzVnVkQ3dnYzJOdmNtVTZJRlZKYm5RMk5Dd2djbVZoYzI5dU9pQlRkSEpwYm1jcElDMCtJRk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUb3lPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d2dJazl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdaVzFwZENCaGJHVnlkSE1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJsYldsMElHRnNaWEowY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdZWE56WlhKMElITmpiM0psSUR3OUlGVkpiblEyTkNneE1EQXBMQ0FpVTJOdmNtVWdiM1YwSUc5bUlISmhibWRsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGTmpiM0psSUc5MWRDQnZaaUJ5WVc1blpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1pYSjBYMlZ1WjJsdVpTOWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnWVhOelpYSjBJSEpsWVhOdmJpNWllWFJsY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTUNrc0lDSlNaV0Z6YjI0Z2NtVnhkV2x5WldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdZWE56WlhKMElDOHZJRkpsWVhOdmJpQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1pYSjBYMlZ1WjJsdVpTOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWTI5MWJuUXNJR1Y0YVhOMGN5QTlJSE5sYkdZdVlXeGxjblJmWTI5MWJuUXViV0Y1WW1Vb2QyRnNiR1YwS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdWZlkyOTFiblJmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1pYSjBYMlZ1WjJsdVpTOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnYzJWc1ppNWhiR1Z5ZEY5amIzVnVkRnQzWVd4c1pYUmRJRDBnWTI5MWJuUWdLeUJWU1c1ME5qUW9NU2tnYVdZZ1pYaHBjM1J6SUdWc2MyVWdWVWx1ZERZMEtERXBDaUFnSUNCaWVpQmxiV2wwWDJGc1pYSjBYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDZ3BsYldsMFgyRnNaWEowWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR1Z5ZEY5bGJtZHBibVV2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklITmxiR1l1WVd4bGNuUmZZMjkxYm5SYmQyRnNiR1YwWFNBOUlHTnZkVzUwSUNzZ1ZVbHVkRFkwS0RFcElHbG1JR1Y0YVhOMGN5QmxiSE5sSUZWSmJuUTJOQ2d4S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJSE5sYkdZdWJHRjBaWE4wWDNOamIzSmxXM2RoYkd4bGRGMGdQU0J6WTI5eVpRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlXVmZjMk52Y21WZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z2MyVnNaaTVzWVhSbGMzUmZjbVZoYzI5dVczZGhiR3hsZEYwZ1BTQnlaV0Z6YjI0S0lDQWdJR0o1ZEdWaklEWWdMeThnSW1GbFgzSmxZWE52Ymw4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z2FXWWdjMk52Y21VZ1BEMGdjMlZzWmk1c2IzZGZkR2h5WlhOb2IyeGtPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lteHZkMTkwYUhKbGMyaHZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHOTNYM1JvY21WemFHOXNaQ0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnUGowS0lDQWdJR0o2SUdWdGFYUmZZV3hsY25SZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3hsY25SZlpXNW5hVzVsTDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKc2IzY2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnNiM2NpQ2dwbGJXbDBYMkZzWlhKMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZzWlhKMFgyVnVaMmx1WlM1amIyNTBjbUZqZEM1QmJHVnlkRVZ1WjJsdVpTNWZjMlYyWlhKcGRIbGZabkp2YlY5elkyOXlaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSE5sYkdZdWJHRjBaWE4wWDNObGRtVnlhWFI1VzNkaGJHeGxkRjBnUFNCelpYWmxjbWwwZVFvZ0lDQWdZbmwwWldNZ055QXZMeUFpWVdWZmMyVjJYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHVnlkRjlsYm1kcGJtVXZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUhKbGRIVnliaUJ6WlhabGNtbDBlUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21WdGFYUmZZV3hsY25SZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdhV1lnYzJOdmNtVWdQRDBnYzJWc1ppNXRaV1JwZFcxZmRHaHlaWE5vYjJ4a09nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xbFpHbDFiVjkwYUhKbGMyaHZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXVmthWFZ0WDNSb2NtVnphRzlzWkNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1BqMEtJQ0FnSUdKNklHVnRhWFJmWVd4bGNuUmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bGNuUmZaVzVuYVc1bEwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSnRaV1JwZFcwaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdFpXUnBkVzBpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3hsY25SZlpXNW5hVzVsTDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnpaWFpsY21sMGVTQTlJSE5sYkdZdVgzTmxkbVZ5YVhSNVgyWnliMjFmYzJOdmNtVW9jMk52Y21VcENpQWdJQ0JpSUdWdGFYUmZZV3hsY25SZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZV3hsY25SZlpXNW5hVzVsTG1OdmJuUnlZV04wTGtGc1pYSjBSVzVuYVc1bExsOXpaWFpsY21sMGVWOW1jbTl0WDNOamIzSmxRREV4Q2dwbGJXbDBYMkZzWlhKMFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJR2xtSUhOamIzSmxJRHc5SUhObGJHWXVhR2xuYUY5MGFISmxjMmh2YkdRNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYUdsbmFGOTBhSEpsYzJodmJHUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YUdsbmFGOTBhSEpsYzJodmJHUWdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJRDQ5Q2lBZ0lDQmllaUJsYldsMFgyRnNaWEowWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR1Z5ZEY5bGJtZHBibVV2WTI5dWRISmhZM1F1Y0hrNk5qWUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSW1ocFoyZ2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSm9hV2RvSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdjMlYyWlhKcGRIa2dQU0J6Wld4bUxsOXpaWFpsY21sMGVWOW1jbTl0WDNOamIzSmxLSE5qYjNKbEtRb2dJQ0FnWWlCbGJXbDBYMkZzWlhKMFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZzWlhKMFgyVnVaMmx1WlM1amIyNTBjbUZqZEM1QmJHVnlkRVZ1WjJsdVpTNWZjMlYyWlhKcGRIbGZabkp2YlY5elkyOXlaVUF4TVFvS1pXMXBkRjloYkdWeWRGOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1pYSjBYMlZ1WjJsdVpTOWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lZM0pwZEdsallXd2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmpjbWwwYVdOaGJDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHVnlkRjlsYm1kcGJtVXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUhObGRtVnlhWFI1SUQwZ2MyVnNaaTVmYzJWMlpYSnBkSGxmWm5KdmJWOXpZMjl5WlNoelkyOXlaU2tLSUNBZ0lHSWdaVzFwZEY5aGJHVnlkRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1aGJHVnlkRjlsYm1kcGJtVXVZMjl1ZEhKaFkzUXVRV3hsY25SRmJtZHBibVV1WDNObGRtVnlhWFI1WDJaeWIyMWZjMk52Y21WQU1URUtDbVZ0YVhSZllXeGxjblJmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z2MyVnNaaTVoYkdWeWRGOWpiM1Z1ZEZ0M1lXeHNaWFJkSUQwZ1kyOTFiblFnS3lCVlNXNTBOalFvTVNrZ2FXWWdaWGhwYzNSeklHVnNjMlVnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lpQmxiV2wwWDJGc1pYSjBYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYkdWeWRGOWxibWRwYm1VdVkyOXVkSEpoWTNRdVFXeGxjblJGYm1kcGJtVXVaMlYwWDJGc1pYSjBYMk52ZFc1MEtIZGhiR3hsZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS1oyVjBYMkZzWlhKMFgyTnZkVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUbzBNaTAwTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOWhiR1Z5ZEY5amIzVnVkQ2h6Wld4bUxDQjNZV3hzWlhRNklFRmpZMjkxYm5RcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWlhKMFgyVnVaMmx1WlM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdZMjkxYm5Rc0lHVjRhWE4wY3lBOUlITmxiR1l1WVd4bGNuUmZZMjkxYm5RdWJXRjVZbVVvZDJGc2JHVjBLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1ZmWTI5MWJuUmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJR2xtSUdWNGFYTjBjem9LSUNBZ0lHSjZJR2RsZEY5aGJHVnlkRjlqYjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJSEpsZEhWeWJpQmpiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1oyVjBYMkZzWlhKMFgyTnZkVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR1Z5ZEY5bGJtZHBibVV2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV3hsY25SZlpXNW5hVzVsTG1OdmJuUnlZV04wTGtGc1pYSjBSVzVuYVc1bExtZGxkRjlzWVhSbGMzUmZZV3hsY25Rb2QyRnNiR1YwT2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwTENCaWVYUmxjeXdnWW5sMFpYTTZDbWRsZEY5c1lYUmxjM1JmWVd4bGNuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeGxjblJmWlc1bmFXNWxMMk52Ym5SeVlXTjBMbkI1T2pRNUxUVXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDJ4aGRHVnpkRjloYkdWeWRDaHpaV3htTENCM1lXeHNaWFE2SUVGalkyOTFiblFwSUMwK0lIUjFjR3hsVzFWSmJuUTJOQ3dnVTNSeWFXNW5MQ0JUZEhKcGJtZGRPZ29nSUNBZ2NISnZkRzhnTVNBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bGNuUmZaVzVuYVc1bEwyTnZiblJ5WVdOMExuQjVPalV4Q2lBZ0lDQXZMeUJ6WTI5eVpTd2djMk52Y21WZlpYaHBjM1J6SUQwZ2MyVnNaaTVzWVhSbGMzUmZjMk52Y21VdWJXRjVZbVVvZDJGc2JHVjBLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1ZmYzJOdmNtVmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJSE5sZG1WeWFYUjVMQ0J6WlhabGNtbDBlVjlsZUdsemRITWdQU0J6Wld4bUxteGhkR1Z6ZEY5elpYWmxjbWwwZVM1dFlYbGlaU2gzWVd4c1pYUXBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmhaVjl6WlhaZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdWeWRGOWxibWRwYm1VdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJSEpsWVhOdmJpd2djbVZoYzI5dVgyVjRhWE4wY3lBOUlITmxiR1l1YkdGMFpYTjBYM0psWVhOdmJpNXRZWGxpWlNoM1lXeHNaWFFwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poWlY5eVpXRnpiMjVmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR1Z5ZEY5bGJtZHBibVV2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHbG1JRzV2ZENCelkyOXlaVjlsZUdsemRITWdiM0lnYm05MElITmxkbVZ5YVhSNVgyVjRhWE4wY3lCdmNpQnViM1FnY21WaGMyOXVYMlY0YVhOMGN6b0tJQ0FnSUdKNklHZGxkRjlzWVhSbGMzUmZZV3hsY25SZmFXWmZZbTlrZVVBekNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbm9nWjJWMFgyeGhkR1Z6ZEY5aGJHVnlkRjlwWmw5aWIyUjVRRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaWJub2daMlYwWDJ4aGRHVnpkRjloYkdWeWRGOWhablJsY2w5cFpsOWxiSE5sUURRS0NtZGxkRjlzWVhSbGMzUmZZV3hsY25SZmFXWmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1pYSjBYMlZ1WjJsdVpTOWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLU3dnVTNSeWFXNW5LQ0p1YjI1bElpa3NJRk4wY21sdVp5Z2lJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklDSnViMjVsSWlBaUlpQXZMeUFpYm05dVpTSXNJQ0lpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOXNZWFJsYzNSZllXeGxjblJmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaWEowWDJWdVoybHVaUzlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhOamIzSmxMQ0J6WlhabGNtbDBlU3dnY21WaGMyOXVDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBUUJrSmdnTmJHOTNYM1JvY21WemFHOXNaQkJ0WldScGRXMWZkR2h5WlhOb2IyeGtEbWhwWjJoZmRHaHlaWE5vYjJ4a0JCVWZmSFVKWVdWZlkyOTFiblJmQ1dGbFgzTmpiM0psWHdwaFpWOXlaV0Z6YjI1ZkIyRmxYM05sZGw4eEdFQUFEQ2lCSG1jcGdUeG5Lb0ZRWnpFYlFRREFnZ1FFTEM5L0lnVEYyREdmQkZrS2o0Y0VRc1orMFRZYUFJNEVBSVVBWFFCR0FBSWpRekVaRkVReEdFUTJHZ0VYd0J5SUFYRlBBaFpMQWhVV1Z3WUNUd05RU3dJVkZsY0dBazhEVUU4Q2dBSUFERkJMQWhXQkRBZ1dWd1lDVUU4Q1VFeFFLMHhRc0NKRE1Sa1VSREVZUkRZYUFSZkFISWdCRnhZclRGQ3dJa014R1JSRU1SaEVOaG9CRjhBY05ob0NGellhQTFjQ0FJZ0FaRWtWRmxjR0FreFFLMHhRc0NKRE1Sa1VSREVZUkRZYUFSYzJHZ0lYTmhvREY0Z0FEU0pETVJsQS8xNHhHQlJFSWtPS0F3QXhBRElKRWtTTC9ZditERUVBSG92K2kvOE1RUUFXaS84a0RrRUFEeUpFS0l2OVp5bUwvbWNxaS85bmlTTkMvKzZLQXdFeEFESUpFa1NML2lRT1JJdi9GVVFuQkl2OVVFbStUQmRNUVFCdml3RWlDQmFMQUV5L0p3V0wvVkNML2hhL0p3YUwvVkJKdkVpTC83OGpLR1ZFaS80UFFRQVRnQU5zYjNjbkI0djlVRW04U0VzQnY0d0FpU01wWlVTTC9nOUJBQXVBQm0xbFpHbDFiVUwvM1NNcVpVU0wvZzlCQUFtQUJHaHBaMmhDLzhxQUNHTnlhWFJwWTJGc1F2KzlJa0wva1lvQkFTY0VpLzlRdmt3WFRFRUFCSXNBVElralRJbUtBUU1uQll2L1VMNU1GMHduQjR2L1VMNU9Ba3duQm92L1VMNU9Ba3hCQUFxTEFVRUFCWXNEUUFBUUk0SUNCRzV2Ym1VQWpBS01BWXdBaVlzQWl3S0xCSXdDakFHTUFJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
