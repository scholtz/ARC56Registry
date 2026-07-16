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
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>();
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
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

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
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(); assetsAbi.From(assets);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNhTWFuYWdlclBsdWdpbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJNaW50QXJnQXNzZXRzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDkiLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wVXAiLCJkZXNjIjoiTm8tb3AgbWV0aG9kIHVzZWQgdG8gcG9vbCBhZGRpdGlvbmFsIG9wY29kZSBidWRnZXQgaW50byBhIG1pbnRpbmcgZ3JvdXAuXG5BQkkgc2lnbmF0dXJlOiBgb3BVcCgpdm9pZGAuIENhbGxlcnMgaW52b2tpbmcgYG1pbnRgIG9uIGEgbm9uLXRyaXZpYWxcbmJhdGNoIG5lZWQgbW9yZSB0aGFuIHRoZSBkZWZhdWx0IHBlci1wcm9ncmFtIG9wY29kZSBidWRnZXQgdG8gcGFyc2UgdGhlXG5BQkktZW5jb2RlZCB0dXBsZSBhcnJheTsgYWRkaW5nIGV4dHJhIGFwcCBjYWxscyBhZ2FpbnN0IHRoaXMgbWV0aG9kXG5jb250cmlidXRlcyB+NzAwIGJ1ZGdldCBlYWNoIHRvIHRoZSBncm91cCdzIHBvb2wuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlCYWNrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoc3RyaW5nLHN0cmluZyx1aW50NjQsdWludDY0LGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYm9vbCxzdHJpbmcpW10iLCJzdHJ1Y3QiOiJNaW50QXJnQXNzZXRzIiwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMzUsMzUxXSwiZXJyb3JNZXNzYWdlIjoiRVJSOklQQVkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDZdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5LDI0MSwyNjIsMjgzLDY1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MCw2NDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxzbWFydF9jb250cmFjdHMvYXJjNTgvcGx1Z2lucy9hc2EtbWFuYWdlci90eXBlcy50czo6Q3JlYXRlQXNzZXRQYXJhbXM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxLDYzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSwobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ2NCx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sYm9vbDEsKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKChsZW4rdXRmOFtdKSwobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ2NCx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sYm9vbDEsKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDkgb2YgKChsZW4rdXRmOFtdKSwobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ2NCx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sYm9vbDEsKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKygobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pLHVpbnQ2NCx1aW50NjQsdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLGJvb2wxLChsZW4rdXRmOFtdKSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjcsMjQ5LDI3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdPQ0F4TkRrS0lDQWdJR0o1ZEdWallteHZZMnNnSWlJZ0luTndaVzVrYVc1blgyRmtaSEpsYzNNaUlDSkZVbEk2U1ZCQldTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMkZ6WVMxdFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnpZVTFoYm1GblpYSlFiSFZuYVc0Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGcxTkdSbFpHVXdJREI0TUdSaE16azVNemtnTUhobFlXUTNZelU0T0NBdkx5QnRaWFJvYjJRZ0ltOXdWWEFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTFwYm5Rb2RXbHVkRFkwTEdKdmIyd3NLSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHSnZiMndzYzNSeWFXNW5LVnRkTEhCaGVTbDFhVzUwTmpSYlhTSXNJRzFsZEdodlpDQWlaR1ZzWlhSbEtIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5GdGRLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDI5d1ZYQmZjbTkxZEdWQU5DQnRhVzUwSUdSbGJHVjBaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdWWEJmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHOXdWWEFvS1RvZ2RtOXBaQ0I3SUgwS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdllYTmhMVzFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVhOaFRXRnVZV2RsY2xCc2RXZHBiaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdYM0IxZVdGZmJHbGlMbUZ5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVjl5WldGa1gyUjVibUZ0YVdOZlpXeGxiV1Z1ZENoaGNuSmhlVG9nWW5sMFpYTXNJR2x1WkdWNE9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncGtlVzVoYldsalgyRnljbUY1WDNKbFlXUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1ME9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dOUW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXRDaUFnSUNCelpXeGxZM1FLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9uSmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnM2SUhWcGJuUTJOQ3dnZDJGc2JHVjBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B5Wld0bGVVRmtaSEpsYzNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pNeU5Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdaMWJtTjBhVzl1SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRwT2lCQlkyTnZkVzUwSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3pNallLSUNBZ0lDOHZJR2xtSUNnaGNtVnJaWGxDWVdOcktTQjdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdWVpQnlaV3RsZVVGa1pISmxjM05mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qTXlOd29nSUNBZ0x5OGdjbVYwZFhKdUlFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQnlaWFJ6ZFdJS0NuSmxhMlY1UVdSa2NtVnpjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qTXpNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIZGhiR3hsZEM1aFpHUnlaWE56Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRnpZVTFoYm1GblpYSlFiSFZuYVc0dWJXbHVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xcGJuUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQTRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCa2RYQnVJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ3RNak1LSUNBZ0lDOHZJRzFwYm5Rb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUnpPaUJEY21WaGRHVkJjM05sZEZCaGNtRnRjMXRkTEFvZ0lDQWdMeThnSUNCdFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0S0lDQWdJQzh2SUNrNklIVnBiblEyTkZ0ZElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3B0YVc1MFgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ3RNak1LSUNBZ0lDOHZJRzFwYm5Rb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZERvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJSEpsYTJWNVFtRmphem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWVhOelpYUnpPaUJEY21WaGRHVkJjM05sZEZCaGNtRnRjMXRkTEFvZ0lDQWdMeThnSUNCdFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0S0lDQWdJQzh2SUNrNklIVnBiblEyTkZ0ZElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEVUtJQ0FnSUR3S0lDQWdJR0o2SUcxcGJuUmZZV1owWlhKZlptOXlRRFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURjS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCbWIzSWdLR3hsYmlzb0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cmRYUm1PRnRkS1N4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4aWIyOXNNU3dvYkdWdUszVjBaamhiWFNrcFcxMHBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERTFNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLM1YwWmpoYlhTa3NLR3hsYml0MWRHWTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEdKdmIyd3hMQ2hzWlc0cmRYUm1PRnRkS1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVRVekNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREVnYjJZZ0tDaHNaVzRyZFhSbU9GdGRLU3dvYkdWdUszVjBaamhiWFNrc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc1ltOXZiREVzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVFE1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0E1SUc5bUlDZ29iR1Z1SzNWMFpqaGJYU2tzS0d4bGJpdDFkR1k0VzEwcExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkRGhiTXpKZExHSnZiMnd4TENoc1pXNHJkWFJtT0Z0ZEtTa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCdGFXNTBYMlp2Y2w5b1pXRmtaWEpBTVFvS2JXbHVkRjloWm5SbGNsOW1iM0pBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyRnpZUzF0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd0TWpNS0lDQWdJQzh2SUcxcGJuUW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYTnpaWFJ6T2lCRGNtVmhkR1ZCYzNObGRGQmhjbUZ0YzF0ZExBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNEtJQ0FnSUM4dklDazZJSFZwYm5RMk5GdGRJSHNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4emJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTkwZVhCbGN5NTBjem82UTNKbFlYUmxRWE56WlhSUVlYSmhiWE0rQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lOekF0TWpjekNpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpjeUNpQWdJQ0F2THlCQ2VYUmxjeWhCWW5OMGNtRmpkRUZqWTI5MWJuUkhiRzlpWVd4VGRHRjBaVXRsZVhOVGNHVnVaR2x1WjBGa1pISmxjM01wQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6Y0dWdVpHbHVaMTloWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lOekF0TWpjekNpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9iV0p5VUdGNWJXVnVkQzV5WldObGFYWmxjaUE5UFQwZ2MyVnVaR1Z5TENCRlVsSmZTVTVXUVV4SlJGOVFRVmxOUlU1VUtRb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2JXbHVkRjloWm5SbGNsOWhjM05sY25SQU53b2dJQ0FnWW5sMFpXTmZNaUF2THlBaVJWSlNPa2xRUVZraUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2U1ZCQldRb0tiV2x1ZEY5aFpuUmxjbDloYzNObGNuUkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2h0WW5KUVlYbHRaVzUwTG1GdGIzVnVkQ0E5UFQwZ1IyeHZZbUZzTG1GemMyVjBRM0psWVhSbFRXbHVRbUZzWVc1alpTQXFJR0Z6YzJWMGN5NXNaVzVuZEdnc0lFVlNVbDlKVGxaQlRFbEVYMUJCV1UxRlRsUXBDaUFnSUNCa2FXY2dPUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCbmJHOWlZV3dnUVhOelpYUkRjbVZoZEdWTmFXNUNZV3hoYm1ObENpQWdJQ0JrYVdjZ05nb2dJQ0FnS2dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ0YVc1MFgyRm1kR1Z5WDJGemMyVnlkRUE1Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pGVWxJNlNWQkJXU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcEpVRUZaQ2dwdGFXNTBYMkZtZEdWeVgyRnpjMlZ5ZEVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnYkdWMElHRnpjMlYwYzBOeVpXRjBaV1E2SUhWcGJuUTJORnRkSUQwZ1cxMDdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3Q2lBZ0lDQmlkWEo1SURJeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJtYjNJZ0tHeGxkQ0JwT2lCMWFXNTBOalFnUFNBd095QnBJRHdnWVhOelpYUnpMbXhsYm1kMGFEc2dhU3NyS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBeE1Rb0tiV2x1ZEY5M2FHbHNaVjkwYjNCQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQnRhVzUwWDJGbWRHVnlYM2RvYVd4bFFERTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCOUlEMGdZWE56WlhSelcybGRPd29nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JREV5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpXRmtYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWRYSjVJREkwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmY21WaFpGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWXlBMElDOHZJREUwT1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmY21WaFpGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpXRmtYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pYaDBjbUZqZENBeU1DQXpNZ29nSUNBZ1luVnllU0F5TUFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbFlXUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0JsZUhSeVlXTjBJRFV5SURNeUNpQWdJQ0JpZFhKNUlERTVDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHVjRkSEpoWTNRZ09EUWdNeklLSUNBZ0lHSjFjbmtnTWpFS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpXRmtYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWlhoMGNtRmpkQ0F4TVRZZ016SUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjl5WldGa1gyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdjSFZ6YUdsdWRDQXhNVGcwQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0oxY25rZ01UUUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZoWkY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZeUEwSUM4dklERTBPUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMExUVTVDaUFnSUNBdkx5QmpiMjV6ZENCamNtVmhkR1ZVZUc0Z1BTQnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRU52Ym1acFp5aDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBUbUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwVG1GdFpTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJDd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjeXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbExBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJHY205NlpXNHNDaUFnSUNBdkx5QWdJQ0FnZFhKc0xBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJR2tnUENBb1lYTnpaWFJ6TG14bGJtZDBhQ0F0SURFcElEOGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpJRG9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtRb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMkZ6WVMxdFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUhKbGEyVjVWRzg2SUdrZ1BDQW9ZWE56WlhSekxteGxibWQwYUNBdElERXBJRDhnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56SURvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLUW9nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0E4Q2lBZ0lDQmllaUJ0YVc1MFgzUmxjbTVoY25sZlptRnNjMlZBTVRNS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29LYldsdWRGOTBaWEp1WVhKNVgyMWxjbWRsUURFME9nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXdGxlVlJ2Q2lBZ0lDQmthV2NnTVRNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVlVrd0tJQ0FnSUdScFp5QXhNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWm1GMWJIUkdjbTk2Wlc0S0lDQWdJR1JwWnlBeE9Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkdjbVZsZW1VS0lDQWdJR1JwWnlBeE5nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR1JwWnlBeE53b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxZMmx0WVd4ekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGUnZkR0ZzQ2lBZ0lDQmthV2NnTVRRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVmJtbDBUbUZ0WlFvZ0lDQWdaR2xuSURJeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkMwMU9Bb2dJQ0FnTHk4Z1kyOXVjM1FnWTNKbFlYUmxWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRTVoYldVc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3c0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsTEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlN3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF5d0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBSbkp2ZW1WdUxBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkN3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQnBJRHdnS0dGemMyVjBjeTVzWlc1bmRHZ2dMU0F4S1NBL0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5QTZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMExUVTVDaUFnSUNBdkx5QmpiMjV6ZENCamNtVmhkR1ZVZUc0Z1BTQnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRU52Ym1acFp5aDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBUbUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwVG1GdFpTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJDd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjeXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbExBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJMQW9nSUNBZ0x5OGdJQ0FnSUdSbFptRjFiSFJHY205NlpXNHNDaUFnSUNBdkx5QWdJQ0FnZFhKc0xBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJR2tnUENBb1lYTnpaWFJ6TG14bGJtZDBhQ0F0SURFcElEOGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpJRG9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtRb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjM05sZEVsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJoYzNObGRITkRjbVZoZEdWa0xuQjFjMmdvWTNKbFlYUmxWSGh1TG1OeVpXRjBaV1JCYzNObGRDNXBaQ2s3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWpFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5aGMyRXRiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QmhjM05sZEhORGNtVmhkR1ZrTG5CMWMyZ29ZM0psWVhSbFZIaHVMbU55WldGMFpXUkJjM05sZEM1cFpDazdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1luVnllU0F5TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdllYTmhMVzFoYm1GblpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdabTl5SUNoc1pYUWdhVG9nZFdsdWREWTBJRDBnTURzZ2FTQThJR0Z6YzJWMGN5NXNaVzVuZEdnN0lHa3JLeWtnZXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4TVFvZ0lDQWdZaUJ0YVc1MFgzZG9hV3hsWDNSdmNFQXhNQW9LYldsdWRGOTBaWEp1WVhKNVgyWmhiSE5sUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnY21WclpYbFViem9nYVNBOElDaGhjM05sZEhNdWJHVnVaM1JvSUMwZ01Ta2dQeUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01nT2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBDaUFnSUNCa2FXY2dOZ29nSUNBZ1pHbG5JRGdLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnJaWGxCWkdSeVpYTnpDaUFnSUNCaUlHMXBiblJmZEdWeWJtRnllVjl0WlhKblpVQXhOQW9LYldsdWRGOWhablJsY2w5M2FHbHNaVUF4TmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyRnpZUzF0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd0TWpNS0lDQWdJQzh2SUcxcGJuUW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYTnpaWFJ6T2lCRGNtVmhkR1ZCYzNObGRGQmhjbUZ0YzF0ZExBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNEtJQ0FnSUM4dklDazZJSFZwYm5RMk5GdGRJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNCa2FXY2dNakVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFYTmhUV0Z1WVdkbGNsQnNkV2RwYmk1a1pXeGxkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1U2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5aGMyRXRiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNMVGN4Q2lBZ0lDQXZMeUJrWld4bGRHVW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYTnpaWFJ6T2lCMWFXNTBOalJiWFN3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU56SUtJQ0FnSUM4dklFSjVkR1Z6S0VGaWMzUnlZV04wUVdOamIzVnVkRWRzYjJKaGJGTjBZWFJsUzJWNWMxTndaVzVrYVc1blFXUmtjbVZ6Y3lrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5Od1pXNWthVzVuWDJGa1pISmxjM01pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakkzTUMweU56TUtJQ0FnSUM4dklHTnZibk4wSUZ0emNHVnVaR2x1WjBGa1pISmxjM05DZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5Z0tJQ0FnSUM4dklDQWdkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQkNlWFJsY3loQlluTjBjbUZqZEVGalkyOTFiblJIYkc5aVlXeFRkR0YwWlV0bGVYTlRjR1Z1WkdsdVowRmtaSEpsYzNNcENpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNzcktTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0taR1ZzWlhSbFgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12WVhOaExXMWhibUZuWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHRnpjMlYwY3k1c1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1BBb2dJQ0FnWW5vZ1pHVnNaWFJsWDJGbWRHVnlYM2RvYVd4bFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMkZ6WVMxdFlXNWhaMlZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpVdE9ERUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBRMjl1Wm1sbktIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWTI5dVptbG5RWE56WlhRNklFRnpjMlYwS0dGemMyVjBjMXRwWFNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZyWlhsVWJ6b2dhU0E4SUNoaGMzTmxkSE11YkdWdVozUm9JQzBnTVNrZ1B5QkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTWdPaUJ5Wld0bGVVRmtaSEpsYzNNb2NtVnJaWGxDWVdOckxDQjNZV3hzWlhRcENpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZZWE5oTFcxaGJtRm5aWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnWTI5dVptbG5RWE56WlhRNklFRnpjMlYwS0dGemMyVjBjMXRwWFNrc0NpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OWhjMkV0YldGdVlXZGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUJ5Wld0bGVWUnZPaUJwSUR3Z0tHRnpjMlYwY3k1c1pXNW5kR2dnTFNBeEtTQS9JRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeUE2SUhKbGEyVjVRV1JrY21WemN5aHlaV3RsZVVKaFkyc3NJSGRoYkd4bGRDa0tJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdQQW9nSUNBZ1lub2daR1ZzWlhSbFgzUmxjbTVoY25sZlptRnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDZ3BrWld4bGRHVmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk9nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXdGxlVlJ2Q2lBZ0lDQmthV2NnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTloYzJFdGJXRnVZV2RsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMUxUZ3dDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRU52Ym1acFp5aDdDaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdOdmJtWnBaMEZ6YzJWME9pQkJjM05sZENoaGMzTmxkSE5iYVYwcExBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJR2tnUENBb1lYTnpaWFJ6TG14bGJtZDBhQ0F0SURFcElEOGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpJRG9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtRb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56VXRPREVLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVabWxuUVhOelpYUTZJRUZ6YzJWMEtHRnpjMlYwYzF0cFhTa3NDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFViem9nYVNBOElDaGhjM05sZEhNdWJHVnVaM1JvSUMwZ01Ta2dQeUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01nT2lCeVpXdGxlVUZrWkhKbGMzTW9jbVZyWlhsQ1lXTnJMQ0IzWVd4c1pYUXBDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDJGellTMXRZVzVoWjJWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmhjM05sZEhNdWJHVnVaM1JvT3lCcEt5c3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCa1pXeGxkR1ZmZDJocGJHVmZkRzl3UURJS0NtUmxiR1YwWlY5MFpYSnVZWEo1WDJaaGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5aGMyRXRiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QnlaV3RsZVZSdk9pQnBJRHdnS0dGemMyVjBjeTVzWlc1bmRHZ2dMU0F4S1NBL0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5QTZJSEpsYTJWNVFXUmtjbVZ6Y3loeVpXdGxlVUpoWTJzc0lIZGhiR3hsZENrS0lDQWdJR1JwWnlBMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWTJGc2JITjFZaUJ5Wld0bGVVRmtaSEpsYzNNS0lDQWdJR0lnWkdWc1pYUmxYM1JsY201aGNubGZiV1Z5WjJWQU5nb0taR1ZzWlhSbFgyRm1kR1Z5WDNkb2FXeGxRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5aGMyRXRiV0Z1WVdkbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNMVGN4Q2lBZ0lDQXZMeUJrWld4bGRHVW9DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1lYTnpaWFJ6T2lCMWFXNTBOalJiWFN3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBQUVDQ0pVQkpnTUFFSE53Wlc1a2FXNW5YMkZrWkhKbGMzTUlSVkpTT2tsUVFWa3hHMEVBSmpFWkZFUXhHRVNDQXdTRlRlM2dCQTJqbVRrRTZ0ZkZpRFlhQUk0REFBRUFSZ0lqQUNORE1Sa1VNUmdVRUVPS0FnR0wvbGNDQUl2K0lsbUwveVFMU3dKTVdVc0NGWXYvSXdoSkpBdExCVXhaVHdSUEFnbE5Vb21LQWdHTC9rQUFBeklEaVl2L2NnaEVpU0pIQ0NoSEJEWWFBVWtWSlJKRUZ6WWFBa2tWSXhKRUlsTTJHZ05IQWlKWlNVNENKQXRNU1JWTVZ3SUFJa2xMQlF4QkFHRkhBaVFMU3dOSlR3SlpTVXNIU1U0RUVrUkxBUlZTU1JWTEFTSlpTWUdYQVJKRVN3Sk1Td0pTSWxtQm1RRUlTd0lrV1VsTEFoSkVTd05NU3dOU0lsa2tDQWhMQWlFRVdVbExBaEpFVHdOTVR3TlNJbGtrQ0FnSVJRVWpDRVVCUXYrWVN3TWtDRXNERWtReEZpTUpTVVVMU1RnUUl4SkVTd2dwWlVoSlJSSk1PQWNTUUFBREtyQUFTd2s0Q0RJUFN3WUxFa0FBQXlxd0FJQUNBQUJGRlNKRkMwc0tTd1VNUVFEMFN3VkpTd3hKVGdPSS90MUpJbGxMQVNSWlVsY0NBRVVZU1VzQ2lQN0tTU1JaU3dFaEJGbFNWd0lBUlJGSlN3S0kvcmFCQkZ0RkMwbExBb2orcTRFTVcwVVBTVXNDaVA2Z1Z4UWdSUlJKU3dLSS9wVlhOQ0JGRTBsTEFvaitpbGRVSUVVVlNVc0NpUDUvVjNRZ1JSWkpTd0tJL25TQm9BbFRSUTVMQVlqK2FVa2hCRmxMQVJWU1Z3SUFSUSt4U3dVakNReEJBRlV5QTdJZ1N3MnlKMHNMc2lSTEU3SXNTeEt5SzBzUXNpcExFYklwU3d5eUkwc0lzaUpMRHJJbFN4V3lKa3NQc2dDQkE3SVFJcklCczdROEZrc1ZTU0paSXdnV1Z3WUFYQUJNVUVVVlN3b2pDRVVMUXY4T1N3WkxDSWorSVVML280QUVGUjk4ZFVzVlVMQWpReWcyR2dGSkZTVVNSQmRKTmhvQ1NSVWpFa1FpVTB3MkdnTkpUZ0pKSWxsSlRnTWxDeVFJVEJVU1JDbGxTQ0pKU3dNTVFRQStzVXNEVndJQVN3RkpUZ0lsQzF0RkNFc0RJd2tNUVFBY01nT3lJRXNHc2lGTEFiSUFnUU95RUNLeUFiTkpJd2hGQVVML3hVc0VTd2FJL2FKQy85d2pRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
