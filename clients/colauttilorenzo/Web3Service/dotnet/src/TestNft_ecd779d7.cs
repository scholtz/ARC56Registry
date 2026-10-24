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

namespace Arc56.Generated.colauttilorenzo.Web3Service.TestNft_ecd779d7
{


    //
    // An ARC-72 NFT collection with enumeration, management and ARC-73. Fund the application account: tokens are boxes.
    //
    public class TestNftProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestNftProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class Arc72TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 216, 8, 212, 244 };
                public const string Signature = "arc72_Transfer(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public static Arc72TransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc72TransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

            public class Arc72ApprovalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 133, 162, 230, 224 };
                public const string Signature = "arc72_Approval(address,address,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public static Arc72ApprovalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc72ApprovalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

            public class Arc72ApprovalForAllEvent
            {
                public static readonly byte[] Selector = new byte[4] { 76, 77, 235, 171 };
                public const string Signature = "arc72_ApprovalForAll(address,address,bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public bool Field3 { get; set; }

                public static Arc72ApprovalForAllEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new Arc72ApprovalForAllEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="uri"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc72Mint(Algorand.Address to, string uri, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 236, 214, 182 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); uriAbi.From(uri);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, uriAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc72Mint_Transactions(Algorand.Address to, string uri, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 236, 214, 182 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var uriAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); uriAbi.From(uri);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, uriAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///ARC-73 itself, ARC-72 core, ARC-72 enumeration and ARC-72 management.
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
        /// <param name="tokenId"> </param>
        public async Task<Algorand.Address> Arc72OwnerOf(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 9, 106, 20 };

            var result = await base.SimApp(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Arc72OwnerOf_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 9, 106, 20 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        public async Task<byte[]> Arc72TokenUri(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 193, 252, 0 };

            var result = await base.SimApp(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(256, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Arc72TokenUri_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 193, 252, 0 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc72TotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 215, 42, 122 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc72TotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 215, 42, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc72TokenByIndex(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 155, 253, 39 };

            var result = await base.SimApp(new List<object> { abiHandle, index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc72TokenByIndex_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 155, 253, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle, index }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Arc72BalanceOf(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 49, 145, 36 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Arc72BalanceOf_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 49, 145, 36 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenId"> </param>
        public async Task<Algorand.Address> Arc72GetApproved(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 138, 164, 241 };

            var result = await base.SimApp(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Arc72GetApproved_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 138, 164, 241 };

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="operator"> </param>
        public async Task<bool> Arc72IsApprovedForAll(Algorand.Address owner, Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 122, 220, 61 };
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

        public async Task<List<Transaction>> Arc72IsApprovedForAll_Transactions(Algorand.Address owner, Algorand.Address @operator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 122, 220, 61 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, operatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="approved"> </param>
        /// <param name="tokenId"> </param>
        public async Task Arc72Approve(Algorand.Address approved, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 237, 186, 78 };
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, approvedAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc72Approve_Transactions(Algorand.Address approved, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 237, 186, 78 };
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, approvedAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="operator"> </param>
        /// <param name="approved"> </param>
        public async Task Arc72SetApprovalForAll(Algorand.Address @operator, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 52, 57, 95 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, operatorAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc72SetApprovalForAll_Transactions(Algorand.Address @operator, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 52, 57, 95 };
            var operatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); operatorAbi.From(@operator);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, operatorAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from_"> </param>
        /// <param name="to"> </param>
        /// <param name="tokenId"> </param>
        public async Task Arc72TransferFrom(Algorand.Address from_, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 241, 148, 160 };
            var from_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); from_Abi.From(from_);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, from_Abi, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc72TransferFrom_Transactions(Algorand.Address from_, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 tokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 241, 148, 160 };
            var from_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); from_Abi.From(from_);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, from_Abi, toAbi, tokenId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdE5mdCIsImRlc2MiOiJBbiBBUkMtNzIgTkZUIGNvbGxlY3Rpb24gd2l0aCBlbnVtZXJhdGlvbiwgbWFuYWdlbWVudCBhbmQgQVJDLTczLiBGdW5kIHRoZSBhcHBsaWNhdGlvbiBhY2NvdW50OiB0b2tlbnMgYXJlIGJveGVzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM3Ml9taW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXJpIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmM3Ml9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdXBwb3J0c0ludGVyZmFjZSIsImRlc2MiOiJBUkMtNzMgaXRzZWxmLCBBUkMtNzIgY29yZSwgQVJDLTcyIGVudW1lcmF0aW9uIGFuZCBBUkMtNzIgbWFuYWdlbWVudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZmFjZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNzJfb3duZXJPZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzcyX3Rva2VuVVJJIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMjU2XSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM3Ml90b3RhbFN1cHBseSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzcyX3Rva2VuQnlJbmRleCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM3Ml9iYWxhbmNlT2YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNzJfZ2V0QXBwcm92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM3Ml9pc0FwcHJvdmVkRm9yQWxsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNzJfYXBwcm92ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwcm92ZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJhcmM3Ml9BcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM3Ml9zZXRBcHByb3ZhbEZvckFsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3BlcmF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjNzJfQXBwcm92YWxGb3JBbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJjNzJfdHJhbnNmZXJGcm9tIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiYXJjNzJfVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3MDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJhbGFuY2VzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NSw0MjUsNDQ3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taW50ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lcl9hY2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5NCw1NzEsNjgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lcnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51cmlzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Ml0sImVycm9yTWVzc2FnZSI6ImluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjgsNDc3LDUyMyw1MzEsNTU3LDYwOCw2NTYsNjY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4OSw0MDgsNDQzLDUwMSw1NjUsNjc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDI1NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5NF0sImVycm9yTWVzc2FnZSI6Im5vdCBhbGxvd2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUxLDU3Nyw2ODZdLCJlcnJvck1lc3NhZ2UiOiJub3Qgb3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjAsNzEzLDgyMl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc1XSwiZXJyb3JNZXNzYWdlIjoidGV4dCB0b28gbG9uZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXpNaUF4SURBZ01qVTJDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdJbTFwYm5SbFpDSWdNSGcyWmlBd2VEWXhJQ0p2ZDI1bGNsOWhZMk52ZFc1MElpQXdlREF3SURCNE1ERWdNSGcyTWlBd2VEY3dJREI0WkRnd09HUTBaalFnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG94TnpjS0lDQWdJQzh2SUhObGJHWXViV2x1ZEdWa0lEMGdWVWx1ZERZMEtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMXBiblJsWkNJS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TVRjNENpQWdJQ0F2THlCelpXeG1MbTkzYm1WeVgyRmpZMjkxYm5RZ1BTQkJZMk52ZFc1MEtDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltOTNibVZ5WDJGalkyOTFiblFpQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbkI1T2pFM013b2dJQ0FnTHk4Z1kyeGhjM01nVkdWemRFNW1kQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4T0FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURsaFpXTmtObUkySURCNE5HVXlNbUV6WW1FZ01IZzNPVEE1Tm1FeE5DQXdlR016WXpGbVl6QXdJREI0TmpSa056SmhOMkVnTUhnMlpEbGlabVF5TnlBd2VHRmpNekU1TVRJMElEQjRPVFE0WVdFMFpqRWdNSGd5TVRkaFpHTXpaQ0F3ZUdJMFpXUmlZVFJsSURCNE56RXpORE01TldZZ01IaG1NbVl4T1RSaE1DQXZMeUJ0WlhSb2IyUWdJbUZ5WXpjeVgyMXBiblFvWVdSa2NtVnpjeXh6ZEhKcGJtY3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWljM1Z3Y0c5eWRITkpiblJsY21aaFkyVW9ZbmwwWlZzMFhTbGliMjlzSWl3Z2JXVjBhRzlrSUNKaGNtTTNNbDl2ZDI1bGNrOW1LSFZwYm5ReU5UWXBZV1JrY21WemN5SXNJRzFsZEdodlpDQWlZWEpqTnpKZmRHOXJaVzVWVWtrb2RXbHVkREkxTmlsaWVYUmxXekkxTmwwaUxDQnRaWFJvYjJRZ0ltRnlZemN5WDNSdmRHRnNVM1Z3Y0d4NUtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmhjbU0zTWw5MGIydGxia0o1U1c1a1pYZ29kV2x1ZERJMU5pbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmhjbU0zTWw5aVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKaGNtTTNNbDluWlhSQmNIQnliM1psWkNoMWFXNTBNalUyS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1GeVl6Y3lYMmx6UVhCd2NtOTJaV1JHYjNKQmJHd29ZV1JrY21WemN5eGhaR1J5WlhOektXSnZiMndpTENCdFpYUm9iMlFnSW1GeVl6Y3lYMkZ3Y0hKdmRtVW9ZV1JrY21WemN5eDFhVzUwTWpVMktYWnZhV1FpTENCdFpYUm9iMlFnSW1GeVl6Y3lYM05sZEVGd2NISnZkbUZzUm05eVFXeHNLR0ZrWkhKbGMzTXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0poY21NM01sOTBjbUZ1YzJabGNrWnliMjBvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHRnlZemN5WDIxcGJuUWdjM1Z3Y0c5eWRITkpiblJsY21aaFkyVWdZWEpqTnpKZmIzZHVaWEpQWmlCaGNtTTNNbDkwYjJ0bGJsVlNTU0JoY21NM01sOTBiM1JoYkZOMWNIQnNlU0JoY21NM01sOTBiMnRsYmtKNVNXNWtaWGdnWVhKak56SmZZbUZzWVc1alpVOW1JR0Z5WXpjeVgyZGxkRUZ3Y0hKdmRtVmtJR0Z5WXpjeVgybHpRWEJ3Y205MlpXUkdiM0pCYkd3Z1lYSmpOekpmWVhCd2NtOTJaU0JoY21NM01sOXpaWFJCY0hCeWIzWmhiRVp2Y2tGc2JDQmhjbU0zTWw5MGNtRnVjMlpsY2taeWIyMEtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhPRG9LSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakUzTXdvZ0lDQWdMeThnWTJ4aGMzTWdWR1Z6ZEU1bWRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpnME5EZGlNellnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQmxjbklLQ2dvdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1VVpYTjBUbVowTG1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCMFpYTjBYMk52Ym5SeVlXTjBjeTV3ZVRveE9EY0tJQ0FnSUM4dklITmxiR1l1YjNkdVpYSmZZV05qYjNWdWRDQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTkzYm1WeVgyRmpZMjkxYm5RaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TVRnMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1VVpYTjBUbVowTG1GeVl6Y3lYMjFwYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjbU0zTWw5dGFXNTBPZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNVGc1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakU1TVFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTV2ZDI1bGNsOWhZMk52ZFc1MExDQWlibTkwSUc5M2JtVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW05M2JtVnlYMkZqWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNkdVpYSmZZV05qYjNWdWRDQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUc5M2JtVnlDaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3hPVElLSUNBZ0lDOHZJSE5sYkdZdWJXbHVkR1ZrSUNzOUlERUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdGFXNTBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVkR1ZrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xcGJuUmxaQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TVRrekNpQWdJQ0F2THlCMGIydGxia2xrSUQwZ1lYSmpOQzVWU1c1ME1qVTJLSE5sYkdZdWJXbHVkR1ZrS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakU1TkFvZ0lDQWdMeThnYzJWc1ppNTFjbWx6VzNSdmEyVnVTV1JkSUQwZ1FubDBaWE15TlRZdVpuSnZiVjlpZVhSbGN5aHdZV1JrWldRb2RYSnBMbTVoZEdsMlpTd2dWVWx1ZERZMEtESTFOaWtwS1FvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdkR1Y0ZEM1aWVYUmxjeTVzWlc1bmRHZ2dQRDBnYzJsNlpTd2dJblJsZUhRZ2RHOXZJR3h2Ym1jaUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG94T1RRS0lDQWdJQzh2SUhObGJHWXVkWEpwYzF0MGIydGxia2xrWFNBOUlFSjVkR1Z6TWpVMkxtWnliMjFmWW5sMFpYTW9jR0ZrWkdWa0tIVnlhUzV1WVhScGRtVXNJRlZKYm5RMk5DZ3lOVFlwS1NrS0lDQWdJR2x1ZEdOZk15QXZMeUF5TlRZS0lDQWdJQzh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbkI1T2pJNUNpQWdJQ0F2THlCaGMzTmxjblFnZEdWNGRDNWllWFJsY3k1c1pXNW5kR2dnUEQwZ2MybDZaU3dnSW5SbGVIUWdkRzl2SUd4dmJtY2lDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSbGVIUWdkRzl2SUd4dmJtY0tJQ0FnSUM4dklIUmxjM1JmWTI5dWRISmhZM1J6TG5CNU9qRTVOQW9nSUNBZ0x5OGdjMlZzWmk1MWNtbHpXM1J2YTJWdVNXUmRJRDBnUW5sMFpYTXlOVFl1Wm5KdmJWOWllWFJsY3lod1lXUmtaV1FvZFhKcExtNWhkR2wyWlN3Z1ZVbHVkRFkwS0RJMU5pa3BLUW9nSUNBZ2FXNTBZMTh6SUM4dklESTFOZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNekFLSUNBZ0lDOHZJSEpsZEhWeWJpQjBaWGgwTG1KNWRHVnpJQ3NnYjNBdVlucGxjbThvYzJsNlpTQXRJSFJsZUhRdVlubDBaWE11YkdWdVozUm9LUW9nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnWW5wbGNtOEtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNVGswQ2lBZ0lDQXZMeUJ6Wld4bUxuVnlhWE5iZEc5clpXNUpaRjBnUFNCQ2VYUmxjekkxTmk1bWNtOXRYMko1ZEdWektIQmhaR1JsWkNoMWNta3VibUYwYVhabExDQlZTVzUwTmpRb01qVTJLU2twQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczTlFvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNVGsxQ2lBZ0lDQXZMeUJ6Wld4bUxsOXlaV05sYVhabEtIUnZMbTVoZEdsMlpTd2dkRzlyWlc1SlpDa0tJQ0FnSUdSMWNESUtJQ0FnSUdOaGJHeHpkV0lnWDNKbFkyVnBkbVVLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakU1TmdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKaGNtTTNNbDlVY21GdWMyWmxjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pa2lMQ0JoY21NMExrRmtaSEpsYzNNb1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5a3NJSFJ2TENCMGIydGxia2xrS1FvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nT1NBdkx5QnRaWFJvYjJRZ0ltRnlZemN5WDFSeVlXNXpabVZ5S0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG94T0RrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTI5dWRISmhZM1J6TGxSbGMzUk9ablF1YzNWd2NHOXlkSE5KYm5SbGNtWmhZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemRYQndiM0owYzBsdWRHVnlabUZqWlRvS0lDQWdJQzh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbkI1T2pFNU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnTHk4Z2RHVnpkRjlqYjI1MGNtRmpkSE11Y0hrNk1qQTBDaUFnSUNBdkx5QnpaV3hsWTNSdmNpQTlQU0JDZVhSbGN5NW1jbTl0WDJobGVDZ2lOR1U1TVRNM09UWWlLU0J2Y2lCelpXeGxZM1J2Y2lBOVBTQkNlWFJsY3k1bWNtOXRYMmhsZUNnaU5UTm1NREpoTkRBaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5HVTVNVE0zT1RZS0lDQWdJRDA5Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TURRdE1qQTFDaUFnSUNBdkx5QnpaV3hsWTNSdmNpQTlQU0JDZVhSbGN5NW1jbTl0WDJobGVDZ2lOR1U1TVRNM09UWWlLU0J2Y2lCelpXeGxZM1J2Y2lBOVBTQkNlWFJsY3k1bWNtOXRYMmhsZUNnaU5UTm1NREpoTkRBaUtRb2dJQ0FnTHk4Z2IzSWdjMlZzWldOMGIzSWdQVDBnUW5sMFpYTXVabkp2YlY5b1pYZ29JbUUxTjJRMFptUmlJaWtnYjNJZ2MyVnNaV04wYjNJZ1BUMGdRbmwwWlhNdVpuSnZiVjlvWlhnb0ltSTVZelptTmprMklpa0tJQ0FnSUdKdWVpQnpkWEJ3YjNKMGMwbHVkR1Z5Wm1GalpWOWliMjlzWDNSeWRXVkFOUW9nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNakEwQ2lBZ0lDQXZMeUJ6Wld4bFkzUnZjaUE5UFNCQ2VYUmxjeTVtY205dFgyaGxlQ2dpTkdVNU1UTTNPVFlpS1NCdmNpQnpaV3hsWTNSdmNpQTlQU0JDZVhSbGN5NW1jbTl0WDJobGVDZ2lOVE5tTURKaE5EQWlLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFNMll3TW1FME1Bb2dJQ0FnUFQwS0lDQWdJQzh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbkI1T2pJd05DMHlNRFVLSUNBZ0lDOHZJSE5sYkdWamRHOXlJRDA5SUVKNWRHVnpMbVp5YjIxZmFHVjRLQ0kwWlRreE16YzVOaUlwSUc5eUlITmxiR1ZqZEc5eUlEMDlJRUo1ZEdWekxtWnliMjFmYUdWNEtDSTFNMll3TW1FME1DSXBDaUFnSUNBdkx5QnZjaUJ6Wld4bFkzUnZjaUE5UFNCQ2VYUmxjeTVtY205dFgyaGxlQ2dpWVRVM1pEUm1aR0lpS1NCdmNpQnpaV3hsWTNSdmNpQTlQU0JDZVhSbGN5NW1jbTl0WDJobGVDZ2lZamxqTm1ZMk9UWWlLUW9nSUNBZ1ltNTZJSE4xY0hCdmNuUnpTVzUwWlhKbVlXTmxYMkp2YjJ4ZmRISjFaVUExQ2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TURVS0lDQWdJQzh2SUc5eUlITmxiR1ZqZEc5eUlEMDlJRUo1ZEdWekxtWnliMjFmYUdWNEtDSmhOVGRrTkdaa1lpSXBJRzl5SUhObGJHVmpkRzl5SUQwOUlFSjVkR1Z6TG1aeWIyMWZhR1Y0S0NKaU9XTTJaalk1TmlJcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFMU4yUTBabVJpQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNakEwTFRJd05Rb2dJQ0FnTHk4Z2MyVnNaV04wYjNJZ1BUMGdRbmwwWlhNdVpuSnZiVjlvWlhnb0lqUmxPVEV6TnprMklpa2diM0lnYzJWc1pXTjBiM0lnUFQwZ1FubDBaWE11Wm5KdmJWOW9aWGdvSWpVelpqQXlZVFF3SWlrS0lDQWdJQzh2SUc5eUlITmxiR1ZqZEc5eUlEMDlJRUo1ZEdWekxtWnliMjFmYUdWNEtDSmhOVGRrTkdaa1lpSXBJRzl5SUhObGJHVmpkRzl5SUQwOUlFSjVkR1Z6TG1aeWIyMWZhR1Y0S0NKaU9XTTJaalk1TmlJcENpQWdJQ0JpYm5vZ2MzVndjRzl5ZEhOSmJuUmxjbVpoWTJWZlltOXZiRjkwY25WbFFEVUtJQ0FnSUM4dklIUmxjM1JmWTI5dWRISmhZM1J6TG5CNU9qSXdOUW9nSUNBZ0x5OGdiM0lnYzJWc1pXTjBiM0lnUFQwZ1FubDBaWE11Wm5KdmJWOW9aWGdvSW1FMU4yUTBabVJpSWlrZ2IzSWdjMlZzWldOMGIzSWdQVDBnUW5sMFpYTXVabkp2YlY5b1pYZ29JbUk1WXpabU5qazJJaWtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZamxqTm1ZMk9UWUtJQ0FnSUQwOUNpQWdJQ0F2THlCMFpYTjBYMk52Ym5SeVlXTjBjeTV3ZVRveU1EUXRNakExQ2lBZ0lDQXZMeUJ6Wld4bFkzUnZjaUE5UFNCQ2VYUmxjeTVtY205dFgyaGxlQ2dpTkdVNU1UTTNPVFlpS1NCdmNpQnpaV3hsWTNSdmNpQTlQU0JDZVhSbGN5NW1jbTl0WDJobGVDZ2lOVE5tTURKaE5EQWlLUW9nSUNBZ0x5OGdiM0lnYzJWc1pXTjBiM0lnUFQwZ1FubDBaWE11Wm5KdmJWOW9aWGdvSW1FMU4yUTBabVJpSWlrZ2IzSWdjMlZzWldOMGIzSWdQVDBnUW5sMFpYTXVabkp2YlY5b1pYZ29JbUk1WXpabU5qazJJaWtLSUNBZ0lHSjZJSE4xY0hCdmNuUnpTVzUwWlhKbVlXTmxYMkp2YjJ4ZlptRnNjMlZBTmdvS2MzVndjRzl5ZEhOSmJuUmxjbVpoWTJWZlltOXZiRjkwY25WbFFEVTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tjM1Z3Y0c5eWRITkpiblJsY21aaFkyVmZZbTl2YkY5dFpYSm5aVUEzT2dvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpBekxUSXdOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bFkzUnZjaUE5UFNCQ2VYUmxjeTVtY205dFgyaGxlQ2dpTkdVNU1UTTNPVFlpS1NCdmNpQnpaV3hsWTNSdmNpQTlQU0JDZVhSbGN5NW1jbTl0WDJobGVDZ2lOVE5tTURKaE5EQWlLUW9nSUNBZ0x5OGdJQ0FnSUc5eUlITmxiR1ZqZEc5eUlEMDlJRUo1ZEdWekxtWnliMjFmYUdWNEtDSmhOVGRrTkdaa1lpSXBJRzl5SUhObGJHVmpkRzl5SUQwOUlFSjVkR1Z6TG1aeWIyMWZhR1Y0S0NKaU9XTTJaalk1TmlJcENpQWdJQ0F2THlBcENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TVRrNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbk4xY0hCdmNuUnpTVzUwWlhKbVlXTmxYMkp2YjJ4ZlptRnNjMlZBTmpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJSE4xY0hCdmNuUnpTVzUwWlhKbVlXTmxYMkp2YjJ4ZmJXVnlaMlZBTndvS0NpOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxsUmxjM1JPWm5RdVlYSmpOekpmYjNkdVpYSlBabHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GeVl6Y3lYMjkzYm1WeVQyWTZDaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3lNRGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3lNVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG05M2JtVnljMXQwYjJ0bGJrbGtYUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFptQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTNibVZ5Y3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklIUmxjM1JmWTI5dWRISmhZM1J6TG5CNU9qSXdPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdVZHVnpkRTVtZEM1aGNtTTNNbDkwYjJ0bGJsVlNTVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21GeVl6Y3lYM1J2YTJWdVZWSkpPZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNakV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNakUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1MWNtbHpXM1J2YTJWdVNXUmRDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWNtbHpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpFeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk52Ym5SeVlXTjBjeTVVWlhOMFRtWjBMbUZ5WXpjeVgzUnZkR0ZzVTNWd2NHeDVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak56SmZkRzkwWVd4VGRYQndiSGs2Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TVRnS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblF5TlRZb2MyVnNaaTV0YVc1MFpXUXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJXbHVkR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMXBiblJsWkNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3lNVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxsUmxjM1JPWm5RdVlYSmpOekpmZEc5clpXNUNlVWx1WkdWNFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEpqTnpKZmRHOXJaVzVDZVVsdVpHVjRPZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNakl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNakl5Q2lBZ0lDQXZMeUJoYzNObGNuUWdhVzVrWlhndWJtRjBhWFpsSUR3Z2MyVnNaaTV0YVc1MFpXUXNJQ0pwYm1SbGVDSUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdGFXNTBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXbHVkR1ZrSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSStDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakl5TXdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkREkxTmlocGJtUmxlQzV1WVhScGRtVWdLeUF4S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBeENpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakl5TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpiMjUwY21GamRITXVWR1Z6ZEU1bWRDNWhjbU0zTWw5aVlXeGhibU5sVDJaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjbU0zTWw5aVlXeGhibU5sVDJZNkNpQWdJQ0F2THlCMFpYTjBYMk52Ym5SeVlXTjBjeTV3ZVRveU1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3lNamNLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KaGJHRnVZMlZ6TG1kbGRDaHZkMjVsY2k1dVlYUnBkbVVzSUdSbFptRjFiSFE5WVhKak5DNVZTVzUwTWpVMktEQXBLUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlRFl5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCMFpYTjBYMk52Ym5SeVlXTjBjeTV3ZVRveU1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTI5dWRISmhZM1J6TGxSbGMzUk9ablF1WVhKak56SmZaMlYwUVhCd2NtOTJaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNtTTNNbDluWlhSQmNIQnliM1psWkRvS0lDQWdJQzh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbkI1T2pJeU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJQzh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbkI1T2pJek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZWEJ3Y205MllXeHpMbWRsZENoMGIydGxia2xrTENCa1pXWmhkV3gwUFdGeVl6UXVRV1JrY21WemN5Z3BLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRFl4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjMlZzWldOMENpQWdJQ0F2THlCMFpYTjBYMk52Ym5SeVlXTjBjeTV3ZVRveU1qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTI5dWRISmhZM1J6TGxSbGMzUk9ablF1WVhKak56SmZhWE5CY0hCeWIzWmxaRVp2Y2tGc2JGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ5WXpjeVgybHpRWEJ3Y205MlpXUkdiM0pCYkd3NkNpQWdJQ0F2THlCMFpYTjBYMk52Ym5SeVlXTjBjeTV3ZVRveU16TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklIUmxjM1JmWTI5dWRISmhZM1J6TG5CNU9qTTJDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVjMmhoTWpVMktHWnBjbk4wTG1KNWRHVnpJQ3NnYzJWamIyNWtMbUo1ZEdWektRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakl6TlFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWIzQmxjbUYwYjNKekxtZGxkQ2h3WVdseVgydGxlU2h2ZDI1bGNpNXVZWFJwZG1Vc0lHOXdaWEpoZEc5eUxtNWhkR2wyWlNrc0lHUmxabUYxYkhROVlYSmpOQzVDYjI5c0tFWmhiSE5sS1NrS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnM01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNak16Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NVVaWE4wVG1aMExtRnlZemN5WDJGd2NISnZkbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNtTTNNbDloY0hCeWIzWmxPZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNak0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TXprS0lDQWdJQzh2SUc5M2JtVnlJRDBnYzJWc1ppNXZkMjVsY25OYmRHOXJaVzVKWkYwS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMlpnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNkdVpYSnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpRd0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnZkMjVsY2k1dVlYUnBkbVVzSUNKdWIzUWdiM2R1WlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnYjNkdVpYSUtJQ0FnSUM4dklIUmxjM1JmWTI5dWRISmhZM1J6TG5CNU9qSTBNUW9nSUNBZ0x5OGdjMlZzWmk1aGNIQnliM1poYkhOYmRHOXJaVzVKWkYwZ1BTQmhjSEJ5YjNabFpBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWXhDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2RHVnpkRjlqYjI1MGNtRmpkSE11Y0hrNk1qUXlDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9JbUZ5WXpjeVgwRndjSEp2ZG1Gc0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJc0lHOTNibVZ5TENCaGNIQnliM1psWkN3Z2RHOXJaVzVKWkNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnMVlUSmxObVV3SUM4dklHMWxkR2h2WkNBaVlYSmpOekpmUVhCd2NtOTJZV3dvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSZlkyOXVkSEpoWTNSekxuQjVPakl6TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqYjI1MGNtRmpkSE11VkdWemRFNW1kQzVoY21NM01sOXpaWFJCY0hCeWIzWmhiRVp2Y2tGc2JGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ5WXpjeVgzTmxkRUZ3Y0hKdmRtRnNSbTl5UVd4c09nb2dJQ0FnTHk4Z2RHVnpkRjlqYjI1MGNtRmpkSE11Y0hrNk1qUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbkI1T2pJME5nb2dJQ0FnTHk4Z2MyVnNaaTV2Y0dWeVlYUnZjbk5iY0dGcGNsOXJaWGtvVkhodUxuTmxibVJsY2l3Z2IzQmxjbUYwYjNJdWJtRjBhWFpsS1YwZ1BTQmhjSEJ5YjNabFpBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TXpZS0lDQWdJQzh2SUhKbGRIVnliaUJ2Y0M1emFHRXlOVFlvWm1seWMzUXVZbmwwWlhNZ0t5QnpaV052Ym1RdVlubDBaWE1wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUM4dklIUmxjM1JmWTI5dWRISmhZM1J6TG5CNU9qSTBOZ29nSUNBZ0x5OGdjMlZzWmk1dmNHVnlZWFJ2Y25OYmNHRnBjbDlyWlhrb1ZIaHVMbk5sYm1SbGNpd2diM0JsY21GMGIzSXVibUYwYVhabEtWMGdQU0JoY0hCeWIzWmxaQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlRGN3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3lORGNLSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dpWVhKak56SmZRWEJ3Y205MllXeEdiM0pCYkd3b1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdKdmIyd3BJaXdnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQ0J2Y0dWeVlYUnZjaXdnWVhCd2NtOTJaV1FwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBZelJrWldKaFlpQXZMeUJ0WlhSb2IyUWdJbUZ5WXpjeVgwRndjSEp2ZG1Gc1JtOXlRV3hzS0dGa1pISmxjM01zWVdSa2NtVnpjeXhpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3lORFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMjl1ZEhKaFkzUnpMbFJsYzNST1puUXVZWEpqTnpKZmRISmhibk5tWlhKR2NtOXRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhKak56SmZkSEpoYm5ObVpYSkdjbTl0T2dvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpRNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpVeENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXZkMjVsY25OYmRHOXJaVzVKWkYwZ1BUMGdabkp2YlY4c0lDSnViM1FnYjNkdVpYSWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRObVlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWEp6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MElHOTNibVZ5Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TmpFS0lDQWdJQzh2SUdsbUlGUjRiaTV6Wlc1a1pYSWdQVDBnYjNkdVpYSTZDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWVhKak56SmZkSEpoYm5ObVpYSkdjbTl0WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNall5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ21GeVl6Y3lYM1J5WVc1elptVnlSbkp2YlY5aFpuUmxjbDlwYm14cGJtVmtYM1JsYzNSZlkyOXVkSEpoWTNSekxsUmxjM1JPWm5RdVgyMWhlVjkwY21GdWMyWmxja0EyT2dvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpVeUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZiV0Y1WDNSeVlXNXpabVZ5S0daeWIyMWZMbTVoZEdsMlpTd2dkRzlyWlc1SlpDa3NJQ0p1YjNRZ1lXeHNiM2RsWkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ1lXeHNiM2RsWkFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpVekNpQWdJQ0F2THlCaVlXeGhibU5sSUQwZ2MyVnNaaTVpWVd4aGJtTmxjMXRtY205dFh5NXVZWFJwZG1WZENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE5qSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZbUZzWVc1alpYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TlRRS0lDQWdJQzh2SUhObGJHWXVZbUZzWVc1alpYTmJabkp2YlY4dWJtRjBhWFpsWFNBOUlHRnlZelF1VlVsdWRESTFOaWhpWVd4aGJtTmxMbTVoZEdsMlpTQXRJREVwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURFS0lDQWdJR0l0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpVMUNpQWdJQ0F2THlCelpXeG1MbUZ3Y0hKdmRtRnNjMXQwYjJ0bGJrbGtYU0E5SUdGeVl6UXVRV1JrY21WemN5Z3BDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMk1Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNalUyQ2lBZ0lDQXZMeUJ6Wld4bUxsOXlaV05sYVhabEtIUnZMbTVoZEdsMlpTd2dkRzlyWlc1SlpDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQmZjbVZqWldsMlpRb2dJQ0FnTHk4Z2RHVnpkRjlqYjI1MGNtRmpkSE11Y0hrNk1qVTNDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9JbUZ5WXpjeVgxUnlZVzV6Wm1WeUtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NJc0lHWnliMjFmTENCMGJ5d2dkRzlyWlc1SlpDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z2JXVjBhRzlrSUNKaGNtTTNNbDlVY21GdWMyWmxjaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5pa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNalE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbUZ5WXpjeVgzUnlZVzV6Wm1WeVJuSnZiVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1d2VUb3lOak1LSUNBZ0lDOHZJR2xtSUhObGJHWXVZWEJ3Y205MllXeHpMbWRsZENoMGIydGxia2xrTENCa1pXWmhkV3gwUFdGeVl6UXVRV1JrY21WemN5Z3BLUzV1WVhScGRtVWdQVDBnVkhodUxuTmxibVJsY2pvS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMk1Rb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCelpXeGxZM1FLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNtTTNNbDkwY21GdWMyWmxja1p5YjIxZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TmpRS0lDQWdJQzh2SUhKbGRIVnliaUJVY25WbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpVeUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZiV0Y1WDNSeVlXNXpabVZ5S0daeWIyMWZMbTVoZEdsMlpTd2dkRzlyWlc1SlpDa3NJQ0p1YjNRZ1lXeHNiM2RsWkNJS0lDQWdJR0lnWVhKak56SmZkSEpoYm5ObVpYSkdjbTl0WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEY5amIyNTBjbUZqZEhNdVZHVnpkRTVtZEM1ZmJXRjVYM1J5WVc1elptVnlRRFlLQ21GeVl6Y3lYM1J5WVc1elptVnlSbkp2YlY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG96TmdvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG5Ob1lUSTFOaWhtYVhKemRDNWllWFJsY3lBcklITmxZMjl1WkM1aWVYUmxjeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TmpVS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtOXdaWEpoZEc5eWN5NW5aWFFvY0dGcGNsOXJaWGtvYjNkdVpYSXNJRlI0Ymk1elpXNWtaWElwTENCa1pXWmhkV3gwUFdGeVl6UXVRbTl2YkNoR1lXeHpaU2twTG01aGRHbDJaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2RHVnpkRjlqYjI1MGNtRmpkSE11Y0hrNk16WUtJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNXphR0V5TlRZb1ptbHljM1F1WW5sMFpYTWdLeUJ6WldOdmJtUXVZbmwwWlhNcENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ0x5OGdkR1Z6ZEY5amIyNTBjbUZqZEhNdWNIazZNalkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1dmNHVnlZWFJ2Y25NdVoyVjBLSEJoYVhKZmEyVjVLRzkzYm1WeUxDQlVlRzR1YzJWdVpHVnlLU3dnWkdWbVlYVnNkRDFoY21NMExrSnZiMndvUm1Gc2MyVXBLUzV1WVhScGRtVUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzNNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnZEdWemRGOWpiMjUwY21GamRITXVjSGs2TWpVeUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWZiV0Y1WDNSeVlXNXpabVZ5S0daeWIyMWZMbTVoZEdsMlpTd2dkRzlyWlc1SlpDa3NJQ0p1YjNRZ1lXeHNiM2RsWkNJS0lDQWdJR0lnWVhKak56SmZkSEpoYm5ObVpYSkdjbTl0WDJGbWRHVnlYMmx1YkdsdVpXUmZkR1Z6ZEY5amIyNTBjbUZqZEhNdVZHVnpkRTVtZEM1ZmJXRjVYM1J5WVc1elptVnlRRFlLQ2dvdkx5QjBaWE4wWDJOdmJuUnlZV04wY3k1VVpYTjBUbVowTGw5eVpXTmxhWFpsS0c5M2JtVnlPaUJpZVhSbGN5d2dkRzlyWlc1SlpEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNsOXlaV05sYVhabE9nb2dJQ0FnTHk4Z2RHVnpkRjlqYjI1MGNtRmpkSE11Y0hrNk1qWTNMVEkyT0FvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQmZjbVZqWldsMlpTaHpaV3htTENCdmQyNWxjam9nUVdOamIzVnVkQ3dnZEc5clpXNUpaRG9nWVhKak5DNVZTVzUwTWpVMktTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUIwWlhOMFgyTnZiblJ5WVdOMGN5NXdlVG95TmprS0lDQWdJQzh2SUhObGJHWXViM2R1WlhKelczUnZhMlZ1U1dSZElEMGdZWEpqTkM1QlpHUnlaWE56S0c5M2JtVnlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFptQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBYMk52Ym5SeVlXTjBjeTV3ZVRveU56QUtJQ0FnSUM4dklHSmhiR0Z1WTJVZ1BTQnpaV3htTG1KaGJHRnVZMlZ6TG1kbGRDaHZkMjVsY2l3Z1pHVm1ZWFZzZEQxaGNtTTBMbFZKYm5ReU5UWW9NQ2twQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TmpJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklIUmxjM1JmWTI5dWRISmhZM1J6TG5CNU9qSTNNUW9nSUNBZ0x5OGdjMlZzWmk1aVlXeGhibU5sYzF0dmQyNWxjbDBnUFNCaGNtTTBMbFZKYm5ReU5UWW9ZbUZzWVc1alpTNXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF4Q2lBZ0lDQmlLd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1lud0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVJQUVBZ0FJbUN3UVZIM3gxQm0xcGJuUmxaQUZ2QVdFTmIzZHVaWEpmWVdOamIzVnVkQUVBQVFFQllnRndCTmdJMVBRZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUF4R0VBQUNDa2taeWNFTWdObk1Sa1VSREVZUVFCY2dnd0VtdXpXdGdST0lxTzZCSGtKYWhRRXc4SDhBQVJrMXlwNkJHMmIvU2NFckRHUkpBU1VpcVR4QkNGNjNEMEV0TzI2VGdSeE5EbGZCUEx4bEtBMkdnQ09EQUFXQUhFQXR3REtBTjhBN1FFUEFTY0JQUUZmQVpJQndRQ0FCTGhFZXpZMkdnQ09BUUFCQUNjRU1RQm5JME0yR2dGSkZTSVNSRFlhQWtra1dZRUNDRXNCRlJKRU1RQWtKd1JsUkJKRUpDbGxSQ01JS1VzQlp4WWlyNnRNVndJQVNSVkpKUTVFSlV3SnIxQ0FBWFZMQWxCTXYwcUlBZkV5QTA4Q1VFc0JVQ2NKVEZDd0tFeFFzQ05ETmhvQlJ3SVZnUVFTUklBRVRwRTNsaEpBQUNGSmdBUlQ4Q3BBRWtBQUZrbUFCS1Y5VDlzU1FBQUxTWUFFdWNiMmxoSkJBQTBqSndVa1R3SlVLRXhRc0NOREpFTC84RFlhQVVrVkloSkVLa3hRdmtRb1RGQ3dJME0yR2dGSkZTSVNSSUFCZFV4UXZrUW9URkN3STBNa0tXVkVGaUt2cXloTVVMQWpRellhQVVrVkloSkVKQ2xsUkJaTEFhVkVKd2FnU1JVaURrUWlyNnNvVEZDd0kwTTJHZ0ZKRlNJU1JDY0hURkMrSndwT0FrMG9URkN3STBNMkdnRkpGU0lTUkN0TVVESURUTDVOS0V4UXNDTkROaG9CU1JVaUVrUTJHZ0pKRlNJU1JGQUJKd2hNVUw0bkJVNENUU2hNVUxBalF6WWFBVWtWSWhKRU5ob0NTUlVpRWtRcVN3RlF2a1F4QUVzQkVrUXJTd0pRU3dPL1R3SlFURkNBQklXaTV1Qk1VTEFqUXpZYUFVa1ZJaEpFTmhvQ1NSVWpFa1F4QUVzQ1VBRW5DRXhRU3dHL01RQlBBbEJNVUlBRVRFM3JxMHhRc0NORE5ob0JSd0lWSWhKRU5ob0NTVTRERlNJU1JEWWFBMGxPQWtrVkloSkVLa3hRdmtSTEFSSkVNUUFTUVFBNUkwUW5CMDhDU1U0Q1VFbStSQ2NHb1VrVklnNUVJcStydnpJREswOERTVTREVUV5L1R3SkpTd0tJQURWUEFreFFURkFuQ1V4UXNDTkRLMHNCVURJRFRMNU5NUUFTUVFBRUkwTC90VXNCTVFCUUFTY0lURkMrSndWT0FrMGtVMEwvb0lvQ0FDcUwvMUNML3I4bkI0ditVQ0t2U3dHK0p3cE9BazBuQnFCSkZTSU9SS3UvaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJhcmM3Ml9UcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImFyYzcyX0FwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiYXJjNzJfQXBwcm92YWxGb3JBbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
