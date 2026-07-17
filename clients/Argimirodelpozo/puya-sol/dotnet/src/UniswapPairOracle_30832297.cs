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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.UniswapPairOracle_30832297
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
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 X { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
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
                    var vX = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.X = vX;
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
        public async Task SetPeriod(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _period, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 250, 186, 158 };

            var result = await base.CallApp(new List<object> { abiHandle, _period }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPeriod_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _period, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 250, 186, 158 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _period }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_consult_leniency"> </param>
        public async Task SetConsultLeniency(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _consult_leniency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 142, 59, 79 };

            var result = await base.CallApp(new List<object> { abiHandle, _consult_leniency }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetConsultLeniency_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 _consult_leniency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 142, 59, 79 };

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
        /// <param name="amountIn"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Consult(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 49, 252, 181 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);

            var result = await base.SimApp(new List<object> { abiHandle, tokenAbi, amountIn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Consult_Transactions(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 49, 252, 181 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, amountIn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        public async Task<Structs.Uq112X112> Price0Average(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 129, 109, 105 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Uq112X112.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Price0Average_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 129, 109, 105 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Uq112X112> Price1Average(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 131, 149, 254 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Uq112X112.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Price1Average_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 131, 149, 254 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVW5pc3dhcFBhaXJPcmFjbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsidXExMTJ4MTEyIjpbeyJuYW1lIjoiX3giLCJ0eXBlIjoidWludDI1NiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRUaW1lbG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3RpbWVsb2NrX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UGVyaW9kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcGVyaW9kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldENvbnN1bHRMZW5pZW5jeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX2NvbnN1bHRfbGVuaWVuY3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0QWxsb3dTdGFsZUNvbnN1bHRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfYWxsb3dfc3RhbGVfY29uc3VsdHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuVXBkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnN1bHQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50SW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZU5ld093bmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfb3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6Ik93bmVyTm9taW5hdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWNjZXB0T3duZXJzaGlwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJPd25lckNoYW5nZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2xkT3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPd25lciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlBFUklPRCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkNPTlNVTFRfTEVOSUVOQ1kiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJBTExPV19TVEFMRV9DT05TVUxUUyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByaWNlMEN1bXVsYXRpdmVMYXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJpY2UxQ3VtdWxhdGl2ZUxhc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJibG9ja1RpbWVzdGFtcExhc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByaWNlMEF2ZXJhZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYpIiwic3RydWN0IjoidXExMTJ4MTEyIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcmljZTFBdmVyYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2KSIsInN0cnVjdCI6InVxMTEyeDExMiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub21pbmF0ZWRPd25lciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MTJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzg4Ml0sImVycm9yTWVzc2FnZSI6IkZpeGVkUG9pbnQ6IERJVl9CWV9aRVJPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU1XSwiZXJyb3JNZXNzYWdlIjoiRml4ZWRQb2ludDogTVVMVElQTElDQVRJT05fT1ZFUkZMT1ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzA1XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgY29udHJhY3Qgb3duZXIgbWF5IHBlcmZvcm0gdGhpcyBhY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDVdLCJlcnJvck1lc3NhZ2UiOiJPd25lciBhZGRyZXNzIGNhbm5vdCBiZSAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2N10sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBQYWlyT3JhY2xlOiBJTlZBTElEX1RPS0VOIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjY4XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFBhaXJPcmFjbGU6IE5PX1JFU0VSVkVTIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4Nl0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBQYWlyT3JhY2xlOiBQRVJJT0RfTk9UX0VMQVBTRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjE4XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFBhaXJPcmFjbGU6IFBSSUNFX0lTX1NUQUxFX05FRURfVE9fQ0FMTF9VUERBVEUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDRdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjJMaWJyYXJ5OiBJREVOVElDQUxfQUREUkVTU0VTIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTcwXSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyTGlicmFyeTogWkVST19BRERSRVNTIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2NSwxMzA3LDEzNDksMTM5M10sImVycm9yTWVzc2FnZSI6IllvdSBhcmUgbm90IGFuIG93bmVyIG9yIHRoZSBnb3Zlcm5hbmNlIHRpbWVsb2NrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTczM10sImVycm9yTWVzc2FnZSI6IllvdSBtdXN0IGJlIG5vbWluYXRlZCBiZWZvcmUgeW91IGNhbiBhY2NlcHQgb3duZXJzaGlwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxMywxODAxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQUxMT1dfU1RBTEVfQ09OU1VMVFMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwMywxNzgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQ09OU1VMVF9MRU5JRU5DWSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDE5LDE0ODIsMTU5OCwxNzYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgUEVSSU9EIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MTIsMTQ3MiwxNTkxLDE4NTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBibG9ja1RpbWVzdGFtcExhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcyOCwxOTAxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgbm9taW5hdGVkT3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0OCwxMjkwLDEzMzIsMTM3NiwxNzAzLDE3MzcsMTg5MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIG93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MzgsMTQ0OCwxNDYwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcGFpciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjM0LDE4NjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwcmljZTBBdmVyYWdlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OTYsMTgxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHByaWNlMEN1bXVsYXRpdmVMYXN0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NzIsMTg4MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHByaWNlMUF2ZXJhZ2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUzMSwxODM4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcHJpY2UxQ3VtdWxhdGl2ZUxhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1OSwxMzAxLDEzNDMsMTM4N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRpbWVsb2NrX2FkZHJlc3MgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRva2VuMCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdG9rZW4xIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0MiwxNTc1LDE2OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4NCwxMzI2LDE1ODNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYyLDg5NSwxNTExLDE1NDYsMTY0OSwxNzY4LDE3ODcsMTgyNCwxODQzXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ05nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSnZkMjVsY2lJZ1ltRnpaVE15S0VGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUVwSURCNElDSjBhVzFsYkc5amExOWhaR1J5WlhOeklpQWlZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBJaUFpVUVWU1NVOUVJaUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlJQ0p3WVdseUlpQWljSEpwWTJVd1EzVnRkV3hoZEdsMlpVeGhjM1FpSUNKd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRDSWdJa05QVGxOVlRGUmZURVZPU1VWT1Exa2lJQ0pCVEV4UFYxOVRWRUZNUlY5RFQwNVRWVXhVVXlJZ0luQnlhV05sTUVGMlpYSmhaMlVpSUNKd2NtbGpaVEZCZG1WeVlXZGxJaUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQWlkRzlyWlc0d0lpQWlkRzlyWlc0eElpQXdlRFJpWlRoak1tRXlJREI0T1RBM1lUVTJPREVnTUhneE5EUXpNalk1TXlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGd3TVRBd01EQXdNREF3SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJtOXRhVzVoZEdWa1QzZHVaWElpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJwYldWc2IyTnJYMkZrWkhKbGMzTWlDaUFnSUNCaWVYUmxZMTh5SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhCMWMyaHBiblFnTXpZd01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVVFVlNTVTlFSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEIxYzJocGJuUWdNVEl3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpUTA5T1UxVk1WRjlNUlU1SlJVNURXU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpUVV4TVQxZGZVMVJCVEVWZlEwOU9VMVZNVkZNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5CaGFYSWlDaUFnSUNCaWVYUmxZMTh5SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREUySUM4dklDSjBiMnRsYmpBaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKMGIydGxiakVpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbkJ5YVdObE1FTjFiWFZzWVhScGRtVk1ZWE4wSWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRDSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmliRzlqYTFScGJXVnpkR0Z0Y0V4aGMzUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSndjbWxqWlRCQmRtVnlZV2RsSWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKd2NtbGpaVEZCZG1WeVlXZGxJZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHSjFjbmtnTmdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGQyNWxjaUJoWkdSeVpYTnpJR05oYm01dmRDQmlaU0F3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlV6TWlneVRFZFFSa1ZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHTmhiR3h6ZFdJZ1ZXNXBjM2RoY0ZZeVRHbGljbUZ5ZVM1d1lXbHlSbTl5Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0p3WVdseUlnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qTXhPRFExWlRNZ0x5OGdiV1YwYUc5a0lDSjBiMnRsYmpBb0tXRmtaSEpsYzNNaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKMGIydGxiakFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVRVd1l6azBPVGtnTHk4Z2JXVjBhRzlrSUNKMGIydGxiakVvS1dGa1pISmxjM01pQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0owYjJ0bGJqRWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdiV1YwYUc5a0lDSndjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkQ2dwZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWljSEpwWTJVd1EzVnRkV3hoZEdsMlpVeGhjM1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01Ua2dMeThnYldWMGFHOWtJQ0p3Y21salpURkRkVzExYkdGMGFYWmxUR0Z6ZENncGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5CeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QnRaWFJvYjJRZ0ltZGxkRkpsYzJWeWRtVnpLQ2tvZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5RMk5Da2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElETXlDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTXpZZ016SUtJQ0FnSUdKMWNua2dNZ29nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCd2RYTm9hVzUwSURZNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlteHZZMnRVYVcxbGMzUmhiWEJNWVhOMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWW5vZ2JXRnBibDlpYjI5c1gyWmhiSE5sUURrS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJ0WVdsdVgySnZiMnhmWm1Gc2MyVkFPUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtDbTFoYVc1ZlltOXZiRjl0WlhKblpVQXhNRG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibWx6ZDJGd1VHRnBjazl5WVdOc1pUb2dUazlmVWtWVFJWSldSVk1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJwYldWc2IyTnJYMkZrWkhKbGMzTWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbTl2YkY5bVlXeHpaVUE1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5aWIyOXNYMjFsY21kbFFERXdDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaFlXWmlZakE0WWlBd2VHRXhabUZpWVRsbElEQjRNVFE0WlROaU5HWWdNSGc1WkRBeVptSTBNU0F3ZURkbFpERTRaRFV5SURCNFlUQmxPREU0TnpJZ01IZ3laRE14Wm1OaU5TQXdlRE5oWkROaE1UQXpJREI0WkRVeU1XUTJNRFFnTUhnM09HTmtZbUUyTlNBd2VEWTFOV1JsTW1ReUlEQjRZMlU1TXpjek1tWWdMeThnYldWMGFHOWtJQ0p6WlhSVWFXMWxiRzlqYXloaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZCbGNtbHZaQ2gxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRU52Ym5OMWJIUk1aVzVwWlc1amVTaDFhVzUwTWpVMktYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFRnNiRzkzVTNSaGJHVkRiMjV6ZFd4MGN5aGliMjlzS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5oYmxWd1pHRjBaU2dwWW05dmJDSXNJRzFsZEdodlpDQWlkWEJrWVhSbEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamIyNXpkV3gwS0dGa1pISmxjM01zZFdsdWRESTFOaWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0p1YjIxcGJtRjBaVTVsZDA5M2JtVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVlXTmpaWEIwVDNkdVpYSnphR2x3S0NsMmIybGtJaXdnYldWMGFHOWtJQ0pRUlZKSlQwUW9LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJa05QVGxOVlRGUmZURVZPU1VWT1Exa29LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJa0ZNVEU5WFgxTlVRVXhGWDBOUFRsTlZURlJUS0NsaWIyOXNJZ29nSUNBZ1lubDBaV01nTVRnZ0x5OGdiV1YwYUc5a0lDSndjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkQ2dwZFdsdWRESTFOaUlLSUNBZ0lHSjVkR1ZqSURFNUlDOHZJRzFsZEdodlpDQWljSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1FvS1hWcGJuUXlOVFlpQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TnpGaE56TXhOakVnTUhoaVl6Z3hObVEyT1NBd2VEVTBPRE01TldabElEQjRZakZpWW1Jd1lUZ2dNSGczWkRKbU16VTFZeUF2THlCdFpYUm9iMlFnSW1Kc2IyTnJWR2x0WlhOMFlXMXdUR0Z6ZENncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKd2NtbGpaVEJCZG1WeVlXZGxLQ2tvZFdsdWRESTFOaWtpTENCdFpYUm9iMlFnSW5CeWFXTmxNVUYyWlhKaFoyVW9LU2gxYVc1ME1qVTJLU0lzSUcxbGRHaHZaQ0FpYjNkdVpYSW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbTV2YldsdVlYUmxaRTkzYm1WeUtDbGhaR1J5WlhOeklnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2djMlYwVkdsdFpXeHZZMnNnYzJWMFVHVnlhVzlrSUhObGRFTnZibk4xYkhSTVpXNXBaVzVqZVNCelpYUkJiR3h2ZDFOMFlXeGxRMjl1YzNWc2RITWdZMkZ1VlhCa1lYUmxJSFZ3WkdGMFpTQmpiMjV6ZFd4MElHNXZiV2x1WVhSbFRtVjNUM2R1WlhJZ1lXTmpaWEIwVDNkdVpYSnphR2x3SUZCRlVrbFBSQ0JEVDA1VFZVeFVYMHhGVGtsRlRrTlpJRUZNVEU5WFgxTlVRVXhGWDBOUFRsTlZURlJUSUhCeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOMElIQnlhV05sTVVOMWJYVnNZWFJwZG1WTVlYTjBJR0pzYjJOclZHbHRaWE4wWVcxd1RHRnpkQ0J3Y21salpUQkJkbVZ5WVdkbElIQnlhV05sTVVGMlpYSmhaMlVnYjNkdVpYSWdibTl0YVc1aGRHVmtUM2R1WlhJS0lDQWdJR1Z5Y2dvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1R2FYaGxaRkJ2YVc1MExtMTFiQ2h6Wld4bU9pQmllWFJsY3l3Z2VUb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1JtbDRaV1JRYjJsdWRDNXRkV3c2Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JpYm5vZ1JtbDRaV1JRYjJsdWRDNXRkV3hmWW05dmJGOTBjblZsUURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpb0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l2Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJRVpwZUdWa1VHOXBiblF1YlhWc1gySnZiMnhmWm1Gc2MyVkFNd29LUm1sNFpXUlFiMmx1ZEM1dGRXeGZZbTl2YkY5MGNuVmxRREk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LUm1sNFpXUlFiMmx1ZEM1dGRXeGZZbTl2YkY5dFpYSm5aVUEwT2dvZ0lDQWdZWE56WlhKMElDOHZJRVpwZUdWa1VHOXBiblE2SUUxVlRGUkpVRXhKUTBGVVNVOU9YMDlXUlZKR1RFOVhDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYUnpkV0lLQ2tacGVHVmtVRzlwYm5RdWJYVnNYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRVpwZUdWa1VHOXBiblF1YlhWc1gySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVHYVhobFpGQnZhVzUwTG1aeVlXTjBhVzl1S0c1MWJXVnlZWFJ2Y2pvZ1lubDBaWE1zSUdSbGJtOXRhVzVoZEc5eU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrWnBlR1ZrVUc5cGJuUXVabkpoWTNScGIyNDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdhWGhsWkZCdmFXNTBPaUJFU1ZaZlFsbGZXa1ZTVHdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllWFJsWXlBeU1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFp5WVhndWMyOXNMa1pwZUdWa1VHOXBiblF1WkdWamIyUmxNVFEwS0hObGJHWTZJR0o1ZEdWektTQXRQaUJpZVhSbGN5d2dZbmwwWlhNNkNrWnBlR1ZrVUc5cGJuUXVaR1ZqYjJSbE1UUTBPZ29nSUNBZ2NISnZkRzhnTVNBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldNZ01qRWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Vlc1cGMzZGhjRll5VEdsaWNtRnllUzV6YjNKMFZHOXJaVzV6S0hSdmEyVnVRVG9nWW5sMFpYTXNJSFJ2YTJWdVFqb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3pvS1ZXNXBjM2RoY0ZZeVRHbGljbUZ5ZVM1emIzSjBWRzlyWlc1ek9nb2dJQ0FnY0hKdmRHOGdNaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnVlc1cGMzZGhjRll5VEdsaWNtRnllVG9nU1VSRlRsUkpRMEZNWDBGRVJGSkZVMU5GVXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSThDaUFnSUNCa2RYQUtJQ0FnSUdKNklGVnVhWE4zWVhCV01reHBZbkpoY25rdWMyOXlkRlJ2YTJWdWMxOTBaWEp1WVhKNVgyWmhiSE5sUURVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2dwVmJtbHpkMkZ3VmpKTWFXSnlZWEo1TG5OdmNuUlViMnRsYm5OZmRHVnlibUZ5ZVY5dFpYSm5aVUEyT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSjZJRlZ1YVhOM1lYQldNa3hwWW5KaGNua3VjMjl5ZEZSdmEyVnVjMTkwWlhKdVlYSjVYMlpoYkhObFFEZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb0tWVzVwYzNkaGNGWXlUR2xpY21GeWVTNXpiM0owVkc5clpXNXpYM1JsY201aGNubGZiV1Z5WjJWQU9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6SWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVhWE4zWVhCV01reHBZbkpoY25rNklGcEZVazlmUVVSRVVrVlRVd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxkSE4xWWdvS1ZXNXBjM2RoY0ZZeVRHbGljbUZ5ZVM1emIzSjBWRzlyWlc1elgzUmxjbTVoY25sZlptRnNjMlZBT0RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaUJWYm1semQyRndWakpNYVdKeVlYSjVMbk52Y25SVWIydGxibk5mZEdWeWJtRnllVjl0WlhKblpVQTVDZ3BWYm1semQyRndWakpNYVdKeVlYSjVMbk52Y25SVWIydGxibk5mZEdWeWJtRnllVjltWVd4elpVQTFPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdJZ1ZXNXBjM2RoY0ZZeVRHbGljbUZ5ZVM1emIzSjBWRzlyWlc1elgzUmxjbTVoY25sZmJXVnlaMlZBTmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1VmJtbHpkMkZ3VmpKTWFXSnlZWEo1TG5CaGFYSkdiM0lvWm1GamRHOXllVG9nWW5sMFpYTXNJSFJ2YTJWdVFUb2dZbmwwWlhNc0lIUnZhMlZ1UWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVmJtbHpkMkZ3VmpKTWFXSnlZWEo1TG5CaGFYSkdiM0k2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRlZ1YVhOM1lYQldNa3hwWW5KaGNua3VjMjl5ZEZSdmEyVnVjd29nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJWYm1semQyRndWakpNYVdKeVlYSjVMbk52Y25SVWIydGxibk1LSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE5oT1dNMFkyWTVJQzh2SUcxbGRHaHZaQ0FpWjJWMFVHRnBjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXBZV1JrY21WemN5SUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VWVzVwYzNkaGNGWXlUM0poWTJ4bFRHbGljbUZ5ZVM1amRYSnlaVzUwUW14dlkydFVhVzFsYzNSaGJYQW9LU0F0UGlCMWFXNTBOalE2Q2xWdWFYTjNZWEJXTWs5eVlXTnNaVXhwWW5KaGNua3VZM1Z5Y21WdWRFSnNiMk5yVkdsdFpYTjBZVzF3T2dvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCaWVtVnlid29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTWpJZ0x5OGdNSGd3TVRBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ01qSWdMeThnTUhnd01UQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsVnVhWE4zWVhCV01rOXlZV05zWlV4cFluSmhjbmt1WTNWeWNtVnVkRU4xYlhWc1lYUnBkbVZRY21salpYTW9jR0ZwY2pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCaWVYUmxjeXdnZFdsdWREWTBPZ3BWYm1semQyRndWakpQY21GamJHVk1hV0p5WVhKNUxtTjFjbkpsYm5SRGRXMTFiR0YwYVhabFVISnBZMlZ6T2dvZ0lDQWdjSEp2ZEc4Z01TQXpDaUFnSUNCallXeHNjM1ZpSUZWdWFYTjNZWEJXTWs5eVlXTnNaVXhwWW5KaGNua3VZM1Z5Y21WdWRFSnNiMk5yVkdsdFpYTjBZVzF3Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREU0SUM4dklHMWxkR2h2WkNBaWNISnBZMlV3UTNWdGRXeGhkR2wyWlV4aGMzUW9LWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURFNUlDOHZJRzFsZEdodlpDQWljSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1FvS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXlNQ0F2THlCdFpYUm9iMlFnSW1kbGRGSmxjMlZ5ZG1WektDa29kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblEyTkNraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURNeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTXpZZ016SUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ2NIVnphR2x1ZENBMk9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0lUMEtJQ0FnSUdKNklGVnVhWE4zWVhCV01rOXlZV05zWlV4cFluSmhjbmt1WTNWeWNtVnVkRU4xYlhWc1lYUnBkbVZRY21salpYTmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lDMEtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnUm1sNFpXUlFiMmx1ZEM1bWNtRmpkR2x2YmdvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZaW9LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaUt3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1JtbDRaV1JRYjJsdWRDNW1jbUZqZEdsdmJnb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JpS2dvZ0lDQWdZaXNLQ2xWdWFYTjNZWEJXTWs5eVlXTnNaVXhwWW5KaGNua3VZM1Z5Y21WdWRFTjFiWFZzWVhScGRtVlFjbWxqWlhOZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVjMlYwVkdsdFpXeHZZMnRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUlVhVzFsYkc5amF6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2MyVjBWR2x0Wld4dlkydGZZbTl2YkY5MGNuVmxRRE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYVcxbGJHOWphMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0o2SUhObGRGUnBiV1ZzYjJOclgySnZiMnhmWm1Gc2MyVkFOQW9LYzJWMFZHbHRaV3h2WTJ0ZlltOXZiRjkwY25WbFFETTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tjMlYwVkdsdFpXeHZZMnRmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnWVhOelpYSjBJQzh2SUZsdmRTQmhjbVVnYm05MElHRnVJRzkzYm1WeUlHOXlJSFJvWlNCbmIzWmxjbTVoYm1ObElIUnBiV1ZzYjJOckNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHpaWFJVYVcxbGJHOWphMTlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ6WlhSVWFXMWxiRzlqYTE5aWIyOXNYMjFsY21kbFFEVUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVjMlYwVUdWeWFXOWtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFVHVnlhVzlrT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQnpaWFJRWlhKcGIyUmZZbTl2YkY5MGNuVmxRRE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGFXMWxiRzlqYTE5aFpHUnlaWE56SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYVcxbGJHOWphMTloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0o2SUhObGRGQmxjbWx2WkY5aWIyOXNYMlpoYkhObFFEUUtDbk5sZEZCbGNtbHZaRjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwelpYUlFaWEpwYjJSZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ1lYTnpaWEowSUM4dklGbHZkU0JoY21VZ2JtOTBJR0Z1SUc5M2JtVnlJRzl5SUhSb1pTQm5iM1psY201aGJtTmxJSFJwYldWc2IyTnJDaUFnSUNCaWVYUmxZeUEySUM4dklDSlFSVkpKVDBRaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEZCbGNtbHZaRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ6WlhSUVpYSnBiMlJmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExuTmxkRU52Ym5OMWJIUk1aVzVwWlc1amVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEVOdmJuTjFiSFJNWlc1cFpXNWplVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2MyVjBRMjl1YzNWc2RFeGxibWxsYm1ONVgySnZiMnhmZEhKMVpVQXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEdsdFpXeHZZMnRmWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkR2x0Wld4dlkydGZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmllaUJ6WlhSRGIyNXpkV3gwVEdWdWFXVnVZM2xmWW05dmJGOW1ZV3h6WlVBMENncHpaWFJEYjI1emRXeDBUR1Z1YVdWdVkzbGZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYzJWMFEyOXVjM1ZzZEV4bGJtbGxibU41WDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCWmIzVWdZWEpsSUc1dmRDQmhiaUJ2ZDI1bGNpQnZjaUIwYUdVZ1oyOTJaWEp1WVc1alpTQjBhVzFsYkc5amF3b2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lrTlBUbE5WVEZSZlRFVk9TVVZPUTFraUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEVOdmJuTjFiSFJNWlc1cFpXNWplVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ6WlhSRGIyNXpkV3gwVEdWdWFXVnVZM2xmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExuTmxkRUZzYkc5M1UzUmhiR1ZEYjI1emRXeDBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRFRnNiRzkzVTNSaGJHVkRiMjV6ZFd4MGN6b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQnpaWFJCYkd4dmQxTjBZV3hsUTI5dWMzVnNkSE5mWW05dmJGOTBjblZsUURNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBhVzFsYkc5amExOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGFXMWxiRzlqYTE5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKNklITmxkRUZzYkc5M1UzUmhiR1ZEYjI1emRXeDBjMTlpYjI5c1gyWmhiSE5sUURRS0NuTmxkRUZzYkc5M1UzUmhiR1ZEYjI1emRXeDBjMTlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwelpYUkJiR3h2ZDFOMFlXeGxRMjl1YzNWc2RITmZZbTl2YkY5dFpYSm5aVUExT2dvZ0lDQWdZWE56WlhKMElDOHZJRmx2ZFNCaGNtVWdibTkwSUdGdUlHOTNibVZ5SUc5eUlIUm9aU0JuYjNabGNtNWhibU5sSUhScGJXVnNiMk5yQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpUVV4TVQxZGZVMVJCVEVWZlEwOU9VMVZNVkZNaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk5sZEVGc2JHOTNVM1JoYkdWRGIyNXpkV3gwYzE5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCelpYUkJiR3h2ZDFOMFlXeGxRMjl1YzNWc2RITmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGxWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG1OaGJsVndaR0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhibFZ3WkdGMFpUb0tJQ0FnSUdOaGJHeHpkV0lnVlc1cGMzZGhjRll5VDNKaFkyeGxUR2xpY21GeWVTNWpkWEp5Wlc1MFFteHZZMnRVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmliRzlqYTFScGJXVnpkR0Z0Y0V4aGMzUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHSnNiMk5yVkdsdFpYTjBZVzF3VEdGemRDQmxlR2x6ZEhNS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSlFSVkpKVDBRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUZCRlVrbFBSQ0JsZUdsemRITUtJQ0FnSUdJK1BRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1VmJtbHpkMkZ3VUdGcGNrOXlZV05zWlM1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWljR0ZwY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY0dGcGNpQmxlR2x6ZEhNS0lDQWdJR05oYkd4emRXSWdWVzVwYzNkaGNGWXlUM0poWTJ4bFRHbGljbUZ5ZVM1amRYSnlaVzUwUTNWdGRXeGhkR2wyWlZCeWFXTmxjd29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWljR0ZwY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY0dGcGNpQmxlR2x6ZEhNS0lDQWdJR05oYkd4emRXSWdWVzVwYzNkaGNGWXlUM0poWTJ4bFRHbGljbUZ5ZVM1amRYSnlaVzUwUTNWdGRXeGhkR2wyWlZCeWFXTmxjd29nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSndZV2x5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3WVdseUlHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQlZibWx6ZDJGd1ZqSlBjbUZqYkdWTWFXSnlZWEo1TG1OMWNuSmxiblJEZFcxMWJHRjBhWFpsVUhKcFkyVnpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0J1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppYkc5amExUnBiV1Z6ZEdGdGNFeGhjM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR0pzYjJOclZHbHRaWE4wWVcxd1RHRnpkQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpVUVWU1NVOUVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QlFSVkpKVDBRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWVzVwYzNkaGNGQmhhWEpQY21GamJHVTZJRkJGVWtsUFJGOU9UMVJmUlV4QlVGTkZSQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbkJ5YVdObE1FTjFiWFZzWVhScGRtVk1ZWE4wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3Y21salpUQkRkVzExYkdGMGFYWmxUR0Z6ZENCbGVHbHpkSE1LSUNBZ0lHSXRDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlMd29nSUNBZ1lubDBaV01nTWpNZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbkJ5YVdObE1FRjJaWEpoWjJVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWkdsbklEUUtJQ0FnSUdKNWRHVmpJREUxSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSndjbWxqWlRGRGRXMTFiR0YwYVhabFRHRnpkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1FnWlhocGMzUnpDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0l2Q2lBZ0lDQmllWFJsWXlBeU15QXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0p3Y21salpURkJkbVZ5WVdkbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luQnlhV05sTVVOMWJYVnNZWFJwZG1WTVlYTjBJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlteHZZMnRVYVcxbGMzUmhiWEJNWVhOMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVZMjl1YzNWc2RGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52Ym5OMWJIUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZMkZzYkhOMVlpQlZibWx6ZDJGd1ZqSlBjbUZqYkdWTWFXSnlZWEo1TG1OMWNuSmxiblJDYkc5amExUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1Kc2IyTnJWR2x0WlhOMFlXMXdUR0Z6ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWW14dlkydFVhVzFsYzNSaGJYQk1ZWE4wSUdWNGFYTjBjd29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSWxCRlVrbFBSQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dVRVZTU1U5RUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pEVDA1VFZVeFVYMHhGVGtsRlRrTlpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkRUMDVUVlV4VVgweEZUa2xGVGtOWklHVjRhWE4wY3dvZ0lDQWdZaXNLSUNBZ0lHSThDaUFnSUNCaWJub2dZMjl1YzNWc2RGOWliMjlzWDNSeWRXVkFNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSkJURXhQVjE5VFZFRk1SVjlEVDA1VFZVeFVVeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRVXhNVDFkZlUxUkJURVZmUTA5T1UxVk1WRk1nWlhocGMzUnpDaUFnSUNCaWVpQmpiMjV6ZFd4MFgySnZiMnhmWm1Gc2MyVkFOQW9LWTI5dWMzVnNkRjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwamIyNXpkV3gwWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCVmJtbHpkMkZ3VUdGcGNrOXlZV05zWlRvZ1VGSkpRMFZmU1ZOZlUxUkJURVZmVGtWRlJGOVVUMTlEUVV4TVgxVlFSRUZVUlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0owYjJ0bGJqQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZhMlZ1TUNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZMjl1YzNWc2RGOWxiSE5sWDJKdlpIbEFOd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSndjbWxqWlRCQmRtVnlZV2RsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3Y21salpUQkJkbVZ5WVdkbElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdSbWw0WldSUWIybHVkQzV0ZFd3S0lDQWdJSEJ2Y0FvZ0lDQWdZMkZzYkhOMVlpQkdhWGhsWkZCdmFXNTBMbVJsWTI5a1pURTBOQW9nSUNBZ2NHOXdDZ3BqYjI1emRXeDBYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGpiMjV6ZFd4MFgyVnNjMlZmWW05a2VVQTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUzSUM4dklDSjBiMnRsYmpFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmEyVnVNU0JsZUdsemRITUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZWdWFYTjNZWEJRWVdseVQzSmhZMnhsT2lCSlRsWkJURWxFWDFSUFMwVk9DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0luQnlhV05sTVVGMlpYSmhaMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJ5YVdObE1VRjJaWEpoWjJVZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQkdhWGhsWkZCdmFXNTBMbTExYkFvZ0lDQWdjRzl3Q2lBZ0lDQmpZV3hzYzNWaUlFWnBlR1ZrVUc5cGJuUXVaR1ZqYjJSbE1UUTBDaUFnSUNCd2IzQUtJQ0FnSUdJZ1kyOXVjM1ZzZEY5aFpuUmxjbDlwWmw5bGJITmxRRGdLQ21OdmJuTjFiSFJmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWTI5dWMzVnNkRjlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWJtOXRhVzVoZEdWT1pYZFBkMjVsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtNXZiV2x1WVhSbFRtVjNUM2R1WlhJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RHaGxJR052Ym5SeVlXTjBJRzkzYm1WeUlHMWhlU0J3WlhKbWIzSnRJSFJvYVhNZ1lXTjBhVzl1Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p1YjIxcGJtRjBaV1JQZDI1bGNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZakk0TVRJeE9HRWdMeThnYldWMGFHOWtJQ0pQZDI1bGNrNXZiV2x1WVhSbFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJaeVlYZ3ZZMjl1ZEhKaFkzUnpMMFp5WVhndWMyOXNMbFZ1YVhOM1lYQlFZV2x5VDNKaFkyeGxMbUZqWTJWd2RFOTNibVZ5YzJocGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZqWTJWd2RFOTNibVZ5YzJocGNEb0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p1YjIxcGJtRjBaV1JQZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2JtOXRhVzVoZEdWa1QzZHVaWElnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWmIzVWdiWFZ6ZENCaVpTQnViMjFwYm1GMFpXUWdZbVZtYjNKbElIbHZkU0JqWVc0Z1lXTmpaWEIwSUc5M2JtVnljMmhwY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCdmQyNWxjaUJsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1F5WTJObU1qa3dJQzh2SUcxbGRHaHZaQ0FpVDNkdVpYSkRhR0Z1WjJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzZHVaWElpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ055QXZMeUFpYm05dGFXNWhkR1ZrVDNkdVpYSWlDaUFnSUNCaWVYUmxZMTh5SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVVRVZTU1U5RVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tVRVZTU1U5RU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSWxCRlVrbFBSQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dVRVZTU1U5RUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1UTA5T1UxVk1WRjlNUlU1SlJVNURXVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2tOUFRsTlZURlJmVEVWT1NVVk9RMWs2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJa05QVGxOVlRGUmZURVZPU1VWT1Exa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFTlBUbE5WVEZSZlRFVk9TVVZPUTFrZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bWNtRjRMMk52Ym5SeVlXTjBjeTlHY21GNExuTnZiQzVWYm1semQyRndVR0ZwY2s5eVlXTnNaUzVCVEV4UFYxOVRWRUZNUlY5RFQwNVRWVXhVVTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNrRk1URTlYWDFOVVFVeEZYME5QVGxOVlRGUlRPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSkJURXhQVjE5VFZFRk1SVjlEVDA1VFZVeFVVeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRVXhNVDFkZlUxUkJURVZmUTA5T1UxVk1WRk1nWlhocGMzUnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMlp5WVhndlkyOXVkSEpoWTNSekwwWnlZWGd1YzI5c0xsVnVhWE4zWVhCUVlXbHlUM0poWTJ4bExuQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0hKcFkyVXdRM1Z0ZFd4aGRHbDJaVXhoYzNRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY0hKcFkyVXdRM1Z0ZFd4aGRHbDJaVXhoYzNRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhCeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOMElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdlpuSmhlQzlqYjI1MGNtRmpkSE12Um5KaGVDNXpiMnd1Vlc1cGMzZGhjRkJoYVhKUGNtRmpiR1V1Y0hKcFkyVXhRM1Z0ZFd4aGRHbDJaVXhoYzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdjbWxqWlRGRGRXMTFiR0YwYVhabFRHRnpkRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJ5YVdObE1VTjFiWFZzWVhScGRtVk1ZWE4wSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW14dlkydFVhVzFsYzNSaGJYQk1ZWE4wT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUpzYjJOclZHbHRaWE4wWVcxd1RHRnpkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTltY21GNEwyTnZiblJ5WVdOMGN5OUdjbUY0TG5OdmJDNVZibWx6ZDJGd1VHRnBjazl5WVdOc1pTNXdjbWxqWlRCQmRtVnlZV2RsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NISnBZMlV3UVhabGNtRm5aVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWljSEpwWTJVd1FYWmxjbUZuWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY0hKcFkyVXdRWFpsY21GblpTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZabkpoZUM5amIyNTBjbUZqZEhNdlJuSmhlQzV6YjJ3dVZXNXBjM2RoY0ZCaGFYSlBjbUZqYkdVdWNISnBZMlV4UVhabGNtRm5aVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CeWFXTmxNVUYyWlhKaFoyVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0luQnlhV05sTVVGMlpYSmhaMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEJ5YVdObE1VRjJaWEpoWjJVZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyWnlZWGd2WTI5dWRISmhZM1J6TDBaeVlYZ3VjMjlzTGxWdWFYTjNZWEJRWVdseVQzSmhZMnhsTG05M2JtVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNkdVpYSTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRzkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OW1jbUY0TDJOdmJuUnlZV04wY3k5R2NtRjRMbk52YkM1VmJtbHpkMkZ3VUdGcGNrOXlZV05zWlM1dWIyMXBibUYwWldSUGQyNWxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q201dmJXbHVZWFJsWkU5M2JtVnlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltNXZiV2x1WVhSbFpFOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ1YjIxcGJtRjBaV1JQZDI1bGNpQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Wm5KaGVDOWpiMjUwY21GamRITXZSbkpoZUM1emIyd3VWVzVwYzNkaGNGQmhhWEpQY21GamJHVXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRWdCaVlZQkJVZmZIVUZiM2R1WlhJZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUhScGJXVnNiMk5yWDJGa1pISmxjM01TWW14dlkydFVhVzFsYzNSaGJYQk1ZWE4wQmxCRlVrbFBSQTV1YjIxcGJtRjBaV1JQZDI1bGNnUndZV2x5RkhCeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOMEZIQnlhV05sTVVOMWJYVnNZWFJwZG1WTVlYTjBFRU5QVGxOVlRGUmZURVZPU1VWT1Exa1VRVXhNVDFkZlUxUkJURVZmUTA5T1UxVk1WRk1OY0hKcFkyVXdRWFpsY21GblpRMXdjbWxqWlRGQmRtVnlZV2RsSVFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVowYjJ0bGJqQUdkRzlyWlc0eEJFdm93cUlFa0hwV2dRUVVReWFUSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVFBQUFBQUFBQUFBQUFBQUFBQUFCUUVBQUFBQUhQLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vOGlTVEVZUUFFOUtTcG5Kd2NxWnljRUttZUJrQndXSndaTVo0RjRGaWNMVEdjbkRDSm5Kd2dxWnljUUttY25FU3BuSndrclp5Y0tLMmNuQlNKbkp3MHJaeWNPSzJjMkdnQTJHZ0UyR2dJMkdnTTJHZ1JGQmtrcUUwUXBTd0ZuZ0NUU3pQS1FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTVVMQ0lBZThuQ0VzQlo3R0JHRnNsc2hBaXNoa2lzZ0ZKc2hpQUJHTVlSZU95R3JPMFBsY0VBQ2NRVEdleEpiSVFJcklaSXJJQlNiSVlnQVNsREpTWnNocXp0RDVYQkFBbkVVeG5zU1d5RUNLeUdTS3lBVW15R0NjU3NocXp0RDVYQkFBbkNVeG5zU1d5RUNLeUdTS3lBVW15R0NjVHNocXp0RDVYQkFBbkNreG5zU1d5RUNLeUdTS3lBYklZSnhTeUdyTzBQbGNFSUxRK1Z5UWdSUUswUG9GRVd5Y0ZUR2NycVVFQUQwa3JxVUVBQ1NORUp3UkxBbWNqUXlKQy8vUXhHUlJFTVJoRWdnd0VxdnV3aXdTaCtycWVCQlNPTzA4RW5RTDdRUVIrMFkxU0JLRG9HSElFTFRIOHRRUTYwNkVEQk5VaDFnUUVlTTI2WlFSbFhlTFNCTTZUY3k4bkVpY1RnZ1VFY2FjeFlRUzhnVzFwQkZTRGxmNEVzYnV3cUFSOUx6VmNOaG9BamhNQm5BSEdBZkFDR2dKR0FtTUM2UU5qQTRNRHFBTzdBODRENEFQekJBWUVFZ1FkQkNnRU1nQ0tBZ0lyaS84cnFFQUFFNHYrVndBZ1NZdi9vMG1NQUl2L29xaEJBQkVqUklzQVNSVWtEa1FrcjZ1TC9rOENpU0pDLyt5S0FnR0wveXVsUkl2K0p4V2ppLytpU1JVa0RrUWtyNnVKaWdFQ2kvOVhBQ0FuRmFLQUV2Ly8vLy8vLy8vLy8vLy8vLy8vLy8vLy82eUwvNG1LQWdJaWkvNkwveE5FaS82TC82UkpRUUFjaS82TUFJc0JRUUFPaS8rTEFFa3FFMFJNVHdOUEE0bUwva0wvNzR2L2pBQkMvK0dLQXdHTC9vdi9pUC9BU0l2K2kvK0kvN2hGQWJHTC9ZRVlXeVd5RUNLeUdTS3lBYklZZ0FRNm5FejVzaHBNc2hxeUdyTzBQbGNFQUltQkNLOHlCeFluRnFwTEFVeFFNZ2NXSnhhcVR3Sk1VQldCQ0FsYmlZb0JBNGovM1VteGkvK0JHRnNsc2hBaXNoa2lzZ0ZKc2hnbkVySWFzN1ErVndRQVRnS3hKYklRSXJJWklySUJTYklZSnhPeUdyTzBQbGNFQUU0Q3NTV3lFQ0t5R1NLeUFiSVlKeFN5R3JPMFBsY0VJRTRDdEQ1WEpDQk9BclErZ1VSYlNVNERFMEVBSzRzQWl3UUppd05KVGdLTEFrbE9BNGordlZjQUlFd1dURXNCbzRzQm9Jd0JURThDaVA2cFZ3QWdvNkNMQVV5TEFJd0NqQUdNQUlrMkdnRkpGU1FTUkRFQUlpbGxSQkpBQUFzeEFDSW5CR1ZFRWtFQUNTTkVKd1JMQVdjalF5SkMvL1EyR2dGSkZTUVNSREVBSWlsbFJCSkFBQXN4QUNJbkJHVkVFa0VBQ1NORUp3WkxBV2NqUXlKQy8vUTJHZ0ZKRlNRU1JERUFJaWxsUkJKQUFBc3hBQ0luQkdWRUVrRUFDU05FSnd0TEFXY2pReUpDLy9RMkdnRkpGU01TUkNKVE1RQWlLV1ZFRWtBQUN6RUFJaWNFWlVRU1FRQUpJMFFuREVzQlp5TkRJa0wvOUlqK2xpSW5CV1ZFQ1JZaUp3WmxSS2VBQVFBaVR3SlVLRXhRc0NORElpY0laVVNJL3BGR0FpSW5DR1ZFaVA2SFNFNENTQ0luQ0dWRWlQNTdUZ0pHQWlJbkJXVkVTd0ZNQ1JZaUp3WmxSRXNCcGtSTEFpY1BvQ0luQ1dWRW9TY1Bxa3NCb2ljWHJFa1ZKQTVFSks5TVN3R3JKdzFNWjBzRUp3K2dJaWNLWlVTaEp3K3FUd0tpSnhlc1NSVWtEa1NySnc1TVp5Y0pUd0puSndwUEFtY25CVXhuSTBNMkdnRkpGU1FTUkRZYUFra1ZKQkpFaVAzaklpY0ZaVVFKRmlJbkJtVkVJaWNMWlVTZ3BFQUFDQ0luREdWRVFRQkZJMFFpSnhCbFJFc0NFa0VBSFNJbkRXVkVTd0dJL05CSWlQMFlTRWtWSkE1RUpLK3JLRXhRc0NORElpY1JaVVJMQWhKRUlpY09aVVJMQVlqOHFraUkvUEpJUXYvWElrTC91RFlhQVVrVkpCSkVNUUFpS1dWRUVrUW5CMHNCWjRBRXNvRWhpa3hRc0NORE1RQWlKd2RsUkV4TEFSSkVJaWxsUkVzQlVJQUUwc3p5a0V4UXNDbE1aeWNIS21jalF5SW5CbVZFU1JVa0RrUWtyNnNvVEZDd0kwTWlKd3RsUkVrVkpBNUVKSytyS0V4UXNDTkRJaWNNWlVTQUFRQWlUd0pVS0V4UXNDTkRJaWNKWlVSSkZTUU9SQ1N2cXloTVVMQWpReUluQ21WRVNSVWtEa1FrcjZzb1RGQ3dJME1pSndWbFJCWW9URkN3STBNaUp3MWxSQ2hNVUxBalF5SW5EbVZFS0V4UXNDTkRJaWxsUkNoTVVMQWpReUluQjJWRUtFeFFzQ05EIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiT3duZXJOb21pbmF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik93bmVyQ2hhbmdlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvbGRPd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
