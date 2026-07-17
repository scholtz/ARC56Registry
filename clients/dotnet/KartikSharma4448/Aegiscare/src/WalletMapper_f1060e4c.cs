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

namespace Arc56.Generated.KartikSharma4448.Aegiscare.WalletMapper_f1060e4c
{


    public class WalletMapperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public WalletMapperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetBeneficiariesReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public string Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[6]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetBeneficiariesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetBeneficiariesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[6]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBeneficiariesReturn);
                }
                public bool Equals(GetBeneficiariesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBeneficiariesReturn left, GetBeneficiariesReturn right)
                {
                    return EqualityComparer<GetBeneficiariesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBeneficiariesReturn left, GetBeneficiariesReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class ShortIdRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 28, 74, 234, 59 };
                public const string Signature = "ShortIdRegistered(address,byte[6])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public byte[] Field2 { get; set; }

                public static ShortIdRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ShortIdRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[6]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Helper method to allow funding the contract for box MBR.
        ///</summary>
        /// <param name="pay"> </param>
        public async Task FundApp(ulong pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 134, 35, 6 };
            var payAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payAbi.From(pay);

            var result = await base.CallApp(new List<object> { abiHandle, payAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundApp_Transactions(ulong pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 134, 35, 6 };
            var payAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payAbi.From(pay);

            return await base.MakeTransactionList(new List<object> { abiHandle, payAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a 6-byte short ID for the caller's wallet.
        ///</summary>
        /// <param name="short_id"> </param>
        public async Task RegisterShortId(byte[] short_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 231, 21, 107 };
            var short_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(6, "byte"); short_idAbi.From(short_id);

            var result = await base.CallApp(new List<object> { abiHandle, short_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterShortId_Transactions(byte[] short_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 231, 21, 107 };
            var short_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(6, "byte"); short_idAbi.From(short_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, short_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow the caller to remove their own short ID registration.
        ///</summary>
        public async Task ClearRegistration(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 227, 26, 126 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClearRegistration_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 227, 26, 126 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the wallet address corresponding to a short ID.
        ///</summary>
        /// <param name="short_id"> </param>
        public async Task<Algorand.Address> GetWalletFromShortId(byte[] short_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 168, 42, 112 };
            var short_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(6, "byte"); short_idAbi.From(short_id);

            var result = await base.SimApp(new List<object> { abiHandle, short_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetWalletFromShortId_Transactions(byte[] short_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 168, 42, 112 };
            var short_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(6, "byte"); short_idAbi.From(short_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, short_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the short ID corresponding to a wallet address.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<byte[]> GetShortIdFromWallet(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 110, 100, 123 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(6, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetShortIdFromWallet_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 110, 100, 123 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Adds a proxy beneficiary link to the caller's wallet.
        ///</summary>
        /// <param name="beneficiary_id"> </param>
        /// <param name="hashed_password"> </param>
        public async Task AddBeneficiary(byte[] beneficiary_id, string hashed_password, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 83, 202, 24 };
            var beneficiary_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(6, "byte"); beneficiary_idAbi.From(beneficiary_id);
            var hashed_passwordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hashed_passwordAbi.From(hashed_password);

            var result = await base.CallApp(new List<object> { abiHandle, beneficiary_idAbi, hashed_passwordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddBeneficiary_Transactions(byte[] beneficiary_id, string hashed_password, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 83, 202, 24 };
            var beneficiary_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(6, "byte"); beneficiary_idAbi.From(beneficiary_id);
            var hashed_passwordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hashed_passwordAbi.From(hashed_password);

            return await base.MakeTransactionList(new List<object> { abiHandle, beneficiary_idAbi, hashed_passwordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Allow the caller to remove all their proxy beneficiaries.
        ///</summary>
        public async Task ClearBeneficiaries(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 189, 147, 31 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClearBeneficiaries_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 189, 147, 31 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<Structs.GetBeneficiariesReturn[]> GetBeneficiaries(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 202, 12, 221 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetBeneficiariesReturn>(x => Structs.GetBeneficiariesReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetBeneficiaries_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 202, 12, 221 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiV2FsbGV0TWFwcGVyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldEJlbmVmaWNpYXJpZXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVs2XSJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZnVuZF9hcHAiLCJkZXNjIjoiSGVscGVyIG1ldGhvZCB0byBhbGxvdyBmdW5kaW5nIHRoZSBjb250cmFjdCBmb3IgYm94IE1CUi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX3Nob3J0X2lkIiwiZGVzYyI6IlJlZ2lzdGVyIGEgNi1ieXRlIHNob3J0IElEIGZvciB0aGUgY2FsbGVyJ3Mgd2FsbGV0LiIsImFyZ3MiOlt7InR5cGUiOiJieXRlWzZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hvcnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlNob3J0SWRSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlWzZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXJfcmVnaXN0cmF0aW9uIiwiZGVzYyI6IkFsbG93IHRoZSBjYWxsZXIgdG8gcmVtb3ZlIHRoZWlyIG93biBzaG9ydCBJRCByZWdpc3RyYXRpb24uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF93YWxsZXRfZnJvbV9zaG9ydF9pZCIsImRlc2MiOiJSZXR1cm5zIHRoZSB3YWxsZXQgYWRkcmVzcyBjb3JyZXNwb25kaW5nIHRvIGEgc2hvcnQgSUQuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbNl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaG9ydF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zaG9ydF9pZF9mcm9tX3dhbGxldCIsImRlc2MiOiJSZXR1cm5zIHRoZSBzaG9ydCBJRCBjb3JyZXNwb25kaW5nIHRvIGEgd2FsbGV0IGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVs2XSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfYmVuZWZpY2lhcnkiLCJkZXNjIjoiQWRkcyBhIHByb3h5IGJlbmVmaWNpYXJ5IGxpbmsgdG8gdGhlIGNhbGxlcidzIHdhbGxldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVs2XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlbmVmaWNpYXJ5X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoYXNoZWRfcGFzc3dvcmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXJfYmVuZWZpY2lhcmllcyIsImRlc2MiOiJBbGxvdyB0aGUgY2FsbGVyIHRvIHJlbW92ZSBhbGwgdGhlaXIgcHJveHkgYmVuZWZpY2lhcmllcy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JlbmVmaWNpYXJpZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzZdLGFkZHJlc3Msc3RyaW5nLHVpbnQ2NClbXSIsInN0cnVjdCI6IkdldEJlbmVmaWNpYXJpZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzAzXSwiZXJyb3JNZXNzYWdlIjoiQmVuZWZpY2lhcnkgSUQgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyXSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IGFkZCBzZWxmIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk5XSwiZXJyb3JNZXNzYWdlIjoiTm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjVdLCJlcnJvck1lc3NhZ2UiOiJTaG9ydCBJRCBhbHJlYWR5IHRha2VuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI4XSwiZXJyb3JNZXNzYWdlIjoiU2hvcnQgSUQgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUzXSwiZXJyb3JNZXNzYWdlIjoiV2FsbGV0IGFscmVhZHkgaGFzIGEgZGlmZmVyZW50IFNob3J0IElELiBDbGVhciBpdCBmaXJzdC4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTNdLCJlcnJvck1lc3NhZ2UiOiJXYWxsZXQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkZHJlc3NfdG9fc2hvcnRfaWQgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA1LDYwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmVuZWZpY2lhcmllcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ1LDU5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzAsMjIwLDI3N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXlJREVnTUNBMkNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE56TTJPVFkwTldZZ01IZzJNVFkwTnpJMVppQXdlREUxTVdZM1l6YzFJREI0TmpJMk5UWmxOV1lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklHTnNZWE56SUZkaGJHeGxkRTFoY0hCbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UY0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEWXlPRFl5TXpBMklEQjROR1ZsTnpFMU5tSWdNSGczTm1Vek1XRTNaU0F3ZURZMllUZ3lZVGN3SURCNFkySTJaVFkwTjJJZ01IaGlPVFV6WTJFeE9DQXdlREJoWW1RNU16Rm1JREI0TkdSallUQmpaR1FnTHk4Z2JXVjBhRzlrSUNKbWRXNWtYMkZ3Y0NoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZjMmh2Y25SZmFXUW9ZbmwwWlZzMlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHVmhjbDl5WldkcGMzUnlZWFJwYjI0b0tYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOTNZV3hzWlhSZlpuSnZiVjl6YUc5eWRGOXBaQ2hpZVhSbFd6WmRLV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbWRsZEY5emFHOXlkRjlwWkY5bWNtOXRYM2RoYkd4bGRDaGhaR1J5WlhOektXSjVkR1ZiTmwwaUxDQnRaWFJvYjJRZ0ltRmtaRjlpWlc1bFptbGphV0Z5ZVNoaWVYUmxXelpkTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSmpiR1ZoY2w5aVpXNWxabWxqYVdGeWFXVnpLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmWW1WdVpXWnBZMmxoY21sbGN5aGhaR1J5WlhOektTaGllWFJsV3paZExHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTJOQ2xiWFNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHWjFibVJmWVhCd0lISmxaMmx6ZEdWeVgzTm9iM0owWDJsa0lHTnNaV0Z5WDNKbFoybHpkSEpoZEdsdmJpQm5aWFJmZDJGc2JHVjBYMlp5YjIxZmMyaHZjblJmYVdRZ1oyVjBYM05vYjNKMFgybGtYMlp5YjIxZmQyRnNiR1YwSUdGa1pGOWlaVzVsWm1samFXRnllU0JqYkdWaGNsOWlaVzVsWm1samFXRnlhV1Z6SUdkbGRGOWlaVzVsWm1samFXRnlhV1Z6Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UYzZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1WFlXeHNaWFJOWVhCd1pYSXVZMjl1ZEhKaFkzUXVWMkZzYkdWMFRXRndjR1Z5TG1aMWJtUmZZWEJ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1puVnVaRjloY0hBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1WFlXeHNaWFJOWVhCd1pYSXVZMjl1ZEhKaFkzUXVWMkZzYkdWMFRXRndjR1Z5TG5KbFoybHpkR1Z5WDNOb2IzSjBYMmxrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm5hWE4wWlhKZmMyaHZjblJmYVdRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTmo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJR05oYkd4bGNpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPalU0TFRVNUNpQWdJQ0F2THlBaklHTm9aV05ySUdsbUlHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2FXWWdZMkZzYkdWeUlHbHVJSE5sYkdZdVlXUmtjbVZ6YzE5MGIxOXphRzl5ZEY5cFpEb0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNVFkwTnpJMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ2NtVm5hWE4wWlhKZmMyaHZjblJmYVdSZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZWMkZzYkdWMFRXRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qWXdMVFl4Q2lBZ0lDQXZMeUFqSUVsbUlIUm9aWGtnWVhKbElISmxaMmx6ZEdWeWFXNW5JSFJvWlNCVFFVMUZJRWxFSUdGbllXbHVMQ0JxZFhOMElISmxkSFZ5YmlBb2FXUmxiWEJ2ZEdWdWRDa0tJQ0FnSUM4dklHbG1JSE5sYkdZdVlXUmtjbVZ6YzE5MGIxOXphRzl5ZEY5cFpGdGpZV3hzWlhKZElEMDlJSE5vYjNKMFgybGtPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga1pISmxjM05mZEc5ZmMyaHZjblJmYVdRZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZkaGJHeGxkQ0JoYkhKbFlXUjVJR2hoY3lCaElHUnBabVpsY21WdWRDQlRhRzl5ZENCSlJDNGdRMnhsWVhJZ2FYUWdabWx5YzNRdUNncHlaV2RwYzNSbGNsOXphRzl5ZEY5cFpGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVYWVd4c1pYUk5ZWEJ3WlhJdVkyOXVkSEpoWTNRdVYyRnNiR1YwVFdGd2NHVnlMbkpsWjJsemRHVnlYM05vYjNKMFgybGtRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZWMkZzYkdWMFRXRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxaMmx6ZEdWeVgzTm9iM0owWDJsa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOamN0TmpnS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYzJodmNuUWdTVVFnYVhNZ2JtOTBJR0ZzY21WaFpIa2dkR0ZyWlc0Z1lua2djMjl0Wlc5dVpTQmxiSE5sQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMmh2Y25SZmFXUWdibTkwSUdsdUlITmxiR1l1YzJodmNuUmZhV1JmZEc5ZllXUmtjbVZ6Y3l3Z0lsTm9iM0owSUVsRUlHRnNjbVZoWkhrZ2RHRnJaVzRpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpNMk9UWTBOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVTJodmNuUWdTVVFnWVd4eVpXRmtlU0IwWVd0bGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnYzJWc1ppNXphRzl5ZEY5cFpGOTBiMTloWkdSeVpYTnpXM05vYjNKMFgybGtYU0E5SUdOaGJHeGxjZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnYzJWc1ppNWhaR1J5WlhOelgzUnZYM05vYjNKMFgybGtXMk5oYkd4bGNsMGdQU0J6YUc5eWRGOXBaQzVqYjNCNUtDa0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMWRoYkd4bGRFMWhjSEJsY2k5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQ0pUYUc5eWRFbGtVbVZuYVhOMFpYSmxaQ2hoWkdSeVpYTnpMR0o1ZEdWYk5sMHBJaXdnWTJGc2JHVnlMQ0J6YUc5eWRGOXBaQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVdNMFlXVmhNMklnTHk4Z2JXVjBhRzlrSUNKVGFHOXlkRWxrVW1WbmFYTjBaWEpsWkNoaFpHUnlaWE56TEdKNWRHVmJObDBwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWWlCeVpXZHBjM1JsY2w5emFHOXlkRjlwWkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NVhZV3hzWlhSTllYQndaWEl1WTI5dWRISmhZM1F1VjJGc2JHVjBUV0Z3Y0dWeUxuSmxaMmx6ZEdWeVgzTm9iM0owWDJsa1FEWUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11VjJGc2JHVjBUV0Z3Y0dWeUxtTnZiblJ5WVdOMExsZGhiR3hsZEUxaGNIQmxjaTVqYkdWaGNsOXlaV2RwYzNSeVlYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamJHVmhjbDl5WldkcGMzUnlZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZMkZzYkdWeUlHbHVJSE5sYkdZdVlXUmtjbVZ6YzE5MGIxOXphRzl5ZEY5cFpDd2dJazV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWXhOalEzTWpWbUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJqWVd4c1pYSWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpZV3hzWlhJZ2FXNGdjMlZzWmk1aFpHUnlaWE56WDNSdlgzTm9iM0owWDJsa0xDQWlUbTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZPREVLSUNBZ0lDOHZJRzlzWkY5cFpDQTlJSE5sYkdZdVlXUmtjbVZ6YzE5MGIxOXphRzl5ZEY5cFpGdGpZV3hzWlhKZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZPRE1LSUNBZ0lDOHZJR1JsYkNCelpXeG1MbUZrWkhKbGMzTmZkRzlmYzJodmNuUmZhV1JiWTJGc2JHVnlYUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZWMkZzYkdWMFRXRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNXphRzl5ZEY5cFpGOTBiMTloWkdSeVpYTnpXMjlzWkY5cFpGMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNelk1TmpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NVhZV3hzWlhSTllYQndaWEl1WTI5dWRISmhZM1F1VjJGc2JHVjBUV0Z3Y0dWeUxtZGxkRjkzWVd4c1pYUmZabkp2YlY5emFHOXlkRjlwWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjkzWVd4c1pYUmZabkp2YlY5emFHOXlkRjlwWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZPRFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQTJQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxZGhiR3hsZEUxaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRvNE9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhOb2IzSjBYMmxrSUdsdUlITmxiR1l1YzJodmNuUmZhV1JmZEc5ZllXUmtjbVZ6Y3l3Z0lsTm9iM0owSUVsRUlHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNelk1TmpRMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRk5vYjNKMElFbEVJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxZGhiR3hsZEUxaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjMmh2Y25SZmFXUmZkRzlmWVdSa2NtVnpjMXR6YUc5eWRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk9EWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1WFlXeHNaWFJOWVhCd1pYSXVZMjl1ZEhKaFkzUXVWMkZzYkdWMFRXRndjR1Z5TG1kbGRGOXphRzl5ZEY5cFpGOW1jbTl0WDNkaGJHeGxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXphRzl5ZEY5cFpGOW1jbTl0WDNkaGJHeGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnWVhOelpYSjBJSGRoYkd4bGRDQnBiaUJ6Wld4bUxtRmtaSEpsYzNOZmRHOWZjMmh2Y25SZmFXUXNJQ0pYWVd4c1pYUWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qRTJORGN5TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlhZV3hzWlhRZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk9UWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUZrWkhKbGMzTmZkRzlmYzJodmNuUmZhV1JiZDJGc2JHVjBYUzVqYjNCNUtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxZGhiR3hsZEUxaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGxkaGJHeGxkRTFoY0hCbGNpNWpiMjUwY21GamRDNVhZV3hzWlhSTllYQndaWEl1WVdSa1gySmxibVZtYVdOcFlYSjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSa1gySmxibVZtYVdOcFlYSjVPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQnVJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0EyUGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QnZkMjVsY2lBOUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxZGhiR3hsZEUxaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCaVpXNWxabWxqYVdGeWVWOXBaQ0JwYmlCelpXeG1Mbk5vYjNKMFgybGtYM1J2WDJGa1pISmxjM01zSUNKQ1pXNWxabWxqYVdGeWVTQkpSQ0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpNMk9UWTBOV1lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUpsYm1WbWFXTnBZWEo1SUVsRUlHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUdKbGJsOTNZV3hzWlhRZ1BTQnpaV3htTG5Ob2IzSjBYMmxrWDNSdlgyRmtaSEpsYzNOYlltVnVaV1pwWTJsaGNubGZhV1JkQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUdGemMyVnlkQ0J2ZDI1bGNpQWhQU0JpWlc1ZmQyRnNiR1YwTENBaVEyRnVibTkwSUdGa1pDQnpaV3htSWdvZ0lDQWdaR2xuSURFS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMkZ1Ym05MElHRmtaQ0J6Wld4bUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakV3T1MweE1UQUtJQ0FnSUM4dklDTWdVSEpsZG1WdWRDQmtkWEJzYVdOaGRHVnpDaUFnSUNBdkx5QnBaaUJ2ZDI1bGNpQnBiaUJ6Wld4bUxtSmxibVZtYVdOcFlYSnBaWE02Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TmpJMk5UWmxOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHRmtaRjlpWlc1bFptbGphV0Z5ZVY5aFpuUmxjbDlwWmw5bGJITmxRRGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1URXhMVEV4TWdvZ0lDQWdMeThnWlhocGMzUnBibWNnUFNCelpXeG1MbUpsYm1WbWFXTnBZWEpwWlhOYmIzZHVaWEpkTG1OdmNIa29LUW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHVjRhWE4wYVc1bkxteGxibWQwYUNrNkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxZGhiR3hsZEUxaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNobGVHbHpkR2x1Wnk1c1pXNW5kR2dwT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSjFjbmtnTmdvS1lXUmtYMkpsYm1WbWFXTnBZWEo1WDJadmNsOW9aV0ZrWlhKQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5WFlXeHNaWFJOWVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvWlhocGMzUnBibWN1YkdWdVozUm9LVG9LSUNBZ0lHUnBaeUExQ2lBZ0lDQmthV2NnT1FvZ0lDQWdQQW9nSUNBZ1lub2dZV1JrWDJKbGJtVm1hV05wWVhKNVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMWRoYkd4bGRFMWhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNVE1LSUNBZ0lDOHZJR2xtSUdWNGFYTjBhVzVuVzJsZExtSmxibVZtYVdOcFlYSjVYMmxrSUQwOUlHSmxibVZtYVdOcFlYSjVYMmxrT2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHUnBaeUEyQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1JwWnlBMENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdGa1pGOWlaVzVsWm1samFXRnllVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1WFlXeHNaWFJOWVhCd1pYSXVZMjl1ZEhKaFkzUXVWMkZzYkdWMFRXRndjR1Z5TG1Ga1pGOWlaVzVsWm1samFXRnllVUF4TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMWRoYkd4bGRFMWhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGxlR2x6ZEdsdVp5NXNaVzVuZEdncE9nb2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURZS0lDQWdJR0lnWVdSa1gySmxibVZtYVdOcFlYSjVYMlp2Y2w5b1pXRmtaWEpBTXdvS1lXUmtYMkpsYm1WbWFXTnBZWEo1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxsZGhiR3hsZEUxaGNIQmxjaTVqYjI1MGNtRmpkQzVYWVd4c1pYUk5ZWEJ3WlhJdVlXUmtYMkpsYm1WbWFXTnBZWEo1UURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BoWkdSZlltVnVaV1pwWTJsaGNubGZZV1owWlhKZmFXWmZaV3h6WlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TVRZS0lDQWdJQzh2SUc1dmR5QTlJRzl3TGtkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlYyRnNiR1YwVFdGd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1kzSmxZWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2h1YjNjcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakV4TnkweE1qSUtJQ0FnSUM4dklISmxZMjl5WkNBOUlFSmxibVZtYVdOcFlYSjVVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJR0psYm1WbWFXTnBZWEo1WDJsa1BXSmxibVZtYVdOcFlYSjVYMmxrTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCaVpXNWxabWxqYVdGeWVWOTNZV3hzWlhROVltVnVYM2RoYkd4bGRDNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdhR0Z6YUdWa1gzQmhjM04zYjNKa1BXaGhjMmhsWkY5d1lYTnpkMjl5WkN3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURNd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMWRoYkd4bGRFMWhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNalFLSUNBZ0lDOHZJR2xtSUc5M2JtVnlJR2x1SUhObGJHWXVZbVZ1WldacFkybGhjbWxsY3pvS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR0ZrWkY5aVpXNWxabWxqYVdGeWVWOWxiSE5sWDJKdlpIbEFNVEVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1USTFDaUFnSUNBdkx5QmhjbklnUFNCelpXeG1MbUpsYm1WbWFXTnBZWEpwWlhOYmIzZHVaWEpkTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KbGJtVm1hV05wWVhKcFpYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZWMkZzYkdWMFRXRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRXlOZ29nSUNBZ0x5OGdZWEp5TG1Gd2NHVnVaQ2h5WldOdmNtUXVZMjl3ZVNncEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKMWNua2dNVFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURFeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0oxY25rZ01UTUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmlkWEo1SURVS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlkWEo1SURjS0NtRmtaRjlpWlc1bFptbGphV0Z5ZVY5bWIzSmZhR1ZoWkdWeVFERTFPZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQmhaR1JmWW1WdVpXWnBZMmxoY25sZllXWjBaWEpmWm05eVFERTNDaUFnSUNCa2FXY2dNVElLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdScFp5QXhNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmlkWEo1SURFekNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1luVnllU0EzQ2lBZ0lDQmlJR0ZrWkY5aVpXNWxabWxqYVdGeWVWOW1iM0pmYUdWaFpHVnlRREUxQ2dwaFpHUmZZbVZ1WldacFkybGhjbmxmWVdaMFpYSmZabTl5UURFM09nb2dJQ0FnWkdsbklERXlDaUFnSUNCc1pXNEtJQ0FnSUdKMWNua2dPQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdKMWNua2dOd29LWVdSa1gySmxibVZtYVdOcFlYSjVYMlp2Y2w5b1pXRmtaWEpBTVRnNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJRHdLSUNBZ0lHSjZJR0ZrWkY5aVpXNWxabWxqYVdGeWVWOWhablJsY2w5bWIzSkFNakFLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTVDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdaR2xuSURFekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNVE1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdJZ1lXUmtYMkpsYm1WbWFXTnBZWEo1WDJadmNsOW9aV0ZrWlhKQU1UZ0tDbUZrWkY5aVpXNWxabWxqYVdGeWVWOWhablJsY2w5bWIzSkFNakE2Q2lBZ0lDQmthV2NnT1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMWRoYkd4bGRFMWhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNallLSUNBZ0lDOHZJR0Z5Y2k1aGNIQmxibVFvY21WamIzSmtMbU52Y0hrb0tTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeE13b2dJQ0FnWkdsbklEWUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1USTNDaUFnSUNBdkx5QnpaV3htTG1KbGJtVm1hV05wWVhKcFpYTmJiM2R1WlhKZElEMGdZWEp5TG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUdGa1pGOWlaVzVsWm1samFXRnllVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1WFlXeHNaWFJOWVhCd1pYSXVZMjl1ZEhKaFkzUXVWMkZzYkdWMFRXRndjR1Z5TG1Ga1pGOWlaVzVsWm1samFXRnllVUF4TXdvS1lXUmtYMkpsYm1WbWFXTnBZWEo1WDJWc2MyVmZZbTlrZVVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5WFlXeHNaWFJOWVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCaGNuSWdQU0JoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRDWlc1bFptbGphV0Z5ZVZKbFkyOXlaRjBvY21WamIzSmtMbU52Y0hrb0tTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREV3TURBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5WFlXeHNaWFJOWVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCelpXeG1MbUpsYm1WbWFXTnBZWEpwWlhOYmIzZHVaWEpkSUQwZ1lYSnlMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJR0ZrWkY5aVpXNWxabWxqYVdGeWVWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVYWVd4c1pYUk5ZWEJ3WlhJdVkyOXVkSEpoWTNRdVYyRnNiR1YwVFdGd2NHVnlMbUZrWkY5aVpXNWxabWxqYVdGeWVVQXhNd29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1WFlXeHNaWFJOWVhCd1pYSXVZMjl1ZEhKaFkzUXVWMkZzYkdWMFRXRndjR1Z5TG1Oc1pXRnlYMkpsYm1WbWFXTnBZWEpwWlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiR1ZoY2w5aVpXNWxabWxqYVdGeWFXVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxZGhiR3hsZEUxaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklHbG1JRzkzYm1WeUlHbHVJSE5sYkdZdVltVnVaV1pwWTJsaGNtbGxjem9LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcyTWpZMU5tVTFaZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxZGhiR3hsZEUxaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE16VUtJQ0FnSUM4dklHOTNibVZ5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlYyRnNiR1YwVFdGd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFek5nb2dJQ0FnTHk4Z2FXWWdiM2R1WlhJZ2FXNGdjMlZzWmk1aVpXNWxabWxqYVdGeWFXVnpPZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1kyeGxZWEpmWW1WdVpXWnBZMmxoY21sbGMxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVpWlc1bFptbGphV0Z5YVdWelcyOTNibVZ5WFFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0NtTnNaV0Z5WDJKbGJtVm1hV05wWVhKcFpYTmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFkaGJHeGxkRTFoY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1WFlXeHNaWFJOWVhCd1pYSXVZMjl1ZEhKaFkzUXVWMkZzYkdWMFRXRndjR1Z5TG1kbGRGOWlaVzVsWm1samFXRnlhV1Z6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkpsYm1WbWFXTnBZWEpwWlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VjJGc2JHVjBUV0Z3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZWMkZzYkdWMFRXRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdhV1lnYjNkdVpYSWdhVzRnYzJWc1ppNWlaVzVsWm1samFXRnlhV1Z6T2dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURZeU5qVTJaVFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQm5aWFJmWW1WdVpXWnBZMmxoY21sbGMxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlYWVd4c1pYUk5ZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVFF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aVpXNWxabWxqYVdGeWFXVnpXMjkzYm1WeVhTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltVnVaV1pwWTJsaGNtbGxjeUJsYm5SeWVTQmxlR2x6ZEhNS0NtZGxkRjlpWlc1bFptbGphV0Z5YVdWelgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbGRoYkd4bGRFMWhjSEJsY2k1amIyNTBjbUZqZEM1WFlXeHNaWFJOWVhCd1pYSXVaMlYwWDJKbGJtVm1hV05wWVhKcFpYTkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGOWlaVzVsWm1samFXRnlhV1Z6WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhsYlFtVnVaV1pwWTJsaGNubFNaV052Y21SZEtDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVhZV3hzWlhSTllYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDJKbGJtVm1hV05wWVhKcFpYTmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11VjJGc2JHVjBUV0Z3Y0dWeUxtTnZiblJ5WVdOMExsZGhiR3hsZEUxaGNIQmxjaTVuWlhSZlltVnVaV1pwWTJsaGNtbGxjMEEwQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBZ0VBQmlZRUJITnBaRjhFWVdSeVh3UVZIM3gxQkdKbGJsOHhHMEVBUnpFWkZFUXhHRVNDQ0FSaWhpTUdCRTduRldzRWR1TWFmZ1JtcUNwd0JNdHVaSHNFdVZQS0dBUUt2Wk1mQkUzS0ROMDJHZ0NPQ0FBSkFCTUFWd0J0QUlVQW5nSFNBZUlBTVJrVU1SZ1VFRU0yR2dFVmdRZ1NSQ05ETmhvQlNSVWxFa1F4QUVsT0FpbE1VRWxPQXIxRkFVRUFDRXNCdmtRU1JDTkRLRXNCVUVtOVJRRVVSRXNEU1U0Q3Ywc0NTd0svVEZDQUJCeEs2anRNVUxCQy85c3BNUUJRU2IxRkFVUkp2a2hNdkVnb1RGQzhTQ05ETmhvQlNSVWxFa1FvVEZCSnZVVUJSTDVJS2t4UXNDTkROaG9CU1JXQklCSkVLVXhRU2IxRkFVUytTQ3BNVUxBalF5UkhBb0FBUndVMkdnRkhBaFVsRWtRMkdnSkpUZ0pKSkZraUNFd1ZFa1F4QUNoUEFsQkp2VVVCUkw1SVNVNENTd0VUUkN0TVVFbTlSUUZCQURWSkpDSzZGMFVKSkVVR1N3VkxDUXhCQUNNaVN3WUxJZ2hMQVVsUEFpSzZGeUlJSmJwTEJCSkFBQWxMQlNNSVJRWkMvOWNqUXpJSEZrc0VTd05RZ0FJQU1GQk1VRXNEVUVzQnZVVUJRUUNXU3dHK1JFa2tXVWxPQWtVTlZ3SUFSUStBQWdBQ1R3SlFSUXlBQUVVTklndEZCU1JGQjBzR1N3VU1RUUFiU3d4TEIwbE9BbGtpQ0JaWEJnSkxEVXhRUlEwaUNFVUhRdi9kU3d3VlJRZ2tSUWRMQmlJTVFRQWNTd3BMQjBsT0FsbExDUWdXVndZQ1N3MU1VRVVOSWdoRkIwTC8zVXNKSXdnV1Z3WUNTd3hRU3cxTEJrc0tVbEJMQzFjQ0FGQkxBVW04U0V5L1F2OU9nQVFBQVFBQ1RGQkxBVW04U0V5L1F2ODhLekVBVUVtOVJRRkJBQU5KdkVnalF6WWFBVWtWZ1NBU1JDdE1VRW05UlFGQkFBbEp2a1FxVEZDd0kwT0FBZ0FBUXYveiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlNob3J0SWRSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlWzZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
