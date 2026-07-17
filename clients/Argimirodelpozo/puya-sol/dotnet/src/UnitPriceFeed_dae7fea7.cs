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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.UnitPriceFeed_dae7fea7
{


    //
    // @title UnitPriceFeed contract
    // @author Aave Labs
    // @notice Price feed that returns the unit price (1), with decimals precision.
    // @dev This price feed can be set for reserves that use the base currency as collateral.
    //
    public class UnitPriceFeedProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public UnitPriceFeedProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetRoundDataReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 RoundId { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Answer { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 StartedAt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 UpdatedAt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 AnsweredInRound { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoundId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRoundId.From(RoundId);
                    ret.AddRange(vRoundId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAnswer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAnswer.From(Answer);
                    ret.AddRange(vAnswer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vStartedAt.From(StartedAt);
                    ret.AddRange(vStartedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vUpdatedAt.From(UpdatedAt);
                    ret.AddRange(vUpdatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAnsweredInRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAnsweredInRound.From(AnsweredInRound);
                    ret.AddRange(vAnsweredInRound.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetRoundDataReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetRoundDataReturn();
                    uint count = 0;
                    var vRoundId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRoundId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.RoundId = vRoundId;
                    var vAnswer = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAnswer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Answer = vAnswer;
                    var vStartedAt = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vStartedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.StartedAt = vStartedAt;
                    var vUpdatedAt = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vUpdatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.UpdatedAt = vUpdatedAt;
                    var vAnsweredInRound = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAnsweredInRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AnsweredInRound = vAnsweredInRound;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetRoundDataReturn);
                }
                public bool Equals(GetRoundDataReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetRoundDataReturn left, GetRoundDataReturn right)
                {
                    return EqualityComparer<GetRoundDataReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetRoundDataReturn left, GetRoundDataReturn right)
                {
                    return !(left == right);
                }

            }

            public class LatestRoundDataReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 RoundId { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Answer { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 StartedAt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 UpdatedAt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 AnsweredInRound { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoundId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRoundId.From(RoundId);
                    ret.AddRange(vRoundId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAnswer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAnswer.From(Answer);
                    ret.AddRange(vAnswer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vStartedAt.From(StartedAt);
                    ret.AddRange(vStartedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vUpdatedAt.From(UpdatedAt);
                    ret.AddRange(vUpdatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAnsweredInRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vAnsweredInRound.From(AnsweredInRound);
                    ret.AddRange(vAnsweredInRound.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LatestRoundDataReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LatestRoundDataReturn();
                    uint count = 0;
                    var vRoundId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRoundId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.RoundId = vRoundId;
                    var vAnswer = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAnswer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Answer = vAnswer;
                    var vStartedAt = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vStartedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.StartedAt = vStartedAt;
                    var vUpdatedAt = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vUpdatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.UpdatedAt = vUpdatedAt;
                    var vAnsweredInRound = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vAnsweredInRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AnsweredInRound = vAnsweredInRound;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LatestRoundDataReturn);
                }
                public bool Equals(LatestRoundDataReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LatestRoundDataReturn left, LatestRoundDataReturn right)
                {
                    return EqualityComparer<LatestRoundDataReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(LatestRoundDataReturn left, LatestRoundDataReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///@inheritdoc AggregatorV3Interface
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Version(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 131, 141, 230 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Version_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 131, 141, 230 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc AggregatorV3Interface
        ///</summary>
        /// <param name="__arc4__roundId"> </param>
        public async Task<Structs.GetRoundDataReturn> GetRoundData(System.Numerics.BigInteger __arc4__roundId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 141, 161, 171 };
            var __arc4__roundIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4__roundIdAbi.From(__arc4__roundId);

            var result = await base.SimApp(new List<object> { abiHandle, __arc4__roundIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetRoundDataReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRoundData_Transactions(System.Numerics.BigInteger __arc4__roundId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 141, 161, 171 };
            var __arc4__roundIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4__roundIdAbi.From(__arc4__roundId);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4__roundIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc AggregatorV3Interface
        ///</summary>
        public async Task<Structs.LatestRoundDataReturn> LatestRoundData(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 177, 133, 17 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LatestRoundDataReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> LatestRoundData_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 177, 133, 17 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc AggregatorV3Interface
        ///</summary>
        public async Task<ulong> Decimals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 119, 158, 231 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Decimals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 119, 158, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Description(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 173, 102, 83 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Description_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 173, 102, 83 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVW5pdFByaWNlRmVlZCIsImRlc2MiOiJAdGl0bGUgVW5pdFByaWNlRmVlZCBjb250cmFjdFxuIEBhdXRob3IgQWF2ZSBMYWJzXG4gQG5vdGljZSBQcmljZSBmZWVkIHRoYXQgcmV0dXJucyB0aGUgdW5pdCBwcmljZSAoMSksIHdpdGggZGVjaW1hbHMgcHJlY2lzaW9uLlxuIEBkZXYgVGhpcyBwcmljZSBmZWVkIGNhbiBiZSBzZXQgZm9yIHJlc2VydmVzIHRoYXQgdXNlIHRoZSBiYXNlIGN1cnJlbmN5IGFzIGNvbGxhdGVyYWwuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7ImdldFJvdW5kRGF0YVJldHVybiI6W3sibmFtZSI6InJvdW5kSWQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFuc3dlciIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoic3RhcnRlZEF0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ1cGRhdGVkQXQiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImFuc3dlcmVkSW5Sb3VuZCIsInR5cGUiOiJ1aW50NTEyIn1dLCJsYXRlc3RSb3VuZERhdGFSZXR1cm4iOlt7Im5hbWUiOiJyb3VuZElkIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJhbnN3ZXIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6InN0YXJ0ZWRBdCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoidXBkYXRlZEF0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJhbnN3ZXJlZEluUm91bmQiLCJ0eXBlIjoidWludDUxMiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6IkBpbmhlcml0ZG9jIEFnZ3JlZ2F0b3JWM0ludGVyZmFjZSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJvdW5kRGF0YSIsImRlc2MiOiJAaW5oZXJpdGRvYyBBZ2dyZWdhdG9yVjNJbnRlcmZhY2UiLCJhcmdzIjpbeyJ0eXBlIjoidWludDgwIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X19yb3VuZElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiZ2V0Um91bmREYXRhUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsYXRlc3RSb3VuZERhdGEiLCJkZXNjIjoiQGluaGVyaXRkb2MgQWdncmVnYXRvclYzSW50ZXJmYWNlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoibGF0ZXN0Um91bmREYXRhUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWNpbWFscyIsImRlc2MiOiJAaW5oZXJpdGRvYyBBZ2dyZWdhdG9yVjNJbnRlcmZhY2UiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlc2NyaXB0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY0N10sImVycm9yTWVzc2FnZSI6IlNhZmVDYXN0T3ZlcmZsb3dlZFVpbnRUb0ludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIERFQ0lNQUxTIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MSw0NjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBVTklUUyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBkZXNjcmlwdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50ODAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzMsMzA4LDM0MSw0MzMsNTYwXSwiZXJyb3JNZXNzYWdlIjoibm90IHBheWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjMsMzc2LDQ4Nyw1MDAsNTExLDUyMiw1MzNdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxVnVhWFJRY21salpVWmxaV1F1YzI5c0xsVnVhWFJRY21salpVWmxaV1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTmpRS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnZ0lsVk9TVlJUSWlBd2VERTFNV1kzWXpjMUlDSmtaWE5qY21sd2RHbHZiaUlnSWtSRlEwbE5RVXhUSWlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQTVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCd2RYTm9hVzUwSURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhOMGIzSmxJRFVLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1Bb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURjS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5WeWVTQTJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmtaWE5qY21sd2RHbHZiaUlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pFUlVOSlRVRk1VeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlWVTVKVkZNaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERUtJQ0FnSUdKMWNua2dPUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR0VLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR2wwYjJJS0lDQWdJR0oxY25rZ09Rb0tiV0ZwYmw5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUdScFp5QTRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaVBnb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOTNhR2xzWlVBMkNpQWdJQ0JrYVdjZ09Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JrYVdjZ053b2dJQ0FnWkdsbklERXdDaUFnSUNCaUtnb2dJQ0FnWW5WeWVTQTRDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1JwWnlBNENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01nb2dJQ0FnWWk4S0lDQWdJR0oxY25rZ09Rb2dJQ0FnWkdsbklEa0tJQ0FnSUdSMWNBb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBTWdvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBMk9nb2dJQ0FnWkdsbklEY0tJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVTmhjM1F1ZEc5SmJuUXlOVFlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbFZPU1ZSVElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrUkZRMGxOUVV4VElnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmtaWE5qY21sd2RHbHZiaUlLSUNBZ0lHUnBaeUExQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGxNemd6T0dSbE5pQXdlRGxsT0dSaE1XRmlJREI0Wm1aaU1UZzFNVEVnTUhoaU9EYzNPV1ZsTnlBd2VEQTJZV1EyTmpVeklDOHZJRzFsZEdodlpDQWlkbVZ5YzJsdmJpZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlaMlYwVW05MWJtUkVZWFJoS0hWcGJuUTRNQ2tvZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXNkV2x1ZERVeE1peDFhVzUwTlRFeUtTSXNJRzFsZEdodlpDQWliR0YwWlhOMFVtOTFibVJFWVhSaEtDa29kV2x1ZERVeE1peDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5S1NJc0lHMWxkR2h2WkNBaVpHVmphVzFoYkhNb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHVnpZM0pwY0hScGIyNG9LWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRtVnljMmx2Ymw5eWIzVjBaVUF4TUNCdFlXbHVYMmRsZEZKdmRXNWtSR0YwWVY5eWIzVjBaVUF4TVNCdFlXbHVYMnhoZEdWemRGSnZkVzVrUkdGMFlWOXliM1YwWlVBeE1pQnRZV2x1WDJSbFkybHRZV3h6WDNKdmRYUmxRREV6SUcxaGFXNWZaR1Z6WTNKcGNIUnBiMjVmY205MWRHVkFNVFFLSUNBZ0lHVnljZ29LYldGcGJsOWtaWE5qY21sd2RHbHZibDl5YjNWMFpVQXhORG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpFNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmtaWE5qY21sd2RHbHZiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2daR1Z6WTNKcGNIUnBiMjRnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREl3T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREl4Q2dwdFlXbHVYMlJsWTJsdFlXeHpYM0p2ZFhSbFFERXpPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TmpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrUkZRMGxOUVV4VElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCRVJVTkpUVUZNVXlCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qVTFDaUFnSUNBbUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNalU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNallLQ20xaGFXNWZiR0YwWlhOMFVtOTFibVJFWVhSaFgzSnZkWFJsUURFeU9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpNQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWxWT1NWUlRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QlZUa2xVVXlCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdScFp5QTBDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdaR2xuSURNS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TURvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TVFvS2JXRnBibDluWlhSU2IzVnVaRVJoZEdGZmNtOTFkR1ZBTVRFNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01USUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBPREFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTXpVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTXpZNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpZFhKNUlETUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdKMWNua2dNZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1luVnllU0EyQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR0krUFFvZ0lDQWdZbm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNNENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVlU1SlZGTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dWVTVKVkZNZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ013b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEUUtJQ0FnSUdKMWNua2dOQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNNE9nb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QXlDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JRElLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNMU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURNMkNncHRZV2x1WDNabGNuTnBiMjVmY205MWRHVkFNVEE2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURReUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURReU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VmJtbDBVSEpwWTJWR1pXVmtMbk52YkM1VFlXWmxRMkZ6ZEM1MGIwbHVkREkxTmloMllXeDFaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BUWVdabFEyRnpkQzUwYjBsdWRESTFOam9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpUGdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTmhabVZEWVhOMFQzWmxjbVpzYjNkbFpGVnBiblJVYjBsdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVZ1YVhSUWNtbGpaVVpsWldRdWMyOXNMbFZ1YVhSUWNtbGpaVVpsWldRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFGQUpnWUFCVlZPU1ZSVEJCVWZmSFVMWkdWelkzSnBjSFJwYjI0SVJFVkRTVTFCVEZNSy8vLy8vLy8vLy8vLy95SkhDU2lCZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBR1UyR2dCSkZZRUlDVnRKUlFJMkdnRkZCaXNvWnljRUltY3BLR2VBQVFGRkNZQUJDa1VMRmtVSlN3Z29wVUVBSTBzSWdBRUJyQ2lwUVFBSFN3ZExDcU5GQ0VzSWdBRUNva1VKU3dsSm8wVUtRdi9XU3dlSUFaa3BUR2NuQkVzQlp5dExCV2NqUXpFWkZFUXhHRVNDQlFUamc0M21CSjZOb2FzRS83R0ZFUVM0ZDU3bkJBYXRabE0yR2dDT0JRRWdBSllBUlFBa0FBRUFNUlpCQUJveEZpTUpPQWdVUkNJclpVUkpGUlpYQmdKTVVDcE1VTEFqUXlKQy8rZ3hGa0VBR0RFV0l3azRDQlJFSWljRVpVU0Ivd0VhRmlwTVVMQWpReUpDLytveEZrRUFTREVXSXdrNENCUkVNZ2NXSndXc0lpbGxSRElIRmpJSEZrc0RGU1FPUkNTdlR3UkxBYXRMQkJVa0RrUlBCRXNDcTBzQlRGQlBCRXNEcTFCUEEwOERxMUJNVUNwTVVMQWpReUpDLzdvMkdnRkpSUXdWZ1FvU1JERVdRUUIyTVJZakNUZ0lGRVFvUlFRb1JRY29SUU1vUlFJb1JRWXlCeFluQmF4TEM2ZEJBQlFpS1dWTVJRaEVTd3BKUlFkSlJRTkpSUVJGQkVzRFNSVWtEa1FrcjB4TEFhdExDRWtWSkE1RVN3S3JVRXNFU1JVa0RrUkxBcXRRU3dOSkZTUU9SRXNDcTFCTEIwa1ZKQTVFVHdLclVDcE1VTEFqUXlKQy80d3hGa0VBTVRFV0l3azRDQlJFZ0NRVkgzeDFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFHd0kwTWlRdi9SaWdFQmkvK0FJSC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vL3BSUkVpLytKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
