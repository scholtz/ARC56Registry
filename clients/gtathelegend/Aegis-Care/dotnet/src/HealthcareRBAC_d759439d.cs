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

namespace Arc56.Generated.gtathelegend.Aegis_Care.HealthcareRBAC_d759439d
{


    public class HealthcareRBACProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HealthcareRBACProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class RoleAssignedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 145, 155, 207, 28 };
                public const string Signature = "RoleAssigned(address,uint8)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public byte Field2 { get; set; }

                public static RoleAssignedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleAssignedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class RoleUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 159, 173, 44, 210 };
                public const string Signature = "RoleUpdated(address,uint8)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public byte Field2 { get; set; }

                public static RoleUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RoleUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Only the initial admin or existing admins can add new admins.
        ///</summary>
        /// <param name="new_admin"> </param>
        public async Task AddAdmin(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 70, 132, 54 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            var result = await base.CallApp(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddAdmin_Transactions(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 70, 132, 54 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns True if the wallet is an admin.
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<bool> IsAdmin(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 115, 245, 252 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsAdmin_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 115, 245, 252 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admins can register any role. Hospitals(bit 1) can register Doctors(bit 2) and Labs(bit 4).
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="role"> </param>
        public async Task RegisterRole(Algorand.Address user, byte role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 245, 39, 113 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); roleAbi.From(role);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterRole_Transactions(Algorand.Address user, byte role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 245, 39, 113 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); roleAbi.From(role);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Only admins can arbitrarily update a role for a user.
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="role"> </param>
        public async Task UpdateRole(Algorand.Address user, byte role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 118, 107, 144 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); roleAbi.From(role);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRole_Transactions(Algorand.Address user, byte role, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 118, 107, 144 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); roleAbi.From(role);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, roleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the role bitmask of a wallet (0 if not set).
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<byte> GetRole(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 221, 95, 223 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> GetRole_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 221, 95, 223 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGVhbHRoY2FyZVJCQUMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYWRkX2FkbWluIiwiZGVzYyI6Ik9ubHkgdGhlIGluaXRpYWwgYWRtaW4gb3IgZXhpc3RpbmcgYWRtaW5zIGNhbiBhZGQgbmV3IGFkbWlucy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19hZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19hZG1pbiIsImRlc2MiOiJSZXR1cm5zIFRydWUgaWYgdGhlIHdhbGxldCBpcyBhbiBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX3JvbGUiLCJkZXNjIjoiQWRtaW5zIGNhbiByZWdpc3RlciBhbnkgcm9sZS4gSG9zcGl0YWxzKGJpdCAxKSBjYW4gcmVnaXN0ZXIgRG9jdG9ycyhiaXQgMikgYW5kIExhYnMoYml0IDQpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSb2xlQXNzaWduZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3JvbGUiLCJkZXNjIjoiT25seSBhZG1pbnMgY2FuIGFyYml0cmFyaWx5IHVwZGF0ZSBhIHJvbGUgZm9yIGEgdXNlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JvbGUiLCJkZXNjIjoiUmV0dXJucyB0aGUgcm9sZSBiaXRtYXNrIG9mIGEgd2FsbGV0ICgwIGlmIG5vdCBzZXQpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjQzLDI5Ml0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgcm9sZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwM10sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzOF0sImVycm9yTWVzc2FnZSI6IlVuYXV0aG9yaXplZCB0byBhc3NpZ24gdGhpcyByb2xlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pbml0aWFsX2FkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucm9sZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4LDE2NiwxODYsMjc4LDMxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQsMjg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURNeUlEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZzNNalptTm1NMk5UVm1JQ0pwYm1sMFgyRmtiV2x1SWlBd2VEWXhOalEyWkRWbUlEQjRPREFnTUhneE5URm1OMk0zTlFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QnpaV3htTG1sdWFYUnBZV3hmWVdSdGFXNHVkbUZzZFdVZ1BTQmhaRzFwYmw5aFpHUnlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBibWwwWDJGa2JXbHVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qSXhMVEl5Q2lBZ0lDQXZMeUFqSUVoaGNtUmpiMlJsWkNCQlpHMXBiam9nV2tJMFJrdEJWa3BWTmtVelFVNVVRMU5RVUVFMVVGTlRTVUV6TlZoVlZVRTBUekpIUVZORVMxcFdSRXhWVGxvMFJFMVFURmxLVFZaTFRRb2dJQ0FnTHk4Z1lXUnRhVzVmWVdSa2NpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3lnaVdrSTBSa3RCVmtwVk5rVXpRVTVVUTFOUVVFRTFVRk5UU1VFek5WaFZWVUUwVHpKSFFWTkVTMXBXUkV4VlRsbzBSRTFRVEZsS1RWWkxUU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdZbUZ6WlRNeUtGcENORVpMUVZaS1ZUWkZNMEZPVkVOVFVGQkJOVkJUVTBsQk16VllWVlZCTkU4eVIwRlRSRXRhVmtSTVZVNWFORVJOVUVFcElDOHZJR0ZrWkhJZ1drSTBSa3RCVmtwVk5rVXpRVTVVUTFOUVVFRTFVRk5UU1VFek5WaFZWVUUwVHpKSFFWTkVTMXBXUkV4VlRsbzBSRTFRVEZsS1RWWkxUUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QnpaV3htTG1sdWFYUnBZV3hmWVdSdGFXNHVkbUZzZFdVZ1BTQmhaRzFwYmw5aFpHUnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12U0dWaGJIUm9ZMkZ5WlZKQ1FVTXZZMjl1ZEhKaFkzUXVjSGs2TVRnS0lDQWdJQzh2SUdOc1lYTnpJRWhsWVd4MGFHTmhjbVZTUWtGREtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1EVTBOamcwTXpZZ01IZzRNVGN6WmpWbVl5QXdlRFF6WmpVeU56Y3hJREI0WkdVM05qWmlPVEFnTUhneE4yUmtOV1prWmlBdkx5QnRaWFJvYjJRZ0ltRmtaRjloWkcxcGJpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1selgyRmtiV2x1S0dGa1pISmxjM01wWW05dmJDSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZjbTlzWlNoaFpHUnlaWE56TEhWcGJuUTRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlY5eWIyeGxLR0ZrWkhKbGMzTXNkV2x1ZERncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzSnZiR1VvWVdSa2NtVnpjeWwxYVc1ME9DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR0ZrWkY5aFpHMXBiaUJwYzE5aFpHMXBiaUJ5WldkcGMzUmxjbDl5YjJ4bElIVndaR0YwWlY5eWIyeGxJR2RsZEY5eWIyeGxDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRRNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVJWldGc2RHaGpZWEpsVWtKQlF5NWpiMjUwY21GamRDNUlaV0ZzZEdoallYSmxVa0pCUXk1aFpHUmZZV1J0YVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhaR1JmWVdSdGFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk16TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZTR1ZoYkhSb1kyRnlaVkpDUVVNdlkyOXVkSEpoWTNRdWNIazZNellLSUNBZ0lDOHZJSE5sYkdZdVgyOXViSGxmWVdSdGFXNG9LUW9nSUNBZ1kyRnNiSE4xWWlCZmIyNXNlVjloWkcxcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBobFlXeDBhR05oY21WU1FrRkRMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCelpXeG1MbUZrYldsdWMxdHVaWGRmWVdSdGFXNWRJRDBnWVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROakUyTkRaa05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGd3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12U0dWaGJIUm9ZMkZ5WlZKQ1FVTXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1SVpXRnNkR2hqWVhKbFVrSkJReTVqYjI1MGNtRmpkQzVJWldGc2RHaGpZWEpsVWtKQlF5NXBjMTloWkcxcGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx6WDJGa2JXbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qTTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE11U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVZMjl1ZEhKaFkzUXVTR1ZoYkhSb1kyRnlaVkpDUVVNdWFYTmZZV1J0YVc0S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVTR1ZoYkhSb1kyRnlaVkpDUVVNdVkyOXVkSEpoWTNRdVNHVmhiSFJvWTJGeVpWSkNRVU11Y21WbmFYTjBaWEpmY205c1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWjJsemRHVnlYM0p2YkdVNkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlJWldGc2RHaGpZWEpsVWtKQlF5OWpiMjUwY21GamRDNXdlVG8wT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QmpZV3hzWlhKZmNtOXNaU0E5SUhObGJHWXVaMlYwWDNKdmJHVW9ZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVNHVmhiSFJvWTJGeVpWSkNRVU11WTI5dWRISmhZM1F1U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVaMlYwWDNKdmJHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z1kyRnNiR1Z5WDJselgyRmtiV2x1SUQwZ2MyVnNaaTVwYzE5aFpHMXBiaWhoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJSE50WVhKMFgyTnZiblJ5WVdOMGN5NUlaV0ZzZEdoallYSmxVa0pCUXk1amIyNTBjbUZqZEM1SVpXRnNkR2hqWVhKbFVrSkJReTVwYzE5aFpHMXBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QjJZV3hwWkY5allXeHNaWElnUFNCallXeHNaWEpmYVhOZllXUnRhVzR1Ym1GMGFYWmxJRzl5SUNnS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlJWldGc2RHaGpZWEpsVWtKQlF5OWpiMjUwY21GamRDNXdlVG8xTkMwMU5nb2dJQ0FnTHk4Z2RtRnNhV1JmWTJGc2JHVnlJRDBnWTJGc2JHVnlYMmx6WDJGa2JXbHVMbTVoZEdsMlpTQnZjaUFvQ2lBZ0lDQXZMeUFnSUNBZ0tHTmhiR3hsY2w5eWIyeGxMbTVoZEdsMlpTQW1JREVwSUNFOUlEQWdZVzVrSUNoeWIyeGxMbTVoZEdsMlpTQTlQU0F5SUc5eUlISnZiR1V1Ym1GMGFYWmxJRDA5SURRcENpQWdJQ0F2THlBcENpQWdJQ0JpYm5vZ2NtVm5hWE4wWlhKZmNtOXNaVjlpYjI5c1gzUnlkV1ZBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUFvWTJGc2JHVnlYM0p2YkdVdWJtRjBhWFpsSUNZZ01Ta2dJVDBnTUNCaGJtUWdLSEp2YkdVdWJtRjBhWFpsSUQwOUlESWdiM0lnY205c1pTNXVZWFJwZG1VZ1BUMGdOQ2tLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNZS0lDQWdJR0o2SUhKbFoybHpkR1Z5WDNKdmJHVmZZbTl2YkY5bVlXeHpaVUEyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURVS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaV2RwYzNSbGNsOXliMnhsWDJKdmIyeGZkSEoxWlVBMUNpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQTlQUW9nSUNBZ1lub2djbVZuYVhOMFpYSmZjbTlzWlY5aWIyOXNYMlpoYkhObFFEWUtDbkpsWjJsemRHVnlYM0p2YkdWZlltOXZiRjkwY25WbFFEVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0tjbVZuYVhOMFpYSmZjbTlzWlY5aWIyOXNYMjFsY21kbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCMllXeHBaRjlqWVd4c1pYSXNJQ0pWYm1GMWRHaHZjbWw2WldRZ2RHOGdZWE56YVdkdUlIUm9hWE1nY205c1pTSUtJQ0FnSUdGemMyVnlkQ0F2THlCVmJtRjFkR2h2Y21sNlpXUWdkRzhnWVhOemFXZHVJSFJvYVhNZ2NtOXNaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QmhjM05sY25RZ2NtOXNaUzV1WVhScGRtVWdQaUF3TENBaVNXNTJZV3hwWkNCeWIyeGxJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ2NtOXNaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QnpaV3htTG5KdmJHVnpXM1Z6WlhKZElEMGdjbTlzWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURjeU5tWTJZelkxTldZS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlJWldGc2RHaGpZWEpsVWtKQlF5OWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKU2IyeGxRWE56YVdkdVpXUW9ZV1JrY21WemN5eDFhVzUwT0NraUxDQjFjMlZ5TENCeWIyeGxLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc1TVRsaVkyWXhZeUF2THlCdFpYUm9iMlFnSWxKdmJHVkJjM05wWjI1bFpDaGhaR1J5WlhOekxIVnBiblE0S1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12U0dWaGJIUm9ZMkZ5WlZKQ1FVTXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WbmFYTjBaWEpmY205c1pWOWliMjlzWDJaaGJITmxRRFk2Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQnlaV2RwYzNSbGNsOXliMnhsWDJKdmIyeGZiV1Z5WjJWQU53b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVJWldGc2RHaGpZWEpsVWtKQlF5NWpiMjUwY21GamRDNUlaV0ZzZEdoallYSmxVa0pCUXk1MWNHUmhkR1ZmY205c1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpWOXliMnhsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklITmxiR1l1WDI5dWJIbGZZV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJmYjI1c2VWOWhaRzFwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbTlzWlM1dVlYUnBkbVVnUGlBd0xDQWlTVzUyWVd4cFpDQnliMnhsSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQnliMnhsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZTR1ZoYkhSb1kyRnlaVkpDUVVNdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJSE5sYkdZdWNtOXNaWE5iZFhObGNsMGdQU0J5YjJ4bENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56STJaalpqTmpVMVpnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlJWldGc2RHaGpZWEpsVWtKQlF5OWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKU2IyeGxWWEJrWVhSbFpDaGhaR1J5WlhOekxIVnBiblE0S1NJc0lIVnpaWElzSUhKdmJHVXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGxtWVdReVkyUXlJQzh2SUcxbGRHaHZaQ0FpVW05c1pWVndaR0YwWldRb1lXUmtjbVZ6Y3l4MWFXNTBPQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVZMjl1ZEhKaFkzUXVTR1ZoYkhSb1kyRnlaVkpDUVVNdVoyVjBYM0p2YkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmY205c1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvM01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa2hsWVd4MGFHTmhjbVZTUWtGRExtTnZiblJ5WVdOMExraGxZV3gwYUdOaGNtVlNRa0ZETG1kbGRGOXliMnhsQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxraGxZV3gwYUdOaGNtVlNRa0ZETG1OdmJuUnlZV04wTGtobFlXeDBhR05oY21WU1FrRkRMbWx6WDJGa2JXbHVLSGRoYkd4bGREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdVNHVmhiSFJvWTJGeVpWSkNRVU11WTI5dWRISmhZM1F1U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVhWE5mWVdSdGFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk16a3ROREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHbHpYMkZrYldsdUtITmxiR1lzSUhkaGJHeGxkRG9nWVhKak5DNUJaR1J5WlhOektTQXRQaUJoY21NMExrSnZiMnc2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12U0dWaGJIUm9ZMkZ5WlZKQ1FVTXZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUdsbUlIZGhiR3hsZENBOVBTQnpaV3htTG1sdWFYUnBZV3hmWVdSdGFXNHVkbUZzZFdVNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1sdWFYUmZZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhVzVwZEdsaGJGOWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdKNklITnRZWEowWDJOdmJuUnlZV04wY3k1SVpXRnNkR2hqWVhKbFVrSkJReTVqYjI1MGNtRmpkQzVJWldGc2RHaGpZWEpsVWtKQlF5NXBjMTloWkcxcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlJWldGc2RHaGpZWEpsVWtKQlF5OWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hVY25WbEtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEZ3dDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ25OdFlYSjBYMk52Ym5SeVlXTjBjeTVJWldGc2RHaGpZWEpsVWtKQlF5NWpiMjUwY21GamRDNUlaV0ZzZEdoallYSmxVa0pCUXk1cGMxOWhaRzFwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZTR1ZoYkhSb1kyRnlaVkpDUVVNdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJR2xtSUhkaGJHeGxkQ0JwYmlCelpXeG1MbUZrYldsdWN6b0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzJNVFkwTm1RMVpnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NUlaV0ZzZEdoallYSmxVa0pCUXk1amIyNTBjbUZqZEM1SVpXRnNkR2hqWVhKbFVrSkJReTVwYzE5aFpHMXBibDloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZV1J0YVc1elczZGhiR3hsZEYwS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBibk1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbk50WVhKMFgyTnZiblJ5WVdOMGN5NUlaV0ZzZEdoallYSmxVa0pCUXk1amIyNTBjbUZqZEM1SVpXRnNkR2hqWVhKbFVrSkJReTVwYzE5aFpHMXBibDloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa2hsWVd4MGFHTmhjbVZTUWtGRExtTnZiblJ5WVdOMExraGxZV3gwYUdOaGNtVlNRa0ZETG1kbGRGOXliMnhsS0hkaGJHeGxkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3B6YldGeWRGOWpiMjUwY21GamRITXVTR1ZoYkhSb1kyRnlaVkpDUVVNdVkyOXVkSEpoWTNRdVNHVmhiSFJvWTJGeVpWSkNRVU11WjJWMFgzSnZiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZTR1ZoYkhSb1kyRnlaVkpDUVVNdlkyOXVkSEpoWTNRdWNIazZOekl0TnpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5eWIyeGxLSE5sYkdZc0lIZGhiR3hsZERvZ1lYSmpOQzVCWkdSeVpYTnpLU0F0UGlCaGNtTTBMbFZKYm5RNE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZTR1ZoYkhSb1kyRnlaVkpDUVVNdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJR2xtSUhkaGJHeGxkQ0JwYmlCelpXeG1Mbkp2YkdWek9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEY3lObVkyWXpZMU5XWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa2hsWVd4MGFHTmhjbVZTUWtGRExtTnZiblJ5WVdOMExraGxZV3gwYUdOaGNtVlNRa0ZETG1kbGRGOXliMnhsWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV5YjJ4bGMxdDNZV3hzWlhSZENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtOXNaWE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbk50WVhKMFgyTnZiblJ5WVdOMGN5NUlaV0ZzZEdoallYSmxVa0pCUXk1amIyNTBjbUZqZEM1SVpXRnNkR2hqWVhKbFVrSkJReTVuWlhSZmNtOXNaVjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RNEtEQXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxraGxZV3gwYUdOaGNtVlNRa0ZETG1OdmJuUnlZV04wTGtobFlXeDBhR05oY21WU1FrRkRMbDl2Ym14NVgyRmtiV2x1S0NrZ0xUNGdkbTlwWkRvS1gyOXViSGxmWVdSdGFXNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklHTmhiR3hsY2lBOUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVwYzE5aFpHMXBiaWhqWVd4c1pYSXBMbTVoZEdsMlpTd2dJazl1YkhrZ1lXUnRhVzRnWVd4c2IzZGxaQ0lLSUNBZ0lHTmhiR3h6ZFdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TGtobFlXeDBhR05oY21WU1FrRkRMbU52Ym5SeVlXTjBMa2hsWVd4MGFHTmhjbVZTUWtGRExtbHpYMkZrYldsdUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmhaRzFwYmlCaGJHeHZkMlZrQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBU0FBSmdVRmNtOXNaVjhLYVc1cGRGOWhaRzFwYmdSaFpHMWZBWUFFRlI5OGRURVlRQUFrS1lBZ3lIaFZBcW1uaWJBMllwUGVEcjVTUURmYjBvRGp0R0JJYXMxR3VqYzhHeDVuTVJ0QkFESXhHUlJFTVJoRWdnVUVCVWFFTmdTQmMvWDhCRVAxSjNFRTNuWnJrQVFYM1YvZk5ob0FqZ1VBQ1FBYkFDMEFpd0MwQURFWkZERVlGQkJETmhvQlNSVWpFa1NJQVBRcVRGQXJ2eUpETmhvQlNSVWpFa1NJQUtBbkJFeFFzQ0pEZ0FBMkdnRkpGU01TUkRZYUFra1ZJaEpFTVFDSUFLc3hBSWdBZlNSVFFBQWJTUmNpR2tFQU1rc0JGMGxGQllFQ0VrQUFDRXNEZ1FRU1FRQWVJa1JMQVVrWFJDaExCRWxPQWxCTEFyOU1VSUFFa1p2UEhFeFFzQ0pESkVMLzN6WWFBVWtWSXhKRU5ob0NTUlVpRWtTSUFHcEpGMFFvU3dKUVN3Ry9VSUFFbjYwczBreFFzQ0pETmhvQlNSVWpFa1NJQURBbkJFeFFzQ0pEaWdFQkpFa3BaVVNML3hKQkFBTXJUSWtxaS85UVNZd0F2VVVCUVFBR2l3QytSRXlKZ0FFQVRJbUtBUUVvaS85UVNiMUZBVUVBQm9zQXZrUk1pWUFCQUV5Sk1RQ0kvN2trVTBTSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlJvbGVBc3NpZ25lZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
