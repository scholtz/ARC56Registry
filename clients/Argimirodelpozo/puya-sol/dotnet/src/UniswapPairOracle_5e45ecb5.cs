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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.UniswapPairOracle_5e45ecb5
{


    public class UniswapPairOracleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public UniswapPairOracleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Uq112X112 : AVMObjectType
            {
                public System.Numerics.BigInteger X { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint224");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Uq112X112 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Uq112X112();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint224");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is System.Numerics.BigInteger vXValue) { ret.X = vXValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Uq112X112);
                }
                public bool Equals(Uq112X112? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Uq112X112 left, Uq112X112 right)
                {
                    return EqualityComparer<Uq112X112>.Default.Equals(left, right);
                }
                public static bool operator !=(Uq112X112 left, Uq112X112 right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class OwnerNominatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 195, 190, 123, 58 };
                public const string Signature = "OwnerNominated(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] NewOwner { get; set; }

                public static OwnerNominatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnerNominatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

            public class OwnerChangedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 99, 218, 219, 229 };
                public const string Signature = "OwnerChanged(uint8[32],uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] OldOwner { get; set; }
                public byte[] NewOwner { get; set; }

                public static OwnerChangedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OwnerChangedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOldOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOldOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOldOwner = vOldOwner.ToValue();
                    if (valueOldOwner is byte[] vOldOwnerValue) { ret.OldOwner = vOldOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNewOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vNewOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNewOwner = vNewOwner.ToValue();
                    if (valueNewOwner is byte[] vNewOwnerValue) { ret.NewOwner = vNewOwnerValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_timelock_address"> </param>
        public async Task SetTimelock(Algorand.Address _timelock_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 251, 176, 139 };
            var _timelock_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _timelock_addressAbi.From(_timelock_address);

            var result = await base.CallApp(new List<object> { abiHandle, _timelock_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTimelock_Transactions(Algorand.Address _timelock_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 251, 176, 139 };
            var _timelock_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _timelock_addressAbi.From(_timelock_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, _timelock_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_period"> </param>
        public async Task SetPeriod(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _period, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 18, 75, 249 };

            var result = await base.CallApp(new List<object> { abiHandle, _period }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPeriod_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _period, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 18, 75, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _period }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_consult_leniency"> </param>
        public async Task SetConsultLeniency(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _consult_leniency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 9, 159, 109 };

            var result = await base.CallApp(new List<object> { abiHandle, _consult_leniency }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetConsultLeniency_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 _consult_leniency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 9, 159, 109 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _consult_leniency }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_allow_stale_consults"> </param>
        public async Task SetAllowStaleConsults(bool _allow_stale_consults, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 2, 251, 65 };
            var _allow_stale_consultsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); _allow_stale_consultsAbi.From(_allow_stale_consults);

            var result = await base.CallApp(new List<object> { abiHandle, _allow_stale_consultsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAllowStaleConsults_Transactions(bool _allow_stale_consults, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 2, 251, 65 };
            var _allow_stale_consultsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); _allow_stale_consultsAbi.From(_allow_stale_consults);

            return await base.MakeTransactionList(new List<object> { abiHandle, _allow_stale_consultsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> CanUpdate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 209, 141, 82 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CanUpdate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 209, 141, 82 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="token"> </param>
        /// <param name="__arc4_amountIn"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Consult(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amountIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 49, 252, 181 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);

            var result = await base.SimApp(new List<object> { abiHandle, tokenAbi, __arc4_amountIn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Consult_Transactions(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_amountIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 49, 252, 181 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, __arc4_amountIn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Period(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 205, 186, 101 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Period_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 205, 186, 101 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ConsultLeniency(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 93, 226, 210 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ConsultLeniency_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 93, 226, 210 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> AllowStaleConsults(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 147, 115, 47 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AllowStaleConsults_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 147, 115, 47 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Pair(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 23, 89, 165 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Pair_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 23, 89, 165 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Token0(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 24, 69, 227 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Token0_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 24, 69, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Token1(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 12, 148, 153 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Token1_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 12, 148, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Price0CumulativeLast(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 232, 194, 162 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Price0CumulativeLast_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 232, 194, 162 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Price1CumulativeLast(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 122, 86, 129 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Price1CumulativeLast_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 122, 86, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> BlockTimestampLast(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 167, 49, 97 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BlockTimestampLast_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 167, 49, 97 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<System.Numerics.BigInteger> Price0Average(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 207, 163, 14 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value;

        }

        public async Task<List<Transaction>> Price0Average_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 207, 163, 14 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<System.Numerics.BigInteger> Price1Average(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 45, 96, 78 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value;

        }

        public async Task<List<Transaction>> Price1Average_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 45, 96, 78 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Owner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Owner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 187, 176, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> NominatedOwner(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 47, 53, 92 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> NominatedOwner_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 47, 53, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_owner"> </param>
        public async Task NominateNewOwner(Algorand.Address _owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 211, 161, 3 };
            var _ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _ownerAbi.From(_owner);

            var result = await base.CallApp(new List<object> { abiHandle, _ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NominateNewOwner_Transactions(Algorand.Address _owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 211, 161, 3 };
            var _ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _ownerAbi.From(_owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, _ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task AcceptOwnership(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 33, 214, 4 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AcceptOwnership_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 33, 214, 4 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVW5pc3dhcFBhaXJPcmFjbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsidXExMTJ4MTEyIjpbeyJuYW1lIjoiX3giLCJ0eXBlIjoidWludDIyNCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRUaW1lbG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3RpbWVsb2NrX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UGVyaW9kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcGVyaW9kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldENvbnN1bHRMZW5pZW5jeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2NvbnN1bHRfbGVuaWVuY3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QWxsb3dTdGFsZUNvbnN1bHRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYWxsb3dfc3RhbGVfY29uc3VsdHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuVXBkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnN1bHQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Ftb3VudEluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUEVSSU9EIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQ09OU1VMVF9MRU5JRU5DWSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkFMTE9XX1NUQUxFX0NPTlNVTFRTIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGFpciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRva2VuMCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRva2VuMSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByaWNlMEN1bXVsYXRpdmVMYXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJpY2UxQ3VtdWxhdGl2ZUxhc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJibG9ja1RpbWVzdGFtcExhc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByaWNlMEF2ZXJhZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDIyNCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcmljZTFBdmVyYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyMjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZWRPd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5vbWluYXRlTmV3T3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9vd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJOb21pbmF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRPd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxMn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTU3Ml0sImVycm9yTWVzc2FnZSI6IkFCSSBib29sIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODVdLCJlcnJvck1lc3NhZ2UiOiJGaXhlZFBvaW50OiBESVZfQllfWkVSTyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2MF0sImVycm9yTWVzc2FnZSI6IkZpeGVkUG9pbnQ6IE1VTFRJUExJQ0FUSU9OX09WRVJGTE9XIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQwMl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNvbnRyYWN0IG93bmVyIG1heSBwZXJmb3JtIHRoaXMgYWN0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQwXSwiZXJyb3JNZXNzYWdlIjoiT3duZXIgYWRkcmVzcyBjYW5ub3QgYmUgMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MjZdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwUGFpck9yYWNsZTogSU5WQUxJRF9UT0tFTiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1N10sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBQYWlyT3JhY2xlOiBOT19SRVNFUlZFUyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MDhdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwUGFpck9yYWNsZTogUEVSSU9EX05PVF9FTEFQU0VEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3OV0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBQYWlyT3JhY2xlOiBQUklDRV9JU19TVEFMRV9ORUVEX1RPX0NBTExfVVBEQVRFIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1MF0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMkxpYnJhcnk6IElERU5USUNBTF9BRERSRVNTRVMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDc0XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyTGlicmFyeTogWkVST19BRERSRVNTIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM5MCwxNDQ4LDE1MDcsMTU2N10sImVycm9yTWVzc2FnZSI6IllvdSBhcmUgbm90IGFuIG93bmVyIG9yIHRoZSBnb3Zlcm5hbmNlIHRpbWVsb2NrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ1MF0sImVycm9yTWVzc2FnZSI6IllvdSBtdXN0IGJlIG5vbWluYXRlZCBiZWZvcmUgeW91IGNhbiBhY2NlcHQgb3duZXJzaGlwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3NCwyMDQwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQUxMT1dfU1RBTEVfQ09OU1VMVFMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2NCwyMDA0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQ09OU1VMVF9MRU5JRU5DWSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjE5LDE3MDQsMTg1OSwxOTY4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgUEVSSU9EIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MDcsMTY4OSwxODQ3LDIyMzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBibG9ja1RpbWVzdGFtcExhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM2MywyNDQ1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbm9taW5hdGVkT3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3NCwxNDMyLDE0OTEsMTU1MSwyMzM1LDI0MDAsMjQ1NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIG93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NTUsMTY2NSwxNjc3LDIwNzVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwYWlyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OTUsMjI2MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHByaWNlMEF2ZXJhZ2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxMywyMTU5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcHJpY2UwQ3VtdWxhdGl2ZUxhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkzMSwyMjk4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcHJpY2UxQXZlcmFnZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzU3LDIxOTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwcmljZTFDdW11bGF0aXZlTGFzdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzg0LDE0NDIsMTUwMSwxNTYxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdGltZWxvY2tfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODg0LDIxMDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0b2tlbjAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkyMiwyMTMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdG9rZW4xIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1NSwxODE4LDIzODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDEzLDE0NzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2OCwxNDI2LDE0ODUsMTU0NSwxNTk5LDE2NTAsMTgzOSwxOTYzLDE5OTksMjAzNSwyMDcwLDIwOTgsMjEyNiwyMTU0LDIxOTAsMjIyNiwyMjU1LDIyOTMsMjMzMSwyMzU4LDIzOTQsMjQzOF0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTY3LDEwMDIsMTI5NywxNjEzLDE2OTgsMTc0MSwxNzg1LDE4NTMsMTkwOCwxOTczLDIwMDksMjE2NCwyMjAwLDIyNjYsMjMwNF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxOSwxNzYzXSwiZXJyb3JNZXNzYWdlIjoidW5kZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMVZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMbk52YkM1VmJtbHpkMkZ3VUdGcGNrOXlZV05zWlM1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREFnTVNBek1pQTJJRFF5T1RRNU5qY3lPVFVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpYjNkdVpYSWlJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBaWRHbHRaV3h2WTJ0ZllXUmtjbVZ6Y3lJZ0ltSnNiMk5yVkdsdFpYTjBZVzF3VEdGemRDSWdJbEJGVWtsUFJDSWdJbkJoYVhJaUlDSnViMjFwYm1GMFpXUlBkMjVsY2lJZ0luQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBJaUFpY0hKcFkyVXhRM1Z0ZFd4aGRHbDJaVXhoYzNRaUlEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SUNKRFQwNVRWVXhVWDB4RlRrbEZUa05aSWlBaVFVeE1UMWRmVTFSQlRFVmZRMDlPVTFWTVZGTWlJQ0owYjJ0bGJqQWlJQ0owYjJ0bGJqRWlJQ0p3Y21salpUQkJkbVZ5WVdkbElpQWljSEpwWTJVeFFYWmxjbUZuWlNJZ01IZzBZbVU0WXpKaE1pQXdlRGt3TjJFMU5qZ3hJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZzJNekU0TkRWbE15QXdlR0UxTUdNNU5EazVJREI0TVRRME16STJPVE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lEQjRNREV3TURBd01EQXdNQ0F3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUXdPVFlLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lITjBiM0psSURVS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUd4dllXUWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCaWRYSjVJRFlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWW5sMFpXTmZNaUF2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdWIyMXBibUYwWldSUGQyNWxjaUlLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkR2x0Wld4dlkydGZZV1JrY21WemN5SUtJQ0FnSUdKNWRHVmpYeklnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHbHVkQ0F6TmpBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKUVJWSkpUMFFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdsdWRDQXhNakFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pEVDA1VFZVeFVYMHhGVGtsRlRrTlpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0pCVEV4UFYxOVRWRUZNUlY5RFQwNVRWVXhVVXlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpY0dGcGNpSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0luUnZhMlZ1TUNJS0lDQWdJR0o1ZEdWalh6SWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW5SdmEyVnVNU0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nT0NBdkx5QWljSEpwWTJVd1EzVnRkV3hoZEdsMlpVeGhjM1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p3Y21salpURkRkVzExYkdGMGFYWmxUR0Z6ZENJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Kc2IyTnJWR2x0WlhOMFlXMXdUR0Z6ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5CeWFXTmxNRUYyWlhKaFoyVWlDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UWWdMeThnSW5CeWFXTmxNVUYyWlhKaFoyVWlDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBkMjVsY2lCaFpHUnlaWE56SUdOaGJtNXZkQ0JpWlNBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpOa1lXUmlaVFV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdZMkZzYkhOMVlpQlZibWx6ZDJGd1ZqSk1hV0p5WVhKNUxuQmhhWEpHYjNJS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5CaGFYSWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QnRaWFJvYjJRZ0luUnZhMlZ1TUNncFlXUmtjbVZ6Y3lJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW5SdmEyVnVNQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeU1TQXZMeUJ0WlhSb2IyUWdJblJ2YTJWdU1TZ3BZV1JrY21WemN5SUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0luUnZhMlZ1TVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXhOeUF2THlCdFpYUm9iMlFnSW5CeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOMEtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKd2NtbGpaVEJEZFcxMWJHRjBhWFpsVEdGemRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QnRaWFJvYjJRZ0luQnlhV05sTVVOMWJYVnNZWFJwZG1WTVlYTjBLQ2wxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSndjbWxqWlRGRGRXMTFiR0YwYVhabFRHRnpkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01qSWdMeThnYldWMGFHOWtJQ0puWlhSU1pYTmxjblpsY3lncEtIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJSEIxYzJocGJuUWdOamdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppYkc5amExUnBiV1Z6ZEdGdGNFeGhjM1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElETTJJRE15Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJRE15Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2diV0ZwYmw5aWIyOXNYMlpoYkhObFFEa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUcxaGFXNWZZbTl2YkY5bVlXeHpaVUE1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYldGcGJsOWliMjlzWDIxbGNtZGxRREV3T2dvZ0lDQWdZWE56WlhKMElDOHZJRlZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxPaUJPVDE5U1JWTkZVbFpGVXdvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpYjI5c1gyWmhiSE5sUURrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgySnZiMnhmYldWeVoyVkFNVEFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHRmhabUppTURoaUlEQjRaREV4TWpSaVpqa2dNSGc0WlRBNU9XWTJaQ0F3ZURsa01ESm1ZalF4SURCNE4yVmtNVGhrTlRJZ01IaGhNR1U0TVRnM01pQXdlREprTXpGbVkySTFJREI0TnpoalpHSmhOalVnTUhnMk5UVmtaVEprTWlBd2VHTmxPVE0zTXpKbUlEQjRPVFF4TnpVNVlUVWdMeThnYldWMGFHOWtJQ0p6WlhSVWFXMWxiRzlqYXloaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZCbGNtbHZaQ2gxYVc1ME5URXlLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRU52Ym5OMWJIUk1aVzVwWlc1amVTaDFhVzUwTlRFeUtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFRnNiRzkzVTNSaGJHVkRiMjV6ZFd4MGN5aGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5oYmxWd1pHRjBaU2dwWW05dmJDSXNJRzFsZEdodlpDQWlkWEJrWVhSbEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamIyNXpkV3gwS0dGa1pISmxjM01zZFdsdWRESTFOaWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0pRUlZKSlQwUW9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJa05QVGxOVlRGUmZURVZPU1VWT1Exa29LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJa0ZNVEU5WFgxTlVRVXhGWDBOUFRsTlZURlJUS0NsaWIyOXNJaXdnYldWMGFHOWtJQ0p3WVdseUtDbGhaR1J5WlhOeklnb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z2JXVjBhRzlrSUNKMGIydGxiakFvS1dGa1pISmxjM01pQ2lBZ0lDQmllWFJsWXlBeU1TQXZMeUJ0WlhSb2IyUWdJblJ2YTJWdU1TZ3BZV1JrY21WemN5SUtJQ0FnSUdKNWRHVmpJREUzSUM4dklHMWxkR2h2WkNBaWNISnBZMlV3UTNWdGRXeGhkR2wyWlV4aGMzUW9LWFZwYm5ReU5UWWlDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QnRaWFJvYjJRZ0luQnlhV05sTVVOMWJYVnNZWFJwZG1WTVlYTjBLQ2wxYVc1ME1qVTJJZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGN4WVRjek1UWXhJREI0TkROalptRXpNR1VnTUhneVpqSmtOakEwWlNBd2VHSXhZbUppTUdFNElEQjROMlF5WmpNMU5XTWdNSGd6WVdRellURXdNeUF3ZUdRMU1qRmtOakEwSUM4dklHMWxkR2h2WkNBaVlteHZZMnRVYVcxbGMzUmhiWEJNWVhOMEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luQnlhV05sTUVGMlpYSmhaMlVvS1hWcGJuUXlNalFpTENCdFpYUm9iMlFnSW5CeWFXTmxNVUYyWlhKaFoyVW9LWFZwYm5ReU1qUWlMQ0J0WlhSb2IyUWdJbTkzYm1WeUtDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSnViMjFwYm1GMFpXUlBkMjVsY2lncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWJtOXRhVzVoZEdWT1pYZFBkMjVsY2loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZqWTJWd2RFOTNibVZ5YzJocGNDZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lITmxkRlJwYldWc2IyTnJJSE5sZEZCbGNtbHZaQ0J6WlhSRGIyNXpkV3gwVEdWdWFXVnVZM2tnYzJWMFFXeHNiM2RUZEdGc1pVTnZibk4xYkhSeklHTmhibFZ3WkdGMFpTQjFjR1JoZEdVZ1kyOXVjM1ZzZENCUVJWSkpUMFFnUTA5T1UxVk1WRjlNUlU1SlJVNURXU0JCVEV4UFYxOVRWRUZNUlY5RFQwNVRWVXhVVXlCd1lXbHlJSFJ2YTJWdU1DQjBiMnRsYmpFZ2NISnBZMlV3UTNWdGRXeGhkR2wyWlV4aGMzUWdjSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1FnWW14dlkydFVhVzFsYzNSaGJYQk1ZWE4wSUhCeWFXTmxNRUYyWlhKaFoyVWdjSEpwWTJVeFFYWmxjbUZuWlNCdmQyNWxjaUJ1YjIxcGJtRjBaV1JQZDI1bGNpQnViMjFwYm1GMFpVNWxkMDkzYm1WeUlHRmpZMlZ3ZEU5M2JtVnljMmhwY0FvZ0lDQWdaWEp5Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXpiMnd1Um1sNFpXUlFiMmx1ZEM1dGRXd29jMlZzWmpvZ1lubDBaWE1zSUhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1JtbDRaV1JRYjJsdWRDNXRkV3c2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbTU2SUVacGVHVmtVRzlwYm5RdWJYVnNYMkp2YjJ4ZmRISjFaVUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHVjRkSEpoWTNRZ01DQXlPQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJcUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMd29nSUNBZ1lqMDlDaUFnSUNCaWVpQkdhWGhsWkZCdmFXNTBMbTExYkY5aWIyOXNYMlpoYkhObFFETUtDa1pwZUdWa1VHOXBiblF1YlhWc1gySnZiMnhmZEhKMVpVQXlPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDa1pwZUdWa1VHOXBiblF1YlhWc1gySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QkdhWGhsWkZCdmFXNTBPaUJOVlV4VVNWQk1TVU5CVkVsUFRsOVBWa1ZTUmt4UFZ3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NrWnBlR1ZrVUc5cGJuUXViWFZzWDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUVacGVHVmtVRzlwYm5RdWJYVnNYMkp2YjJ4ZmJXVnlaMlZBTkFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVjMjlzTGtacGVHVmtVRzlwYm5RdVpuSmhZM1JwYjI0b2JuVnRaWEpoZEc5eU9pQmllWFJsY3l3Z1pHVnViMjFwYm1GMGIzSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tSbWw0WldSUWIybHVkQzVtY21GamRHbHZiam9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0krQ2lBZ0lDQmhjM05sY25RZ0x5OGdSbWw0WldSUWIybHVkRG9nUkVsV1gwSlpYMXBGVWs4S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldNZ01qTWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS2dvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU9Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2NIVnphR2x1ZENBeU9Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG5OdmJDNUdhWGhsWkZCdmFXNTBMbVJsWTI5a1pURTBOQ2h6Wld4bU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrWnBlR1ZrVUc5cGJuUXVaR1ZqYjJSbE1UUTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldNZ01qTWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXpiMnd1Vlc1cGMzZGhjRll5VEdsaWNtRnllUzV6YjNKMFZHOXJaVzV6S0hSdmEyVnVRVG9nWW5sMFpYTXNJSFJ2YTJWdVFqb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1ZXNXBjM2RoY0ZZeVRHbGljbUZ5ZVM1emIzSjBWRzlyWlc1ek9nb2dJQ0FnY0hKdmRHOGdNaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnVlc1cGMzZGhjRll5VEdsaWNtRnllVG9nU1VSRlRsUkpRMEZNWDBGRVJGSkZVMU5GVXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSThDaUFnSUNCa2RYQUtJQ0FnSUdKNklGVnVhWE4zWVhCV01reHBZbkpoY25rdWMyOXlkRlJ2YTJWdWMxOTBaWEp1WVhKNVgyWmhiSE5sUURVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2dwVmJtbHpkMkZ3VmpKTWFXSnlZWEo1TG5OdmNuUlViMnRsYm5OZmRHVnlibUZ5ZVY5dFpYSm5aVUEyT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSjZJRlZ1YVhOM1lYQldNa3hwWW5KaGNua3VjMjl5ZEZSdmEyVnVjMTkwWlhKdVlYSjVYMlpoYkhObFFEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb0tWVzVwYzNkaGNGWXlUR2xpY21GeWVTNXpiM0owVkc5clpXNXpYM1JsY201aGNubGZiV1Z5WjJWQU9Ub0tJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnVlc1cGMzZGhjRll5VEdsaWNtRnllVG9nV2tWU1QxOUJSRVJTUlZOVENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEpsZEhOMVlnb0tWVzVwYzNkaGNGWXlUR2xpY21GeWVTNXpiM0owVkc5clpXNXpYM1JsY201aGNubGZabUZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlCVmJtbHpkMkZ3VmpKTWFXSnlZWEo1TG5OdmNuUlViMnRsYm5OZmRHVnlibUZ5ZVY5dFpYSm5aVUE1Q2dwVmJtbHpkMkZ3VmpKTWFXSnlZWEo1TG5OdmNuUlViMnRsYm5OZmRHVnlibUZ5ZVY5bVlXeHpaVUExT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSWdWVzVwYzNkaGNGWXlUR2xpY21GeWVTNXpiM0owVkc5clpXNXpYM1JsY201aGNubGZiV1Z5WjJWQU5nb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1YzI5c0xsVnVhWE4zWVhCV01reHBZbkpoY25rdWNHRnBja1p2Y2lobVlXTjBiM0o1T2lCaWVYUmxjeXdnZEc5clpXNUJPaUJpZVhSbGN5d2dkRzlyWlc1Q09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsVnVhWE4zWVhCV01reHBZbkpoY25rdWNHRnBja1p2Y2pvS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVlc1cGMzZGhjRll5VEdsaWNtRnllUzV6YjNKMFZHOXJaVzV6Q2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUZWdWFYTjNZWEJXTWt4cFluSmhjbmt1YzI5eWRGUnZhMlZ1Y3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TTJFNVl6UmpaamtnTHk4Z2JXVjBhRzlrSUNKblpYUlFZV2x5S0dGa1pISmxjM01zWVdSa2NtVnpjeWxoWkdSeVpYTnpJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWMyOXNMbFZ1YVhOM1lYQldNazl5WVdOc1pVeHBZbkpoY25rdVkzVnljbVZ1ZEVKc2IyTnJWR2x0WlhOMFlXMXdLQ2tnTFQ0Z2RXbHVkRFkwT2dwVmJtbHpkMkZ3VmpKUGNtRmpiR1ZNYVdKeVlYSjVMbU4xY25KbGJuUkNiRzlqYTFScGJXVnpkR0Z0Y0RvS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURJMElDOHZJREI0TURFd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklESTBJQzh2SURCNE1ERXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExuTnZiQzVWYm1semQyRndWakpQY21GamJHVk1hV0p5WVhKNUxtTjFjbkpsYm5SRGRXMTFiR0YwYVhabFVISnBZMlZ6S0hCaGFYSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN5d2dZbmwwWlhNc0lIVnBiblEyTkRvS1ZXNXBjM2RoY0ZZeVQzSmhZMnhsVEdsaWNtRnllUzVqZFhKeVpXNTBRM1Z0ZFd4aGRHbDJaVkJ5YVdObGN6b0tJQ0FnSUhCeWIzUnZJREVnTXdvZ0lDQWdZMkZzYkhOMVlpQlZibWx6ZDJGd1ZqSlBjbUZqYkdWTWFXSnlZWEo1TG1OMWNuSmxiblJDYkc5amExUnBiV1Z6ZEdGdGNBb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUJ0WlhSb2IyUWdJbkJ5YVdObE1FTjFiWFZzWVhScGRtVk1ZWE4wS0NsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlCdFpYUm9iMlFnSW5CeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMEtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTWpJZ0x5OGdiV1YwYUc5a0lDSm5aWFJTWlhObGNuWmxjeWdwS0hWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME5qUXBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXpNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElETTJJRE15Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJSEIxYzJocGJuUWdOamdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQ0U5Q2lBZ0lDQmllaUJWYm1semQyRndWakpQY21GamJHVk1hV0p5WVhKNUxtTjFjbkpsYm5SRGRXMTFiR0YwYVhabFVISnBZMlZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlFWnBlR1ZrVUc5cGJuUXVabkpoWTNScGIyNEtJQ0FnSUdWNGRISmhZM1FnTUNBeU9Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdJcUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRVpwZUdWa1VHOXBiblF1Wm5KaFkzUnBiMjRLSUNBZ0lHVjRkSEpoWTNRZ01DQXlPQW9nSUNBZ1lpb0tJQ0FnSUdJckNncFZibWx6ZDJGd1ZqSlBjbUZqYkdWTWFXSnlZWEo1TG1OMWNuSmxiblJEZFcxMWJHRjBhWFpsVUhKcFkyVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXpiMnd1Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1YzJWMFZHbHRaV3h2WTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJVYVcxbGJHOWphem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJSE5sZEZScGJXVnNiMk5yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NuTmxkRlJwYldWc2IyTnJYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYzJWMFZHbHRaV3h2WTJ0ZlltOXZiRjkwY25WbFFEZ0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYVcxbGJHOWphMTloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBhVzFsYkc5amExOWhaR1J5WlhOeklHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSjZJSE5sZEZScGJXVnNiMk5yWDJKdmIyeGZabUZzYzJWQU9Rb0tjMlYwVkdsdFpXeHZZMnRmWW05dmJGOTBjblZsUURnNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2MyVjBWR2x0Wld4dlkydGZZbTl2YkY5dFpYSm5aVUF4TURvS0lDQWdJR0Z6YzJWeWRDQXZMeUJaYjNVZ1lYSmxJRzV2ZENCaGJpQnZkMjVsY2lCdmNpQjBhR1VnWjI5MlpYSnVZVzVqWlNCMGFXMWxiRzlqYXdvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2MyVjBWR2x0Wld4dlkydGZZbTl2YkY5bVlXeHpaVUE1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdjMlYwVkdsdFpXeHZZMnRmWW05dmJGOXRaWEpuWlVBeE1Bb0tjMlYwVkdsdFpXeHZZMnRmZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2MyVjBWR2x0Wld4dlkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlWYm1semQyRndVR0ZwY2s5eVlXTnNaUzV6YjJ3dVZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWMyVjBVR1Z5YVc5a1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVUdWeWFXOWtPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUhObGRGQmxjbWx2WkY5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHpaWFJRWlhKcGIyUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ6WlhSUVpYSnBiMlJmWW05dmJGOTBjblZsUURnS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBhVzFsYkc5amExOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGFXMWxiRzlqYTE5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKNklITmxkRkJsY21sdlpGOWliMjlzWDJaaGJITmxRRGtLQ25ObGRGQmxjbWx2WkY5aWIyOXNYM1J5ZFdWQU9Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncHpaWFJRWlhKcGIyUmZZbTl2YkY5dFpYSm5aVUF4TURvS0lDQWdJR0Z6YzJWeWRDQXZMeUJaYjNVZ1lYSmxJRzV2ZENCaGJpQnZkMjVsY2lCdmNpQjBhR1VnWjI5MlpYSnVZVzVqWlNCMGFXMWxiRzlqYXdvZ0lDQWdZbmwwWldNZ05TQXZMeUFpVUVWU1NVOUVJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwelpYUlFaWEpwYjJSZlltOXZiRjltWVd4elpVQTVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2MyVjBVR1Z5YVc5a1gySnZiMnhmYldWeVoyVkFNVEFLQ25ObGRGQmxjbWx2WkY5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnpaWFJRWlhKcGIyUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlWYm1semQyRndVR0ZwY2s5eVlXTnNaUzV6YjJ3dVZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWMyVjBRMjl1YzNWc2RFeGxibWxsYm1ONVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwUTI5dWMzVnNkRXhsYm1sbGJtTjVPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUhObGRFTnZibk4xYkhSTVpXNXBaVzVqZVY5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHpaWFJEYjI1emRXeDBUR1Z1YVdWdVkzbGZkR1Z5Ym1GeWVWOXRaWEpuWlVBME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ6WlhSRGIyNXpkV3gwVEdWdWFXVnVZM2xmWW05dmJGOTBjblZsUURnS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBhVzFsYkc5amExOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGFXMWxiRzlqYTE5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKNklITmxkRU52Ym5OMWJIUk1aVzVwWlc1amVWOWliMjlzWDJaaGJITmxRRGtLQ25ObGRFTnZibk4xYkhSTVpXNXBaVzVqZVY5aWIyOXNYM1J5ZFdWQU9Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncHpaWFJEYjI1emRXeDBUR1Z1YVdWdVkzbGZZbTl2YkY5dFpYSm5aVUF4TURvS0lDQWdJR0Z6YzJWeWRDQXZMeUJaYjNVZ1lYSmxJRzV2ZENCaGJpQnZkMjVsY2lCdmNpQjBhR1VnWjI5MlpYSnVZVzVqWlNCMGFXMWxiRzlqYXdvZ0lDQWdZbmwwWldNZ01URWdMeThnSWtOUFRsTlZURlJmVEVWT1NVVk9RMWtpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuTmxkRU52Ym5OMWJIUk1aVzVwWlc1amVWOWliMjlzWDJaaGJITmxRRGs2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnpaWFJEYjI1emRXeDBUR1Z1YVdWdVkzbGZZbTl2YkY5dFpYSm5aVUF4TUFvS2MyVjBRMjl1YzNWc2RFeGxibWxsYm1ONVgzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSE5sZEVOdmJuTjFiSFJNWlc1cFpXNWplVjkwWlhKdVlYSjVYMjFsY21kbFFEUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG5OdmJDNVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXpaWFJCYkd4dmQxTjBZV3hsUTI5dWMzVnNkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkJiR3h2ZDFOMFlXeGxRMjl1YzNWc2RITTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJSE5sZEVGc2JHOTNVM1JoYkdWRGIyNXpkV3gwYzE5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHpaWFJCYkd4dmQxTjBZV3hsUTI5dWMzVnNkSE5mZEdWeWJtRnllVjl0WlhKblpVQTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUc5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCelpYUkJiR3h2ZDFOMFlXeGxRMjl1YzNWc2RITmZZbTl2YkY5MGNuVmxRRGdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYVcxbGJHOWphMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0o2SUhObGRFRnNiRzkzVTNSaGJHVkRiMjV6ZFd4MGMxOWliMjlzWDJaaGJITmxRRGtLQ25ObGRFRnNiRzkzVTNSaGJHVkRiMjV6ZFd4MGMxOWliMjlzWDNSeWRXVkFPRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3B6WlhSQmJHeHZkMU4wWVd4bFEyOXVjM1ZzZEhOZlltOXZiRjl0WlhKblpVQXhNRG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QlpiM1VnWVhKbElHNXZkQ0JoYmlCdmQyNWxjaUJ2Y2lCMGFHVWdaMjkyWlhKdVlXNWpaU0IwYVcxbGJHOWphd29nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dZbTl2YkNCMllXeHBaR0YwYVc5dUNpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVFVeE1UMWRmVTFSQlRFVmZRMDlPVTFWTVZGTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYzJWMFFXeHNiM2RUZEdGc1pVTnZibk4xYkhSelgySnZiMnhmWm1Gc2MyVkFPVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlITmxkRUZzYkc5M1UzUmhiR1ZEYjI1emRXeDBjMTlpYjI5c1gyMWxjbWRsUURFd0NncHpaWFJCYkd4dmQxTjBZV3hsUTI5dWMzVnNkSE5mZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2MyVjBRV3hzYjNkVGRHRnNaVU52Ym5OMWJIUnpYM1JsY201aGNubGZiV1Z5WjJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1YzI5c0xsVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExtTmhibFZ3WkdGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5oYmxWd1pHRjBaVG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJqWVc1VmNHUmhkR1ZmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS1kyRnVWWEJrWVhSbFgzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1kyRnNiSE4xWWlCVmJtbHpkMkZ3VmpKUGNtRmpiR1ZNYVdKeVlYSjVMbU4xY25KbGJuUkNiRzlqYTFScGJXVnpkR0Z0Y0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUpzYjJOclZHbHRaWE4wWVcxd1RHRnpkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBJR1Y0YVhOMGN3b2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhWFJ2WWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbEJGVWtsUFJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1VFVlNTVTlFSUdWNGFYTjBjd29nSUNBZ1lqNDlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGpZVzVWY0dSaGRHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWTJGdVZYQmtZWFJsWDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWMyOXNMbFZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMblZ3WkdGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpUb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQjFjR1JoZEdWZmRHVnlibUZ5ZVY5bVlXeHpaVUF6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tkWEJrWVhSbFgzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luQmhhWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJoYVhJZ1pYaHBjM1J6Q2lBZ0lDQmpZV3hzYzNWaUlGVnVhWE4zWVhCV01rOXlZV05zWlV4cFluSmhjbmt1WTNWeWNtVnVkRU4xYlhWc1lYUnBkbVZRY21salpYTUtJQ0FnSUhCdmNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luQmhhWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJoYVhJZ1pYaHBjM1J6Q2lBZ0lDQmpZV3hzYzNWaUlGVnVhWE4zWVhCV01rOXlZV05zWlV4cFluSmhjbmt1WTNWeWNtVnVkRU4xYlhWc1lYUnBkbVZRY21salpYTUtJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWNHRnBjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djR0ZwY2lCbGVHbHpkSE1LSUNBZ0lHTmhiR3h6ZFdJZ1ZXNXBjM2RoY0ZZeVQzSmhZMnhsVEdsaWNtRnllUzVqZFhKeVpXNTBRM1Z0ZFd4aGRHbDJaVkJ5YVdObGN3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmliRzlqYTFScGJXVnpkR0Z0Y0V4aGMzUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhWFJ2WWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbEJGVWtsUFJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1VFVlNTVTlFSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lHSThQUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVhWE4zWVhCUVlXbHlUM0poWTJ4bE9pQlFSVkpKVDBSZlRrOVVYMFZNUVZCVFJVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKd2NtbGpaVEJEZFcxMWJHRjBhWFpsVEdGemRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NISnBZMlV3UTNWdGRXeGhkR2wyWlV4aGMzUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklERUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUhWdVpHVnlabXh2ZHdvZ0lDQWdaR2xuSURNS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkdsbklERUtJQ0FnSUdJdkNpQWdJQ0JpZVhSbFl5QXlOU0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNamdLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSEIxYzJocGJuUWdNamdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0p3Y21salpUQkJkbVZ5WVdkbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NISnBZMlV4UTNWdGRXeGhkR2wyWlV4aGMzUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdJK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUhWdVpHVnlabXh2ZHdvZ0lDQWdaR2xuSURVS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnYzNkaGNBb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlMd29nSUNBZ1lubDBaV01nTWpVZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJNENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0luQnlhV05sTVVGMlpYSmhaMlVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpY0hKcFkyVXdRM1Z0ZFd4aGRHbDJaVXhoYzNRaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p3Y21salpURkRkVzExYkdGMGFYWmxUR0Z6ZENJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUpzYjJOclZHbHRaWE4wWVcxd1RHRnpkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwMWNHUmhkR1ZmZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2RYQmtZWFJsWDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWMyOXNMbFZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMbU52Ym5OMWJIUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjI1emRXeDBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCamIyNXpkV3gwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtTnZibk4xYkhSZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCallXeHNjM1ZpSUZWdWFYTjNZWEJXTWs5eVlXTnNaVXhwWW5KaGNua3VZM1Z5Y21WdWRFSnNiMk5yVkdsdFpYTjBZVzF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmliRzlqYTFScGJXVnpkR0Z0Y0V4aGMzUWdaWGhwYzNSekNpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlVRVZTU1U5RUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCUVJWSkpUMFFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lrTlBUbE5WVEZSZlRFVk9TVVZPUTFraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVOUFRsTlZURlJmVEVWT1NVVk9RMWtnWlhocGMzUnpDaUFnSUNCaUt3b2dJQ0FnWWp3S0lDQWdJR0p1ZWlCamIyNXpkV3gwWDJKdmIyeGZkSEoxWlVBMkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01USWdMeThnSWtGTVRFOVhYMU5VUVV4RlgwTlBUbE5WVEZSVElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQlRFeFBWMTlUVkVGTVJWOURUMDVUVlV4VVV5QmxlR2x6ZEhNS0lDQWdJR0o2SUdOdmJuTjFiSFJmWW05dmJGOW1ZV3h6WlVBM0NncGpiMjV6ZFd4MFgySnZiMnhmZEhKMVpVQTJPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbU52Ym5OMWJIUmZZbTl2YkY5dFpYSm5aVUE0T2dvZ0lDQWdZWE56WlhKMElDOHZJRlZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxPaUJRVWtsRFJWOUpVMTlUVkVGTVJWOU9SVVZFWDFSUFgwTkJURXhmVlZCRVFWUkZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0luUnZhMlZ1TUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEc5clpXNHdJR1Y0YVhOMGN3b2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JpZWlCamIyNXpkV3gwWDJWc2MyVmZZbTlrZVVBeE1Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKd2NtbGpaVEJCZG1WeVlXZGxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndjbWxqWlRCQmRtVnlZV2RsSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1JtbDRaV1JRYjJsdWRDNXRkV3dLSUNBZ0lHTmhiR3h6ZFdJZ1JtbDRaV1JRYjJsdWRDNWtaV052WkdVeE5EUUtDbU52Ym5OMWJIUmZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGpiMjV6ZFd4MFgyVnNjMlZmWW05a2VVQXhNRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWlkRzlyWlc0eElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIydGxiakVnWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVmJtbHpkMkZ3VUdGcGNrOXlZV05zWlRvZ1NVNVdRVXhKUkY5VVQwdEZUZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUySUM4dklDSndjbWxqWlRGQmRtVnlZV2RsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3Y21salpURkJkbVZ5WVdkbElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdSbWw0WldSUWIybHVkQzV0ZFd3S0lDQWdJR05oYkd4emRXSWdSbWw0WldSUWIybHVkQzVrWldOdlpHVXhORFFLSUNBZ0lHSWdZMjl1YzNWc2RGOWhablJsY2w5cFpsOWxiSE5sUURFeENncGpiMjV6ZFd4MFgySnZiMnhmWm1Gc2MyVkFOem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHTnZibk4xYkhSZlltOXZiRjl0WlhKblpVQTRDZ3BqYjI1emRXeDBYM1JsY201aGNubGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdOdmJuTjFiSFJmZEdWeWJtRnllVjl0WlhKblpVQTBDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VUdGcGNrOXlZV05zWlM1emIyd3VWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVVRVZTU1U5RVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tVRVZTU1U5RU9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklGQkZVa2xQUkY5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncFFSVkpKVDBSZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVVFVlNTVTlFSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJRUlZKSlQwUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1VFVlNTVTlFWDNSbGNtNWhjbmxmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlGQkZVa2xQUkY5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExuTnZiQzVWYm1semQyRndVR0ZwY2s5eVlXTnNaUzVEVDA1VFZVeFVYMHhGVGtsRlRrTlpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LUTA5T1UxVk1WRjlNUlU1SlJVNURXVG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJEVDA1VFZVeFVYMHhGVGtsRlRrTlpYM1JsY201aGNubGZabUZzYzJWQU13b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ2tOUFRsTlZURlJmVEVWT1NVVk9RMWxmZEdWeWJtRnllVjl0WlhKblpVQTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSWtOUFRsTlZURlJmVEVWT1NVVk9RMWtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRU5QVGxOVlRGUmZURVZPU1VWT1Exa2daWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1EwOU9VMVZNVkY5TVJVNUpSVTVEV1Y5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQkRUMDVUVlV4VVgweEZUa2xGVGtOWlgzUmxjbTVoY25sZmJXVnlaMlZBTkFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVjMjlzTGxWdWFYTjNZWEJRWVdseVQzSmhZMnhsTGtGTVRFOVhYMU5VUVV4RlgwTlBUbE5WVEZSVFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tRVXhNVDFkZlUxUkJURVZmUTA5T1UxVk1WRk02Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nUVV4TVQxZGZVMVJCVEVWZlEwOU9VMVZNVkZOZmRHVnlibUZ5ZVY5bVlXeHpaVUF6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tRVXhNVDFkZlUxUkJURVZmUTA5T1UxVk1WRk5mZEdWeWJtRnllVjl0WlhKblpVQTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01USWdMeThnSWtGTVRFOVhYMU5VUVV4RlgwTlBUbE5WVEZSVElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQlRFeFBWMTlUVkVGTVJWOURUMDVUVlV4VVV5QmxlR2x6ZEhNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2tGTVRFOVhYMU5VUVV4RlgwTlBUbE5WVEZSVFgzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRUZNVEU5WFgxTlVRVXhGWDBOUFRsTlZURlJUWDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWMyOXNMbFZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMbkJoYVhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZV2x5T2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUhCaGFYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LY0dGcGNsOTBaWEp1WVhKNVgyMWxjbWRsUURRNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSndZV2x5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3WVdseUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NHRnBjbDkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCd1lXbHlYM1JsY201aGNubGZiV1Z5WjJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1YzI5c0xsVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExuUnZhMlZ1TUZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnZhMlZ1TURvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCMGIydGxiakJmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2RHOXJaVzR3WDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKMGIydGxiakFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2YTJWdU1DQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuUnZhMlZ1TUY5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQjBiMnRsYmpCZmRHVnlibUZ5ZVY5dFpYSm5aVUEwQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXpiMnd1Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1ZEc5clpXNHhXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEc5clpXNHhPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJSFJ2YTJWdU1WOTBaWEp1WVhKNVgyWmhiSE5sUURNS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3AwYjJ0bGJqRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJblJ2YTJWdU1TSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR4SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZEc5clpXNHhYM1JsY201aGNubGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhSdmEyVnVNVjkwWlhKdVlYSjVYMjFsY21kbFFEUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG5OdmJDNVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXdjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOME9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklIQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBYM1JsY201aGNubGZabUZzYzJWQU13b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ25CeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOMFgzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHdjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkRjkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCd2NtbGpaVEJEZFcxMWJHRjBhWFpsVEdGemRGOTBaWEp1WVhKNVgyMWxjbWRsUURRS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMVZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMbk52YkM1VmJtbHpkMkZ3VUdGcGNrOXlZV05zWlM1d2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YVdObE1VTjFiWFZzWVhScGRtVk1ZWE4wT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUhCeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMFgzUmxjbTVoY25sZlptRnNjMlZBTXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbkJ5YVdObE1VTjFiWFZzWVhScGRtVk1ZWE4wWDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5CeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRGOTBaWEp1WVhKNVgyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ3Y21salpURkRkVzExYkdGMGFYWmxUR0Z6ZEY5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExuTnZiQzVWYm1semQyRndVR0ZwY2s5eVlXTnNaUzVpYkc5amExUnBiV1Z6ZEdGdGNFeGhjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWJHOWphMVJwYldWemRHRnRjRXhoYzNRNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ1lteHZZMnRVYVcxbGMzUmhiWEJNWVhOMFgzUmxjbTVoY25sZlptRnNjMlZBTXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbUpzYjJOclZHbHRaWE4wWVcxd1RHRnpkRjkwWlhKdVlYSjVYMjFsY21kbFFEUTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppYkc5amExUnBiV1Z6ZEdGdGNFeGhjM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0pzYjJOclZHbHRaWE4wWVcxd1RHRnpkQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbUpzYjJOclZHbHRaWE4wWVcxd1RHRnpkRjkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCaWJHOWphMVJwYldWemRHRnRjRXhoYzNSZmRHVnlibUZ5ZVY5dFpYSm5aVUEwQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXpiMnd1Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1Y0hKcFkyVXdRWFpsY21GblpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YVdObE1FRjJaWEpoWjJVNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2NISnBZMlV3UVhabGNtRm5aVjkwWlhKdVlYSjVYMlpoYkhObFFETUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwd2NtbGpaVEJCZG1WeVlXZGxYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0p3Y21salpUQkJkbVZ5WVdkbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCd2NtbGpaVEJCZG1WeVlXZGxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNamdLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSEIxYzJocGJuUWdNamdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY0hKcFkyVXdRWFpsY21GblpWOTBaWEp1WVhKNVgyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ3Y21salpUQkJkbVZ5WVdkbFgzUmxjbTVoY25sZmJXVnlaMlZBTkFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVjMjlzTGxWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG5CeWFXTmxNVUYyWlhKaFoyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3Y21salpURkJkbVZ5WVdkbE9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklIQnlhV05sTVVGMlpYSmhaMlZmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2NISnBZMlV4UVhabGNtRm5aVjkwWlhKdVlYSjVYMjFsY21kbFFEUTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5pQXZMeUFpY0hKcFkyVXhRWFpsY21GblpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NISnBZMlV4UVhabGNtRm5aU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREk0Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0J3ZFhOb2FXNTBJREk0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25CeWFXTmxNVUYyWlhKaFoyVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnY0hKcFkyVXhRWFpsY21GblpWOTBaWEp1WVhKNVgyMWxjbWRsUURRS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMVZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMbk52YkM1VmJtbHpkMkZ3VUdGcGNrOXlZV05zWlM1dmQyNWxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205M2JtVnlPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzkzYm1WeVgzUmxjbTVoY25sZlptRnNjMlZBTXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTkzYm1WeVgzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtOTNibVZ5WDNSbGNtNWhjbmxmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHOTNibVZ5WDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWMyOXNMbFZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMbTV2YldsdVlYUmxaRTkzYm1WeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tibTl0YVc1aGRHVmtUM2R1WlhJNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JtOXRhVzVoZEdWa1QzZHVaWEpmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JtOXRhVzVoZEdWa1QzZHVaWEpmZEdWeWJtRnllVjl0WlhKblpVQTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHNXZiV2x1WVhSbFpFOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYm05dGFXNWhkR1ZrVDNkdVpYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYm05dGFXNWhkR1ZrVDNkdVpYSmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlWYm1semQyRndVR0ZwY2s5eVlXTnNaUzV6YjJ3dVZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWJtOXRhVzVoZEdWT1pYZFBkMjVsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtNXZiV2x1WVhSbFRtVjNUM2R1WlhJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdWIyMXBibUYwWlU1bGQwOTNibVZ5WDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtNXZiV2x1WVhSbFRtVjNUM2R1WlhKZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJvWlNCamIyNTBjbUZqZENCdmQyNWxjaUJ0WVhrZ2NHVnlabTl5YlNCMGFHbHpJR0ZqZEdsdmJnb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJtOXRhVzVoZEdWa1QzZHVaWElpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6TmlaVGRpTTJFZ0x5OGdiV1YwYUc5a0lDSlBkMjVsY2s1dmJXbHVZWFJsWkNoMWFXNTBPRnN6TWwwcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTV2YldsdVlYUmxUbVYzVDNkdVpYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYm05dGFXNWhkR1ZPWlhkUGQyNWxjbDkwWlhKdVlYSjVYMjFsY21kbFFEUUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG5OdmJDNVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNWhZMk5sY0hSUGQyNWxjbk5vYVhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhZMk5sY0hSUGQyNWxjbk5vYVhBNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ1lXTmpaWEIwVDNkdVpYSnphR2x3WDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtRmpZMlZ3ZEU5M2JtVnljMmhwY0Y5MFpYSnVZWEo1WDIxbGNtZGxRRFE2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p1YjIxcGJtRjBaV1JQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2JtOXRhVzVoZEdWa1QzZHVaWElnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWmIzVWdiWFZ6ZENCaVpTQnViMjFwYm1GMFpXUWdZbVZtYjNKbElIbHZkU0JqWVc0Z1lXTmpaWEIwSUc5M2JtVnljMmhwY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdmQyNWxjaUJsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFl6WkdGa1ltVTFJQzh2SUcxbGRHaHZaQ0FpVDNkdVpYSkRhR0Z1WjJWa0tIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltNXZiV2x1WVhSbFpFOTNibVZ5SWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGhZMk5sY0hSUGQyNWxjbk5vYVhCZmRHVnlibUZ5ZVY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZV05qWlhCMFQzZHVaWEp6YUdsd1gzUmxjbTVoY25sZmJXVnlaMlZBTkFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG5OdmJDNVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQUFFZ0J2Ly8vLzhQSmhvRUZSOThkUVZ2ZDI1bGNpQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJCMGFXMWxiRzlqYTE5aFpHUnlaWE56RW1Kc2IyTnJWR2x0WlhOMFlXMXdUR0Z6ZEFaUVJWSkpUMFFFY0dGcGNnNXViMjFwYm1GMFpXUlBkMjVsY2hSd2NtbGpaVEJEZFcxMWJHRjBhWFpsVEdGemRCUndjbWxqWlRGRGRXMTFiR0YwYVhabFRHRnpkQ0VCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFRMDlPVTFWTVZGOU1SVTVKUlU1RFdSUkJURXhQVjE5VFZFRk1SVjlEVDA1VFZVeFVVd1owYjJ0bGJqQUdkRzlyWlc0eERYQnlhV05sTUVGMlpYSmhaMlVOY0hKcFkyVXhRWFpsY21GblpRUkw2TUtpQkpCNlZvRWNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVJqR0VYakJLVU1sSmtFRkVNbWt5QUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUFBQUFBQUFBQUFBQUFBQUFBQUFVQkFBQUFBQnovLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vSWttQmdDQ3ZTVFVGTlFBMEFJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlCY1FEVUFNUmhBQVRrMkdnQTJHZ0UyR2dJMkdnTTJHZ1JGQmlrcVp5Y0hLbWNyS21lQmtCd1dKd1ZNWjRGNEZpY0xUR2NuRENKbkp3WXFaeWNOS21jbkRpcG5Kd2lBQUdjbkNZQUFaeWNFSW1jbkR5Y1RaeWNRSnhOblNTb1RSQ2xMQVdlQUpHUGEyK1VBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFeFFzSWdCK1NjR1N3Rm5zWUVZV3lXeUVDS3lHU0t5QVVteUdDY1VzaHF6dEQ1WEJBQW5EVXhuc1NXeUVDS3lHU0t5QVVteUdDY1ZzaHF6dEQ1WEJBQW5Ea3huc1NXeUVDS3lHU0t5QVVteUdDY1JzaHF6dEQ1WEJBQW5DRXhuc1NXeUVDS3lHU0t5QVVteUdDY1NzaHF6dEQ1WEJBQW5DVXhuc1NXeUVDS3lHU0t5QWJJWUp4YXlHck8wUG9GRVd5Y0VUR2UwUGxja0lFVUJ0RDVYQkNDQUFLbEJBQTlKZ0FDcFFRQUlJMFFyU3dKbkkwTWlRdi8xTVJrVVJERVlSSUlMQktyN3NJc0UwUkpMK1FTT0NaOXRCSjBDKzBFRWZ0R05VZ1NnNkJoeUJDMHgvTFVFZU0yNlpRUmxYZUxTQk02VGN5OEVsQmRacFNjVUp4VW5FU2NTZ2djRWNhY3hZUVJEejZNT0JDOHRZRTRFc2J1d3FBUjlMelZjQkRyVG9RTUUxU0hXQkRZYUFJNFdBYVlCM3dJYUFsVUNsUUxJQTNVRUFRUWxCRWtFYkFTSUJLUUV3QVRrQlFnRkpRVkxCWEVGakFXb0Jkd0FpZ0lCZ0FDTC80QUFxRUFBRTR2K1Z3QWNTWXYvbzBtTUFJdi9vcWhCQUE0alJJc0FTUlVrRGtRa3I2dE1pU0pDLysrS0FnR0wvNEFBcFVTTC9pY1hveWNLcW92L29ra1ZnUndPUklFY3I2dUppZ0VCaS85WEFDQW5GNktBRXYvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLzZ5SmlnSUNJb3YraS84VFJJditpLytrU1VFQUc0di9qQUNMQVVFQURZditTU29UUklzQVR3TlBBNG1MLzBMLzhJditqQUJDLytLS0F3R0wvb3YvaVAvQlNJditpLytJLzdsRkFiR0wvWUVZV3lXeUVDS3lHU0t5QWJJWWdBUTZuRXo1c2hwTXNocXlHck8wUGxjRUFJbUJDSzh5QnhZbkdLcExBVXhRTWdjV0p4aXFUd0pNVUJXQkNBbGJJUVFhaVlvQkE0ai8ya214aS8rQkdGc2xzaEFpc2hraXNnRkpzaGduRWJJYXM3UStWd1FBVGdLeEpiSVFJcklaSXJJQlNiSVlKeEt5R3JPMFBsY0VBRTRDc1NXeUVDS3lHU0t5QWJJWUp4YXlHck8wUGxjRUlFNEN0RDVYSkNCT0FyUStnVVJiU1U0REUwRUFNSXNBaXdRSlNTRUVEa1NMQTBsT0Fvc0NTVTREaVA2eVZ3QWNUQlpNU3dHaml3R2dqQUZNVHdLSS9wNVhBQnlqb0lzQlRJc0FqQUtNQVl3QWlUWWFBVWtWSkJKRU1SWkJBQ2d4RmlNSk9BZ1VSREVBSWlsbFJCSkFBQW94QUNJclpVUVNRUUFJSTBRclN3Rm5JME1pUXYvMUlrTC8yallhQVVrVmdVQVNSREVXUVFBcE1SWWpDVGdJRkVReEFDSXBaVVFTUUFBS01RQWlLMlZFRWtFQUNTTkVKd1ZMQVdjalF5SkMvL1FpUXYvWk5ob0JTUldCUUJKRU1SWkJBQ2t4RmlNSk9BZ1VSREVBSWlsbFJCSkFBQW94QUNJclpVUVNRUUFKSTBRbkMwc0JaeU5ESWtMLzlDSkMvOWsyR2dGSkZTTVNSQ0pUTVJaQkFDMHhGaU1KT0FnVVJERUFJaWxsUkJKQUFBb3hBQ0lyWlVRU1FRQU5JMFJIQWlNT1JDY01UR2NqUXlKQy8vQWlRdi9WTVJaQkFDb3hGaU1KT0FnVVJJaitQQ0luQkdWRUNVa2hCQTVFRmlJbkJXVkVwNEFCQUNKUEFsUW9URkN3STBNaVF2L1lNUlpCQUtReEZpTUpPQWdVUkNJbkJtVkVpUDRrUmdJaUp3WmxSSWorR2toT0FrZ2lKd1psUklqK0RrNENSZ0lpSndSbFJFc0JUQWxKSVFRT1JCWWlKd1ZsUkVzQnBrUWlKd2hsUkVzRFN3R25SRXNESndxZ1RLRW5DcXBMQWFJbkdheEpGWUVjRGtTQkhLOU1Td0dySnc5TVp5SW5DV1ZFU3dWTEFhZEVTd1VuQ3FCTW9TY0txazhDb2ljWnJFa1ZnUndPUktzbkVFeG5Kd2hQQW1jbkNVOENaeWNFVEdjalF5SkMvMTQyR2dGSkZTUVNSRFlhQWtrVkpCSkVNUlpCQUhNeEZpTUpPQWdVUklqOVRDSW5CR1ZFQ1VraEJBNUVGaUluQldWRUlpY0xaVVNncEVBQUNDSW5ER1ZFUVFCQkkwUWlKdzFsUkVzQ0VrRUFHeUluRDJWRVN3R0kvREtJL0lCSkZTUU9SQ1N2cXloTVVMQWpReUluRG1WRVN3SVNSQ0luRUdWRVN3R0kvQTZJL0Z4Qy85a2lRdis4SWtML2p6RVdRUUFiTVJZakNUZ0lGRVFpSndWbFJFa1ZKQTVFSksrcktFeFFzQ05ESWtMLzV6RVdRUUFiTVJZakNUZ0lGRVFpSnd0bFJFa1ZKQTVFSksrcktFeFFzQ05ESWtMLzV6RVdRUUFhTVJZakNUZ0lGRVFpSnd4bFJJQUJBQ0pQQWxRb1RGQ3dJME1pUXYvb01SWkJBQk14RmlNSk9BZ1VSQ0luQm1WRUtFeFFzQ05ESWtMLzd6RVdRUUFUTVJZakNUZ0lGRVFpSncxbFJDaE1VTEFqUXlKQy8rOHhGa0VBRXpFV0l3azRDQlJFSWljT1pVUW9URkN3STBNaVF2L3ZNUlpCQUJzeEZpTUpPQWdVUkNJbkNHVkVTUlVrRGtRa3I2c29URkN3STBNaVF2L25NUlpCQUJzeEZpTUpPQWdVUkNJbkNXVkVTUlVrRGtRa3I2c29URkN3STBNaVF2L25NUlpCQUJReEZpTUpPQWdVUkNJbkJHVkVGaWhNVUxBalF5SkMvKzR4RmtFQUhURVdJd2s0Q0JSRUlpY1BaVVJKRllFY0RrU0JISytyS0V4UXNDTkRJa0wvNVRFV1FRQWRNUllqQ1RnSUZFUWlKeEJsUkVrVmdSd09SSUVjcjZzb1RGQ3dJME1pUXYvbE1SWkJBQkl4RmlNSk9BZ1VSQ0lwWlVRb1RGQ3dJME1pUXYvd01SWkJBQk14RmlNSk9BZ1VSQ0luQjJWRUtFeFFzQ05ESWtMLzd6WWFBVWtWSkJKRU1SWkJBQ014RmlNSk9BZ1VSREVBSWlsbFJCSkVKd2RMQVVsT0FtZUFCTU8rZXpwTVVMQWpReUpDLzk4eEZrRUFMVEVXSXdrNENCUkVNUUFpSndkbFJFeExBUkpFSWlsbFJFc0JVSUFFWTlyYjVVeFFzQ2xNWnljSEttY2pReUpDLzlVPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyTm9taW5hdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJPd25lckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
