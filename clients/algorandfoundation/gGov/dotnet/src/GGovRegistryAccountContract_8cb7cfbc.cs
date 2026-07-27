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

namespace Arc56.Generated.algorandfoundation.gGov.GGovRegistryAccountContract_8cb7cfbc
{


    public class GGovRegistryAccountContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GGovRegistryAccountContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GGovAccount : AVMObjectType
            {
                public uint AccountId { get; set; }

                public Structs.GGovAccountCommitteeOffsets[] CommitteeOffsets { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vAccountId.From(AccountId);
                    ret.AddRange(vAccountId.Encode());
                    var arrCommitteeOffsets = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GGovAccountCommitteeOffsets>(x => Structs.GGovAccountCommitteeOffsets.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrCommitteeOffsets.Value = (CommitteeOffsets ?? Array.Empty<Structs.GGovAccountCommitteeOffsets>()).ToList();
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

                public static GGovAccount Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GGovAccount();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vAccountId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccountId = vAccountId.ToValue();
                    if (valueAccountId is uint vAccountIdValue) { ret.AccountId = vAccountIdValue; }
                    var indexCommitteeOffsets = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrCommitteeOffsets = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GGovAccountCommitteeOffsets>(x => Structs.GGovAccountCommitteeOffsets.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
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
                    return Equals(obj as GGovAccount);
                }
                public bool Equals(GGovAccount? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GGovAccount left, GGovAccount right)
                {
                    return EqualityComparer<GGovAccount>.Default.Equals(left, right);
                }
                public static bool operator !=(GGovAccount left, GGovAccount right)
                {
                    return !(left == right);
                }

            }

            public class GGovAccountCommitteeOffsets : AVMObjectType
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

                public static GGovAccountCommitteeOffsets Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GGovAccountCommitteeOffsets();
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
                    return Equals(obj as GGovAccountCommitteeOffsets);
                }
                public bool Equals(GGovAccountCommitteeOffsets? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GGovAccountCommitteeOffsets left, GGovAccountCommitteeOffsets right)
                {
                    return EqualityComparer<GGovAccountCommitteeOffsets>.Default.Equals(left, right);
                }
                public static bool operator !=(GGovAccountCommitteeOffsets left, GGovAccountCommitteeOffsets right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Get account ID if exists, else return 0
        ///</summary>
        /// <param name="account">account to look up </param>
        public async Task<Structs.GGovAccount> GetAccount(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            return Structs.GGovAccount.Parse(lastLogBytes.Skip(4).ToArray());

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR0dvdlJlZ2lzdHJ5QWNjb3VudENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdHb3ZBY2NvdW50IjpbeyJuYW1lIjoiYWNjb3VudElkIiwidHlwZSI6InVpbnQzMiJ9LHsibmFtZSI6ImNvbW1pdHRlZU9mZnNldHMiLCJ0eXBlIjoiR0dvdkFjY291bnRDb21taXR0ZWVPZmZzZXRzW10ifV0sIkdHb3ZBY2NvdW50Q29tbWl0dGVlT2Zmc2V0cyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDE2In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldEFjY291bnQiLCJkZXNjIjoiR2V0IGFjY291bnQgSUQgaWYgZXhpc3RzLCBlbHNlIHJldHVybiAwIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6ImFjY291bnQgdG8gbG9vayB1cCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDMyLCh1aW50MTYsdWludDE2KVtdKSIsInN0cnVjdCI6IkdHb3ZBY2NvdW50IiwiZGVzYyI6ImFjY291bnQgSUQgb3IgMCBpZiBub3QgZm91bmQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ0FjY291bnRzIiwiZGVzYyI6IkxvZyBtdWx0aXBsZSBhY2NvdW50cycgSURzIChvciB6ZXJvIGlmIG5vdCBmb3VuZClcblVzZWQgdG8gZmV0Y2ggYWNjb3VudD5JRCBxdWlja2x5IG9mZi1jaGFpbiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50cyIsImRlc2MiOiJhY2NvdW50cyB0byBsb2ciLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZWFzZUJ1ZGdldCIsImRlc2MiOiJVdGlsaXR5IHRvIGluY3JlYXNlIG9wY29kZSBidWRnZXQgYnkgcGVyZm9ybWluZyAkaXR4bnMgbm8tb3AgaXR4bnMiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXR4bnMiLCJkZXNjIjoiTnVtYmVyIG9mIG5vLW9wIGl0eG5zIHRvIHBlcmZvcm0iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMjJdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhY2NvdW50PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lETXlDaUFnSUNCaWVYUmxZMkpzYjJOcklHSmhjMlUyTkNoRE5FVkNVWGM5UFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aMjkyTFhKbFoybHpkSEo1TDJkbmIzWlNaV2RwYzNSeWVVRmpZMjkxYm5RdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2JHRnpkRUZqWTI5MWJuUkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SURBZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWJHRnpkRUZqWTI5MWJuUkpaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WjJkdmRpMXlaV2RwYzNSeWVTOW5aMjkyVW1WbmFYTjBjbmxCWTJOdmRXNTBMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCSFIyOTJVbVZuYVhOMGNubEJZMk52ZFc1MFEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCQ1lYTmxRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHTTJNRGN4TTJZeUlEQjRZVEl5TUdJNVpqa2dNSGcwTVRFNFpXTmlaaUF2THlCdFpYUm9iMlFnSW1kbGRFRmpZMjkxYm5Rb1lXUmtjbVZ6Y3lrb2RXbHVkRE15TENoMWFXNTBNVFlzZFdsdWRERTJLVnRkS1NJc0lHMWxkR2h2WkNBaWJHOW5RV05qYjNWdWRITW9ZV1JrY21WemMxdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHVZM0psWVhObFFuVmtaMlYwS0hWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2daMlYwUVdOamIzVnVkQ0JzYjJkQlkyTnZkVzUwY3lCcGJtTnlaV0Z6WlVKMVpHZGxkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bloyOTJMWEpsWjJsemRISjVMMmRuYjNaU1pXZHBjM1J5ZVVGalkyOTFiblF1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFZEhiM1pTWldkcGMzUnllVUZqWTI5MWJuUkRiMjUwY21GamRDQmxlSFJsYm1SeklFSmhjMlZEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0lDWW1JR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bloyOTJMWEpsWjJsemRISjVMMmRuYjNaU1pXZHBjM1J5ZVVGalkyOTFiblF1WVd4bmJ5NTBjem82UjBkdmRsSmxaMmx6ZEhKNVFXTmpiM1Z1ZEVOdmJuUnlZV04wTG1kbGRFRmpZMjkxYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJCWTJOdmRXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZG5iM1l0Y21WbmFYTjBjbmt2WjJkdmRsSmxaMmx6ZEhKNVFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pFeU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bloyOTJMWEpsWjJsemRISjVMMmRuYjNaU1pXZHBjM1J5ZVVGalkyOTFiblF1WVd4bmJ5NTBjem94TWpVS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtZGxkRUZqWTI5MWJuUkpaa1Y0YVhOMGN5aGhZMk52ZFc1MEtRb2dJQ0FnWTJGc2JITjFZaUJuWlhSQlkyTnZkVzUwU1daRmVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aMjkyTFhKbFoybHpkSEo1TDJkbmIzWlNaV2RwYzNSeWVVRmpZMjkxYm5RdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbmIzWXRjbVZuYVhOMGNua3ZaMmR2ZGxKbFoybHpkSEo1UVdOamIzVnVkQzVoYkdkdkxuUnpPanBIUjI5MlVtVm5hWE4wY25sQlkyTnZkVzUwUTI5dWRISmhZM1F1Ykc5blFXTmpiM1Z1ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHNiMmRCWTJOdmRXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW5aMjkyTFhKbFoybHpkSEo1TDJkbmIzWlNaV2RwYzNSeWVVRmpZMjkxYm5RdVlXeG5ieTUwY3pveE16TUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhZMk52ZFc1MFBnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NteHZaMEZqWTI5MWJuUnpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWjI5MkxYSmxaMmx6ZEhKNUwyZG5iM1pTWldkcGMzUnllVUZqWTI5MWJuUXVZV3huYnk1MGN6b3hNelVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVdOamIzVnVkQ0J2WmlCaFkyTnZkVzUwY3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEFvZ0lDQWdZbm9nYkc5blFXTmpiM1Z1ZEhOZllXWjBaWEpmWm05eVFEVUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbmIzWXRjbVZuYVhOMGNua3ZaMmR2ZGxKbFoybHpkSEo1UVdOamIzVnVkQzVoYkdkdkxuUnpPakV6TmdvZ0lDQWdMeThnYkc5bktHVnVZMjlrWlVGeVl6UW9kR2hwY3k1blpYUkJZMk52ZFc1MFNXWkZlR2x6ZEhNb1lXTmpiM1Z1ZENrcEtRb2dJQ0FnWTJGc2JITjFZaUJuWlhSQlkyTnZkVzUwU1daRmVHbHpkSE1LSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCc2IyZEJZMk52ZFc1MGMxOW1iM0pmYUdWaFpHVnlRRElLQ214dlowRmpZMjkxYm5SelgyRm1kR1Z5WDJadmNrQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZG5iM1l0Y21WbmFYTjBjbmt2WjJkdmRsSmxaMmx6ZEhKNVFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pFek13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZbUZ6WlM1aGJHZHZMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVhVzVqY21WaGMyVkNkV1JuWlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibU55WldGelpVSjFaR2RsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwySmhjMlV1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lIWmhiR2xrWVhSbFJXNWpiMlJwYm1jNklDZDFibk5oWm1VdFpHbHpZV0pzWldRbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlpWVhObExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQnBkSGh1Y3pzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LYVc1amNtVmhjMlZDZFdSblpYUmZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5aVlYTmxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JwZEhodWN6c2dhU3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJwYm1OeVpXRnpaVUoxWkdkbGRGOWhablJsY2w5M2FHbHNaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5aVlYTmxMbUZzWjI4dWRITTZNalV0TXpFS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRPaUJsYlhCMGVTNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd2dMeThnYVc1MFpXNTBhVzl1WVd4c2VTQjFjMmx1WnlCamJHVmhjaUJ6ZEdGMFpTQndjbTluY21GdElHWnZjaUFpY21WMGRYSnVJSFJ5ZFdVaUNpQWdJQ0F2THlBZ0lDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJR1Z0Y0hSNUxtTnNaV0Z5VTNSaGRHVlFjbTluY21GdExBb2dJQ0FnTHk4Z0lDQWdJRzl1UTI5dGNHeGxkR2x2YmpvZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1RVpXeGxkR1ZCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWlZWE5sTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhjMlV2WW1GelpTNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QmpiMjV6ZENCbGJYQjBlU0E5SUdOdmJYQnBiR1VvUlcxd2RIbERiMjUwY21GamRDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z1ltRnpaVFkwS0VNMFJVSlJkejA5S1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYkdWaGNsTjBZWFJsVUhKdlozSmhiVkJoWjJWekNpQWdJQ0JpZVhSbFkxOHdJQzh2SUdKaGMyVTJOQ2hETkVWQ1VYYzlQU2tLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3Y205MllXeFFjbTluY21GdFVHRm5aWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJKaGMyVXVZV3huYnk1MGN6b3lOUzB6TUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCeWIzWmhiRkJ5YjJkeVlXMDZJR1Z0Y0hSNUxtTnNaV0Z5VTNSaGRHVlFjbTluY21GdExDQXZMeUJwYm5SbGJuUnBiMjVoYkd4NUlIVnphVzVuSUdOc1pXRnlJSE4wWVhSbElIQnliMmR5WVcwZ1ptOXlJQ0p5WlhSMWNtNGdkSEoxWlNJS0lDQWdJQzh2SUNBZ0lDQmpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJUb2daVzF3ZEhrdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lDQWdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlltRnpaUzVoYkdkdkxuUnpPakkxTFRNeENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzVUhKdlozSmhiVG9nWlcxd2RIa3VZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMHNJQzh2SUdsdWRHVnVkR2x2Ym1Gc2JIa2dkWE5wYm1jZ1kyeGxZWElnYzNSaGRHVWdjSEp2WjNKaGJTQm1iM0lnSW5KbGRIVnliaUIwY25WbElnb2dJQ0FnTHk4Z0lDQWdJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJsYlhCMGVTNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd0tJQ0FnSUM4dklDQWdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMkpoYzJVdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHbDBlRzV6T3lCcEt5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCcGJtTnlaV0Z6WlVKMVpHZGxkRjkzYUdsc1pWOTBiM0JBTWdvS2FXNWpjbVZoYzJWQ2RXUm5aWFJmWVdaMFpYSmZkMmhwYkdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMkpoYzJVdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZG5iM1l0Y21WbmFYTjBjbmt2WjJkdmRsSmxaMmx6ZEhKNVFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pwSFIyOTJVbVZuYVhOMGNubEJZMk52ZFc1MFEyOXVkSEpoWTNRdVoyVjBRV05qYjNWdWRFbG1SWGhwYzNSektHRmpZMjkxYm5RNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBRV05qYjNWdWRFbG1SWGhwYzNSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJkbmIzWXRjbVZuYVhOMGNua3ZaMmR2ZGxKbFoybHpkSEo1UVdOamIzVnVkQzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJ3Y205MFpXTjBaV1FnWjJWMFFXTmpiM1Z1ZEVsbVJYaHBjM1J6S0dGalkyOTFiblE2SUVGalkyOTFiblFwT2lCSFIyOTJRV05qYjNWdWRDQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWjI5MkxYSmxaMmx6ZEhKNUwyZG5iM1pTWldkcGMzUnllVUZqWTI5MWJuUXVZV3huYnk1MGN6b3hOd29nSUNBZ0x5OGdZV05qYjNWdWRITWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dSMGR2ZGtGalkyOTFiblErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZU2NnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTluWjI5MkxYSmxaMmx6ZEhKNUwyZG5iM1pTWldkcGMzUnllVUZqWTI5MWJuUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdhV1lnS0dKdmVDNWxlR2x6ZEhNcElISmxkSFZ5YmlCaWIzZ3VkbUZzZFdVS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwUVdOamIzVnVkRWxtUlhocGMzUnpYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1oyVjBRV05qYjNWdWRFbG1SWGhwYzNSelgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZG5iM1l0Y21WbmFYTjBjbmt2WjJkdmRsSmxaMmx6ZEhKNVFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCeVpYUjFjbTRnZXlCaFkyTnZkVzUwU1dRNklHRmpZMjkxYm5SSlpDd2dZMjl0YldsMGRHVmxUMlptYzJWMGN6b2dXMTBnZlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBMk1EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyZG5iM1l0Y21WbmFYTjBjbmt2WjJkdmRsSmxaMmx6ZEhKNVFXTmpiM1Z1ZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCbGJITmxJSEpsZEhWeWJpQjBhR2x6TG1kbGRFVnRjSFI1UjBkdmRrRmpZMjkxYm5Rb2RUTXlLREFwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUUFnSmdFRUM0RUJRekVZUUFBUmdBMXNZWE4wUVdOamIzVnVkRWxrSTJjeEcwRUFKREVaRkVReEdFU0NBd1RHQnhQeUJLSWd1ZmtFUVJqc3Z6WWFBSTREQUFzQUlRQlhBREVaRkRFWUZCQkVJa00yR2dGSkZTUVNSSWdBYW9BRUZSOThkVXhRc0NKRE5ob0JSd0lqV1VsT0FpUUxnUUlJVEJVU1JDTkpTd0lNUVFBWlN3SlhBZ0JMQVVsT0FpUUxKRmlJQURPd0lnaEZBVUwvNENKRE5ob0JGeU5KU3dJTVFRQWJzWUVGc2hrb3NrSW9za0NCQnJJUUk3SUJzMGtpQ0VVQlF2L2VJa09LQVFHQUFXR0wvMUJKdlVVQlFRQUdpd0MrUkV5SmdBZ0FBQUFBQUFZQUFFeUoiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
