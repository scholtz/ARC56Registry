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

namespace Arc56.Generated.algorandfoundation.algokit_subscriber_py.testing_app_4bf00bef
{


    public class TestingAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestingAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class SwappedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 28, 203, 217, 37 };
                public const string Signature = "Swapped(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static SwappedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SwappedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class ComplexEvent
            {
                public static readonly byte[] Selector = new byte[4] { 24, 218, 94, 167 };
                public const string Signature = "Complex(uint32[],uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public uint[] Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static ComplexEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ComplexEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is uint[] vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task<string> CallAbi(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 126, 128, 165 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.SimApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallAbi_Transactions(string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 126, 128, 165 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> CallAbiForeignRefs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 117, 96, 44 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CallAbiForeignRefs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 117, 96, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="int1"> </param>
        /// <param name="int2"> </param>
        /// <param name="bytes1"> </param>
        /// <param name="bytes2"> </param>
        public async Task SetGlobal(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 207, 141, 234 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            var result = await base.CallApp(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetGlobal_Transactions(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 207, 141, 234 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            return await base.MakeTransactionList(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="int1"> </param>
        /// <param name="int2"> </param>
        /// <param name="bytes1"> </param>
        /// <param name="bytes2"> </param>
        public async Task SetLocal(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 194, 131, 74 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            var result = await base.CallApp(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLocal_Transactions(ulong int1, ulong int2, string bytes1, byte[] bytes2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 194, 131, 74 };
            var int1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int1Abi.From(int1);
            var int2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); int2Abi.From(int2);
            var bytes1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bytes1Abi.From(bytes1);
            var bytes2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); bytes2Abi.From(bytes2);

            return await base.MakeTransactionList(new List<object> { abiHandle, int1Abi, int2Abi, bytes1Abi, bytes2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task IssueTransferToSender(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 190, 34, 25 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IssueTransferToSender_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 190, 34, 25 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="value"> </param>
        public async Task SetBox(byte[] name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 180, 162, 48 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBox_Transactions(byte[] name, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 180, 162, 48 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); nameAbi.From(name);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Error(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 208, 218, 13 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Error_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 208, 218, 13 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task EmitSwapped(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 60, 238, 93 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmitSwapped_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 60, 238, 93 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task EmitSwappedTwice(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 176, 151, 90 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmitSwappedTwice_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 176, 151, 90 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="array"> </param>
        public async Task EmitComplex(ulong a, ulong b, uint[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 35, 13, 12 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt32>("uint32"); arrayAbi.From(array);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmitComplex_Transactions(ulong a, ulong b, uint[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 35, 13, 12 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt32>("uint32"); arrayAbi.From(array);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdGluZ0FwcCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcHRfaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGxfYWJpIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxsX2FiaV9mb3JlaWduX3JlZnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9nbG9iYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50MiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnl0ZXMyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9sb2NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnQyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJieXRlczIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNzdWVfdHJhbnNmZXJfdG9fc2VuZGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlcnJvciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtaXRTd2FwcGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN3YXBwZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW1pdFN3YXBwZWRUd2ljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTd2FwcGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtaXRDb21wbGV4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQzMltdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN3YXBwZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDb21wbGV4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQzMltdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjJ9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCIsIk9wdEluIl0sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iLCJVcGRhdGVBcHBsaWNhdGlvbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3NF0sImVycm9yTWVzc2FnZSI6IkRlbGliZXJhdGUgZXJyb3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMsMTM0LDE1MiwxNzAsMTc4LDE5NiwyMTEsMjQwLDI2OSwyOTNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE9wdEluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE2LDEzNywxNTUsMTczLDE4MSwxOTksMjE0LDI0MywyNzIsMjk2LDMyNywzNTEsMzU5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Nl0sImVycm9yTWVzc2FnZSI6InVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCamIyNTBjbUZqZEM1MFpYTjBhVzVuWDJGd2NDNWpiMjUwY21GamRDNVVaWE4wYVc1blFYQndMbDlmWVd4bmIzQjVYMlZ1ZEhKNWNHOXBiblJmZDJsMGFGOXBibWwwS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUNBeE1Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERmpZMkprT1RJMUlEQjRNVFV4Wmpkak56VWdJaUlLSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRXhDaUFnSUNBdkx5QmpiR0Z6Y3lCVVpYTjBhVzVuUVhCd0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRZS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnek1HTTJaRFU0WVNBd2VHWXhOMlU0TUdFMUlEQjRZV1EzTlRZd01tTWdNSGhoTkdObU9HUmxZU0F3ZUdObFl6STRNelJoSURCNE9UaGlaVEl5TVRrZ01IaGhOR0kwWVRJek1DQXdlRFEwWkRCa1lUQmtJREI0WkRRelkyVmxOV1FnTUhneE1XSXdPVGMxWVNBd2VHRmtNak13WkRCaklDOHZJRzFsZEdodlpDQWliM0IwWDJsdUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKallXeHNYMkZpYVNoemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pqWVd4c1gyRmlhVjltYjNKbGFXZHVYM0psWm5Nb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMyVjBYMmRzYjJKaGJDaDFhVzUwTmpRc2RXbHVkRFkwTEhOMGNtbHVaeXhpZVhSbFd6UmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjlzYjJOaGJDaDFhVzUwTmpRc2RXbHVkRFkwTEhOMGNtbHVaeXhpZVhSbFd6UmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHpjM1ZsWDNSeVlXNXpabVZ5WDNSdlgzTmxibVJsY2loMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJKdmVDaGllWFJsV3pSZExITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0psY25KdmNpZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVpXMXBkRk4zWVhCd1pXUW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0psYldsMFUzZGhjSEJsWkZSM2FXTmxLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWlcxcGRFTnZiWEJzWlhnb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME16SmJYU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5dmNIUmZhVzVmY205MWRHVkFOU0J0WVdsdVgyTmhiR3hmWVdKcFgzSnZkWFJsUURZZ2JXRnBibDlqWVd4c1gyRmlhVjltYjNKbGFXZHVYM0psWm5OZmNtOTFkR1ZBTnlCdFlXbHVYM05sZEY5bmJHOWlZV3hmY205MWRHVkFPQ0J0WVdsdVgzTmxkRjlzYjJOaGJGOXliM1YwWlVBNUlHMWhhVzVmYVhOemRXVmZkSEpoYm5ObVpYSmZkRzlmYzJWdVpHVnlYM0p2ZFhSbFFERXdJRzFoYVc1ZmMyVjBYMkp2ZUY5eWIzVjBaVUF4TVNCdFlXbHVYMlZ5Y205eVgzSnZkWFJsUURFeUlHMWhhVzVmWlcxcGRGTjNZWEJ3WldSZmNtOTFkR1ZBTVRNZ2JXRnBibDlsYldsMFUzZGhjSEJsWkZSM2FXTmxYM0p2ZFhSbFFERTBJRzFoYVc1ZlpXMXBkRU52YlhCc1pYaGZjbTkxZEdWQU1UVUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TURvS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QlVaWE4wYVc1blFYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJWdGFYUkRiMjF3YkdWNFgzSnZkWFJsUURFMU9nb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk1URUtJQ0FnSUM4dklHTnNZWE56SUZSbGMzUnBibWRCY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRXhOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR1Z0YVhSRGIyMXdiR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlZ0YVhSVGQyRndjR1ZrVkhkcFkyVmZjbTkxZEdWQU1UUTZDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUIwWlhOMGFXNW5YMkZ3Y0M5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZHVnpkR2x1WjBGd2NDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZNVEV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWlcxcGRGTjNZWEJ3WldSVWQybGpaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWxiV2wwVTNkaGNIQmxaRjl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QlVaWE4wYVc1blFYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCbGJXbDBVM2RoY0hCbFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bGNuSnZjbDl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdZWE56WlhKMElFWmhiSE5sTENBaVJHVnNhV0psY21GMFpTQmxjbkp2Y2lJZ0lDTWdibTl4WVRvZ1VGUXdNVFVzSUVJd01URUtJQ0FnSUdWeWNpQXZMeUJFWld4cFltVnlZWFJsSUdWeWNtOXlDZ3B0WVdsdVgzTmxkRjlpYjNoZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG81T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2pFeENpQWdJQ0F2THlCamJHRnpjeUJVWlhOMGFXNW5RWEJ3S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlITmxkRjlpYjNnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVhOemRXVmZkSEpoYm5ObVpYSmZkRzlmYzJWdVpHVnlYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk9UVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUIwWlhOMGFXNW5YMkZ3Y0M5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZHVnpkR2x1WjBGd2NDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZPVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJwYzNOMVpWOTBjbUZ1YzJabGNsOTBiMTl6Wlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBYMnh2WTJGc1gzSnZkWFJsUURrNkNpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG80TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2pFeENpQWdJQ0F2THlCamJHRnpjeUJVWlhOMGFXNW5RWEJ3S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2T0RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCelpYUmZiRzlqWVd3S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzJWMFgyZHNiMkpoYkY5eWIzVjBaVUE0T2dvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZOemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG94TVFvZ0lDQWdMeThnWTJ4aGMzTWdWR1Z6ZEdsdVowRndjQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzJWMFgyZHNiMkpoYkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqWVd4c1gyRmlhVjltYjNKbGFXZHVYM0psWm5OZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmpZV3hzWDJGaWFWOW1iM0psYVdkdVgzSmxabk1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTmhiR3hmWVdKcFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPakV4Q2lBZ0lDQXZMeUJqYkdGemN5QlVaWE4wYVc1blFYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQmpZV3hzWDJGaWFRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYjNCMFgybHVYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpQY0hSSmJpSmRLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTl3ZEVsdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVDNCMFNXNEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UWTZDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRveE1Rb2dJQ0FnTHk4Z1kyeGhjM01nVkdWemRHbHVaMEZ3Y0NoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjM2RwZEdOb0lHMWhhVzVmWTNKbFlYUmxRREUzSUcxaGFXNWZZM0psWVhSbFFERTNJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TUNCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qQWdiV0ZwYmw5MWNHUmhkR1ZBTVRnZ2JXRnBibDlrWld4bGRHVkFNVGtLSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2dwdFlXbHVYMlJsYkdWMFpVQXhPVG9LSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHUmxiR1YwWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxY0dSaGRHVkFNVGc2Q2lBZ0lDQXZMeUIwWlhOMGFXNW5YMkZ3Y0M5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQjFjR1JoZEdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxRREUzT2dvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpd2dZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpTENBaVQzQjBTVzRpWFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUXVkR1Z6ZEdsdVoxOWhjSEF1WTI5dWRISmhZM1F1VkdWemRHbHVaMEZ3Y0M1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncElDMCtJSFp2YVdRNkNtRjFkR2h2Y21sNlpWOWpjbVZoZEc5eU9nb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKMWJtRjFkR2h2Y21sNlpXUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVoZFhSb2IzSnBlbVZrQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJqYjI1MGNtRmpkQzUwWlhOMGFXNW5YMkZ3Y0M1amIyNTBjbUZqZEM1VVpYTjBhVzVuUVhCd0xtbDBiMkVvYVRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2FYUnZZVG9LSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qTTFMVE0yQ2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlFvZ0lDQWdMeThnWkdWbUlHbDBiMkVvYzJWc1ppd2dhVG9nVlVsdWREWTBLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lpSUtJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCcFppQnBJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTU2SUdsMGIyRmZaV3h6WlY5aWIyUjVRRElLSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NJd0lpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaU1DSUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LYVhSdllWOWxiSE5sWDJKdlpIbEFNam9LSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QnlaWFIxY200Z0tITmxiR1l1YVhSdllTaHBJQzh2SUZWSmJuUTJOQ2d4TUNrcElHbG1JQ2hwSUM4dklGVkpiblEyTkNneE1Da3BJRDRnVlVsdWREWTBLREFwSUdWc2MyVWdVM1J5YVc1bktDSWlLU2tnS3lCVGRISnBibWN1Wm5KdmJWOWllWFJsY3lnS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQXZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWW5vZ2FYUnZZVjkwWlhKdVlYSjVYMlpoYkhObFFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqWVd4c2MzVmlJR2wwYjJFS0NtbDBiMkZmZEdWeWJtRnllVjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklGTjBjbWx1WnlnaU1ERXlNelExTmpjNE9TSXBMbUo1ZEdWelcya2dKU0JWU1c1ME5qUW9NVEFwWFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEFLSUNBZ0lDVUtJQ0FnSUhCMWMyaGllWFJsY3lBaU1ERXlNelExTmpjNE9TSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5EQXRORElLSUNBZ0lDOHZJSEpsZEhWeWJpQW9jMlZzWmk1cGRHOWhLR2tnTHk4Z1ZVbHVkRFkwS0RFd0tTa2dhV1lnS0drZ0x5OGdWVWx1ZERZMEtERXdLU2tnUGlCVlNXNTBOalFvTUNrZ1pXeHpaU0JUZEhKcGJtY29JaUlwS1NBcklGTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektBb2dJQ0FnTHk4Z0lDQWdJRk4wY21sdVp5Z2lNREV5TXpRMU5qYzRPU0lwTG1KNWRHVnpXMmtnSlNCVlNXNTBOalFvTVRBcFhRb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21sMGIyRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9nb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUhKbGRIVnliaUFvYzJWc1ppNXBkRzloS0drZ0x5OGdWVWx1ZERZMEtERXdLU2tnYVdZZ0tHa2dMeThnVlVsdWREWTBLREV3S1NrZ1BpQlZTVzUwTmpRb01Da2daV3h6WlNCVGRISnBibWNvSWlJcEtTQXJJRk4wY21sdVp5NW1jbTl0WDJKNWRHVnpLQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlJZ29nSUNBZ1lpQnBkRzloWDNSbGNtNWhjbmxmYldWeVoyVkFOUW9LQ2k4dklHTnZiblJ5WVdOMExuUmxjM1JwYm1kZllYQndMbU52Ym5SeVlXTjBMbFJsYzNScGJtZEJjSEF1ZFhCa1lYUmxLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxPZ29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklITmxiR1l1WVhWMGFHOXlhWHBsWDJOeVpXRjBiM0lvS1FvZ0lDQWdZMkZzYkhOMVlpQmhkWFJvYjNKcGVtVmZZM0psWVhSdmNnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kyOXVkSEpoWTNRdWRHVnpkR2x1WjE5aGNIQXVZMjl1ZEhKaFkzUXVWR1Z6ZEdsdVowRndjQzVrWld4bGRHVW9LU0F0UGlCMmIybGtPZ3BrWld4bGRHVTZDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2MyVnNaaTVoZFhSb2IzSnBlbVZmWTNKbFlYUnZjaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHRjFkR2h2Y21sNlpWOWpjbVZoZEc5eUNpQWdJQ0J5WlhSemRXSUtDZ292THlCamIyNTBjbUZqZEM1MFpYTjBhVzVuWDJGd2NDNWpiMjUwY21GamRDNVVaWE4wYVc1blFYQndMbU5oYkd4ZllXSnBLSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTmhiR3hmWVdKcE9nb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TmpBdE5qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdOaGJHeGZZV0pwS0hObGJHWXNJSFpoYkhWbE9pQlRkSEpwYm1jcElDMCtJRk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lraGxiR3h2TENBaUtTQXJJSFpoYkhWbENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtobGJHeHZMQ0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTI5dWRISmhZM1F1ZEdWemRHbHVaMTloY0hBdVkyOXVkSEpoWTNRdVZHVnpkR2x1WjBGd2NDNWpZV3hzWDJGaWFWOW1iM0psYVdkdVgzSmxabk1vS1NBdFBpQmllWFJsY3pvS1kyRnNiRjloWW1sZlptOXlaV2xuYmw5eVpXWnpPZ29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklDc2djMlZzWmk1cGRHOWhLRlI0Ymk1aGNIQnNhV05oZEdsdmJuTW9NU2t1YVdRcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVjeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHbDBiMkVLSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qWTNDaUFnSUNBdkx5QWlRWEJ3T2lBaUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGd2NEb2dJZ29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk5qY3ROamdLSUNBZ0lDOHZJQ0pCY0hBNklDSUtJQ0FnSUM4dklDc2djMlZzWmk1cGRHOWhLRlI0Ymk1aGNIQnNhV05oZEdsdmJuTW9NU2t1YVdRcENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlBcklDSXNJRUZ6YzJWME9pQWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpd2dRWE56WlhRNklDSUtJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2pZM0xUWTVDaUFnSUNBdkx5QWlRWEJ3T2lBaUNpQWdJQ0F2THlBcklITmxiR1l1YVhSdllTaFVlRzR1WVhCd2JHbGpZWFJwYjI1ektERXBMbWxrS1FvZ0lDQWdMeThnS3lBaUxDQkJjM05sZERvZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvM01Bb2dJQ0FnTHk4Z0t5QnpaV3htTG1sMGIyRW9WSGh1TG1GemMyVjBjeWd3S1M1cFpDa0tJQ0FnSUhSNGJtRWdRWE56WlhSeklEQUtJQ0FnSUdOaGJHeHpkV0lnYVhSdllRb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TmpjdE56QUtJQ0FnSUM4dklDSkJjSEE2SUNJS0lDQWdJQzh2SUNzZ2MyVnNaaTVwZEc5aEtGUjRiaTVoY0hCc2FXTmhkR2x2Ym5Nb01Ta3VhV1FwQ2lBZ0lDQXZMeUFySUNJc0lFRnpjMlYwT2lBaUNpQWdJQ0F2THlBcklITmxiR1l1YVhSdllTaFVlRzR1WVhOelpYUnpLREFwTG1sa0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z0t5QWlMQ0JCWTJOdmRXNTBPaUFpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaXdnUVdOamIzVnVkRG9nSWdvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZOamN0TnpFS0lDQWdJQzh2SUNKQmNIQTZJQ0lLSUNBZ0lDOHZJQ3NnYzJWc1ppNXBkRzloS0ZSNGJpNWhjSEJzYVdOaGRHbHZibk1vTVNrdWFXUXBDaUFnSUNBdkx5QXJJQ0lzSUVGemMyVjBPaUFpQ2lBZ0lDQXZMeUFySUhObGJHWXVhWFJ2WVNoVWVHNHVZWE56WlhSektEQXBMbWxrS1FvZ0lDQWdMeThnS3lBaUxDQkJZMk52ZFc1ME9pQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNScGJtZGZZWEJ3TDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QXJJSE5sYkdZdWFYUnZZU2h2Y0M1blpYUmllWFJsS0ZSNGJpNWhZMk52ZFc1MGN5Z3dLUzVpZVhSbGN5d2dNQ2twQ2lBZ0lDQjBlRzVoSUVGalkyOTFiblJ6SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0JqWVd4c2MzVmlJR2wwYjJFS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPalkzTFRjeUNpQWdJQ0F2THlBaVFYQndPaUFpQ2lBZ0lDQXZMeUFySUhObGJHWXVhWFJ2WVNoVWVHNHVZWEJ3YkdsallYUnBiMjV6S0RFcExtbGtLUW9nSUNBZ0x5OGdLeUFpTENCQmMzTmxkRG9nSWdvZ0lDQWdMeThnS3lCelpXeG1MbWwwYjJFb1ZIaHVMbUZ6YzJWMGN5Z3dLUzVwWkNrS0lDQWdJQzh2SUNzZ0lpd2dRV05qYjNWdWREb2dJZ29nSUNBZ0x5OGdLeUJ6Wld4bUxtbDBiMkVvYjNBdVoyVjBZbmwwWlNoVWVHNHVZV05qYjNWdWRITW9NQ2t1WW5sMFpYTXNJREFwS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnS3lBaU9pSUtJQ0FnSUhCMWMyaGllWFJsY3lBaU9pSUtJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2pZM0xUY3pDaUFnSUNBdkx5QWlRWEJ3T2lBaUNpQWdJQ0F2THlBcklITmxiR1l1YVhSdllTaFVlRzR1WVhCd2JHbGpZWFJwYjI1ektERXBMbWxrS1FvZ0lDQWdMeThnS3lBaUxDQkJjM05sZERvZ0lnb2dJQ0FnTHk4Z0t5QnpaV3htTG1sMGIyRW9WSGh1TG1GemMyVjBjeWd3S1M1cFpDa0tJQ0FnSUM4dklDc2dJaXdnUVdOamIzVnVkRG9nSWdvZ0lDQWdMeThnS3lCelpXeG1MbWwwYjJFb2IzQXVaMlYwWW5sMFpTaFVlRzR1WVdOamIzVnVkSE1vTUNrdVlubDBaWE1zSURBcEtRb2dJQ0FnTHk4Z0t5QWlPaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZOelFLSUNBZ0lDOHZJQ3NnYzJWc1ppNXBkRzloS0c5d0xtZGxkR0o1ZEdVb1ZIaHVMbUZqWTI5MWJuUnpLREFwTG1KNWRHVnpMQ0F4S1NrS0lDQWdJSFI0Ym1FZ1FXTmpiM1Z1ZEhNZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUdOaGJHeHpkV0lnYVhSdllRb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TmpjdE56UUtJQ0FnSUM4dklDSkJjSEE2SUNJS0lDQWdJQzh2SUNzZ2MyVnNaaTVwZEc5aEtGUjRiaTVoY0hCc2FXTmhkR2x2Ym5Nb01Ta3VhV1FwQ2lBZ0lDQXZMeUFySUNJc0lFRnpjMlYwT2lBaUNpQWdJQ0F2THlBcklITmxiR1l1YVhSdllTaFVlRzR1WVhOelpYUnpLREFwTG1sa0tRb2dJQ0FnTHk4Z0t5QWlMQ0JCWTJOdmRXNTBPaUFpQ2lBZ0lDQXZMeUFySUhObGJHWXVhWFJ2WVNodmNDNW5aWFJpZVhSbEtGUjRiaTVoWTJOdmRXNTBjeWd3S1M1aWVYUmxjeXdnTUNrcENpQWdJQ0F2THlBcklDSTZJZ29nSUNBZ0x5OGdLeUJ6Wld4bUxtbDBiMkVvYjNBdVoyVjBZbmwwWlNoVWVHNHVZV05qYjNWdWRITW9NQ2t1WW5sMFpYTXNJREVwS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG8yTmkwM05Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUNnS0lDQWdJQzh2SUNBZ0lDQWlRWEJ3T2lBaUNpQWdJQ0F2THlBZ0lDQWdLeUJ6Wld4bUxtbDBiMkVvVkhodUxtRndjR3hwWTJGMGFXOXVjeWd4S1M1cFpDa0tJQ0FnSUM4dklDQWdJQ0FySUNJc0lFRnpjMlYwT2lBaUNpQWdJQ0F2THlBZ0lDQWdLeUJ6Wld4bUxtbDBiMkVvVkhodUxtRnpjMlYwY3lnd0tTNXBaQ2tLSUNBZ0lDOHZJQ0FnSUNBcklDSXNJRUZqWTI5MWJuUTZJQ0lLSUNBZ0lDOHZJQ0FnSUNBcklITmxiR1l1YVhSdllTaHZjQzVuWlhSaWVYUmxLRlI0Ymk1aFkyTnZkVzUwY3lnd0tTNWllWFJsY3l3Z01Da3BDaUFnSUNBdkx5QWdJQ0FnS3lBaU9pSUtJQ0FnSUM4dklDQWdJQ0FySUhObGJHWXVhWFJ2WVNodmNDNW5aWFJpZVhSbEtGUjRiaTVoWTJOdmRXNTBjeWd3S1M1aWVYUmxjeXdnTVNrcENpQWdJQ0F2THlBcENpQWdJQ0J5WlhSemRXSUtDZ292THlCamIyNTBjbUZqZEM1MFpYTjBhVzVuWDJGd2NDNWpiMjUwY21GamRDNVVaWE4wYVc1blFYQndMbk5sZEY5bmJHOWlZV3dvYVc1ME1Ub2dkV2x1ZERZMExDQnBiblF5T2lCMWFXNTBOalFzSUdKNWRHVnpNVG9nWW5sMFpYTXNJR0o1ZEdWek1qb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuTmxkRjluYkc5aVlXdzZDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRvM055MDRNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdjMlYwWDJkc2IySmhiQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQ0JwYm5ReE9pQlZTVzUwTmpRc0lHbHVkREk2SUZWSmJuUTJOQ3dnWW5sMFpYTXhPaUJUZEhKcGJtY3NJR0o1ZEdWek1qb2dZWEpqTkM1VGRHRjBhV05CY25KaGVWdGhjbU0wTGtKNWRHVXNJRXhwZEdWeVlXeGJORjFkQ2lBZ0lDQXZMeUFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBMElEQUtJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2pneENpQWdJQ0F2THlCelpXeG1MbWx1ZERFZ1BTQnBiblF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbWx1ZERFaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBhVzVuWDJGd2NDOWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnYzJWc1ppNXBiblF5SUQwZ2FXNTBNZ29nSUNBZ2NIVnphR0o1ZEdWeklDSnBiblF5SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZPRE1LSUNBZ0lDOHZJSE5sYkdZdVlubDBaWE14SUQwZ1lubDBaWE14TG1KNWRHVnpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltSjVkR1Z6TVNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJ6Wld4bUxtSjVkR1Z6TWlBOUlHSjVkR1Z6TWk1aWVYUmxjd29nSUNBZ2NIVnphR0o1ZEdWeklDSmllWFJsY3pJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCamIyNTBjbUZqZEM1MFpYTjBhVzVuWDJGd2NDNWpiMjUwY21GamRDNVVaWE4wYVc1blFYQndMbk5sZEY5c2IyTmhiQ2hwYm5ReE9pQjFhVzUwTmpRc0lHbHVkREk2SUhWcGJuUTJOQ3dnWW5sMFpYTXhPaUJpZVhSbGN5d2dZbmwwWlhNeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyVjBYMnh2WTJGc09nb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2T0RZdE9Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlITmxkRjlzYjJOaGJDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxDQnBiblF4T2lCVlNXNTBOalFzSUdsdWRESTZJRlZKYm5RMk5Dd2dZbmwwWlhNeE9pQlRkSEpwYm1jc0lHSjVkR1Z6TWpvZ1lYSmpOQzVUZEdGMGFXTkJjbkpoZVZ0aGNtTTBMa0o1ZEdVc0lFeHBkR1Z5WVd4Yk5GMWRDaUFnSUNBdkx5QXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUEwSURBS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZMkZzWDJsdWRERmJWSGh1TG5ObGJtUmxjbDBnUFNCcGJuUXhDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW14dlkyRnNYMmx1ZERFaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZMkZzWDJsdWRESmJWSGh1TG5ObGJtUmxjbDBnUFNCcGJuUXlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW14dlkyRnNYMmx1ZERJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJ6Wld4bUxteHZZMkZzWDJKNWRHVnpNVnRVZUc0dWMyVnVaR1Z5WFNBOUlHSjVkR1Z6TVM1aWVYUmxjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKc2IyTmhiRjlpZVhSbGN6RWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCelpXeG1MbXh2WTJGc1gySjVkR1Z6TWx0VWVHNHVjMlZ1WkdWeVhTQTlJR0o1ZEdWek1pNWllWFJsY3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2NIVnphR0o1ZEdWeklDSnNiMk5oYkY5aWVYUmxjeklpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR052Ym5SeVlXTjBMblJsYzNScGJtZGZZWEJ3TG1OdmJuUnlZV04wTGxSbGMzUnBibWRCY0hBdWFYTnpkV1ZmZEhKaGJuTm1aWEpmZEc5ZmMyVnVaR1Z5S0dGdGIzVnVkRG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbWx6YzNWbFgzUnlZVzV6Wm1WeVgzUnZYM05sYm1SbGNqb0tJQ0FnSUM4dklIUmxjM1JwYm1kZllYQndMMk52Ym5SeVlXTjBMbkI1T2prMUxUazJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnBjM04xWlY5MGNtRnVjMlpsY2w5MGIxOXpaVzVrWlhJb2MyVnNaaXdnWVcxdmRXNTBPaUJoY21NMExsVkpiblEyTkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk9UY0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2h5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TENCaGJXOTFiblE5WVcxdmRXNTBMbTVoZEdsMlpTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOdmJuUnlZV04wTG5SbGMzUnBibWRmWVhCd0xtTnZiblJ5WVdOMExsUmxjM1JwYm1kQmNIQXVjMlYwWDJKdmVDaHVZVzFsT2lCaWVYUmxjeXdnZG1Gc2RXVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHpaWFJmWW05NE9nb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2T1RrdE1UQXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpaWFJmWW05NEtITmxiR1lzSUc1aGJXVTZJR0Z5WXpRdVUzUmhkR2xqUVhKeVlYbGJZWEpqTkM1Q2VYUmxMQ0JNYVhSbGNtRnNXelJkWFN3Z2RtRnNkV1U2SUdGeVl6UXVVM1J5YVc1bktTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUIwWlhOMGFXNW5YMkZ3Y0M5amIyNTBjbUZqZEM1d2VUb3hNREVLSUNBZ0lDOHZJSE5sYkdZdVltOTRXMjVoYldWZElEMGdkbUZzZFdVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kyOXVkSEpoWTNRdWRHVnpkR2x1WjE5aGNIQXVZMjl1ZEhKaFkzUXVWR1Z6ZEdsdVowRndjQzVsYldsMFUzZGhjSEJsWkNoaE9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtVnRhWFJUZDJGd2NHVmtPZ29nSUNBZ0x5OGdkR1Z6ZEdsdVoxOWhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UQTNMVEV3T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWlcxcGRGTjNZWEJ3WldRb2MyVnNaaXdnWVRvZ1lYSmpOQzVWU1c1ME5qUXNJR0k2SUdGeVl6UXVWVWx1ZERZMEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUIwWlhOMGFXNW5YMkZ3Y0M5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dpVTNkaGNIQmxaQ0lzSUdFc0lHSXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklHMWxkR2h2WkNBaVUzZGhjSEJsWkNoMWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJqYjI1MGNtRmpkQzUwWlhOMGFXNW5YMkZ3Y0M1amIyNTBjbUZqZEM1VVpYTjBhVzVuUVhCd0xtVnRhWFJUZDJGd2NHVmtWSGRwWTJVb1lUb2dZbmwwWlhNc0lHSTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGxiV2wwVTNkaGNIQmxaRlIzYVdObE9nb2dJQ0FnTHk4Z2RHVnpkR2x1WjE5aGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRFeExURXhNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdaVzFwZEZOM1lYQndaV1JVZDJsalpTaHpaV3htTENCaE9pQmhjbU0wTGxWSmJuUTJOQ3dnWWpvZ1lYSmpOQzVWU1c1ME5qUXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKVGQyRndjR1ZrSWl3Z1lTd2dZaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdiV1YwYUc5a0lDSlRkMkZ3Y0dWa0tIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnBibWRmWVhCd0wyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKVGQyRndjR1ZrSWl3Z1lpd2dZU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdiV1YwYUc5a0lDSlRkMkZ3Y0dWa0tIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOdmJuUnlZV04wTG5SbGMzUnBibWRmWVhCd0xtTnZiblJ5WVdOMExsUmxjM1JwYm1kQmNIQXVaVzFwZEVOdmJYQnNaWGdvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6TENCaGNuSmhlVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbVZ0YVhSRGIyMXdiR1Y0T2dvZ0lDQWdMeThnZEdWemRHbHVaMTloY0hBdlkyOXVkSEpoWTNRdWNIazZNVEUyTFRFeE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ1pXMXBkRU52YlhCc1pYZ29jMlZzWml3Z1lUb2dZWEpqTkM1VlNXNTBOalFzSUdJNklHRnlZelF1VlVsdWREWTBMQ0JoY25KaGVUb2dZWEpqTkM1RWVXNWhiV2xqUVhKeVlYbGJZWEpqTkM1VlNXNTBNekpkS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ2lVM2RoY0hCbFpDSXNJR0VzSUdJcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SUcxbGRHaHZaQ0FpVTNkaGNIQmxaQ2gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wYVc1blgyRndjQzlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ2lRMjl0Y0d4bGVDSXNJR0Z5Y21GNUxDQmlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3WVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE9HUmhOV1ZoTnlBdkx5QnRaWFJvYjJRZ0lrTnZiWEJzWlhnb2RXbHVkRE15VzEwc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFRQUtKZ01FSE12WkpRUVZIM3gxQURFYlFRRXlnZ3NFTU1iVmlnVHhmb0NsQksxMVlDd0VwTStONmdUT3dvTktCSmkrSWhrRXBMU2lNQVJFME5vTkJOUTg3bDBFRWJDWFdnU3RJdzBNTmhvQWpnc0ExQUMyQUo0QWdRQmtBRlVBUXdBN0FDa0FGd0FDSTBNeEdSUkVNUmhFTmhvQk5ob0NOaG9EaUFKTUlrTXhHUlJFTVJoRU5ob0JOaG9DaUFJa0lrTXhHUlJFTVJoRU5ob0JOaG9DaUFJRklrTXhHUlJFTVJoRUFERVpGRVF4R0VRMkdnRTJHZ0tJQWQ0aVF6RVpGRVF4R0VRMkdnR0lBYm9pUXpFWkZFUXhHRVEyR2dFWE5ob0NGellhQTFjQ0FEWWFCSWdCVVNKRE1Sa1VSREVZUkRZYUFSYzJHZ0lYTmhvRFZ3SUFOaG9FaUFFSUlrTXhHUlJFTVJoRWlBQzFTUlVXVndZQ1RGQXBURkN3SWtNeEdSUkVNUmhFTmhvQlZ3SUFpQUNIU1JVV1Z3WUNURkFwVEZDd0lrTXhHU0lTUkRFWVJDSkRNUm1OQmdBVEFCUC9FdjhTQUFzQUEwTC9EekVZUklnQVVpSkRNUmhFaUFCR0lrTXhHQlJFSWtNeEFESUpFa1NKaWdFQktvdi9RQUFGZ0FFd1RJbUwveVFLU1l3QVFRQWJpd0NJLytPTC95UVlnQW93TVRJek5EVTJOemc1VENKWVVFeUpLa0wvNW9qL3Y0bUkvN3VKaWdFQmdBZElaV3hzYnl3Z2kvOVFpVFl5QVlqL3E0QUZRWEJ3T2lCTVVJQUpMQ0JCYzNObGREb2dVRFl3QUlqL2tGQ0FDeXdnUVdOamIzVnVkRG9nVURZY0FDTlZpUDk1VUlBQk9sQTJIQUFpVllqL2JGQ0ppZ1FBZ0FScGJuUXhpL3huZ0FScGJuUXlpLzFuZ0FaaWVYUmxjekdML21lQUJtSjVkR1Z6TW92L1o0bUtCQUF4QUlBS2JHOWpZV3hmYVc1ME1ZdjhaakVBZ0Fwc2IyTmhiRjlwYm5ReWkvMW1NUUNBREd4dlkyRnNYMko1ZEdWek1ZditaakVBZ0F4c2IyTmhiRjlpZVhSbGN6S0wvMmFKaWdFQXNURUFpLzhYc2dpeUJ5S3lFQ095QWJPSmlnSUFpLzY4U0l2K2kvKy9pWW9DQUl2K2kvOVFLRXhRc0ltS0FnQ0wvb3YvVUNoTVVMQ0wvNHYrVUNoTVVMQ0ppZ01BaS8yTC9sQW9URkN3Z0FJQUNvditVSXYvVUlBRUdOcGVwMHhRc0lrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjUsInBhdGNoIjozLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlN3YXBwZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDb21wbGV4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQzMltdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
