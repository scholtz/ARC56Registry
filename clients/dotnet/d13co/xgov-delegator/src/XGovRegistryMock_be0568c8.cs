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

namespace Arc56.Generated.d13co.xgov_delegator.XGovRegistryMock_be0568c8
{


    public class XGovRegistryMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public XGovRegistryMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class XGovBoxValue : AVMObjectType
            {
                public Algorand.Address VotingAddress { get; set; }

                public ulong ToleratedAbsences { get; set; }

                public ulong LastVoteTimestamp { get; set; }

                public ulong SubscriptionRound { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vVotingAddress.From(VotingAddress);
                    ret.AddRange(vVotingAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToleratedAbsences = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vToleratedAbsences.From(ToleratedAbsences);
                    ret.AddRange(vToleratedAbsences.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVoteTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastVoteTimestamp.From(LastVoteTimestamp);
                    ret.AddRange(vLastVoteTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscriptionRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSubscriptionRound.From(SubscriptionRound);
                    ret.AddRange(vSubscriptionRound.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static XGovBoxValue Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new XGovBoxValue();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVotingAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotingAddress = vVotingAddress.ToValue();
                    if (valueVotingAddress is Algorand.Address vVotingAddressValue) { ret.VotingAddress = vVotingAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToleratedAbsences = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vToleratedAbsences.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueToleratedAbsences = vToleratedAbsences.ToValue();
                    if (valueToleratedAbsences is ulong vToleratedAbsencesValue) { ret.ToleratedAbsences = vToleratedAbsencesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVoteTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastVoteTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastVoteTimestamp = vLastVoteTimestamp.ToValue();
                    if (valueLastVoteTimestamp is ulong vLastVoteTimestampValue) { ret.LastVoteTimestamp = vLastVoteTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscriptionRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSubscriptionRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSubscriptionRound = vSubscriptionRound.ToValue();
                    if (valueSubscriptionRound is ulong vSubscriptionRoundValue) { ret.SubscriptionRound = vSubscriptionRoundValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as XGovBoxValue);
                }
                public bool Equals(XGovBoxValue? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(XGovBoxValue left, XGovBoxValue right)
                {
                    return EqualityComparer<XGovBoxValue>.Default.Equals(left, right);
                }
                public static bool operator !=(XGovBoxValue left, XGovBoxValue right)
                {
                    return !(left == right);
                }

            }

            public class GetXgovBoxReturn : AVMObjectType
            {
                public Structs.XGovBoxValue Field0 { get; set; } = new Structs.XGovBoxValue();

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetXgovBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetXgovBoxReturn();
                    uint count = 0;
                    ret.Field0 = Structs.XGovBoxValue.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetXgovBoxReturn);
                }
                public bool Equals(GetXgovBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetXgovBoxReturn left, GetXgovBoxReturn right)
                {
                    return EqualityComparer<GetXgovBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetXgovBoxReturn left, GetXgovBoxReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voterAddress"> </param>
        public async Task<Structs.GetXgovBoxReturn> GetXgovBox(Algorand.Address voterAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 99, 13, 101 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);

            var result = await base.SimApp(new List<object> { abiHandle, voterAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetXgovBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetXgovBox_Transactions(Algorand.Address voterAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 99, 13, 101 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> CreateProposal(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 156, 59, 24 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateProposal_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 156, 59, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voterAddress"> </param>
        /// <param name="value"> XGovBoxValue</param>
        public async Task SetXGovBox(Algorand.Address voterAddress, Structs.XGovBoxValue value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 58, 102, 126 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);

            var result = await base.CallApp(new List<object> { abiHandle, voterAddressAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetXGovBox_Transactions(Algorand.Address voterAddress, Structs.XGovBoxValue value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 58, 102, 126 };
            var voterAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAddressAbi.From(voterAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAddressAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWEdvdlJlZ2lzdHJ5TW9jayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJYR292Qm94VmFsdWUiOlt7Im5hbWUiOiJ2b3RpbmdBZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ0b2xlcmF0ZWRBYnNlbmNlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0Vm90ZVRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdWJzY3JpcHRpb25Sb3VuZCIsInR5cGUiOiJ1aW50NjQifV0sIkdldFhnb3ZCb3hSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiWEdvdkJveFZhbHVlIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0X3hnb3ZfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKChhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0KSxib29sKSIsInN0cnVjdCI6IkdldFhnb3ZCb3hSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZVByb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0WEdvdkJveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJYR292Qm94VmFsdWUiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVhc2VCdWRnZXQiLCJkZXNjIjoiVXRpbGl0eSB0byBpbmNyZWFzZSBvcGNvZGUgYnVkZ2V0IGJ5IHBlcmZvcm1pbmcgJGl0eG5zIG5vLW9wIGl0eG5zIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0eG5zIiwiZGVzYyI6Ik51bWJlciBvZiBuby1vcCBpdHhucyB0byBwZXJmb3JtIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTI0XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDgsNjk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMveGdvdi1yZWdpc3RyeS1tb2NrL3hHb3ZSZWdpc3RyeU1vY2suYWxnby50czo6WEdvdkJveFZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURZZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ1ltRnpaVFkwS0VNMFJVSlJkejA5S1NBaWVDSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZV05qYjNWdWRDMXBaQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR3hoYzNSQlkyTnZkVzUwU1dRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXdJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbXhoYzNSQlkyTnZkVzUwU1dRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJZUjI5MlVtVm5hWE4wY25sTmIyTnJJR1Y0ZEdWdVpITWdRV05qYjNWdWRFbGtRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFekNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VESTNOak13WkRZMUlEQjRaRFk1WXpOaU1UZ2dNSGhrWmpOaE5qWTNaU0F3ZURReE1UaGxZMkptSUM4dklHMWxkR2h2WkNBaVoyVjBYM2huYjNaZlltOTRLR0ZrWkhKbGMzTXBLQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1N4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpWTNKbFlYUmxVSEp2Y0c5ellXd29LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljMlYwV0VkdmRrSnZlQ2hoWkdSeVpYTnpMQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NsMmIybGtJaXdnYldWMGFHOWtJQ0pwYm1OeVpXRnpaVUoxWkdkbGRDaDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdkbGRGaEhiM1pDYjNnZ1kzSmxZWFJsVUhKdmNHOXpZV3dnYzJWMFdFZHZka0p2ZUNCcGJtTnlaV0Z6WlVKMVpHZGxkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEpsWjJsemRISjVMVzF2WTJzdmVFZHZkbEpsWjJsemRISjVUVzlqYXk1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdXRWR2ZGxKbFoybHpkSEo1VFc5amF5QmxlSFJsYm1SeklFRmpZMjkxYm5SSlpFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FnSmlZZ1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNtVm5hWE4wY25rdGJXOWpheTk0UjI5MlVtVm5hWE4wY25sTmIyTnJMbUZzWjI4dWRITTZPbGhIYjNaU1pXZHBjM1J5ZVUxdlkyc3VaMlYwV0VkdmRrSnZlRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGaEhiM1pDYjNnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXlaV2RwYzNSeWVTMXRiMk5yTDNoSGIzWlNaV2RwYzNSeWVVMXZZMnN1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsTENCdVlXMWxPaUFuWjJWMFgzaG5iM1pmWW05NEp5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2VHZHZka0p2ZUNBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCWVIyOTJRbTk0Vm1Gc2RXVStLSHNnYTJWNVVISmxabWw0T2lBbmVDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbmdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNtVm5hWE4wY25rdGJXOWpheTk0UjI5MlVtVm5hWE4wY25sTmIyTnJMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR052Ym5OMElIc2daWGhwYzNSeklIMGdQU0JpYjNnS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhKbFoybHpkSEo1TFcxdlkyc3ZlRWR2ZGxKbFoybHpkSEo1VFc5amF5NWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmpiMjV6ZENCMllXeDFaVG9nV0VkdmRrSnZlRlpoYkhWbElEMGdaWGhwYzNSeklEOGdZbTk0TG5aaGJIVmxJRG9nZEdocGN5NW5aWFJGYlhCMGVWaEhiM1pDYjNoV1lXeDFaU2dwQ2lBZ0lDQmllaUJuWlhSWVIyOTJRbTk0WDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2dwblpYUllSMjkyUW05NFgzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYSmxaMmx6ZEhKNUxXMXZZMnN2ZUVkdmRsSmxaMmx6ZEhKNVRXOWpheTVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXM1poYkhWbExDQmxlR2x6ZEhOZENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTd2dibUZ0WlRvZ0oyZGxkRjk0WjI5MlgySnZlQ2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRmhIYjNaQ2IzaGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjbVZuYVhOMGNua3RiVzlqYXk5NFIyOTJVbVZuYVhOMGNubE5iMk5yTG1Gc1oyOHVkSE02TXpVdE5EQUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lIWnZkR2x1WjBGa1pISmxjM002SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2RHOXNaWEpoZEdWa1FXSnpaVzVqWlhNNklEQXNDaUFnSUNBdkx5QWdJR3hoYzNSV2IzUmxWR2x0WlhOMFlXMXdPaUF3TEFvZ0lDQWdMeThnSUNCemRXSnpZM0pwY0hScGIyNVNiM1Z1WkRvZ01Dd0tJQ0FnSUM4dklIMEtJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxNeklvUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCS1FvZ0lDQWdZaUJuWlhSWVIyOTJRbTk0WDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEpsWjJsemRISjVMVzF2WTJzdmVFZHZkbEpsWjJsemRISjVUVzlqYXk1aGJHZHZMblJ6T2pwWVIyOTJVbVZuYVhOMGNubE5iMk5yTG1OeVpXRjBaVkJ5YjNCdmMyRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxVSEp2Y0c5ellXdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pvME9DMDFOUW9nSUNBZ0x5OGdZMjl1YzNRZ1kzSmxZWFJsWkNBOUlHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUNBZ1lYQndjbTkyWVd4UWNtOW5jbUZ0T2lCd2NtOXdiM05oYkVOdmJuUnlZV04wTG1Gd2NISnZkbUZzVUhKdlozSmhiU3dnTHk4Z2FXNTBaVzUwYVc5dVlXeHNlU0IxYzJsdVp5QmpiR1ZoY2lCemRHRjBaU0J3Y205bmNtRnRJR1p2Y2lBaWNtVjBkWEp1SUhSeWRXVWlDaUFnSUNBdkx5QWdJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUhCeWIzQnZjMkZzUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBzQ2lBZ0lDQXZMeUFnSUNBZ1oyeHZZbUZzVG5WdFFubDBaWE02SURJc0NpQWdJQ0F2THlBZ0lDQWdaMnh2WW1Gc1RuVnRWV2x1ZERvZ05Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1oyeHZZbUZzVG5WdFZXbHVkRG9nTkN3S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVkc2IySmhiRTUxYlZWcGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEpsWjJsemRISjVMVzF2WTJzdmVFZHZkbEpsWjJsemRISjVUVzlqYXk1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCbmJHOWlZV3hPZFcxQ2VYUmxjem9nTWl3S0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVkc2IySmhiRTUxYlVKNWRHVlRiR2xqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNtVm5hWE4wY25rdGJXOWpheTk0UjI5MlVtVm5hWE4wY25sTmIyTnJMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR052Ym5OMElIQnliM0J2YzJGc1EyOXVkSEpoWTNRZ1BTQmpiMjF3YVd4bEtGaEhiM1pRY205d2IzTmhiRTF2WTJzcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUdKaGMyVTJOQ2hETkVWQ1VYYzlQU2tLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMVFZV2RsY3dvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVMk5DaERlVUZGUVZGQlNVbERXVVpEU0VKNVlqTkNkbU15Vm5sQ2JrNHdXVmhTTVdOM2VHcGlNakYwWVZoU01GcFhWbVpoVjFGTlpHMDVNRnBXT1haalIxWjFXRE5TZWtRelduWmtSMngxV2pFNWEyUllTbWhrUjJ4MlltcEZXVkZCUVhsTFJFVkJXbmxyYWxwNWNVRkpRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWcDVjMnBhZVdORlNUSmplRWN3UlVGU2VrVmFSa1ZSZUVkRlUwTkRRVkZyV1ZZclVVSkNhRUp2VGtsRmFIUXdPVmxSVVhWblZsVlZRazVDTms1S05FVlNZM3BHZFZGVFYyNHhjbEJDUzA5cE1WaHZNa2RuUTA5RFFVRk1RVVEwUVZoblFuVkJTRGhCYW5kRFowRk1TVUZOVW10VlRWSm5WVVZGVVdsUmVsbGhRVlZyVmtwU1NrVm5RVVpYVkVaQ1NuWlZiRkJCYTJoQ1FVSnNURUZpTlVWR2VHRkJRVkZCYWxOM1RsVlZTVUZGUmxJNU9HUlZlRkZ6UTBwRVNUQk1MelpFV1dGQlVsVnNSV3RSTWtkblNWWktRa3BGVG1odlJFWlRVVk5TU1VGSFJsSTVPR1JSUVVGelEwcEVUbWh2UWxOU1ZXeEZhMU5KUVVkbmIxUkhZMmxSZWxsaFFWVnJWa3BDU2tWR05HZEJWbmxzVFZwNVNrUk9hRzlDVTFKVmJFVnJVMGxCUldOeFZFZGphVkY2V1dGQlZXdFdTa0pLUlVZMFowRk9hWFJOV25sS1JFNW9iMEpUVWxWclJXdFJXR2xCUVd4S2QxSk5XbmxLUkU1b2IwSlRVbFZzUld0Uk1rZG5Ta3BHVTFGVFVrSmxTVUZCZFVGQlZscFFRV3hDVFVaeU9HbFJla1ZCU1hsb2JGSkNTa0ZCUVhsQlEwVldVMVZxY0VKV1ZsSkpjMEZEU2lrS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2NtOTJZV3hRY205bmNtRnRVR0ZuWlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYSmxaMmx6ZEhKNUxXMXZZMnN2ZUVkdmRsSmxaMmx6ZEhKNVRXOWpheTVoYkdkdkxuUnpPalE0TFRVMENpQWdJQ0F2THlCamIyNXpkQ0JqY21WaGRHVmtJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCeWIzWmhiRkJ5YjJkeVlXMDZJSEJ5YjNCdmMyRnNRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeFFjbTluY21GdExDQXZMeUJwYm5SbGJuUnBiMjVoYkd4NUlIVnphVzVuSUdOc1pXRnlJSE4wWVhSbElIQnliMmR5WVcwZ1ptOXlJQ0p5WlhSMWNtNGdkSEoxWlNJS0lDQWdJQzh2SUNBZ0lDQmpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJUb2djSEp2Y0c5ellXeERiMjUwY21GamRDNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd0tJQ0FnSUM4dklDQWdJQ0JuYkc5aVlXeE9kVzFDZVhSbGN6b2dNaXdLSUNBZ0lDOHZJQ0FnSUNCbmJHOWlZV3hPZFcxVmFXNTBPaUEwTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk5EZ3ROVFVLSUNBZ0lDOHZJR052Ym5OMElHTnlaV0YwWldRZ1BTQnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lHRndjSEp2ZG1Gc1VISnZaM0poYlRvZ2NISnZjRzl6WVd4RGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBzSUM4dklHbHVkR1Z1ZEdsdmJtRnNiSGtnZFhOcGJtY2dZMnhsWVhJZ2MzUmhkR1VnY0hKdlozSmhiU0JtYjNJZ0luSmxkSFZ5YmlCMGNuVmxJZ29nSUNBZ0x5OGdJQ0FnSUdOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0T2lCd2NtOXdiM05oYkVOdmJuUnlZV04wTG1Oc1pXRnlVM1JoZEdWUWNtOW5jbUZ0TEFvZ0lDQWdMeThnSUNBZ0lHZHNiMkpoYkU1MWJVSjVkR1Z6T2lBeUxBb2dJQ0FnTHk4Z0lDQWdJR2RzYjJKaGJFNTFiVlZwYm5RNklEUXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYSmxaMmx6ZEhKNUxXMXZZMnN2ZUVkdmRsSmxaMmx6ZEhKNVRXOWpheTVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJ3Y205d2IzTmhiQzVqWVd4c0xuTmxkRkJ5YjNCdmMyVnlLSHNnWVhCd1NXUXNJR0Z5WjNNNklGdFVlRzR1YzJWdVpHVnlYU0I5S1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EWmtaRE5rTmpFZ0x5OGdiV1YwYUc5a0lDSnpaWFJRY205d2IzTmxjaWhoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVkJ5YjNCdmMyRnNLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk9saEhiM1pTWldkcGMzUnllVTF2WTJzdWMyVjBXRWR2ZGtKdmVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEZoSGIzWkNiM2c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGkxeVpXZHBjM1J5ZVMxdGIyTnJMM2hIYjNaU1pXZHBjM1J5ZVUxdlkyc3VZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdjSFZpYkdsaklITmxkRmhIYjNaQ2IzZ29kbTkwWlhKQlpHUnlaWE56T2lCQlkyTnZkVzUwTENCMllXeDFaVG9nV0VkdmRrSnZlRlpoYkhWbEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEVTJJQzh2SURVMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGkxeVpXZHBjM1J5ZVMxdGIyTnJMM2hIYjNaU1pXZHBjM1J5ZVUxdlkyc3VZV3huYnk1MGN6bzZXRWR2ZGtKdmVGWmhiSFZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5aVlYTmxMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR1Z1YzNWeVpTaFVlRzR1YzJWdVpHVnlJRDA5UFNCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNJR1Z5Y2xWdVlYVjBhRzl5YVhwbFpDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDNWMGFXeHpMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR2xtSUNnaFkyOXVaQ2tnZXdvZ0lDQWdZbTU2SUhObGRGaEhiM1pDYjNoZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5aVlYTmxMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR1Z1YzNWeVpTaFVlRzR1YzJWdVpHVnlJRDA5UFNCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNJR1Z5Y2xWdVlYVjBhRzl5YVhwbFpDa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa0ZWVkVnaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOTFkR2xzY3k1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCc2IyY29ZMjlrWlNrS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdmRYUnBiSE11WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnWlhKeUtDa0tJQ0FnSUdWeWNnb0tjMlYwV0VkdmRrSnZlRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2VHZHZka0p2ZUNBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCWVIyOTJRbTk0Vm1Gc2RXVStLSHNnYTJWNVVISmxabWw0T2lBbmVDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbmdpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXlaV2RwYzNSeWVTMXRiMk5yTDNoSGIzWlNaV2RwYzNSeWVVMXZZMnN1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnZEdocGN5NTRaMjkyUW05NEtIWnZkR1Z5UVdSa2NtVnpjeWt1ZG1Gc2RXVWdQU0JqYkc5dVpTaDJZV3gxWlNrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRGaEhiM1pDYjNnb2RtOTBaWEpCWkdSeVpYTnpPaUJCWTJOdmRXNTBMQ0IyWVd4MVpUb2dXRWR2ZGtKdmVGWmhiSFZsS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhjMlV2WW1GelpTNWhiR2R2TG5Sek9qcENZWE5sUTI5dWRISmhZM1F1YVc1amNtVmhjMlZDZFdSblpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm1OeVpXRnpaVUoxWkdkbGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMkpoYzJVdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5aVlYTmxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JwZEhodWN6c2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS2FXNWpjbVZoYzJWQ2RXUm5aWFJmZDJocGJHVmZkRzl3UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWlZWE5sTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCcGRIaHVjenNnYVNzcktTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCcGJtTnlaV0Z6WlVKMVpHZGxkRjloWm5SbGNsOTNhR2xzWlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWlZWE5sTG1Gc1oyOHVkSE02TWpVdE16RUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUNBZ1lYQndjbTkyWVd4UWNtOW5jbUZ0T2lCbGJYQjBlUzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU3dnTHk4Z2FXNTBaVzUwYVc5dVlXeHNlU0IxYzJsdVp5QmpiR1ZoY2lCemRHRjBaU0J3Y205bmNtRnRJR1p2Y2lBaWNtVjBkWEp1SUhSeWRXVWlDaUFnSUNBdkx5QWdJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUdWdGNIUjVMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0FnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlpWVhObExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHOXVRMjl0Y0d4bGRHbHZiam9nVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVFWld4bGRHVkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUExQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlltRnpaUzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJqYjI1emRDQmxiWEIwZVNBOUlHTnZiWEJwYkdVb1JXMXdkSGxEYjI1MGNtRmpkQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdZbUZ6WlRZMEtFTTBSVUpSZHowOUtRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlZCaFoyVnpDaUFnSUNCaWVYUmxZMTh3SUM4dklHSmhjMlUyTkNoRE5FVkNVWGM5UFNrS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2NtOTJZV3hRY205bmNtRnRVR0ZuWlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwySmhjMlV1WVd4bmJ5NTBjem95TlMwek1Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQnliM1poYkZCeWIyZHlZVzA2SUdWdGNIUjVMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQ0F2THlCcGJuUmxiblJwYjI1aGJHeDVJSFZ6YVc1bklHTnNaV0Z5SUhOMFlYUmxJSEJ5YjJkeVlXMGdabTl5SUNKeVpYUjFjbTRnZEhKMVpTSUtJQ0FnSUM4dklDQWdJQ0JqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nWlcxd2RIa3VZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMHNDaUFnSUNBdkx5QWdJQ0FnYjI1RGIyMXdiR1YwYVc5dU9pQlBia052YlhCc1pYUmxRV04wYVc5dUxrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlltRnpaUzVoYkdkdkxuUnpPakkxTFRNeENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzVUhKdlozSmhiVG9nWlcxd2RIa3VZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMHNJQzh2SUdsdWRHVnVkR2x2Ym1Gc2JIa2dkWE5wYm1jZ1kyeGxZWElnYzNSaGRHVWdjSEp2WjNKaGJTQm1iM0lnSW5KbGRIVnliaUIwY25WbElnb2dJQ0FnTHk4Z0lDQWdJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJsYlhCMGVTNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd0tJQ0FnSUM4dklDQWdJQ0J2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMkpoYzJVdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHbDBlRzV6T3lCcEt5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCcGJtTnlaV0Z6WlVKMVpHZGxkRjkzYUdsc1pWOTBiM0JBTWdvS2FXNWpjbVZoYzJWQ2RXUm5aWFJmWVdaMFpYSmZkMmhwYkdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aVlYTmxMMkpoYzJVdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSFpoYkdsa1lYUmxSVzVqYjJScGJtYzZJQ2QxYm5OaFptVXRaR2x6WVdKc1pXUW5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUdJQ1lEQkF1QkFVTUJlQVFWSDN4MU1SaEFBQkdBRFd4aGMzUkJZMk52ZFc1MFNXUWlaekViUVFBck1Sa1VSREVZUklJRUJDZGpEV1VFMXB3N0dBVGZPbVorQkVFWTdMODJHZ0NPQkFBTEFHNENWZ0tFQURFWkZERVlGQkJFSTBNMkdnRkpGU1VTUkNsTVVFbTlTVThDU0VFQUVrc0J2a1NBQVFBaVN3TlVVQ3BNVUxBalE0QTRBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJDLzdXeGdRU3lOSUVDc2pVb3NrS0FyUU1MSUFRQkFBZ2dKZ1VJY0hKdmNHOXpaWElHYzNSaGRIVnpER052YlcxcGRIUmxaVjlwWkF4MmIzUmxYMjl3Wlc1ZmRITVBkbTkwYVc1blgyUjFjbUYwYVc5dU1SaEFBRElvTVFCbktTTm5Lb0FnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQm5LeU5uSndRalp6RWJRUUJITVJrVVJERVlSSUlJQkNSaFg1QUVHRUdnMGdTRzNUMWhCQzZCVlJRRTBIbzBuZ1JGek1XNUJKYWZXczhFbzZMVmVqWWFBSTRJQUFzQVBnQmVBRzRBZndDUEFLQUFzZ0F4R1JReEdCUVFSQ0pETmhvQlNSVWxFa1NBQVZaTVVFbTlTVThDU0VFQUdVc0J2a1FYRm9BQkFDTkxBMVJRZ0FRVkgzeDFURkN3SWtNalF2L29OaG9CRlNVU1JEWWFBaFVrRWtRMkdnTVZKQkpFZ0FZVkgzeDFBQUN3SWtNMkdnRkpGU1VTUklnQWFDaE1aeUpETmhvQlNSVWtFa1FYaUFCWEtVeG5Ja00yR2dGSkZTVVNSSWdBUnlwTVp5SkROaG9CU1JVa0VrUVhpQUEySzB4bklrTTJHZ0ZKRlNRU1JCZUlBQ1VuQkV4bklrTTJHZ0ZKRlNVU1JEWWFBa2tWSkJKRUY0Z0FDNEFCVms4Q1VFd1d2eUpETVFBaktHVkVFa0FBRElBSVJWSlNPa0ZWVkVpd0FJbXlRQ1N5RUNLeUFiTzBQYkV4QUlBRWh0MDlZYklhc2hvaXNobEpzaGdrc2hBaXNnR3pGaXBNVUxBalF6WWFBVWtWSlJKRU5ob0NTUldCT0JKRU1RQXlDUkpBQUF5QUNFVlNVanBCVlZSSXNBQXBTd0pRU3dHL0kwTTJHZ0VYSWtsTEFneEJBQnF4Z1FXeUdTaXlRaWl5UUNTeUVDS3lBYk5KSXdoRkFVTC8zeU5EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
