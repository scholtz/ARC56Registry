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

namespace Arc56.Generated.d13co.xgov_delegator.OracleAccountContract_af3c0c8d
{


    public class OracleAccountContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OracleAccountContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class OracleAccount : AVMObjectType
            {
                public uint AccountId { get; set; }

                public Structs.OracleAccountCommitteeOffsets[] CommitteeOffsets { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vAccountId.From(AccountId);
                    ret.AddRange(vAccountId.Encode());
                    var arrCommitteeOffsets = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.OracleAccountCommitteeOffsets>(x => Structs.OracleAccountCommitteeOffsets.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrCommitteeOffsets.Value = (CommitteeOffsets ?? Array.Empty<Structs.OracleAccountCommitteeOffsets>()).ToList();
                    stringRef[ret.Count] = arrCommitteeOffsets.Encode();
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

                public static OracleAccount Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new OracleAccount();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vAccountId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccountId = vAccountId.ToValue();
                    if (valueAccountId is uint vAccountIdValue) { ret.AccountId = vAccountIdValue; }
                    var indexCommitteeOffsets = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrCommitteeOffsets = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.OracleAccountCommitteeOffsets>(x => Structs.OracleAccountCommitteeOffsets.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrCommitteeOffsets.Decode(bytes.Skip(indexCommitteeOffsets + prefixOffset).ToArray());
                    ret.CommitteeOffsets = arrCommitteeOffsets.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as OracleAccount);
                }
                public bool Equals(OracleAccount? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(OracleAccount left, OracleAccount right)
                {
                    return EqualityComparer<OracleAccount>.Default.Equals(left, right);
                }
                public static bool operator !=(OracleAccount left, OracleAccount right)
                {
                    return !(left == right);
                }

            }

            public class OracleAccountCommitteeOffsets : AVMObjectType
            {
                public ushort Field0 { get; set; }

                public ushort Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
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

                public static OracleAccountCommitteeOffsets Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new OracleAccountCommitteeOffsets();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ushort vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ushort vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as OracleAccountCommitteeOffsets);
                }
                public bool Equals(OracleAccountCommitteeOffsets? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(OracleAccountCommitteeOffsets left, OracleAccountCommitteeOffsets right)
                {
                    return EqualityComparer<OracleAccountCommitteeOffsets>.Default.Equals(left, right);
                }
                public static bool operator !=(OracleAccountCommitteeOffsets left, OracleAccountCommitteeOffsets right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Get account ID if exists, else return 0
        ///</summary>
        /// <param name="account">account to look up </param>
        public async Task<Structs.OracleAccount> GetAccount(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 7, 19, 242 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.OracleAccount.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAccount_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 7, 19, 242 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Log multiple accounts' IDs (or zero if not found)
        ///Used to fetch account>ID quickly off-chain
        ///</summary>
        /// <param name="accounts">accounts to log </param>
        public async Task LogAccounts(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 32, 185, 249 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            var result = await base.SimApp(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogAccounts_Transactions(Algorand.Address[] accounts, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 32, 185, 249 };
            var accountsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); accountsAbi.From(accounts);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Utility to increase opcode budget by performing $itxns no-op itxns
        ///</summary>
        /// <param name="itxns">Number of no-op itxns to perform </param>
        public async Task IncreaseBudget(ulong itxns, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 24, 236, 191 };
            var itxnsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); itxnsAbi.From(itxns);

            var result = await base.CallApp(new List<object> { abiHandle, itxnsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncreaseBudget_Transactions(ulong itxns, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 24, 236, 191 };
            var itxnsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); itxnsAbi.From(itxns);

            return await base.MakeTransactionList(new List<object> { abiHandle, itxnsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3JhY2xlQWNjb3VudENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9yYWNsZUFjY291bnQiOlt7Im5hbWUiOiJhY2NvdW50SWQiLCJ0eXBlIjoidWludDMyIn0seyJuYW1lIjoiY29tbWl0dGVlT2Zmc2V0cyIsInR5cGUiOiJPcmFjbGVBY2NvdW50Q29tbWl0dGVlT2Zmc2V0c1tdIn1dLCJPcmFjbGVBY2NvdW50Q29tbWl0dGVlT2Zmc2V0cyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDE2In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldEFjY291bnQiLCJkZXNjIjoiR2V0IGFjY291bnQgSUQgaWYgZXhpc3RzLCBlbHNlIHJldHVybiAwIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6ImFjY291bnQgdG8gbG9vayB1cCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDMyLCh1aW50MTYsdWludDE2KVtdKSIsInN0cnVjdCI6Ik9yYWNsZUFjY291bnQiLCJkZXNjIjoiYWNjb3VudCBJRCBvciAwIGlmIG5vdCBmb3VuZCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nQWNjb3VudHMiLCJkZXNjIjoiTG9nIG11bHRpcGxlIGFjY291bnRzJyBJRHMgKG9yIHplcm8gaWYgbm90IGZvdW5kKVxuVXNlZCB0byBmZXRjaCBhY2NvdW50PklEIHF1aWNrbHkgb2ZmLWNoYWluIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRzIiwiZGVzYyI6ImFjY291bnRzIHRvIGxvZyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluY3JlYXNlQnVkZ2V0IiwiZGVzYyI6IlV0aWxpdHkgdG8gaW5jcmVhc2Ugb3Bjb2RlIGJ1ZGdldCBieSBwZXJmb3JtaW5nICRpdHhucyBuby1vcCBpdHhucyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdHhucyIsImRlc2MiOiJOdW1iZXIgb2Ygbm8tb3AgaXR4bnMgdG8gcGVyZm9ybSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIyMl0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFjY291bnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURNeUNpQWdJQ0JpZVhSbFkySnNiMk5ySUdKaGMyVTJOQ2hETkVWQ1VYYzlQU2tLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtRmpiR1V2YjNKaFkyeGxMV0ZqWTI5MWJuUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdiR0Z6ZEVGalkyOTFiblJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklEQWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWliR0Z6ZEVGalkyOTFiblJKWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSmhZMnhsTDI5eVlXTnNaUzFoWTJOdmRXNTBMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUGNtRmpiR1ZCWTJOdmRXNTBRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkNZWE5sUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXlDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR00yTURjeE0yWXlJREI0WVRJeU1HSTVaamtnTUhnME1URTRaV05pWmlBdkx5QnRaWFJvYjJRZ0ltZGxkRUZqWTI5MWJuUW9ZV1JrY21WemN5a29kV2x1ZERNeUxDaDFhVzUwTVRZc2RXbHVkREUyS1Z0ZEtTSXNJRzFsZEdodlpDQWliRzluUVdOamIzVnVkSE1vWVdSa2NtVnpjMXRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWx1WTNKbFlYTmxRblZrWjJWMEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWjJWMFFXTmpiM1Z1ZENCc2IyZEJZMk52ZFc1MGN5QnBibU55WldGelpVSjFaR2RsZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbUZqYkdVdmIzSmhZMnhsTFdGalkyOTFiblF1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFOXlZV05zWlVGalkyOTFiblJEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRUpoYzJWRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbUZqYkdVdmIzSmhZMnhsTFdGalkyOTFiblF1WVd4bmJ5NTBjem82VDNKaFkyeGxRV05qYjNWdWRFTnZiblJ5WVdOMExtZGxkRUZqWTI5MWJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSQlkyTnZkVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTOXZjbUZqYkdVdFlXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pFeU53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtRmpiR1V2YjNKaFkyeGxMV0ZqWTI5MWJuUXVZV3huYnk1MGN6b3hNamtLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1kbGRFRmpZMjkxYm5SSlprVjRhWE4wY3loaFkyTnZkVzUwS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJCWTJOdmRXNTBTV1pGZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtRmpiR1V2YjNKaFkyeGxMV0ZqWTI5MWJuUXVZV3huYnk1MGN6b3hNamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlZV05zWlM5dmNtRmpiR1V0WVdOamIzVnVkQzVoYkdkdkxuUnpPanBQY21GamJHVkJZMk52ZFc1MFEyOXVkSEpoWTNRdWJHOW5RV05qYjNWdWRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BzYjJkQlkyTnZkVzUwY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21GamJHVXZiM0poWTJ4bExXRmpZMjkxYm5RdVlXeG5ieTUwY3pveE16Y0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhZMk52ZFc1MFBnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NteHZaMEZqWTI5MWJuUnpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21GamJHVXZiM0poWTJ4bExXRmpZMjkxYm5RdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZV05qYjNWdWRDQnZaaUJoWTJOdmRXNTBjeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2diRzluUVdOamIzVnVkSE5mWVdaMFpYSmZabTl5UURVS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTOXZjbUZqYkdVdFlXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pFME1Bb2dJQ0FnTHk4Z2JHOW5LR1Z1WTI5a1pVRnlZelFvZEdocGN5NW5aWFJCWTJOdmRXNTBTV1pGZUdsemRITW9ZV05qYjNWdWRDa3BLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUkJZMk52ZFc1MFNXWkZlR2x6ZEhNS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnNiMmRCWTJOdmRXNTBjMTltYjNKZmFHVmhaR1Z5UURJS0NteHZaMEZqWTI5MWJuUnpYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTOXZjbUZqYkdVdFlXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZbUZ6WlM1aGJHZHZMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVhVzVqY21WaGMyVkNkV1JuWlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibU55WldGelpVSjFaR2RsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwySmhjMlV1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlpWVhObExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQnBkSGh1Y3pzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LYVc1amNtVmhjMlZDZFdSblpYUmZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5aVlYTmxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JwZEhodWN6c2dhU3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJwYm1OeVpXRnpaVUoxWkdkbGRGOWhablJsY2w5M2FHbHNaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5aVlYTmxMbUZzWjI4dWRITTZNalV0TXpFS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRPaUJsYlhCMGVTNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd2dMeThnYVc1MFpXNTBhVzl1WVd4c2VTQjFjMmx1WnlCamJHVmhjaUJ6ZEdGMFpTQndjbTluY21GdElHWnZjaUFpY21WMGRYSnVJSFJ5ZFdVaUNpQWdJQ0F2THlBZ0lDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJR1Z0Y0hSNUxtTnNaV0Z5VTNSaGRHVlFjbTluY21GdExBb2dJQ0FnTHk4Z0lDQWdJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1RVpXeGxkR1ZCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWlZWE5sTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhjMlV2WW1GelpTNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QmpiMjV6ZENCbGJYQjBlU0E5SUdOdmJYQnBiR1VvUlcxd2RIbERiMjUwY21GamRDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z1ltRnpaVFkwS0VNMFJVSlJkejA5S1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYkdWaGNsTjBZWFJsVUhKdlozSmhiVkJoWjJWekNpQWdJQ0JpZVhSbFkxOHdJQzh2SUdKaGMyVTJOQ2hETkVWQ1VYYzlQU2tLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3Y205MllXeFFjbTluY21GdFVHRm5aWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJKaGMyVXVZV3huYnk1MGN6b3lOUzB6TUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCeWIzWmhiRkJ5YjJkeVlXMDZJR1Z0Y0hSNUxtTnNaV0Z5VTNSaGRHVlFjbTluY21GdExDQXZMeUJwYm5SbGJuUnBiMjVoYkd4NUlIVnphVzVuSUdOc1pXRnlJSE4wWVhSbElIQnliMmR5WVcwZ1ptOXlJQ0p5WlhSMWNtNGdkSEoxWlNJS0lDQWdJQzh2SUNBZ0lDQmpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJUb2daVzF3ZEhrdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lDQWdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlltRnpaUzVoYkdkdkxuUnpPakkxTFRNeENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzVUhKdlozSmhiVG9nWlcxd2RIa3VZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMHNJQzh2SUdsdWRHVnVkR2x2Ym1Gc2JIa2dkWE5wYm1jZ1kyeGxZWElnYzNSaGRHVWdjSEp2WjNKaGJTQm1iM0lnSW5KbGRIVnliaUIwY25WbElnb2dJQ0FnTHk4Z0lDQWdJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJsYlhCMGVTNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd0tJQ0FnSUM4dklDQWdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMkpoYzJVdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHbDBlRzV6T3lCcEt5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCcGJtTnlaV0Z6WlVKMVpHZGxkRjkzYUdsc1pWOTBiM0JBTWdvS2FXNWpjbVZoYzJWQ2RXUm5aWFJmWVdaMFpYSmZkMmhwYkdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMkpoYzJVdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlZV05zWlM5dmNtRmpiR1V0WVdOamIzVnVkQzVoYkdkdkxuUnpPanBQY21GamJHVkJZMk52ZFc1MFEyOXVkSEpoWTNRdVoyVjBRV05qYjNWdWRFbG1SWGhwYzNSektHRmpZMjkxYm5RNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBRV05qYjNWdWRFbG1SWGhwYzNSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVlXTnNaUzl2Y21GamJHVXRZV05qYjNWdWRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QndjbTkwWldOMFpXUWdaMlYwUVdOamIzVnVkRWxtUlhocGMzUnpLR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXBPaUJQY21GamJHVkJZMk52ZFc1MElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WVdOc1pTOXZjbUZqYkdVdFlXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCaFkyTnZkVzUwY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCUGNtRmpiR1ZCWTJOdmRXNTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRW5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbUVpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0poWTJ4bEwyOXlZV05zWlMxaFkyTnZkVzUwTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUdsbUlDaGliM2d1WlhocGMzUnpLU0J5WlhSMWNtNGdZbTk0TG5aaGJIVmxDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdkbGRFRmpZMjkxYm5SSlprVjRhWE4wYzE5bGJITmxYMkp2WkhsQU1nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWRsZEVGalkyOTFiblJKWmtWNGFYTjBjMTlsYkhObFgySnZaSGxBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21GamJHVXZiM0poWTJ4bExXRmpZMjkxYm5RdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhzZ1lXTmpiM1Z1ZEVsa09pQmhZMk52ZFc1MFNXUXNJR052YlcxcGRIUmxaVTltWm5ObGRITTZJRnRkSUgwS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd05qQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbUZqYkdVdmIzSmhZMnhsTFdGalkyOTFiblF1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWld4elpTQnlaWFIxY200Z2RHaHBjeTVuWlhSRmJYQjBlVTl5WVdOc1pVRmpZMjkxYm5Rb2RUTXlLREFwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUUFnSmdFRUM0RUJRekVZUUFBUmdBMXNZWE4wUVdOamIzVnVkRWxrSTJjeEcwRUFKREVaRkVReEdFU0NBd1RHQnhQeUJLSWd1ZmtFUVJqc3Z6WWFBSTREQUFzQUlRQlhBREVaRkRFWUZCQkVJa00yR2dGSkZTUVNSSWdBYW9BRUZSOThkVXhRc0NKRE5ob0JSd0lqV1VsT0FpUUxnUUlJVEJVU1JDTkpTd0lNUVFBWlN3SlhBZ0JMQVVsT0FpUUxKRmlJQURPd0lnaEZBVUwvNENKRE5ob0JGeU5KU3dJTVFRQWJzWUVGc2hrb3NrSW9za0NCQnJJUUk3SUJzMGtpQ0VVQlF2L2VJa09LQVFHQUFXR0wvMUJKdlVVQlFRQUdpd0MrUkV5SmdBZ0FBQUFBQUFZQUFFeUoiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
