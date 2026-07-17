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

namespace Arc56.Generated.Potti1234.PottiSwap.Escrow_a34e1865
{


    public class EscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EscrowInstance : AVMObjectType
            {
                public ulong CreatedTime { get; set; }

                public ulong RescueTime { get; set; }

                public ulong Amount { get; set; }

                public Algorand.Address Creator { get; set; }

                public Algorand.Address Taker { get; set; }

                public byte[] SecretHash { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedTime.From(CreatedTime);
                    ret.AddRange(vCreatedTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRescueTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRescueTime.From(RescueTime);
                    ret.AddRange(vRescueTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTaker = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTaker.From(Taker);
                    ret.AddRange(vTaker.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSecretHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSecretHash.From(SecretHash);
                    ret.AddRange(vSecretHash.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EscrowInstance Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EscrowInstance();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedTime = vCreatedTime.ToValue();
                    if (valueCreatedTime is ulong vCreatedTimeValue) { ret.CreatedTime = vCreatedTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRescueTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRescueTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRescueTime = vRescueTime.ToValue();
                    if (valueRescueTime is ulong vRescueTimeValue) { ret.RescueTime = vRescueTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTaker = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTaker.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTaker = vTaker.ToValue();
                    if (valueTaker is Algorand.Address vTakerValue) { ret.Taker = vTakerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSecretHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSecretHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSecretHash = vSecretHash.ToValue();
                    if (valueSecretHash is byte[] vSecretHashValue) { ret.SecretHash = vSecretHashValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EscrowInstance);
                }
                public bool Equals(EscrowInstance? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EscrowInstance left, EscrowInstance right)
                {
                    return EqualityComparer<EscrowInstance>.Default.Equals(left, right);
                }
                public static bool operator !=(EscrowInstance left, EscrowInstance right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="timelock">The number seconds from the current time after the Escrow can be returned to the creator </param>
        /// <param name="secretHash">Hash of the secret in keccak256 </param>
        /// <param name="taker">Creator of the escrow (Factory) can set taker address to the resolver address after it is know who won the auction </param>
        /// <param name="txnDeposit">The deposit transaction of the asset </param>
        public async Task<ulong> Create(PaymentTransaction txnDeposit, ulong timelock, byte[] secretHash, Algorand.Address taker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txnDeposit });
            byte[] abiHandle = { 222, 182, 240, 230 };
            var timelockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timelockAbi.From(timelock);
            var secretHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretHashAbi.From(secretHash);
            var takerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); takerAbi.From(taker);

            var result = await base.CallApp(new List<object> { abiHandle, timelockAbi, secretHashAbi, takerAbi, txnDeposit }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Create_Transactions(PaymentTransaction txnDeposit, ulong timelock, byte[] secretHash, Algorand.Address taker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { txnDeposit });
            byte[] abiHandle = { 222, 182, 240, 230 };
            var timelockAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timelockAbi.From(timelock);
            var secretHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretHashAbi.From(secretHash);
            var takerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); takerAbi.From(taker);

            return await base.MakeTransactionList(new List<object> { abiHandle, timelockAbi, secretHashAbi, takerAbi, txnDeposit }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw from escrow with known secret
        ///</summary>
        /// <param name="secret">Secret </param>
        /// <param name="escrowId"> </param>
        public async Task Withdraw(byte[] secret, ulong escrowId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 219, 165, 74 };
            var secretAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretAbi.From(secret);
            var escrowIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowIdAbi.From(escrowId);

            var result = await base.CallApp(new List<object> { abiHandle, secretAbi, escrowIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(byte[] secret, ulong escrowId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 219, 165, 74 };
            var secretAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretAbi.From(secret);
            var escrowIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowIdAbi.From(escrowId);

            return await base.MakeTransactionList(new List<object> { abiHandle, secretAbi, escrowIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///After timelock runs out refund to original sender
        ///</summary>
        /// <param name="escrowId"> </param>
        public async Task Cancel(ulong escrowId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 43, 57, 186 };
            var escrowIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowIdAbi.From(escrowId);

            var result = await base.CallApp(new List<object> { abiHandle, escrowIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Cancel_Transactions(ulong escrowId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 43, 57, 186 };
            var escrowIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowIdAbi.From(escrowId);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrowIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return hash of the secret.
        ///</summary>
        /// <param name="secret">The secret </param>
        public async Task<byte[]> MakeHash(byte[] secret, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 225, 61, 225 };
            var secretAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretAbi.From(secret);

            var result = await base.SimApp(new List<object> { abiHandle, secretAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> MakeHash_Transactions(byte[] secret, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 225, 61, 225 };
            var secretAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); secretAbi.From(secret);

            return await base.MakeTransactionList(new List<object> { abiHandle, secretAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current time
        ///</summary>
        public async Task<ulong> LatestTimestamp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 204, 217, 48 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LatestTimestamp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 204, 217, 48 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkVzY3Jvd0luc3RhbmNlIjpbeyJuYW1lIjoiY3JlYXRlZFRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVzY3VlVGltZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3JlYXRvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidGFrZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InNlY3JldEhhc2giLCJ0eXBlIjoiYnl0ZVszMl0ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVsb2NrIiwiZGVzYyI6IlRoZSBudW1iZXIgc2Vjb25kcyBmcm9tIHRoZSBjdXJyZW50IHRpbWUgYWZ0ZXIgdGhlIEVzY3JvdyBjYW4gYmUgcmV0dXJuZWQgdG8gdGhlIGNyZWF0b3IiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VjcmV0SGFzaCIsImRlc2MiOiJIYXNoIG9mIHRoZSBzZWNyZXQgaW4ga2VjY2FrMjU2IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFrZXIiLCJkZXNjIjoiQ3JlYXRvciBvZiB0aGUgZXNjcm93IChGYWN0b3J5KSBjYW4gc2V0IHRha2VyIGFkZHJlc3MgdG8gdGhlIHJlc29sdmVyIGFkZHJlc3MgYWZ0ZXIgaXQgaXMga25vdyB3aG8gd29uIHRoZSBhdWN0aW9uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eG5EZXBvc2l0IiwiZGVzYyI6IlRoZSBkZXBvc2l0IHRyYW5zYWN0aW9uIG9mIHRoZSBhc3NldCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3IiwiZGVzYyI6IldpdGhkcmF3IGZyb20gZXNjcm93IHdpdGgga25vd24gc2VjcmV0IiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VjcmV0IiwiZGVzYyI6IlNlY3JldCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsIiwiZGVzYyI6IkFmdGVyIHRpbWVsb2NrIHJ1bnMgb3V0IHJlZnVuZCB0byBvcmlnaW5hbCBzZW5kZXIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFrZUhhc2giLCJkZXNjIjoiUmV0dXJuIGhhc2ggb2YgdGhlIHNlY3JldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWNyZXQiLCJkZXNjIjoiVGhlIHNlY3JldCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJIYXNoIG9mIHRoZSBzZWNyZXQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxhdGVzdFRpbWVzdGFtcCIsImRlc2MiOiJHZXQgY3VycmVudCB0aW1lIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IkN1cnJlbnQgdGltZSBvZiB0aGUgYmxvY2tjaGFpbiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMTEsMzU4XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMl0sImVycm9yTWVzc2FnZSI6IkVzY3JvdyBjYW4gYmUgcmVkZWVtZWQgd2l0aCBwYXNzd29yZCB1cCB0byB0aGUgcmVzY3VlIHRpbWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTksMzM3LDM3Ml0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyLDEyOSwxNTYsMTcyLDE5MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2N10sImVycm9yTWVzc2FnZSI6IlRoZSBlc2Nyb3cgY2Fubm90IGJlIGNhbmNlbGVkIHlldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyM10sImVycm9yTWVzc2FnZSI6IlRoZSBwYXNzd29yZCBpcyBub3QgY29ycmVjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNSwxMzIsMTU5LDE3NSwxOTRdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc3LDI4NywyOTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNVFlLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbVZ6WTNKdmQwbHVjM1JoYm1ObGMwRnRiM1Z1ZENJZ01IZ3hOVEZtTjJNM05TQWlaWE5qY205M1NXNXpkR0Z1WTJWeklnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdWelkzSnZkMGx1YzNSaGJtTmxjMEZ0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGMyTnliM2RKYm5OMFlXNWpaWE5CYlc5MWJuUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVZ6WTNKdmR5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1JsWWpabU1HVTJJREI0WVRka1ltRTFOR0VnTUhnM056SmlNemxpWVNBd2VHUmxaVEV6WkdVeElEQjROalJqWTJRNU16QWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9kV2x1ZERZMExHSjVkR1ZiTXpKZExHRmtaSEpsYzNNc2NHRjVLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYY29ZbmwwWlZzek1sMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1OaGJtTmxiQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWJXRnJaVWhoYzJnb1lubDBaVnN6TWwwcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKc1lYUmxjM1JVYVcxbGMzUmhiWEFvS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgzSnZkWFJsUURVZ2JXRnBibDkzYVhSb1pISmhkMTl5YjNWMFpVQTJJRzFoYVc1ZlkyRnVZMlZzWDNKdmRYUmxRRGNnYldGcGJsOXRZV3RsU0dGemFGOXliM1YwWlVBNElHMWhhVzVmYkdGMFpYTjBWR2x0WlhOMFlXMXdYM0p2ZFhSbFFEa0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJGYzJOeWIzY2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyeGhkR1Z6ZEZScGJXVnpkR0Z0Y0Y5eWIzVjBaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdiR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDIxaGEyVklZWE5vWDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVZ6WTNKdmR5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1kyRnNiSE4xWWlCdFlXdGxTR0Z6YUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZ1WTJWc1gzSnZkWFJsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhOamNtOTNJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1kyRnVZMlZzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM2RwZEdoa2NtRjNYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1JYTmpjbTkzSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdkMmwwYUdSeVlYY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkzSmxZWFJsWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSWE5qY205M0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhSFJzWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVnpZM0p2ZHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M0xtTnlaV0YwWlNoMGFXMWxiRzlqYXpvZ2RXbHVkRFkwTENCelpXTnlaWFJJWVhOb09pQmllWFJsY3l3Z2RHRnJaWEk2SUdKNWRHVnpMQ0IwZUc1RVpYQnZjMmwwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9DMHpPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1VvZEdsdFpXeHZZMnM2SUhWcGJuUTJOQ3dnYzJWamNtVjBTR0Z6YURvZ1lYSmpOQzVUZEdGMGFXTkNlWFJsY3p3ek1qNHNJSFJoYTJWeU9pQkJaR1J5WlhOekxDQjBlRzVFWlhCdmMybDBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIxYVc1ME5qUWdld29nSUNBZ2NISnZkRzhnTkNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QmpjbVZoZEdWa1ZHbHRaVG9nYm1WM0lGVnBiblJPTmpRb2RHaHBjeTVzWVhSbGMzUlVhVzFsYzNSaGJYQW9LU2tzQ2lBZ0lDQmpZV3hzYzNWaUlHeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2NtVnpZM1ZsVkdsdFpUb2dibVYzSUZWcGJuUk9OalFvUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDQXJJSFJwYldWc2IyTnJLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdZVzF2ZFc1ME9pQnVaWGNnVldsdWRFNDJOQ2gwZUc1RVpYQnZjMmwwTG1GdGIzVnVkQ2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnWTNKbFlYUnZjam9nYm1WM0lFRmtaSEpsYzNNb2RIaHVSR1Z3YjNOcGRDNXpaVzVrWlhJcExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQXRORGNLSUNBZ0lDOHZJR052Ym5OMElHNWxkMFZ6WTNKdmQwbHVjM1JoYm1ObElEMGdibVYzSUVWelkzSnZkMGx1YzNSaGJtTmxLSHNLSUNBZ0lDOHZJQ0FnWTNKbFlYUmxaRlJwYldVNklHNWxkeUJWYVc1MFRqWTBLSFJvYVhNdWJHRjBaWE4wVkdsdFpYTjBZVzF3S0NrcExBb2dJQ0FnTHk4Z0lDQnlaWE5qZFdWVWFXMWxPaUJ1WlhjZ1ZXbHVkRTQyTkNoSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJQ3NnZEdsdFpXeHZZMnNwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUc1bGR5QlZhVzUwVGpZMEtIUjRia1JsY0c5emFYUXVZVzF2ZFc1MEtTd0tJQ0FnSUM4dklDQWdZM0psWVhSdmNqb2dibVYzSUVGa1pISmxjM01vZEhodVJHVndiM05wZEM1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNCMFlXdGxjam9nZEdGclpYSXNDaUFnSUNBdkx5QWdJSE5sWTNKbGRFaGhjMmc2SUhObFkzSmxkRWhoYzJnc0NpQWdJQ0F2THlCOUtUc0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdWelkzSnZkMGx1YzNSaGJtTmxjMEZ0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnZlNrN0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhOamNtOTNTVzV6ZEdGdVkyVnpRVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklIUm9hWE11WlhOamNtOTNTVzV6ZEdGdVkyVnpLSFJvYVhNdVpYTmpjbTkzU1c1emRHRnVZMlZ6UVcxdmRXNTBMblpoYkhWbEtTNTJZV3gxWlNBOUlHNWxkMFZ6WTNKdmQwbHVjM1JoYm1ObExtTnZjSGtvS1RzS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklIQjFZbXhwWXlCbGMyTnliM2RKYm5OMFlXNWpaWE1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JGYzJOeWIzZEpibk4wWVc1alpUNG9leUJyWlhsUWNtVm1hWGc2SUNKbGMyTnliM2RKYm5OMFlXNWpaWE1pSUgwcE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVpYTmpjbTkzU1c1emRHRnVZMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QjBhR2x6TG1WelkzSnZkMGx1YzNSaGJtTmxjeWgwYUdsekxtVnpZM0p2ZDBsdWMzUmhibU5sYzBGdGIzVnVkQzUyWVd4MVpTa3VkbUZzZFdVZ1BTQnVaWGRGYzJOeWIzZEpibk4wWVc1alpTNWpiM0I1S0NrN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaWE5qY205M1NXNXpkR0Z1WTJWelFXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLVHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxjMk55YjNkSmJuTjBZVzVqWlhOQmJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnZEdocGN5NWxjMk55YjNkSmJuTjBZVzVqWlhOQmJXOTFiblF1ZG1Gc2RXVXJLenNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QndkV0pzYVdNZ1pYTmpjbTkzU1c1emRHRnVZMlZ6UVcxdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTUNCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVnpZM0p2ZDBsdWMzUmhibU5sYzBGdGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhSb2FYTXVaWE5qY205M1NXNXpkR0Z1WTJWelFXMXZkVzUwTG5aaGJIVmxLeXM3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdWelkzSnZkMGx1YzNSaGJtTmxjMEZ0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnZlNrN0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhOamNtOTNTVzV6ZEdGdVkyVnpRVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbVZ6WTNKdmQwbHVjM1JoYm1ObGMwRnRiM1Z1ZEM1MllXeDFaU0F0SURFN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhOamNtOTNMbmRwZEdoa2NtRjNLSE5sWTNKbGREb2dZbmwwWlhNc0lHVnpZM0p2ZDBsa09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUzAyTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QjNhWFJvWkhKaGR5aHpaV055WlhRNklHRnlZelF1VTNSaGRHbGpRbmwwWlhNOE16SStMQ0JsYzJOeWIzZEpaRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR052Ym5OMElHVnpZM0p2ZDBsdWMzUmhibU5sSUQwZ2RHaHBjeTVsYzJOeWIzZEpibk4wWVc1alpYTW9aWE5qY205M1NXUXBMblpoYkhWbExtTnZjSGtvS1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2NIVmliR2xqSUdWelkzSnZkMGx1YzNSaGJtTmxjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRVZ6WTNKdmQwbHVjM1JoYm1ObFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1WelkzSnZkMGx1YzNSaGJtTmxjeUlnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbGMyTnliM2RKYm5OMFlXNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklHTnZibk4wSUdWelkzSnZkMGx1YzNSaGJtTmxJRDBnZEdocGN5NWxjMk55YjNkSmJuTjBZVzVqWlhNb1pYTmpjbTkzU1dRcExuWmhiSFZsTG1OdmNIa29LVHNLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtMWhhMlZJWVhOb0tITmxZM0psZENrZ1BUMDlJR1Z6WTNKdmQwbHVjM1JoYm1ObExuTmxZM0psZEVoaGMyZ3VibUYwYVhabExDQWlWR2hsSUhCaGMzTjNiM0prSUdseklHNXZkQ0JqYjNKeVpXTjBJaWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ2JXRnJaVWhoYzJnS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRGc0SURNeUlDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlVhR1VnY0dGemMzZHZjbVFnYVhNZ2JtOTBJR052Y25KbFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b2RHeGpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG14aGRHVnpkRlJwYldWemRHRnRjQ2dwSUR3Z1pYTmpjbTkzU1c1emRHRnVZMlV1Y21WelkzVmxWR2x0WlM1dVlYUnBkbVVzSUNKRmMyTnliM2NnWTJGdUlHSmxJSEpsWkdWbGJXVmtJSGRwZEdnZ2NHRnpjM2R2Y21RZ2RYQWdkRzhnZEdobElISmxjMk4xWlNCMGFXMWxJaWs3Q2lBZ0lDQmpZV3hzYzNWaUlHeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFVnpZM0p2ZHlCallXNGdZbVVnY21Wa1pXVnRaV1FnZDJsMGFDQndZWE56ZDI5eVpDQjFjQ0IwYnlCMGFHVWdjbVZ6WTNWbElIUnBiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUhSb2FYTXVaWE5qY205M1NXNXpkR0Z1WTJWektHVnpZM0p2ZDBsa0tTNWtaV3hsZEdVb0tUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnZEdocGN5NWZjMlZ1WkNobGMyTnliM2RKYm5OMFlXNWpaUzUwWVd0bGNpd2daWE5qY205M1NXNXpkR0Z1WTJVdVlXMXZkVzUwTG01aGRHbDJaU2s3Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05UWWdNeklnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCallXeHNjM1ZpSUY5elpXNWtDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGYzJOeWIzY3VZMkZ1WTJWc0tHVnpZM0p2ZDBsa09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtTmhibU5sYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56a3RPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1kyRnVZMlZzS0dWelkzSnZkMGxrT2lCMWFXNTBOalFwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnWTI5dWMzUWdaWE5qY205M1NXNXpkR0Z1WTJVZ1BTQjBhR2x6TG1WelkzSnZkMGx1YzNSaGJtTmxjeWhsYzJOeWIzZEpaQ2t1ZG1Gc2RXVXVZMjl3ZVNncE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QndkV0pzYVdNZ1pYTmpjbTkzU1c1emRHRnVZMlZ6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnUlhOamNtOTNTVzV6ZEdGdVkyVStLSHNnYTJWNVVISmxabWw0T2lBaVpYTmpjbTkzU1c1emRHRnVZMlZ6SWlCOUtUc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltVnpZM0p2ZDBsdWMzUmhibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoMGJHTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdZMjl1YzNRZ1pYTmpjbTkzU1c1emRHRnVZMlVnUFNCMGFHbHpMbVZ6WTNKdmQwbHVjM1JoYm1ObGN5aGxjMk55YjNkSlpDa3VkbUZzZFdVdVkyOXdlU2dwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmgwYkdNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXViR0YwWlhOMFZHbHRaWE4wWVcxd0tDa2dQaUJsYzJOeWIzZEpibk4wWVc1alpTNXlaWE5qZFdWVWFXMWxMbTVoZEdsMlpTd2dJbFJvWlNCbGMyTnliM2NnWTJGdWJtOTBJR0psSUdOaGJtTmxiR1ZrSUhsbGRDSXBPd29nSUNBZ1kyRnNiSE4xWWlCc1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCVWFHVWdaWE5qY205M0lHTmhibTV2ZENCaVpTQmpZVzVqWld4bFpDQjVaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUhSb2FYTXVaWE5qY205M1NXNXpkR0Z1WTJWektHVnpZM0p2ZDBsa0tTNWtaV3hsZEdVb0tUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnZEdocGN5NWZjMlZ1WkNobGMyTnliM2RKYm5OMFlXNWpaUzVqY21WaGRHOXlMQ0JsYzJOeWIzZEpibk4wWVc1alpTNWhiVzkxYm5RdWJtRjBhWFpsS1RzS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXlOQ0F6TWlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHTmhiR3h6ZFdJZ1gzTmxibVFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkeTVmYzJWdVpDaHlaV05sYVhabGNqb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwZmMyVnVaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RRS0lDQWdJQzh2SUhCeWFYWmhkR1VnWDNObGJtUW9jbVZqWldsMlpYSTZJRUZrWkhKbGMzTXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVdE1UQXhDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SUVkc2IySmhiQzV0YVc1VWVHNUdaV1VzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklISmxZMlZwZG1WeUxtSjVkR1Z6TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5Qm1aV1U2SUVkc2IySmhiQzV0YVc1VWVHNUdaV1VzQ2lBZ0lDQm5iRzlpWVd3Z1RXbHVWSGh1Um1WbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvZEd4akwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UVXRNVEF3Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklFZHNiMkpoYkM1dGFXNVVlRzVHWldVc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJSEpsWTJWcGRtVnlMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazFMVEV3TVFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQkhiRzlpWVd3dWJXbHVWSGh1Um1WbExBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJ5WldObGFYWmxjaTVpZVhSbGN5d0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwT3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9kR3hqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tWelkzSnZkeTV0WVd0bFNHRnphQ2h6WldOeVpYUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tiV0ZyWlVoaGMyZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFIUnNZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TUMweE1URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0F2THlCd2RXSnNhV01nYldGclpVaGhjMmdvYzJWamNtVjBPaUJoY21NMExsTjBZWFJwWTBKNWRHVnpQRE15UGlrNklHSjVkR1Z6SUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaDBiR012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRJS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1clpXTmpZV3N5TlRZb2MyVmpjbVYwTG1KNWRHVnpLVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZjMk55YjNjdWJHRjBaWE4wVkdsdFpYTjBZVzF3S0NrZ0xUNGdkV2x1ZERZME9ncHNZWFJsYzNSVWFXMWxjM1JoYlhBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUhSc1l5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNUW9nSUNBZ0x5OGdjbVYwZFhKdUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEE3Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQUlFQ1lERldWelkzSnZkMGx1YzNSaGJtTmxjMEZ0YjNWdWRBUVZIM3gxRDJWelkzSnZkMGx1YzNSaGJtTmxjekVZUUFBREtDTm5NUnRCQUtDQ0JRVGV0dkRtQktmYnBVb0VkeXM1dWdUZTRUM2hCR1RNMlRBMkdnQ09CUUJSQUQ0QUxnQVRBQUlqUXpFWkZFUXhHRVNJQVNNV0tVeFFzQ0pETVJrVVJERVlSRFlhQVlnQkNFa1ZGbGNHQWt4UUtVeFFzQ0pETVJrVVJERVlSRFlhQVJlSUFMUWlRekVaRkVReEdFUTJHZ0UyR2dJWGlBQnlJa014R1JSRU1SaEVOaG9CRnpZYUFqWWFBekVXSWdsSk9CQWlFa1NJQUJJV0tVeFFzQ0pETVJsQS80VXhHQlJFSWtPS0JBR0lBS2dXTWdlTC9BZ1dpLzg0Q0JhTC96Z0FUd05QQTFCUEFsQk1VSXYrVUl2OVVDTW9aVVFXS2t4UVRMOGpLR1ZFSWdnb1RHY2pLR1ZFSWdtSmlnSUFpLzhXS2t4UVNiNUVpLzZJQUZaTEFWZFlJQkpFaUFCVFN3RWtXd3hFVEx4SVNWYzRJRXdsVzRnQUpJbUtBUUNML3hZcVRGQkp2a1NJQURCTEFTUmJEVVJNdkVoSlZ4Z2dUQ1ZiaUFBQmlZb0NBTEV5QUl2K3NnZUwvN0lJSXJJUXNnR3ppWW9CQVl2L0Fva3lCNGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
