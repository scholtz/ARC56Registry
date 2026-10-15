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

namespace Arc56.Generated.Marshal_AM.x500_algorand.X500Registry_681c6e68
{


    public class X500RegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public X500RegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EndpointRecord : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public ulong FlatPremiumMicroAlgos { get; set; }

                public ushort PercentBps { get; set; }

                public uint SlaLatencyMs { get; set; }

                public ulong ImputedCostMicroAlgos { get; set; }

                public ulong ApiPriceMicroUsdc { get; set; }

                public byte FeeRecipientCount { get; set; }

                public bool Paused { get; set; }

                public string Hostname { get; set; }

                public Algorand.Address ContactAddress { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlatPremiumMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFlatPremiumMicroAlgos.From(FlatPremiumMicroAlgos);
                    ret.AddRange(vFlatPremiumMicroAlgos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPercentBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vPercentBps.From(PercentBps);
                    ret.AddRange(vPercentBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSlaLatencyMs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vSlaLatencyMs.From(SlaLatencyMs);
                    ret.AddRange(vSlaLatencyMs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vImputedCostMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vImputedCostMicroAlgos.From(ImputedCostMicroAlgos);
                    ret.AddRange(vImputedCostMicroAlgos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApiPriceMicroUsdc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApiPriceMicroUsdc.From(ApiPriceMicroUsdc);
                    ret.AddRange(vApiPriceMicroUsdc.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeRecipientCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vFeeRecipientCount.From(FeeRecipientCount);
                    ret.AddRange(vFeeRecipientCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaused = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPaused.From(Paused);
                    ret.AddRange(vPaused.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHostname = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vHostname.From(Hostname);
                    stringRef[ret.Count] = vHostname.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vContactAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vContactAddress.From(ContactAddress);
                    ret.AddRange(vContactAddress.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EndpointRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EndpointRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlatPremiumMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFlatPremiumMicroAlgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFlatPremiumMicroAlgos = vFlatPremiumMicroAlgos.ToValue();
                    if (valueFlatPremiumMicroAlgos is ulong vFlatPremiumMicroAlgosValue) { ret.FlatPremiumMicroAlgos = vFlatPremiumMicroAlgosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPercentBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vPercentBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePercentBps = vPercentBps.ToValue();
                    if (valuePercentBps is ushort vPercentBpsValue) { ret.PercentBps = vPercentBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSlaLatencyMs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vSlaLatencyMs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSlaLatencyMs = vSlaLatencyMs.ToValue();
                    if (valueSlaLatencyMs is uint vSlaLatencyMsValue) { ret.SlaLatencyMs = vSlaLatencyMsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vImputedCostMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vImputedCostMicroAlgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueImputedCostMicroAlgos = vImputedCostMicroAlgos.ToValue();
                    if (valueImputedCostMicroAlgos is ulong vImputedCostMicroAlgosValue) { ret.ImputedCostMicroAlgos = vImputedCostMicroAlgosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApiPriceMicroUsdc = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApiPriceMicroUsdc.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApiPriceMicroUsdc = vApiPriceMicroUsdc.ToValue();
                    if (valueApiPriceMicroUsdc is ulong vApiPriceMicroUsdcValue) { ret.ApiPriceMicroUsdc = vApiPriceMicroUsdcValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeRecipientCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vFeeRecipientCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeeRecipientCount = vFeeRecipientCount.ToValue();
                    if (valueFeeRecipientCount is byte vFeeRecipientCountValue) { ret.FeeRecipientCount = vFeeRecipientCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaused = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPaused.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePaused = vPaused.ToValue();
                    if (valuePaused is bool vPausedValue) { ret.Paused = vPausedValue; }
                    var indexHostname = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHostname = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vHostname.Decode(bytes.Skip(indexHostname + prefixOffset).ToArray());
                    var valueHostname = vHostname.ToValue();
                    if (valueHostname is string vHostnameValue) { ret.Hostname = vHostnameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vContactAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vContactAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueContactAddress = vContactAddress.ToValue();
                    if (valueContactAddress is Algorand.Address vContactAddressValue) { ret.ContactAddress = vContactAddressValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EndpointRecord);
                }
                public bool Equals(EndpointRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EndpointRecord left, EndpointRecord right)
                {
                    return EqualityComparer<EndpointRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(EndpointRecord left, EndpointRecord right)
                {
                    return !(left == right);
                }

            }

            public class GetEndpointReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ushort Field4 { get; set; }

                public uint Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

                public byte Field8 { get; set; }

                public string Field9 { get; set; }

                public Algorand.Address Field10 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField9.From(Field9);
                    stringRef[ret.Count] = vField9.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField10.From(Field10);
                    ret.AddRange(vField10.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetEndpointReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetEndpointReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ushort vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is uint vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is ulong vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is byte vField8Value) { ret.Field8 = vField8Value; }
                    var indexField9 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField9.Decode(bytes.Skip(indexField9 + prefixOffset).ToArray());
                    var valueField9 = vField9.ToValue();
                    if (valueField9 is string vField9Value) { ret.Field9 = vField9Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField10.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField10 = vField10.ToValue();
                    if (valueField10 is Algorand.Address vField10Value) { ret.Field10 = vField10Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetEndpointReturn);
                }
                public bool Equals(GetEndpointReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetEndpointReturn left, GetEndpointReturn right)
                {
                    return EqualityComparer<GetEndpointReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetEndpointReturn left, GetEndpointReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="slug"> </param>
        /// <param name="hostname"> </param>
        /// <param name="apiPriceMicroUsdc"> </param>
        /// <param name="contactAddress"> </param>
        /// <param name="slaLatencyMs"> </param>
        public async Task RegisterEndpoint(byte[] slug, string hostname, ulong apiPriceMicroUsdc, Algorand.Address contactAddress, uint slaLatencyMs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 239, 227, 34 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var hostnameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hostnameAbi.From(hostname);
            var apiPriceMicroUsdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); apiPriceMicroUsdcAbi.From(apiPriceMicroUsdc);
            var contactAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contactAddressAbi.From(contactAddress);
            var slaLatencyMsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); slaLatencyMsAbi.From(slaLatencyMs);

            var result = await base.CallApp(new List<object> { abiHandle, slugAbi, hostnameAbi, apiPriceMicroUsdcAbi, contactAddressAbi, slaLatencyMsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterEndpoint_Transactions(byte[] slug, string hostname, ulong apiPriceMicroUsdc, Algorand.Address contactAddress, uint slaLatencyMs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 239, 227, 34 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var hostnameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hostnameAbi.From(hostname);
            var apiPriceMicroUsdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); apiPriceMicroUsdcAbi.From(apiPriceMicroUsdc);
            var contactAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contactAddressAbi.From(contactAddress);
            var slaLatencyMsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); slaLatencyMsAbi.From(slaLatencyMs);

            return await base.MakeTransactionList(new List<object> { abiHandle, slugAbi, hostnameAbi, apiPriceMicroUsdcAbi, contactAddressAbi, slaLatencyMsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="slug"> </param>
        public async Task<Structs.GetEndpointReturn> GetEndpoint(byte[] slug, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 27, 180, 229 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);

            var result = await base.SimApp(new List<object> { abiHandle, slugAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetEndpointReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEndpoint_Transactions(byte[] slug, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 27, 180, 229 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);

            return await base.MakeTransactionList(new List<object> { abiHandle, slugAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> SlugCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 162, 145, 9 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SlugCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 162, 145, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task<byte[]> SlugAt(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 232, 2, 153 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.SimApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> SlugAt_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 232, 2, 153 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> ProtocolPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 175, 64, 247 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProtocolPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 175, 64, 247 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="slug"> </param>
        /// <param name="slaLatencyMs"> </param>
        public async Task SetEndpointSla(byte[] slug, uint slaLatencyMs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 200, 126, 14 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var slaLatencyMsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); slaLatencyMsAbi.From(slaLatencyMs);

            var result = await base.CallApp(new List<object> { abiHandle, slugAbi, slaLatencyMsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEndpointSla_Transactions(byte[] slug, uint slaLatencyMs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 200, 126, 14 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var slaLatencyMsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); slaLatencyMsAbi.From(slaLatencyMs);

            return await base.MakeTransactionList(new List<object> { abiHandle, slugAbi, slaLatencyMsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="slug"> </param>
        /// <param name="hostname"> </param>
        /// <param name="apiPriceMicroUsdc"> </param>
        /// <param name="contactAddress"> </param>
        public async Task UpdateEndpoint(byte[] slug, string hostname, ulong apiPriceMicroUsdc, Algorand.Address contactAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 217, 215, 211 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var hostnameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hostnameAbi.From(hostname);
            var apiPriceMicroUsdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); apiPriceMicroUsdcAbi.From(apiPriceMicroUsdc);
            var contactAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contactAddressAbi.From(contactAddress);

            var result = await base.CallApp(new List<object> { abiHandle, slugAbi, hostnameAbi, apiPriceMicroUsdcAbi, contactAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateEndpoint_Transactions(byte[] slug, string hostname, ulong apiPriceMicroUsdc, Algorand.Address contactAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 217, 215, 211 };
            var slugAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(16, "byte"); slugAbi.From(slug);
            var hostnameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); hostnameAbi.From(hostname);
            var apiPriceMicroUsdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); apiPriceMicroUsdcAbi.From(apiPriceMicroUsdc);
            var contactAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contactAddressAbi.From(contactAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, slugAbi, hostnameAbi, apiPriceMicroUsdcAbi, contactAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWDUwMFJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkVuZHBvaW50UmVjb3JkIjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZsYXRQcmVtaXVtTWljcm9BbGdvcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwZXJjZW50QnBzIiwidHlwZSI6InVpbnQxNiJ9LHsibmFtZSI6InNsYUxhdGVuY3lNcyIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJpbXB1dGVkQ29zdE1pY3JvQWxnb3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXBpUHJpY2VNaWNyb1VzZGMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmVlUmVjaXBpZW50Q291bnQiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJwYXVzZWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Imhvc3RuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImNvbnRhY3RBZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifV0sIkdldEVuZHBvaW50UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDMyIn0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDgiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDkiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxMCIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InJlZ2lzdGVyX2VuZHBvaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzE2XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNsdWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imhvc3RuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcGlQcmljZU1pY3JvVXNkYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbnRhY3RBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MzIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzbGFMYXRlbmN5TXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2VuZHBvaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzE2XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNsdWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxhZGRyZXNzLHVpbnQ2NCx1aW50MTYsdWludDMyLHVpbnQ2NCx1aW50NjQsdWludDgsc3RyaW5nLGFkZHJlc3MpIiwic3RydWN0IjoiR2V0RW5kcG9pbnRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsdWdfY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsdWdfYXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDhbMTZdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3RvY29sX3BhdXNlZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9lbmRwb2ludF9zbGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMTZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2x1ZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDMyIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2xhTGF0ZW5jeU1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9lbmRwb2ludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFsxNl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzbHVnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob3N0bmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBpUHJpY2VNaWNyb1VzZGMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb250YWN0QWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUwNF0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODksMjU2LDQ3Myw0OTMsNTE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQwLDM0NywzNTIsMzYwLDM2NywzNzMsMzgwLDM4Nyw0MTQsNTU4LDU2NCw2MjNdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk3XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIHJhbmdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4LDU4MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1Niw1ODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyLDI4Miw1MzYsNTc1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDE2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3Niw2MDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1LDU0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQzMiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2Nyw0ODgsNTk3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYwLDYyNV0sImVycm9yTWVzc2FnZSI6Im5vdCBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1MSw2MTFdLCJlcnJvck1lc3NhZ2UiOiJub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MV0sImVycm9yTWVzc2FnZSI6InByb3RvY29sIHBhdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OF0sImVycm9yTWVzc2FnZSI6InNsdWcgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luTnNkV2REYjNWdWRDSWdNSGd4TlRGbU4yTTNOU0FpY0hKdmRHOWpiMnhRWVhWelpXUWlJREI0TURBd01DQWlhV1I0SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCemJIVm5RMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6YkhWblEyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2NISnZkRzlqYjJ4UVlYVnpaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ptRnNjMlVnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKd2NtOTBiMk52YkZCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmtaV1poZFd4MElHTnNZWE56SUZnMU1EQlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TmdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0Tm1abFptVXpNaklnTUhneE1URmlZalJsTlNBd2VHWmlZVEk1TVRBNUlEQjRaRE5sT0RBeU9Ua2dNSGd3Tm1GbU5EQm1OeUF3ZURVMVl6ZzNaVEJsSURCNE16UmtPV1EzWkRNZ0x5OGdiV1YwYUc5a0lDSnlaV2RwYzNSbGNsOWxibVJ3YjJsdWRDaDFhVzUwT0ZzeE5sMHNjM1J5YVc1bkxIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUXpNaWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmWlc1a2NHOXBiblFvZFdsdWREaGJNVFpkS1NoaWIyOXNMR0p2YjJ3c1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWRERTJMSFZwYm5Rek1peDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTRMSE4wY21sdVp5eGhaR1J5WlhOektTSXNJRzFsZEdodlpDQWljMngxWjE5amIzVnVkQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p6YkhWblgyRjBLSFZwYm5RMk5DbDFhVzUwT0ZzeE5sMGlMQ0J0WlhSb2IyUWdJbkJ5YjNSdlkyOXNYM0JoZFhObFpDZ3BZbTl2YkNJc0lHMWxkR2h2WkNBaWMyVjBYMlZ1WkhCdmFXNTBYM05zWVNoMWFXNTBPRnN4Tmwwc2RXbHVkRE15S1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOWxibVJ3YjJsdWRDaDFhVzUwT0ZzeE5sMHNjM1J5YVc1bkxIVnBiblEyTkN4aFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J5WldkcGMzUmxja1Z1WkhCdmFXNTBJR2RsZEVWdVpIQnZhVzUwSUhOc2RXZERiM1Z1ZEUxbGRHaHZaQ0J6YkhWblFYUk5aWFJvYjJRZ2NISnZkRzlqYjJ4UVlYVnpaV1JOWlhSb2IyUWdjMlYwUlc1a2NHOXBiblJUYkdFZ2RYQmtZWFJsUlc1a2NHOXBiblFLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UWTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklGZzFNREJTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwWU5UQXdVbVZuYVhOMGNua3VjbVZuYVhOMFpYSkZibVJ3YjJsdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWjJsemRHVnlSVzVrY0c5cGJuUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnVZVzFsT2lBaWNtVm5hWE4wWlhKZlpXNWtjRzlwYm5RaUlIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTVRZK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNeklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0NGMGFHbHpMbkJ5YjNSdlkyOXNVR0YxYzJWa0xuWmhiSFZsTENBaWNISnZkRzlqYjJ3Z2NHRjFjMlZrSWlrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QndjbTkwYjJOdmJGQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtUc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQnliM1J2WTI5c1VHRjFjMlZrSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11Y0hKdmRHOWpiMnhRWVhWelpXUXVkbUZzZFdVc0lDSndjbTkwYjJOdmJDQndZWFZ6WldRaUtUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdjSEp2ZEc5amIyd2djR0YxYzJWa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1bGJtUndiMmx1ZEhNb2MyeDFaeWt1WlhocGMzUnpMQ0FpYzJ4MVp5QmxlR2x6ZEhNaUtUc0tJQ0FnSUdScFp5QTBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnpiSFZuSUdWNGFYTjBjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCdmQyNWxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1pteGhkRkJ5WlcxcGRXMU5hV055YjBGc1oyOXpPaUJFUlVaQlZVeFVYMFpNUVZSZlVGSkZUVWxWVFN3S0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPalV4TFRZeUNpQWdJQ0F2THlCMGFHbHpMbVZ1WkhCdmFXNTBjeWh6YkhWbktTNTJZV3gxWlNBOUlIc0tJQ0FnSUM4dklDQWdiM2R1WlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJR1pzWVhSUWNtVnRhWFZ0VFdsamNtOUJiR2R2Y3pvZ1JFVkdRVlZNVkY5R1RFRlVYMUJTUlUxSlZVMHNDaUFnSUNBdkx5QWdJSEJsY21ObGJuUkNjSE02SUc1bGR5QmhjbU0wTGxWcGJuUXhOaWd3S1N3S0lDQWdJQzh2SUNBZ2MyeGhUR0YwWlc1amVVMXpMQW9nSUNBZ0x5OGdJQ0JwYlhCMWRHVmtRMjl6ZEUxcFkzSnZRV3huYjNNNklFUkZSa0ZWVEZSZlNVMVFWVlJGUkY5RFQxTlVMQW9nSUNBZ0x5OGdJQ0JoY0dsUWNtbGpaVTFwWTNKdlZYTmtZeXdLSUNBZ0lDOHZJQ0FnWm1WbFVtVmphWEJwWlc1MFEyOTFiblE2SUc1bGR5QmhjbU0wTGxWcGJuUTRLREVwTEFvZ0lDQWdMeThnSUNCd1lYVnpaV1E2SUdaaGJITmxMQW9nSUNBZ0x5OGdJQ0JvYjNOMGJtRnRaU3dLSUNBZ0lDOHZJQ0FnWTI5dWRHRmpkRUZrWkhKbGMzTXNDaUFnSUNBdkx5QjlPd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklIQmxjbU5sYm5SQ2NITTZJRzVsZHlCaGNtTTBMbFZwYm5ReE5pZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZOVEV0TmpJS0lDQWdJQzh2SUhSb2FYTXVaVzVrY0c5cGJuUnpLSE5zZFdjcExuWmhiSFZsSUQwZ2V3b2dJQ0FnTHk4Z0lDQnZkMjVsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdabXhoZEZCeVpXMXBkVzFOYVdOeWIwRnNaMjl6T2lCRVJVWkJWVXhVWDBaTVFWUmZVRkpGVFVsVlRTd0tJQ0FnSUM4dklDQWdjR1Z5WTJWdWRFSndjem9nYm1WM0lHRnlZelF1VldsdWRERTJLREFwTEFvZ0lDQWdMeThnSUNCemJHRk1ZWFJsYm1ONVRYTXNDaUFnSUNBdkx5QWdJR2x0Y0hWMFpXUkRiM04wVFdsamNtOUJiR2R2Y3pvZ1JFVkdRVlZNVkY5SlRWQlZWRVZFWDBOUFUxUXNDaUFnSUNBdkx5QWdJR0Z3YVZCeWFXTmxUV2xqY205VmMyUmpMQW9nSUNBZ0x5OGdJQ0JtWldWU1pXTnBjR2xsYm5SRGIzVnVkRG9nYm1WM0lHRnlZelF1VldsdWREZ29NU2tzQ2lBZ0lDQXZMeUFnSUhCaGRYTmxaRG9nWm1Gc2MyVXNDaUFnSUNBdkx5QWdJR2h2YzNSdVlXMWxMQW9nSUNBZ0x5OGdJQ0JqYjI1MFlXTjBRV1JrY21WemN5d0tJQ0FnSUM4dklIMDdDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QnBiWEIxZEdWa1EyOXpkRTFwWTNKdlFXeG5iM002SUVSRlJrRlZURlJmU1UxUVZWUkZSRjlEVDFOVUxBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pVeExUWXlDaUFnSUNBdkx5QjBhR2x6TG1WdVpIQnZhVzUwY3loemJIVm5LUzUyWVd4MVpTQTlJSHNLSUNBZ0lDOHZJQ0FnYjNkdVpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUdac1lYUlFjbVZ0YVhWdFRXbGpjbTlCYkdkdmN6b2dSRVZHUVZWTVZGOUdURUZVWDFCU1JVMUpWVTBzQ2lBZ0lDQXZMeUFnSUhCbGNtTmxiblJDY0hNNklHNWxkeUJoY21NMExsVnBiblF4Tmlnd0tTd0tJQ0FnSUM4dklDQWdjMnhoVEdGMFpXNWplVTF6TEFvZ0lDQWdMeThnSUNCcGJYQjFkR1ZrUTI5emRFMXBZM0p2UVd4bmIzTTZJRVJGUmtGVlRGUmZTVTFRVlZSRlJGOURUMU5VTEFvZ0lDQWdMeThnSUNCaGNHbFFjbWxqWlUxcFkzSnZWWE5rWXl3S0lDQWdJQzh2SUNBZ1ptVmxVbVZqYVhCcFpXNTBRMjkxYm5RNklHNWxkeUJoY21NMExsVnBiblE0S0RFcExBb2dJQ0FnTHk4Z0lDQndZWFZ6WldRNklHWmhiSE5sTEFvZ0lDQWdMeThnSUNCb2IzTjBibUZ0WlN3S0lDQWdJQzh2SUNBZ1kyOXVkR0ZqZEVGa1pISmxjM01zQ2lBZ0lDQXZMeUI5T3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNVEF3TURBMk1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJqYjI1emRDQnBaSGdnUFNCMGFHbHpMbk5zZFdkRGIzVnVkQzUyWVd4MVpUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSE5zZFdkRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTnNkV2REYjNWdWRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWTI5dWMzUWdhV1I0SUQwZ2RHaHBjeTV6YkhWblEyOTFiblF1ZG1Gc2RXVTdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUIwYUdsekxuTnNkV2RCZENocFpIZ3BMblpoYkhWbElEMGdZMnh2Ym1Vb2MyeDFaeWs3Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2MyeDFaMEYwSUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnVTJ4MVp6RTJQaWg3SUd0bGVWQnlaV1pwZURvZ0ltbGtlQ0lnZlNrN0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcFpIZ2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2RHaHBjeTV6YkhWblFYUW9hV1I0S1M1MllXeDFaU0E5SUdOc2IyNWxLSE5zZFdjcE93b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJSFJvYVhNdWMyeDFaME52ZFc1MExuWmhiSFZsSUQwZ2FXUjRJQ3NnVldsdWREWTBLREVwT3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnYzJ4MVowTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWljMngxWjBOdmRXNTBJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCMGFHbHpMbk5zZFdkRGIzVnVkQzUyWVd4MVpTQTlJR2xrZUNBcklGVnBiblEyTkNneEtUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnVZVzFsT2lBaWNtVm5hWE4wWlhKZlpXNWtjRzlwYm5RaUlIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPanBZTlRBd1VtVm5hWE4wY25rdVoyVjBSVzVrY0c5cGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSRmJtUndiMmx1ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc1aGJXVTZJQ0puWlhSZlpXNWtjRzlwYm5RaUxDQnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURFMlBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPamcwQ2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11Wlc1a2NHOXBiblJ6S0hOc2RXY3BMbVY0YVhOMGN5a2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1oyVjBSVzVrY0c5cGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdWSGh1TG5ObGJtUmxjaXdLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnYm1WM0lHRnlZelF1VldsdWRERTJLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvNU5nb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6bzROUzA1TndvZ0lDQWdMeThnY21WMGRYSnVJRnNLSUNBZ0lDOHZJQ0FnWm1Gc2MyVXNDaUFnSUNBdkx5QWdJR1poYkhObExBb2dJQ0FnTHk4Z0lDQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUc1bGR5QmhjbU0wTGxWcGJuUXhOaWd3S1N3S0lDQWdJQzh2SUNBZ2JtVjNJR0Z5WXpRdVZXbHVkRE15S0RBcExBb2dJQ0FnTHk4Z0lDQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnYm1WM0lHRnlZelF1VldsdWREZ29NQ2tzQ2lBZ0lDQXZMeUFnSUNJaUxBb2dJQ0FnTHk4Z0lDQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdYVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TmpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TUFvZ0lDQWdZMjl1WTJGMENncG5aWFJGYm1Sd2IybHVkRjloWm5SbGNsOXBibXhwYm1Wa1gyTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem82V0RVd01GSmxaMmx6ZEhKNUxtZGxkRVZ1WkhCdmFXNTBRRFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQWlaMlYwWDJWdVpIQnZhVzUwSWl3Z2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRVZ1WkhCdmFXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUdWd0xuQmhkWE5sWkN3S0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJNd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QmxjQzV2ZDI1bGNpd0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z1pYQXVabXhoZEZCeVpXMXBkVzFOYVdOeWIwRnNaMjl6TEFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVEExQ2lBZ0lDQXZMeUJsY0M1d1pYSmpaVzUwUW5CekxBb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblJ6SURRd0lESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmxjQzV6YkdGTVlYUmxibU41VFhNc0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkSE1nTkRJZ05Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklHVndMbWx0Y0hWMFpXUkRiM04wVFdsamNtOUJiR2R2Y3l3S0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRFEyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNRGdLSUNBZ0lDOHZJR1Z3TG1Gd2FWQnlhV05sVFdsamNtOVZjMlJqTEFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdOVFFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdaWEF1Wm1WbFVtVmphWEJwWlc1MFEyOTFiblFzQ2lBZ0lDQmthV2NnTndvZ0lDQWdjSFZ6YUdsdWRDQTJNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5QmxjQzVvYjNOMGJtRnRaU3dLSUNBZ0lHUnBaeUE0Q2lBZ0lDQndkWE5vYVc1MGN5QTVPQ0F5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnT1FvZ0lDQWdjSFZ6YUdsdWRDQTVPQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1URUtJQ0FnSUM4dklHVndMbU52Ym5SaFkzUkJaR1J5WlhOekxBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQndkWE5vYVc1MElEWTJDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UQXdMVEV4TWdvZ0lDQWdMeThnY21WMGRYSnVJRnNLSUNBZ0lDOHZJQ0FnZEhKMVpTd0tJQ0FnSUM4dklDQWdaWEF1Y0dGMWMyVmtMQW9nSUNBZ0x5OGdJQ0JsY0M1dmQyNWxjaXdLSUNBZ0lDOHZJQ0FnWlhBdVpteGhkRkJ5WlcxcGRXMU5hV055YjBGc1oyOXpMQW9nSUNBZ0x5OGdJQ0JsY0M1d1pYSmpaVzUwUW5CekxBb2dJQ0FnTHk4Z0lDQmxjQzV6YkdGTVlYUmxibU41VFhNc0NpQWdJQ0F2THlBZ0lHVndMbWx0Y0hWMFpXUkRiM04wVFdsamNtOUJiR2R2Y3l3S0lDQWdJQzh2SUNBZ1pYQXVZWEJwVUhKcFkyVk5hV055YjFWelpHTXNDaUFnSUNBdkx5QWdJR1Z3TG1abFpWSmxZMmx3YVdWdWRFTnZkVzUwTEFvZ0lDQWdMeThnSUNCbGNDNW9iM04wYm1GdFpTd0tJQ0FnSUM4dklDQWdaWEF1WTI5dWRHRmpkRUZrWkhKbGMzTXNDaUFnSUNBdkx5QmRPd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCMWJtTnZkbVZ5SURFeENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOaklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYm1GdFpUb2dJbWRsZEY5bGJtUndiMmx1ZENJc0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpSUdkbGRFVnVaSEJ2YVc1MFgyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qcFlOVEF3VW1WbmFYTjBjbmt1WjJWMFJXNWtjRzlwYm5SQU5Bb0tDaTh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6bzZXRFV3TUZKbFoybHpkSEo1TG5Oc2RXZERiM1Z1ZEUxbGRHaHZaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Oc2RXZERiM1Z1ZEUxbGRHaHZaRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbk5zZFdkRGIzVnVkQzUyWVd4MVpUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSE5zZFdkRGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTnNkV2REYjNWdWRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTnNkV2REYjNWdWRDNTJZV3gxWlRzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYm1GdFpUb2dJbk5zZFdkZlkyOTFiblFpTENCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvNldEVXdNRkpsWjJsemRISjVMbk5zZFdkQmRFMWxkR2h2WkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTnNkV2RCZEUxbGRHaHZaRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQWljMngxWjE5aGRDSXNJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5QmhjM05sY25Rb2FXNWtaWGdnUENCMGFHbHpMbk5zZFdkRGIzVnVkQzUyWVd4MVpTd2dJbWx1WkdWNElHOTFkQ0J2WmlCeVlXNW5aU0lwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2MyeDFaME52ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzJ4MVowTnZkVzUwSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXlOQW9nSUNBZ0x5OGdZWE56WlhKMEtHbHVaR1Y0SUR3Z2RHaHBjeTV6YkhWblEyOTFiblF1ZG1Gc2RXVXNJQ0pwYm1SbGVDQnZkWFFnYjJZZ2NtRnVaMlVpS1RzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJ5WVc1blpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPakV5TlFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWMyeDFaMEYwS0dsdVpHVjRLUzUyWVd4MVpUc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnYzJ4MVowRjBJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dVMngxWnpFMlBpaDdJR3RsZVZCeVpXWnBlRG9nSW1sa2VDSWdmU2s3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pwWkhnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OVlOVEF3VW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TWpVS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTnNkV2RCZENocGJtUmxlQ2t1ZG1Gc2RXVTdDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFeU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzVoYldVNklDSnpiSFZuWDJGMElpd2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdldEVXdNRkpsWjJsemRISjVMbUZzWjI4dWRITTZPbGcxTURCU1pXZHBjM1J5ZVM1d2NtOTBiMk52YkZCaGRYTmxaRTFsZEdodlpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YjNSdlkyOXNVR0YxYzJWa1RXVjBhRzlrT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Y0hKdmRHOWpiMnhRWVhWelpXUXVkbUZzZFdVN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QndjbTkwYjJOdmJGQmhkWE5sWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtUc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQnliM1J2WTI5c1VHRjFjMlZrSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Y0hKdmRHOWpiMnhRWVhWelpXUXVkbUZzZFdVN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXlPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc1aGJXVTZJQ0p3Y205MGIyTnZiRjl3WVhWelpXUWlMQ0J5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6bzZXRFV3TUZKbFoybHpkSEo1TG5ObGRFVnVaSEJ2YVc1MFUyeGhXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFJXNWtjRzlwYm5SVGJHRTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRNMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dibUZ0WlRvZ0luTmxkRjlsYm1Sd2IybHVkRjl6YkdFaUlIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTVRZK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5Rek1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPakV6TmdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVpXNWtjRzlwYm5SektITnNkV2NwTG1WNGFYTjBjeXdnSW01dmRDQnlaV2RwYzNSbGNtVmtJaWs3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JsY0M1dmQyNWxjaXdnSW01dmRDQnZkMjVsY2lJcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXpOeTB4TXpnS0lDQWdJQzh2SUdOdmJuTjBJR1Z3SUQwZ1kyeHZibVVvZEdocGN5NWxibVJ3YjJsdWRITW9jMngxWnlrdWRtRnNkV1VwT3dvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHVndMbTkzYm1WeUxDQWlibTkwSUc5M2JtVnlJaWs3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCbGNDNXZkMjVsY2l3Z0ltNXZkQ0J2ZDI1bGNpSXBPd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdiM2R1WlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNemt0TVRRd0NpQWdJQ0F2THlCbGNDNXpiR0ZNWVhSbGJtTjVUWE1nUFNCemJHRk1ZWFJsYm1ONVRYTTdDaUFnSUNBdkx5QjBhR2x6TG1WdVpIQnZhVzUwY3loemJIVm5LUzUyWVd4MVpTQTlJR05zYjI1bEtHVndLVHNLSUNBZ0lIQjFjMmhwYm5RZ05ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXlaWEJzWVdObElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UTTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYm1GdFpUb2dJbk5sZEY5bGJtUndiMmx1ZEY5emJHRWlJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwWU5UQXdVbVZuYVhOMGNua3VkWEJrWVhSbFJXNWtjRzlwYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWRmJtUndiMmx1ZERvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hORE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdVlXMWxPaUFpZFhCa1lYUmxYMlZ1WkhCdmFXNTBJaUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lERTJQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPakUxTUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVpXNWtjRzlwYm5SektITnNkV2NwTG1WNGFYTjBjeXdnSW01dmRDQnlaV2RwYzNSbGNtVmtJaWs3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5URUtJQ0FnSUM4dklHTnZibk4wSUdWd0lEMGdZMnh2Ym1Vb2RHaHBjeTVsYm1Sd2IybHVkSE1vYzJ4MVp5a3VkbUZzZFdVcE93b2dJQ0FnWkdsbklETUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMWcxTURCU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR1Z3TG05M2JtVnlMQ0FpYm05MElHOTNibVZ5SWlrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12V0RVd01GSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UVXhMVEUxTWdvZ0lDQWdMeThnWTI5dWMzUWdaWEFnUFNCamJHOXVaU2gwYUdsekxtVnVaSEJ2YVc1MGN5aHpiSFZuS1M1MllXeDFaU2s3Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1pYQXViM2R1WlhJc0lDSnViM1FnYjNkdVpYSWlLVHNLSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdWd0xtOTNibVZ5TENBaWJtOTBJRzkzYm1WeUlpazdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQnZkMjVsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDFnMU1EQlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTFNd29nSUNBZ0x5OGdaWEF1YUc5emRHNWhiV1VnUFNCb2IzTjBibUZ0WlRzS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5WU5UQXdVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hOVFFLSUNBZ0lDOHZJR1Z3TG1Gd2FWQnlhV05sVFdsamNtOVZjMlJqSUQwZ1lYQnBVSEpwWTJWTmFXTnliMVZ6WkdNN0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVeUlEVTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZXRFV3TUZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRVMUNpQWdJQ0F2THlCbGNDNWpiMjUwWVdOMFFXUmtjbVZ6Y3lBOUlHTnZiblJoWTNSQlpHUnlaWE56T3dvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOallLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlZTlRBd1VtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5UWUtJQ0FnSUM4dklIUm9hWE11Wlc1a2NHOXBiblJ6S0hOc2RXY3BMblpoYkhWbElEMGdZMnh2Ym1Vb1pYQXBPd29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwxZzFNREJTWldkcGMzUnllUzVoYkdkdkxuUnpPakUwTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHNWhiV1U2SUNKMWNHUmhkR1ZmWlc1a2NHOXBiblFpSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ0NDWUZDWE5zZFdkRGIzVnVkQVFWSDN4MURuQnliM1J2WTI5c1VHRjFjMlZrQWdBQUEybGtlREVZUUFBR0tDSm5LaUpuTVJ0QkFFQXhHUlJFTVJoRWdnY0ViKy9qSWdRUkc3VGxCUHVpa1FrRTArZ0NtUVFHcjBEM0JGWElmZzRFTk5uWDB6WWFBSTRIQUFrQWxBRlpBV1FCZ2dHVEFib0FNUmtVTVJnVUVFTTJHZ0ZKRllFUUVrUTJHZ0pKSWxtQkFnaExBUlVTUkZjQ0FEWWFBMGtWSlJKRUZ6WWFCRWtWSkJKRU5ob0ZTUldCQkJKRUlpcGxSQlJFU3dTOVJRRVVSREVBZ2NDRVBSWlFLMUJNVUlHQXJlSUVGbEJQQWhaUVN3SVZGbGNHQWs4RFVFeUFCQUVBQUdKUVR3SlFURkJMQWJ4SVN3Rk12eUlvWlVSSkZpY0VURkJQQXI4akNDaE1aeU5ETmhvQlJ3SVZnUkFTUkwxRkFVQUFMMGd4QUNJV01RQ0FBUUJQQTFCTEFsQ0FCZ0FBQUFBQUFGQkxBbEJQQWxDQUF3QUFZbEJNVUN0UUtVeFFzQ05EU1lFL0k3b2lVMHNCSWlTNlN3SWtKYm9YU3dPREFpZ0N1a3NFZ3dJcUJMcExCWUV1SmJvWFN3YUJOaVc2RjBzSGdUNGp1a3NJZ3dKaUFyb1hnUUlJU3dtQllrOEN1bGNDQUU4SmdVSWt1b0FCZ0NOUEMxUlBDVkJQQ0JaUVR3ZFFUd1pRVHdVV1VFOEVGbEJQQTFCTEFoVVdWd1lDVHdOUVRJQUNBR0pRVHdKUVRGQkMvM1FpS0dWRUZpbE1VTEFqUXpZYUFVa1ZKUkpFRnlJb1pVUkxBUTFFRmljRVRGQytSQ2xNVUxBalF5SXFaVVNBQVFBaVR3SlVLVXhRc0NORE5ob0JTUldCRUJKRU5ob0NTUldCQkJKRVN3RzlSUUZFTVFCTEFpSWt1aEpFZ1NwTXV5TkROaG9CU1JXQkVCSkVOaG9DU1NKWmdRSUlTd0VWRWtRMkdnTkpGU1VTUkRZYUJFa1ZKQkpFU3dPOVJRRkVTd08rU0V3eEFFc0ZJaVM2RWtSTEFZRkFXVThDSWs4Q1dFOERVRThDWERaTVhFSkxBYnhJdnlORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
