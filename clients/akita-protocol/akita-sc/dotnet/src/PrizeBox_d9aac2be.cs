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

namespace Arc56.Generated.akita_protocol.akita_sc.PrizeBox_d9aac2be
{


    //
    // A transferable bundle of ASAs/ALGO. `funder` (from `ChildContract`) records who paid the
    //app-creation MBR; the factory refunds it to them on deletion. Everything held in the box
    //account (its min balance, opt-in MBR, any ALGO) belongs to the current owner.
    //
    public class PrizeBoxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PrizeBoxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class FunderInfo : AVMObjectType
            {
                public Algorand.Address Account { get; set; }

                public ulong Amount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAccount.From(Account);
                    ret.AddRange(vAccount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FunderInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FunderInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FunderInfo);
                }
                public bool Equals(FunderInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FunderInfo left, FunderInfo right)
                {
                    return EqualityComparer<FunderInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(FunderInfo left, FunderInfo right)
                {
                    return !(left == right);
                }

            }

            public class WithdrawArgAssets : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static WithdrawArgAssets Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new WithdrawArgAssets();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as WithdrawArgAssets);
                }
                public bool Equals(WithdrawArgAssets? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(WithdrawArgAssets left, WithdrawArgAssets right)
                {
                    return EqualityComparer<WithdrawArgAssets>.Default.Equals(left, right);
                }
                public static bool operator !=(WithdrawArgAssets left, WithdrawArgAssets right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="funder"> FunderInfo</param>
        public async Task Create(Algorand.Address owner, Structs.FunderInfo funder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 202, 175, 42 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, funder }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address owner, Structs.FunderInfo funder, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 202, 175, 42 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, funder }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deleted only through `PrizeBoxFactory.deletePrizeBox` so the creation MBR the factory
        ///releases can be refunded to the minter; the box account closes to the owner.
        ///</summary>
        /// <param name="caller"> </param>
        public async Task DeleteApplication(Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 82, 21, 224 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            var result = await base.CallApp(new List<object> { abiHandle, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Algorand.Address caller, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 82, 21, 224 };
            var callerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); callerAbi.From(caller);

            return await base.MakeTransactionList(new List<object> { abiHandle, callerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///optin tells the contract to opt into an asa
        ///</summary>
        /// <param name="payment">The payment transaction </param>
        /// <param name="asset">The asset to be opted into </param>
        public async Task Optin(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 62, 161, 24, 50 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, payment, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Optin_Transactions(PaymentTransaction payment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 62, 161, 24, 50 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newOwner"> </param>
        public async Task Transfer(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 249, 42, 228 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Transfer_Transactions(Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 249, 42, 228 };
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> WithdrawArgAssets</param>
        public async Task Withdraw(Structs.WithdrawArgAssets[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 32, 15, 189 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.WithdrawArgAssets>(x => Structs.WithdrawArgAssets.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(Structs.WithdrawArgAssets[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 32, 15, 189 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.WithdrawArgAssets>(x => Structs.WithdrawArgAssets.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJpemVCb3giLCJkZXNjIjoiQSB0cmFuc2ZlcmFibGUgYnVuZGxlIG9mIEFTQXMvQUxHTy4gYGZ1bmRlcmAgKGZyb20gYENoaWxkQ29udHJhY3RgKSByZWNvcmRzIHdobyBwYWlkIHRoZVxuYXBwLWNyZWF0aW9uIE1CUjsgdGhlIGZhY3RvcnkgcmVmdW5kcyBpdCB0byB0aGVtIG9uIGRlbGV0aW9uLiBFdmVyeXRoaW5nIGhlbGQgaW4gdGhlIGJveFxuYWNjb3VudCAoaXRzIG1pbiBiYWxhbmNlLCBvcHQtaW4gTUJSLCBhbnkgQUxHTykgYmVsb25ncyB0byB0aGUgY3VycmVudCBvd25lci4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRnVuZGVySW5mbyI6W3sibmFtZSI6ImFjY291bnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifV0sIldpdGhkcmF3QXJnQXNzZXRzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0KSIsInN0cnVjdCI6IkZ1bmRlckluZm8iLCJuYW1lIjoiZnVuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkRlbGV0ZWQgb25seSB0aHJvdWdoIGBQcml6ZUJveEZhY3RvcnkuZGVsZXRlUHJpemVCb3hgIHNvIHRoZSBjcmVhdGlvbiBNQlIgdGhlIGZhY3RvcnlcbnJlbGVhc2VzIGNhbiBiZSByZWZ1bmRlZCB0byB0aGUgbWludGVyOyB0aGUgYm94IGFjY291bnQgY2xvc2VzIHRvIHRoZSBvd25lci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0aW4iLCJkZXNjIjoib3B0aW4gdGVsbHMgdGhlIGNvbnRyYWN0IHRvIG9wdCBpbnRvIGFuIGFzYSIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6IlRoZSBwYXltZW50IHRyYW5zYWN0aW9uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gYmUgb3B0ZWQgaW50byIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJXaXRoZHJhd0FyZ0Fzc2V0cyIsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMjZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyQW9wdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJDbHdhIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklhc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODgsMzAwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTRdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTWJmZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyN10sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOZW10IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA1LDI3NSw0MDIsNDQwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5vd24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzBdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTgsMjA5LDIzMiwyNjgsMzc0LDM5NSw0MzMsNTExLDUyMSw1NDksNTc4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYxXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHNtYXJ0X2NvbnRyYWN0cy91dGlscy90eXBlcy9hc3NldC50czo6QXNzZXRJbmZvPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNSwxNzEsMzg5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvdXRpbHMvdHlwZXMvbWJyLnRzOjpGdW5kZXJJbmZvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUzXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURnS0lDQWdJR0o1ZEdWallteHZZMnNnSW05M2JtVnlJaUFpYjNCMGFXNWZZMjkxYm5RaUlDSkZVbEk2WlhKeVRtOTNiaUlnSWtWU1VqcGxjbkpKY0dGNUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpwZW1WQ2IzZ2daWGgwWlc1a2N5QkRhR2xzWkVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJeE5USXhOV1V3SUM4dklHMWxkR2h2WkNBaVpHVnNaWFJsUVhCd2JHbGpZWFJwYjI0b1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWtaV3hsZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBeUNncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlhWHBsUW05NElHVjRkR1Z1WkhNZ1EyaHBiR1JEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3paV0V4TVRnek1pQXdlR0ZrWmpreVlXVTBJREI0TkRReU1EQm1ZbVFnTHk4Z2JXVjBhRzlrSUNKdmNIUnBiaWh3WVhrc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhjb0tIVnBiblEyTkN4MWFXNTBOalFwVzEwcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUc5d2RHbHVJSFJ5WVc1elptVnlJSGRwZEdoa2NtRjNDaUFnSUNCbGNuSUtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeWFYcGxRbTk0SUdWNGRHVnVaSE1nUTJocGJHUkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzROR05oWVdZeVlTQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaGhaR1J5WlhOekxDaGhaR1J5WlhOekxIVnBiblEyTkNrcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyUmxiR1YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmljZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJR1JsYkdWMFpVRndjR3hwWTJGMGFXOXVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtbDZaVUp2ZUM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12ZEhsd1pYTXZiV0p5TG5Sek9qcEdkVzVrWlhKSmJtWnZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklGQnlhWHBsUW05NFIyeHZZbUZzVTNSaGRHVkxaWGxQZDI1bGNpQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWliM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VnUFNCdmQyNWxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCdmNIUnBia052ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dVSEpwZW1WQ2IzaEhiRzlpWVd4VGRHRjBaVXRsZVU5d2RHbHVRMjkxYm5RZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOXdkR2x1WDJOdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QjBhR2x6TG05d2RHbHVRMjkxYm5RdWRtRnNkV1VnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5amFHbHNaQzUwY3pveE1Rb2dJQ0FnTHk4Z1puVnVaR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThSblZ1WkdWeVNXNW1iejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVJuVnVaR1Z5SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1aMWJtUmxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdkR2hwY3k1bWRXNWtaWEl1ZG1Gc2RXVWdQU0JqYkc5dVpTaG1kVzVrWlhJcENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEpwZW1WQ2IzZ3VaR1ZzWlhSbFFYQndiR2xqWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVkJjSEJzYVdOaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dKMFJsYkdWMFpVRndjR3hwWTJGMGFXOXVKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lHVnljazExYzNSQ1pVTmhiR3hsWkVaeWIyMUdZV04wYjNKNUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR1JsYkdWMFpVRndjR3hwWTJGMGFXOXVYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1VqcGxjbkpOWW1abUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrMWlabVlLQ21SbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1WDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWTJGc2JHVnlJRDA5UFNCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTENCbGNuSk9iM1JQZDI1bGNpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUc5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUZCeWFYcGxRbTk0UjJ4dlltRnNVM1JoZEdWTFpYbFBkMjVsY2lCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIzZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoallXeHNaWElnUFQwOUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lHVnljazV2ZEU5M2JtVnlLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1pHVnNaWFJsUVhCd2JHbGpZWFJwYjI1ZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJa1ZTVWpwbGNuSk9iM2R1SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2s1dmQyNEtDbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kR2hwY3k1dmNIUnBia052ZFc1MExuWmhiSFZsSUQwOVBTQXdMQ0JsY25KT2IzUkZiWEIwZVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJRzl3ZEdsdVEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lCUWNtbDZaVUp2ZUVkc2IySmhiRk4wWVhSbFMyVjVUM0IwYVc1RGIzVnVkQ0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNCMGFXNWZZMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBhR2x6TG05d2RHbHVRMjkxYm5RdWRtRnNkV1VnUFQwOUlEQXNJR1Z5Y2s1dmRFVnRjSFI1S1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjZJR1JsYkdWMFpVRndjR3hwWTJGMGFXOXVYMkZtZEdWeVgyRnpjMlZ5ZEVBM0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1VqcGxjbkpPWlcxMElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrNWxiWFFLQ21SbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1WDJGbWRHVnlYMkZ6YzJWeWRFQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFMVFUzQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc2dZMnh2YzJWU1pXMWhhVzVrWlhKVWJ6b2dkR2hwY3k1dmQyNWxjaTUyWVd4MVpTQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z0xuQmhlVzFsYm5Rb2V5QmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQjBhR2x6TG05M2JtVnlMblpoYkhWbElIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lCUWNtbDZaVUp2ZUVkc2IySmhiRk4wWVhSbFMyVjVUM2R1WlhJZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUF1Y0dGNWJXVnVkQ2g3SUdOc2IzTmxVbVZ0WVdsdVpHVnlWRzg2SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VnZlNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zYjNObFVtVnRZV2x1WkdWeVZHOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5TMDFOZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklIUm9hWE11YjNkdVpYSXVkbUZzZFdVZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUzAxTndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5SR1ZzWlhSbFFYQndiR2xqWVhScGIyNG5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbWw2WlVKdmVDNXZjSFJwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtOXdkR2x1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzQ2lBZ0lDQXZMeUJ2Y0hScGJpaHdZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lHRnpjMlYwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd2daWEp5VG05MFQzZHVaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lCUWNtbDZaVUp2ZUVkc2IySmhiRk4wWVhSbFMyVjVUM2R1WlhJZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnWlhKeVRtOTBUM2R1WlhJcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ2Y0hScGJsOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldOZk1pQXZMeUFpUlZKU09tVnljazV2ZDI0aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVRtOTNiZ29LYjNCMGFXNWZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaHdZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2daWEp5U1c1MllXeHBaRkJoZVcxbGJuUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRzl3ZEdsdVgyRm1kR1Z5WDJGemMyVnlkRUExQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pGVWxJNlpYSnlTWEJoZVNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KSmNHRjVDZ3B2Y0hScGJsOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIQmhlVzFsYm5RdVlXMXZkVzUwSUQwOVBTQkhiRzlpWVd3dVlYTnpaWFJQY0hSSmJrMXBia0poYkdGdVkyVXNJR1Z5Y2tsdWRtRnNhV1JRWVhsdFpXNTBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCbmJHOWlZV3dnUVhOelpYUlBjSFJKYmsxcGJrSmhiR0Z1WTJVS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYjNCMGFXNWZZV1owWlhKZllYTnpaWEowUURjS0lDQWdJR0o1ZEdWalh6TWdMeThnSWtWU1VqcGxjbkpKY0dGNUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrbHdZWGtLQ205d2RHbHVYMkZtZEdWeVgyRnpjMlZ5ZEVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9JVWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxtbHpUM0IwWldSSmJpaEJjM05sZENoaGMzTmxkQ2twTENCbGNuSkJiSEpsWVdSNVQzQjBaV1JKYmlrS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHOXdkR2x1WDJGbWRHVnlYMkZ6YzJWeWRFQTVDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KQmIzQjBJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja0Z2Y0hRS0NtOXdkR2x1WDJGbWRHVnlYMkZ6YzJWeWRFQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvUVhOelpYUW9ZWE56WlhRcExtTnNZWGRpWVdOcklEMDlQU0JIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zSUdWeWNrTnNZWGRpWVdOclFYTnpaWFFwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJEYkdGM1ltRmphd29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUc5d2RHbHVYMkZtZEdWeVgyRnpjMlZ5ZEVBeE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5UTJ4M1lTSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSkRiSGRoQ2dwdmNIUnBibDloWm5SbGNsOWhjM05sY25SQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56WXRPRElLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05pMDRNUW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZdE9ESUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nWVhOelpYUXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdkR2hwY3k1dmNIUnBia052ZFc1MExuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUc5d2RHbHVRMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQlFjbWw2WlVKdmVFZHNiMkpoYkZOMFlYUmxTMlY1VDNCMGFXNURiM1Z1ZENCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzQjBhVzVmWTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EUUtJQ0FnSUM4dklIUm9hWE11YjNCMGFXNURiM1Z1ZEM1MllXeDFaU0FyUFNBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2IzQjBhVzVEYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJRkJ5YVhwbFFtOTRSMnh2WW1Gc1UzUmhkR1ZMWlhsUGNIUnBia052ZFc1MElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnZjSFJwYmw5amIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdkR2hwY3k1dmNIUnBia052ZFc1MExuWmhiSFZsSUNzOUlERUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHOXdkR2x1S0hCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdnWVhOelpYUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKcGVtVkNiM2d1ZEhKaGJuTm1aWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNtRnVjMlpsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnZEhKaGJuTm1aWElvYm1WM1QzZHVaWEk2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd2daWEp5VG05MFQzZHVaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCdmQyNWxjaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lCUWNtbDZaVUp2ZUVkc2IySmhiRk4wWVhSbFMyVjVUM2R1WlhJZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NXZkMjVsY2k1MllXeDFaU3dnWlhKeVRtOTBUM2R1WlhJcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIwY21GdWMyWmxjbDloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVJWSlNPbVZ5Y2s1dmQyNGlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlUbTkzYmdvS2RISmhibk5tWlhKZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJRzkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJRkJ5YVhwbFFtOTRSMnh2WW1Gc1UzUmhkR1ZMWlhsUGQyNWxjaUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYjNkdVpYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Ea0tJQ0FnSUM4dklIUm9hWE11YjNkdVpYSXVkbUZzZFdVZ1BTQnVaWGRQZDI1bGNnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2RISmhibk5tWlhJb2JtVjNUM2R1WlhJNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5YVhwbFFtOTRMbmRwZEdoa2NtRjNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJSGRwZEdoa2NtRjNLR0Z6YzJWMGN6b2dRWE56WlhSSmJtWnZXMTBwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHh6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmRIbHdaWE12WVhOelpYUXVkSE02T2tGemMyVjBTVzVtYno0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXViM2R1WlhJdWRtRnNkV1VzSUdWeWNrNXZkRTkzYm1WeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdiM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dVSEpwZW1WQ2IzaEhiRzlpWVd4VGRHRjBaVXRsZVU5M2JtVnlJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0lHVnljazV2ZEU5M2JtVnlLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2QybDBhR1J5WVhkZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJa1ZTVWpwbGNuSk9iM2R1SWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2s1dmQyNEtDbmRwZEdoa2NtRjNYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNBclBTQXhLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LZDJsMGFHUnlZWGRmZDJocGJHVmZkRzl3UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCaGMzTmxkSE11YkdWdVozUm9PeUJwSUNzOUlERXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklIZHBkR2hrY21GM1gyRm1kR1Z5WDNkb2FXeGxRREUzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR2xtSUNoaGMzTmxkSE5iYVYwdVlYTnpaWFFnSVQwOUlEQXBJSHNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWW5vZ2QybDBhR1J5WVhkZlpXeHpaVjlpYjJSNVFERTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UZ0tJQ0FnSUM4dklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TnkweE1EQUtJQ0FnSUM4dklHTnZibk4wSUZ0aGMzTmxkRWh2YkdScGJtY3NJRzl3ZEdWa1NXNWRJRDBnUVhOelpYUkliMnhrYVc1bkxtRnpjMlYwUW1Gc1lXNWpaU2dLSUNBZ0lDOHZJQ0FnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z6YzJWMGMxdHBYUzVoYzNObGRBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklETUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRzl3ZEdWa1NXNHNJR1Z5Y2tsdWRtRnNhV1JCYzNObGRDa0tJQ0FnSUdKdWVpQjNhWFJvWkhKaGQxOWhablJsY2w5aGMzTmxjblJBT0FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlTV0Z6ZENJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KSllYTjBDZ3AzYVhSb1pISmhkMTloWm5SbGNsOWhjM05sY25SQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklHTnZibk4wSUdOc2IzTmxUM1YwSUQwZ1lYTnpaWFJJYjJ4a2FXNW5JRDA5UFNCaGMzTmxkSE5iYVYwdVlXMXZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QnBaaUFvWTJ4dmMyVlBkWFFwSUhzS0lDQWdJR0o2SUhkcGRHaGtjbUYzWDJWc2MyVmZZbTlrZVVBeE1Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2RHaHBjeTV2Y0hScGJrTnZkVzUwTG5aaGJIVmxJQzA5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJRzl3ZEdsdVEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lCUWNtbDZaVUp2ZUVkc2IySmhiRk4wWVhSbFMyVjVUM0IwYVc1RGIzVnVkQ0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNCMGFXNWZZMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCMGFHbHpMbTl3ZEdsdVEyOTFiblF1ZG1Gc2RXVWdMVDBnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKcGVtVXRZbTk0TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUc5d2RHbHVRMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQlFjbWw2WlVKdmVFZHNiMkpoYkZOMFlYUmxTMlY1VDNCMGFXNURiM1Z1ZENCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzQjBhVzVmWTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QjBhR2x6TG05d2RHbHVRMjkxYm5RdWRtRnNkV1VnTFQwZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY3RNVEUwQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMGMxdHBYUzVoYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1lYTnpaWFJ6VzJsZExtRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUTJ4dmMyVlViem9nZEdocGN5NXZkMjVsY2k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQjBhR2x6TG05M2JtVnlMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nVUhKcGVtVkNiM2hIYkc5aVlXeFRkR0YwWlV0bGVVOTNibVZ5SUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmQyNWxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFEyeHZjMlZVYndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TnkweE1UTUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1lYTnpaWFJ6VzJsZExtRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUJoYzNObGRITmJhVjB1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkRiRzl6WlZSdk9pQjBhR2x6TG05M2JtVnlMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGN0TVRFMENpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUdGemMyVjBjMXRwWFM1aGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dZWE56WlhSelcybGRMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQjBhR2x6TG05M2JtVnlMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFEyeHZjMlZVYnpvZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tkMmwwYUdSeVlYZGZZV1owWlhKZmFXWmZaV3h6WlVBeE5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHRnpjMlYwY3k1c1pXNW5kR2c3SUdrZ0t6MGdNU2tnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ2QybDBhR1J5WVhkZmQyaHBiR1ZmZEc5d1FEUUtDbmRwZEdoa2NtRjNYMlZzYzJWZlltOWtlVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRZdE1USXlDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwYzF0cFhTNWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nWVhOelpYUnpXMmxkTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUIwYUdsekxtOTNibVZ5TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakFLSUNBZ0lDOHZJR0Z6YzJWMFVtVmpaV2wyWlhJNklIUm9hWE11YjNkdVpYSXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5YVhwbExXSnZlQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJ2ZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUJRY21sNlpVSnZlRWRzYjJKaGJGTjBZWFJsUzJWNVQzZHVaWElnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW05M2JtVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNQW9nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUyTFRFeU1Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkSE5iYVYwdVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z6YzJWMGMxdHBYUzVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUyTFRFeU1nb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkSE5iYVYwdVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJR0Z6YzJWMGMxdHBYUzVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dkR2hwY3k1dmQyNWxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQjNhWFJvWkhKaGQxOWhablJsY2w5cFpsOWxiSE5sUURFMkNncDNhWFJvWkhKaGQxOWxiSE5sWDJKdlpIbEFNVFE2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWFYcGxMV0p2ZUM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5TMHhNekFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dZWE56WlhSelcybGRMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nZEdocGN5NXZkMjVsY2k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpwZW1VdFltOTRMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJR0Z6YzJWMGMxdHBYUzVoYlc5MWJuUXNDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtbDZaUzFpYjNndlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qZ0tJQ0FnSUM4dklISmxZMlZwZG1WeU9pQjBhR2x6TG05M2JtVnlMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21sNlpTMWliM2d2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnYjNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nVUhKcGVtVkNiM2hIYkc5aVlXeFRkR0YwWlV0bGVVOTNibVZ5SUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmQyNWxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNamdLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUIwYUdsekxtOTNibVZ5TG5aaGJIVmxMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISnBlbVV0WW05NEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTFMVEV5T1FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJoYzNObGRITmJhVjB1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbTkzYm1WeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlhWHBsTFdKdmVDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOUzB4TXpBS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWVhOelpYUnpXMmxkTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTV2ZDI1bGNpNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnWWlCM2FYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2dwM2FYUm9aSEpoZDE5aFpuUmxjbDkzYUdsc1pVQXhOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbWw2WlMxaWIzZ3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkMmwwYUdSeVlYY29ZWE56WlhSek9pQkJjM05sZEVsdVptOWJYU2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdDQ1lFQlc5M2JtVnlDMjl3ZEdsdVgyTnZkVzUwQzBWU1VqcGxjbkpPYjNkdUMwVlNVanBsY25KSmNHRjVnQVFoVWhYZ05ob0FqZ0VBTkRFWkZFUXhHRUVBSFlJREJENmhHRElFcmZrcTVBUkVJQSs5TmhvQWpnTUFqd0VaQVRNQWdBU0V5cThxTmhvQWpnRUFEUUF4R1lFRkVqRVlFRVJDQUNRMkdnRkpGU1FTUkRZYUFra1ZnU2dTUkNoUEFtY3BJbWVBQm1aMWJtUmxja3huSTBNMkdnRkpGU1FTUkRFQU1na1NRQUFQZ0F0RlVsSTZaWEp5VFdKbVpyQUFJaWhsUkJKQUFBTXFzQUFpS1dWRVFRQVBnQXRGVWxJNlpYSnlUbVZ0ZExBQXNTSW9aVVN5Q1NPeUVDS3lBYk1qUXpFV0l3bEpPQkFqRWtRMkdnRkpGU1VTUkJjeEFDSW9aVVFTUUFBREtyQUFTd0U0QnpJS0VrQUFBeXV3QUV3NENESVFFa0FBQXl1d0FESUtTd0Z3QUVVQlFRQVBnQXRGVWxJNlpYSnlRVzl3ZExBQVNYRUtSRElERWtBQUQ0QUxSVkpTT21WeWNrTnNkMkd3QUxFeUNreXlFU0t5RXJJVWdRU3lFQ0t5QWJNaUtXVkVJd2dwVEdjalF6WWFBVWtWSkJKRU1RQWlLR1ZFRWtBQUF5cXdBQ2hNWnlORE5ob0JSd0lpV1VsT0FvRVFDNEVDQ0V3VkVrUXhBQ0lvWlVRU1FBQURLckFBSWtsTEFneEJBSkJMQWxjQ0FFc0JnUkFMZ1JCWVNVNENJbHRKVGdOQkFGOHlDa3NEY0FCQUFBK0FDMFZTVWpwbGNuSkpZWE4wc0FCUEFpVmJTVThDRWtFQUpTSXBaVVFqQ1NsTVo3RWlLR1ZFU2JJVnNoU3lFa3l5RVlFRXNoQWlzZ0d6SXdoQy81bXhJaWhsUkxJVXNoSk1zaEdCQkxJUUlySUJzMEwvNUU4Q1NMRk1KVnNpS0dWRXNnZXlDQ095RUNLeUFiTkMvOHNqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
