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

namespace Arc56.Generated.orinx_org.orinx_contracts_algorand.OrinxRegistry_78de42d1
{


    public class OrinxRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OrinxRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class UsernameData : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public byte[] MetaAddress { get; set; }

                public ulong RegistrationTime { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetaAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vMetaAddress.From(MetaAddress);
                    ret.AddRange(vMetaAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrationTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegistrationTime.From(RegistrationTime);
                    ret.AddRange(vRegistrationTime.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UsernameData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UsernameData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetaAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vMetaAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMetaAddress = vMetaAddress.ToValue();
                    if (valueMetaAddress is byte[] vMetaAddressValue) { ret.MetaAddress = vMetaAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrationTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegistrationTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistrationTime = vRegistrationTime.ToValue();
                    if (valueRegistrationTime is ulong vRegistrationTimeValue) { ret.RegistrationTime = vRegistrationTimeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UsernameData);
                }
                public bool Equals(UsernameData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UsernameData left, UsernameData right)
                {
                    return EqualityComparer<UsernameData>.Default.Equals(left, right);
                }
                public static bool operator !=(UsernameData left, UsernameData right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task CreateApplication(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="username"> </param>
        /// <param name="metaAddress"> </param>
        public async Task RegisterUsername(PaymentTransaction payment, string username, byte[] metaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 65, 243, 120, 217 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);
            var metaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); metaAddressAbi.From(metaAddress);

            var result = await base.CallApp(new List<object> { abiHandle, payment, usernameAbi, metaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterUsername_Transactions(PaymentTransaction payment, string username, byte[] metaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 65, 243, 120, 217 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);
            var metaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); metaAddressAbi.From(metaAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, usernameAbi, metaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="username"> </param>
        /// <param name="newMetaAddress"> </param>
        public async Task UpdateStealthKeys(string username, byte[] newMetaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 40, 225, 185 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);
            var newMetaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); newMetaAddressAbi.From(newMetaAddress);

            var result = await base.CallApp(new List<object> { abiHandle, usernameAbi, newMetaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateStealthKeys_Transactions(string username, byte[] newMetaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 40, 225, 185 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);
            var newMetaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(64, "byte"); newMetaAddressAbi.From(newMetaAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, usernameAbi, newMetaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="username"> </param>
        /// <param name="newOwner"> </param>
        public async Task TransferUsername(string username, Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 189, 80, 27 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, usernameAbi, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferUsername_Transactions(string username, Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 189, 80, 27 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, usernameAbi, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="username"> </param>
        public async Task DeleteUsername(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 28, 119, 15 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            var result = await base.CallApp(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteUsername_Transactions(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 28, 119, 15 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            return await base.MakeTransactionList(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fee"> </param>
        public async Task SetRegistrationFee(ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 41, 31, 145 };
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            var result = await base.CallApp(new List<object> { abiHandle, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRegistrationFee_Transactions(ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 41, 31, 145 };
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAdmin"> </param>
        public async Task SetAdmin(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 134, 105, 18 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAdmin_Transactions(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 134, 105, 18 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="username"> </param>
        public async Task<Structs.UsernameData> ResolveUsername(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 101, 19, 201 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            var result = await base.SimApp(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.UsernameData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ResolveUsername_Transactions(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 101, 19, 201 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            return await base.MakeTransactionList(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="username"> </param>
        public async Task<bool> UsernameExists(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 200, 150, 159 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            var result = await base.SimApp(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UsernameExists_Transactions(string username, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 200, 150, 159 };
            var usernameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); usernameAbi.From(username);

            return await base.MakeTransactionList(new List<object> { abiHandle, usernameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="metaAddress"> </param>
        public async Task<bool> MetaAddressExists(byte[] metaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 229, 104, 48 };
            var metaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metaAddressAbi.From(metaAddress);

            var result = await base.SimApp(new List<object> { abiHandle, metaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MetaAddressExists_Transactions(byte[] metaAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 229, 104, 48 };
            var metaAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metaAddressAbi.From(metaAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, metaAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 139, 36, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetRegistrationFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 206, 179, 97 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRegistrationFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 206, 179, 97 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Version(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 140, 190, 133 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Version_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 140, 190, 133 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3JpbnhSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJVc2VybmFtZURhdGEiOlt7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibWV0YUFkZHJlc3MiLCJ0eXBlIjoiYnl0ZVs2NF0ifSx7Im5hbWUiOiJyZWdpc3RyYXRpb25UaW1lIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJVc2VybmFtZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VybmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs2NF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVTdGVhbHRoS2V5cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VybmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVs2NF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdNZXRhQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlclVzZXJuYW1lIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3T3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlVXNlcm5hbWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlcm5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0UmVnaXN0cmF0aW9uRmVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRBZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzb2x2ZVVzZXJuYW1lIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGJ5dGVbNjRdLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJVc2VybmFtZURhdGEiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVzZXJuYW1lRXhpc3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWV0YUFkZHJlc3NFeGlzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0YUFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlZ2lzdHJhdGlvbkZlZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNDRdLCJlcnJvck1lc3NhZ2UiOiJGZWUgbXVzdCBnbyB0byBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1Nl0sImVycm9yTWVzc2FnZSI6IkluY29ycmVjdCBmZWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjRdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIG5ldyBvd25lciBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkyLDM5NV0sImVycm9yTWVzc2FnZSI6Ik1ldGEtYWRkcmVzcyBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBjaGFuZ2UgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBzZXQgZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gZGVsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gdHJhbnNmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiB1cGRhdGUga2V5cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MF0sImVycm9yTWVzc2FnZSI6IlVzZXJuYW1lIGFscmVhZHkgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Nyw0NDgsNDk0LDU4Nl0sImVycm9yTWVzc2FnZSI6IlVzZXJuYW1lIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MF0sImVycm9yTWVzc2FnZSI6IlVzZXJuYW1lIHRvbyBsb25nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY3XSwiZXJyb3JNZXNzYWdlIjoiVXNlcm5hbWUgdG9vIHNob3J0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUzLDUzMyw1NTUsNjY5LDY4MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMCwzMjAsNDIxLDQ3Niw1NjgsNjAwLDYzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNywzMjcsNDI4LDQ4Myw1NzUsNjA3LDY0Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODYsNDM2LDU0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzYsMzM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURJZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luVnpaWEpmSWlBaVlXUnRhVzRpSUNKdFpYUmhYeUlnTUhneE5URm1OMk0zTlNBaWNtVm5hWE4wY21GMGFXOXVSbVZsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJQY21sdWVGSmxaMmx6ZEhKNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFMkNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE5ERm1NemM0WkRrZ01IaGtZakk0WlRGaU9TQXdlRFEwWW1RMU1ERmlJREI0Tm1ReFl6YzNNR1lnTUhobVpUSTVNV1k1TVNBd2VERTNPRFkyT1RFeUlEQjRPR1EyTlRFell6a2dNSGc1TjJNNE9UWTVaaUF3ZUdRMlpUVTJPRE13SURCNFlXTTRZakkwWkdVZ01IaGtPV05sWWpNMk1TQXdlR000T0dOaVpUZzFJQzh2SUcxbGRHaHZaQ0FpY21WbmFYTjBaWEpWYzJWeWJtRnRaU2h3WVhrc2MzUnlhVzVuTEdKNWRHVmJOalJkS1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWTjBaV0ZzZEdoTFpYbHpLSE4wY21sdVp5eGllWFJsV3pZMFhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2xWelpYSnVZVzFsS0hOMGNtbHVaeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxiR1YwWlZWelpYSnVZVzFsS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJTWldkcGMzUnlZWFJwYjI1R1pXVW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFRmtiV2x1S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljbVZ6YjJ4MlpWVnpaWEp1WVcxbEtITjBjbWx1Wnlrb1lXUmtjbVZ6Y3l4aWVYUmxXelkwWFN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKMWMyVnlibUZ0WlVWNGFYTjBjeWh6ZEhKcGJtY3BZbTl2YkNJc0lHMWxkR2h2WkNBaWJXVjBZVUZrWkhKbGMzTkZlR2x6ZEhNb1lubDBaVnRkS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEVGa2JXbHVLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0puWlhSU1pXZHBjM1J5WVhScGIyNUdaV1VvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZG1WeWMybHZiaWdwYzNSeWFXNW5JZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21WbmFYTjBaWEpWYzJWeWJtRnRaU0IxY0dSaGRHVlRkR1ZoYkhSb1MyVjVjeUIwY21GdWMyWmxjbFZ6WlhKdVlXMWxJR1JsYkdWMFpWVnpaWEp1WVcxbElITmxkRkpsWjJsemRISmhkR2x2YmtabFpTQnpaWFJCWkcxcGJpQnlaWE52YkhabFZYTmxjbTVoYldVZ2RYTmxjbTVoYldWRmVHbHpkSE1nYldWMFlVRmtaSEpsYzNORmVHbHpkSE1nWjJWMFFXUnRhVzRnWjJWMFVtVm5hWE4wY21GMGFXOXVSbVZsSUcxaGFXNWZkbVZ5YzJsdmJsOXliM1YwWlVBeE5Bb2dJQ0FnWlhKeUNncHRZV2x1WDNabGNuTnBiMjVmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16UUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREExTXpFeVpUTXdNbVV6TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUGNtbHVlRkpsWjJsemRISjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaRE15TkdKbFlUUWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWhoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rOXlhVzU0VW1WbmFYTjBjbmt1WTNKbFlYUmxRWEJ3YkdsallYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExrRmtaSEpsYzNNK0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklIUm9hWE11WVdSdGFXNHVkbUZzZFdVZ1BTQmhaRzFwYmdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QnlaV2RwYzNSeVlYUnBiMjVHWldVZ1BTQkhiRzlpWVd4VGRHRjBaVHhoY21NMExsVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNtVm5hWE4wY21GMGFXOXVSbVZsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIUm9hWE11Y21WbmFYTjBjbUYwYVc5dVJtVmxMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZERZMEtEQXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazl5YVc1NFVtVm5hWE4wY25rdWNtVm5hWE4wWlhKVmMyVnlibUZ0WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxaMmx6ZEdWeVZYTmxjbTVoYldVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEWTBJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMk5ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJQ0pHWldVZ2JYVnpkQ0JuYnlCMGJ5QmpiMjUwY21GamRDSXBPd29nSUNBZ1pHbG5JRElLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdaV1VnYlhWemRDQm5ieUIwYnlCamIyNTBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHRnpjMlZ5ZENod1lYbHRaVzUwTG1GdGIzVnVkQ0E5UFQwZ2RHaHBjeTV5WldkcGMzUnlZWFJwYjI1R1pXVXVkbUZzZFdVdVlYTlZhVzUwTmpRb0tTd2dJa2x1WTI5eWNtVmpkQ0JtWldVaUtUc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhKbFoybHpkSEpoZEdsdmJrWmxaU0E5SUVkc2IySmhiRk4wWVhSbFBHRnlZelF1VldsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WldkcGMzUnlZWFJwYjI1R1pXVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVcxbGJuUXVZVzF2ZFc1MElEMDlQU0IwYUdsekxuSmxaMmx6ZEhKaGRHbHZia1psWlM1MllXeDFaUzVoYzFWcGJuUTJOQ2dwTENBaVNXNWpiM0p5WldOMElHWmxaU0lwT3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjBiMmtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNWpiM0p5WldOMElHWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUdOdmJuTjBJRzVoYldWQ2VYUmxjeUE5SUVKNWRHVnpLSFZ6WlhKdVlXMWxMbTVoZEdsMlpTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdZMjl1YzNRZ2JtRnRaVXhsYmlBOUlHNWhiV1ZDZVhSbGN5NXNaVzVuZEdnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z1lYTnpaWEowS0c1aGJXVk1aVzRnUGowZ1ZWTkZVazVCVFVWZlRVbE9YMHhGVGtkVVNDd2dKMVZ6WlhKdVlXMWxJSFJ2YnlCemFHOXlkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUF6Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklGVnpaWEp1WVcxbElIUnZieUJ6YUc5eWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDaHVZVzFsVEdWdUlEdzlJRlZUUlZKT1FVMUZYMDFCV0Y5TVJVNUhWRWdzSUNkVmMyVnlibUZ0WlNCMGIyOGdiRzl1WnljcENpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWWE5sY201aGJXVWdkRzl2SUd4dmJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUIxYzJWeWJtRnRaVVJoZEdFZ1BTQkNiM2hOWVhBOFlubDBaWE1zSUZWelpYSnVZVzFsUkdGMFlUNG9leUJyWlhsUWNtVm1hWGc2SUNkMWMyVnlYeWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5WelpYSmZJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENnaGRYTmxja0p2ZUM1bGVHbHpkSE1zSUNkVmMyVnlibUZ0WlNCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCVmMyVnlibUZ0WlNCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QmpiMjV6ZENCdFpYUmhTR0Z6YUNBOUlHOXdMbk5vWVRJMU5paHRaWFJoUVdSa2NtVnpjeTV1WVhScGRtVXBDaUFnSUNCa2FXY2dNZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2JXVjBZVWhoYzJoVWIxVnpaWEp1WVcxbElEMGdRbTk0VFdGd1BHSjVkR1Z6TENCaWVYUmxjejRvZXlCclpYbFFjbVZtYVhnNklDZHRaWFJoWHljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltMWxkR0ZmSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZWE56WlhKMEtDRnRaWFJoUW05NExtVjRhWE4wY3l3Z0owMWxkR0V0WVdSa2NtVnpjeUJoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJOWlhSaExXRmtaSEpsYzNNZ1lXeHlaV0ZrZVNCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdiM2R1WlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdZMjl1YzNRZ1kzVnljbVZ1ZEZScGJXVWdQU0JIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdjbVZuYVhOMGNtRjBhVzl1VkdsdFpUb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtHTjFjbkpsYm5SVWFXMWxLUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnprdE9ETUtJQ0FnSUM4dklIVnpaWEpDYjNndWRtRnNkV1VnUFNCdVpYY2dWWE5sY201aGJXVkVZWFJoS0hzS0lDQWdJQzh2SUNBZ2IzZHVaWEk2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lHMWxkR0ZCWkdSeVpYTnpPaUJ0WlhSaFFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ2NtVm5hWE4wY21GMGFXOXVWR2x0WlRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0dOMWNuSmxiblJVYVcxbEtRb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJRzFsZEdGQ2IzZ3VkbUZzZFdVZ1BTQnVZVzFsUW5sMFpYTUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazl5YVc1NFVtVm5hWE4wY25rdWRYQmtZWFJsVTNSbFlXeDBhRXRsZVhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWVGRHVmhiSFJvUzJWNWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUWdMeThnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURZMFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJR052Ym5OMElHNWhiV1ZDZVhSbGN5QTlJRUo1ZEdWektIVnpaWEp1WVcxbExtNWhkR2wyWlNrS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjFjMlZ5Ym1GdFpVUmhkR0VnUFNCQ2IzaE5ZWEE4WW5sMFpYTXNJRlZ6WlhKdVlXMWxSR0YwWVQ0b2V5QnJaWGxRY21WbWFYZzZJQ2QxYzJWeVh5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZ6WlhKZklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCaGMzTmxjblFvZFhObGNrSnZlQzVsZUdsemRITXNJQ2RWYzJWeWJtRnRaU0J1YjNRZ1ptOTFibVFuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCVmMyVnlibUZ0WlNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLSFZ6WlhKQ2IzZ3VkbUZzZFdVcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TlFvZ0lDQWdMeThnWVhOelpYSjBLR1JoZEdFdWIzZHVaWEl1Ym1GMGFYWmxJRDA5UFNCVWVHNHVjMlZ1WkdWeUxDQW5UMjVzZVNCdmQyNWxjaUJqWVc0Z2RYQmtZWFJsSUd0bGVYTW5LUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCdmQyNWxjaUJqWVc0Z2RYQmtZWFJsSUd0bGVYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TVFvZ0lDQWdMeThnWTI5dWMzUWdibVYzVFdWMFlVaGhjMmdnUFNCdmNDNXphR0V5TlRZb2JtVjNUV1YwWVVGa1pISmxjM011Ym1GMGFYWmxLUW9nSUNBZ2MzZGhjQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2JXVjBZVWhoYzJoVWIxVnpaWEp1WVcxbElEMGdRbTk0VFdGd1BHSjVkR1Z6TENCaWVYUmxjejRvZXlCclpYbFFjbVZtYVhnNklDZHRaWFJoWHljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltMWxkR0ZmSWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCamIyNXpkQ0J2YkdSTlpYUmhTR0Z6YUNBOUlHOXdMbk5vWVRJMU5paGtZWFJoTG0xbGRHRkJaR1J5WlhOekxtNWhkR2wyWlNrS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTmpRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUdsbUlDaHVaWGROWlhSaFNHRnphQ0FoUFQwZ2IyeGtUV1YwWVVoaGMyZ3BJSHNLSUNBZ0lDRTlDaUFnSUNCaWVpQjFjR1JoZEdWVGRHVmhiSFJvUzJWNWMxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOd29nSUNBZ0x5OGdZWE56WlhKMEtDRnVaWGROWlhSaFFtOTRMbVY0YVhOMGN5d2dKMDFsZEdFdFlXUmtjbVZ6Y3lCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRbktRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RXVjBZUzFoWkdSeVpYTnpJR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUcxbGRHRklZWE5vVkc5VmMyVnlibUZ0WlNBOUlFSnZlRTFoY0R4aWVYUmxjeXdnWW5sMFpYTStLSHNnYTJWNVVISmxabWw0T2lBbmJXVjBZVjhuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdFpYUmhYeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlNUW9nSUNBZ0x5OGdiMnhrVFdWMFlVSnZlQzVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklHNWxkMDFsZEdGQ2IzZ3VkbUZzZFdVZ1BTQnVZVzFsUW5sMFpYTUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCa2FXY2dOQW9nSUNBZ1ltOTRYM0IxZEFvS2RYQmtZWFJsVTNSbFlXeDBhRXRsZVhOZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTRMVEV5T1FvZ0lDQWdMeThnWkdGMFlTNXRaWFJoUVdSa2NtVnpjeUE5SUc1bGQwMWxkR0ZCWkdSeVpYTnpDaUFnSUNBdkx5QjFjMlZ5UW05NExuWmhiSFZsSUQwZ1kyeHZibVVvWkdGMFlTa0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUdScFp5QTJDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUGNtbHVlRkpsWjJsemRISjVMblJ5WVc1elptVnlWWE5sY201aGJXVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwY21GdWMyWmxjbFZ6WlhKdVlXMWxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTRDaUFnSUNBdkx5QmpiMjV6ZENCdVlXMWxRbmwwWlhNZ1BTQkNlWFJsY3loMWMyVnlibUZ0WlM1dVlYUnBkbVVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhWelpYSnVZVzFsUkdGMFlTQTlJRUp2ZUUxaGNEeGllWFJsY3l3Z1ZYTmxjbTVoYldWRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0ozVnpaWEpmSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRYTmxjbDhpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNZ29nSUNBZ0x5OGdZWE56WlhKMEtIVnpaWEpDYjNndVpYaHBjM1J6TENBblZYTmxjbTVoYldVZ2JtOTBJR1p2ZFc1a0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdWWE5sY201aGJXVWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRVS0lDQWdJQzh2SUdOdmJuTjBJR1JoZEdFZ1BTQmpiRzl1WlNoMWMyVnlRbTk0TG5aaGJIVmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dSaGRHRXViM2R1WlhJdWJtRjBhWFpsSUQwOVBTQlVlRzR1YzJWdVpHVnlMQ0FuVDI1c2VTQnZkMjVsY2lCallXNGdkSEpoYm5ObVpYSW5LUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2IzZHVaWElnWTJGdUlIUnlZVzV6Wm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGRQZDI1bGNpNXVZWFJwZG1VZ0lUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdnSjBsdWRtRnNhV1FnYm1WM0lHOTNibVZ5SUdGa1pISmxjM01uS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUc1bGR5QnZkMjVsY2lCaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UUXRNVFUxQ2lBZ0lDQXZMeUJrWVhSaExtOTNibVZ5SUQwZ2JtVjNUM2R1WlhJS0lDQWdJQzh2SUhWelpYSkNiM2d1ZG1Gc2RXVWdQU0JqYkc5dVpTaGtZWFJoS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s5eWFXNTRVbVZuYVhOMGNua3VaR1ZzWlhSbFZYTmxjbTVoYldWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdWVmMyVnlibUZ0WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpFS0lDQWdJQzh2SUdOdmJuTjBJRzVoYldWQ2VYUmxjeUE5SUVKNWRHVnpLSFZ6WlhKdVlXMWxMbTVoZEdsMlpTa0tJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdkWE5sY201aGJXVkVZWFJoSUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JWYzJWeWJtRnRaVVJoZEdFK0tIc2dhMlY1VUhKbFptbDRPaUFuZFhObGNsOG5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVh5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMUNpQWdJQ0F2THlCaGMzTmxjblFvZFhObGNrSnZlQzVsZUdsemRITXNJQ2RWYzJWeWJtRnRaU0J1YjNRZ1ptOTFibVFuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCVmMyVnlibUZ0WlNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJPQW9nSUNBZ0x5OGdZMjl1YzNRZ1pHRjBZU0E5SUdOc2IyNWxLSFZ6WlhKQ2IzZ3VkbUZzZFdVcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN4Q2lBZ0lDQXZMeUJoYzNObGNuUW9aR0YwWVM1dmQyNWxjaTV1WVhScGRtVWdQVDA5SUZSNGJpNXpaVzVrWlhJc0lDZFBibXg1SUc5M2JtVnlJR05oYmlCa1pXeGxkR1VuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnZkMjVsY2lCallXNGdaR1ZzWlhSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR052Ym5OMElHMWxkR0ZJWVhOb0lEMGdiM0F1YzJoaE1qVTJLR1JoZEdFdWJXVjBZVUZrWkhKbGMzTXVibUYwYVhabEtRb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBMk5Bb2dJQ0FnYzJoaE1qVTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnYldWMFlVaGhjMmhVYjFWelpYSnVZVzFsSUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JpZVhSbGN6NG9leUJyWlhsUWNtVm1hWGc2SUNkdFpYUmhYeWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW0xbGRHRmZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56WUtJQ0FnSUM4dklHMWxkR0ZDYjNndVpHVnNaWFJsS0NrS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGM1Q2lBZ0lDQXZMeUIxYzJWeVFtOTRMbVJsYkdWMFpTZ3BDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazl5YVc1NFVtVm5hWE4wY25rdWMyVjBVbVZuYVhOMGNtRjBhVzl1Um1WbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVW1WbmFYTjBjbUYwYVc5dVJtVmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1V1Ym1GMGFYWmxMQ0FuVDI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUdabFpTY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHRmtiV2x1SUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1QlpHUnlaWE56UGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaFpHMXBiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVXVibUYwYVhabExDQW5UMjVzZVNCaFpHMXBiaUJqWVc0Z2MyVjBJR1psWlNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVJR05oYmlCelpYUWdabVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2NtVm5hWE4wY21GMGFXOXVSbVZsSUQwZ1IyeHZZbUZzVTNSaGRHVThZWEpqTkM1VmFXNTBOalErS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5KbFoybHpkSEpoZEdsdmJrWmxaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5nb2dJQ0FnTHk4Z2RHaHBjeTV5WldkcGMzUnlZWFJwYjI1R1pXVXVkbUZzZFdVZ1BTQm1aV1VLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBQY21sdWVGSmxaMmx6ZEhKNUxuTmxkRUZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwUVdSdGFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVElLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbUZrYldsdUxuWmhiSFZsTG01aGRHbDJaU3dnSjA5dWJIa2dZV1J0YVc0Z1kyRnVJR05vWVc1blpTQmhaRzFwYmljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdGa2JXbHVJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TWdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVdSdGFXNHVkbUZzZFdVdWJtRjBhWFpsTENBblQyNXNlU0JoWkcxcGJpQmpZVzRnWTJoaGJtZGxJR0ZrYldsdUp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRnWTJGdUlHTm9ZVzVuWlNCaFpHMXBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdGa2JXbHVJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TXdvZ0lDQWdMeThnZEdocGN5NWhaRzFwYmk1MllXeDFaU0E5SUc1bGQwRmtiV2x1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VDNKcGJuaFNaV2RwYzNSeWVTNXlaWE52YkhabFZYTmxjbTVoYldWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaWE52YkhabFZYTmxjbTVoYldVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrNUNpQWdJQ0F2THlCamIyNXpkQ0J1WVcxbFFubDBaWE1nUFNCQ2VYUmxjeWgxYzJWeWJtRnRaUzV1WVhScGRtVXBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSFZ6WlhKdVlXMWxSR0YwWVNBOUlFSnZlRTFoY0R4aWVYUmxjeXdnVlhObGNtNWhiV1ZFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNWelpYSmZKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFhObGNsOGlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd01Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hWelpYSkNiM2d1WlhocGMzUnpMQ0FuVlhObGNtNWhiV1VnYm05MElHWnZkVzVrSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZYTmxjbTVoYldVZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRElLSUNBZ0lDOHZJSEpsZEhWeWJpQjFjMlZ5UW05NExuWmhiSFZsQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2s5eWFXNTRVbVZuYVhOMGNua3VkWE5sY201aGJXVkZlR2x6ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjMlZ5Ym1GdFpVVjRhWE4wY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21sdWVGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURnS0lDQWdJQzh2SUdOdmJuTjBJRzVoYldWQ2VYUmxjeUE5SUVKNWRHVnpLSFZ6WlhKdVlXMWxMbTVoZEdsMlpTa0tJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdkWE5sY201aGJXVkVZWFJoSUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JWYzJWeWJtRnRaVVJoZEdFK0tIc2dhMlY1VUhKbFptbDRPaUFuZFhObGNsOG5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVh5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFd0NpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lHRnlZelF1UW05dmJDaDFjMlZ5UW05NExtVjRhWE4wY3lrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakEyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlQzSnBibmhTWldkcGMzUnllUzV0WlhSaFFXUmtjbVZ6YzBWNGFYTjBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xbGRHRkJaR1J5WlhOelJYaHBjM1J6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TmdvZ0lDQWdMeThnWTI5dWMzUWdiV1YwWVVoaGMyZ2dQU0J2Y0M1emFHRXlOVFlvYldWMFlVRmtaSEpsYzNNdWJtRjBhWFpsS1FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHMWxkR0ZJWVhOb1ZHOVZjMlZ5Ym1GdFpTQTlJRUp2ZUUxaGNEeGllWFJsY3l3Z1lubDBaWE0rS0hzZ2EyVjVVSEpsWm1sNE9pQW5iV1YwWVY4bklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnRaWFJoWHlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eWFXNTRYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakU0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUdGeVl6UXVRbTl2YkNodFpYUmhRbTk0TG1WNGFYTjBjeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VDNKcGJuaFNaV2RwYzNSeWVTNW5aWFJCWkcxcGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVGa2JXbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJMENpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NWhaRzFwYmk1MllXeDFaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtbHVlRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJoWkcxcGJpQTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRV1JrY21WemN6NG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKcGJuaGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNalFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1Ga2JXbHVMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5YVc1NFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VDNKcGJuaFNaV2RwYzNSeWVTNW5aWFJTWldkcGMzUnlZWFJwYjI1R1pXVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU1pXZHBjM1J5WVhScGIyNUdaV1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0pwYm5oZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16QUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkpsWjJsemRISmhkR2x2YmtabFpTNTJZV3gxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWx1ZUY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCeVpXZHBjM1J5WVhScGIyNUdaV1VnUFNCSGJHOWlZV3hUZEdGMFpUeGhjbU0wTGxWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpY21WbmFYTjBjbUYwYVc5dVJtVmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlhVzU0WDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNd0NpQWdJQ0F2THlCeVpYUjFjbTRnZEdocGN5NXlaV2RwYzNSeVlYUnBiMjVHWldVdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSnBibmhmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDSUNZRkJYVnpaWEpmQldGa2JXbHVCVzFsZEdGZkJCVWZmSFVQY21WbmFYTjBjbUYwYVc5dVJtVmxNUmtVUkRFWVFRQnNnZ3dFUWZONDJRVGJLT0c1QkVTOVVCc0ViUngzRHdUK0tSK1JCQmVHYVJJRWpXVVR5UVNYeUphZkJOYmxhREFFcklzazNnVFp6ck5oQk1pTXZvVTJHZ0NPREFBNUFLY0JEQUZEQVhNQmlnR2ZBYjhCNGdJR0FoQUFBUUNBQ3hVZmZIVUFCVEV1TUM0d3NDSkRnQVRUSkw2a05ob0FqZ0VBQVFBMkdnRkpGU1VTUkNsTVp5Y0VnQWdBQUFBQUFBQUFBR2NpUXpFV0lnbEpPQkFpRWtRMkdnRkpJMWtrQ0VzQkZSSkVOaG9DU1JXQlFCSkVTd0k0QnpJS0VrUlBBamdJSXljRVpVUVhFa1JNVndJQVNSVkpnUU1QUkNVT1JDaExBVkJKdlVVQkZFUkxBZ0VxVEZCSnZVVUJGRVF4QURJSEZreFBCVkJNVUU4Q1RMOUp2RWhNdnlKRE5ob0JTU05aSkFoTEFSVVNSRFlhQWtsT0Fra1ZnVUFTUkV4WEFnQkpUZ0lvVEZCSlRnSkp2VVVCUkw1SVNWY0FJREVBRWtSTUFTcExBVkJPQWt4WElFQUJTVTRDRTBFQUZFc0JTYjFGQVJSRUtrc0NVTHhJU2J4SVN3Uy9Td0lsU3dhN0lrTTJHZ0ZKSTFra0NFc0JGUkpFTmhvQ1NSVWxFa1JNVndJQUtFeFFTYjFGQVVSSnZraFhBQ0F4QUJKRVN3RXlBeE5FSTA4Q3V5SkROaG9CU1NOWkpBaExBUlVTUkZjQ0FDaE1VRW05UlFGRVNiNUlTVmNBSURFQUVrUlhJRUFCS2t4UXZFaThTQ0pETmhvQlNSV0JDQkpFTVFBaktXVkVFa1FuQkV4bklrTTJHZ0ZKRlNVU1JERUFJeWxsUkJKRUtVeG5Ja00yR2dGSkkxa2tDRXNCRlJKRVZ3SUFLRXhRU2IxRkFVUytTQ3RNVUxBaVF6WWFBVWtqV1NRSVN3RVZFa1JYQWdBb1RGQzlSUUdBQVFBalR3SlVLMHhRc0NKRE5ob0JTU05aSkFoTEFSVVNSRmNDQUFFcVRGQzlSUUdBQVFBalR3SlVLMHhRc0NKREl5bGxSQ3RNVUxBaVF5TW5CR1ZFSzB4UXNDSkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
