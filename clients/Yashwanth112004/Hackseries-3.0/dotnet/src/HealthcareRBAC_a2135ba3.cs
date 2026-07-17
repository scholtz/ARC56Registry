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

namespace Arc56.Generated.Yashwanth112004.Hackseries_3_0.HealthcareRBAC_a2135ba3
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
        ///Only existing admins can add new admins.
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
        ///Only admins can register a role for a user.
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
        ///Only admins can update a role for a user.
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
        ///Returns the role of a wallet (0 if not set).
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGVhbHRoY2FyZVJCQUMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYWRkX2FkbWluIiwiZGVzYyI6Ik9ubHkgZXhpc3RpbmcgYWRtaW5zIGNhbiBhZGQgbmV3IGFkbWlucy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19hZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19hZG1pbiIsImRlc2MiOiJSZXR1cm5zIFRydWUgaWYgdGhlIHdhbGxldCBpcyBhbiBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX3JvbGUiLCJkZXNjIjoiT25seSBhZG1pbnMgY2FuIHJlZ2lzdGVyIGEgcm9sZSBmb3IgYSB1c2VyLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSb2xlQXNzaWduZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3JvbGUiLCJkZXNjIjoiT25seSBhZG1pbnMgY2FuIHVwZGF0ZSBhIHJvbGUgZm9yIGEgdXNlci4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUm9sZVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JvbGUiLCJkZXNjIjoiUmV0dXJucyB0aGUgcm9sZSBvZiBhIHdhbGxldCAoMCBpZiBub3Qgc2V0KS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI5OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gYWxsb3dlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MywyOTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWlucyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJvbGVzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMiwxNDAsMTczLDIxMSwyNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgxLDIxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElETXlJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGcyTVRZME5tUTFaaUF3ZURjeU5tWTJZelkxTldZZ01IZzRNQ0F3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklITmxiR1l1YVc1cGRHbGhiRjloWkcxcGJpNTJZV3gxWlNBOUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pwYm1sMFgyRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUb3lOUzB5TmdvZ0lDQWdMeThnSXlCVFpYUWdaR1Z3Ykc5NVpYSWdZWE1nWVdSdGFXNEtJQ0FnSUM4dklITmxiR1l1WVdSdGFXNXpXMkZ5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtWMGdQU0JoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkwTm1RMVpnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE9EQUtJQ0FnSUdKdmVGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBobFlXeDBhR05oY21WU1FrRkRMMk52Ym5SeVlXTjBMbkI1T2pFeUNpQWdJQ0F2THlCamJHRnpjeUJJWldGc2RHaGpZWEpsVWtKQlF5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQTFORFk0TkRNMklEQjRPREUzTTJZMVptTWdNSGcwTTJZMU1qYzNNU0F3ZUdSbE56WTJZamt3SURCNE1UZGtaRFZtWkdZZ0x5OGdiV1YwYUc5a0lDSmhaR1JmWVdSdGFXNG9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGMxOWhaRzFwYmloaFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbkpsWjJsemRHVnlYM0p2YkdVb1lXUmtjbVZ6Y3l4MWFXNTBPQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWZmNtOXNaU2hoWkdSeVpYTnpMSFZwYm5RNEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXliMnhsS0dGa1pISmxjM01wZFdsdWREZ2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JoWkdSZllXUnRhVzRnYVhOZllXUnRhVzRnY21WbmFYTjBaWEpmY205c1pTQjFjR1JoZEdWZmNtOXNaU0JuWlhSZmNtOXNaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFME9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVZMjl1ZEhKaFkzUXVTR1ZoYkhSb1kyRnlaVkpDUVVNdVlXUmtYMkZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV1JrWDJGa2JXbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJ6Wld4bUxsOXZibXg1WDJGa2JXbHVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyOXViSGxmWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvek1nb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJuTmJibVYzWDJGa2JXbHVYU0E5SUdGeVl6UXVRbTl2YkNoVWNuVmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TmpRMlpEVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGc0TUFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBobFlXeDBhR05oY21WU1FrRkRMMk52Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVNHVmhiSFJvWTJGeVpWSkNRVU11WTI5dWRISmhZM1F1U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVhWE5mWVdSdGFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzE5aFpHMXBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdhV1lnZDJGc2JHVjBJR2x1SUhObGJHWXVZV1J0YVc1ek9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXhOalEyWkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJwYzE5aFpHMXBibDloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvek9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZV1J0YVc1elczZGhiR3hsZEYwS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzV6SUdWdWRISjVJR1Y0YVhOMGN3b0thWE5mWVdSdGFXNWZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVZMjl1ZEhKaFkzUXVTR1ZoYkhSb1kyRnlaVkpDUVVNdWFYTmZZV1J0YVc1QU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BwYzE5aFpHMXBibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnYVhOZllXUnRhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVNHVmhiSFJvWTJGeVpWSkNRVU11WTI5dWRISmhZM1F1U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVhWE5mWVdSdGFXNUFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1SVpXRnNkR2hqWVhKbFVrSkJReTVqYjI1MGNtRmpkQzVJWldGc2RHaGpZWEpsVWtKQlF5NXlaV2RwYzNSbGNsOXliMnhsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm5hWE4wWlhKZmNtOXNaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBobFlXeDBhR05oY21WU1FrRkRMMk52Ym5SeVlXTjBMbkI1T2pRMENpQWdJQ0F2THlCelpXeG1MbDl2Ym14NVgyRmtiV2x1S0NrS0lDQWdJR05oYkd4emRXSWdYMjl1YkhsZllXUnRhVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdjMlZzWmk1eWIyeGxjMXQxYzJWeVhTQTlJSEp2YkdVS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnM01qWm1ObU0yTlRWbUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvSWxKdmJHVkJjM05wWjI1bFpDaGhaR1J5WlhOekxIVnBiblE0S1NJc0lIVnpaWElzSUhKdmJHVXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGt4T1dKalpqRmpJQzh2SUcxbGRHaHZaQ0FpVW05c1pVRnpjMmxuYm1Wa0tHRmtaSEpsYzNNc2RXbHVkRGdwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlJWldGc2RHaGpZWEpsVWtKQlF5OWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGtobFlXeDBhR05oY21WU1FrRkRMbU52Ym5SeVlXTjBMa2hsWVd4MGFHTmhjbVZTUWtGRExuVndaR0YwWlY5eWIyeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYM0p2YkdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12U0dWaGJIUm9ZMkZ5WlZKQ1FVTXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdjMlZzWmk1ZmIyNXNlVjloWkcxcGJpZ3BDaUFnSUNCallXeHNjM1ZpSUY5dmJteDVYMkZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12U0dWaGJIUm9ZMkZ5WlZKQ1FVTXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUhObGJHWXVjbTlzWlhOYmRYTmxjbDBnUFNCeWIyeGxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROekkyWmpaak5qVTFaZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtDSlNiMnhsVlhCa1lYUmxaQ2hoWkdSeVpYTnpMSFZwYm5RNEtTSXNJSFZ6WlhJc0lISnZiR1VwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURsbVlXUXlZMlF5SUM4dklHMWxkR2h2WkNBaVVtOXNaVlZ3WkdGMFpXUW9ZV1JrY21WemN5eDFhVzUwT0NraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBobFlXeDBhR05oY21WU1FrRkRMMk52Ym5SeVlXTjBMbkI1T2pRNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVNHVmhiSFJvWTJGeVpWSkNRVU11WTI5dWRISmhZM1F1U0dWaGJIUm9ZMkZ5WlZKQ1FVTXVaMlYwWDNKdmJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNtOXNaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdhV1lnZDJGc2JHVjBJR2x1SUhObGJHWXVjbTlzWlhNNkNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE56STJaalpqTmpVMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWjJWMFgzSnZiR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1Mbkp2YkdWelczZGhiR3hsZEYwS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtOXNaWE1nWlc1MGNua2daWGhwYzNSekNncG5aWFJmY205c1pWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVJWldGc2RHaGpZWEpsVWtKQlF5NWpiMjUwY21GamRDNUlaV0ZzZEdoallYSmxVa0pCUXk1blpYUmZjbTlzWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBobFlXeDBhR05oY21WU1FrRkRMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5eWIyeGxYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5SVpXRnNkR2hqWVhKbFVrSkJReTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERnb01Da0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlNHVmhiSFJvWTJGeVpWSkNRVU12WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lpQm5aWFJmY205c1pWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVJWldGc2RHaGpZWEpsVWtKQlF5NWpiMjUwY21GamRDNUlaV0ZzZEdoallYSmxVa0pCUXk1blpYUmZjbTlzWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa2hsWVd4MGFHTmhjbVZTUWtGRExtTnZiblJ5WVdOMExraGxZV3gwYUdOaGNtVlNRa0ZETGw5dmJteDVYMkZrYldsdUtDa2dMVDRnZG05cFpEb0tYMjl1YkhsZllXUnRhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZTR1ZoYkhSb1kyRnlaVkpDUVVNdlkyOXVkSEpoWTNRdWNIazZOakl0TmpNS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYMjl1YkhsZllXUnRhVzRvYzJWc1ppa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREFnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMGhsWVd4MGFHTmhjbVZTUWtGREwyTnZiblJ5WVdOMExuQjVPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZMkZzYkdWeUlHbHVJSE5sYkdZdVlXUnRhVzV6SUdGdVpDQnpaV3htTG1Ga2JXbHVjMXRqWVd4c1pYSmRMbTVoZEdsMlpTd2dJazl1YkhrZ1lXUnRhVzRnWVd4c2IzZGxaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTVRZME5tUTFaZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwaGxZV3gwYUdOaGNtVlNRa0ZETDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QmpZV3hzWlhJZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUlaV0ZzZEdoallYSmxVa0pCUXk5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdZWE56WlhKMElHTmhiR3hsY2lCcGJpQnpaV3htTG1Ga2JXbHVjeUJoYm1RZ2MyVnNaaTVoWkcxcGJuTmJZMkZzYkdWeVhTNXVZWFJwZG1Vc0lDSlBibXg1SUdGa2JXbHVJR0ZzYkc5M1pXUWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCZmIyNXNlVjloWkcxcGJsOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJuTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllaUJmYjI1c2VWOWhaRzFwYmw5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENncGZiMjVzZVY5aFpHMXBibDlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12U0dWaGJIUm9ZMkZ5WlZKQ1FVTXZZMjl1ZEhKaFkzUXVjSGs2TmpZS0lDQWdJQzh2SUdGemMyVnlkQ0JqWVd4c1pYSWdhVzRnYzJWc1ppNWhaRzFwYm5NZ1lXNWtJSE5sYkdZdVlXUnRhVzV6VzJOaGJHeGxjbDB1Ym1GMGFYWmxMQ0FpVDI1c2VTQmhaRzFwYmlCaGJHeHZkMlZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRnWVd4c2IzZGxaQW9nSUNBZ2NtVjBjM1ZpQ2dwZmIyNXNlVjloWkcxcGJsOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lpQmZiMjVzZVY5aFpHMXBibDlpYjI5c1gyMWxjbWRsUURRSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBU0FBSmdRRVlXUnRYd1Z5YjJ4bFh3R0FCQlVmZkhVeEdFQUFGWUFLYVc1cGRGOWhaRzFwYmpFQVp5Z3hBRkFxdnpFYlFRQXlNUmtVUkRFWVJJSUZCQVZHaERZRWdYUDEvQVJEOVNkeEJONTJhNUFFRjkxZjN6WWFBSTRGQUFrQUd3QThBR0lBaUFBeEdSUXhHQlFRUXpZYUFVa1ZJeEpFaUFDVktFeFFLcjhpUXpZYUFVa1ZJeEpFS0V4UVNiMUZBVUVBQ1VtK1JDdE1VTEFpUTRBQkFFTC85RFlhQVVrVkl4SkVOaG9DU1JVaUVrU0lBRm9wU3dKUVN3Ry9VSUFFa1p2UEhFeFFzQ0pETmhvQlNSVWpFa1EyR2dKSkZTSVNSSWdBTkNsTEFsQkxBYjlRZ0FTZnJTelNURkN3SWtNMkdnRkpGU01TUkNsTVVFbTlSUUZCQUFsSnZrUXJURkN3SWtPQUFRQkMvL1NLQUFBb01RQlFTYjFGQVVFQURJc0F2a1FrVTBFQUF5SkVpU1JDLy9vPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlJvbGVBc3NpZ25lZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJvbGVVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
