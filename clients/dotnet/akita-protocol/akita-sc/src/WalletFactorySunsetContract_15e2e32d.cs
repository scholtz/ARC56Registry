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

namespace Arc56.Generated.akita_protocol.akita_sc.WalletFactorySunsetContract_15e2e32d
{


    //
    // Final approval for the ARC58 wallet factory during protocol sunset.
    //
    //The factory is the creator of DAO wallet apps, so this keeps just enough of
    //the old factory behavior alive to push the already-boxed SunsetContract into
    //the DAO wallet and then call the wallet's sunset cleanup methods as creator.
    //
    public class WalletFactorySunsetContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public WalletFactorySunsetContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CloseOutWalletArgCloses : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static CloseOutWalletArgCloses Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CloseOutWalletArgCloses();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CloseOutWalletArgCloses);
                }
                public bool Equals(CloseOutWalletArgCloses? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CloseOutWalletArgCloses left, CloseOutWalletArgCloses right)
                {
                    return EqualityComparer<CloseOutWalletArgCloses>.Default.Equals(left, right);
                }
                public static bool operator !=(CloseOutWalletArgCloses left, CloseOutWalletArgCloses right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task UpdateWallet(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 226, 47, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateWallet_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 226, 47, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="boxes"> </param>
        public async Task DeleteWalletBoxes(ulong wallet, byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 161, 5, 52 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>(); boxesAbi.From(boxes);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteWalletBoxes_Transactions(ulong wallet, byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 161, 5, 52 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>(); boxesAbi.From(boxes);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="closes"> CloseOutWalletArgCloses</param>
        public async Task CloseOutWallet(ulong wallet, Structs.CloseOutWalletArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 203, 153, 99 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutWalletArgCloses>(x => Structs.CloseOutWalletArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseOutWallet_Transactions(ulong wallet, Structs.CloseOutWalletArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 203, 153, 99 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutWalletArgCloses>(x => Structs.CloseOutWalletArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="assets"> </param>
        public async Task DeleteWalletAssets(ulong wallet, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 39, 225, 136 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteWalletAssets_Transactions(ulong wallet, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 39, 225, 136 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="escrowFactory"> </param>
        /// <param name="escrowIds"> </param>
        public async Task DeleteWalletEscrows(ulong wallet, ulong escrowFactory, ulong[] escrowIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 48, 60, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var escrowFactoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowFactoryAbi.From(escrowFactory);
            var escrowIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); escrowIdsAbi.From(escrowIds);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, escrowFactoryAbi, escrowIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteWalletEscrows_Transactions(ulong wallet, ulong escrowFactory, ulong[] escrowIds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 48, 60, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var escrowFactoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowFactoryAbi.From(escrowFactory);
            var escrowIdsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); escrowIdsAbi.From(escrowIds);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, escrowFactoryAbi, escrowIdsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="closeRemainderTo"> </param>
        public async Task DeleteWallet(ulong wallet, Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 5, 57, 38 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteWallet_Transactions(ulong wallet, Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 5, 57, 38 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteBoxedContract(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 70, 177, 164 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxedContract_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 70, 177, 164 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="boxes"> </param>
        public async Task DeleteBoxes(byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 253, 101, 167 };
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>(); boxesAbi.From(boxes);

            var result = await base.CallApp(new List<object> { abiHandle, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxes_Transactions(byte[][] boxes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 253, 101, 167 };
            var boxesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>(); boxesAbi.From(boxes);

            return await base.MakeTransactionList(new List<object> { abiHandle, boxesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="closes"> CloseOutWalletArgCloses</param>
        public async Task CloseOut(Structs.CloseOutWalletArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 37, 234, 217 };
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutWalletArgCloses>(x => Structs.CloseOutWalletArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            var result = await base.CallApp(new List<object> { abiHandle, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseOut_Transactions(Structs.CloseOutWalletArgCloses[] closes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 37, 234, 217 };
            var closesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CloseOutWalletArgCloses>(x => Structs.CloseOutWalletArgCloses.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; closesAbi.From(closes);

            return await base.MakeTransactionList(new List<object> { abiHandle, closesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task DeleteAssets(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 216, 16, 20 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteAssets_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 216, 16, 20 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="closeRemainderTo"> </param>
        public async Task Delete(Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 139, 33, 58 };
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            var result = await base.CallApp(new List<object> { abiHandle, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Algorand.Address closeRemainderTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 139, 33, 58 };
            var closeRemainderToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); closeRemainderToAbi.From(closeRemainderTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, closeRemainderToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiV2FsbGV0RmFjdG9yeVN1bnNldENvbnRyYWN0IiwiZGVzYyI6IkZpbmFsIGFwcHJvdmFsIGZvciB0aGUgQVJDNTggd2FsbGV0IGZhY3RvcnkgZHVyaW5nIHByb3RvY29sIHN1bnNldC5cblxuVGhlIGZhY3RvcnkgaXMgdGhlIGNyZWF0b3Igb2YgREFPIHdhbGxldCBhcHBzLCBzbyB0aGlzIGtlZXBzIGp1c3QgZW5vdWdoIG9mXG50aGUgb2xkIGZhY3RvcnkgYmVoYXZpb3IgYWxpdmUgdG8gcHVzaCB0aGUgYWxyZWFkeS1ib3hlZCBTdW5zZXRDb250cmFjdCBpbnRvXG50aGUgREFPIHdhbGxldCBhbmQgdGhlbiBjYWxsIHRoZSB3YWxsZXQncyBzdW5zZXQgY2xlYW51cCBtZXRob2RzIGFzIGNyZWF0b3IuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNsb3NlT3V0V2FsbGV0QXJnQ2xvc2VzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InVwZGF0ZVdhbGxldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlV2FsbGV0Qm94ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsb3NlT3V0V2FsbGV0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0KVtdIiwic3RydWN0IjoiQ2xvc2VPdXRXYWxsZXRBcmdDbG9zZXMiLCJuYW1lIjoiY2xvc2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZVdhbGxldEFzc2V0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZVdhbGxldEVzY3Jvd3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dGYWN0b3J5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd0lkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVXYWxsZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xvc2VSZW1haW5kZXJUbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hlZENvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUJveGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm94ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2VPdXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0KVtdIiwic3RydWN0IjoiQ2xvc2VPdXRXYWxsZXRBcmdDbG9zZXMiLCJuYW1lIjoiY2xvc2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFzc2V0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsb3NlUmVtYWluZGVyVG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTYyXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1Ml0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc5XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMSw2MjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxLDMzNSwzOTYsNDQ1LDUwMiw1OTgsNjQyLDcxNiw3ODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTQsODAwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhc3NldD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTUsNjYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxieXRlcz4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDYsNzI4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxzbWFydF9jb250cmFjdHMvc3Vuc2V0L3R5cGVzLnRzOjpBc3NldENsb3NlUGFyYW1zPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MSw4NTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0LDI4MywzODksNDM4LDQ4Nyw0OTYsNTUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI5LDYzNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyhsZW4rdWludDhbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0NBME1EazJDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmlZeUlnTUhoaFlqaGlNakV6WVNBd2VEazRabVEyTldFM0lEQjRPVFl5TldWaFpEa2dNSGhqTjJRNE1UQXhOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1YyRnNiR1YwUm1GamRHOXllVk4xYm5ObGRFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREU1Q2lBZ0lDQmllWFJsWTE4eElDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbEtHRmtaSEpsYzNNcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZaR1ZzWlhSbFgzSnZkWFJsUURNS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWMkZzYkdWMFJtRmpkRzl5ZVZOMWJuTmxkRU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNREZsTWpKbU0yWWdNSGd6WldFeE1EVXpOQ0F3ZUdFMFkySTVPVFl6SURCNFlqWXlOMlV4T0RnZ01IZzJORE13TTJNelppQXdlR1ppTURVek9USTJJREI0WkRNME5tSXhZVFFnTHk4Z2JXVjBhRzlrSUNKMWNHUmhkR1ZYWVd4c1pYUW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGJHVjBaVmRoYkd4bGRFSnZlR1Z6S0hWcGJuUTJOQ3hpZVhSbFcxMWJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmpiRzl6WlU5MWRGZGhiR3hsZENoMWFXNTBOalFzS0dGa1pISmxjM01zZFdsdWREWTBLVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsYkdWMFpWZGhiR3hsZEVGemMyVjBjeWgxYVc1ME5qUXNkV2x1ZERZMFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVnNaWFJsVjJGc2JHVjBSWE5qY205M2N5aDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJORnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsYkdWMFpWZGhiR3hsZENoMWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmtaV3hsZEdWQ2IzaGxaRU52Ym5SeVlXTjBLQ2wyYjJsa0lnb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSW1SbGJHVjBaVUp2ZUdWektHSjVkR1ZiWFZ0ZEtYWnZhV1FpQ2lBZ0lDQmllWFJsWTE4eklDOHZJRzFsZEdodlpDQWlZMnh2YzJWUGRYUW9LR0ZrWkhKbGMzTXNkV2x1ZERZMEtWdGRLWFp2YVdRaUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxRWE56WlhSektIVnBiblEyTkZ0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCMWNHUmhkR1ZYWVd4c1pYUWdaR1ZzWlhSbFYyRnNiR1YwUW05NFpYTWdZMnh2YzJWUGRYUlhZV3hzWlhRZ1pHVnNaWFJsVjJGc2JHVjBRWE56WlhSeklHUmxiR1YwWlZkaGJHeGxkRVZ6WTNKdmQzTWdaR1ZzWlhSbFYyRnNiR1YwSUcxaGFXNWZaR1ZzWlhSbFFtOTRaV1JEYjI1MGNtRmpkRjl5YjNWMFpVQXhNaUJrWld4bGRHVkNiM2hsY3lCamJHOXpaVTkxZENCa1pXeGxkR1ZCYzNObGRITUtJQ0FnSUdWeWNnb0tiV0ZwYmw5a1pXeGxkR1ZDYjNobFpFTnZiblJ5WVdOMFgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QmliM2hsWkVOdmJuUnlZV04wSUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ1FtOTRTMlY1UW05NFpXUkRiMjUwY21GamRDQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbU1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCMGFHbHpMbUp2ZUdWa1EyOXVkSEpoWTNRdVpHVnNaWFJsS0NrS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qRXdOUW9nSUNBZ0x5OGdaR1ZzWlhSbFFtOTRaV1JEYjI1MGNtRmpkQ2dwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaR1ZzWlhSbFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk1USTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMFJsYkdWMFpVRndjR3hwWTJGMGFXOXVKMTBnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QkVaV3hsZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlHUmxiR1YwWlFvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlhZV3hzWlhSR1lXTjBiM0o1VTNWdWMyVjBRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6bzZWMkZzYkdWMFJtRmpkRzl5ZVZOMWJuTmxkRU52Ym5SeVlXTjBMblZ3WkdGMFpWZGhiR3hsZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlZkaGJHeGxkRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSFZ3WkdGMFpWZGhiR3hsZENoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR0p2ZUdWa1EyOXVkSEpoWTNRZ1BTQkNiM2c4WW5sMFpYTStLSHNnYTJWNU9pQkNiM2hMWlhsQ2IzaGxaRU52Ym5SeVlXTjBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppWXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZkMkZzYkdWMExXWmhZM1J2Y25rdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1kyOXVjM1FnWVhCd2NtOTJZV3hUYVhwbE9pQjFhVzUwTmpRZ1BTQjBhR2x6TG1KdmVHVmtRMjl1ZEhKaFkzUXViR1Z1WjNSb0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnYVdZZ0tHRndjSEp2ZG1Gc1UybDZaU0ErSUUxQldGOUJWazFmUWxsVVJWOUJVbEpCV1Y5TVJVNUhWRWdwSUhzS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0ErQ2lBZ0lDQmllaUIxY0dSaGRHVlhZV3hzWlhSZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdZbTk0WldSRGIyNTBjbUZqZENBOUlFSnZlRHhpZVhSbGN6NG9leUJyWlhrNklFSnZlRXRsZVVKdmVHVmtRMjl1ZEhKaFkzUWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUpqSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCamFIVnVhekVnUFNCMGFHbHpMbUp2ZUdWa1EyOXVkSEpoWTNRdVpYaDBjbUZqZENnd0xDQk5RVmhmUVZaTlgwSlpWRVZmUVZKU1FWbGZURVZPUjFSSUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHTm9kVzVyTWlBOUlIUm9hWE11WW05NFpXUkRiMjUwY21GamRDNWxlSFJ5WVdOMEtFMUJXRjlCVmsxZlFsbFVSVjlCVWxKQldWOU1SVTVIVkVnc0lHRndjSEp2ZG1Gc1UybDZaU0F0SUUxQldGOUJWazFmUWxsVVJWOUJVbEpCV1Y5TVJVNUhWRWdwQ2lBZ0lDQnBiblJqSURRZ0x5OGdOREE1TmdvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJpYjNobFpFTnZiblJ5WVdOMElEMGdRbTk0UEdKNWRHVnpQaWg3SUd0bGVUb2dRbTk0UzJWNVFtOTRaV1JEYjI1MGNtRmpkQ0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHTm9kVzVyTWlBOUlIUm9hWE11WW05NFpXUkRiMjUwY21GamRDNWxlSFJ5WVdOMEtFMUJXRjlCVmsxZlFsbFVSVjlCVWxKQldWOU1SVTVIVkVnc0lHRndjSEp2ZG1Gc1UybDZaU0F0SUUxQldGOUJWazFmUWxsVVJWOUJVbEpCV1Y5TVJVNUhWRWdwQ2lBZ0lDQnBiblJqSURRZ0x5OGdOREE1TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb0tkWEJrWVhSbFYyRnNiR1YwWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem8xTlMwMk1Rb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVdKemRISmhZM1JsWkVGalkyOTFiblJWY0dSaGRHVlRkSFZpTG5CeWIzUnZkSGx3WlM1MWNHUmhkR1UrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhkaGJHeGxkQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXM1JvYVhNdVkyaHBiR1JEYjI1MGNtRmpkRlpsY25OcGIyNHVkbUZzZFdWZExBb2dJQ0FnTHk4Z0lDQnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VlhCa1lYUmxRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUdGd2NISnZkbUZzVUhKdlozSmhiVG9nVzJOb2RXNXJNU3dnWTJoMWJtc3lYU3dLSUNBZ0lDOHZJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUdOdmJYQnBiR1ZCY21NMEtGTjFibk5sZEVOdmJuUnlZV04wS1M1amJHVmhjbE4wWVhSbFVISnZaM0poYlN3S0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUdGeVozTTZJRnQwYUdsekxtTm9hV3hrUTI5dWRISmhZM1JXWlhKemFXOXVMblpoYkhWbFhTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklHTm9hV3hrUTI5dWRISmhZM1JXWlhKemFXOXVJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGloN0lHdGxlVG9nUW1GelpVWmhZM1J2Y25sSGJHOWlZV3hUZEdGMFpVdGxlVU5vYVd4a1EyOXVkSEpoWTNSV1pYSnphVzl1SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1Ob2FXeGtYMk52Ym5SeVlXTjBYM1psY25OcGIyNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR0Z5WjNNNklGdDBhR2x6TG1Ob2FXeGtRMjl1ZEhKaFkzUldaWEp6YVc5dUxuWmhiSFZsWFN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nWTI5dGNHbHNaVUZ5WXpRb1UzVnVjMlYwUTI5dWRISmhZM1FwTG1Oc1pXRnlVM1JoZEdWUWNtOW5jbUZ0TEFvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVMk5DaERORVZDVVhjOVBTa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeGxZWEpUZEdGMFpWQnliMmR5WVcxUVlXZGxjd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3Y205MllXeFFjbTluY21GdFVHRm5aWE1LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3Y205MllXeFFjbTluY21GdFVHRm5aWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnYjI1RGIyMXdiR1YwYVc5dU9pQlBia052YlhCc1pYUmxRV04wYVc5dUxsVndaR0YwWlVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qVTFMVFl4Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQkJZbk4wY21GamRHVmtRV05qYjNWdWRGVndaR0YwWlZOMGRXSXVjSEp2ZEc5MGVYQmxMblZ3WkdGMFpUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmRHaHBjeTVqYUdsc1pFTnZiblJ5WVdOMFZtVnljMmx2Ymk1MllXeDFaVjBzQ2lBZ0lDQXZMeUFnSUc5dVEyOXRjR3hsZEdsdmJqb2dUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNVZjR1JoZEdWQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdZWEJ3Y205MllXeFFjbTluY21GdE9pQmJZMmgxYm1zeExDQmphSFZ1YXpKZExBb2dJQ0FnTHk4Z0lDQmpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJUb2dZMjl0Y0dsc1pVRnlZelFvVTNWdWMyVjBRMjl1ZEhKaFkzUXBMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1ZoT1RFNE1HUmtJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxLSE4wY21sdVp5bDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUIxY0dSaGRHVlhZV3hzWlhRb2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkWEJrWVhSbFYyRnNiR1YwWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QmliM2hsWkVOdmJuUnlZV04wSUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ1FtOTRTMlY1UW05NFpXUkRiMjUwY21GamRDQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbU1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUdOb2RXNXJNU0E5SUhSb2FYTXVZbTk0WldSRGIyNTBjbUZqZEM1bGVIUnlZV04wS0RBc0lHRndjSEp2ZG1Gc1UybDZaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkWEo1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZkMkZzYkdWMExXWmhZM1J2Y25rdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1kyaDFibXN5SUQwZ1FubDBaWE1vSnljcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR0lnZFhCa1lYUmxWMkZzYkdWMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem82VjJGc2JHVjBSbUZqZEc5eWVWTjFibk5sZEVOdmJuUnlZV04wTG1SbGJHVjBaVmRoYkd4bGRFSnZlR1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsVjJGc2JHVjBRbTk0WlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklHUmxiR1YwWlZkaGJHeGxkRUp2ZUdWektIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNJR0p2ZUdWek9pQmllWFJsYzF0ZEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncGtaV3hsZEdWWFlXeHNaWFJDYjNobGMxOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUdSbGJHVjBaVmRoYkd4bGRFSnZlR1Z6S0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lHSnZlR1Z6T2lCaWVYUmxjMXRkS1RvZ2RtOXBaQ0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQmtaV3hsZEdWWFlXeHNaWFJDYjNobGMxOWhablJsY2w5bWIzSkFOQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTndvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdadmNpQW9iR1Z1S3loc1pXNHJkV2x1ZERoYlhTbGJYU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR1JsYkdWMFpWZGhiR3hsZEVKdmVHVnpYMlp2Y2w5b1pXRmtaWEpBTVFvS1pHVnNaWFJsVjJGc2JHVjBRbTk0WlhOZllXWjBaWEpmWm05eVFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJR1JsYkdWMFpWZGhiR3hsZEVKdmVHVnpLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzSUdKdmVHVnpPaUJpZVhSbGMxdGRLVG9nZG05cFpDQjdDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WW5sMFpYTStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZOalV0TmprS0lDQWdJQzh2SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRk4xYm5ObGRFTnZiblJ5WVdOMExuQnliM1J2ZEhsd1pTNWtaV3hsZEdWQ2IzaGxjejRvZXdvZ0lDQWdMeThnSUNCelpXNWtaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlltOTRaWE5kTEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnYzJWdVpHVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2FXY2dOd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qWTFMVFk1Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVpHVnNaWFJsUW05NFpYTStLSHNLSUNBZ0lDOHZJQ0FnYzJWdVpHVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJKdmVHVnpYU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbFFtOTRaWE1vWW5sMFpWdGRXMTBwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk5qUUtJQ0FnSUM4dklHUmxiR1YwWlZkaGJHeGxkRUp2ZUdWektIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNJR0p2ZUdWek9pQmllWFJsYzF0ZEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pwWFlXeHNaWFJHWVdOMGIzSjVVM1Z1YzJWMFEyOXVkSEpoWTNRdVkyeHZjMlZQZFhSWFlXeHNaWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamJHOXpaVTkxZEZkaGJHeGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnWTJ4dmMyVlBkWFJYWVd4c1pYUW9kMkZzYkdWME9pQkJjSEJzYVdOaGRHbHZiaXdnWTJ4dmMyVnpPaUJCYzNObGRFTnNiM05sVUdGeVlXMXpXMTBwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4YzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTBlWEJsY3k1MGN6bzZRWE56WlhSRGJHOXpaVkJoY21GdGN6NEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6bzNNeTAzTndvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1Z1YzJWMFEyOXVkSEpoWTNRdWNISnZkRzkwZVhCbExtTnNiM05sVDNWMFBpaDdDaUFnSUNBdkx5QWdJSE5sYm1SbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRqYkc5elpYTmRMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdjMlZ1WkdWeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6bzNNeTAzTndvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdVM1Z1YzJWMFEyOXVkSEpoWTNRdWNISnZkRzkwZVhCbExtTnNiM05sVDNWMFBpaDdDaUFnSUNBdkx5QWdJSE5sYm1SbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRqYkc5elpYTmRMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdiV1YwYUc5a0lDSmpiRzl6WlU5MWRDZ29ZV1JrY21WemN5eDFhVzUwTmpRcFcxMHBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnWTJ4dmMyVlBkWFJYWVd4c1pYUW9kMkZzYkdWME9pQkJjSEJzYVdOaGRHbHZiaXdnWTJ4dmMyVnpPaUJCYzNObGRFTnNiM05sVUdGeVlXMXpXMTBwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZPbGRoYkd4bGRFWmhZM1J2Y25sVGRXNXpaWFJEYjI1MGNtRmpkQzVrWld4bGRHVlhZV3hzWlhSQmMzTmxkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1ZYWVd4c1pYUkJjM05sZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklHUmxiR1YwWlZkaGJHeGxkRUZ6YzJWMGN5aDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0JoYzNObGRITTZJRUZ6YzJWMFcxMHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z6YzJWMFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qZ3hMVGcxQ2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVpHVnNaWFJsUVhOelpYUnpQaWg3Q2lBZ0lDQXZMeUFnSUhObGJtUmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0aGMzTmxkSE5kTEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnYzJWdVpHVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem80TVMwNE5Rb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnVTNWdWMyVjBRMjl1ZEhKaFkzUXVjSEp2ZEc5MGVYQmxMbVJsYkdWMFpVRnpjMlYwY3o0b2V3b2dJQ0FnTHk4Z0lDQnpaVzVrWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJZWE56WlhSelhTd0tJQ0FnSUM4dklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklHMWxkR2h2WkNBaVpHVnNaWFJsUVhOelpYUnpLSFZwYm5RMk5GdGRLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUdSbGJHVjBaVmRoYkd4bGRFRnpjMlYwY3loM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQmhjM05sZEhNNklFRnpjMlYwVzEwcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02T2xkaGJHeGxkRVpoWTNSdmNubFRkVzV6WlhSRGIyNTBjbUZqZEM1a1pXeGxkR1ZYWVd4c1pYUkZjMk55YjNkelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFYyRnNiR1YwUlhOamNtOTNjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem80T0FvZ0lDQWdMeThnWkdWc1pYUmxWMkZzYkdWMFJYTmpjbTkzY3loM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQmxjMk55YjNkR1lXTjBiM0o1T2lCQmNIQnNhV05oZEdsdmJpd2daWE5qY205M1NXUnpPaUIxYVc1ME5qUmJYU2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGRXbHVkRFkwUGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pnNUxUa3pDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCVGRXNXpaWFJEYjI1MGNtRmpkQzV3Y205MGIzUjVjR1V1WkdWc1pYUmxSWE5qY205M2N6NG9ld29nSUNBZ0x5OGdJQ0J6Wlc1a1pYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWlhOamNtOTNSbUZqZEc5eWVTd2daWE5qY205M1NXUnpYU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJSE5sYm1SbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZPRGt0T1RNS0lDQWdJQzh2SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRk4xYm5ObGRFTnZiblJ5WVdOMExuQnliM1J2ZEhsd1pTNWtaV3hsZEdWRmMyTnliM2R6UGloN0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIzWVd4c1pYUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGxjMk55YjNkR1lXTjBiM0o1TENCbGMyTnliM2RKWkhOZExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTBNVFkzWldVM0lDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbFJYTmpjbTkzY3loMWFXNTBOalFzZFdsdWREWTBXMTBwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJR1JsYkdWMFpWZGhiR3hsZEVWelkzSnZkM01vZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3Z1pYTmpjbTkzUm1GamRHOXllVG9nUVhCd2JHbGpZWFJwYjI0c0lHVnpZM0p2ZDBsa2N6b2dkV2x1ZERZMFcxMHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk9sZGhiR3hsZEVaaFkzUnZjbmxUZFc1elpYUkRiMjUwY21GamRDNWtaV3hsZEdWWFlXeHNaWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1ZYWVd4c1pYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR1JsYkdWMFpWZGhiR3hsZENoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk9UY3RNVEF5Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQlRkVzV6WlhSRGIyNTBjbUZqZEM1d2NtOTBiM1I1Y0dVdVpHVnNaWFJsUGloN0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIzWVd4c1pYUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGpiRzl6WlZKbGJXRnBibVJsY2xSdlhTd0tJQ0FnSUM4dklDQWdiMjVEYjIxd2JHVjBhVzl1T2lCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGtSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1TEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkVzV6WlhRdmQyRnNiR1YwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem81T0FvZ0lDQWdMeThnYzJWdVpHVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUJ2YmtOdmJYQnNaWFJwYjI0NklFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZkMkZzYkdWMExXWmhZM1J2Y25rdVlXeG5ieTUwY3pvNU55MHhNRElLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlGTjFibk5sZEVOdmJuUnlZV04wTG5CeWIzUnZkSGx3WlM1a1pXeGxkR1UrS0hzS0lDQWdJQzh2SUNBZ2MyVnVaR1Z5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSGRoYkd4bGRDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1cyTnNiM05sVW1WdFlXbHVaR1Z5Vkc5ZExBb2dJQ0FnTHk4Z0lDQnZia052YlhCc1pYUnBiMjQ2SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1UkdWc1pYUmxRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUJ0WlhSb2IyUWdJbVJsYkdWMFpTaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR1JsYkdWMFpWZGhiR3hsZENoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pwWFlXeHNaWFJHWVdOMGIzSjVVM1Z1YzJWMFEyOXVkSEpoWTNRdVpHVnNaWFJsUW05NFpYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVkNiM2hsY3pvS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRBNUNpQWdJQ0F2THlCa1pXeGxkR1ZDYjNobGN5aGliM2hsY3pvZ1lubDBaWE5iWFNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taR1ZzWlhSbFFtOTRaWE5mWm05eVgyaGxZV1JsY2tBeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdaR1ZzWlhSbFFtOTRaWE1vWW05NFpYTTZJR0o1ZEdWelcxMHBPaUIyYjJsa0lIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEVUtJQ0FnSUR3S0lDQWdJR0o2SUdSbGJHVjBaVUp2ZUdWelgyRm1kR1Z5WDJadmNrQTBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWm05eUlDaHNaVzRyS0d4bGJpdDFhVzUwT0Z0ZEtWdGRLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdaR1ZzWlhSbFFtOTRaWE5mWm05eVgyaGxZV1JsY2tBeENncGtaV3hsZEdWQ2IzaGxjMTloWm5SbGNsOW1iM0pBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZkMkZzYkdWMExXWmhZM1J2Y25rdVlXeG5ieTUwY3pveE1Ea0tJQ0FnSUM4dklHUmxiR1YwWlVKdmVHVnpLR0p2ZUdWek9pQmllWFJsYzF0ZEtUb2dkbTlwWkNCN0NpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZbmwwWlhNK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZbTk0WlhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRGNLQ21SbGJHVjBaVUp2ZUdWelgzZG9hV3hsWDNSdmNFQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUdKdmVHVnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWkdsbklEVUtJQ0FnSUR3S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JpZWlCa1pXeGxkR1ZDYjNobGMxOWhablJsY2w5M2FHbHNaVUE0Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z1YzJWMEwzZGhiR3hsZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRFeENpQWdJQ0F2THlCdmNDNUNiM2d1WkdWc1pYUmxLR0p2ZUdWelcybGRLUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUdKdmVHVnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0EzQ2lBZ0lDQmlJR1JsYkdWMFpVSnZlR1Z6WDNkb2FXeGxYM1J2Y0VBMkNncGtaV3hsZEdWQ2IzaGxjMTloWm5SbGNsOTNhR2xzWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdaR1ZzWlhSbFFtOTRaWE1vWW05NFpYTTZJR0o1ZEdWelcxMHBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk9sZGhiR3hsZEVaaFkzUnZjbmxUZFc1elpYUkRiMjUwY21GamRDNWpiRzl6WlU5MWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU5zYjNObFQzVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPakV4TlFvZ0lDQWdMeThnWTJ4dmMyVlBkWFFvWTJ4dmMyVnpPaUJCYzNObGRFTnNiM05sVUdGeVlXMXpXMTBwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZkSGx3WlhNdWRITTZPa0Z6YzJWMFEyeHZjMlZRWVhKaGJYTStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZNVEUyQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnWTJ4dmMyVnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1kyeHZjMlZQZFhSZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZNVEUyQ2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnWTJ4dmMyVnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E4Q2lBZ0lDQmllaUJqYkc5elpVOTFkRjloWm5SbGNsOTNhR2xzWlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWdWMyVjBMM2RoYkd4bGRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk1URTNDaUFnSUNBdkx5QmpiMjV6ZENCN0lHRnpjMlYwUTJ4dmMyVlVieXdnZUdabGNrRnpjMlYwSUgwZ1BTQmpiRzl6WlhOYmFWMEtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTBNQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6b3hNVGdLSUNBZ0lDOHZJR2wwZUc0dVlYTnpaWFJVY21GdWMyWmxjaWg3SUdGemMyVjBRMnh2YzJWVWJ5d2dlR1psY2tGemMyVjBJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRU5zYjNObFZHOEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdabTl5SUNoc1pYUWdhVG9nZFdsdWREWTBJRDBnTURzZ2FTQThJR05zYjNObGN5NXNaVzVuZEdnN0lHa3JLeWtnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQmpiRzl6WlU5MWRGOTNhR2xzWlY5MGIzQkFNZ29LWTJ4dmMyVlBkWFJmWVdaMFpYSmZkMmhwYkdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6b3hNVFVLSUNBZ0lDOHZJR05zYjNObFQzVjBLR05zYjNObGN6b2dRWE56WlhSRGJHOXpaVkJoY21GdGMxdGRLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWJuTmxkQzkzWVd4c1pYUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qcFhZV3hzWlhSR1lXTjBiM0o1VTNWdWMyVjBRMjl1ZEhKaFkzUXVaR1ZzWlhSbFFYTnpaWFJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsUVhOelpYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPakV5TWdvZ0lDQWdMeThnWkdWc1pYUmxRWE56WlhSektHRnpjMlYwY3pvZ1FYTnpaWFJiWFNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnpjMlYwUGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pFeU13b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHRnpjMlYwY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtDbVJsYkdWMFpVRnpjMlYwYzE5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRXNXpaWFF2ZDJGc2JHVjBMV1poWTNSdmNua3VZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JoYzNObGRITXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR1JsYkdWMFpVRnpjMlYwYzE5aFpuUmxjbDkzYUdsc1pVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnVjMlYwTDNkaGJHeGxkQzFtWVdOMGIzSjVMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwUTI5dVptbG5LSHNnWTI5dVptbG5RWE56WlhRNklHRnpjMlYwYzF0cFhTQjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhRS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pFeU13b2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHRnpjMlYwY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCa1pXeGxkR1ZCYzNObGRITmZkMmhwYkdWZmRHOXdRRElLQ21SbGJHVjBaVUZ6YzJWMGMxOWhablJsY2w5M2FHbHNaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pFeU1nb2dJQ0FnTHk4Z1pHVnNaWFJsUVhOelpYUnpLR0Z6YzJWMGN6b2dRWE56WlhSYlhTazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZkMkZzYkdWMExXWmhZM1J2Y25rdVlXeG5ieTUwY3pvNlYyRnNiR1YwUm1GamRHOXllVk4xYm5ObGRFTnZiblJ5WVdOMExtUmxiR1YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFc1elpYUXZkMkZzYkdWMExXWmhZM1J2Y25rdVlXeG5ieTUwY3pveE1qZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25SR1ZzWlhSbFFYQndiR2xqWVhScGIyNG5YU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFibk5sZEM5M1lXeHNaWFF0Wm1GamRHOXllUzVoYkdkdkxuUnpPakV6TUFvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc2dZMnh2YzJWU1pXMWhhVzVrWlhKVWJ5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHOXpaVkpsYldGcGJtUmxjbFJ2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYm5ObGRDOTNZV3hzWlhRdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZEVaV3hsZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBQUVDQ0lBZ0pnVUNZbU1FcTRzaE9nU1kvV1duQkpZbDZ0a0V4OWdRRkRFYlFRQmpLVFlhQUk0QkFFOHhHUlJFTVJoRWdnY0VBZUl2UHdRK29RVTBCS1RMbVdNRXRpZmhpQVJrTUR3L0JQc0ZPU1lFMDBheHBDb3JKd1EyR2dDT0NnQWFBSndCQmdFM0FXZ0JxQUFCQWRZQ1RnS1hBQ2k4U0NORE1SbUJCUkl4R0JCRVFnTEFNUmtVTVJnVUVFTWlOaG9CU1JVbEVrUVhLTDFNU1U4Q1JDRUVEVUVBWHlnaUlRUzZSUU1oQkFrb0lRUlBBcnF4SW9BV1kyaHBiR1JmWTI5dWRISmhZM1JmZG1WeWMybHZibVZFU1JVV1Z3WUNURkNBQkF1QkFVT3lRa3NEc2tCTXNrQ0JCTElaU3dHeUdJQUU2cEdBM2JJYXNocUJCcklRSXJJQnN5TkRLQ0pQQXJwRkFvQUFRditsTmhvQlNSVWxFa1FYTmhvQ1J3SWlXVWxPQWlRTFRFa1ZURmNDQUNKSlN3VU1RUUFrUndJa0Mwc0RTVThDV1VsTEIwbE9CQkpFU3dFVlVpSlpKQWdJUlFVakNFVUJRdi9WU3dNa0NFc0RFa1N4TWdwTEI3SVlzZ0Fxc2hwTEJiSWFnUWF5RUNLeUFiTWpRellhQVVrVkpSSkVGellhQWtraVdZRW9DeVFJU3dFVkVrU3hNZ3BQQXJJWXNnQXJzaHF5R29FR3NoQWlzZ0d6STBNMkdnRkpGU1VTUkJjMkdnSkpJbGtsQ3lRSVN3RVZFa1N4TWdwUEFySVlzZ0FuQkxJYXNocUJCcklRSXJJQnN5TkROaG9CU1JVbEVrUVhOaG9DU1JVbEVrUTJHZ05KSWxrbEN5UUlTd0VWRWtTeE1ncFBBN0lZc2dDQUJCUVdmdWV5R2t5eUdySWFnUWF5RUNLeUFiTWpRellhQVVrVkpSSkVGellhQWtrVmdTQVNSTEV5Q29FRnNobFBBcklZc2dBcHNocXlHb0VHc2hBaXNnR3pJME9BQUVrMkdnRkpJbGxKVGdJa0MweEpGVXhYQWdBaVNVc0ZERUVBSkVjQ0pBdExBMGxQQWxsSlN3ZEpUZ1FTUkVzQkZWSWlXU1FJQ0VVRkl3aEZBVUwvMVVzREpBaExBeEpFSWtVSFN3WkxCUXhKUlFkQkFCOUxCVVJMQmtra0Mwc0RTVThDV1VwWkpBaFlWd0lBdkVnakNFVUhRdi9XSTBNMkdnRkhBaUpaU1U0Q2dTZ0xKQWhNRlJKRUlrbExBZ3hCQUN4TEFsY0NBRXNCU1U0Q2dTZ0xnU2hZU1ZjQUlFeUJJRnV4c2hHeUZZRUVzaEFpc2dHekl3aEZBVUwvelNORE5ob0JSd0lpV1VsT0FpVUxKQWhNRlJKRUlrbExBZ3hCQUIreFN3SlhBZ0JMQVVsT0FpVUxXN0loZ1FPeUVDS3lBYk1qQ0VVQlF2L2FJME0yR2dGSkZZRWdFa1N4c2dranNoQWlzZ0d6STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
