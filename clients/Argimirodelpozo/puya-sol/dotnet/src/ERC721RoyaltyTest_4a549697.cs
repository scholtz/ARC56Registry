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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.ERC721RoyaltyTest_4a549697
{


    public class ERC721RoyaltyTestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ERC721RoyaltyTestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RoyaltyInfo : AVMObjectType
            {
                public byte[] Receiver { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 RoyaltyFraction { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRoyaltyFraction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vRoyaltyFraction.From(RoyaltyFraction);
                    ret.AddRange(vRoyaltyFraction.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RoyaltyInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RoyaltyInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    var vRoyaltyFraction = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vRoyaltyFraction.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.RoyaltyFraction = vRoyaltyFraction;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RoyaltyInfo);
                }
                public bool Equals(RoyaltyInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RoyaltyInfo left, RoyaltyInfo right)
                {
                    return EqualityComparer<RoyaltyInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(RoyaltyInfo left, RoyaltyInfo right)
                {
                    return !(left == right);
                }

            }

            public class RoyaltyInfoReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
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

                public static RoyaltyInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RoyaltyInfoReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RoyaltyInfoReturn);
                }
                public bool Equals(RoyaltyInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RoyaltyInfoReturn left, RoyaltyInfoReturn right)
                {
                    return EqualityComparer<RoyaltyInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(RoyaltyInfoReturn left, RoyaltyInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="tokenId"> </param>
        public async Task Mint(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 85, 136, 234 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Mint_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 85, 136, 234 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="feeNumerator"> </param>
        public async Task SetDefaultRoyalty(Algorand.Address receiver, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 feeNumerator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 142, 72, 133 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, feeNumerator }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetDefaultRoyalty_Transactions(Algorand.Address receiver, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 feeNumerator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 142, 72, 133 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, feeNumerator }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        /// <param name="receiver"> </param>
        /// <param name="feeNumerator"> </param>
        public async Task SetTokenRoyalty(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Algorand.Address receiver, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 feeNumerator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 78, 187, 95 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, tokenId, receiverAbi, feeNumerator }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTokenRoyalty_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Algorand.Address receiver, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 feeNumerator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 78, 187, 95 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId, receiverAbi, feeNumerator }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        public async Task Burn(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 19, 205, 87 };

            var result = await base.CallApp(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Burn_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 19, 205, 87 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="interfaceId"> </param>
        public async Task<bool> SupportsInterface(byte[] interfaceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 34, 163, 186 };
            var interfaceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); interfaceIdAbi.From(interfaceId);

            var result = await base.SimApp(new List<object> { abiHandle, interfaceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SupportsInterface_Transactions(byte[] interfaceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 34, 163, 186 };
            var interfaceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); interfaceIdAbi.From(interfaceId);

            return await base.MakeTransactionList(new List<object> { abiHandle, interfaceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> BalanceOf(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 12, 144, 177 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 12, 144, 177 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        public async Task<Algorand.Address> OwnerOf(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 54, 245, 99 };

            var result = await base.SimApp(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> OwnerOf_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 54, 245, 99 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Name(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 117, 6, 22 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Name_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 117, 6, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Symbol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 91, 82, 184 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Symbol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 91, 82, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        public async Task<string> TokenUri(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 183, 155, 30 };

            var result = await base.SimApp(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TokenUri_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 183, 155, 30 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="tokenId"> </param>
        public async Task Approve(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 186, 164, 165 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Approve_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 186, 164, 165 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        public async Task<Algorand.Address> GetApproved(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 58, 20, 252 };

            var result = await base.SimApp(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetApproved_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 58, 20, 252 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="operator"> </param>
        /// <param name="approved"> </param>
        public async Task SetApprovalForAll(Algorand.Address @operator, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 226, 107, 156 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, operatorAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetApprovalForAll_Transactions(Algorand.Address @operator, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 226, 107, 156 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="operator"> </param>
        public async Task<bool> IsApprovedForAll(Algorand.Address owner, Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 5, 196, 111 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsApprovedForAll_Transactions(Algorand.Address owner, Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 5, 196, 111 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="to"> </param>
        /// <param name="tokenId"> </param>
        public async Task TransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 205, 25, 225 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 205, 25, 225 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="to"> </param>
        /// <param name="tokenId"> </param>
        public async Task SafeTransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 36, 204, 190 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SafeTransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 36, 204, 190 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="to"> </param>
        /// <param name="tokenId"> </param>
        /// <param name="data"> </param>
        public async Task SafeTransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 61, 23, 96 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, tokenId, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SafeTransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 61, 23, 96 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, tokenId, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        /// <param name="salePrice"> </param>
        public async Task<Structs.RoyaltyInfoReturn> RoyaltyInfo(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 salePrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 44, 191, 137 };

            var result = await base.SimApp(new List<object> { abiHandle, tokenId, salePrice }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RoyaltyInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RoyaltyInfo_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 tokenId, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 salePrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 44, 191, 137 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId, salePrice }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRVJDNzIxUm95YWx0eVRlc3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUm95YWx0eUluZm8iOlt7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJyb3lhbHR5RnJhY3Rpb24iLCJ0eXBlIjoidWludDUxMiJ9XSwiUm95YWx0eUluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NTEyIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im1pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXREZWZhdWx0Um95YWx0eSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVOdW1lcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VG9rZW5Sb3lhbHR5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVOdW1lcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdXBwb3J0c0ludGVyZmFjZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJmYWNlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiYWxhbmNlT2YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3duZXJPZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN5bWJvbCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9rZW5VUkkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBcHByb3ZlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldEFwcHJvdmFsRm9yQWxsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzQXBwcm92ZWRGb3JBbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlckZyb20iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2FmZVRyYW5zZmVyRnJvbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzYWZlVHJhbnNmZXJGcm9tIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJveWFsdHlJbmZvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsZVByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ1MTIpIiwic3RydWN0IjoiUm95YWx0eUluZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzk0XSwiZXJyb3JNZXNzYWdlIjoiRVJDMjk4MUludmFsaWREZWZhdWx0Um95YWx0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMF0sImVycm9yTWVzc2FnZSI6IkVSQzI5ODFJbnZhbGlkRGVmYXVsdFJveWFsdHlSZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0NV0sImVycm9yTWVzc2FnZSI6IkVSQzI5ODFJbnZhbGlkVG9rZW5Sb3lhbHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxXSwiZXJyb3JNZXNzYWdlIjoiRVJDMjk4MUludmFsaWRUb2tlblJveWFsdHlSZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODddLCJlcnJvck1lc3NhZ2UiOiJFUkM3MjFJbmNvcnJlY3RPd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOTddLCJlcnJvck1lc3NhZ2UiOiJFUkM3MjFJbnN1ZmZpY2llbnRBcHByb3ZhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzldLCJlcnJvck1lc3NhZ2UiOiJFUkM3MjFJbnZhbGlkQXBwcm92ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzFdLCJlcnJvck1lc3NhZ2UiOiJFUkM3MjFJbnZhbGlkT3BlcmF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTddLCJlcnJvck1lc3NhZ2UiOiJFUkM3MjFJbnZhbGlkT3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTksMTA3M10sImVycm9yTWVzc2FnZSI6IkVSQzcyMUludmFsaWRSZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2N10sImVycm9yTWVzc2FnZSI6IkVSQzcyMUludmFsaWRTZW5kZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDEsMTE5OCwxMzg0XSwiZXJyb3JNZXNzYWdlIjoiRVJDNzIxTm9uZXhpc3RlbnRUb2tlbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfZGVmYXVsdFJveWFsdHlJbmZvIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9uYW1lIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9zeW1ib2wgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzIxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDUsMzc3LDQyOCw1NTIsNjY3LDcxMyw3NjQsNzcyLDc5Niw4MDQsODI1LDgzMyw4NTQsODYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MywzODYsNDIwLDQzNyw0OTEsNTg5LDY0NCw2NzUsNjkxLDgxMiw4NDEsODcwLDg5Niw5MDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAzLDQ1NCw1NzIsMTAzMV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiM0JsYm5wbGNIQmxiR2x1TDJOdmJuUnlZV04wY3k5RlVrTTNNakZTYjNsaGJIUjVMbk52YkM1RlVrTTNNakZTYjNsaGJIUjVWR1Z6ZEM1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRFkwSURFZ016SWdNQ0F4TURBd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdNSGd4TlRGbU4yTTNOU0F3ZUNBaVgyUmxabUYxYkhSU2IzbGhiSFI1U1c1bWJ5SWdJbDl1WVcxbElpQWlYM041YldKdmJDSWdJbDlpWVd4aGJtTmxjeUlnSWw5MGIydGxibEp2ZVdGc2RIbEpibVp2SWlBaVgyOXdaWEpoZEc5eVFYQndjbTkyWVd4eklpQWlYMjkzYm1WeWN5SWdJbDkwYjJ0bGJrRndjSEp2ZG1Gc2N5SUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWalh6TWdMeThnSWw5a1pXWmhkV3gwVW05NVlXeDBlVWx1Wm04aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVgyNWhiV1VpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDNONWJXSnZiQ0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pmYm1GdFpTSUtJQ0FnSUhCMWMyaGllWFJsY3lBaVVtOTVZV3gwZVU1R1ZDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmZjM2x0WW05c0lnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKU1RrWlVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpqazFOVGc0WldFZ01IZ3laVGhsTkRnNE5TQXdlREl3TkdWaVlqVm1JREI0WXpBeE0yTmtOVGNnTUhnMFpUSXlZVE5pWVNBd2VHTTVNR001TUdJeElEQjRPVGN6Tm1ZMU5qTWdNSGd4T1RjMU1EWXhOaUF3ZURBd05XSTFNbUk0SURCNFpHTmlOemxpTVdVZ01IZzFPV0poWVRSaE5TQXdlRFEzTTJFeE5HWmpJREI0TWpsbE1qWmlPV01nTUhnMU1EQTFZelEyWmlBd2VEazNZMlF4T1dVeElEQjRPV015TkdOalltVWdNSGcwT1ROa01UYzJNQ0F3ZUdRMU1tTmlaamc1SUM4dklHMWxkR2h2WkNBaWJXbHVkQ2hoWkdSeVpYTnpMSFZwYm5RMU1USXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBSR1ZtWVhWc2RGSnZlV0ZzZEhrb1lXUmtjbVZ6Y3l4MWFXNTBOVEV5S1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEZSdmEyVnVVbTk1WVd4MGVTaDFhVzUwTlRFeUxHRmtaSEpsYzNNc2RXbHVkRFV4TWlsMmIybGtJaXdnYldWMGFHOWtJQ0ppZFhKdUtIVnBiblExTVRJcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzNWd2NHOXlkSE5KYm5SbGNtWmhZMlVvWW5sMFpWczBYU2xpYjI5c0lpd2diV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTlRFeUlpd2diV1YwYUc5a0lDSnZkMjVsY2s5bUtIVnBiblExTVRJcFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaWJtRnRaU2dwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0p6ZVcxaWIyd29LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkRzlyWlc1VlVra29kV2x1ZERVeE1pbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltRndjSEp2ZG1Vb1lXUmtjbVZ6Y3l4MWFXNTBOVEV5S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEVGd2NISnZkbVZrS0hWcGJuUTFNVElwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpYzJWMFFYQndjbTkyWVd4R2IzSkJiR3dvWVdSa2NtVnpjeXhpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW1selFYQndjbTkyWldSR2IzSkJiR3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luUnlZVzV6Wm1WeVJuSnZiU2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERVeE1pbDJiMmxrSWl3Z2JXVjBhRzlrSUNKellXWmxWSEpoYm5ObVpYSkdjbTl0S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5URXlLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmhabVZVY21GdWMyWmxja1p5YjIwb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTFNVElzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSnZlV0ZzZEhsSmJtWnZLSFZwYm5RMU1USXNkV2x1ZERVeE1pa29ZV1JrY21WemN5eDFhVzUwTlRFeUtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFwYm5RZ2MyVjBSR1ZtWVhWc2RGSnZlV0ZzZEhrZ2MyVjBWRzlyWlc1U2IzbGhiSFI1SUdKMWNtNGdjM1Z3Y0c5eWRITkpiblJsY21aaFkyVW9NU2tnWW1Gc1lXNWpaVTltSUc5M2JtVnlUMllnYm1GdFpTQnplVzFpYjJ3Z2RHOXJaVzVWVWtrZ1lYQndjbTkyWlNCblpYUkJjSEJ5YjNabFpDQnpaWFJCY0hCeWIzWmhiRVp2Y2tGc2JDQnBjMEZ3Y0hKdmRtVmtSbTl5UVd4c0lIUnlZVzV6Wm1WeVJuSnZiU0J6WVdabFZISmhibk5tWlhKR2NtOXRLRE1wSUhOaFptVlVjbUZ1YzJabGNrWnliMjBvTkNrZ2NtOTVZV3gwZVVsdVptOEtJQ0FnSUdWeWNnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl2Y0dWdWVtVndjR1ZzYVc0dlkyOXVkSEpoWTNSekwwVlNRemN5TVZKdmVXRnNkSGt1YzI5c0xrVlNRemN5TVZKdmVXRnNkSGxVWlhOMExtMXBiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdGFXNTBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblExTVRJS0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdQVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRlVrTTNNakZKYm5aaGJHbGtVbVZqWldsMlpYSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JqWVd4c2MzVmlJRjkxY0dSaGRHVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0FoUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNRemN5TVVsdWRtRnNhV1JUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUZVa00zTWpGU2IzbGhiSFI1TG5OdmJDNUZVa00zTWpGU2IzbGhiSFI1VkdWemRDNXpaWFJFWldaaGRXeDBVbTk1WVd4MGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEVSbFptRjFiSFJTYjNsaGJIUjVPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWWp3S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVa015T1RneFNXNTJZV3hwWkVSbFptRjFiSFJTYjNsaGJIUjVDaUFnSUNCa2FXY2dNZ29nSUNBZ1lubDBaV05mTUNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUQwOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSVkpETWprNE1VbHVkbUZzYVdSRVpXWmhkV3gwVW05NVlXeDBlVkpsWTJWcGRtVnlDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbDlrWldaaGRXeDBVbTk1WVd4MGVVbHVabThpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBWU1F6Y3lNVkp2ZVdGc2RIa3VjMjlzTGtWU1F6Y3lNVkp2ZVdGc2RIbFVaWE4wTG5ObGRGUnZhMlZ1VW05NVlXeDBlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGUnZhMlZ1VW05NVlXeDBlVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERVeE1nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZandLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRlVrTXlPVGd4U1c1MllXeHBaRlJ2YTJWdVVtOTVZV3gwZVFvZ0lDQWdaR2xuSURJS0lDQWdJR0o1ZEdWalh6QWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQTlQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1F6STVPREZKYm5aaGJHbGtWRzlyWlc1U2IzbGhiSFI1VW1WalpXbDJaWElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0o4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVgzUnZhMlZ1VW05NVlXeDBlVWx1Wm04aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmIzQmxibnBsY0hCbGJHbHVMMk52Ym5SeVlXTjBjeTlGVWtNM01qRlNiM2xoYkhSNUxuTnZiQzVGVWtNM01qRlNiM2xoYkhSNVZHVnpkQzVpZFhKdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblZ5YmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREVXhNZ29nSUNBZ1lubDBaV05mTUNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUhOM1lYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JqWVd4c2MzVmlJRjkxY0dSaGRHVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNRemN5TVU1dmJtVjRhWE4wWlc1MFZHOXJaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmIzQmxibnBsY0hCbGJHbHVMMk52Ym5SeVlXTjBjeTlGVWtNM01qRlNiM2xoYkhSNUxuTnZiQzVGVWtNM01qRlNiM2xoYkhSNVZHVnpkQzV6ZFhCd2IzSjBjMGx1ZEdWeVptRmpaU2d4S1Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFjSEJ2Y25SelNXNTBaWEptWVdObEtERXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTkQ0S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnS0lDQWdJRDA5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnVlaUJ6ZFhCd2IzSjBjMGx1ZEdWeVptRmpaU2d4S1Y5aWIyOXNYM1J5ZFdWQU5Bb2dJQ0FnWkhWd0NpQWdJQ0JpYm5vZ2MzVndjRzl5ZEhOSmJuUmxjbVpoWTJVb01TbGZZbTl2YkY5MGNuVmxRRFFLSUNBZ0lHUjFjQW9nSUNBZ1lub2djM1Z3Y0c5eWRITkpiblJsY21aaFkyVW9NU2xmWW05dmJGOW1ZV3h6WlVBMUNncHpkWEJ3YjNKMGMwbHVkR1Z5Wm1GalpTZ3hLVjlpYjI5c1gzUnlkV1ZBTkRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwemRYQndiM0owYzBsdWRHVnlabUZqWlNneEtWOWliMjlzWDIxbGNtZGxRRFk2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B6ZFhCd2IzSjBjMGx1ZEdWeVptRmpaU2d4S1Y5aWIyOXNYMlpoYkhObFFEVTZDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWWlCemRYQndiM0owYzBsdWRHVnlabUZqWlNneEtWOWliMjlzWDIxbGNtZGxRRFlLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmIzQmxibnBsY0hCbGJHbHVMMk52Ym5SeVlXTjBjeTlGVWtNM01qRlNiM2xoYkhSNUxuTnZiQzVGVWtNM01qRlNiM2xoYkhSNVZHVnpkQzVpWVd4aGJtTmxUMlpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaVlXeGhibU5sVDJZNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lEMDlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUlZKRE56SXhTVzUyWVd4cFpFOTNibVZ5Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEWWdMeThnSWw5aVlXeGhibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBWU1F6Y3lNVkp2ZVdGc2RIa3VjMjlzTGtWU1F6Y3lNVkp2ZVdGc2RIbFVaWE4wTG05M2JtVnlUMlpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmQyNWxjazltT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCallXeHNjM1ZpSUY5eVpYRjFhWEpsVDNkdVpXUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUZVa00zTWpGU2IzbGhiSFI1TG5OdmJDNUZVa00zTWpGU2IzbGhiSFI1VkdWemRDNXVZVzFsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JtRnRaVG9LSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmZibUZ0WlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDI1aGJXVWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBWU1F6Y3lNVkp2ZVdGc2RIa3VjMjlzTGtWU1F6Y3lNVkp2ZVdGc2RIbFVaWE4wTG5ONWJXSnZiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ONWJXSnZiRG9LSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmZjM2x0WW05c0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCZmMzbHRZbTlzSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUZVa00zTWpGU2IzbGhiSFI1TG5OdmJDNUZVa00zTWpGU2IzbGhiSFI1VkdWemRDNTBiMnRsYmxWU1NWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2YTJWdVZWSkpPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0JqWVd4c2MzVmlJRjl5WlhGMWFYSmxUM2R1WldRS0lDQWdJSEJ2Y0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiM0JsYm5wbGNIQmxiR2x1TDJOdmJuUnlZV04wY3k5RlVrTTNNakZTYjNsaGJIUjVMbk52YkM1RlVrTTNNakZTYjNsaGJIUjVWR1Z6ZEM1aGNIQnliM1psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYQndjbTkyWlRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5URXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZMkZzYkhOMVlpQmZZWEJ3Y205MlpTZzBLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dmNHVnVlbVZ3Y0dWc2FXNHZZMjl1ZEhKaFkzUnpMMFZTUXpjeU1WSnZlV0ZzZEhrdWMyOXNMa1ZTUXpjeU1WSnZlV0ZzZEhsVVpYTjBMbWRsZEVGd2NISnZkbVZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRWEJ3Y205MlpXUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblExTVRJS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQmZjbVZ4ZFdseVpVOTNibVZrQ2lBZ0lDQndiM0FLSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRUZ3Y0hKdmRtVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDI5d1pXNTZaWEJ3Wld4cGJpOWpiMjUwY21GamRITXZSVkpETnpJeFVtOTVZV3gwZVM1emIyd3VSVkpETnpJeFVtOTVZV3gwZVZSbGMzUXVjMlYwUVhCd2NtOTJZV3hHYjNKQmJHeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSQmNIQnliM1poYkVadmNrRnNiRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXlDaUFnSUNCaWVYUmxZMTh3SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnUFQwS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZVa00zTWpGSmJuWmhiR2xrVDNCbGNtRjBiM0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbDl2Y0dWeVlYUnZja0Z3Y0hKdmRtRnNjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTNNekEzWldGaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl2Y0dWdWVtVndjR1ZzYVc0dlkyOXVkSEpoWTNSekwwVlNRemN5TVZKdmVXRnNkSGt1YzI5c0xrVlNRemN5TVZKdmVXRnNkSGxVWlhOMExtbHpRWEJ3Y205MlpXUkdiM0pCYkd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjMEZ3Y0hKdmRtVmtSbTl5UVd4c09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyOXdaVzU2WlhCd1pXeHBiaTlqYjI1MGNtRmpkSE12UlZKRE56SXhVbTk1WVd4MGVTNXpiMnd1UlZKRE56SXhVbTk1WVd4MGVWUmxjM1F1YVhOQmNIQnliM1psWkVadmNrRnNiQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl2Y0dWdWVtVndjR1ZzYVc0dlkyOXVkSEpoWTNSekwwVlNRemN5TVZKdmVXRnNkSGt1YzI5c0xrVlNRemN5TVZKdmVXRnNkSGxVWlhOMExuUnlZVzV6Wm1WeVJuSnZiVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SeVlXNXpabVZ5Um5KdmJUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lHTmhiR3h6ZFdJZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDI5d1pXNTZaWEJ3Wld4cGJpOWpiMjUwY21GamRITXZSVkpETnpJeFVtOTVZV3gwZVM1emIyd3VSVkpETnpJeFVtOTVZV3gwZVZSbGMzUXVkSEpoYm5ObVpYSkdjbTl0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyOXdaVzU2WlhCd1pXeHBiaTlqYjI1MGNtRmpkSE12UlZKRE56SXhVbTk1WVd4MGVTNXpiMnd1UlZKRE56SXhVbTk1WVd4MGVWUmxjM1F1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiU2d6S1Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmhabVZVY21GdWMyWmxja1p5YjIwb015azZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dmNHVnVlbVZ3Y0dWc2FXNHZZMjl1ZEhKaFkzUnpMMFZTUXpjeU1WSnZlV0ZzZEhrdWMyOXNMa1ZTUXpjeU1WSnZlV0ZzZEhsVVpYTjBMblJ5WVc1elptVnlSbkp2YlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBWU1F6Y3lNVkp2ZVdGc2RIa3VjMjlzTGtWU1F6Y3lNVkp2ZVdGc2RIbFVaWE4wTG5OaFptVlVjbUZ1YzJabGNrWnliMjBvTkNsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpZV1psVkhKaGJuTm1aWEpHY205dEtEUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiM0JsYm5wbGNIQmxiR2x1TDJOdmJuUnlZV04wY3k5RlVrTTNNakZTYjNsaGJIUjVMbk52YkM1RlVrTTNNakZTYjNsaGJIUjVWR1Z6ZEM1MGNtRnVjMlpsY2taeWIyMEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUZVa00zTWpGU2IzbGhiSFI1TG5OdmJDNUZVa00zTWpGU2IzbGhiSFI1VkdWemRDNXliM2xoYkhSNVNXNW1iMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KdmVXRnNkSGxKYm1adk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVgzUnZhMlZ1VW05NVlXeDBlVWx1Wm04aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdQVDBLSUNBZ0lHSjZJSEp2ZVdGc2RIbEpibVp2WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lsOWtaV1poZFd4MFVtOTVZV3gwZVVsdVptOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMlJsWm1GMWJIUlNiM2xoYkhSNVNXNW1ieUJsZUdsemRITUtDbkp2ZVdGc2RIbEpibVp2WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lHUjFjRzRnTWdvZ0lDQWdaWGgwY21GamRDQXpNaUEyTkFvZ0lDQWdaR2xuSURRS0lDQWdJR0lxQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBS0lDQWdJR2wwYjJJS0lDQWdJR0l2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURNS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiM0JsYm5wbGNIQmxiR2x1TDJOdmJuUnlZV04wY3k5RlVrTTNNakZTYjNsaGJIUjVMbk52YkM1RlVrTTNNakZTYjNsaGJIUjVWR1Z6ZEM1cGMwRndjSEp2ZG1Wa1JtOXlRV3hzS0c5M2JtVnlPaUJpZVhSbGN5d2diM0JsY21GMGIzSTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBWU1F6Y3lNVkp2ZVdGc2RIa3VjMjlzTGtWU1F6Y3lNVkp2ZVdGc2RIbFVaWE4wTG1selFYQndjbTkyWldSR2IzSkJiR3c2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nT0NBdkx5QWlYMjl3WlhKaGRHOXlRWEJ3Y205MllXeHpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBWU1F6Y3lNVkp2ZVdGc2RIa3VjMjlzTGtWU1F6Y3lNVkp2ZVdGc2RIbFVaWE4wTG5SeVlXNXpabVZ5Um5KdmJTaG1jbTl0T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCMGIydGxia2xrT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjl3Wlc1NlpYQndaV3hwYmk5amIyNTBjbUZqZEhNdlJWSkROekl4VW05NVlXeDBlUzV6YjJ3dVJWSkROekl4VW05NVlXeDBlVlJsYzNRdWRISmhibk5tWlhKR2NtOXRPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6QWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQTlQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1F6Y3lNVWx1ZG1Gc2FXUlNaV05sYVhabGNnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTmhiR3h6ZFdJZ1gzVndaR0YwWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQWhQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1F6Y3lNVWx1WTI5eWNtVmpkRTkzYm1WeUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUZVa00zTWpGU2IzbGhiSFI1TG5OdmJDNUZVa00zTWpGU2IzbGhiSFI1VkdWemRDNWZiM2R1WlhKUFppaDBiMnRsYmtsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsOXZkMjVsY2s5bU9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0pmYjNkdVpYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiM0JsYm5wbGNIQmxiR2x1TDJOdmJuUnlZV04wY3k5RlVrTTNNakZTYjNsaGJIUjVMbk52YkM1RlVrTTNNakZTYjNsaGJIUjVWR1Z6ZEM1ZloyVjBRWEJ3Y205MlpXUW9kRzlyWlc1SlpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGZaMlYwUVhCd2NtOTJaV1E2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmZkRzlyWlc1QmNIQnliM1poYkhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dmNHVnVlbVZ3Y0dWc2FXNHZZMjl1ZEhKaFkzUnpMMFZTUXpjeU1WSnZlV0ZzZEhrdWMyOXNMa1ZTUXpjeU1WSnZlV0ZzZEhsVVpYTjBMbDkxY0dSaGRHVW9kRzg2SUdKNWRHVnpMQ0IwYjJ0bGJrbGtPaUJpZVhSbGN5d2dZWFYwYURvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwZmRYQmtZWFJsT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnWDI5M2JtVnlUMllLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV05mTUNBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0JrZFhBS0lDQWdJR0o2SUY5MWNHUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW5vZ1gzVndaR0YwWlY5aWIyOXNYMlpoYkhObFFERXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUY5MWNHUmhkR1ZmWW05dmJGOTBjblZsUURFeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dmNHVnVlbVZ3Y0dWc2FXNHZZMjl1ZEhKaFkzUnpMMFZTUXpjeU1WSnZlV0ZzZEhrdWMyOXNMa1ZTUXpjeU1WSnZlV0ZzZEhsVVpYTjBMbWx6UVhCd2NtOTJaV1JHYjNKQmJHd0tJQ0FnSUdKdWVpQmZkWEJrWVhSbFgySnZiMnhmZEhKMVpVQXhNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUY5blpYUkJjSEJ5YjNabFpBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZbm9nWDNWd1pHRjBaVjlpYjI5c1gyWmhiSE5sUURFeUNncGZkWEJrWVhSbFgySnZiMnhmZEhKMVpVQXhNVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BmZFhCa1lYUmxYMkp2YjJ4ZmJXVnlaMlZBTVRNNkNpQWdJQ0JpYm5vZ1gzVndaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWtNM01qRkpibk4xWm1acFkybGxiblJCY0hCeWIzWmhiQW9nSUNBZ1pYSnlJQzh2SUVWU1F6Y3lNVTV2Ym1WNGFYTjBaVzUwVkc5clpXNEtDbDkxY0dSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0o1ZEdWalh6QWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1lub2dYM1Z3WkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJR0o1ZEdWalh6QWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2NtOTJaU2cwS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWDJKaGJHRnVZMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSXRDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENncGZkWEJrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZbmwwWldOZk1DQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDRTlDaUFnSUNCaWVpQmZkWEJrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEWWdMeThnSWw5aVlXeGhibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmlLd29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0tYM1Z3WkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKZmIzZHVaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUmtaakkxTW1Ga0NpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tYM1Z3WkdGMFpWOWliMjlzWDJaaGJITmxRREV5T2dvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHSWdYM1Z3WkdGMFpWOWliMjlzWDIxbGNtZGxRREV6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyOXdaVzU2WlhCd1pXeHBiaTlqYjI1MGNtRmpkSE12UlZKRE56SXhVbTk1WVd4MGVTNXpiMnd1UlZKRE56SXhVbTk1WVd4MGVWUmxjM1F1WDJGd2NISnZkbVVvTkNrb2RHODZJR0o1ZEdWekxDQjBiMnRsYmtsa09pQmllWFJsY3l3Z1lYVjBhRG9nWW5sMFpYTXNJR1Z0YVhSRmRtVnVkRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BmWVhCd2NtOTJaU2cwS1RvS0lDQWdJSEJ5YjNSdklEUWdNQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW01NklGOWhjSEJ5YjNabEtEUXBYMmxtWDJKdlpIbEFNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWVYUmxZMTh3SUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnSVQwS0lDQWdJR0o2SUY5aGNIQnliM1psS0RRcFgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvS1gyRndjSEp2ZG1Vb05DbGZhV1pmWW05a2VVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCallXeHNjM1ZpSUY5eVpYRjFhWEpsVDNkdVpXUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHSjZJRjloY0hCeWIzWmxLRFFwWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnSVQwS0lDQWdJR0o2SUY5aGNIQnliM1psS0RRcFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUZVa00zTWpGU2IzbGhiSFI1TG5OdmJDNUZVa00zTWpGU2IzbGhiSFI1VkdWemRDNXBjMEZ3Y0hKdmRtVmtSbTl5UVd4c0NpQWdJQ0JoYzNObGNuUWdMeThnUlZKRE56SXhTVzUyWVd4cFpFRndjSEp2ZG1WeUNncGZZWEJ3Y205MlpTZzBLVjloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNklGOWhjSEJ5YjNabEtEUXBYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9HTTFZbVV4WlRVS0lDQWdJR3h2WndvS1gyRndjSEp2ZG1Vb05DbGZZV1owWlhKZmFXWmZaV3h6WlVBNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0lsOTBiMnRsYmtGd2NISnZkbUZzY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmIzQmxibnBsY0hCbGJHbHVMMk52Ym5SeVlXTjBjeTlGVWtNM01qRlNiM2xoYkhSNUxuTnZiQzVGVWtNM01qRlNiM2xoYkhSNVZHVnpkQzVmY21WeGRXbHlaVTkzYm1Wa0tIUnZhMlZ1U1dRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1gzSmxjWFZwY21WUGQyNWxaRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjl2ZDI1bGNrOW1DaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0E5UFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFVlNRemN5TVU1dmJtVjRhWE4wWlc1MFZHOXJaVzRLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUZVa00zTWpGU2IzbGhiSFI1TG5OdmJDNUZVa00zTWpGU2IzbGhiSFI1VkdWemRDNWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGUUFFZ0FKQk9KZ3NnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVGUjk4ZFFBVFgyUmxabUYxYkhSU2IzbGhiSFI1U1c1bWJ3VmZibUZ0WlFkZmMzbHRZbTlzQ1Y5aVlXeGhibU5sY3hGZmRHOXJaVzVTYjNsaGJIUjVTVzVtYnhKZmIzQmxjbUYwYjNKQmNIQnliM1poYkhNSFgyOTNibVZ5Y3c5ZmRHOXJaVzVCY0hCeWIzWmhiSE14R0VBQUpTc3FaeWNFS21jbkJTcG5Kd1NBQ2xKdmVXRnNkSGxPUmxSbkp3V0FCRkpPUmxSbkkwTXhHUlJFTVJoRWdoSUUrVldJNmdRdWpraUZCQ0JPdTE4RXdCUE5Wd1JPSXFPNkJNa01rTEVFbHpiMVl3UVpkUVlXQkFCYlVyZ0UzTGViSGdSWnVxU2xCRWM2RlB3RUtlSnJuQVJRQmNSdkJKZk5HZUVFbkNUTXZnUkpQUmRnQk5Vc3Y0azJHZ0NPRWdBQkFDRUFUQUNUQUtjQTBBRDFBUVlCR1FFc0FVTUJXd0Z4QWFRQnhBSGhBZjRDS0FBMkdnRkpGU1FTUkRZYUFra1ZJaEpFU3dFb0VoUkVLSWdEQnlnVEZFUWpRellhQVVrVkpCSkVOaG9DU1JWSkloSkVJUVFXU3dLa0ZFUkxBaWdTRkVRaURrUWlyNnRRSzB4bkkwTTJHZ0ZKRlNJU1JEWWFBa2tWSkJKRU5ob0RTUlZKSWhKRUlRUVdTd0trRkVSTEFpZ1NGRVFpRGtRaXIweExBYXRQQWt4UVRFOENVRWtWSWdraVdBRW5CMHhRVEw4alF6WWFBVWtWSWhKRUtFd29pQUtCS0JJVVJDTkROaG9CU1JXQkJCSkVLaEpKUUFBSVNVQUFCRWxCQUE0amdBRUFKVThDVkNsTVVMQWpReVZDLys4MkdnRkpGU1FTUkVrb0VoUkVBU2NHVEZDK0trNENUVWtWSWc1RUlxK3JLVXhRc0NORE5ob0JTUlVpRWtTSUF3c3BURkN3STBNbEp3UmxSRWtWRmxjR0FreFFLVXhRc0NOREpTY0ZaVVJKRlJaWEJnSk1VQ2xNVUxBalF6WWFBVWtWSWhKRWlBTFVTSUFHRlI5OGRRQUFzQ05ETmhvQlNSVWtFa1EyR2dKSkZTSVNSREVBSTRnQ1pDTkROaG9CU1JVaUVrUkppQUtrU0lnQm5pbE1VTEFqUXpZYUFVa1ZKQkpFTmhvQ1NSVWpFa1FsVXpFQVN3SW9FaFJFVHdKUUFTY0lURkJNRmt4TEFiK0FCQmN3ZnF0TVVMQWpRellhQVVrVkpCSkVOaG9DU1JVa0VrU0lBUXVBQVFBbFR3SlVLVXhRc0NORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkRZYUEwa1ZJaEpFaUFENUkwTTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRU5ob0RTUlVpRWtTSUFOd2pRellhQVVrVkpCSkVOaG9DU1JVa0VrUTJHZ05KRlNJU1JEWWFCRWtsV1lFQ0NFd1ZFa1NJQUxJalF6WWFBVWtWSWhKRU5ob0NTVTRDRlNJU1JDS3ZTVThDVUVrVklna2lXQUVuQjB4UXZvQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRTRDVFVsWEFDQW9Fa0VBQnlVclpVeEZBa1JIQWxjZ1FFc0VveUVFRnFKTVZ3QWdTd0VWSWc1RVRFc0RxMUFwVEZDd0kwT0tBZ0dML292L1VBRW5DRXhRdmt3WEpVeFBBazJKaWdNQWkvNG9FaFJFaS82TC96RUFpQUE0aS8wVEZFU0ppZ0VCSXErTC8xQkpGU0lKSWxnQkp3bE1VTDRvVGdKTmlZb0JBU0t2aS85UVNSVWlDU0pZQVNjS1RGQytLRTRDVFltS0F3R0wvb2oveG92L0tCTkpRUUFzaXdGQkFJS0xBSXYvRWtBQUZZc0FpLytJLzN4QUFBdUwvb2ovdTR2L0VrRUFaU05BQUFhTEFDZ1NSQUNMQUNnVFFRQWRLSXYrS0NXSUFGQ0xBQUVuQmt4UVNiNHFUZ0pOSXhhaFN3RzhTTCtML1NnVFFRQVZpLzBCSndaTVVFbStLazRDVFNNV29Fc0J2RWkvSXErTC9sQkpGU0lKSWxnQkp3bE1VSXY5djRBRTNmSlNyYkNKSlVML21Jb0VBQ1dMLzBBQUI0ditLQk5CQUNxTC9ZZ0FPWXdBaS80b0UwRUFFSXNBaS80VFFRQUlpd0NML29qKzJFU0wvMEVBQjRBRWpGdmg1YkFpcjR2OVVFa1ZJZ2tpV0FFbkNreFFpL3kvaVlvQkFZdi9pUDdkU1NnU0ZFU0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
