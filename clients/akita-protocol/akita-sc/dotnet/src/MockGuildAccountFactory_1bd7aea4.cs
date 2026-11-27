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

namespace Arc56.Generated.akita_protocol.akita_sc.MockGuildAccountFactory_1bd7aea4
{


    //
    // Production-shaped wallet factory that creates the Guild integration tests' mock ARC-58 wallets.
    //
    public class MockGuildAccountFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockGuildAccountFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NewAccountArgPlugins : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public string Field2 { get; set; }

                public bool Field3 { get; set; }

                public byte Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public Structs.NewAccountArgPluginsField7[] Field7 { get; set; }

                public bool Field8 { get; set; }

                public bool Field9 { get; set; }

                public bool Field10 { get; set; }

                public bool Field11 { get; set; }

                public bool Field12 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    var arrField7 = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NewAccountArgPluginsField7>(x => Structs.NewAccountArgPluginsField7.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrField7.Value = (Field7 ?? Array.Empty<Structs.NewAccountArgPluginsField7>()).ToList();
                    stringRef[ret.Count] = arrField7.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField9.From(Field9);
                    ret.AddRange(vField9.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField10.From(Field10);
                    ret.AddRange(vField10.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField11 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField11.From(Field11);
                    ret.AddRange(vField11.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField12 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField12.From(Field12);
                    ret.AddRange(vField12.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NewAccountArgPlugins Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NewAccountArgPlugins();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is byte vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    var indexField7 = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrField7 = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NewAccountArgPluginsField7>(x => Structs.NewAccountArgPluginsField7.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrField7.Decode(bytes.Skip(indexField7 + prefixOffset).ToArray());
                    ret.Field7 = arrField7.Value.ToArray();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is bool vField8Value) { ret.Field8 = vField8Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField9.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField9 = vField9.ToValue();
                    if (valueField9 is bool vField9Value) { ret.Field9 = vField9Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField10.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField10 = vField10.ToValue();
                    if (valueField10 is bool vField10Value) { ret.Field10 = vField10Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField11 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField11.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField11 = vField11.ToValue();
                    if (valueField11 is bool vField11Value) { ret.Field11 = vField11Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField12 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField12.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField12 = vField12.ToValue();
                    if (valueField12 is bool vField12Value) { ret.Field12 = vField12Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NewAccountArgPlugins);
                }
                public bool Equals(NewAccountArgPlugins? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NewAccountArgPlugins left, NewAccountArgPlugins right)
                {
                    return EqualityComparer<NewAccountArgPlugins>.Default.Equals(left, right);
                }
                public static bool operator !=(NewAccountArgPlugins left, NewAccountArgPlugins right)
                {
                    return !(left == right);
                }

            }

            public class NewAccountArgPluginsField7 : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
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

                public static NewAccountArgPluginsField7 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NewAccountArgPluginsField7();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as NewAccountArgPluginsField7);
                }
                public bool Equals(NewAccountArgPluginsField7? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NewAccountArgPluginsField7 left, NewAccountArgPluginsField7 right)
                {
                    return EqualityComparer<NewAccountArgPluginsField7>.Default.Equals(left, right);
                }
                public static bool operator !=(NewAccountArgPluginsField7 left, NewAccountArgPluginsField7 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="controlledAddress"> </param>
        /// <param name="admin"> </param>
        /// <param name="nickname"> </param>
        /// <param name="referrer"> </param>
        /// <param name="salt"> </param>
        /// <param name="bio"> </param>
        /// <param name="automaticUpdates"> </param>
        /// <param name="extraFunding"> </param>
        /// <param name="assets"> </param>
        /// <param name="plugins"> NewAccountArgPlugins</param>
        public async Task<ulong> NewAccount(PaymentTransaction payment, Algorand.Address controlledAddress, Algorand.Address admin, string nickname, Algorand.Address referrer, byte[] salt, string bio, bool automaticUpdates, ulong extraFunding, ulong[] assets, Structs.NewAccountArgPlugins[] plugins, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 224, 209, 137, 184 };
            var controlledAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlledAddressAbi.From(controlledAddress);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var nicknameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nicknameAbi.From(nickname);
            var referrerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); referrerAbi.From(referrer);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); saltAbi.From(salt);
            var bioAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bioAbi.From(bio);
            var automaticUpdatesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); automaticUpdatesAbi.From(automaticUpdates);
            var extraFundingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); extraFundingAbi.From(extraFunding);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);
            var pluginsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NewAccountArgPlugins>(x => Structs.NewAccountArgPlugins.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; pluginsAbi.From(plugins);

            var result = await base.CallApp(new List<object> { abiHandle, payment, controlledAddressAbi, adminAbi, nicknameAbi, referrerAbi, saltAbi, bioAbi, automaticUpdatesAbi, extraFundingAbi, assetsAbi, pluginsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NewAccount_Transactions(PaymentTransaction payment, Algorand.Address controlledAddress, Algorand.Address admin, string nickname, Algorand.Address referrer, byte[] salt, string bio, bool automaticUpdates, ulong extraFunding, ulong[] assets, Structs.NewAccountArgPlugins[] plugins, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 224, 209, 137, 184 };
            var controlledAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); controlledAddressAbi.From(controlledAddress);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var nicknameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nicknameAbi.From(nickname);
            var referrerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); referrerAbi.From(referrer);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); saltAbi.From(salt);
            var bioAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bioAbi.From(bio);
            var automaticUpdatesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); automaticUpdatesAbi.From(automaticUpdates);
            var extraFundingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); extraFundingAbi.From(extraFunding);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);
            var pluginsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.NewAccountArgPlugins>(x => Structs.NewAccountArgPlugins.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; pluginsAbi.From(plugins);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, controlledAddressAbi, adminAbi, nicknameAbi, referrerAbi, saltAbi, bioAbi, automaticUpdatesAbi, extraFundingAbi, assetsAbi, pluginsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Cost(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 103, 250, 109 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Cost_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 103, 250, 109 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task UpdateWallet(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 226, 47, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateWallet_Transactions(ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 226, 47, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0d1aWxkQWNjb3VudEZhY3RvcnkiLCJkZXNjIjoiUHJvZHVjdGlvbi1zaGFwZWQgd2FsbGV0IGZhY3RvcnkgdGhhdCBjcmVhdGVzIHRoZSBHdWlsZCBpbnRlZ3JhdGlvbiB0ZXN0cycgbW9jayBBUkMtNTggd2FsbGV0cy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTmV3QWNjb3VudEFyZ1BsdWdpbnMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJOZXdBY2NvdW50QXJnUGx1Z2luc0ZpZWxkN1tdIn0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDkiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMTAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMTEiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMTIiLCJ0eXBlIjoiYm9vbCJ9XSwiTmV3QWNjb3VudEFyZ1BsdWdpbnNGaWVsZDciOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVs0XSJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5ld0FjY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRyb2xsZWRBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5pY2tuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmZXJyZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmlvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0b21hdGljVXBkYXRlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXh0cmFGdW5kaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZyxib29sLHVpbnQ4LHVpbnQ2NCx1aW50NjQsKGJ5dGVbNF0sdWludDY0KVtdLGJvb2wsYm9vbCxib29sLGJvb2wsYm9vbClbXSIsInN0cnVjdCI6Ik5ld0FjY291bnRBcmdQbHVnaW5zIiwibmFtZSI6InBsdWdpbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb3N0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVXYWxsZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQxNV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDcsMTMzLDE2MCwxNzUsMjM3LDI1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMsMTM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8c21hcnRfY29udHJhY3RzL2FyYzU4L2FjY291bnQvdHlwZXMudHM6OlBsdWdpbkluc3RhbGw+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTMsMTAxLDEyMCwxMjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0LDE0NTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICh1aW50NjQsdWludDhbMzJdLChsZW4rdXRmOFtdKSxib29sMSx1aW50OCx1aW50NjQsdWludDY0LChsZW4rKHVpbnQ4WzRdLHVpbnQ2NClbXSksYm9vbDEsYm9vbDEsYm9vbDEsYm9vbDEsYm9vbDEpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNyBvZiAodWludDY0LHVpbnQ4WzMyXSwobGVuK3V0ZjhbXSksYm9vbDEsdWludDgsdWludDY0LHVpbnQ2NCwobGVuKyh1aW50OFs0XSx1aW50NjQpW10pLGJvb2wxLGJvb2wxLGJvb2wxLGJvb2wxLGJvb2wxKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyh1aW50NjQsdWludDhbMzJdLChsZW4rdXRmOFtdKSxib29sMSx1aW50OCx1aW50NjQsdWludDY0LChsZW4rKHVpbnQ4WzRdLHVpbnQ2NClbXSksYm9vbDEsYm9vbDEsYm9vbDEsYm9vbDEsYm9vbDEpW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI0LDI0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4Nl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ016SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFoWTJOdmRXNTBMV1poWTNSdmNua3VZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxdlkydEhkV2xzWkVGalkyOTFiblJHWVdOMGIzSjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBM0NpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpUQmtNVGc1WWpnZ01IZzVZalkzWm1FMlpDQXdlREF4WlRJeVpqTm1JQzh2SUcxbGRHaHZaQ0FpYm1WM1FXTmpiM1Z1ZENod1lYa3NZV1JrY21WemN5eGhaR1J5WlhOekxITjBjbWx1Wnl4aFpHUnlaWE56TEdKNWRHVmJNekpkTEhOMGNtbHVaeXhpYjI5c0xIVnBiblEyTkN4MWFXNTBOalJiWFN3b2RXbHVkRFkwTEdGa1pISmxjM01zYzNSeWFXNW5MR0p2YjJ3c2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5Dd29ZbmwwWlZzMFhTeDFhVzUwTmpRcFcxMHNZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ3hpYjI5c0tWdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMjl6ZENncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZYWVd4c1pYUW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdVpYZEJZMk52ZFc1MElHMWhhVzVmWTI5emRGOXliM1YwWlVBMElIVndaR0YwWlZkaGJHeGxkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnZjM1JmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxaFkyTnZkVzUwTFdaaFkzUnZjbmt1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd01EQXdNREF3TURBeVpHTTJZekFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXRmpZMjkxYm5RdFptRmpkRzl5ZVM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTBkMWFXeGtRV05qYjNWdWRFWmhZM1J2Y25rZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6VmpOakZpWVNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgzSnZkWFJsUURnS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFoWTJOdmRXNTBMV1poWTNSdmNua3VZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZV05qYjNWdWRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pFRmpZMjkxYm5SR1lXTjBiM0o1TG01bGQwRmpZMjkxYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHVaWGRCWTJOdmRXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdGalkyOTFiblF0Wm1GamRHOXllUzVoYkdkdkxuUnpPakUzTFRJNUNpQWdJQ0F2THlCdVpYZEJZMk52ZFc1MEtBb2dJQ0FnTHk4Z0lDQndZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0NpQWdJQ0F2THlBZ0lHTnZiblJ5YjJ4c1pXUkJaR1J5WlhOek9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhaRzFwYmpvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ2JtbGphMjVoYldVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ2NtVm1aWEp5WlhJNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lITmhiSFE2SUdKNWRHVnpQRE15UGl3S0lDQWdJQzh2SUNBZ1ltbHZPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJR0YxZEc5dFlYUnBZMVZ3WkdGMFpYTTZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJR1Y0ZEhKaFJuVnVaR2x1WnpvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCaGMzTmxkSE02SUhWcGJuUTJORnRkTEFvZ0lDQWdMeThnSUNCd2JIVm5hVzV6T2lCUWJIVm5hVzVKYm5OMFlXeHNXMTBzQ2lBZ0lDQXZMeUFwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUE0Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncHVaWGRCWTJOdmRXNTBYMlp2Y2w5b1pXRmtaWEpBTVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWhZMk52ZFc1MExXWmhZM1J2Y25rdVlXeG5ieTUwY3pveE55MHlPUW9nSUNBZ0x5OGdibVYzUVdOamIzVnVkQ2dLSUNBZ0lDOHZJQ0FnY0dGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQW9nSUNBZ0x5OGdJQ0JqYjI1MGNtOXNiR1ZrUVdSa2NtVnpjem9nUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWVdSdGFXNDZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJRzVwWTJ0dVlXMWxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJSEpsWm1WeWNtVnlPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0J6WVd4ME9pQmllWFJsY3p3ek1qNHNDaUFnSUNBdkx5QWdJR0pwYnpvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNCaGRYUnZiV0YwYVdOVmNHUmhkR1Z6T2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNCbGVIUnlZVVoxYm1ScGJtYzZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdZWE56WlhSek9pQjFhVzUwTmpSYlhTd0tJQ0FnSUM4dklDQWdjR3gxWjJsdWN6b2dVR3gxWjJsdVNXNXpkR0ZzYkZ0ZExBb2dJQ0FnTHk4Z0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEVUtJQ0FnSUR3S0lDQWdJR0o2SUc1bGQwRmpZMjkxYm5SZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2daVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWm05eUlDaHNaVzRyS0hWcGJuUTJOQ3gxYVc1ME9Gc3pNbDBzS0d4bGJpdDFkR1k0VzEwcExHSnZiMnd4TEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRc0tHeGxiaXNvZFdsdWREaGJORjBzZFdsdWREWTBLVnRkS1N4aWIyOXNNU3hpYjI5c01TeGliMjlzTVN4aWIyOXNNU3hpYjI5c01TbGJYU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0EwTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXlJRzltSUNoMWFXNTBOalFzZFdsdWREaGJNekpkTENoc1pXNHJkWFJtT0Z0ZEtTeGliMjlzTVN4MWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMExDaHNaVzRyS0hWcGJuUTRXelJkTEhWcGJuUTJOQ2xiWFNrc1ltOXZiREVzWW05dmJERXNZbTl2YkRFc1ltOXZiREVzWW05dmJERXBDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElEWTFDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0EyTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTnlCdlppQW9kV2x1ZERZMExIVnBiblE0V3pNeVhTd29iR1Z1SzNWMFpqaGJYU2tzWW05dmJERXNkV2x1ZERnc2RXbHVkRFkwTEhWcGJuUTJOQ3dvYkdWdUt5aDFhVzUwT0ZzMFhTeDFhVzUwTmpRcFcxMHBMR0p2YjJ3eExHSnZiMnd4TEdKdmIyd3hMR0p2YjJ3eExHSnZiMnd4S1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnYm1WM1FXTmpiM1Z1ZEY5bWIzSmZhR1ZoWkdWeVFERUtDbTVsZDBGalkyOTFiblJmWVdaMFpYSmZabTl5UURRNkNpQWdJQ0J3YjNCdUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFlXTmpiM1Z1ZEMxbVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRjdE1qa0tJQ0FnSUM4dklHNWxkMEZqWTI5MWJuUW9DaUFnSUNBdkx5QWdJSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd0tJQ0FnSUM4dklDQWdZMjl1ZEhKdmJHeGxaRUZrWkhKbGMzTTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR0ZrYldsdU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQnVhV05yYm1GdFpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQnlaV1psY25KbGNqb2dRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdjMkZzZERvZ1lubDBaWE04TXpJK0xBb2dJQ0FnTHk4Z0lDQmlhVzg2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWVhWMGIyMWhkR2xqVlhCa1lYUmxjem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ0FnWlhoMGNtRkdkVzVrYVc1bk9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHRnpjMlYwY3pvZ2RXbHVkRFkwVzEwc0NpQWdJQ0F2THlBZ0lIQnNkV2RwYm5NNklGQnNkV2RwYmtsdWMzUmhiR3hiWFN3S0lDQWdJQzh2SUNrNklIVnBiblEyTkNCN0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzloWTJOdmRXNTBMM1I1Y0dWekxuUnpPanBRYkhWbmFXNUpibk4wWVd4c1Bnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV0ZqWTI5MWJuUXRabUZqZEc5eWVTNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmpiMjV6ZENCM1lXeHNaWFFnUFNCamIyMXdhV3hsUVhKak5DaE5iMk5yUjNWcGJHUlhZV3hzWlhRcExtTmhiR3d1WTNKbFlYUmxLSHNnWVhKbmN6b2dXMkZrYldsdVhTQjlLUzVwZEhodUxtTnlaV0YwWldSQmNIQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRWRzYjJKaGJFNTFiVUo1ZEdWVGJHbGpaUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVkc2IySmhiRTUxYlZWcGJuUUtJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxOalFvUXpSRlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9RM2xCUlVGUlFVTkRRMWxHUWxkR2EySlhiSFZFUjBacVpFZHNkbUpzT1dwaU0xWjFaRUV4YkdNeVRubGlNMlJtWWtjNWFtRXlWbXRETW5ob1l6TlNabGxYVGpCaFZ6bDFRa0pWWm1aSVZYaEhSVUZCUTFOcmFscDVjMnBhZVc5cVducEZXa1pGVVhoSFJVVkJaVWxKVVVKQ1pVZGhVa2xGVm01S1IweG5VbGhNT1VoeFFraGpiaXRHUlVVM2RsSkpMMUZVYWxWTWJsVkNUamxLZEZBd1JVTlZUeloxVVZSeWNuaFRaMEpPU2t4a1ZsbEZkakF4T0ZaM1ZGWXpWR2R5UWtaNmNqZFZUVVV4V1dGR2NuZFRabkp1VkZGQ1FrODRVazlSTWtkblEwOUZRVUV3UVVWSlFYTm5SbTVCV1ZWQ2NIZEhOa0ZsVVVOUFFVcGhRVzB3UTJwM1MzZEJkSGRETm5kT1dFRkpRVVY2UjJ4UGNXcFpZVUZKTkVKQlFVVkJUbWh2UWxOU1YwSkpRa3BGUzBWNGJtZENTbXBpTWpVd1kyMDVjMkpIVm10WU1rWnJXa2hLYkdNelRYbERiV05wVVhwWllVRlZhMVpuVTBGVFVrTm9UVnA1U2tST2FHOUNSbE5WVTFKRVdXRkJhRmRDU1VKS1JVNW9iMFJUVTA1YVNrRm9UVVpTU2tWT2FHOUZSbE5KVTFKRVdXRkNVbFZwUld0Uk1rZG5XVlpLVWtwRlRtaHZTRVpUVlZOU1JGbGhRMFZyYWxkWlJVMURlVkZKVkVKVlUxSkVXV0ZEVWxWcFJXdFJNa2RuYjFaSmFFcEZUbWh2VEVaVFNWTlNSRmxoUkVKVmFVVnJVVEpIWnpCV1NXaEtSV2RTVTBsQmNrbHBVWHBaWVVGVmEycFhVMUZKVTNkRlZrVnJVbGhCWjBFeVIyZEtTa1pUVlZOU1FtTXlSMmRPU2taWlJXZEZhMUV5UjJkU1Nra3hhMnREUlhOQ1JsSktSVlozU1VGT2FHOUdSbE5KVTFKRVdXRkNhRlZwUld0Uk1rZG5ZMVpLVWtwRlRtaHZTVVpUVlZOU1JGbGhRMVZyYWxkWlJVMURlVkZKVkVKVlUxSkVXV0ZEYUZWcFJXdFJNa2RuYzFaSmFFcEZUbWh2VFVaVFNWTlNSRmxoUkZKVmFVVnJVVEpIWnpWS1JsTkpVMUpEVGxSUlVVRnpVMGxCUVZSM1NWZFVkMHBSVkVWclZrWnNZMGRCYTNoUlZFbEJRMEZEY0ZGVVJrTkJRVmMxVUVGc1FrcDJSV2hOZGpSRlZtbEJTVUZKYTA1REx6bFJNa2RuUmtwSk1XdHJRMFZ6UWtaU1NrVldkMGxCWjBGR2RWUkdReXRTUTJORlZFWkRkMGxyVFRKSFowVldTbEpLUlU1b2IwTkdXVVZuUld0Uk1rZG5Ua3BKTVd0clEwVjNWa1ZyVTBKTFNXZENkbE5LUkU1b2IwSlRVMDVhU2tGb1RVWlNTa1ZuVTIxSlFXRnZhVkY2V1dGQlZXdHFWMU5SU1ZSQ1ZWTlNSRmxoUVdoWFFrbENTa1ZuVldGSlFWa3JRVVJDVldabVNGVkJRVUZCUVVGQlFVRkJURUZwVVhwWllVRlZhMnBYVTFGSlZFSlZVMUpKUmtocFFVWjBTWGx3YkZKQ1VYRlRkMFp1WjBGRlFVa3dPRU5XU1VGelJsSTVPR1JSUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUpOVlV4QmFWRjZXV0ZCVld0cVYxTlJTVlJDVlZOU1JGbGhRV3RyYWxkWlJWSkRlVkZKVkVKVlUxSkpSa2xwUVVWTFNXdE5Na2RuUmtwR1dVVm5SV3RSYjFSSFpVSlhOR2RCT1hsS1JFNW9iMEpUVTA1YVNrRm9UVVpTU2tWT2FHOURVMU5PV21kVFNVeEtRV2hOUmxKS1JXZFVTMGxCVGxWcFVYcFpZVUZWYTJwWFUxRkpWRUpWVTFKRVdXRkJhMnRxVjFOVlRFcEJhRTFHVWtwRloxUjVTVUZNVVdsUmVsbGhRVkpYUWtsQ1NrVk9hRzlEVTFOT1dtZFRRVXhLUVdoTlJsSktSVTVvYjBSR1UxVlRVa1JaWVVKQ1ZXeEZhMU5DU0c5blFXbERTa1JPYUc5Q1JsbEZaMFZyVTBKSU5HZEJaVk5LUkU1b2IwSlRVbFZzUld0UldFNW9iME5UVTA1YVNrRm9URUZTVlZOU1JtTkRRVVJaWVVFd2EycFhVMUZKVTNkRlZrVnJVbGhCWjBFeVIyZFNTa2t4YTJ0RFJYTkNSbEpLUlZaM1NVRk9hRzlHVTFOT1drcEJhRXhCVWxWVFVreEdUWE5yU2xCQmNrcEJWRXhLUVdkUlUzbEhWWGw1UjBsQlJUWndSMEV6WWtsaGMyaHhRa0p5U1ZGSk4wbENjM2xLUkVsNWFHeFNRMk5GVkVaRGQwbHJUMHRCVVVGcVMxZFdSVWxuWjNCVVIyTnlhUzg1Ym1sUlBUMHBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlZCaFoyVnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTmpOamswWldGaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtHRmtaSEpsYzNNcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdkcGRIaHVJREFnUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWhZMk52ZFc1MExXWmhZM1J2Y25rdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2FYUjRiaTV3WVhsdFpXNTBLSHNnY21WalpXbDJaWEk2SUhkaGJHeGxkQzVoWkdSeVpYTnpMQ0JoYlc5MWJuUTZJRWRzYjJKaGJDNXRhVzVDWVd4aGJtTmxJQ3NnVFc5amExZGhiR3hsZEVaMWJtUnBibWNnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUjFjQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ1oyeHZZbUZzSUUxcGJrSmhiR0Z1WTJVS0lDQWdJSEIxYzJocGJuUWdNakF3TURBd01Bb2dJQ0FnS3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZV05qYjNWdWRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk1UY3RNamtLSUNBZ0lDOHZJRzVsZDBGalkyOTFiblFvQ2lBZ0lDQXZMeUFnSUhCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdLSUNBZ0lDOHZJQ0FnWTI5dWRISnZiR3hsWkVGa1pISmxjM002SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdGa2JXbHVPaUJCWTJOdmRXNTBMQW9nSUNBZ0x5OGdJQ0J1YVdOcmJtRnRaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0J5WldabGNuSmxjam9nUVdOamIzVnVkQ3dLSUNBZ0lDOHZJQ0FnYzJGc2REb2dZbmwwWlhNOE16SStMQW9nSUNBZ0x5OGdJQ0JpYVc4NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ1lYVjBiMjFoZEdsalZYQmtZWFJsY3pvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1pYaDBjbUZHZFc1a2FXNW5PaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR0Z6YzJWMGN6b2dkV2x1ZERZMFcxMHNDaUFnSUNBdkx5QWdJSEJzZFdkcGJuTTZJRkJzZFdkcGJrbHVjM1JoYkd4YlhTd0tJQ0FnSUM4dklDazZJSFZwYm5RMk5DQjdDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZV05qYjNWdWRDMW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pFRmpZMjkxYm5SR1lXTjBiM0o1TG5Wd1pHRjBaVmRoYkd4bGRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpWZGhiR3hsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWhZMk52ZFc1MExXWmhZM1J2Y25rdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2RYQmtZWFJsVjJGc2JHVjBLSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRwT2lCMmIybGtJSHQ5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDSURFWkZFUXhHRUVBTG9JREJPRFJpYmdFbTJmNmJRUUI0aTgvTmhvQWpnTUFJZ0FCQlhvQWdBd1ZIM3gxQUFBQUFBQXR4c0N3STBPQUJFeGNZYm8yR2dDT0FRQUJBQ05ETVJZakNUZ1FJeEpFTmhvQkZTVVNSRFlhQWtrVkpSSkVOaG9EU1NKWkpBaE1GUkpFTmhvRUZTVVNSRFlhQlJVbEVrUTJHZ1pKSWxra0NFd1ZFa1EyR2djVkl4SkVOaG9JRllFSUVrUTJHZ2xKSWxtQkNBc2tDRXdWRWtRMkdncEpJbGxKVGdJa0MweEpGVTRDVndJQUlrbExCUXhCQUV4SkpBdExBa2xQQWxsSlR3VkpUZ1FTUkVzQkZWSkpGVXNCZ1NoWlNZRS9Fa1JMQWt4TEFsSWlXWUZCQ0VzQ2dUeFpTVXNDRWtSUEEweFBBMUlpV1lFTUN5UUlDQWhPQWlNSVF2K3RSZ0pQQWtna0NCSkVzU1N5TllFRHNqU0FCQXVCQVVPeVFvQzhDQXNnQkFFQUFnZ21CUVZoWkcxcGJneGhZM1JwYjI1ZlkyOTFiblFOWlhOamNtOTNYMnh2WTJ0bFpBdHNZWE4wWDJGamRHbHZiZ1FWSDN4MU1SaEFBQWtwSTJjckkyY3FJMmN4R1JSRU1SaEJBSGlDRUFRWGhta1NCRlp5Umk0RVZ5L1I2Z1IzSi9oUkJPNzBTUDBFNDFDNTFBVGZTYlQ5QkFsRHVya0U2NjhVb0FUU1MzVldCTDlOZkZjRTFkMDRLd1JjNisxREJOV0doYThFbjY1MDBBUVR2RVRrTmhvQWpoQUFOQUJDQUxJQlp3R0ZBYWNCdWdIa0FqZ0NXZ0p0QW84Q3NBTGNBdXNEVndDQUJNeHBUcW8yR2dDT0FRQUJBRFlhQVVrVmdTQVNSQ2hNWjRBU1kyOXVkSEp2Ykd4bFpGOWhaR1J5WlhOek1ncG5Ja00yR2dGSkZZRWdFa1FvVEdjaVF6WWFBUlVsRWtRMkdnSVZnU0FTUkRZYUEwa2pXU1FJVEJVU1JEWWFCQlVpRWtRMkdnVVZJaEpFTmhvR0ZTVVNSRFlhQnhVbEVrUTJHZ2hKSTFtQkRBc2tDRXdWRWtRMkdna1ZJaEpFTmhvS0ZTSVNSRFlhQ3hVaUVrUTJHZ3dWSWhKRU5ob05GU0lTUklFVWlBS3lJa00yR2dGSkkxa2tDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUVhOaG9EU1JXQklCSkVOaG9FU1NOWkpBaExBUlVTUkZjQ0FEWWFCUlVpRWtRMkdnWVZJaEpFTmhvSEZTVVNSRFlhQ0JVbEVrUTJHZ2xKSTFtQkRBc2tDRXdWRWtRMkdnb1ZJaEpFTmhvTEZTSVNSRFlhREJVaUVrUTJHZzBWSWhKRU5ob09TUlVpRWtRalUwRUFMRWlBQUU4Q0ZrOENVRXhKRlJaWEJnSk1VRXlBQWdBcVVFeFFnQUZ1VHdKUVNieElUTCtCRllnQ0FDSkRRdi9VTmhvQlNTTlpKQWhMQVJVU1JGY0NBSUFCYmt4UXZrUW5CRXhRc0NKRE5ob0JGU1VTUkRZYUFoV0JJQkpFTmhvRFNTTlpKQWhNRlJKRWdTaUlBYjBpUXpZYUFVa2pXU1FJVEJVU1JJRXBpQUdxSWtNMkdnRkpJMWtrQ0V3VkVrUTJHZ0lWZ1NBU1JJRkdpQUdQZ0F3VkgzeDFBQUFBQUFBQUFBQ3dJa00yR2dGSkkxa2tDRXdWRWtTQlI0Z0JiU01xWlVRVUtrc0JaNEFCQUNOUEFsU0FMQlVmZkhVQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFURkN3SWtNMkdnRkpJMWtrQ0V3VkVrUTJHZ0pKSTFtQkVRc2tDRXdWRWtTQlNJZ0JDaUpETmhvQlNSV0JJQkpFS0V4bmdWdUlBUGNpUXpZYUFVa2pXU1FJVEJVU1JEWWFBa2tqV1lFaUN5UUlUQlVTUklFeWlBRFZJa00yR2dGSkkxa2tDRXdWRWtRMkdnSkpJMWtsQ3lRSVRCVVNSSUU4aUFDMElrTTJHZ0VWZ1NBU1JEWWFBa2tqV1lFZ0N5UUlUQlVTUkRZYUF4VWxFa1EyR2dRVkpSSkVnUjZJQUlnaVF6WWFBUldCSUJKRWdSK0lBSGtpUXpZYUFVa1ZKUkpFRnpZYUFra2pXU1FJU3dFVkVrUlhBZ0EyR2dOSkkxa2tDRXNCRlJKRVZ3SUFOaG9FU1NOWkpBaExBUlVTUkZjQ0FEWWFCVWtqV1NRSVN3RVZFa1N4VExKQ1R3S3lRRXl5UUlFRXNobE1zaGlBQk9xUmdOMnlHcklhZ1FheUVDT3lBYk1pUXlNb1pVUW5CRXhRc0NKRGlnRUFJeWxsUkNJSUtVeG5LNHYvWjRteVFDS3lHWUFFekdsT3FySWFzaHFCQnJJUUlySUJzN2NBUGJGSmNnaEVNZ0dCZ0lsNkNMSUlzZ2Nqc2hBaXNnR3pGb0FFRlI5OGRVeFFzQ05ETmhvQkZZRUlFa1FqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
