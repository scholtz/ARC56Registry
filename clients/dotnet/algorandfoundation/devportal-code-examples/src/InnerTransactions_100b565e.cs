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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.InnerTransactions_100b565e
{


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

            public class NoopAppCallReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
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

                public static NoopAppCallReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NoopAppCallReturn();
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as NoopAppCallReturn);
                }
                public bool Equals(NoopAppCallReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NoopAppCallReturn left, NoopAppCallReturn right)
                {
                    return EqualityComparer<NoopAppCallReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(NoopAppCallReturn left, NoopAppCallReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
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
        ///
        ///</summary>
        public async Task<ulong> FungibleAssetCreate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 118, 137, 243 };

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
            byte[] abiHandle = { 234, 118, 137, 243 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Following the ARC3 standard, the total supply must be 1 for a non-fungible asset.
        ///If you want to create fractional NFTs, `total` * `decimals` point must be 1. ex) total=100, decimals=2, 100 * 0.01 = 1
        ///</summary>
        public async Task<ulong> NonFungibleAssetCreate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 38, 71, 48 };

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
            byte[] abiHandle = { 254, 38, 71, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task AssetOptIn(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 91, 8, 9 };
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
            byte[] abiHandle = { 67, 91, 8, 9 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task AssetTransfer(ulong asset, Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 103, 230, 251 };
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
            byte[] abiHandle = { 98, 103, 230, 251 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="acct_to_be_frozen"> </param>
        /// <param name="asset"> </param>
        public async Task AssetFreeze(Algorand.Address acct_to_be_frozen, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 121, 67, 39 };
            var acct_to_be_frozenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acct_to_be_frozenAbi.From(acct_to_be_frozen);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, acct_to_be_frozenAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetFreeze_Transactions(Algorand.Address acct_to_be_frozen, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 121, 67, 39 };
            var acct_to_be_frozenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acct_to_be_frozenAbi.From(acct_to_be_frozen);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, acct_to_be_frozenAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="account_to_be_revoked"> </param>
        /// <param name="amount"> </param>
        public async Task AssetRevoke(ulong asset, Algorand.Address account_to_be_revoked, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 37, 25, 249 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var account_to_be_revokedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); account_to_be_revokedAbi.From(account_to_be_revoked);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, account_to_be_revokedAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssetRevoke_Transactions(ulong asset, Algorand.Address account_to_be_revoked, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 37, 25, 249 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var account_to_be_revokedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); account_to_be_revokedAbi.From(account_to_be_revoked);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, account_to_be_revokedAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task AssetConfig(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 232, 13, 186 };
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
            byte[] abiHandle = { 133, 232, 13, 186 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        public async Task AssetDelete(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 73, 87, 194 };
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
            byte[] abiHandle = { 89, 73, 87, 194 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task<Structs.MultiInnerTxnsReturn> MultiInnerTxns(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 144, 236, 83 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MultiInnerTxnsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MultiInnerTxns_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 144, 236, 83 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///This method uses the itxn.ApplicationCall to deploy the HelloWorld contract.
        ///</summary>
        public async Task<ulong> DeployApp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 49, 116, 93 };

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
            byte[] abiHandle = { 54, 49, 116, 93 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///This method uses the arc4.arc4_create to deploy the HelloWorld contract.
        ///</summary>
        public async Task<ulong> Arc4DeployApp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 169, 177, 2 };

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
            byte[] abiHandle = { 16, 169, 177, 2 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task<Structs.NoopAppCallReturn> NoopAppCall(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 252, 228, 213 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NoopAppCallReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NoopAppCall_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 252, 228, 213 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW5uZXJUcmFuc2FjdGlvbnMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTXVsdGlJbm5lclR4bnNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XSwiTm9vcEFwcENhbGxSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZ2libGVfYXNzZXRfY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibm9uX2Z1bmdpYmxlX2Fzc2V0X2NyZWF0ZSIsImRlc2MiOiJGb2xsb3dpbmcgdGhlIEFSQzMgc3RhbmRhcmQsIHRoZSB0b3RhbCBzdXBwbHkgbXVzdCBiZSAxIGZvciBhIG5vbi1mdW5naWJsZSBhc3NldC5cbklmIHlvdSB3YW50IHRvIGNyZWF0ZSBmcmFjdGlvbmFsIE5GVHMsIGB0b3RhbGAgKiBgZGVjaW1hbHNgIHBvaW50IG11c3QgYmUgMS4gZXgpIHRvdGFsPTEwMCwgZGVjaW1hbHM9MiwgMTAwICogMC4wMSA9IDEiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldF9vcHRfaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXNzZXRfdHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2V0X2ZyZWV6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjdF90b19iZV9mcm96ZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2V0X3Jldm9rZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnRfdG9fYmVfcmV2b2tlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2V0X2NvbmZpZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldF9kZWxldGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXVsdGlfaW5uZXJfdHhucyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcpIiwic3RydWN0IjoiTXVsdGlJbm5lclR4bnNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBsb3lfYXBwIiwiZGVzYyI6IlRoaXMgbWV0aG9kIHVzZXMgdGhlIGl0eG4uQXBwbGljYXRpb25DYWxsIHRvIGRlcGxveSB0aGUgSGVsbG9Xb3JsZCBjb250cmFjdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM0X2RlcGxveV9hcHAiLCJkZXNjIjoiVGhpcyBtZXRob2QgdXNlcyB0aGUgYXJjNC5hcmM0X2NyZWF0ZSB0byBkZXBsb3kgdGhlIEhlbGxvV29ybGQgY29udHJhY3QuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibm9vcF9hcHBfY2FsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiTm9vcEFwcENhbGxSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExNl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwMyw3MDAsNzM0XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gbG9nIHZhbHVlIGlzIG5vdCB0aGUgcmVzdWx0IG9mIGFuIEFCSSByZXR1cm4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ05pQXpDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdNSGd3TW1KbFkyVXhNU0F3ZURBd01EVTFOelptTnpJMll6WTBJR0poYzJVMk5DaERORVZDVVhjOVBTa2dZbUZ6WlRZMEtFTjZSV0pSVVVGWlowRlJRM1p6TkZKT2FHOUJhbWRGUVVGUlFYaEhVbEY0UjBKQ1JWRm5RVWxOVW10VlRWSm5WVVZGVFRKSFowWllRV2REUVVJd2FHeGlSM2gyVEVOQ1RWVkZhMVpHYkdOSFFXdDRVV2RCVVZaSU0zZ3hWRVpEZDJkUlJrUXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakU1Q2lBZ0lDQXZMeUJqYkdGemN5QkpibTVsY2xSeVlXNXpZV04wYVc5dWN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qQUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNak01TlRBd01qY2dNSGhsWVRjMk9EbG1NeUF3ZUdabE1qWTBOek13SURCNE5ETTFZakE0TURrZ01IZzJNalkzWlRabVlpQXdlR0U1TnprME16STNJREI0TlRJeU5URTVaamtnTUhnNE5XVTRNR1JpWVNBd2VEVTVORGsxTjJNeUlEQjRObVk1TUdWak5UTWdNSGd6TmpNeE56UTFaQ0F3ZURFd1lUbGlNVEF5SURCNFl6ZG1ZMlUwWkRVZ0x5OGdiV1YwYUc5a0lDSndZWGx0Wlc1MEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltWjFibWRwWW14bFgyRnpjMlYwWDJOeVpXRjBaU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p1YjI1ZlpuVnVaMmxpYkdWZllYTnpaWFJmWTNKbFlYUmxLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbUZ6YzJWMFgyOXdkRjlwYmloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZWE56WlhSZmRISmhibk5tWlhJb2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRnpjMlYwWDJaeVpXVjZaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaGMzTmxkRjl5WlhadmEyVW9kV2x1ZERZMExHRmtaSEpsYzNNc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ6YzJWMFgyTnZibVpwWnloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZWE56WlhSZlpHVnNaWFJsS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnRkV3gwYVY5cGJtNWxjbDkwZUc1ektIVnBiblEyTkNrb2RXbHVkRFkwTEhOMGNtbHVaeWtpTENCdFpYUm9iMlFnSW1SbGNHeHZlVjloY0hBb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlYSmpORjlrWlhCc2IzbGZZWEJ3S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW01dmIzQmZZWEJ3WDJOaGJHd29kV2x1ZERZMEtTaHpkSEpwYm1jc2MzUnlhVzVuS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lIQmhlVzFsYm5RZ1puVnVaMmxpYkdWZllYTnpaWFJmWTNKbFlYUmxJRzV2Ymw5bWRXNW5hV0pzWlY5aGMzTmxkRjlqY21WaGRHVWdZWE56WlhSZmIzQjBYMmx1SUdGemMyVjBYM1J5WVc1elptVnlJR0Z6YzJWMFgyWnlaV1Y2WlNCaGMzTmxkRjl5WlhadmEyVWdZWE56WlhSZlkyOXVabWxuSUdGemMyVjBYMlJsYkdWMFpTQnRkV3gwYVY5cGJtNWxjbDkwZUc1eklHUmxjR3h2ZVY5aGNIQWdZWEpqTkY5a1pYQnNiM2xmWVhCd0lHNXZiM0JmWVhCd1gyTmhiR3dLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeU1Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVJQzh2SUc5dUlHVnljbTl5T2lCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVwYm01bGNsOTBjbUZ1YzJGamRHbHZibk11WTI5dWRISmhZM1F1U1c1dVpYSlVjbUZ1YzJGamRHbHZibk11Y0dGNWJXVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CaGVXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pJekNpQWdJQ0F2THlCeVpYTjFiSFFnUFNCcGRIaHVMbEJoZVcxbGJuUW9ZVzF2ZFc1MFBUVXdNREFzSUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0lHWmxaVDB3S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdjSFZ6YUdsdWRDQTFNREF3SUM4dklEVXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3lNQzB5TVFvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCUVFWbE5SVTVVQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMbU52Ym5SeVlXTjBMa2x1Ym1WeVZISmhibk5oWTNScGIyNXpMbVoxYm1kcFlteGxYMkZ6YzJWMFgyTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtWjFibWRwWW14bFgyRnpjMlYwWDJOeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TXpndE5ETUtJQ0FnSUM4dklHbDBlRzVmY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TURCZk1EQXdYekF3TUY4d01EQXNDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TWl3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbEpRSWl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQU0pTYjNsaGJIUjVJRkJ2YVc1MGN5SXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQU0pTYjNsaGJIUjVJRkJ2YVc1MGN5SXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsSnZlV0ZzZEhrZ1VHOXBiblJ6SWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDBpVWxBaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKU1VDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzBNQW9nSUNBZ0x5OGdaR1ZqYVcxaGJITTlNaXdLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUhSdmRHRnNQVEV3TUY4d01EQmZNREF3WHpBd01Dd0tJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3TURBd0lDOHZJREV3TURBd01EQXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJwZEhodVgzSmxjM1ZzZENBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0JwYm5Salh6TWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pNNExUUXpDaUFnSUNBdkx5QnBkSGh1WDNKbGMzVnNkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5TVRBd1h6QXdNRjh3TURCZk1EQXdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRJc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pTVUNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDBpVW05NVlXeDBlU0JRYjJsdWRITWlMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRnpjMlYwU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk16VXRNellLSUNBZ0lDOHZJQ01nWlhoaGJYQnNaVG9nUVZOVFJWUmZRMUpGUVZSRkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTVqYjI1MGNtRmpkQzVKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTV1YjI1ZlpuVnVaMmxpYkdWZllYTnpaWFJmWTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYm05dVgyWjFibWRwWW14bFgyRnpjMlYwWDJOeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TlRRdE5qUUtJQ0FnSUM4dklHbDBlRzVmY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TURBc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTlNaXdLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBYMjVoYldVOUlrMU1JaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBTSk5iMjVoSUV4cGMyRWlMQW9nSUNBZ0x5OGdJQ0FnSUhWeWJEMGlhSFIwY0hNNkx5OXNhVzVyWDNSdlgybHdabk12VFc5dVlWOU1hWE5oSWl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzJNUzAyTXdvZ0lDQWdMeThnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdabkpsWlhwbFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlCamJHRjNZbUZqYXoxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaSFZ3YmlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFEyeGhkMkpoWTJzS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSR2NtVmxlbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJTWlhObGNuWmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdkWEpzUFNKb2RIUndjem92TDJ4cGJtdGZkRzlmYVhCbWN5OU5iMjVoWDB4cGMyRWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklDSm9kSFJ3Y3pvdkwyeHBibXRmZEc5ZmFYQm1jeTlOYjI1aFgweHBjMkVpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlZKTUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQU0pOYjI1aElFeHBjMkVpTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pOYjI1aElFeHBjMkVpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pOVENJc0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWsxTUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QmtaV05wYldGc2N6MHlMQW9nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldOcGJXRnNjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnZEc5MFlXdzlNVEF3TEFvZ0lDQWdjSFZ6YUdsdWRDQXhNREFnTHk4Z01UQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklHbDBlRzVmY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lHbHVkR05mTXlBdkx5QmhZMlpuQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZOVFF0TmpRS0lDQWdJQzh2SUdsMGVHNWZjbVZ6ZFd4MElEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMHhNREFzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOU1pd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5SWsxTUlpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKTmIyNWhJRXhwYzJFaUxBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQwaWFIUjBjSE02THk5c2FXNXJYM1J2WDJsd1puTXZUVzl1WVY5TWFYTmhJaXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXVZMjl1ZEhKaFkzUXVTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXVZWE56WlhSZmIzQjBYMmx1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYTnpaWFJmYjNCMFgybHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG8zTUMwM01Rb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQkJVMU5GVkY5UFVGUmZTVTRLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TnpNdE56Z0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk56WUtJQ0FnSUM4dklHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TnpNS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzNOd29nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk56TXROemdLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG8zTUMwM01Rb2dJQ0FnTHk4Z0l5QmxlR0Z0Y0d4bE9pQkJVMU5GVkY5UFVGUmZTVTRLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekxtTnZiblJ5WVdOMExrbHVibVZ5VkhKaGJuTmhZM1JwYjI1ekxtRnpjMlYwWDNSeVlXNXpabVZ5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYTnpaWFJmZEhKaGJuTm1aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pnNUxUa3dDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRUZUVTBWVVgxUlNRVTVUUmtWU0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qa3lMVGszQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5Y21WalpXbDJaWElzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2prMkNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG81TWkwNU53b2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYSmxZMlZwZG1WeUxBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pnNUxUa3dDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRUZUVTBWVVgxUlNRVTVUUmtWU0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTVqYjI1MGNtRmpkQzVKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTVoYzNObGRGOW1jbVZsZW1WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjM05sZEY5bWNtVmxlbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pFd09DMHhNRGtLSUNBZ0lDOHZJQ01nWlhoaGJYQnNaVG9nUVZOVFJWUmZSbEpGUlZwRkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qRXhNUzB4TVRZS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSR2NtVmxlbVVvQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsWDJGalkyOTFiblE5WVdOamRGOTBiMTlpWlY5bWNtOTZaVzRzSUNBaklHRmpZMjkxYm5RZ2RHOGdZbVVnWm5KdmVtVnVDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHWnliM3BsYmoxVWNuVmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3hNVFFLSUNBZ0lDOHZJR1p5YjNwbGJqMVVjblZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbkpsWlhwbFFYTnpaWFJHY205NlpXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JuSmxaWHBsUVhOelpYUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JuSmxaWHBsUVhOelpYUkJZMk52ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qRXhNUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRVp5WldWNlpTZ0tJQ0FnSUhCMWMyaHBiblFnTlNBdkx5Qmhabko2Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZNVEV4TFRFeE5nb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFWnlaV1Y2WlNnS0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1WZllXTmpiM1Z1ZEQxaFkyTjBYM1J2WDJKbFgyWnliM3BsYml3Z0lDTWdZV05qYjNWdWRDQjBieUJpWlNCbWNtOTZaVzRLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVZmWVhOelpYUTlZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdabkp2ZW1WdVBWUnlkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG94TURndE1UQTVDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRUZUVTBWVVgwWlNSVVZhUlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXVZMjl1ZEhKaFkzUXVTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXVZWE56WlhSZmNtVjJiMnRsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYTnpaWFJmY21WMmIydGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG94TWpRdE1USTFDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRUZUVTBWVVgxSkZWazlMUlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveE1qa3RNVE0xQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNObGJtUmxjajFoWTJOdmRXNTBYM1J2WDJKbFgzSmxkbTlyWldRc0lDQWpJRUZ6YzJWMFUyVnVaR1Z5SUdseklHOXViSGtnZFhObFpDQnBiaUIwYUdVZ1kyRnpaU0J2WmlCamJHRjNZbUZqYXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qRXpNQW9nSUNBZ0x5OGdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJUWlc1a1pYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUxURXpOUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl6Wlc1a1pYSTlZV05qYjNWdWRGOTBiMTlpWlY5eVpYWnZhMlZrTENBZ0l5QkJjM05sZEZObGJtUmxjaUJwY3lCdmJteDVJSFZ6WldRZ2FXNGdkR2hsSUdOaGMyVWdiMllnWTJ4aGQySmhZMnNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1USTBMVEV5TlFvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCQlUxTkZWRjlTUlZaUFMwVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TG1OdmJuUnlZV04wTGtsdWJtVnlWSEpoYm5OaFkzUnBiMjV6TG1GemMyVjBYMk52Ym1acFoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ6YzJWMFgyTnZibVpwWnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1UUTFMVEUwTmdvZ0lDQWdMeThnSXlCbGVHRnRjR3hsT2lCQlUxTkZWRjlEVDA1R1NVY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdlkyOXVkSEpoWTNRdWNIazZNVFE0TFRFMU5Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQmpiMjVtYVdkZllYTnpaWFE5WVhOelpYUXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbWNtVmxlbVU5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakUxTVFvZ0lDQWdMeThnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakUxTWdvZ0lDQWdMeThnWm5KbFpYcGxQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakUxTXdvZ0lDQWdMeThnWTJ4aGQySmhZMnM5VkhodUxuTmxibVJsY2l3S0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVOc1lYZGlZV05yQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUm5KbFpYcGxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1UUTRDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1UVTBDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveE5EZ3RNVFUxQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdOdmJtWnBaMTloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveE5EVXRNVFEyQ2lBZ0lDQXZMeUFqSUdWNFlXMXdiR1U2SUVGVFUwVlVYME5QVGtaSlJ3b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVwYm01bGNsOTBjbUZ1YzJGamRHbHZibk11WTI5dWRISmhZM1F1U1c1dVpYSlVjbUZ1YzJGamRHbHZibk11WVhOelpYUmZaR1ZzWlhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWE56WlhSZlpHVnNaWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveE5qWXRNVFkzQ2lBZ0lDQXZMeUFqSUdWNFlXMXdiR1U2SUVGVFUwVlVYMFJGVEVWVVJRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3hOamt0TVRjeUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHTnZibVpwWjE5aGMzTmxkRDFoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1UWTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1UY3hDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveE5qa3RNVGN5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdOdmJtWnBaMTloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pFMk5pMHhOamNLSUNBZ0lDOHZJQ01nWlhoaGJYQnNaVG9nUVZOVFJWUmZSRVZNUlZSRkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTVqYjI1MGNtRmpkQzVKYm01bGNsUnlZVzV6WVdOMGFXOXVjeTV0ZFd4MGFWOXBibTVsY2w5MGVHNXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYlhWc2RHbGZhVzV1WlhKZmRIaHVjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRjMkxURTNOd29nSUNBZ0x5OGdJeUJsZUdGdGNHeGxPaUJIVWs5VlVFVkVYMGxPVGtWU1gxUllUbE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZMjl1ZEhKaFkzUXVjSGs2TVRjNUNpQWdJQ0F2THlCd1lYbHRaVzUwWDNCaGNtRnRjeUE5SUdsMGVHNHVVR0Y1YldWdWRDaGhiVzkxYm5ROU5UQXdNQ3dnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3Z1ptVmxQVEFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakU0TndvZ0lDQWdMeThnY0dGNVgzUjRiaXdnWVhCd1gyTmhiR3hmZEhodUlEMGdhWFI0Ymk1emRXSnRhWFJmZEhodWN5aHdZWGx0Wlc1MFgzQmhjbUZ0Y3l3Z1lYQndYMk5oYkd4ZmNHRnlZVzF6S1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3hOemtLSUNBZ0lDOHZJSEJoZVcxbGJuUmZjR0Z5WVcxeklEMGdhWFI0Ymk1UVlYbHRaVzUwS0dGdGIzVnVkRDAxTURBd0xDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQ0JtWldVOU1Da0tJQ0FnSUhCMWMyaHBiblFnTlRBd01DQXZMeUExTURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qRTROd29nSUNBZ0x5OGdjR0Y1WDNSNGJpd2dZWEJ3WDJOaGJHeGZkSGh1SUQwZ2FYUjRiaTV6ZFdKdGFYUmZkSGh1Y3lod1lYbHRaVzUwWDNCaGNtRnRjeXdnWVhCd1gyTmhiR3hmY0dGeVlXMXpLUW9nSUNBZ2FYUjRibDl1WlhoMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qRTRNd29nSUNBZ0x5OGdZWEJ3WDJGeVozTTlLR0Z5WXpRdVlYSmpORjl6YVdkdVlYUjFjbVVvSW1obGJHeHZLSE4wY21sdVp5bHpkSEpwYm1jaUtTd2dZWEpqTkM1VGRISnBibWNvSWxkdmNteGtJaWtwTEFvZ0lDQWdZbmwwWldOZk1TQXZMeUJ0WlhSb2IyUWdJbWhsYkd4dktITjBjbWx1WnlsemRISnBibWNpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNRFUxTnpabU56STJZelkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakU0TVFvZ0lDQWdMeThnWVhCd1gyTmhiR3hmY0dGeVlXMXpJRDBnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0JwYm5Salh6SWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveE9EUUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pFNE53b2dJQ0FnTHk4Z2NHRjVYM1I0Yml3Z1lYQndYMk5oYkd4ZmRIaHVJRDBnYVhSNGJpNXpkV0p0YVhSZmRIaHVjeWh3WVhsdFpXNTBYM0JoY21GdGN5d2dZWEJ3WDJOaGJHeGZjR0Z5WVcxektRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2RwZEhodUlEQWdRVzF2ZFc1MENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1UZzVDaUFnSUNBdkx5Qm9aV3hzYjE5M2IzSnNaRjl5WlhOMWJIUWdQU0JoY21NMExsTjBjbWx1Wnk1bWNtOXRYMnh2WnloaGNIQmZZMkZzYkY5MGVHNHViR0Z6ZEY5c2IyY3BDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR3h2WnlCMllXeDFaU0JwY3lCdWIzUWdkR2hsSUhKbGMzVnNkQ0J2WmlCaGJpQkJRa2tnY21WMGRYSnVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakUzTmkweE56Y0tJQ0FnSUM4dklDTWdaWGhoYlhCc1pUb2dSMUpQVlZCRlJGOUpUazVGVWw5VVdFNVRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREJoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVwYm01bGNsOTBjbUZ1YzJGamRHbHZibk11WTI5dWRISmhZM1F1U1c1dVpYSlVjbUZ1YzJGamRHbHZibk11WkdWd2JHOTVYMkZ3Y0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxjR3h2ZVY5aGNIQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakl3T1MweU1UTUtJQ0FnSUM4dklHRndjRjkwZUc0Z1BTQnBkSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCaGNIQnliM1poYkY5d2NtOW5jbUZ0UFdOdmJYQnBiR1ZrWDJOdmJuUnlZV04wTG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJUMWpiMjF3YVd4bFpGOWpiMjUwY21GamRDNWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3lNRGNLSUNBZ0lDOHZJR052YlhCcGJHVmtYMk52Ym5SeVlXTjBJRDBnWTI5dGNHbHNaVjlqYjI1MGNtRmpkQ2hJWld4c2IxZHZjbXhrS1FvZ0lDQWdZbmwwWldOZk15QXZMeUJpWVhObE5qUW9RelJGUWxGM1BUMHBDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnNaV0Z5VTNSaGRHVlFjbTluY21GdFVHRm5aWE1LSUNBZ0lHSjVkR1ZqSURRZ0x5OGdZbUZ6WlRZMEtFTjZSV0pSVVVGWlowRlJRM1p6TkZKT2FHOUJhbWRGUVVGUlFYaEhVbEY0UjBKQ1JWRm5RVWxOVW10VlRWSm5WVVZGVFRKSFowWllRV2REUVVJd2FHeGlSM2gyVEVOQ1RWVkZhMVpHYkdOSFFXdDRVV2RCVVZaSU0zZ3hWRVpEZDJkUlJrUXBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlZCaFoyVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnWVhCd1gzUjRiaUE5SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnYVc1MFkxOHlJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WTI5dWRISmhZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveU1Ea3RNakV6Q2lBZ0lDQXZMeUJoY0hCZmRIaHVJRDBnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0F2THlBZ0lDQWdZWEJ3Y205MllXeGZjSEp2WjNKaGJUMWpiMjF3YVd4bFpGOWpiMjUwY21GamRDNWhjSEJ5YjNaaGJGOXdjbTluY21GdExBb2dJQ0FnTHk4Z0lDQWdJR05zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzA5WTI5dGNHbHNaV1JmWTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qSXdNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdVkyOXVkSEpoWTNRdVNXNXVaWEpVY21GdWMyRmpkR2x2Ym5NdVlYSmpORjlrWlhCc2IzbGZZWEJ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYSmpORjlrWlhCc2IzbGZZWEJ3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveU1qTUtJQ0FnSUM4dklHRndjRjkwZUc0Z1BTQmhjbU0wTG1GeVl6UmZZM0psWVhSbEtFaGxiR3h2VjI5eWJHUXBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUdKaGMyVTJOQ2hETkVWQ1VYYzlQU2tLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMVFZV2RsY3dvZ0lDQWdZbmwwWldNZ05DQXZMeUJpWVhObE5qUW9RM3BGWWxGUlFWbG5RVkZEZG5NMFVrNW9iMEZxWjBWQlFWRkJlRWRTVVhoSFFrSkZVV2RCU1UxU2ExVk5VbWRWUlVWTk1rZG5SbGhCWjBOQlFqQm9iR0pIZUhaTVEwSk5WVVZyVmtac1kwZEJhM2hSWjBGUlZrZ3plREZVUmtOM1oxRkdSQ2tLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3Y205MllXeFFjbTluY21GdFVHRm5aWE1LSUNBZ0lHbHVkR05mTWlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXVZMjl1ZEhKaFkzUXVTVzV1WlhKVWNtRnVjMkZqZEdsdmJuTXVibTl2Y0Y5aGNIQmZZMkZzYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtNXZiM0JmWVhCd1gyTmhiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pJeU9TMHlNekFLSUNBZ0lDOHZJQ01nWlhoaGJYQnNaVG9nVGs5UFVGOUJVRkJmUTBGTVRBb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3lNekl0TWpNMkNpQWdJQ0F2THlBaklHbHVkbTlyWlNCaGJpQkJRa2tnYldWMGFHOWtDaUFnSUNBdkx5QmpZV3hzWDNSNGJpQTlJR2wwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzS0FvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxaGNIQmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMkZ5WjNNOUtHRnlZelF1WVhKak5GOXphV2R1WVhSMWNtVW9JbWhsYkd4dktITjBjbWx1WnlsemRISnBibWNpS1N3Z1lYSmpOQzVUZEhKcGJtY29JbGR2Y214a0lpa3BMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5amIyNTBjbUZqZEM1d2VUb3lNelVLSUNBZ0lDOHZJR0Z3Y0Y5aGNtZHpQU2hoY21NMExtRnlZelJmYzJsbmJtRjBkWEpsS0NKb1pXeHNieWh6ZEhKcGJtY3BjM1J5YVc1bklpa3NJR0Z5WXpRdVUzUnlhVzVuS0NKWGIzSnNaQ0lwS1N3S0lDQWdJR0o1ZEdWalh6RWdMeThnYldWMGFHOWtJQ0pvWld4c2J5aHpkSEpwYm1jcGMzUnlhVzVuSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREExTlRjMlpqY3lObU0yTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyTnZiblJ5WVdOMExuQjVPakl6TWkweU16TUtJQ0FnSUM4dklDTWdhVzUyYjJ0bElHRnVJRUZDU1NCdFpYUm9iMlFLSUNBZ0lDOHZJR05oYkd4ZmRIaHVJRDBnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0JwYm5Salh6SWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pJek1pMHlNellLSUNBZ0lDOHZJQ01nYVc1MmIydGxJR0Z1SUVGQ1NTQnRaWFJvYjJRS0lDQWdJQzh2SUdOaGJHeGZkSGh1SUQwZ2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQV0Z3Y0Y5cFpDd0tJQ0FnSUM4dklDQWdJQ0JoY0hCZllYSm5jejBvWVhKak5DNWhjbU0wWDNOcFoyNWhkSFZ5WlNnaWFHVnNiRzhvYzNSeWFXNW5LWE4wY21sdVp5SXBMQ0JoY21NMExsTjBjbWx1WnlnaVYyOXliR1FpS1Nrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk52Ym5SeVlXTjBMbkI1T2pJek55MHlNemdLSUNBZ0lDOHZJQ01nWlhoMGNtRmpkQ0J5WlhOMWJIUUtJQ0FnSUM4dklHWnBjbk4wWDJobGJHeHZYM2R2Y214a1gzSmxjM1ZzZENBOUlHRnlZelF1VTNSeWFXNW5MbVp5YjIxZmJHOW5LR05oYkd4ZmRIaHVMbXhoYzNSZmJHOW5LUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJzYjJjZ2RtRnNkV1VnYVhNZ2JtOTBJSFJvWlNCeVpYTjFiSFFnYjJZZ1lXNGdRVUpKSUhKbGRIVnliZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG95TkRBdE1qUTFDaUFnSUNBdkx5QWpJRTlTTENCallXeHNJR2wwSUdGMWRHOXRZWFJwWXlCQlVrTTBJR1Z1WTI5a2FXNW5MQ0IwZVhCbElIWmhiR2xrWVhScGIyNGdZVzVrSUhKbGMzVnNkQ0JvWVc1a2JHbHVad29nSUNBZ0x5OGdjMlZqYjI1a1gyaGxiR3h2WDNkdmNteGtYM0psYzNWc2RDd2dZMkZzYkY5MGVHNGdQU0JoY21NMExtRmlhVjlqWVd4c0tDQWdJeUJrWldOc1lYSmxJSEpsZEhWeWJpQjBlWEJsQ2lBZ0lDQXZMeUFnSUNBZ1NHVnNiRzlYYjNKc1pDNW9aV3hzYnl3Z0lDTWdiV1YwYUc5a0lITnBaMjVoZEhWeVpTQjBieUJqWVd4c0NpQWdJQ0F2THlBZ0lDQWdJbUZuWVdsdUlpd2dJQ01nWVdKcElHMWxkR2h2WkNCaGNtZDFiV1Z1ZEhNS0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVlYQndYMmxrTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJRzFsZEdodlpDQWlhR1ZzYkc4b2MzUnlhVzVuS1hOMGNtbHVaeUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJOdmJuUnlZV04wTG5CNU9qSTBNd29nSUNBZ0x5OGdJbUZuWVdsdUlpd2dJQ01nWVdKcElHMWxkR2h2WkNCaGNtZDFiV1Z1ZEhNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EVTJNVFkzTmpFMk9UWmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqYjI1MGNtRmpkQzV3ZVRveU5EQXRNalExQ2lBZ0lDQXZMeUFqSUU5U0xDQmpZV3hzSUdsMElHRjFkRzl0WVhScFl5QkJVa00wSUdWdVkyOWthVzVuTENCMGVYQmxJSFpoYkdsa1lYUnBiMjRnWVc1a0lISmxjM1ZzZENCb1lXNWtiR2x1WndvZ0lDQWdMeThnYzJWamIyNWtYMmhsYkd4dlgzZHZjbXhrWDNKbGMzVnNkQ3dnWTJGc2JGOTBlRzRnUFNCaGNtTTBMbUZpYVY5allXeHNLQ0FnSXlCa1pXTnNZWEpsSUhKbGRIVnliaUIwZVhCbENpQWdJQ0F2THlBZ0lDQWdTR1ZzYkc5WGIzSnNaQzVvWld4c2J5d2dJQ01nYldWMGFHOWtJSE5wWjI1aGRIVnlaU0IwYnlCallXeHNDaUFnSUNBdkx5QWdJQ0FnSW1GbllXbHVJaXdnSUNNZ1lXSnBJRzFsZEdodlpDQmhjbWQxYldWdWRITUtJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTlZWEJ3WDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVc1MFkxOHlJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUd4dlp5QjJZV3gxWlNCcGN5QnViM1FnZEdobElISmxjM1ZzZENCdlppQmhiaUJCUWtrZ2NtVjBkWEp1Q2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpiMjUwY21GamRDNXdlVG95TWprdE1qTXdDaUFnSUNBdkx5QWpJR1Y0WVcxd2JHVTZJRTVQVDFCZlFWQlFYME5CVEV3S0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFHQXlZRkJCVWZmSFVFQXI3T0VRY0FCVmR2Y214a0JBdUJBVU5MQ3pFYlFRQVlnQVFDdnM0Uk5ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVNMkdnRlhBZ0NBQjBobGJHeHZMQ0JNVUVrVkZsY0dBa3hRZ0FRVkgzeDFURkN3Z1FGRE1SdEJBR294R1JSRU1SaEVnZzBFSTVVQUp3VHFkb256QlA0bVJ6QUVRMXNJQ1FSaVorYjdCS2w1UXljRVVpVVorUVNGNkEyNkJGbEpWOElFYjVEc1V3UTJNWFJkQkJDcHNRSUV4L3prMVRZYUFJNE5BQWtBSXdCWkFMTUF5d0RuQVFBQklBRStBVTRCa1FHcEFjRUFNUmtVTVJnVUVFT3hNUUN5QjRHSUo3SUlJcklRSTdJQnM3UUlGaWhNVUxBaVE3R0FEbEp2ZVdGc2RIa2dVRzlwYm5SenNpYUFBbEpRc2lXQkFySWpnWURRMjhQMEFySWlKYklRSTdJQnM3UThGaWhNVUxBaVE3RXlDa2NEc2l5eUs3SXFzaW1BSG1oMGRIQnpPaTh2YkdsdWExOTBiMTlwY0daekwwMXZibUZmVEdselliSW5nQWxOYjI1aElFeHBjMkd5Sm9BQ1RVeXlKWUVDc2lPQlpMSWlKYklRSTdJQnM3UThGaWhNVUxBaVF6WWFBUmV4TWdvanNoS3lGTElSZ1FTeUVDT3lBYk1pUXpZYUFSYzJHZ0kyR2dNWHNiSVNzaFN5RVlFRXNoQWpzZ0d6SWtNMkdnRTJHZ0lYc1NLeUw3SXRzaTZCQmJJUUk3SUJzeUpETmhvQkZ6WWFBallhQXhleE1ncXlGTElTc2hPeUVZRUVzaEFqc2dHeklrTTJHZ0VYc1RJS1NURUFTYklzc2l1eUtySXBzaUVsc2hBanNnR3pJa00yR2dFWHNiSWhKYklRSTdJQnN5SkROaG9CRnpFQXNiSUhnWWduc2dnaXNoQWpzZ0cyS2JJYUtySWFzaGdrc2hBanNnR3p0d0FJdEQ1SlZ3UUFURmNBQkNnU1JFd1dnQUlBQ2xCTVVDaE1VTEFpUTdFcnNrSW5CTEpBSkxJUUk3SUJzN1E5RmloTVVMQWlRN0Vyc2tJbkJMSkFKTElRSTdJQnM3UTlGaWhNVUxBaVF6WWFBUmV4S2JJYUtySWFTYklZSkxJUUk3SUJzN1ErU1ZjRUFFeFhBQVFvRWtTeFRMSVlLYklhZ0FjQUJXRm5ZV2x1c2hva3NoQWpzZ0d6dEQ1SlZ3QUVLQkpFVndZQVN3RVZnUVFJU3dFVkZsY0dBazhDVUV3V1Z3WUNnQUlBQkV4UVR3SlFURkFvVEZDd0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjowLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
