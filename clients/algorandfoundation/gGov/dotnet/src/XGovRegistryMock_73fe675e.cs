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

namespace Arc56.Generated.algorandfoundation.gGov.XGovRegistryMock_73fe675e
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWEdvdlJlZ2lzdHJ5TW9jayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJYR292Qm94VmFsdWUiOlt7Im5hbWUiOiJ2b3RpbmdBZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ0b2xlcmF0ZWRBYnNlbmNlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0Vm90ZVRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdWJzY3JpcHRpb25Sb3VuZCIsInR5cGUiOiJ1aW50NjQifV0sIkdldFhnb3ZCb3hSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiWEdvdkJveFZhbHVlIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0X3hnb3ZfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKChhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0KSxib29sKSIsInN0cnVjdCI6IkdldFhnb3ZCb3hSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZVByb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0WEdvdkJveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJYR292Qm94VmFsdWUiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVhc2VCdWRnZXQiLCJkZXNjIjoiVXRpbGl0eSB0byBpbmNyZWFzZSBvcGNvZGUgYnVkZ2V0IGJ5IHBlcmZvcm1pbmcgJGl0eG5zIG5vLW9wIGl0eG5zIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0eG5zIiwiZGVzYyI6Ik51bWJlciBvZiBuby1vcCBpdHhucyB0byBwZXJmb3JtIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTI0XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDgsNjk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMveGdvdi1yZWdpc3RyeS1tb2NrL3hHb3ZSZWdpc3RyeU1vY2suYWxnby50czo6WEdvdkJveFZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURZZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ1ltRnpaVFkwS0VNMFJVSlJkejA5S1NBaWVDSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZV05qYjNWdWRDMXBaQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJzWVhOMFFXTmpiM1Z1ZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dNQ0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pzWVhOMFFXTmpiM1Z1ZEVsa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhKbFoybHpkSEo1TFcxdlkyc3ZlRWR2ZGxKbFoybHpkSEo1VFc5amF5NWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nV0VkdmRsSmxaMmx6ZEhKNVRXOWpheUJsZUhSbGJtUnpJRUZqWTI5MWJuUkpaRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE13b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3lOell6TUdRMk5TQXdlR1EyT1dNellqRTRJREI0WkdZellUWTJOMlVnTUhnME1URTRaV05pWmlBdkx5QnRaWFJvYjJRZ0ltZGxkRjk0WjI5MlgySnZlQ2hoWkdSeVpYTnpLU2dvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNrc1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1OeVpXRjBaVkJ5YjNCdmMyRnNLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZEZoSGIzWkNiM2dvWVdSa2NtVnpjeXdvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYVc1amNtVmhjMlZDZFdSblpYUW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCblpYUllSMjkyUW05NElHTnlaV0YwWlZCeWIzQnZjMkZzSUhObGRGaEhiM1pDYjNnZ2FXNWpjbVZoYzJWQ2RXUm5aWFFLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRmhIYjNaU1pXZHBjM1J5ZVUxdlkyc2daWGgwWlc1a2N5QkJZMk52ZFc1MFNXUkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYSmxaMmx6ZEhKNUxXMXZZMnN2ZUVkdmRsSmxaMmx6ZEhKNVRXOWpheTVoYkdkdkxuUnpPanBZUjI5MlVtVm5hWE4wY25sTmIyTnJMbWRsZEZoSGIzWkNiM2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUllSMjkyUW05NE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjbVZuYVhOMGNua3RiVzlqYXk5NFIyOTJVbVZuYVhOMGNubE5iMk5yTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlN3Z2JtRnRaVG9nSjJkbGRGOTRaMjkyWDJKdmVDY2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIaG5iM1pDYjNnZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1dFZHZka0p2ZUZaaGJIVmxQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZ25JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0o0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYSmxaMmx6ZEhKNUxXMXZZMnN2ZUVkdmRsSmxaMmx6ZEhKNVRXOWpheTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJqYjI1emRDQjdJR1Y0YVhOMGN5QjlJRDBnWW05NENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGkxeVpXZHBjM1J5ZVMxdGIyTnJMM2hIYjNaU1pXZHBjM1J5ZVUxdlkyc3VZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ2RtRnNkV1U2SUZoSGIzWkNiM2hXWVd4MVpTQTlJR1Y0YVhOMGN5QS9JR0p2ZUM1MllXeDFaU0E2SUhSb2FYTXVaMlYwUlcxd2RIbFlSMjkyUW05NFZtRnNkV1VvS1FvZ0lDQWdZbm9nWjJWMFdFZHZka0p2ZUY5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvS1oyVjBXRWR2ZGtKdmVGOTBaWEp1WVhKNVgyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXlaV2RwYzNSeWVTMXRiMk5yTDNoSGIzWlNaV2RwYzNSeWVVMXZZMnN1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY21WMGRYSnVJRnQyWVd4MVpTd2daWGhwYzNSelhRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrYVdjZ013b2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhKbFoybHpkSEo1TFcxdlkyc3ZlRWR2ZGxKbFoybHpkSEo1VFc5amF5NWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVXNJRzVoYldVNklDZG5aWFJmZUdkdmRsOWliM2duSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJZUjI5MlFtOTRYM1JsY201aGNubGZabUZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJMWEpsWjJsemRISjVMVzF2WTJzdmVFZHZkbEpsWjJsemRISjVUVzlqYXk1aGJHZHZMblJ6T2pNMUxUUXdDaUFnSUNBdkx5QnlaWFIxY200Z2V3b2dJQ0FnTHk4Z0lDQjJiM1JwYm1kQlpHUnlaWE56T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIUnZiR1Z5WVhSbFpFRmljMlZ1WTJWek9pQXdMQW9nSUNBZ0x5OGdJQ0JzWVhOMFZtOTBaVlJwYldWemRHRnRjRG9nTUN3S0lDQWdJQzh2SUNBZ2MzVmljMk55YVhCMGFXOXVVbTkxYm1RNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCd2RYTm9ZbmwwWlhNZ1ltRnpaVE15S0VGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVNrS0lDQWdJR0lnWjJWMFdFZHZka0p2ZUY5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pvNldFZHZkbEpsWjJsemRISjVUVzlqYXk1amNtVmhkR1ZRY205d2IzTmhiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVkJ5YjNCdmMyRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk5EZ3ROVFVLSUNBZ0lDOHZJR052Ym5OMElHTnlaV0YwWldRZ1BTQnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lHRndjSEp2ZG1Gc1VISnZaM0poYlRvZ2NISnZjRzl6WVd4RGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBzSUM4dklHbHVkR1Z1ZEdsdmJtRnNiSGtnZFhOcGJtY2dZMnhsWVhJZ2MzUmhkR1VnY0hKdlozSmhiU0JtYjNJZ0luSmxkSFZ5YmlCMGNuVmxJZ29nSUNBZ0x5OGdJQ0FnSUdOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0T2lCd2NtOXdiM05oYkVOdmJuUnlZV04wTG1Oc1pXRnlVM1JoZEdWUWNtOW5jbUZ0TEFvZ0lDQWdMeThnSUNBZ0lHZHNiMkpoYkU1MWJVSjVkR1Z6T2lBeUxBb2dJQ0FnTHk4Z0lDQWdJR2RzYjJKaGJFNTFiVlZwYm5RNklEUXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHZHNiMkpoYkU1MWJWVnBiblE2SURRc0NpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCSGJHOWlZV3hPZFcxVmFXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkaTF5WldkcGMzUnllUzF0YjJOckwzaEhiM1pTWldkcGMzUnllVTF2WTJzdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1oyeHZZbUZzVG5WdFFubDBaWE02SURJc0NpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCSGJHOWlZV3hPZFcxQ2VYUmxVMnhwWTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MkxYSmxaMmx6ZEhKNUxXMXZZMnN2ZUVkdmRsSmxaMmx6ZEhKNVRXOWpheTVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJqYjI1emRDQndjbTl3YjNOaGJFTnZiblJ5WVdOMElEMGdZMjl0Y0dsc1pTaFlSMjkyVUhKdmNHOXpZV3hOYjJOcktRb2dJQ0FnWW5sMFpXTmZNQ0F2THlCaVlYTmxOalFvUXpSRlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9RM2xCUlVGUlFVbEpRMWxHUTBoQ2VXSXpRblpqTWxaNVFtNU9NRmxZVWpGamQzaHFZakl4ZEdGWVVqQmFWMVptWVZkUlRXUnRPVEJhVmpsMlkwZFdkVmd6VW5wRU0xcDJaRWRzZFZveE9XdGtXRXBvWkVkc2RtSnFSVmxSUVVGNVMwUkZRVnA1YTJwYWVYRkJTVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRmFlWE5xV25salJVa3lZM2hITUVWQlVucEZXa1pGVVhoSFJWTkRRMEZSYTFsV0sxRkNRbWhDYjA1SlJXaDBNRGxaVVZGMVoxWlZWVUpPUWpaT1NqUkZVbU42Um5WUlUxZHVNWEpRUWt0UGFURlliekpIWjBOUFEwRkJURUZFTkVGWVowSjFRVWc0UVdwM1EyZEJURWxCVFZKclZVMVNaMVZGUlZGcFVYcFpZVUZWYTFaS1VrcEZaMEZHVjFSR1FrcDJWV3hRUVd0b1FrRkNiRXhCWWpWRlJuaGhRVUZSUVdwVGQwNVZWVWxCUlVaU09UaGtWWGhSYzBOS1JFa3dUQzgyUkZsaFFWSlZiRVZyVVRKSFowbFdTa0pLUlU1b2IwUkdVMUZUVWtsQlIwWlNPVGhrVVVGQmMwTktSRTVvYjBKVFVsVnNSV3RUU1VGSFoyOVVSMk5wVVhwWllVRlZhMVpLUWtwRlJqUm5RVlo1YkUxYWVVcEVUbWh2UWxOU1ZXeEZhMU5KUVVWamNWUkhZMmxSZWxsaFFWVnJWa3BDU2tWR05HZEJUbWwwVFZwNVNrUk9hRzlDVTFKVmEwVnJVVmhwUVVGc1NuZFNUVnA1U2tST2FHOUNVMUpWYkVWclVUSkhaMHBLUmxOUlUxSkNaVWxCUVhWQlFWWmFVRUZzUWsxR2NqaHBVWHBGUVVsNWFHeFNRa3BCUVVGNVFVTkZWbE5WYW5CQ1ZsWlNTWE5CUTBvcENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXlaV2RwYzNSeWVTMXRiMk5yTDNoSGIzWlNaV2RwYzNSeWVVMXZZMnN1WVd4bmJ5NTBjem8wT0MwMU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnWTNKbFlYUmxaQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRPaUJ3Y205d2IzTmhiRU52Ym5SeVlXTjBMbUZ3Y0hKdmRtRnNVSEp2WjNKaGJTd2dMeThnYVc1MFpXNTBhVzl1WVd4c2VTQjFjMmx1WnlCamJHVmhjaUJ6ZEdGMFpTQndjbTluY21GdElHWnZjaUFpY21WMGRYSnVJSFJ5ZFdVaUNpQWdJQ0F2THlBZ0lDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJSEJ5YjNCdmMyRnNRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMHNDaUFnSUNBdkx5QWdJQ0FnWjJ4dlltRnNUblZ0UW5sMFpYTTZJRElzQ2lBZ0lDQXZMeUFnSUNBZ1oyeHZZbUZzVG5WdFZXbHVkRG9nTkN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUdsdWRHTmZNaUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhKbFoybHpkSEo1TFcxdlkyc3ZlRWR2ZGxKbFoybHpkSEo1VFc5amF5NWhiR2R2TG5Sek9qUTRMVFUxQ2lBZ0lDQXZMeUJqYjI1emRDQmpjbVZoZEdWa0lEMGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYQndiR2xqWVhScGIyNURZV3hzS0hzS0lDQWdJQzh2SUNBZ0lDQmhjSEJ5YjNaaGJGQnliMmR5WVcwNklIQnliM0J2YzJGc1EyOXVkSEpoWTNRdVlYQndjbTkyWVd4UWNtOW5jbUZ0TENBdkx5QnBiblJsYm5ScGIyNWhiR3g1SUhWemFXNW5JR05zWldGeUlITjBZWFJsSUhCeWIyZHlZVzBnWm05eUlDSnlaWFIxY200Z2RISjFaU0lLSUNBZ0lDOHZJQ0FnSUNCamJHVmhjbE4wWVhSbFVISnZaM0poYlRvZ2NISnZjRzl6WVd4RGIyNTBjbUZqZEM1amJHVmhjbE4wWVhSbFVISnZaM0poYlN3S0lDQWdJQzh2SUNBZ0lDQm5iRzlpWVd4T2RXMUNlWFJsY3pvZ01pd0tJQ0FnSUM4dklDQWdJQ0JuYkc5aVlXeE9kVzFWYVc1ME9pQTBMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRpMXlaV2RwYzNSeWVTMXRiMk5yTDNoSGIzWlNaV2RwYzNSeWVVMXZZMnN1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnY0hKdmNHOXpZV3d1WTJGc2JDNXpaWFJRY205d2IzTmxjaWg3SUdGd2NFbGtMQ0JoY21kek9pQmJWSGh1TG5ObGJtUmxjbDBnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZzJaR1F6WkRZeElDOHZJRzFsZEdodlpDQWljMlYwVUhKdmNHOXpaWElvWVdSa2NtVnpjeWwyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6SWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1ZRY205d2IzTmhiQ2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyTFhKbFoybHpkSEo1TFcxdlkyc3ZlRWR2ZGxKbFoybHpkSEo1VFc5amF5NWhiR2R2TG5Sek9qcFlSMjkyVW1WbmFYTjBjbmxOYjJOckxuTmxkRmhIYjNaQ2IzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSWVIyOTJRbTk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNtVm5hWE4wY25rdGJXOWpheTk0UjI5MlVtVm5hWE4wY25sTmIyTnJMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFJZUjI5MlFtOTRLSFp2ZEdWeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZEN3Z2RtRnNkV1U2SUZoSGIzWkNiM2hXWVd4MVpTazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTFOaUF2THlBMU5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNZdGNtVm5hWE4wY25rdGJXOWpheTk0UjI5MlVtVm5hWE4wY25sTmIyTnJMbUZzWjI4dWRITTZPbGhIYjNaQ2IzaFdZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlltRnpaUzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJsYm5OMWNtVW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpMQ0JsY25KVmJtRjFkR2h2Y21sNlpXUXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5MWRHbHNjeTVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJwWmlBb0lXTnZibVFwSUhzS0lDQWdJR0p1ZWlCelpYUllSMjkyUW05NFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlltRnpaUzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJsYm5OMWNtVW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpMQ0JsY25KVmJtRjFkR2h2Y21sNlpXUXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBCVlZSSUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZkWFJwYkhNdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2JHOW5LR052WkdVcENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwzVjBhV3h6TG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUdWeWNpZ3BDaUFnSUNCbGNuSUtDbk5sZEZoSGIzWkNiM2hmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIaG5iM1pDYjNnZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1dFZHZka0p2ZUZaaGJIVmxQaWg3SUd0bGVWQnlaV1pwZURvZ0ozZ25JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0o0SWdvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWXRjbVZuYVhOMGNua3RiVzlqYXk5NFIyOTJVbVZuYVhOMGNubE5iMk5yTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUhSb2FYTXVlR2R2ZGtKdmVDaDJiM1JsY2tGa1pISmxjM01wTG5aaGJIVmxJRDBnWTJ4dmJtVW9kbUZzZFdVcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1l0Y21WbmFYTjBjbmt0Ylc5amF5OTRSMjkyVW1WbmFYTjBjbmxOYjJOckxtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUllSMjkyUW05NEtIWnZkR1Z5UVdSa2NtVnpjem9nUVdOamIzVnVkQ3dnZG1Gc2RXVTZJRmhIYjNaQ2IzaFdZV3gxWlNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlZWE5sTDJKaGMyVXVZV3huYnk1MGN6bzZRbUZ6WlVOdmJuUnlZV04wTG1sdVkzSmxZWE5sUW5Wa1oyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1amNtVmhjMlZDZFdSblpYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlpWVhObExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpoYzJVdlltRnpaUzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnYVhSNGJuTTdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtbHVZM0psWVhObFFuVmtaMlYwWDNkb2FXeGxYM1J2Y0VBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZbUZ6WlM1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z2FYUjRibk03SUdrckt5a2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ2FXNWpjbVZoYzJWQ2RXUm5aWFJmWVdaMFpYSmZkMmhwYkdWQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKaGMyVXZZbUZ6WlM1aGJHZHZMblJ6T2pJMUxUTXhDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lHRndjSEp2ZG1Gc1VISnZaM0poYlRvZ1pXMXdkSGt1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBzSUM4dklHbHVkR1Z1ZEdsdmJtRnNiSGtnZFhOcGJtY2dZMnhsWVhJZ2MzUmhkR1VnY0hKdlozSmhiU0JtYjNJZ0luSmxkSFZ5YmlCMGNuVmxJZ29nSUNBZ0x5OGdJQ0FnSUdOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0T2lCbGJYQjBlUzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU3dLSUNBZ0lDOHZJQ0FnSUNCdmJrTnZiWEJzWlhScGIyNDZJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVSR1ZzWlhSbFFYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySmhjMlV2WW1GelpTNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1UkdWc1pYUmxRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQndkWE5vYVc1MElEVWdMeThnTlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwySmhjMlV1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnWTI5dWMzUWdaVzF3ZEhrZ1BTQmpiMjF3YVd4bEtFVnRjSFI1UTI5dWRISmhZM1FwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJR0poYzJVMk5DaERORVZDVVhjOVBTa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeGxZWEpUZEdGMFpWQnliMmR5WVcxUVlXZGxjd29nSUNBZ1lubDBaV05mTUNBdkx5QmlZWE5sTmpRb1F6UkZRbEYzUFQwcENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWlZWE5sTG1Gc1oyOHVkSE02TWpVdE16QUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1Gd2NHeHBZMkYwYVc5dVEyRnNiQ2g3Q2lBZ0lDQXZMeUFnSUNBZ1lYQndjbTkyWVd4UWNtOW5jbUZ0T2lCbGJYQjBlUzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU3dnTHk4Z2FXNTBaVzUwYVc5dVlXeHNlU0IxYzJsdVp5QmpiR1ZoY2lCemRHRjBaU0J3Y205bmNtRnRJR1p2Y2lBaWNtVjBkWEp1SUhSeWRXVWlDaUFnSUNBdkx5QWdJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUdWdGNIUjVMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0FnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNUVaV3hsZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpWVhObEwySmhjMlV1WVd4bmJ5NTBjem95TlMwek1Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQnliM1poYkZCeWIyZHlZVzA2SUdWdGNIUjVMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQ0F2THlCcGJuUmxiblJwYjI1aGJHeDVJSFZ6YVc1bklHTnNaV0Z5SUhOMFlYUmxJSEJ5YjJkeVlXMGdabTl5SUNKeVpYUjFjbTRnZEhKMVpTSUtJQ0FnSUM4dklDQWdJQ0JqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nWlcxd2RIa3VZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMHNDaUFnSUNBdkx5QWdJQ0FnYjI1RGIyMXdiR1YwYVc5dU9pQlBia052YlhCc1pYUmxRV04wYVc5dUxrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlpWVhObExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQnBkSGh1Y3pzZ2FTc3JLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2FXNWpjbVZoYzJWQ2RXUm5aWFJmZDJocGJHVmZkRzl3UURJS0NtbHVZM0psWVhObFFuVmtaMlYwWDJGbWRHVnlYM2RvYVd4bFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlpWVhObExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUIyWVd4cFpHRjBaVVZ1WTI5a2FXNW5PaUFuZFc1ellXWmxMV1JwYzJGaWJHVmtKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUdJQ1lEQkF1QkFVTUJlQVFWSDN4MU1SaEFBQkdBRFd4aGMzUkJZMk52ZFc1MFNXUWlaekViUVFBck1Sa1VSREVZUklJRUJDZGpEV1VFMXB3N0dBVGZPbVorQkVFWTdMODJHZ0NPQkFBTEFHNENWZ0tFQURFWkZERVlGQkJFSTBNMkdnRkpGU1VTUkNsTVVFbTlTVThDU0VFQUVrc0J2a1NBQVFBaVN3TlVVQ3BNVUxBalE0QTRBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJDLzdXeGdRU3lOSUVDc2pVb3NrS0FyUU1MSUFRQkFBZ2dKZ1VJY0hKdmNHOXpaWElHYzNSaGRIVnpER052YlcxcGRIUmxaVjlwWkF4MmIzUmxYMjl3Wlc1ZmRITVBkbTkwYVc1blgyUjFjbUYwYVc5dU1SaEFBRElvTVFCbktTTm5Lb0FnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQm5LeU5uSndRalp6RWJRUUJITVJrVVJERVlSSUlJQkNSaFg1QUVHRUdnMGdTRzNUMWhCQzZCVlJRRTBIbzBuZ1JGek1XNUJKYWZXczhFbzZMVmVqWWFBSTRJQUFzQVBnQmVBRzRBZndDUEFLQUFzZ0F4R1JReEdCUVFSQ0pETmhvQlNSVWxFa1NBQVZaTVVFbTlTVThDU0VFQUdVc0J2a1FYRm9BQkFDTkxBMVJRZ0FRVkgzeDFURkN3SWtNalF2L29OaG9CRlNVU1JEWWFBaFVrRWtRMkdnTVZKQkpFZ0FZVkgzeDFBQUN3SWtNMkdnRkpGU1VTUklnQWFDaE1aeUpETmhvQlNSVWtFa1FYaUFCWEtVeG5Ja00yR2dGSkZTVVNSSWdBUnlwTVp5SkROaG9CU1JVa0VrUVhpQUEySzB4bklrTTJHZ0ZKRlNRU1JCZUlBQ1VuQkV4bklrTTJHZ0ZKRlNVU1JEWWFBa2tWSkJKRUY0Z0FDNEFCVms4Q1VFd1d2eUpETVFBaktHVkVFa0FBRElBSVJWSlNPa0ZWVkVpd0FJbXlRQ1N5RUNLeUFiTzBQYkV4QUlBRWh0MDlZYklhc2hvaXNobEpzaGdrc2hBaXNnR3pGaXBNVUxBalF6WWFBVWtWSlJKRU5ob0NTUldCT0JKRU1RQXlDUkpBQUF5QUNFVlNVanBCVlZSSXNBQXBTd0pRU3dHL0kwTTJHZ0VYSWtsTEFneEJBQnF4Z1FXeUdTaXlRaWl5UUNTeUVDS3lBYk5KSXdoRkFVTC8zeU5EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
