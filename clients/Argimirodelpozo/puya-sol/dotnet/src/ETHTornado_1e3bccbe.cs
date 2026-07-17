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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.ETHTornado_1e3bccbe
{


    public class ETHTornadoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ETHTornadoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class DepositEvent
            {
                public static readonly byte[] Selector = new byte[4] { 90, 109, 158, 155 };
                public const string Signature = "Deposit(uint8[32],uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Commitment { get; set; }
                public ulong LeafIndex { get; set; }
                public ulong Timestamp { get; set; }

                public static DepositEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DepositEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCommitment.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitment = vCommitment.ToValue();
                    if (valueCommitment is byte[] vCommitmentValue) { ret.Commitment = vCommitmentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLeafIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLeafIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLeafIndex = vLeafIndex.ToValue();
                    if (valueLeafIndex is ulong vLeafIndexValue) { ret.LeafIndex = vLeafIndexValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class WithdrawalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 97, 32, 239, 30 };
                public const string Signature = "Withdrawal(uint8[32],uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] To { get; set; }
                public byte[] NullifierHash { get; set; }
                public byte[] Relayer { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Fee { get; set; }

                public static WithdrawalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new WithdrawalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is byte[] vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNullifierHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNullifierHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNullifierHash = vNullifierHash.ToValue();
                    if (valueNullifierHash is byte[] vNullifierHashValue) { ret.NullifierHash = vNullifierHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRelayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vRelayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRelayer = vRelayer.ToValue();
                    if (valueRelayer is byte[] vRelayerValue) { ret.Relayer = vRelayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFee = vFee.ToValue();
                    if (valueFee is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vFeeValue) { ret.Fee = vFeeValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_verifier"> </param>
        /// <param name="_hasher"> </param>
        /// <param name="_denomination"> </param>
        /// <param name="_merkleTreeHeight"> </param>
        public async Task PostInit(Algorand.Address _verifier, Algorand.Address _hasher, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _denomination, ulong _merkleTreeHeight, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 238, 200, 241 };
            var _verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _verifierAbi.From(_verifier);
            var _hasherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _hasherAbi.From(_hasher);
            var _merkleTreeHeightAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _merkleTreeHeightAbi.From(_merkleTreeHeight);

            var result = await base.CallApp(new List<object> { abiHandle, _verifierAbi, _hasherAbi, _denomination, _merkleTreeHeightAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Algorand.Address _verifier, Algorand.Address _hasher, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _denomination, ulong _merkleTreeHeight, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 238, 200, 241 };
            var _verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _verifierAbi.From(_verifier);
            var _hasherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _hasherAbi.From(_hasher);
            var _merkleTreeHeightAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); _merkleTreeHeightAbi.From(_merkleTreeHeight);

            return await base.MakeTransactionList(new List<object> { abiHandle, _verifierAbi, _hasherAbi, _denomination, _merkleTreeHeightAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Verifier(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 177, 125, 22 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Verifier_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 177, 125, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Denomination(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 220, 140, 15 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Denomination_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 220, 140, 15 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key0"> </param>
        public async Task<bool> NullifierHashes(byte[] key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 226, 116, 197 };
            var key0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); key0Abi.From(key0);

            var result = await base.SimApp(new List<object> { abiHandle, key0Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NullifierHashes_Transactions(byte[] key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 226, 116, 197 };
            var key0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); key0Abi.From(key0);

            return await base.MakeTransactionList(new List<object> { abiHandle, key0Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key0"> </param>
        public async Task<bool> Commitments(byte[] key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 148, 213, 116 };
            var key0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); key0Abi.From(key0);

            var result = await base.SimApp(new List<object> { abiHandle, key0Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Commitments_Transactions(byte[] key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 148, 213, 116 };
            var key0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); key0Abi.From(key0);

            return await base.MakeTransactionList(new List<object> { abiHandle, key0Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> FieldSize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 95, 37, 50 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> FieldSize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 95, 37, 50 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ZeroValue(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 102, 71, 85 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ZeroValue_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 102, 71, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Hasher(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 59, 207, 179 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Hasher_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 59, 207, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Levels(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 170, 189, 112 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Levels_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 170, 189, 112 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key0"> </param>
        public async Task<byte[]> FilledSubtrees(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 221, 185, 244 };

            var result = await base.SimApp(new List<object> { abiHandle, key0 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> FilledSubtrees_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 221, 185, 244 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key0 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key0"> </param>
        public async Task<byte[]> Roots(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 223, 45, 121 };

            var result = await base.SimApp(new List<object> { abiHandle, key0 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Roots_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 key0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 223, 45, 121 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key0 }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> RootHistorySize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 51, 197, 173 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RootHistorySize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 51, 197, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> CurrentRootIndex(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 132, 7, 9 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CurrentRootIndex_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 132, 7, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> NextIndex(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 246, 182, 70 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NextIndex_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 246, 182, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev Deposit funds into the contract. The caller must send (for ETH) or approve (for ERC20) value equal to or `denomination` of this instance.
        ///@param _commitment the note commitment, which is PedersenHash(nullifier + secret)
        ///</summary>
        /// <param name="_commitment"> </param>
        public async Task Deposit(byte[] _commitment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 209, 40, 114 };
            var _commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _commitmentAbi.From(_commitment);

            var result = await base.CallApp(new List<object> { abiHandle, _commitmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deposit_Transactions(byte[] _commitment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 209, 40, 114 };
            var _commitmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _commitmentAbi.From(_commitment);

            return await base.MakeTransactionList(new List<object> { abiHandle, _commitmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev Withdraw a deposit from the contract. `proof` is a zkSNARK proof data, and input is an array of circuit public inputs
        ///`input` array consists of:
        ///- merkle root of all deposits in the contract
        ///- hash of unique deposit nullifier to prevent double spends
        ///- the recipient of funds
        ///- optional fee that goes to the transaction sender (usually a relay)
        ///</summary>
        /// <param name="_proof"> </param>
        /// <param name="_root"> </param>
        /// <param name="_nullifierHash"> </param>
        /// <param name="_recipient"> </param>
        /// <param name="_relayer"> </param>
        /// <param name="_fee"> </param>
        /// <param name="_refund"> </param>
        public async Task Withdraw(byte[] _proof, byte[] _root, byte[] _nullifierHash, Algorand.Address _recipient, Algorand.Address _relayer, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _refund, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 179, 57, 111 };
            var _proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); _proofAbi.From(_proof);
            var _rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _rootAbi.From(_root);
            var _nullifierHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _nullifierHashAbi.From(_nullifierHash);
            var _recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _recipientAbi.From(_recipient);
            var _relayerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _relayerAbi.From(_relayer);

            var result = await base.CallApp(new List<object> { abiHandle, _proofAbi, _rootAbi, _nullifierHashAbi, _recipientAbi, _relayerAbi, _fee, _refund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(byte[] _proof, byte[] _root, byte[] _nullifierHash, Algorand.Address _recipient, Algorand.Address _relayer, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _fee, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _refund, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 179, 57, 111 };
            var _proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); _proofAbi.From(_proof);
            var _rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _rootAbi.From(_root);
            var _nullifierHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _nullifierHashAbi.From(_nullifierHash);
            var _recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _recipientAbi.From(_recipient);
            var _relayerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _relayerAbi.From(_relayer);

            return await base.MakeTransactionList(new List<object> { abiHandle, _proofAbi, _rootAbi, _nullifierHashAbi, _recipientAbi, _relayerAbi, _fee, _refund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev whether a note is already spent 
        ///</summary>
        /// <param name="_nullifierHash"> </param>
        public async Task<bool> IsSpent(byte[] _nullifierHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 142, 189, 108 };
            var _nullifierHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _nullifierHashAbi.From(_nullifierHash);

            var result = await base.SimApp(new List<object> { abiHandle, _nullifierHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsSpent_Transactions(byte[] _nullifierHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 142, 189, 108 };
            var _nullifierHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _nullifierHashAbi.From(_nullifierHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, _nullifierHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev Hash 2 tree leaves, returns MiMC(_left, _right)
        ///</summary>
        /// <param name="_hasher"> </param>
        /// <param name="_left"> </param>
        /// <param name="_right"> </param>
        public async Task<byte[]> HashLeftRight(Algorand.Address _hasher, byte[] _left, byte[] _right, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 157, 115, 3 };
            var _hasherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _hasherAbi.From(_hasher);
            var _leftAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _leftAbi.From(_left);
            var _rightAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _rightAbi.From(_right);

            var result = await base.SimApp(new List<object> { abiHandle, _hasherAbi, _leftAbi, _rightAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> HashLeftRight_Transactions(Algorand.Address _hasher, byte[] _left, byte[] _right, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 157, 115, 3 };
            var _hasherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _hasherAbi.From(_hasher);
            var _leftAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _leftAbi.From(_left);
            var _rightAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _rightAbi.From(_right);

            return await base.MakeTransactionList(new List<object> { abiHandle, _hasherAbi, _leftAbi, _rightAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev Whether the root is present in the root history
        ///</summary>
        /// <param name="_root"> </param>
        public async Task<bool> IsKnownRoot(byte[] _root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 157, 170, 180 };
            var _rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _rootAbi.From(_root);

            var result = await base.SimApp(new List<object> { abiHandle, _rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsKnownRoot_Transactions(byte[] _root, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 157, 170, 180 };
            var _rootAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _rootAbi.From(_root);

            return await base.MakeTransactionList(new List<object> { abiHandle, _rootAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev Returns the last root
        ///</summary>
        public async Task<byte[]> GetLastRoot(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 4, 222, 228 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetLastRoot_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 4, 222, 228 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev provides Zero (Empty) elements for a MiMC MerkleTree. Up to 32 levels
        ///</summary>
        /// <param name="i"> </param>
        public async Task<byte[]> Zeros(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 170, 79, 253 };

            var result = await base.SimApp(new List<object> { abiHandle, i }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Zeros_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 170, 79, 253 };

            return await base.MakeTransactionList(new List<object> { abiHandle, i }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRVRIVG9ybmFkbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfdmVyaWZpZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfaGFzaGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2Rlbm9taW5hdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX21lcmtsZVRyZWVIZWlnaHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZpZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZW5vbWluYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJudWxsaWZpZXJIYXNoZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29tbWl0bWVudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiRklFTERfU0laRSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlpFUk9fVkFMVUUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoYXNoZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsZXZlbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpbGxlZFN1YnRyZWVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJvb3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlJPT1RfSElTVE9SWV9TSVpFIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjdXJyZW50Um9vdEluZGV4IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuZXh0SW5kZXgiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiQGRldiBEZXBvc2l0IGZ1bmRzIGludG8gdGhlIGNvbnRyYWN0LiBUaGUgY2FsbGVyIG11c3Qgc2VuZCAoZm9yIEVUSCkgb3IgYXBwcm92ZSAoZm9yIEVSQzIwKSB2YWx1ZSBlcXVhbCB0byBvciBgZGVub21pbmF0aW9uYCBvZiB0aGlzIGluc3RhbmNlLlxuQHBhcmFtIF9jb21taXRtZW50IHRoZSBub3RlIGNvbW1pdG1lbnQsIHdoaWNoIGlzIFBlZGVyc2VuSGFzaChudWxsaWZpZXIgKyBzZWNyZXQpIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2NvbW1pdG1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkRlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29tbWl0bWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxlYWZJbmRleCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IkBkZXYgV2l0aGRyYXcgYSBkZXBvc2l0IGZyb20gdGhlIGNvbnRyYWN0LiBgcHJvb2ZgIGlzIGEgemtTTkFSSyBwcm9vZiBkYXRhLCBhbmQgaW5wdXQgaXMgYW4gYXJyYXkgb2YgY2lyY3VpdCBwdWJsaWMgaW5wdXRzXG5gaW5wdXRgIGFycmF5IGNvbnNpc3RzIG9mOlxuLSBtZXJrbGUgcm9vdCBvZiBhbGwgZGVwb3NpdHMgaW4gdGhlIGNvbnRyYWN0XG4tIGhhc2ggb2YgdW5pcXVlIGRlcG9zaXQgbnVsbGlmaWVyIHRvIHByZXZlbnQgZG91YmxlIHNwZW5kc1xuLSB0aGUgcmVjaXBpZW50IG9mIGZ1bmRzXG4tIG9wdGlvbmFsIGZlZSB0aGF0IGdvZXMgdG8gdGhlIHRyYW5zYWN0aW9uIHNlbmRlciAodXN1YWxseSBhIHJlbGF5KSIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3Jvb3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX251bGxpZmllckhhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3JlbGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3JlZnVuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiV2l0aGRyYXdhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im51bGxpZmllckhhc2giLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWxheWVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzU3BlbnQiLCJkZXNjIjoiQGRldiB3aGV0aGVyIGEgbm90ZSBpcyBhbHJlYWR5IHNwZW50ICIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9udWxsaWZpZXJIYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGFzaExlZnRSaWdodCIsImRlc2MiOiJAZGV2IEhhc2ggMiB0cmVlIGxlYXZlcywgcmV0dXJucyBNaU1DKF9sZWZ0LCBfcmlnaHQpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfaGFzaGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9sZWZ0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9yaWdodCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0tub3duUm9vdCIsImRlc2MiOiJAZGV2IFdoZXRoZXIgdGhlIHJvb3QgaXMgcHJlc2VudCBpbiB0aGUgcm9vdCBoaXN0b3J5IiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3Jvb3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRMYXN0Um9vdCIsImRlc2MiOiJAZGV2IFJldHVybnMgdGhlIGxhc3Qgcm9vdCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ6ZXJvcyIsImRlc2MiOiJAZGV2IHByb3ZpZGVzIFplcm8gKEVtcHR5KSBlbGVtZW50cyBmb3IgYSBNaU1DIE1lcmtsZVRyZWUuIFVwIHRvIDMyIGxldmVscyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzOTZdLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgZmluZCB5b3VyIG1lcmtsZSByb290IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3Ml0sImVycm9yTWVzc2FnZSI6IkZlZSBleGNlZWRzIHRyYW5zZmVyIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM3NV0sImVycm9yTWVzc2FnZSI6IkluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTIzXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCB3aXRoZHJhdyBwcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjZdLCJlcnJvck1lc3NhZ2UiOiJNZXJrbGUgdHJlZSBpcyBmdWxsLiBObyBtb3JlIGxlYXZlcyBjYW4gYmUgYWRkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTMxXSwiZXJyb3JNZXNzYWdlIjoiTWVzc2FnZSB2YWx1ZSBpcyBzdXBwb3NlZCB0byBiZSB6ZXJvIGZvciBFVEggaW5zdGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQ0XSwiZXJyb3JNZXNzYWdlIjoiUGxlYXNlIHNlbmQgYG1peERlbm9taW5hdGlvbmAgRVRIIGFsb25nIHdpdGggdHJhbnNhY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDE0LDEzNThdLCJlcnJvck1lc3NhZ2UiOiJSZWVudHJhbmN5R3VhcmQ6IHJlZW50cmFudCBjYWxsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUzNF0sImVycm9yTWVzc2FnZSI6IlJlZnVuZCB2YWx1ZSBpcyBzdXBwb3NlZCB0byBiZSB6ZXJvIGZvciBFVEggaW5zdGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM4XSwiZXJyb3JNZXNzYWdlIjoiVGhlIGNvbW1pdG1lbnQgaGFzIGJlZW4gc3VibWl0dGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM5MF0sImVycm9yTWVzc2FnZSI6IlRoZSBub3RlIGhhcyBiZWVuIGFscmVhZHkgc3BlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTFdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5M10sImVycm9yTWVzc2FnZSI6Il9sZWZ0IHNob3VsZCBiZSBpbnNpZGUgdGhlIGZpZWxkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjU3XSwiZXJyb3JNZXNzYWdlIjoiX2xldmVscyBzaG91bGQgYmUgZ3JlYXRlciB0aGFuIHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjFdLCJlcnJvck1lc3NhZ2UiOiJfbGV2ZWxzIHNob3VsZCBiZSBsZXNzIHRoYW4gMzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzk5XSwiZXJyb3JNZXNzYWdlIjoiX3JpZ2h0IHNob3VsZCBiZSBpbnNpZGUgdGhlIGZpZWxkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxMCwxMzU0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX3N0YXR1cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzcsMTE3OSwxNzQzLDE5NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBjdXJyZW50Um9vdEluZGV4IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMSwxMjQyLDEzNjgsMTUzOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGRlbm9taW5hdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODYsMTEyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGhhc2hlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OTcsMTA1NCwxMDc0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbGV2ZWxzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4OSwxMDQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbmV4dEluZGV4IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5MCwxNDg2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdmVyaWZpZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc0XSwiZXJyb3JNZXNzYWdlIjoiZGVub21pbmF0aW9uIHNob3VsZCBiZSBncmVhdGVyIHRoYW4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxNiw2MjQsODIzLDg1NiwxMDA2LDEyOTUsMTMwNiwxMzE3LDEzMjgsMTY1NSwxNjg4LDE2OTYsMTcwNCwxNzIxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzNCw5MTIsOTQ2LDEzNDIsMTM1MCwxNzc1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxOCw4MDYsMTA2MiwxMTg2LDEyMjMsMTYxNl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0NF0sImVycm9yTWVzc2FnZSI6InVuZGVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxtRndjSEp2ZG1Gc1gzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTXpJZ01DQXhJRElnTkRJNU5EazJOekk1TlFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQWlYM04wWVhSMWN5SWdNSGdnSW1OMWNuSmxiblJTYjI5MFNXNWtaWGdpSUNKa1pXNXZiV2x1WVhScGIyNGlJQ0pzWlhabGJITWlJQ0pvWVhOb1pYSWlJQ0p1WlhoMFNXNWtaWGdpSUNKMlpYSnBabWxsY2lJZ0ltWnBiR3hsWkZOMVluUnlaV1Z6SWlBd2VEQXdJQ0p5YjI5MGN5SWdJbDlmWTNSdmNsOXdaVzVrYVc1bklpQWliblZzYkdsbWFXVnlTR0Z6YUdWeklpQXdlREF5SURCNE16QTJORFJsTnpKbE1UTXhZVEF5T1dJNE5UQTBOV0kyT0RFNE1UVTROV1F5T0RNelpUZzBPRGM1WWprM01Ea3hORE5sTVdZMU9UTm1NREF3TURBd01TQWlZMjl0YldsMGJXVnVkSE1pSURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TlRZeVpqRXlNR1VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltaGhjMmhsY2lJS0lDQWdJR0o1ZEdWalh6RWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpYkdWMlpXeHpJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpkWEp5Wlc1MFVtOXZkRWx1WkdWNElnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKdVpYaDBTVzVrWlhnaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6SWdMeThnSWw5emRHRjBkWE1pQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpZG1WeWFXWnBaWElpQ2lBZ0lDQmllWFJsWTE4eElDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbVJsYm05dGFXNWhkR2x2YmlJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnY0hWemFHbHVkQ0EwTURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T0dWbFpXTTRaakVnTUhnMU1XSXhOMlF4TmlBd2VEVTBaR000WXpCbUlEQjRZemRsTWpjMFl6VWdNSGd4TlRrMFpEVTNOQ0F3ZURZME5XWXlOVE15SURCNE56QTJOalEzTlRVZ01IaGhZak5pWTJaaU15QXdlR0k1WVdGaVpEY3dJREI0T1dOa1pHSTVaalFnTUhnek4yUm1NbVEzT1NBd2VESmhNek5qTldGa0lEQjROakk0TkRBM01Ea2dNSGhsT1dZMllqWTBOaUF3ZUdNM1pERXlPRGN5SURCNFlUaGlNek01Tm1ZZ01IaG1PVGhsWW1RMll5QXdlR0l6T1dRM016QXpJREI0WW1JNVpHRmhZalFnTUhneE16QTBaR1ZsTkNBd2VHSTRZV0UwWm1aa0lDOHZJRzFsZEdodlpDQWlYMTl3YjNOMFNXNXBkQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZG1WeWFXWnBaWElvS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1SbGJtOXRhVzVoZEdsdmJpZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWliblZzYkdsbWFXVnlTR0Z6YUdWektHSjVkR1ZiTXpKZEtXSnZiMndpTENCdFpYUm9iMlFnSW1OdmJXMXBkRzFsYm5SektHSjVkR1ZiTXpKZEtXSnZiMndpTENCdFpYUm9iMlFnSWtaSlJVeEVYMU5KV2tVb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0lscEZVazlmVmtGTVZVVW9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbWhoYzJobGNpZ3BZV1JrY21WemN5SXNJRzFsZEdodlpDQWliR1YyWld4ektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltWnBiR3hsWkZOMVluUnlaV1Z6S0hWcGJuUXlOVFlwWW5sMFpWc3pNbDBpTENCdFpYUm9iMlFnSW5KdmIzUnpLSFZwYm5ReU5UWXBZbmwwWlZzek1sMGlMQ0J0WlhSb2IyUWdJbEpQVDFSZlNFbFRWRTlTV1Y5VFNWcEZLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU4xY25KbGJuUlNiMjkwU1c1a1pYZ29LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlibVY0ZEVsdVpHVjRLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbVJsY0c5emFYUW9ZbmwwWlZzek1sMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhjb1lubDBaVnRkTEdKNWRHVmJNekpkTEdKNWRHVmJNekpkTEdGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBkbTlwWkNJc0lHMWxkR2h2WkNBaWFYTlRjR1Z1ZENoaWVYUmxXek15WFNsaWIyOXNJaXdnYldWMGFHOWtJQ0pvWVhOb1RHVm1kRkpwWjJoMEtHRmtaSEpsYzNNc1lubDBaVnN6TWwwc1lubDBaVnN6TWwwcFlubDBaVnN6TWwwaUxDQnRaWFJvYjJRZ0ltbHpTMjV2ZDI1U2IyOTBLR0o1ZEdWYk16SmRLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltZGxkRXhoYzNSU2IyOTBLQ2xpZVhSbFd6TXlYU0lzSUcxbGRHaHZaQ0FpZW1WeWIzTW9kV2x1ZERJMU5pbGllWFJsV3pNeVhTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRjlmY0c5emRFbHVhWFFnZG1WeWFXWnBaWElnWkdWdWIyMXBibUYwYVc5dUlHNTFiR3hwWm1sbGNraGhjMmhsY3lCamIyMXRhWFJ0Wlc1MGN5QnRZV2x1WDBaSlJVeEVYMU5KV2tWZmNtOTFkR1ZBTVRBZ2JXRnBibDlhUlZKUFgxWkJURlZGWDNKdmRYUmxRREV4SUdoaGMyaGxjaUJzWlhabGJITWdabWxzYkdWa1UzVmlkSEpsWlhNZ2NtOXZkSE1nYldGcGJsOVNUMDlVWDBoSlUxUlBVbGxmVTBsYVJWOXliM1YwWlVBeE5pQmpkWEp5Wlc1MFVtOXZkRWx1WkdWNElHNWxlSFJKYm1SbGVDQmtaWEJ2YzJsMElIZHBkR2hrY21GM0lHbHpVM0JsYm5RZ2FHRnphRXhsWm5SU2FXZG9kQ0JwYzB0dWIzZHVVbTl2ZENCblpYUk1ZWE4wVW05dmRDQjZaWEp2Y3dvZ0lDQWdaWEp5Q2dwdFlXbHVYMUpQVDFSZlNFbFRWRTlTV1Y5VFNWcEZYM0p2ZFhSbFFERTJPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNREF3TURGbENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmV2tWU1QxOVdRVXhWUlY5eWIzVjBaVUF4TVRvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTW1abE5UUmpOakJrTTJGallXSm1Nek0wTTJFek5XSTJaV0poTVRWa1lqUTRNakZpTXpRd1pqYzJaVGMwTVdVeU1qUTVOamcxWldRME9EazVZV1kyWXdvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMFpKUlV4RVgxTkpXa1ZmY205MWRHVkFNVEE2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVYMTl3YjNOMFNXNXBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2w5ZmNHOXpkRWx1YVhRNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRjlmY0c5emRFbHVhWFFnWVd4eVpXRmtlU0JqWVd4c1pXUUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSmZYMk4wYjNKZmNHVnVaR2x1WnlJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdYMnhsZG1Wc2N5QnphRzkxYkdRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUhwbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdYMnhsZG1Wc2N5QnphRzkxYkdRZ1ltVWdiR1Z6Y3lCMGFHRnVJRE15Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pzWlhabGJITWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlhR0Z6YUdWeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NncGZYM0J2YzNSSmJtbDBYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2dYMTl3YjNOMFNXNXBkRjloWm5SbGNsOTNhR2xzWlVBMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVptbHNiR1ZrVTNWaWRISmxaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnWDE5d2IzTjBTVzVwZEY5M2FHbHNaVjkwYjNCQU1nb0tYMTl3YjNOMFNXNXBkRjloWm5SbGNsOTNhR2xzWlVBME9nb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjeU5tWTJaamMwTnpNMk5qWTROMkZoWkdZNE5qSmlaRGMzTm1NNFptTXhPR0k0WlRsbU9HVXlNREE0T1RjeE5EZzFObVZsTWpNellqTTVNREpoTlRreFpEQmtOV1l5T1RJMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVgzTjBZWFIxY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNENpQWdJQ0JpUGdvZ0lDQWdZWE56WlhKMElDOHZJR1JsYm05dGFXNWhkR2x2YmlCemFHOTFiR1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblpsY21sbWFXVnlJZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0prWlc1dmJXbHVZWFJwYjI0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWRtVnlhV1pwWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm1sbGNqb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMlpYSnBabWxsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZG1WeWFXWnBaWElnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NWtaVzV2YldsdVlYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXNXZiV2x1WVhScGIyNDZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVpHVnViMjFwYm1GMGFXOXVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmtaVzV2YldsdVlYUnBiMjRnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWJuVnNiR2xtYVdWeVNHRnphR1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JuVnNiR2xtYVdWeVNHRnphR1Z6T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKdWRXeHNhV1pwWlhKSVlYTm9aWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZbmwwWldNZ01URWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTVqYjIxdGFYUnRaVzUwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnZiVzFwZEcxbGJuUnpPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0pqYjIxdGFYUnRaVzUwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG1oaGMyaGxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21oaGMyaGxjam9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSm9ZWE5vWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdoaGMyaGxjaUJsZUdsemRITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxteGxkbVZzYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteGxkbVZzY3pvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pzWlhabGJITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHeGxkbVZzY3lCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbVpwYkd4bFpGTjFZblJ5WldWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tabWxzYkdWa1UzVmlkSEpsWlhNNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWm1sc2JHVmtVM1ZpZEhKbFpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbkp2YjNSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbTl2ZEhNNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpY205dmRITWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbU4xY25KbGJuUlNiMjkwU1c1a1pYaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqZFhKeVpXNTBVbTl2ZEVsdVpHVjRPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltTjFjbkpsYm5SU2IyOTBTVzVrWlhnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUdOMWNuSmxiblJTYjI5MFNXNWtaWGdnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NXVaWGgwU1c1a1pYaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B1WlhoMFNXNWtaWGc2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlibVY0ZEVsdVpHVjRJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnVaWGgwU1c1a1pYZ2daWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1a1pYQnZjMmwwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVndiM05wZERvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdZbmwwWldNZ01UVWdMeThnTUhnd01nb2dJQ0FnWWlFOUNpQWdJQ0JoYzNObGNuUWdMeThnVW1WbGJuUnlZVzVqZVVkMVlYSmtPaUJ5WldWdWRISmhiblFnWTJGc2JBb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnSWw5emRHRjBkWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKamIyMXRhWFJ0Wlc1MGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCVWFHVWdZMjl0YldsMGJXVnVkQ0JvWVhNZ1ltVmxiaUJ6ZFdKdGFYUjBaV1FLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSnVaWGgwU1c1a1pYZ2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYm1WNGRFbHVaR1Y0SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lteGxkbVZzY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYkdWMlpXeHpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaR2xuSURFS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV1Z5YTJ4bElIUnlaV1VnYVhNZ1puVnNiQzRnVG04Z2JXOXlaU0JzWldGMlpYTWdZMkZ1SUdKbElHRmtaR1ZrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1kyOTJaWElnTWdvS1pHVndiM05wZEY5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKc1pYWmxiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR3hsZG1Wc2N5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBekNpQWdJQ0ErQ2lBZ0lDQmllaUJrWlhCdmMybDBYMkZtZEdWeVgzZG9hV3hsUURjS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDVUtJQ0FnSUdKdWVpQmtaWEJ2YzJsMFgyVnNjMlZmWW05a2VVQTFDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM01LSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWm1sc2JHVmtVM1ZpZEhKbFpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdKMWNua2dPQW9LWkdWd2IzTnBkRjloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWFHRnphR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJvWVhOb1pYSWdaWGhwYzNSekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVhR0Z6YUV4bFpuUlNhV2RvZEFvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXZDaUFnSUNCaWRYSjVJREVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXpDaUFnSUNCaUlHUmxjRzl6YVhSZmQyaHBiR1ZmZEc5d1FESUtDbVJsY0c5emFYUmZaV3h6WlY5aWIyUjVRRFU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKbWFXeHNaV1JUZFdKMGNtVmxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWlCa1pYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29LWkdWd2IzTnBkRjloWm5SbGNsOTNhR2xzWlVBM09nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1OMWNuSmxiblJTYjI5MFNXNWtaWGdpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR04xY25KbGJuUlNiMjkwU1c1a1pYZ2daWGhwYzNSekNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2NIVnphR2x1ZENBek1Bb2dJQ0FnSlFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTNWeWNtVnVkRkp2YjNSSmJtUmxlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKeWIyOTBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0p1WlhoMFNXNWtaWGdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JuZEhodUlEQWdRVzF2ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWkdWdWIyMXBibUYwYVc5dUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCa1pXNXZiV2x1WVhScGIyNGdaWGhwYzNSekNpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRYkdWaGMyVWdjMlZ1WkNCZ2JXbDRSR1Z1YjIxcGJtRjBhVzl1WUNCRlZFZ2dZV3h2Ym1jZ2QybDBhQ0IwY21GdWMyRmpkR2x2YmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURjS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOak1tUTNNRGczSUM4dklHMWxkR2h2WkNBaVJHVndiM05wZENoaWVYUmxXek15WFN4MWFXNTBOalFzZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDl6ZEdGMGRYTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDl6ZEdGMGRYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUF3ZURBeUNpQWdJQ0JpSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldWdWRISmhibU41UjNWaGNtUTZJSEpsWlc1MGNtRnVkQ0JqWVd4c0NpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWDNOMFlYUjFjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaR1Z1YjIxcGJtRjBhVzl1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJrWlc1dmJXbHVZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSbVZsSUdWNFkyVmxaSE1nZEhKaGJuTm1aWElnZG1Gc2RXVUtJQ0FnSUdScFp5QTBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0p1ZFd4c2FXWnBaWEpJWVhOb1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVkdobElHNXZkR1VnYUdGeklHSmxaVzRnWVd4eVpXRmtlU0J6Y0dWdWRBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1cGMwdHViM2R1VW05dmRBb2dJQ0FnWVhOelpYSjBJQzh2SUVOaGJtNXZkQ0JtYVc1a0lIbHZkWElnYldWeWEyeGxJSEp2YjNRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5abGNtbG1hV1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIyWlhKcFptbGxjaUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEYzRaalEwTTJZM0lDOHZJRzFsZEdodlpDQWlkbVZ5YVdaNVVISnZiMllvWW5sMFpWdGRMSFZwYm5ReU5UWmJObDBwWW05dmJDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0IzYVhSb1pISmhkeUJ3Y205dlpnb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdkMGVHNGdNQ0JCYlc5MWJuUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJOWlhOellXZGxJSFpoYkhWbElHbHpJSE4xY0hCdmMyVmtJSFJ2SUdKbElIcGxjbThnWm05eUlFVlVTQ0JwYm5OMFlXNWpaUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VtVm1kVzVrSUhaaGJIVmxJR2x6SUhOMWNIQnZjMlZrSUhSdklHSmxJSHBsY204Z1ptOXlJRVZVU0NCcGJuTjBZVzVqWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbVJsYm05dGFXNWhkR2x2YmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWkdWdWIyMXBibUYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZajQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVrWlhKbWJHOTNDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdKNWRHVmpJREU0SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRElLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2dkMmwwYUdSeVlYZGZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3AzYVhSb1pISmhkMTloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTmdvZ0lDQWdaR2xuSURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhpT0ROaVkySTNZU0F2THlCdFpYUm9iMlFnSWxkcGRHaGtjbUYzWVd3b1lXUmtjbVZ6Y3l4aWVYUmxXek15WFN4aFpHUnlaWE56TEhWcGJuUXlOVFlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pmYzNSaGRIVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbWx6VTNCbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzFOd1pXNTBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0p1ZFd4c2FXWnBaWEpJWVhOb1pYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NW9ZWE5vVEdWbWRGSnBaMmgwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FHRnphRXhsWm5SU2FXZG9kRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1b1lYTm9UR1ZtZEZKcFoyaDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NXBjMHR1YjNkdVVtOXZkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selMyNXZkMjVTYjI5ME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JqWVd4c2MzVmlJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1YVhOTGJtOTNibEp2YjNRS0lDQWdJR0o1ZEdWaklERXhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1WjJWMFRHRnpkRkp2YjNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJNWVhOMFVtOXZkRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpkWEp5Wlc1MFVtOXZkRWx1WkdWNElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamRYSnlaVzUwVW05dmRFbHVaR1Y0SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0p5YjI5MGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDZaWEp2Y3pvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxucGxjbTl6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTVvWVhOb1RHVm1kRkpwWjJoMEtGOW9ZWE5vWlhJNklHSjVkR1Z6TENCZmJHVm1kRG9nWW5sMFpYTXNJRjl5YVdkb2REb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbWhoYzJoTVpXWjBVbWxuYUhRNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV01nTVRZZ0x5OGdNSGd6TURZME5HVTNNbVV4TXpGaE1ESTVZamcxTURRMVlqWTRNVGd4TlRnMVpESTRNek5sT0RRNE56bGlPVGN3T1RFME0yVXhaalU1TTJZd01EQXdNREF4Q2lBZ0lDQmlQQW9nSUNBZ1lYTnpaWEowSUM4dklGOXNaV1owSUhOb2IzVnNaQ0JpWlNCcGJuTnBaR1VnZEdobElHWnBaV3hrQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURFMklDOHZJREI0TXpBMk5EUmxOekpsTVRNeFlUQXlPV0k0TlRBME5XSTJPREU0TVRVNE5XUXlPRE16WlRnME9EYzVZamszTURreE5ETmxNV1kxT1RObU1EQXdNREF3TVFvZ0lDQWdZandLSUNBZ0lHRnpjMlZ5ZENBdkx5QmZjbWxuYUhRZ2MyaHZkV3hrSUdKbElHbHVjMmxrWlNCMGFHVWdabWxsYkdRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXhPU0F2THlCdFpYUm9iMlFnSWsxcFRVTlRjRzl1WjJVb2RXbHVkREkxTml4MWFXNTBNalUyS1NoMWFXNTBNalUyTEhWcGJuUXlOVFlwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F6TWdvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElETTJJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QXdlRE13TmpRMFpUY3laVEV6TVdFd01qbGlPRFV3TkRWaU5qZ3hPREUxT0RWa01qZ3pNMlU0TkRnM09XSTVOekE1TVRRelpURm1OVGt6WmpBd01EQXdNREVLSUNBZ0lHSWxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QnRaWFJvYjJRZ0lrMXBUVU5UY0c5dVoyVW9kV2x1ZERJMU5peDFhVzUwTWpVMktTaDFhVzUwTWpVMkxIVnBiblF5TlRZcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWFYTkxibTkzYmxKdmIzUW9YM0p2YjNRNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVhWE5MYm05M2JsSnZiM1E2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lpSUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNENpQWdJQ0JpUFQwS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWFYTkxibTkzYmxKdmIzUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVhWE5MYm05M2JsSnZiM1JmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltTjFjbkpsYm5SU2IyOTBTVzVrWlhnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCamRYSnlaVzUwVW05dmRFbHVaR1Y0SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG1selMyNXZkMjVTYjI5MFgzZG9hV3hsWDNSdmNFQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWljbTl2ZEhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUFQwS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWFYTkxibTkzYmxKdmIzUmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVhWE5MYm05M2JsSnZiM1JmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdKdWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbWx6UzI1dmQyNVNiMjkwWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ2NIVnphR2x1ZENBek1Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbWx6UzI1dmQyNVNiMjkwWDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBaFBRb2dJQ0FnWW01NklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVhWE5MYm05M2JsSnZiM1JmZDJocGJHVmZkRzl3UURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1ZW1WeWIzTW9hVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1NlpYSnZjMTlsYkhObFgySnZaSGxBTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TW1abE5UUmpOakJrTTJGallXSm1Nek0wTTJFek5XSTJaV0poTVRWa1lqUTRNakZpTXpRd1pqYzJaVGMwTVdVeU1qUTVOamcxWldRME9EazVZV1kyWXdvZ0lDQWdjbVYwYzNWaUNnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNUW9nSUNBZ1lqMDlDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lOVFpoTmpFek5UYzNOMlZsWlRKbVpESTJaalUwWWpoaU56QXpOMkV5TlRRek9XUTFNak0xWTJGbFpUSXlOREUxTkRFNE5tUXlZamhoTlRKbE16RmtDaUFnSUNCeVpYUnpkV0lLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM05mWld4elpWOWliMlI1UURRNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWaklERTFJQzh2SURCNE1ESUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NTZaWEp2YzE5bGJITmxYMkp2WkhsQU5nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1URTFNVGswT1RnNU5XVTRNbUZpTVRrNU1qUmtaVGt5WXpRd1lUTmtObVkzWW1OaU5qQmtPVEppTURBMU1EUmlPREU1T1RZeE16WTRNMll3WXpJd01Bb2dJQ0FnY21WMGMzVmlDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUEyT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TXdvZ0lDQWdZajA5Q2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUE0Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TURFeU1XVmxPREV4TkRnNVptWTRaRFl4WmpBNVptSTRPV1V6TVRObU1UUTVOVGxoTUdZeU9HSmlOREk0WVRJd1pHSmhObUl3WWpBMk9HSXpZbVJpQ2lBZ0lDQnlaWFJ6ZFdJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOZlpXeHpaVjlpYjJSNVFEZzZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQTBDaUFnSUNCaVBUMEtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOZlpXeHpaVjlpYjJSNVFERXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dZVGc1WTJFMlptWmhNVFJqWXpRMk1tTm1aV1JpT0RReVl6TXdaV1F5TWpGaE5UQmhNMlEyWW1Zd01qSmhObUUxTjJSak9ESmhZakkwWXpFMU4yTTVDaUFnSUNCeVpYUnpkV0lLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM05mWld4elpWOWliMlI1UURFd09nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd05Rb2dJQ0FnWWowOUNpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxucGxjbTl6WDJWc2MyVmZZbTlrZVVBeE1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qUmpZVEExWXpKaU5XTmtOREpsT0Rrd1pEWmlaVGswWXpZNFpEQTJPRGxtTkdZeU1XTTVZMlZqT1dNd1pqRXpabVUwTVdRMU5qWmtabUkxTkRrMU9Rb2dJQ0FnY21WMGMzVmlDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUF4TWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURZS0lDQWdJR0k5UFFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1NlpYSnZjMTlsYkhObFgySnZaSGxBTVRRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURGalkySTVOMk01TXpJMU5qVmhPVEpqTmpBeE5UWmlaR0poTW1Rd09HWXpZbVl4TXpjM05EWTBaVEF5TldObFpUYzJOVFkzT1dVMk1EUmhOek14TldNS0lDQWdJSEpsZEhOMVlnb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTU2WlhKdmMxOWxiSE5sWDJKdlpIbEFNVFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREEzQ2lBZ0lDQmlQVDBLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1ZW1WeWIzTmZaV3h6WlY5aWIyUjVRREUyQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4T1RFMU5tWmlaRGRrTVdFNFltWTFZMkpoT0Rrd09UTTJOMlJsTVdJMk1qUTFNelJsWW1GaU5HWXdaamM1WlRBd00ySmpZMlJrTVdJeE9ESmlaR0kwQ2lBZ0lDQnlaWFJ6ZFdJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOZlpXeHpaVjlpYjJSNVFERTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dPQW9nSUNBZ1lqMDlDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQXhPQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNall4WVdZNFl6Rm1NRGt4TW1VME5qVTNORFEyTkRFME1EbG1Oakl5WkRRMk5tTXpPVEl3WVdNMlpUVm1aak0zWlRNMk5qQTBZMkl4TVdSbVptWTRNQW9nSUNBZ2NtVjBjM1ZpQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxucGxjbTl6WDJWc2MyVmZZbTlrZVVBeE9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1Ea0tJQ0FnSUdJOVBRb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NTZaWEp2YzE5bGJITmxYMkp2WkhsQU1qQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOVGcwTlRrM01qUm1aalpqWVRWaE1UWTFNbVpqWW1NelpUZ3lZamt6T0RrMVkyWXdPR1U1TnpWaU1UbGlaV0ZpTTJZMU5HTXlNVGRrTVdNd01EY0tJQ0FnSUhKbGRITjFZZ29LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1NlpYSnZjMTlsYkhObFgySnZaSGxBTWpBNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaENpQWdJQ0JpUFQwS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM05mWld4elpWOWliMlI1UURJeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneFpqQTBaV1l5TUdSbFpUUTRaRE01T1RnMFpEaGxZV0psTnpZNFlUY3daV0ZtWVRZek1UQmhaREl3T0RRNVpEUTFOek5qTTJNME1HTXlZV1F4WlRNd0NpQWdJQ0J5WlhSemRXSUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1ZW1WeWIzTmZaV3h6WlY5aWIyUjVRREl5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WWdvZ0lDQWdZajA5Q2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUF5TkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVdKbFlUTmtaV00xWkdGaU5URTFOamRqWlRkbE1qQXdZVE13WmpkaVlUWmtOREkzTm1GbFlXRTFNMlV5TmpnMlpqazJNbUUwTm1NMk5tUTFNVEZsTlFvZ0lDQWdjbVYwYzNWaUNnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQXlORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR01LSUNBZ0lHSTlQUW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTU2WlhKdmMxOWxiSE5sWDJKdlpIbEFNallLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREJsWlRCbU9UUXhaVEprWVRSaU9XVXpNV016WTJFNU4yRTBNR1E0Wm1FNVkyVTJPR1E1TjJNd09EUXhOemN3TnpGaU0yTmlORFpqWkRNek56Sm1NR1lLSUNBZ0lISmxkSE4xWWdvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NTZaWEp2YzE5bGJITmxYMkp2WkhsQU1qWTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmtDaUFnSUNCaVBUMEtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOZlpXeHpaVjlpYjJSNVFESTRDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hZMkU1TlRBelpUZzVNelU0T0RRMU1ERmlZbUZtTWpCaVpURTBaV0kwWXpRMllqZzVOemN5WXprM1lqazJaVE5pTW1WaVpqTmhNelpoT1RRNFltSmtDaUFnSUNCeVpYUnpkV0lLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM05mWld4elpWOWliMlI1UURJNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd1pRb2dJQ0FnWWowOUNpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxucGxjbTl6WDJWc2MyVmZZbTlrZVVBek1Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UTXpZVGd3WlRNd05qazNZMlExTldRNFpqZGtOR0l3T1RZMVlqZGlaVEkwTURVM1ltRTFaR016WkdFNE9UaGxaVEl4T0RjeU16STBORFpqWWpFd09Bb2dJQ0FnY21WMGMzVmlDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUF6TURvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdZS0lDQWdJR0k5UFFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1NlpYSnZjMTlsYkhObFgySnZaSGxBTXpJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFelpUWmtPR1pqT0RnNE16bGxaRGMyWlRFNE1tTXlZVGMzT1dGbU5XSXlZekJrWVRsa1pERTRZemt3TkRJM1lUWTBOR1kzWlRFME9HRTJNalV6WWpZS0lDQWdJSEpsZEhOMVlnb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTU2WlhKdmMxOWxiSE5sWDJKdlpIbEFNekk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREV3Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1ZW1WeWIzTmZaV3h6WlY5aWIyUjVRRE0wQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4WldJeE5tSXdOVGRoTkRjM1pqUmlZemhtTlRjeVpXRTJZbVZsTXprMU5qRXdPVGhtTnpobU1UVmlabUl6TmprNVpHTmlZamRpWkRoa1lqWXhPRFUwQ2lBZ0lDQnlaWFJ6ZFdJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOZlpXeHpaVjlpYjJSNVFETTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hNUW9nSUNBZ1lqMDlDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQXpOZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR1JoTW1OaU1UWmhNV05sWVdGaVpqRmpNVFppT0RNNFpqZGhPV1V6WmpKaE0yRXpNRGc0WkRsbE1HRTJaR1ZpWVdFM05EZ3hNVFEyTWpBMk9UWmxZUW9nSUNBZ2NtVjBjM1ZpQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxucGxjbTl6WDJWc2MyVmZZbTlrZVVBek5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1USUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NTZaWEp2YzE5bGJITmxYMkp2WkhsQU16Z0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTBZVE5pTTJRNE1qSTBNakJpTVRSaU5XUTRZMkkyWXpJNFlUVTNOR1l3TVdVNU9HVmhPV1U1TkRBMU5URmtNbVZpWkRjMVkyVmxNVEkyTkRsbU9XUUtJQ0FnSUhKbGRITjFZZ29LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1NlpYSnZjMTlsYkhObFgySnZaSGxBTXpnNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFekNpQWdJQ0JpUFQwS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM05mWld4elpWOWliMlI1UURRd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE9UZzJNakpoWTJKa056Z3paREZpTUdRNU1EWTBNVEExWWpGbVl6aGxOR1E0T0RnNVpHVTVOV00wWXpVeE9XSXpaall6TlRnd09XWmxObUZtWXpBMUNpQWdJQ0J5WlhSemRXSUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1ZW1WeWIzTmZaV3h6WlY5aWIyUjVRRFF3T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TkFvZ0lDQWdZajA5Q2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUEwTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpsa04yVmtNemt4TWpVMlkyTmpNMlZoTlRrMll6ZzJaVGt6TTJJNE9XWm1Nek01WkRJMVpXRTRaR1JqWldRNU56VmhaVEptWlRNd1lqVXlPVFprTkFvZ0lDQWdjbVYwYzNWaUNnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQTBNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFVLSUNBZ0lHSTlQUW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTU2WlhKdmMxOWxiSE5sWDJKdlpIbEFORFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREU1WW1VMU9XWXlaakEwTVROalpUYzRZekJqTXpjd00yRXpZVFUwTlRGaU1XUTNaak01TmpJNVptRXpNMkZpWkRFeE5UUTRZVGMyTURZMVlqSTVOamNLSUNBZ0lISmxkSE4xWWdvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NTZaWEp2YzE5bGJITmxYMkp2WkhsQU5EUTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTJDaUFnSUNCaVBUMEtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOZlpXeHpaVjlpYjJSNVFEUTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3habVl6WmpZeE56azNaVFV6T0dJM01HVTJNVGt6TVRCa016Tm1NbUV3TmpObE4yVmlOVGt4TURSbE1URXlaVGsxTnpNNFpHRXhNalUwWkdNek5EVXpDaUFnSUNCeVpYUnpkV0lLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM05mWld4elpWOWliMlI1UURRMk9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE53b2dJQ0FnWWowOUNpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxucGxjbTl6WDJWc2MyVmZZbTlrZVVBME9Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UQmpNVFpoWlRrNU5UbGpaamd6TlRnNU9EQmtPV1JrT1RZeE5tVTBPREl5T0Rjek56TXhNR0V4TUdVeVlqWmlOek14WXpGaE5UUTRaakF6Tm1NME9Bb2dJQ0FnY21WMGMzVmlDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUEwT0RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1NlpYSnZjMTlsYkhObFgySnZaSGxBTlRBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCaVlUUXpNMkUyTXpFM05HRTVNR0ZqTWpBNU9USmxOelZsTXpBNU5UUTVOamd4TW1JMk5USTJPRFZpTldVeFlUSmxZV1V3WWpGaVpqUmxPR1pqWkRFS0lDQWdJSEpsZEhOMVlnb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTU2WlhKdmMxOWxiSE5sWDJKdlpIbEFOVEE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREU1Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1ZW1WeWIzTmZaV3h6WlY5aWIyUjVRRFV5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVRsa1pHSTVaR1l5WW1NNU9HUTVPRGRrTUdSbVpXTmhPV1F5WWpZME0yUmxZV1poWWpobU56QXpOalUyTW1VMk1qZGpNelkyTnpJMk5tRXdORFJqQ2lBZ0lDQnlaWFJ6ZFdJS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MGIzSnVZV1J2TFdOaGMyZ3ZZMjl1ZEhKaFkzUnpMMFZVU0ZSdmNtNWhaRzh1YzI5c0xrVlVTRlJ2Y201aFpHOHVlbVZ5YjNOZlpXeHpaVjlpYjJSNVFEVXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hZUW9nSUNBZ1lqMDlDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQTFOQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNbVF6WXpnNFlqSXpNVGMxWXpWaE5UVTJOV1JpT1RJNE5ERTBZelkyWkRFNU1USmlNVEZoWTJZNU56UmlNbVUyTkRSallXRmhZekEwTnpNNVkyVTVPUW9nSUNBZ2NtVjBjM1ZpQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZEc5eWJtRmtieTFqWVhOb0wyTnZiblJ5WVdOMGN5OUZWRWhVYjNKdVlXUnZMbk52YkM1RlZFaFViM0p1WVdSdkxucGxjbTl6WDJWc2MyVmZZbTlrZVVBMU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XSUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NTZaWEp2YzE5bGJITmxYMkp2WkhsQU5UWUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESmxZV0kxTldZMllXVTBaVFkyWlRNeVl6VXhPRGxsWldRMVl6UTNNRGcwTURnMk16UTBOVGMyTUdZMVpXUTNaVGRpTmpsaU1tRTJNall3TUdZek5UUUtJQ0FnSUhKbGRITjFZZ29LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1J2Y201aFpHOHRZMkZ6YUM5amIyNTBjbUZqZEhNdlJWUklWRzl5Ym1Ga2J5NXpiMnd1UlZSSVZHOXlibUZrYnk1NlpYSnZjMTlsYkhObFgySnZaSGxBTlRZNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURGakNpQWdJQ0JpUFQwS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkwYjNKdVlXUnZMV05oYzJndlkyOXVkSEpoWTNSekwwVlVTRlJ2Y201aFpHOHVjMjlzTGtWVVNGUnZjbTVoWkc4dWVtVnliM05mWld4elpWOWliMlI1UURVNENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ESmtaak0zWVRJMk5ESTJNakU0TURJek9ETmpaamsxTW1KbU5HUmtNV1l6TW1Vd05UUXpNMkpsWldJeFptUTBNVEF6TVdaaU4yVmhZMlU1Tnpsa0NpQWdJQ0J5WlhSemRXSUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTBiM0p1WVdSdkxXTmhjMmd2WTI5dWRISmhZM1J6TDBWVVNGUnZjbTVoWkc4dWMyOXNMa1ZVU0ZSdmNtNWhaRzh1ZW1WeWIzTmZaV3h6WlY5aWIyUjVRRFU0T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4WkFvZ0lDQWdZajA5Q2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkRzl5Ym1Ga2J5MWpZWE5vTDJOdmJuUnlZV04wY3k5RlZFaFViM0p1WVdSdkxuTnZiQzVGVkVoVWIzSnVZV1J2TG5wbGNtOXpYMlZzYzJWZlltOWtlVUEyTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRBMFlXVmlOREUwTXpWa1lqWTJZek5sTmpKbVpXTmpZekZrTm1ZMVpEazRaREJoTUdWa056VmtNVE0zTkdSaU5EVTNZMlkwTmpKbE0yRXhaalF5TndvZ0lDQWdjbVYwYzNWaUNnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbnBsY205elgyVnNjMlZmWW05a2VVQTJNRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNV1VLSUNBZ0lHSTlQUW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzUnZjbTVoWkc4dFkyRnphQzlqYjI1MGNtRmpkSE12UlZSSVZHOXlibUZrYnk1emIyd3VSVlJJVkc5eWJtRmtieTU2WlhKdmMxOWxiSE5sWDJKdlpIbEFOaklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREZtTTJNMlptUTROVGhsT1dFM1pEUmlNR1F4WmpNNFpUSTFObUV3T1dRNE1XUTFZVFZsTTJNNU5qTTVPRGRsTW1RMFlqZ3hOR05tWVdJM1l6WmxZbUlLSUNBZ0lISmxkSE4xWWdvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNSdmNtNWhaRzh0WTJGemFDOWpiMjUwY21GamRITXZSVlJJVkc5eWJtRmtieTV6YjJ3dVJWUklWRzl5Ym1Ga2J5NTZaWEp2YzE5bGJITmxYMkp2WkhsQU5qSTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERm1DaUFnSUNCaVBUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneVl6ZGhNRGRrTWpCa1ptWTNPV1F3TVdabFkyVmtZekV4TXpReU9EUmhPR1F3T0RRek5qWXdObU01TXpZNU0ySTJOMlV6TXpObU5qY3hZbVkyT1dOakNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRHOXlibUZrYnkxallYTm9MMk52Ym5SeVlXTjBjeTlGVkVoVWIzSnVZV1J2TG5OdmJDNUZWRWhVYjNKdVlXUnZMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRklBQUJBdi8vLy84UEpoUUVGUjk4ZFNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWRmYzNSaGRIVnpBQkJqZFhKeVpXNTBVbTl2ZEVsdVpHVjRER1JsYm05dGFXNWhkR2x2Ymdac1pYWmxiSE1HYUdGemFHVnlDVzVsZUhSSmJtUmxlQWgyWlhKcFptbGxjZzVtYVd4c1pXUlRkV0owY21WbGN3RUFCWEp2YjNSekRsOWZZM1J2Y2w5d1pXNWthVzVuRDI1MWJHeHBabWxsY2toaGMyaGxjd0VDSURCa1RuTGhNYUFwdUZCRnRvR0JXRjBvTStoSWVibHdrVVBoOVpQd0FBQUJDMk52YlcxcGRHMWxiblJ6SVFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVJXTHhJT01SaEFBQ0VuQnlsbkp3WWpaeWNFSTJjbkNDTm5LaXRuSndrcFp5Y0ZLMmNuRFNSbkpFT0JnQ0N2TlFBMEFJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlCY1FEVUFNUmtVUkRFWVJJSVZCSTd1eVBFRVViRjlGZ1JVM0l3UEJNZmlkTVVFRlpUVmRBUmtYeVV5QkhCbVIxVUVxenZQc3dTNXFyMXdCSnpkdWZRRU45OHRlUVFxTThXdEJHS0VCd2tFNmZhMlJnVEgwU2h5Qktpek9XOEUrWTY5YkFTem5YTURCTHVkcXJRRUV3VGU1QVM0cWsvOU5ob0FqaFVBWkFFVkFTQUJNd0ZVQURzQUVnRjFBWUFCakFHdUFBRUIwQUhjQWVnQyt3UnpCSlFFdFFUTUJPc0FnQXdWSDN4MUFBQUFBQUFBQUI2d0pFT0FKQlVmZkhVdjVVeGcwNnlyOHpRNk5iYnJvVjIwZ2hzMEQzYm5RZUlrbG9YdFNKbXZiTEFrUTRBa0ZSOThkVEJrVG5MaE1hQXB1RkJGdG9HQldGMG9NK2hJZWJsd2tVUGg5WlB3QUFBQnNDUkROaG9CU1JVaUVrUTJHZ0pKRlNJU1JEWWFBMGxPQWhVaUVrUTJHZ1JKRllFSUVrUVhTVTRDSncxa1JDY05JMmRKUkVraURFUW5Ca3huSndkTVp5TkpTd0lNUVFBZ1J3SVdTWWdGS0NLdlR3SlFTUlVpQ1NKWUFTY0tURkJNdnlRSVJRRkMvOWxMQVNRSlNTRUVEa1FXaUFVQ2dDVnliMjkwYzJab2VxMzRZcjEzYkkvQmk0NmZqaUFJbHhTRmJ1SXpzNUFxV1IwTlh5a2xUTDhrRmlwTVowc0NTU3VsUkNjSlN3Vm5Kd1ZNWnlSREl5Y0paVVFvVEZDd0pFTWpKd1ZsUkVrVklnNUVJcStyS0V4UXNDUkROaG9CU1JVaUVrUUJKdzVNVUw1TUZ5Tk1Ud0pOSndzalR3SlVLRXhRc0NSRE5ob0JTUlVpRWtRQkp4Rk1VTDVNRnlOTVR3Sk5Kd3NqVHdKVUtFeFFzQ1JESXljSFpVUW9URkN3SkVNakp3WmxSQllvVEZDd0pFTTJHZ0ZKRlNJU1JDS3ZURkJKRlNJSklsZ0JKd3BNVUw0cFRnSk5LRXhRc0NSRE5ob0JTUlVpRWtRaXIweFFTUlVpQ1NKWUFTY01URkMrS1U0Q1RTaE1VTEFrUXlNbkJHVkVGaWhNVUxBa1F5TW5DR1ZFRmloTVVMQWtReU0yR2dGSEFoVWlFa1FqS21WRUp3K3BSQ1VXS2t4blNRRW5FVXhRU1U0Q3Zrd1hJMHhQQWswVVJDTW5DR1ZNU1U0Q1RnTkVJeWNHWlVRbFRKUkpJUVFPUkVzQkUwUWpUZ0lqSndabFJFc0REVUVBWGtrbEdFQUFPMHNDRmttSUE0OU1JcTlNVUVrVklna2lXQUVuQ2t4UVN3TkpUZ0svUlFnakp3ZGxSRXNJVHdLSUFvOUZBa2tsQ2tVQlN3SWtDRVVEUXYrMElxOUxBeFpRU1JVaUNTSllBU2NLVEZDK0tVNENUVVVIU3dGQy84Y2pKd1JsUkNRSVNTRUVEa1NCSGhnbkJFc0JaeUt2VEJaUVNSVWlDU0pZQVNjTVRGQkxBcjlMQTBra0NFa2hCQTVFSndoTVp5UVdTd1pNdnpNQUNCWWpKd1ZsUktoRUZqSUhGa3NIVHdKUVRGQ0FCTXd0Y0lkTVVMQWtGaXBNWnlSRE5ob0JTU05aSlFoTEFSVVNSRmNDQURZYUFra1ZJaEpFTmhvRFNVNERTUlVpRWtRMkdnUkpUZ1JKRlNJU1JEWWFCVWxPQlVrVkloSkVOaG9HU1U0R1NSVkpUZ2NpRWtRMkdnZEpGU0lTUkNNcVpVUW5ENmxFSlJZcVRHY2pKd1ZsUkVzQ3AwUkxCQUVuRGt4UVNiNU1GeU5NVHdKTkZFUkxCb2dDQ2tTeFN3Y1ZGbGNHQWs4SVVDS3ZTVTRKU1U4SlVFa1ZJZ2tpV0VzQlR3bFFTUlVpQ1NKWVVFc0JTd2hRU1JVaUNTSllVRXNCVHdkUVNSVWlDU0pZVUVzQlN3WlFTUlVpQ1NKWVVFeExCRkJKRlNJSklsaFFJeWNKWlVTQkdGdUJCcklRSTdJWkk3SUJzaGlBQkhqMFEvZXlHa3l5R3JJYXM3UStWd1FBSTFORUpCYS9Nd0FJRkVRcnFFUWpKd1ZsUkVsTEFxZEVzWUVJcjBsT0FrNEVKeEtnU3dLaEp4S3FVRWtWZ1FnSld5U3lFRThDc2djanNnR3lDTE1ycFVFQUdMRkpTd1JRU1JXQkNBbGJKTElRU3dXeUJ5T3lBYklJczBzQ0lnNUVTd05MQXF0TEJrc0lVRXNHVUV4UWdBUzRPOHQ2VEZDd0pCWXFUR2NrUXpZYUFVa1ZJaEpFQVNjT1RGQytUQmNqVEU4Q1RTY0xJMDhDVkNoTVVMQWtRellhQVVrVkloSkVOaG9DU1JVaUVrUTJHZ05KRlNJU1JJZ0FUU2hNVUxBa1F6WWFBVWtWSWhKRWlBREJKd3NqVHdKVUtFeFFzQ1JESXE4akp3UmxSQlpRU1JVaUNTSllBU2NNVEZDK0tVNENUU2hNVUxBa1F6WWFBVWtWSWhKRWlBRGlLRXhRc0NSRGlnTUJpLzRuRUtSRWkvOG5FS1JFc1NLdlNZditVRWtWSWdraVdJdjlnUmhiZ1FheUVDT3lHU095QVVteUdDY1RzaHBNc2hvcHNocXp0RDVYQkNDMFBsY2tJRXlMLzZBbkVLcXhTd05NVUVrVklna2lXRXNEVHdKUVNSVWlDU0pZZ1FheUVDT3lHU095QVU4Q3NoZ25FN0lhVExJYXNocXp0RDVYQkNCUVNSVWlDU0pZaVlvQkFTdEppLzhycUVFQUJDT01BSWtqSndSbFRFbE9Bb3dBUkl3QklxK0xBUlpRU1JVaUNTSllBU2NNVEZDK0tVNENUWXYvRWtFQUJDU01BSW1MQVVBQUJJRWVqQUdMQVNRSlNZd0Jpd0FUUVAvS0k0d0FpWW9CQVl2L0s2aEJBQ09BSUMvbFRHRFRyS3Z6TkRvMXR1dWhYYlNDR3pRUGR1ZEI0aVNXaGUxSW1hOXNpWXYvZ0FFQnFFRUFJNEFnSldwaE5YZCs3aS9TYjFTNHR3TjZKVU9kVWpYSzdpSkJWQmh0SzRwUzR4MkppLzhuRDZoQkFDT0FJQkZSbEppVjZDcXhtU1Rla3NRS1BXOTd5MkRaS3dCUVM0R1pZVGFEOE1JQWlZdi9nQUVEcUVFQUk0QWdJQkllNkJGSW4valdId243aWVNVDhVbFpvUEtMdENpaURicHJDd2FMTzl1SmkvK0FBUVNvUVFBamdDQUtpY3B2K2hUTVJpeisyNFFzTU8waUdsQ2oxcjhDS21wWDNJS3JKTUZYeVltTC80QUJCYWhCQUNPQUlDVEtCY0sxelVMb2tOYStsTWFOQm9uMDhoeWM3SndQRS81QjFXYmZ0VWxaaVl2L2dBRUdxRUVBSTRBZ0hNdVh5VEpXV3BMR0FWYTl1aTBJODc4VGQwWk9BbHp1ZGxaNTVnU25NVnlKaS8rQUFRZW9RUUFqZ0NBWkZXKzlmUnFMOWN1b2tKTm4zaHRpUlRUcnEwOFBlZUFEdk0zUnNZSzl0SW1MLzRBQkNLaEJBQ09BSUNZYStNSHdrUzVHVjBSa0ZBbjJJdFJtdzVJS3h1WC9OK05tQk1zUjMvK0FpWXYvZ0FFSnFFRUFJNEFnQUZoRmx5VC9iS1doWlMvTHcrZ3JrNGxjOEk2WFd4bStxejlVd2hmUndBZUppLytBQVFxb1FRQWpnQ0FmQk84ZzN1U05PWmhOanF2bmFLY09yNll4Q3RJSVNkUlhQRHhBd3EwZU1JbUwvNEFCQzZoQkFDT0FJQnZxUGV4ZHExRldmT2ZpQUtNUGU2YlVKMnJxcFQ0bWh2bGlwR3htMVJIbGlZdi9nQUVNcUVFQUk0QWdEdUQ1UWVMYVM1NHh3OHFYcEEyUHFjNW8yWHdJUVhjSEd6eTBiTk0zTHcrSmkvK0FBUTJvUVFBamdDQWNxVkEraVRXSVJRRzdyeUMrRk90TVJyaVhjc2w3bHVPeTYvT2phcFNMdlltTC80QUJEcWhCQUNPQUlCTTZnT01HbDgxVjJQZlVzSlpiZStKQVY3cGR3OXFKanVJWWNqSkViTEVJaVl2L2dBRVBxRUVBSTRBZ0UrYlkvSWlEbnRkdUdDd3FkNXIxc3NEYW5kR01rRUo2WkU5K0ZJcGlVN2FKaS8rQUFSQ29RUUFqZ0NBZXNXc0Zla2QvUzhqMWN1cHI3amxXRUpqM2p4Vy9zMm1keTdlOWpiWVlWSW1MLzRBQkVhaEJBQ09BSUEyaXl4YWh6cXEvSEJhNE9QZXA0L0tqb3dpTm5ncHQ2NnAwZ1JSaUJwYnFpWXYvZ0FFU3FFRUFJNEFnSktPejJDSkNDeFMxMk10c0tLVjA4QjZZNnA2VUJWSFM2OWRjN2hKa241MkppLytBQVJPb1FRQWpnQ0FaaGlLc3ZYZzlHdzJRWkJCYkg4amsySWlkNlZ4TVVacy9ZMWdKL21yOEJZbUwvNEFCRktoQkFDT0FJQ25YN1RrU1ZzekQ2bGxzaHVrenVKL3pPZEplcU4zTzJYV3VMK01MVXBiVWlZdi9nQUVWcUVFQUk0QWdHYjVaOHZCQlBPZU1ERGNEbzZWRkd4MS9PV0tmb3pxOUVWU0tkZ1piS1dlSmkvK0FBUmFvUVFBamdDQWY4L1lYbCtVNHR3NWhreERUUHlvR1BuNjFrUVRoRXVsWE9Ob1NWTncwVTRtTC80QUJGNmhCQUNPQUlCREJhdW1WblBnMWlZRFozWllXNUlJb2MzTVFvUTRyYTNNY0dsU1BBMnhJaVl2L2dBRVlxRUVBSTRBZ0M2UXpwakYwcVFyQ0NaTG5YakNWU1dnU3RsSm9XMTRhTHE0TEcvVG8vTkdKaS8rQUFSbW9RUUFqZ0NBQm5kdWQ4cnlZMllmUTMreXAwclpEM3ErcmozQTJWaTVpZkRabkptb0VUSW1MLzRBQkdxaEJBQ09BSUMwOGlMSXhkY1dsVmwyNUtFRk1adEdSS3hHcytYU3k1a1RLcXNCSE9jNlppWXYvZ0FFYnFFRUFJNEFnTHF0VjlxNU9adU1zVVludTFjUndoQWhqUkZkZzllMStlMm15cGlZQTgxU0ppLytBQVJ5b1FRQWpnQ0FBTGZONkprSmlHQUk0UFBsU3YwM1I4eTRGUXp2dXNmMUJBeCszNnM2WG5ZbUwvNEFCSGFoQkFDT0FJQkJLNjBGRFhiWnNQbUwrek1IVzlkbU5DZzdYWFJOMDIwVjg5R0xqb2ZRbmlZdi9nQUVlcUVFQUk0QWdIenh2MkZqcHA5U3cwZk9PSldvSjJCMWFYanlXT1lmaTFMZ1V6NnQ4YnJ1SmkvK0FBUitvUklBZ0xIb0gwZzMvZWRBZjdPM0JFMEtFcU5DRU5tQnNrMms3WitNejluRy9hY3lKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb21taXRtZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVhZkluZGV4IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJXaXRoZHJhd2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibnVsbGlmaWVySGFzaCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlbGF5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
