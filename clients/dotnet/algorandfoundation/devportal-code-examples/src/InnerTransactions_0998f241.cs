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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.InnerTransactions_0998f241
{


    //
    // InnerTransactions contract demonstrates various inner transaction patterns
    //in Algorand smart contracts.
    //
    public class InnerTransactionsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public InnerTransactionsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MultiInnerTxnsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
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

                public static MultiInnerTxnsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MultiInnerTxnsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MultiInnerTxnsReturn);
                }
                public bool Equals(MultiInnerTxnsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MultiInnerTxnsReturn left, MultiInnerTxnsReturn right)
                {
                    return EqualityComparer<MultiInnerTxnsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MultiInnerTxnsReturn left, MultiInnerTxnsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Demonstrates a simple payment inner transaction.
        ///The fee is set to 0 by default. Manually set here for demonstration purposes.
        ///The `Sender` for the payment is implied to be Global.currentApplicationAddress.
        ///If a different sender is needed, it'd have to be an account that has been
        ///rekeyed to the application address.
        ///</summary>
        public async Task<ulong> Payment(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 149, 0, 39 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Payment_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 149, 0, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creates a fungible asset (token)
        ///</summary>
        public async Task<ulong> FungibleAssetCreate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 7, 247, 125 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FungibleAssetCreate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 7, 247, 125 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creates a non-fungible asset (NFT).
        ///Following the ARC3 standard, the total supply must be 1 for a non-fungible asset.
        ///If you want to create fractional NFTs, `total` * `decimals` point must be 1.
        ///ex) total=100, decimals=2, 100 * 0.01 = 1
        ///The fee is set to 0 by default for inner transactions.
        ///The Sender is implied to be Global.currentApplicationAddress.
        ///</summary>
        public async Task<ulong> NonFungibleAssetCreate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 36, 146, 132 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NonFungibleAssetCreate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 36, 146, 132 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opts the application into an asset.
        ///A zero amount asset transfer to one's self is a special type of asset transfer
        ///that is used to opt-in to an asset.
        ///To send an asset transfer, the asset must be an available resource.
        ///</summary>
        /// <param name="asset">The asset to opt into </param>
        public async Task AssetOptIn(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 189, 179, 31 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetOptIn_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 189, 179, 31 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfers an asset from the application to another account.
        ///For a smart contract to transfer an asset, the app account must be opted into the asset
        ///and be holding non zero amount of assets.
        ///To send an asset transfer, the asset must be an available resource.
        ///</summary>
        /// <param name="asset">The asset to transfer </param>
        /// <param name="receiver">The account to receive the asset </param>
        /// <param name="amount">The amount to transfer </param>
        public async Task AssetTransfer(ulong asset, Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 154, 252, 97 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetTransfer_Transactions(ulong asset, Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 154, 252, 97 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freezes an asset for a specific account.
        ///To freeze an asset, the asset must be a freezable asset
        ///by having an account with freeze authority.
        ///</summary>
        /// <param name="acctToBeFrozen">The account to freeze the asset for </param>
        /// <param name="asset">The asset to freeze </param>
        public async Task AssetFreeze(Algorand.Address acctToBeFrozen, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 242, 72, 115 };
            var acctToBeFrozenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctToBeFrozenAbi.From(acctToBeFrozen);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, acctToBeFrozenAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetFreeze_Transactions(Algorand.Address acctToBeFrozen, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 242, 72, 115 };
            var acctToBeFrozenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctToBeFrozenAbi.From(acctToBeFrozen);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, acctToBeFrozenAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revokes (clawbacks) an asset from an account.
        ///To revoke an asset, the asset must be a revocable asset
        ///by having an account with clawback authority.
        ///The Sender is implied to be current_application_address.
        ///</summary>
        /// <param name="asset">The asset to revoke </param>
        /// <param name="accountToBeRevoked">The account to revoke the asset from </param>
        /// <param name="amount">The amount to revoke </param>
        public async Task AssetRevoke(ulong asset, Algorand.Address accountToBeRevoked, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 10, 255, 255 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountToBeRevokedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountToBeRevokedAbi.From(accountToBeRevoked);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, accountToBeRevokedAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetRevoke_Transactions(ulong asset, Algorand.Address accountToBeRevoked, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 10, 255, 255 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var accountToBeRevokedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountToBeRevokedAbi.From(accountToBeRevoked);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, accountToBeRevokedAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reconfigures an existing asset.
        ///For a smart contract to transfer an asset, the app account must be opted into the asset
        ///and be holding non zero amount of assets.
        ///To send an asset transfer, the asset must be an available resource.
        ///Refer the Resource Availability section for more information.
        ///</summary>
        /// <param name="asset">The asset to reconfigure </param>
        public async Task AssetConfig(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 54, 227, 40 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetConfig_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 54, 227, 40 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deletes an asset.
        ///To delete an asset, the asset must be a deleteable asset
        ///by having an account with delete authority.
        ///The Sender is implied to be current_application_address.
        ///</summary>
        /// <param name="asset">The asset to delete </param>
        public async Task AssetDelete(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 146, 153, 216 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetDelete_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 146, 153, 216 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Demonstrates grouped inner transactions
        ///</summary>
        /// <param name="appId">The application to call </param>
        public async Task<Structs.MultiInnerTxnsReturn> MultiInnerTxns(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 63, 242, 245 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MultiInnerTxnsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MultiInnerTxns_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 63, 242, 245 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deploys a HelloWorld contract using direct application call
        ///
        ///This method uses the itxn.applicationCall to deploy the HelloWorld contract.
        ///</summary>
        public async Task<ulong> DeployApp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 32, 168, 126 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DeployApp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 32, 168, 126 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deploys a HelloWorld contract using arc4
        ///
        ///This method uses arc4 to deploy the HelloWorld contract.
        ///</summary>
        public async Task<ulong> Arc4DeployApp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 236, 192, 20 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Arc4DeployApp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 236, 192, 20 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Demonstrates calling methods on another application
        ///</summary>
        /// <param name="appId">The application to call </param>
        public async Task<string> NoopAppCall(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 64, 142, 165 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> NoopAppCall_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 64, 142, 165 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW5uZXJUcmFuc2FjdGlvbnMiLCJkZXNjIjoiSW5uZXJUcmFuc2FjdGlvbnMgY29udHJhY3QgZGVtb25zdHJhdGVzIHZhcmlvdXMgaW5uZXIgdHJhbnNhY3Rpb24gcGF0dGVybnNcbmluIEFsZ29yYW5kIHNtYXJ0IGNvbnRyYWN0cy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTXVsdGlJbm5lclR4bnNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJwYXltZW50IiwiZGVzYyI6IkRlbW9uc3RyYXRlcyBhIHNpbXBsZSBwYXltZW50IGlubmVyIHRyYW5zYWN0aW9uLlxuVGhlIGZlZSBpcyBzZXQgdG8gMCBieSBkZWZhdWx0LiBNYW51YWxseSBzZXQgaGVyZSBmb3IgZGVtb25zdHJhdGlvbiBwdXJwb3Nlcy5cblRoZSBgU2VuZGVyYCBmb3IgdGhlIHBheW1lbnQgaXMgaW1wbGllZCB0byBiZSBHbG9iYWwuY3VycmVudEFwcGxpY2F0aW9uQWRkcmVzcy5cbklmIGEgZGlmZmVyZW50IHNlbmRlciBpcyBuZWVkZWQsIGl0J2QgaGF2ZSB0byBiZSBhbiBhY2NvdW50IHRoYXQgaGFzIGJlZW5cbnJla2V5ZWQgdG8gdGhlIGFwcGxpY2F0aW9uIGFkZHJlc3MuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBhbW91bnQgb2YgdGhlIHBheW1lbnQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5naWJsZUFzc2V0Q3JlYXRlIiwiZGVzYyI6IkNyZWF0ZXMgYSBmdW5naWJsZSBhc3NldCAodG9rZW4pIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBJRCBvZiB0aGUgY3JlYXRlZCBhc3NldCJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5vbkZ1bmdpYmxlQXNzZXRDcmVhdGUiLCJkZXNjIjoiQ3JlYXRlcyBhIG5vbi1mdW5naWJsZSBhc3NldCAoTkZUKS5cbkZvbGxvd2luZyB0aGUgQVJDMyBzdGFuZGFyZCwgdGhlIHRvdGFsIHN1cHBseSBtdXN0IGJlIDEgZm9yIGEgbm9uLWZ1bmdpYmxlIGFzc2V0LlxuSWYgeW91IHdhbnQgdG8gY3JlYXRlIGZyYWN0aW9uYWwgTkZUcywgYHRvdGFsYCAqIGBkZWNpbWFsc2AgcG9pbnQgbXVzdCBiZSAxLlxuZXgpIHRvdGFsPTEwMCwgZGVjaW1hbHM9MiwgMTAwICogMC4wMSA9IDFcblRoZSBmZWUgaXMgc2V0IHRvIDAgYnkgZGVmYXVsdCBmb3IgaW5uZXIgdHJhbnNhY3Rpb25zLlxuVGhlIFNlbmRlciBpcyBpbXBsaWVkIHRvIGJlIEdsb2JhbC5jdXJyZW50QXBwbGljYXRpb25BZGRyZXNzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgSUQgb2YgdGhlIGNyZWF0ZWQgYXNzZXQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldE9wdEluIiwiZGVzYyI6Ik9wdHMgdGhlIGFwcGxpY2F0aW9uIGludG8gYW4gYXNzZXQuXG5BIHplcm8gYW1vdW50IGFzc2V0IHRyYW5zZmVyIHRvIG9uZSdzIHNlbGYgaXMgYSBzcGVjaWFsIHR5cGUgb2YgYXNzZXQgdHJhbnNmZXJcbnRoYXQgaXMgdXNlZCB0byBvcHQtaW4gdG8gYW4gYXNzZXQuXG5UbyBzZW5kIGFuIGFzc2V0IHRyYW5zZmVyLCB0aGUgYXNzZXQgbXVzdCBiZSBhbiBhdmFpbGFibGUgcmVzb3VyY2UuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBhc3NldCB0byBvcHQgaW50byIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldFRyYW5zZmVyIiwiZGVzYyI6IlRyYW5zZmVycyBhbiBhc3NldCBmcm9tIHRoZSBhcHBsaWNhdGlvbiB0byBhbm90aGVyIGFjY291bnQuXG5Gb3IgYSBzbWFydCBjb250cmFjdCB0byB0cmFuc2ZlciBhbiBhc3NldCwgdGhlIGFwcCBhY2NvdW50IG11c3QgYmUgb3B0ZWQgaW50byB0aGUgYXNzZXRcbmFuZCBiZSBob2xkaW5nIG5vbiB6ZXJvIGFtb3VudCBvZiBhc3NldHMuXG5UbyBzZW5kIGFuIGFzc2V0IHRyYW5zZmVyLCB0aGUgYXNzZXQgbXVzdCBiZSBhbiBhdmFpbGFibGUgcmVzb3VyY2UuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBhc3NldCB0byB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6IlRoZSBhY2NvdW50IHRvIHJlY2VpdmUgdGhlIGFzc2V0IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjoiVGhlIGFtb3VudCB0byB0cmFuc2ZlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldEZyZWV6ZSIsImRlc2MiOiJGcmVlemVzIGFuIGFzc2V0IGZvciBhIHNwZWNpZmljIGFjY291bnQuXG5UbyBmcmVlemUgYW4gYXNzZXQsIHRoZSBhc3NldCBtdXN0IGJlIGEgZnJlZXphYmxlIGFzc2V0XG5ieSBoYXZpbmcgYW4gYWNjb3VudCB3aXRoIGZyZWV6ZSBhdXRob3JpdHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2N0VG9CZUZyb3plbiIsImRlc2MiOiJUaGUgYWNjb3VudCB0byBmcmVlemUgdGhlIGFzc2V0IGZvciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiVGhlIGFzc2V0IHRvIGZyZWV6ZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldFJldm9rZSIsImRlc2MiOiJSZXZva2VzIChjbGF3YmFja3MpIGFuIGFzc2V0IGZyb20gYW4gYWNjb3VudC5cblRvIHJldm9rZSBhbiBhc3NldCwgdGhlIGFzc2V0IG11c3QgYmUgYSByZXZvY2FibGUgYXNzZXRcbmJ5IGhhdmluZyBhbiBhY2NvdW50IHdpdGggY2xhd2JhY2sgYXV0aG9yaXR5LlxuVGhlIFNlbmRlciBpcyBpbXBsaWVkIHRvIGJlIGN1cnJlbnRfYXBwbGljYXRpb25fYWRkcmVzcy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiVGhlIGFzc2V0IHRvIHJldm9rZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRUb0JlUmV2b2tlZCIsImRlc2MiOiJUaGUgYWNjb3VudCB0byByZXZva2UgdGhlIGFzc2V0IGZyb20iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOiJUaGUgYW1vdW50IHRvIHJldm9rZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldENvbmZpZyIsImRlc2MiOiJSZWNvbmZpZ3VyZXMgYW4gZXhpc3RpbmcgYXNzZXQuXG5Gb3IgYSBzbWFydCBjb250cmFjdCB0byB0cmFuc2ZlciBhbiBhc3NldCwgdGhlIGFwcCBhY2NvdW50IG11c3QgYmUgb3B0ZWQgaW50byB0aGUgYXNzZXRcbmFuZCBiZSBob2xkaW5nIG5vbiB6ZXJvIGFtb3VudCBvZiBhc3NldHMuXG5UbyBzZW5kIGFuIGFzc2V0IHRyYW5zZmVyLCB0aGUgYXNzZXQgbXVzdCBiZSBhbiBhdmFpbGFibGUgcmVzb3VyY2UuXG5SZWZlciB0aGUgUmVzb3VyY2UgQXZhaWxhYmlsaXR5IHNlY3Rpb24gZm9yIG1vcmUgaW5mb3JtYXRpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBhc3NldCB0byByZWNvbmZpZ3VyZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldERlbGV0ZSIsImRlc2MiOiJEZWxldGVzIGFuIGFzc2V0LlxuVG8gZGVsZXRlIGFuIGFzc2V0LCB0aGUgYXNzZXQgbXVzdCBiZSBhIGRlbGV0ZWFibGUgYXNzZXRcbmJ5IGhhdmluZyBhbiBhY2NvdW50IHdpdGggZGVsZXRlIGF1dGhvcml0eS5cblRoZSBTZW5kZXIgaXMgaW1wbGllZCB0byBiZSBjdXJyZW50X2FwcGxpY2F0aW9uX2FkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6IlRoZSBhc3NldCB0byBkZWxldGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXVsdGlJbm5lclR4bnMiLCJkZXNjIjoiRGVtb25zdHJhdGVzIGdyb3VwZWQgaW5uZXIgdHJhbnNhY3Rpb25zIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6IlRoZSBhcHBsaWNhdGlvbiB0byBjYWxsIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6Ik11bHRpSW5uZXJUeG5zUmV0dXJuIiwiZGVzYyI6IkEgdHVwbGUgY29udGFpbmluZyB0aGUgcGF5bWVudCBhbW91bnQgYW5kIHRoZSByZXN1bHQgb2YgdGhlIGhlbGxvIHdvcmxkIGNhbGwifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBsb3lBcHAiLCJkZXNjIjoiRGVwbG95cyBhIEhlbGxvV29ybGQgY29udHJhY3QgdXNpbmcgZGlyZWN0IGFwcGxpY2F0aW9uIGNhbGxcblxuVGhpcyBtZXRob2QgdXNlcyB0aGUgaXR4bi5hcHBsaWNhdGlvbkNhbGwgdG8gZGVwbG95IHRoZSBIZWxsb1dvcmxkIGNvbnRyYWN0LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgSUQgb2YgdGhlIGRlcGxveWVkIGFwcGxpY2F0aW9uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNERlcGxveUFwcCIsImRlc2MiOiJEZXBsb3lzIGEgSGVsbG9Xb3JsZCBjb250cmFjdCB1c2luZyBhcmM0XG5cblRoaXMgbWV0aG9kIHVzZXMgYXJjNCB0byBkZXBsb3kgdGhlIEhlbGxvV29ybGQgY29udHJhY3QuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBJRCBvZiB0aGUgZGVwbG95ZWQgYXBwbGljYXRpb24ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub29wQXBwQ2FsbCIsImRlc2MiOiJEZW1vbnN0cmF0ZXMgY2FsbGluZyBtZXRob2RzIG9uIGFub3RoZXIgYXBwbGljYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwSWQiLCJkZXNjIjoiVGhlIGFwcGxpY2F0aW9uIHRvIGNhbGwiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiQSBzdHJpbmcgcmVzdWx0IGZyb20gdGhlIGhlbGxvIHdvcmxkIGNhbGwifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU0Miw2NzZdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRE1nTkFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSURCNE0yRmhaRFprT0RZZ01IZ3dNREF6TkRRMlpqWTFDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdaWGh3YjNKMElHUmxabUYxYkhRZ1kyeGhjM01nU1c1dVpYSlVjbUZ1YzJGamRHbHZibk1nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1qQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNak01TlRBd01qY2dNSGd3TWpBM1pqYzNaQ0F3ZUdReU1qUTVNamcwSURCNE16QmlaR0l6TVdZZ01IaGpPVGxoWm1NMk1TQXdlR0ppWmpJME9EY3pJREI0TlRVd1lXWm1abVlnTUhoa01UTTJaVE15T0NBd2VEZzRPVEk1T1dRNElEQjRZMlV6Wm1ZeVpqVWdNSGhrWVRJd1lUZzNaU0F3ZURNNFpXTmpNREUwSURCNE5EWTBNRGhsWVRVZ0x5OGdiV1YwYUc5a0lDSndZWGx0Wlc1MEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltWjFibWRwWW14bFFYTnpaWFJEY21WaGRHVW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlibTl1Um5WdVoybGliR1ZCYzNObGRFTnlaV0YwWlNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKaGMzTmxkRTl3ZEVsdUtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0poYzNObGRGUnlZVzV6Wm1WeUtIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjM05sZEVaeVpXVjZaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGMzTmxkRkpsZG05clpTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZWE56WlhSRGIyNW1hV2NvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnpjMlYwUkdWc1pYUmxLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdGRXeDBhVWx1Ym1WeVZIaHVjeWgxYVc1ME5qUXBLSFZwYm5RMk5DeHpkSEpwYm1jcElpd2diV1YwYUc5a0lDSmtaWEJzYjNsQmNIQW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZWEpqTkVSbGNHeHZlVUZ3Y0NncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKdWIyOXdRWEJ3UTJGc2JDaDFhVzUwTmpRcGMzUnlhVzVuSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2NHRjViV1Z1ZENCbWRXNW5hV0pzWlVGemMyVjBRM0psWVhSbElHNXZia1oxYm1kcFlteGxRWE56WlhSRGNtVmhkR1VnWVhOelpYUlBjSFJKYmlCaGMzTmxkRlJ5WVc1elptVnlJR0Z6YzJWMFJuSmxaWHBsSUdGemMyVjBVbVYyYjJ0bElHRnpjMlYwUTI5dVptbG5JR0Z6YzJWMFJHVnNaWFJsSUcxMWJIUnBTVzV1WlhKVWVHNXpJR1JsY0d4dmVVRndjQ0J0WVdsdVgyRnlZelJFWlhCc2IzbEJjSEJmY205MWRHVkFNVFVnYm05dmNFRndjRU5oYkd3S0lDQWdJR1Z5Y2dvS2JXRnBibDloY21NMFJHVndiRzk1UVhCd1gzSnZkWFJsUURFMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ3dDaUFnSUNBdkx5QndkV0pzYVdNZ1lYSmpORVJsY0d4dmVVRndjQ2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd05HUXlDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURJd09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHVjRjRzl5ZENCa1pXWmhkV3gwSUdOc1lYTnpJRWx1Ym1WeVZISmhibk5oWTNScGIyNXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRnTHk4Z2IyNGdaWEp5YjNJNklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DZ29LTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekxuQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZWGx0Wlc1ME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3RNelVLSUNBZ0lDOHZJR052Ym5OMElISmxjM1ZzZENBOUlHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ05UQXdNQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1Ym1WeVZISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ05UQXdNQ3dLSUNBZ0lIQjFjMmhwYm5RZ05UQXdNQ0F2THlBMU1EQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprdE16UUtJQ0FnSUM4dklHTnZibk4wSUhKbGMzVnNkQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nTlRBd01Dd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1Ym1WeVZISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamt0TXpVS0lDQWdJQzh2SUdOdmJuTjBJSEpsYzNWc2RDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dOVEF3TUN3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1FXMXZkVzUwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJSEJoZVcxbGJuUW9LVG9nZFdsdWREWTBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXVablZ1WjJsaWJHVkJjM05sZEVOeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21aMWJtZHBZbXhsUVhOelpYUkRjbVZoZEdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME55MDFOQW9nSUNBZ0x5OGdZMjl1YzNRZ2FYUjRibEpsYzNWc2RDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRG9nTVRBd1h6QXdNRjh3TURCZk1EQXdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6T2lBeUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhST1lXMWxPaUFuVWxBbkxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFRtRnRaVG9nSjFKdmVXRnNkSGtnVUc5cGJuUnpKeXdLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVhOelpYUk9ZVzFsT2lBblVtOTVZV3gwZVNCUWIybHVkSE1uTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pTYjNsaGJIUjVJRkJ2YVc1MGN5SUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnZFc1cGRFNWhiV1U2SUNkU1VDY3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsSlFJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdaR1ZqYVcxaGJITTZJRElzQ2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnZEc5MFlXdzZJREV3TUY4d01EQmZNREF3WHpBd01Dd0tJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3TURBd0lDOHZJREV3TURBd01EQXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOeTAxTXdvZ0lDQWdMeThnWTI5dWMzUWdhWFI0YmxKbGMzVnNkQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkRvZ01UQXdYekF3TUY4d01EQmZNREF3TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4ek9pQXlMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUk9ZVzFsT2lBblVsQW5MQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBUbUZ0WlRvZ0oxSnZlV0ZzZEhrZ1VHOXBiblJ6Snl3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEzTFRVMENpQWdJQ0F2THlCamIyNXpkQ0JwZEhodVVtVnpkV3gwSUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc09pQXhNREJmTURBd1h6QXdNRjh3TURBc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTZJRElzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRTVoYldVNklDZFNVQ2NzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJPWVcxbE9pQW5VbTk1WVd4MGVTQlFiMmx1ZEhNbkxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z2NIVmliR2xqSUdaMWJtZHBZbXhsUVhOelpYUkRjbVZoZEdVb0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdWJtOXVSblZ1WjJsaWJHVkJjM05sZEVOeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q201dmJrWjFibWRwWW14bFFYTnpaWFJEY21WaGRHVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPUzA0TWdvZ0lDQWdMeThnWTI5dWMzUWdhWFI0YmxKbGMzVnNkQ0E5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkRvZ01UQXdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6T2lBeUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhST1lXMWxPaUFuVFV3bkxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFRtRnRaVG9nSjAxdmJtRWdUR2x6WVNjc0NpQWdJQ0F2THlBZ0lDQWdkWEpzT2lBbmFIUjBjSE02THk5c2FXNXJYM1J2WDJsd1puTXZUVzl1WVY5TWFYTmhKeXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVU2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUcxaGJtRm5aWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMzTFRjNUNpQWdJQ0F2THlCeVpYTmxjblpsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJR1p5WldWNlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlCamJHRjNZbUZqYXpvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQmtkWEJ1SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRGJHRjNZbUZqYXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVaeVpXVjZaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2RYSnNPaUFuYUhSMGNITTZMeTlzYVc1clgzUnZYMmx3Wm5NdlRXOXVZVjlNYVhOaEp5d0tJQ0FnSUhCMWMyaGllWFJsY3lBaWFIUjBjSE02THk5c2FXNXJYM1J2WDJsd1puTXZUVzl1WVY5TWFYTmhJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZTVEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUdGemMyVjBUbUZ0WlRvZ0owMXZibUVnVEdsellTY3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrMXZibUVnVEdsellTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnZFc1cGRFNWhiV1U2SUNkTlRDY3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrMU1JZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNZ29nSUNBZ0x5OGdaR1ZqYVcxaGJITTZJRElzQ2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnZEc5MFlXdzZJREV3TUN3S0lDQWdJSEIxYzJocGJuUWdNVEF3SUM4dklERXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9TMDRNUW9nSUNBZ0x5OGdZMjl1YzNRZ2FYUjRibEpsYzNWc2RDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRG9nTVRBd0xBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpPaUF5TEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJPWVcxbE9pQW5UVXduTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVG1GdFpUb2dKMDF2Ym1FZ1RHbHpZU2NzQ2lBZ0lDQXZMeUFnSUNBZ2RYSnNPaUFuYUhSMGNITTZMeTlzYVc1clgzUnZYMmx3Wm5NdlRXOXVZVjlNYVhOaEp5d0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklHWmxaVG9nTUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprdE9ESUtJQ0FnSUM4dklHTnZibk4wSUdsMGVHNVNaWE4xYkhRZ1BTQnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRU52Ym1acFp5aDdDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzZJREV3TUN3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6b2dNaXdLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBUbUZ0WlRvZ0owMU1KeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRTVoYldVNklDZE5iMjVoSUV4cGMyRW5MQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEb2dKMmgwZEhCek9pOHZiR2x1YTE5MGIxOXBjR1p6TDAxdmJtRmZUR2x6WVNjc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbE9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6b2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUc1dmJrWjFibWRwWW14bFFYTnpaWFJEY21WaGRHVW9LVG9nZFdsdWREWTBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXVZWE56WlhSUGNIUkpibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GemMyVjBUM0IwU1c0NkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5nb2dJQ0FnTHk4Z2NIVmliR2xqSUdGemMyVjBUM0IwU1c0b1lYTnpaWFE2SUVGemMyVjBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOeTB4TURRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazVDaUFnSUNBdkx5QmhjM05sZEZKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUdGemMyVjBRVzF2ZFc1ME9pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazNMVEV3TXdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBeUNpQWdJQ0F2THlCbVpXVTZJREFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamszTFRFd05Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWE56WlhSUGNIUkpiaWhoYzNObGREb2dRWE56WlhRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82U1c1dVpYSlVjbUZ1YzJGamRHbHZibk11WVhOelpYUlVjbUZ1YzJabGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ6YzJWMFZISmhibk5tWlhJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklIQjFZbXhwWXlCaGMzTmxkRlJ5WVc1elptVnlLR0Z6YzJWME9pQkJjM05sZEN3Z2NtVmpaV2wyWlhJNklFRmpZMjkxYm5Rc0lHRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRrdE1USTJDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJ5WldObGFYWmxjaXdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4T1MweE1qVUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSEpsWTJWcGRtVnlMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE9TMHhNallLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhKbFkyVnBkbVZ5TEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdGemMyVjBWSEpoYm5ObVpYSW9ZWE56WlhRNklFRnpjMlYwTENCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZEN3Z1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXVZWE56WlhSR2NtVmxlbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGMzTmxkRVp5WldWNlpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPUW9nSUNBZ0x5OGdjSFZpYkdsaklHRnpjMlYwUm5KbFpYcGxLR0ZqWTNSVWIwSmxSbkp2ZW1WdU9pQkJZMk52ZFc1MExDQmhjM05sZERvZ1FYTnpaWFFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTUMweE5EY0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBSbkpsWlhwbEtIc0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVkJZMk52ZFc1ME9pQmhZMk4wVkc5Q1pVWnliM3BsYml3Z0x5OGdZV05qYjNWdWRDQjBieUJpWlNCbWNtOTZaVzRLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVZCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdabkp2ZW1WdU9pQjBjblZsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EUUtJQ0FnSUM4dklHWnliM3BsYmpvZ2RISjFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFWnlaV1Y2WlVGemMyVjBSbkp2ZW1WdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVaeVpXVjZaVUZ6YzJWMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVaeVpXVjZaVUZ6YzJWMFFXTmpiM1Z1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRd0xURTBOZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJHY21WbGVtVW9ld29nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVUZqWTI5MWJuUTZJR0ZqWTNSVWIwSmxSbkp2ZW1WdUxDQXZMeUJoWTJOdmRXNTBJSFJ2SUdKbElHWnliM3BsYmdvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlVGemMyVjBPaUJoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JtY205NlpXNDZJSFJ5ZFdVc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOUW9nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EQXRNVFEzQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEVaeVpXVjZaU2g3Q2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsUVdOamIzVnVkRG9nWVdOamRGUnZRbVZHY205NlpXNHNJQzh2SUdGalkyOTFiblFnZEc4Z1ltVWdabkp2ZW1WdUNpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbFFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdaeWIzcGxiam9nZEhKMVpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6T1FvZ0lDQWdMeThnY0hWaWJHbGpJR0Z6YzJWMFJuSmxaWHBsS0dGalkzUlViMEpsUm5KdmVtVnVPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dRWE56WlhRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82U1c1dVpYSlVjbUZ1YzJGamRHbHZibk11WVhOelpYUlNaWFp2YTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjM05sZEZKbGRtOXJaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTVFvZ0lDQWdMeThnY0hWaWJHbGpJR0Z6YzJWMFVtVjJiMnRsS0dGemMyVjBPaUJCYzNObGRDd2dZV05qYjNWdWRGUnZRbVZTWlhadmEyVmtPaUJCWTJOdmRXNTBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXlMVEUzTUFvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZObGJtUmxjam9nWVdOamIzVnVkRlJ2UW1WU1pYWnZhMlZrTENBdkx5QkJjM05sZEZObGJtUmxjaUJwY3lCdmJteDVJSFZ6WldRZ2FXNGdkR2hsSUdOaGMyVWdiMllnWTJ4aGQySmhZMnNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOalFLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1pMHhOamtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJUWlc1a1pYSTZJR0ZqWTI5MWJuUlViMEpsVW1WMmIydGxaQ3dnTHk4Z1FYTnpaWFJUWlc1a1pYSWdhWE1nYjI1c2VTQjFjMlZrSUdsdUlIUm9aU0JqWVhObElHOW1JR05zWVhkaVlXTnJDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZNENpQWdJQ0F2THlCbVpXVTZJREFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTWkweE56QUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlRaVzVrWlhJNklHRmpZMjkxYm5SVWIwSmxVbVYyYjJ0bFpDd2dMeThnUVhOelpYUlRaVzVrWlhJZ2FYTWdiMjVzZVNCMWMyVmtJR2x1SUhSb1pTQmpZWE5sSUc5bUlHTnNZWGRpWVdOckNpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdGemMyVjBVbVYyYjJ0bEtHRnpjMlYwT2lCQmMzTmxkQ3dnWVdOamIzVnVkRlJ2UW1WU1pYWnZhMlZrT2lCQlkyTnZkVzUwTENCaGJXOTFiblE2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEpibTVsY2xSeVlXNXpZV04wYVc5dWN5NWhjM05sZEVOdmJtWnBaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GemMyVjBRMjl1Wm1sbk9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ3pDaUFnSUNBdkx5QndkV0pzYVdNZ1lYTnpaWFJEYjI1bWFXY29ZWE56WlhRNklFRnpjMlYwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RRdE1Ua3pDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRU52Ym1acFp5aDdDaUFnSUNBdkx5QWdJQ0FnWTI5dVptbG5RWE56WlhRNklHRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlRvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphem9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzNDaUFnSUNBdkx5QnRZVzVoWjJWeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EZ0tJQ0FnSUM4dklISmxjMlZ5ZG1VNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RrS0lDQWdJQzh2SUdaeVpXVjZaVG9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TUFvZ0lDQWdMeThnWTJ4aGQySmhZMnM2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRGJHRjNZbUZqYXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVaeVpXVjZaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9EUXRNVGt5Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEVOdmJtWnBaeWg3Q2lBZ0lDQXZMeUFnSUNBZ1kyOXVabWxuUVhOelpYUTZJR0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCamJHRjNZbUZqYXpvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3hDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5DMHhPVE1LSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCamIyNW1hV2RCYzNObGREb2dZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbE9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yT2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1Ym1WeVZISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWE56WlhSRGIyNW1hV2NvWVhOelpYUTZJRUZ6YzJWMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TG1GemMyVjBSR1ZzWlhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWE56WlhSRVpXeGxkR1U2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURVS0lDQWdJQzh2SUhCMVlteHBZeUJoYzNObGRFUmxiR1YwWlNoaGMzTmxkRG9nUVhOelpYUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOaTB5TVRFS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQmpiMjVtYVdkQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TmkweU1UQUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBRMjl1Wm1sbktIc0tJQ0FnSUM4dklDQWdJQ0JqYjI1bWFXZEJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3T1FvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRFl0TWpFeENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRFTnZibVpwWnloN0NpQWdJQ0F2THlBZ0lDQWdZMjl1Wm1sblFYTnpaWFE2SUdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBMUNpQWdJQ0F2THlCd2RXSnNhV01nWVhOelpYUkVaV3hsZEdVb1lYTnpaWFE2SUVGemMyVjBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekxtMTFiSFJwU1c1dVpYSlVlRzV6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JYVnNkR2xKYm01bGNsUjRibk02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJ0ZFd4MGFVbHVibVZ5VkhodWN5aGhjSEJKWkRvZ1FYQndiR2xqWVhScGIyNHBPaUJiZFdsdWREWTBMQ0J6ZEhKcGJtZGRJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TXkweU1qa0tJQ0FnSUM4dklHTnZibk4wSUhCaGVWUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nTlRBd01Dd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTJDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU5Rb2dJQ0FnTHk4Z1lXMXZkVzUwT2lBMU1EQXdMQW9nSUNBZ2NIVnphR2x1ZENBMU1EQXdJQzh2SURVd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpNdE1qSTRDaUFnSUNBdkx5QmpiMjV6ZENCd1lYbFVlRzRnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SURVd01EQXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU53b2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpNdE1qSTVDaUFnSUNBdkx5QmpiMjV6ZENCd1lYbFVlRzRnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SURVd01EQXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRUZ0YjNWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTXlMVEl6T0FvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3UTJGc2JGUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd1NXUTZJR0Z3Y0Vsa0xtbGtMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NFRnlaM002SUZ0aGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZHpZWGxJWld4c2J5aHpkSEpwYm1jc2MzUnlhVzVuS1hOMGNtbHVaeWNwTENCdVpYY2dZWEpqTkM1VGRISW9KMHBoYm1VbktTd2dibVYzSUdGeVl6UXVVM1J5S0NkRWIyVW5LVjBzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek5Rb2dJQ0FnTHk4Z1lYQndRWEpuY3pvZ1cyRnlZelF1YldWMGFHOWtVMlZzWldOMGIzSW9KM05oZVVobGJHeHZLSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSnlrc0lHNWxkeUJoY21NMExsTjBjaWduU21GdVpTY3BMQ0J1WlhjZ1lYSmpOQzVUZEhJb0owUnZaU2NwWFN3S0lDQWdJR0o1ZEdWalh6RWdMeThnYldWMGFHOWtJQ0p6WVhsSVpXeHNieWh6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREEwTkdFMk1UWmxOalVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNelEwTm1ZMk5Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNeUxUSXpOd29nSUNBZ0x5OGdZMjl1YzNRZ1lYQndRMkZzYkZSNGJpQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3U1dRNklHRndjRWxrTG1sa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0VGeVozTTZJRnRoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NkellYbElaV3hzYnloemRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5Y3BMQ0J1WlhjZ1lYSmpOQzVUZEhJb0owcGhibVVuS1N3Z2JtVjNJR0Z5WXpRdVUzUnlLQ2RFYjJVbktWMHNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TmdvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNekl0TWpNNENpQWdJQ0F2THlCamIyNXpkQ0JoY0hCRFlXeHNWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQkpaRG9nWVhCd1NXUXVhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndRWEpuY3pvZ1cyRnlZelF1YldWMGFHOWtVMlZzWldOMGIzSW9KM05oZVVobGJHeHZLSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSnlrc0lHNWxkeUJoY21NMExsTjBjaWduU21GdVpTY3BMQ0J1WlhjZ1lYSmpOQzVUZEhJb0owUnZaU2NwWFN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUXhDaUFnSUNBdkx5QmpiMjV6ZENCb1pXeHNiMWR2Y214a1VtVnpkV3gwSUQwZ1lYSmpOQzVrWldOdlpHVkJjbU0wUEhOMGNtbHVaejRvWVhCd1EyRnNiRlI0Ymk1c1lYTjBURzluTENBbmJHOW5KeWtLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpReUNpQWdJQ0F2THlCeVpYUjFjbTRnVzNCaGVWUjRiaTVoYlc5MWJuUXNJR2hsYkd4dlYyOXliR1JTWlhOMWJIUmRDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01HRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJ0ZFd4MGFVbHVibVZ5VkhodWN5aGhjSEJKWkRvZ1FYQndiR2xqWVhScGIyNHBPaUJiZFdsdWREWTBMQ0J6ZEhKcGJtZGRJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXVaR1Z3Ykc5NVFYQndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWd2JHOTVRWEJ3T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZekxUSTJPUW9nSUNBZ0x5OGdZMjl1YzNRZ1lYQndWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQnliM1poYkZCeWIyZHlZVzA2SUVKNWRHVnpLQ2RoY0hCeWIzWmhiRjl3Y205bmNtRnRKeWtzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGxZWEpUZEdGMFpWQnliMmR5WVcwNklFSjVkR1Z6S0NkamJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdEp5a3NDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTmdvZ0lDQWdMeThnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUVKNWRHVnpLQ2RqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0Snlrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJOUW9nSUNBZ0x5OGdZWEJ3Y205MllXeFFjbTluY21GdE9pQkNlWFJsY3lnbllYQndjbTkyWVd4ZmNISnZaM0poYlNjcExBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaGNIQnliM1poYkY5d2NtOW5jbUZ0SWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCeWIzWmhiRkJ5YjJkeVlXMVFZV2RsY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZekxUSTJPQW9nSUNBZ0x5OGdZMjl1YzNRZ1lYQndWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0FnSUNCaGNIQnliM1poYkZCeWIyZHlZVzA2SUVKNWRHVnpLQ2RoY0hCeWIzWmhiRjl3Y205bmNtRnRKeWtzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGxZWEpUZEdGMFpWQnliMmR5WVcwNklFSjVkR1Z6S0NkamJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdEp5a3NDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTndvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOak10TWpZNUNpQWdJQ0F2THlCamIyNXpkQ0JoY0hCVWVHNGdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJUb2dRbmwwWlhNb0oyRndjSEp2ZG1Gc1gzQnliMmR5WVcwbktTd0tJQ0FnSUM4dklDQWdJQ0JqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nUW5sMFpYTW9KMk5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBuS1N3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTUFvZ0lDQWdMeThnY0hWaWJHbGpJR1JsY0d4dmVVRndjQ2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTV1YjI5d1FYQndRMkZzYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtNXZiM0JCY0hCRFlXeHNPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMGx1Ym1WeVZISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamszQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdibTl2Y0VGd2NFTmhiR3dvWVhCd1NXUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5SmJtNWxjbFJ5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU9TMHpNRFFLSUNBZ0lDOHZJR052Ym5OMElHTmhiR3hVZUc0Z1BTQnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUNBZ0lHRndjRWxrT2lCaGNIQkpaQzVwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJCY21kek9pQmJZWEpqTkM1dFpYUm9iMlJUWld4bFkzUnZjaWduYzJGNVNHVnNiRzhvYzNSeWFXNW5MSE4wY21sdVp5bHpkSEpwYm1jbktTd2dibVYzSUdGeVl6UXVVM1J5S0NkS2IyaHVKeWtzSUc1bGR5QmhjbU0wTGxOMGNpZ25SRzlsSnlsZExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUpibTVsY2xSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdNZ29nSUNBZ0x5OGdZWEJ3UVhKbmN6b2dXMkZ5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSjNOaGVVaGxiR3h2S0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bkp5a3NJRzVsZHlCaGNtTTBMbE4wY2lnblNtOW9iaWNwTENCdVpYY2dZWEpqTkM1VGRISW9KMFJ2WlNjcFhTd0tJQ0FnSUdKNWRHVmpYekVnTHk4Z2JXVjBhRzlrSUNKellYbElaV3hzYnloemRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBME5HRTJaalk0Tm1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TXpRME5tWTJOUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qazVMVE13TXdvZ0lDQWdMeThnWTI5dWMzUWdZMkZzYkZSNGJpQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3U1dRNklHRndjRWxrTG1sa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0VGeVozTTZJRnRoY21NMExtMWxkR2h2WkZObGJHVmpkRzl5S0NkellYbElaV3hzYnloemRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5Y3BMQ0J1WlhjZ1lYSmpOQzVUZEhJb0owcHZhRzRuS1N3Z2JtVjNJR0Z5WXpRdVUzUnlLQ2RFYjJVbktWMHNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVGt0TXpBMENpQWdJQ0F2THlCamIyNXpkQ0JqWVd4c1ZIaHVJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWEJ3YkdsallYUnBiMjVEWVd4c0tIc0tJQ0FnSUM4dklDQWdJQ0JoY0hCSlpEb2dZWEJ3U1dRdWFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1FYSm5jem9nVzJGeVl6UXViV1YwYUc5a1UyVnNaV04wYjNJb0ozTmhlVWhsYkd4dktITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5KeWtzSUc1bGR5QmhjbU0wTGxOMGNpZ25TbTlvYmljcExDQnVaWGNnWVhKak5DNVRkSElvSjBSdlpTY3BYU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12U1c1dVpYSlVjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TURjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExtUmxZMjlrWlVGeVl6UThjM1J5YVc1blBpaGpZV3hzVkhodUxteGhjM1JNYjJjc0lDZHNiMmNuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UY0tJQ0FnSUM4dklIQjFZbXhwWXlCdWIyOXdRWEJ3UTJGc2JDaGhjSEJKWkRvZ1FYQndiR2xqWVhScGIyNHBPaUJ6ZEhKcGJtY2dld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBREJDWURCQlVmZkhVRU9xMXRoZ1VBQTBSdlpURWJRUUI3TVJrVVJERVlSSUlOQkNPVkFDY0VBZ2YzZlFUU0pKS0VCREM5c3g4RXlacjhZUVM3OGtoekJGVUsvLzhFMFRiaktBU0lrcG5ZQk00Lzh2VUUyaUNvZmdRNDdNQVVCRVpBanFVMkdnQ09EUUFhQURRQWFnREVBTnNBOWdFUEFTNEJUQUZjQWJVQUFRSHlBSUFNRlI5OGRRQUFBQUFBQUFUU3NDSkRNUmtVTVJnVUVFT3hNUUN5QjRHSUo3SUlJcklRSTdJQnM3UUlGaWhNVUxBaVE3R0FEbEp2ZVdGc2RIa2dVRzlwYm5SenNpYUFBbEpRc2lXQkFySWpnWURRMjhQMEFySWlKTElRSTdJQnM3UThGaWhNVUxBaVE3RXlDa2NEc2l5eUs3SXFzaW1BSG1oMGRIQnpPaTh2YkdsdWExOTBiMTlwY0daekwwMXZibUZmVEdselliSW5nQWxOYjI1aElFeHBjMkd5Sm9BQ1RVeXlKWUVDc2lPQlpMSWlKTElRSTdJQnM3UThGaWhNVUxBaVF6WWFBUmV4TWdvanNoS3lGTElSSmJJUUk3SUJzeUpETmhvQkZ6WWFBallhQXhleHNoS3lGTElSSmJJUUk3SUJzeUpETmhvQk5ob0NGN0Vpc2kreUxiSXVnUVd5RUNPeUFiTWlRellhQVJjMkdnSTJHZ01Yc1RJS3NoU3lFcklUc2hFbHNoQWpzZ0d6SWtNMkdnRVhzVElLU1RFQVNiSXNzaXV5S3JJcHNpRWtzaEFqc2dHeklrTTJHZ0VYc2JJaEpMSVFJN0lCc3lKRE5ob0JGN0V4QUxJSGdZZ25zZ2dpc2hBanNnR3p0QWl4S2JJYWdBWUFCRXBoYm1XeUdpcXlHa3l5R0lFR3NoQWpzZ0d6dEQ1SlZ3QUVLQkpFVndZQVRCWkxBUlVXVndZQ1R3SlFUSUFDQUFwUVRGQW9URkN3SWtPeGdCTmpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRza0tBRUdGd2NISnZkbUZzWDNCeWIyZHlZVzJ5UUlFR3NoQWpzZ0d6dEQwV0tFeFFzQ0pETmhvQkY3RXBzaHFBQmdBRVNtOW9icklhS3JJYXNoaUJCcklRSTdJQnM3UStTVmNFQUV4WEFBUW9Fa1FvVEZDd0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
