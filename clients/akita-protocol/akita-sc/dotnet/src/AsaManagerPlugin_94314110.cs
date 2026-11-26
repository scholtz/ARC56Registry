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

namespace Arc56.Generated.akita_protocol.akita_sc.AsaManagerPlugin_94314110
{


    public class AsaManagerPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AsaManagerPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MintArgAssets : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public Algorand.Address Field4 { get; set; }

                public Algorand.Address Field5 { get; set; }

                public Algorand.Address Field6 { get; set; }

                public Algorand.Address Field7 { get; set; }

                public bool Field8 { get; set; }

                public string Field9 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField9.From(Field9);
                    stringRef[ret.Count] = vField9.Encode();
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

                public static MintArgAssets Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MintArgAssets();
                    uint count = 0;
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is Algorand.Address vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is Algorand.Address vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is Algorand.Address vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is Algorand.Address vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is bool vField8Value) { ret.Field8 = vField8Value; }
                    var indexField9 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField9.Decode(bytes.Skip(indexField9 + prefixOffset).ToArray());
                    var valueField9 = vField9.ToValue();
                    if (valueField9 is string vField9Value) { ret.Field9 = vField9Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MintArgAssets);
                }
                public bool Equals(MintArgAssets? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MintArgAssets left, MintArgAssets right)
                {
                    return EqualityComparer<MintArgAssets>.Default.Equals(left, right);
                }
                public static bool operator !=(MintArgAssets left, MintArgAssets right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///No-op method used to pool additional opcode budget into a minting group.
        ///ABI signature: `opUp()void`. Callers invoking `mint` on a non-trivial
        ///batch need more than the default per-program opcode budget to parse the
        ///ABI-encoded tuple array; adding extra app calls against this method
        ///contributes ~700 budget each to the group's pool.
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="assets"> MintArgAssets</param>
        /// <param name="mbrPayment"> </param>
        public async Task<ulong[]> Mint(PaymentTransaction mbrPayment, ulong wallet, bool rekeyBack, Structs.MintArgAssets[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 13, 163, 153, 57 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.MintArgAssets>(x => Structs.MintArgAssets.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetsAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> Mint_Transactions(PaymentTransaction mbrPayment, ulong wallet, bool rekeyBack, Structs.MintArgAssets[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 13, 163, 153, 57 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.MintArgAssets>(x => Structs.MintArgAssets.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetsAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="assets"> </param>
        public async Task Delete(ulong wallet, bool rekeyBack, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 215, 197, 136 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(ulong wallet, bool rekeyBack, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 215, 197, 136 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNhTWFuYWdlclBsdWdpbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJNaW50QXJnQXNzZXRzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDkiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wVXAiLCJkZXNjIjoiTm8tb3AgbWV0aG9kIHVzZWQgdG8gcG9vbCBhZGRpdGlvbmFsIG9wY29kZSBidWRnZXQgaW50byBhIG1pbnRpbmcgZ3JvdXAuXG5BQkkgc2lnbmF0dXJlOiBgb3BVcCgpdm9pZGAuIENhbGxlcnMgaW52b2tpbmcgYG1pbnRgIG9uIGEgbm9uLXRyaXZpYWxcbmJhdGNoIG5lZWQgbW9yZSB0aGFuIHRoZSBkZWZhdWx0IHBlci1wcm9ncmFtIG9wY29kZSBidWRnZXQgdG8gcGFyc2UgdGhlXG5BQkktZW5jb2RlZCB0dXBsZSBhcnJheTsgYWRkaW5nIGV4dHJhIGFwcCBjYWxscyBhZ2FpbnN0IHRoaXMgbWV0aG9kXG5jb250cmlidXRlcyB+NzAwIGJ1ZGdldCBlYWNoIHRvIHRoZSBncm91cCdzIHBvb2wuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50NjQsdWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCxzdHJpbmcpW10iLCJzdHJ1Y3QiOiJNaW50QXJnQXNzZXRzIiwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNjIsMzc2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjVdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmF0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMiwyNzQsMjk1LDMxNiw2NjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDAsNjU2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL2FyYzU4L3BsdWdpbnMvYXNhLW1hbmFnZXIvdHlwZXMudHM6OkNyZWF0ZUFzc2V0UGFyYW1zPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MSw2NDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAwIG9mICgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pLHVpbnQ2NCx1aW50NjQsdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLGJvb2wxLChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pLHVpbnQ2NCx1aW50NjQsdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLGJvb2wxLChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA5IG9mICgobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pLHVpbnQ2NCx1aW50NjQsdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLGJvb2wxLChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisoKGxlbit1dGY4W10pLChsZW4rdXRmOFtdKSx1aW50NjQsdWludDY0LHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSxib29sMSwobGVuK3V0ZjhbXSkpW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYwLDI4MiwzMDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ0XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0NBeE5Ea0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lrVlNVanBsY25KSmNHRjVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWE5oVFdGdVlXZGxjbEJzZFdkcGJpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TUFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T0RVMFpHVmtaVEFnTUhnd1pHRXpPVGt6T1NBd2VHVmhaRGRqTlRnNElDOHZJRzFsZEdodlpDQWliM0JWY0NncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYldsdWRDaDFhVzUwTmpRc1ltOXZiQ3dvYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZbTl2YkN4emRISnBibWNwVzEwc2NHRjVLWFZwYm5RMk5GdGRJaXdnYldWMGFHOWtJQ0prWld4bGRHVW9kV2x1ZERZMExHSnZiMndzZFdsdWREWTBXMTBwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmIzQlZjRjl5YjNWMFpVQTBJRzFwYm5RZ1pHVnNaWFJsQ2lBZ0lDQmxjbklLQ20xaGFXNWZiM0JWY0Y5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdllYTmhMVzFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdiM0JWY0NncE9pQjJiMmxrSUhzZ2ZRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmMyRk5ZVzVoWjJWeVVHeDFaMmx1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNWtlVzVoYldsalgyRnljbUY1WDNKbFlXUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MEtHRnljbUY1T2lCaWVYUmxjeXdnYVc1a1pYZzZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbVI1Ym1GdGFXTmZZWEp5WVhsZmNtVmhaRjlrZVc1aGJXbGpYMlZzWlcxbGJuUTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzBLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdRR0ZyYVhSaExYQnliM1J2WTI5c0wzQnNkV2RwYmk5bWRXNWpkR2x2Ym5NdWRITTZPbWRsZEVOdmJuUnliMnhzWldSVGNHVnVaR2x1WjBGalkyOTFiblFvZDJGc2JHVjBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BuWlhSRGIyNTBjbTlzYkdWa1UzQmxibVJwYm1kQlkyTnZkVzUwT2dvZ0lDQWdMeThnTGk0dkxpNHZibTlrWlY5dGIyUjFiR1Z6TDBCaGEybDBZUzF3Y205MGIyTnZiQzl3YkhWbmFXNHZablZ1WTNScGIyNXpMblJ6T2pNM0NpQWdJQ0F2THlCbGVIQnZjblFnWm5WdVkzUnBiMjRnWjJWMFEyOXVkSEp2Ykd4bFpGTndaVzVrYVc1blFXTmpiM1Z1ZENoM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUtUb2dRV05qYjNWdWRDQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pveE9TMHlNZ29nSUNBZ0x5OGdZMjl1YzNRZ1czTndaVzVrYVc1blFXUmtjbVZ6YzBKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLQW9nSUNBZ0x5OGdJQ0IzWVd4c1pYUXNDaUFnSUNBdkx5QWdJRUo1ZEdWektFRlNRelU0WDFOUVJVNUVTVTVIWDBGRVJGSkZVMU5mUzBWWktRb2dJQ0FnTHk4Z0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F2THlBdUxpOHVMaTl1YjJSbFgyMXZaSFZzWlhNdlFHRnJhWFJoTFhCeWIzUnZZMjlzTDNCc2RXZHBiaTltZFc1amRHbHZibk11ZEhNNk1qRUtJQ0FnSUM4dklFSjVkR1Z6S0VGU1F6VTRYMU5RUlU1RVNVNUhYMEZFUkZKRlUxTmZTMFZaS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p6Y0dWdVpHbHVaMTloWkdSeVpYTnpJZ29nSUNBZ0x5OGdMaTR2TGk0dmJtOWtaVjl0YjJSMWJHVnpMMEJoYTJsMFlTMXdjbTkwYjJOdmJDOXdiSFZuYVc0dlpuVnVZM1JwYjI1ekxuUnpPakU1TFRJeUNpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVZKRE5UaGZVMUJGVGtSSlRrZGZRVVJFVWtWVFUxOUxSVmtwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pvek9Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSE5sYm1SbGNpNWhkWFJvUVdSa2NtVnpjeUE5UFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUVGU1F6VTRYMFZTVWw5UVRGVkhTVTVmVGs5VVgwRlZWRWhmUVVSRVVpa0tJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFYVjBhRUZrWkhJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1oyVjBRMjl1ZEhKdmJHeGxaRk53Wlc1a2FXNW5RV05qYjNWdWRGOWhablJsY2w5aGMzTmxjblJBTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlUbUYwYUNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KT1lYUm9DZ3BuWlhSRGIyNTBjbTlzYkdWa1UzQmxibVJwYm1kQlkyTnZkVzUwWDJGbWRHVnlYMkZ6YzJWeWRFQXlPZ29nSUNBZ0x5OGdMaTR2TGk0dmJtOWtaVjl0YjJSMWJHVnpMMEJoYTJsMFlTMXdjbTkwYjJOdmJDOXdiSFZuYVc0dlpuVnVZM1JwYjI1ekxuUnpPalF3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZ1WkdWeUNpQWdJQ0J5WlhSemRXSUtDZ292THlCQVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pvNmNtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmphem9nZFdsdWREWTBMQ0IzWVd4c1pYUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbkpsYTJWNVFXUmtjbVZ6Y3pvS0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pveE5ETUtJQ0FnSUM4dklHVjRjRzl5ZENCbWRXNWpkR2x2YmlCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ1FXTmpiM1Z1ZENCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJQzR1THk0dUwyNXZaR1ZmYlc5a2RXeGxjeTlBWVd0cGRHRXRjSEp2ZEc5amIyd3ZjR3gxWjJsdUwyWjFibU4wYVc5dWN5NTBjem94TkRRS0lDQWdJQzh2SUdsbUlDZ2hjbVZyWlhsQ1lXTnJLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSnVlaUJ5Wld0bGVVRmtaSEpsYzNOZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUF1TGk4dUxpOXViMlJsWDIxdlpIVnNaWE12UUdGcmFYUmhMWEJ5YjNSdlkyOXNMM0JzZFdkcGJpOW1kVzVqZEdsdmJuTXVkSE02TVRRMUNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUhKbGRITjFZZ29LY21WclpYbEJaR1J5WlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUM0dUx5NHVMMjV2WkdWZmJXOWtkV3hsY3k5QVlXdHBkR0V0Y0hKdmRHOWpiMnd2Y0d4MVoybHVMMloxYm1OMGFXOXVjeTUwY3pveE5EY0tJQ0FnSUM4dklISmxkSFZ5YmlCM1lXeHNaWFF1WVdSa2NtVnpjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQmMyRk5ZVzVoWjJWeVVHeDFaMmx1TG0xcGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0YVc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0MweU13b2dJQ0FnTHk4Z2JXbHVkQ2dLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBPaUJCY0hCc2FXTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ2NtVnJaWGxDWVdOck9pQmliMjlzWldGdUxBb2dJQ0FnTHk4Z0lDQmhjM05sZEhNNklFTnlaV0YwWlVGemMyVjBVR0Z5WVcxelcxMHNDaUFnSUNBdkx5QWdJRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiZ29nSUNBZ0x5OGdLVG9nZFdsdWREWTBXMTBnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0tiV2x1ZEY5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNExUSXpDaUFnSUNBdkx5QnRhVzUwS0FvZ0lDQWdMeThnSUNCM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJR0Z6YzJWMGN6b2dRM0psWVhSbFFYTnpaWFJRWVhKaGJYTmJYU3dLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1Q2lBZ0lDQXZMeUFwT2lCMWFXNTBOalJiWFNCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUJ0YVc1MFgyRm1kR1Z5WDJadmNrQTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdadmNpQW9iR1Z1S3lnb2JHVnVLM1YwWmpoYlhTa3NLR3hsYml0MWRHWTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEdKdmIyd3hMQ2hzWlc0cmRYUm1PRnRkS1NsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UVXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEQWdiMllnS0Noc1pXNHJkWFJtT0Z0ZEtTd29iR1Z1SzNWMFpqaGJYU2tzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzWW05dmJERXNLR3hsYml0MWRHWTRXMTBwS1FvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F4TlRNS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNU0J2WmlBb0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cmRYUm1PRnRkS1N4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4aWIyOXNNU3dvYkdWdUszVjBaamhiWFNrcENpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTkNBdkx5QXhORGtLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRGtnYjJZZ0tDaHNaVzRyZFhSbU9GdGRLU3dvYkdWdUszVjBaamhiWFNrc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc1ltOXZiREVzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnYldsdWRGOW1iM0pmYUdWaFpHVnlRREVLQ20xcGJuUmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQndiM0J1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyRnpZUzF0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd0TWpNS0lDQWdJQzh2SUcxcGJuUW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYTnpaWFJ6T2lCRGNtVmhkR1ZCYzNObGRGQmhjbUZ0YzF0ZExBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNEtJQ0FnSUM4dklDazZJSFZwYm5RMk5GdGRJSHNLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdllYTmhMVzFoYm1GblpYSXZkSGx3WlhNdWRITTZPa055WldGMFpVRnpjMlYwVUdGeVlXMXpQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMENpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0JuWlhSRGIyNTBjbTlzYkdWa1UzQmxibVJwYm1kQlkyTnZkVzUwS0hkaGJHeGxkQ2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRzFpY2xCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwOUlITmxibVJsY2l3Z1pYSnlTVzUyWVd4cFpGQmhlVzFsYm5RcENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCdGFXNTBYMkZtZEdWeVgyRnpjMlZ5ZEVBM0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKRlVsSTZaWEp5U1hCaGVTSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSkpjR0Y1Q2dwdGFXNTBYMkZtZEdWeVgyRnpjMlZ5ZEVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHMWljbEJoZVcxbGJuUXVZVzF2ZFc1MElEMDlQU0JIYkc5aVlXd3VZWE56WlhSRGNtVmhkR1ZOYVc1Q1lXeGhibU5sSUNvZ1lYTnpaWFJ6TG14bGJtZDBhQ3dnWlhKeVNXNTJZV3hwWkZCaGVXMWxiblFwQ2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHZHNiMkpoYkNCQmMzTmxkRU55WldGMFpVMXBia0poYkdGdVkyVUtJQ0FnSUdScFp5QXlDaUFnSUNBcUNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUcxcGJuUmZZV1owWlhKZllYTnpaWEowUURrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtWU1VqcGxjbkpKY0dGNUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrbHdZWGtLQ20xcGJuUmZZV1owWlhKZllYTnpaWEowUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJzWlhRZ1lYTnpaWFJ6UTNKbFlYUmxaRG9nZFdsdWREWTBXMTBnUFNCYlhUc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyRnpZUzF0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JoYzNObGRITXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2dwdGFXNTBYM2RvYVd4bFgzUnZjRUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyRnpZUzF0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JoYzNObGRITXViR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR1IxY0RJS0lDQWdJRHdLSUNBZ0lHSjZJRzFwYm5SZllXWjBaWEpmZDJocGJHVkFNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklIMGdQU0JoYzNObGRITmJhVjA3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVmhaRjlrZVc1aGJXbGpYMlZzWlcxbGJuUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOTJaWElnTndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbFlXUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TkRrS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOTJaWElnTndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbFlXUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmpiM1psY2lBM0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVmhaRjlrZVc1aGJXbGpYMlZzWlcxbGJuUUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JqYjNabGNpQTNDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHVjRkSEpoWTNRZ01qQWdNeklLSUNBZ0lHTnZkbVZ5SURZS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpXRmtYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWlhoMGNtRmpkQ0ExTWlBek1nb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYM0psWVdSZlpIbHVZVzFwWTE5bGJHVnRaVzUwQ2lBZ0lDQmxlSFJ5WVdOMElEZzBJRE15Q2lBZ0lDQmpiM1psY2lBMkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVmhaRjlrZVc1aGJXbGpYMlZzWlcxbGJuUUtJQ0FnSUdWNGRISmhZM1FnTVRFMklETXlDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmY21WaFpGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJSEIxYzJocGJuUWdNVEU0TkFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYM0psWVdSZlpIbHVZVzFwWTE5bGJHVnRaVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QXhORGtLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkMwMU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTNKbFlYUmxWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRTVoYldVc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3c0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsTEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlN3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF5d0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBSbkp2ZW1WdUxBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkN3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnBJRHdnS0dGemMyVjBjeTVzWlc1bmRHZ2dMU0F4S1NBL0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5QTZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJ5Wld0bGVWUnZPaUJwSUR3Z0tHRnpjMlYwY3k1c1pXNW5kR2dnTFNBeEtTQS9JRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeUE2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa0tJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdQQW9nSUNBZ1lub2diV2x1ZEY5MFpYSnVZWEo1WDJaaGJITmxRREV6Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtDbTFwYm5SZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TkRvS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WclpYbFVid29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZTVEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVSbFptRjFiSFJHY205NlpXNEtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkRiR0YzWW1GamF3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUm5KbFpYcGxDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSU1pYTmxjblpsQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldOcGJXRnNjd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJPWVcxbENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EUXROVGdLSUNBZ0lDOHZJR052Ym5OMElHTnlaV0YwWlZSNGJpQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJPWVcxbExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhST1lXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6TEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpTd0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnNzQ2lBZ0lDQXZMeUFnSUNBZ1pHVm1ZWFZzZEVaeWIzcGxiaXdLSUNBZ0lDOHZJQ0FnSUNCMWNtd3NDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFViem9nYVNBOElDaGhjM05sZEhNdWJHVnVaM1JvSUMwZ01Ta2dQeUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01nT2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdllYTmhMVzFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOQzAxT1FvZ0lDQWdMeThnWTI5dWMzUWdZM0psWVhSbFZIaHVJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSRGIyNW1hV2NvZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEU1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRFNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3dzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNpd0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaU3dLSUNBZ0lDOHZJQ0FnSUNCamJHRjNZbUZqYXl3S0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFJuSnZlbVZ1TEFvZ0lDQWdMeThnSUNBZ0lIVnliQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCcElEd2dLR0Z6YzJWMGN5NXNaVzVuZEdnZ0xTQXhLU0EvSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lBNklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1lYTnpaWFJ6UTNKbFlYUmxaQzV3ZFhOb0tHTnlaV0YwWlZSNGJpNWpjbVZoZEdWa1FYTnpaWFF1YVdRcE93b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1lYTnpaWFJ6UTNKbFlYUmxaQzV3ZFhOb0tHTnlaV0YwWlZSNGJpNWpjbVZoZEdWa1FYTnpaWFF1YVdRcE93b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmhjM05sZEhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JpSUcxcGJuUmZkMmhwYkdWZmRHOXdRREV3Q2dwdGFXNTBYM1JsY201aGNubGZabUZzYzJWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCcElEd2dLR0Z6YzJWMGN5NXNaVzVuZEdnZ0xTQXhLU0EvSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lBNklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaR2xuSURZS0lDQWdJR05oYkd4emRXSWdjbVZyWlhsQlpHUnlaWE56Q2lBZ0lDQmlJRzFwYm5SZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TkFvS2JXbHVkRjloWm5SbGNsOTNhR2xzWlVBeE5qb0tJQ0FnSUhCdmNHNGdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9DMHlNd29nSUNBZ0x5OGdiV2x1ZENnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdjbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0JoYzNObGRITTZJRU55WldGMFpVRnpjMlYwVUdGeVlXMXpXMTBzQ2lBZ0lDQXZMeUFnSUcxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0YmdvZ0lDQWdMeThnS1RvZ2RXbHVkRFkwVzEwZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdllYTmhMVzFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRWE5oVFdGdVlXZGxjbEJzZFdkcGJpNWtaV3hsZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkzTFRjeENpQWdJQ0F2THlCa1pXeGxkR1VvQ2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdZWE56WlhSek9pQjFhVzUwTmpSYlhTd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2MzZGhjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlJRDBnWjJWMFEyOXVkSEp2Ykd4bFpGTndaVzVrYVc1blFXTmpiM1Z1ZENoM1lXeHNaWFFwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU52Ym5SeWIyeHNaV1JUY0dWdVpHbHVaMEZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMkZ6WVMxdFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCaGMzTmxkSE11YkdWdVozUm9PeUJwS3lzcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncGtaV3hsZEdWZmQyaHBiR1ZmZEc5d1FESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBOENpQWdJQ0JpZWlCa1pXeGxkR1ZmWVdaMFpYSmZkMmhwYkdWQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlMwNE1Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JqYjI1bWFXZEJjM05sZERvZ1FYTnpaWFFvWVhOelpYUnpXMmxkS1N3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnBJRHdnS0dGemMyVjBjeTVzWlc1bmRHZ2dMU0F4S1NBL0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5QTZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUJqYjI1bWFXZEJjM05sZERvZ1FYTnpaWFFvWVhOelpYUnpXMmxkS1N3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ29LSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5aGMyRXRiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QnlaV3RsZVZSdk9pQnBJRHdnS0dGemMyVjBjeTVzWlc1bmRHZ2dMU0F4S1NBL0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5QTZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJR1JwWnlBMUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1BBb2dJQ0FnWW5vZ1pHVnNaWFJsWDNSbGNtNWhjbmxmWm1Gc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNncGtaV3hsZEdWZmRHVnlibUZ5ZVY5dFpYSm5aVUEyT2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWld0bGVWUnZDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyRnpZUzF0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelV0T0RBS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZMjl1Wm1sblFYTnpaWFE2SUVGemMyVjBLR0Z6YzJWMGMxdHBYU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2FTQThJQ2hoYzNObGRITXViR1Z1WjNSb0lDMGdNU2tnUHlCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNZ09pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlMwNE1Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JqYjI1bWFXZEJjM05sZERvZ1FYTnpaWFFvWVhOelpYUnpXMmxkS1N3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnBJRHdnS0dGemMyVjBjeTVzWlc1bmRHZ2dMU0F4S1NBL0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5QTZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUdGemMyVjBjeTVzWlc1bmRHZzdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdaR1ZzWlhSbFgzZG9hV3hsWDNSdmNFQXlDZ3BrWld4bGRHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnY21WclpYbFViem9nYVNBOElDaGhjM05sZEhNdWJHVnVaM1JvSUMwZ01Ta2dQeUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01nT2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnJaWGxCWkdSeVpYTnpDaUFnSUNCaUlHUmxiR1YwWlY5MFpYSnVZWEo1WDIxbGNtZGxRRFlLQ21SbGJHVjBaVjloWm5SbGNsOTNhR2xzWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTnkwM01Rb2dJQ0FnTHk4Z1pHVnNaWFJsS0FvZ0lDQWdMeThnSUNCM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJR0Z6YzJWMGN6b2dkV2x1ZERZMFcxMHNDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFQ0NKVUJKZ0VMUlZKU09tVnlja2x3WVhreEcwRUFKakVaRkVReEdFU0NBd1NGVGUzZ0JBMmptVGtFNnRmRmlEWWFBSTREQUFFQWVRSkFBQ05ETVJrVU1SZ1VFRU9LQWdHTC9sY0NBSXYrSWxtTC95UUxTd0pNV1VzQ0ZZdi9Jd2hKSkF0TEJVeFpUd1JQQWdsTlVvbUtBUUdMLzRBUWMzQmxibVJwYm1kZllXUmtjbVZ6YzJWSVNYTUNSRElLRWtBQUQ0QUxSVkpTT21WeWNrNWhkR2l3QUltS0FnR0wva0FBQXpJRGlZdi9jZ2hFaVRZYUFVa1ZKUkpFRnpZYUFra1ZJeEpFSWxOTU5ob0RTVTRDU1NKWlNVNENKQXRNU1JWT0FsY0NBQ0pKU3dVTVFRQmVTU1FMU3dKSlR3SlpTVThGU1U0RUVrUkxBUlZTU1JWTEFTSlpTWUdYQVJKRVN3Sk1Td0pTSWxtQm1RRUlTd0lrV1VsTEFoSkVTd05NU3dOU0lsa2tDQWhMQWlFRVdVbExBaEpFVHdOTVR3TlNJbGtrQ0FnSVRnSWpDRUwvbTBZQ0pBZ1NSREVXSXdsSEFqZ1FJeEpFU3dPSS94WkpUZ1ZNT0FjU1FBQURLTEFBT0FneUQwc0NDeEpBQUFNb3NBQ0FBZ0FBVGdJaVRFb01RUURzU3dWSlN3TkpUZ09JL3JsSklsbExBU1JaVWxjQ0FFNEhTVXNDaVA2bVNTUlpTd0VoQkZsU1Z3SUFUZ2RKU3dLSS9wS0JCRnRPQjBsTEFvaitoNEVNVzA0SFNVc0NpUDU4VnhRZ1RnWkpTd0tJL25GWE5DQk9Ca2xMQW9qK1psZFVJRTRHU1VzQ2lQNWJWM1FnVGdOSlN3S0kvbENCb0FsVFRnSkxBWWorUlVraEJGbExBUlZTVndJQVRMRkxBeU1KREVFQVRqSURzaUN5SjdJa1RMSXNUd1N5SzA4RXNpcFBCTElwVHdXeUkwOEZzaUpQQmJJbFR3V3lKa3NFc2dDQkE3SVFJcklCczdROEZrOEVTU0paSXdnV1Z3WUFYQUJNVUU0RFRDTUlURUwvR1VzUVN3YUkvamhDLzZwR0E0QUVGUjk4ZFV4UXNDTkROaG9CU1JVbEVrUVhTVFlhQWtrVkl4SkVJbE5NTmhvRFNVNENTU0paU1U0RUpRc2tDRXdWRWtTSS9ja2lTVXNFREVFQU9MRkxBbGNDQUVzQlNVNENKUXRiVEVzRkl3a01RUUFYTWdPeUlMSWhTd0d5QUlFRHNoQWlzZ0d6SXdoQy84dExCVXNIaVAyL1F2L2hJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
