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

namespace Arc56.Generated.Swarup_git_hub.algo_skillcred.DemoSm_084b8b06
{


    public class DemoSmProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DemoSmProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetRequestReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public string Field2 { get; set; }

                public string Field3 { get; set; }

                public string Field4 { get; set; }

                public string Field5 { get; set; }

                public string Field6 { get; set; }

                public string Field7 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.From(Field4);
                    stringRef[ret.Count] = vField4.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField5.From(Field5);
                    stringRef[ret.Count] = vField5.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField6.From(Field6);
                    stringRef[ret.Count] = vField6.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField7.From(Field7);
                    stringRef[ret.Count] = vField7.Encode();
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

                public static GetRequestReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetRequestReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
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
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    var indexField4 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.Decode(bytes.Skip(indexField4 + prefixOffset).ToArray());
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is string vField4Value) { ret.Field4 = vField4Value; }
                    var indexField5 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField5.Decode(bytes.Skip(indexField5 + prefixOffset).ToArray());
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is string vField5Value) { ret.Field5 = vField5Value; }
                    var indexField6 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField6.Decode(bytes.Skip(indexField6 + prefixOffset).ToArray());
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is string vField6Value) { ret.Field6 = vField6Value; }
                    var indexField7 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField7.Decode(bytes.Skip(indexField7 + prefixOffset).ToArray());
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is string vField7Value) { ret.Field7 = vField7Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetRequestReturn);
                }
                public bool Equals(GetRequestReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetRequestReturn left, GetRequestReturn right)
                {
                    return EqualityComparer<GetRequestReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetRequestReturn left, GetRequestReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="issuer"> </param>
        /// <param name="organization"> </param>
        /// <param name="scope"> </param>
        public async Task RegisterIssuer(Algorand.Address issuer, string organization, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 2, 94, 185 };
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);
            var organizationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationAbi.From(organization);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.CallApp(new List<object> { abiHandle, issuerAbi, organizationAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterIssuer_Transactions(Algorand.Address issuer, string organization, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 2, 94, 185 };
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);
            var organizationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationAbi.From(organization);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, issuerAbi, organizationAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="issuer"> </param>
        /// <param name="active"> </param>
        public async Task UpdateIssuerStatus(Algorand.Address issuer, bool active, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 187, 124, 61 };
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);
            var activeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); activeAbi.From(active);

            var result = await base.CallApp(new List<object> { abiHandle, issuerAbi, activeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateIssuerStatus_Transactions(Algorand.Address issuer, bool active, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 187, 124, 61 };
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);
            var activeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); activeAbi.From(active);

            return await base.MakeTransactionList(new List<object> { abiHandle, issuerAbi, activeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="issuer"> </param>
        public async Task<string> GetIssuerStatus(Algorand.Address issuer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 43, 211, 192 };
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);

            var result = await base.SimApp(new List<object> { abiHandle, issuerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetIssuerStatus_Transactions(Algorand.Address issuer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 43, 211, 192 };
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);

            return await base.MakeTransactionList(new List<object> { abiHandle, issuerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        /// <param name="issuer"> </param>
        /// <param name="certificate_type"> </param>
        /// <param name="certificate_name"> </param>
        /// <param name="certificate_id"> </param>
        /// <param name="organization"> </param>
        /// <param name="evidence_hash"> </param>
        public async Task SubmitVerificationRequest(ulong request_id, Algorand.Address issuer, string certificate_type, string certificate_name, string certificate_id, string organization, string evidence_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 88, 8, 203 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);
            var certificate_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); certificate_typeAbi.From(certificate_type);
            var certificate_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); certificate_nameAbi.From(certificate_name);
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); certificate_idAbi.From(certificate_id);
            var organizationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationAbi.From(organization);
            var evidence_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_hashAbi.From(evidence_hash);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi, issuerAbi, certificate_typeAbi, certificate_nameAbi, certificate_idAbi, organizationAbi, evidence_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitVerificationRequest_Transactions(ulong request_id, Algorand.Address issuer, string certificate_type, string certificate_name, string certificate_id, string organization, string evidence_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 88, 8, 203 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); issuerAbi.From(issuer);
            var certificate_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); certificate_typeAbi.From(certificate_type);
            var certificate_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); certificate_nameAbi.From(certificate_name);
            var certificate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); certificate_idAbi.From(certificate_id);
            var organizationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); organizationAbi.From(organization);
            var evidence_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_hashAbi.From(evidence_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi, issuerAbi, certificate_typeAbi, certificate_nameAbi, certificate_idAbi, organizationAbi, evidence_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task MarkUnderReview(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 214, 60, 217 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkUnderReview_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 214, 60, 217 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        /// <param name="credential_id"> </param>
        public async Task VerifyRequest(ulong request_id, ulong credential_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 165, 180, 156 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var credential_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credential_idAbi.From(credential_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi, credential_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VerifyRequest_Transactions(ulong request_id, ulong credential_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 163, 165, 180, 156 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var credential_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credential_idAbi.From(credential_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi, credential_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task RejectRequest(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 137, 6, 41 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectRequest_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 137, 6, 41 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="credential_id"> </param>
        /// <param name="request_id"> </param>
        public async Task RevokeCredential(ulong credential_id, ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 29, 167, 81 };
            var credential_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credential_idAbi.From(credential_id);
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, credential_idAbi, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeCredential_Transactions(ulong credential_id, ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 29, 167, 81 };
            var credential_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credential_idAbi.From(credential_id);
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, credential_idAbi, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<string> GetRequestStatus(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 212, 116, 247 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetRequestStatus_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 212, 116, 247 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="credential_id"> </param>
        public async Task<string> GetCredentialStatus(ulong credential_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 49, 189, 232 };
            var credential_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credential_idAbi.From(credential_id);

            var result = await base.SimApp(new List<object> { abiHandle, credential_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetCredentialStatus_Transactions(ulong credential_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 49, 189, 232 };
            var credential_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); credential_idAbi.From(credential_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, credential_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<Structs.GetRequestReturn> GetRequest(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 194, 47, 24 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetRequestReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRequest_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 194, 47, 24 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVtb1NtIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFJlcXVlc3RSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDciLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3Rlcl9pc3N1ZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imlzc3VlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfaXNzdWVyX3N0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXNzdWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWN0aXZlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9pc3N1ZXJfc3RhdHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc3N1ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF92ZXJpZmljYXRpb25fcmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXNzdWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZXJ0aWZpY2F0ZV90eXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZXJ0aWZpY2F0ZV9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjZXJ0aWZpY2F0ZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmlkZW5jZV9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtfdW5kZXJfcmV2aWV3IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X3JlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlZGVudGlhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWplY3RfcmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZV9jcmVkZW50aWFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWRlbnRpYWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlcXVlc3Rfc3RhdHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jcmVkZW50aWFsX3N0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVkZW50aWFsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3Msc3RyaW5nLHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcpIiwic3RydWN0IjoiR2V0UmVxdWVzdFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5MzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNyZWRlbnRpYWxfYWN0aXZlIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNzdWVyX3Njb3BlIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlZ2lzdHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcXVlc3RfY2VydGlmaWNhdGVfaWQgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXF1ZXN0X2NlcnRpZmljYXRlX25hbWUgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTkwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXF1ZXN0X2NlcnRpZmljYXRlX3R5cGUgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVxdWVzdF9ldmlkZW5jZV9oYXNoIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4MywxMjU5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXF1ZXN0X2lzc3VlciBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDExXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXF1ZXN0X29yZ2FuaXphdGlvbiBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjMsNzI4LDczNyw3OTYsODA1LDg2NCwxMjkxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXF1ZXN0X3N0YXR1cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcXVlc3Rfc3R1ZGVudCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTgsMjY4LDI4NCw0NDEsNDU3LDQ3Myw0ODksNTA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNSwyNzUsMjkxLDQ0OCw0NjQsNDgwLDQ5Niw1MTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYyLDMzOCwzNzQsNDM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNSw2NDcsNjgwLDY4OSw3ODAsODM0LDg0Myw4OTIsOTE4LDk2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTWlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKeWN5SWdNSGd4TlRGbU4yTTNOU0FpYVdFaUlDSnlhWE56SWlBaVkyRWlJQ0p5WldkcGMzUnllU0lnSW1seklpQWlRVU5VU1ZaRklpQWljbVVpSUNKeWMzUjFJaUFpY21OMGNDSWdJbkpqYm0waUlDSnlZMmxrSWlBaWNtOXlaeUlnSW5KbGRtZ2lJQ0pqWlNJZ0lsSkZWazlMUlVRaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnYzJWc1ppNXlaV2RwYzNSeWVTNTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luSmxaMmx6ZEhKNUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1JHVnRiMU50S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TVFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TURKaVpXTmxNVEVnTUhnM1lUQXlOV1ZpT1NBd2VERXlZbUkzWXpOa0lEQjRNVE15WW1Rell6QWdNSGd5TmpVNE1EaGpZaUF3ZURJeVpEWXpZMlE1SURCNFlUTmhOV0kwT1dNZ01IaG1Zamc1TURZeU9TQXdlRGxoTVdSaE56VXhJREI0WkRsa05EYzBaamNnTUhobFlqTXhZbVJsT0NBd2VEWTBZekl5WmpFNElDOHZJRzFsZEdodlpDQWlhR1ZzYkc4b2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpY21WbmFYTjBaWEpmYVhOemRXVnlLR0ZrWkhKbGMzTXNjM1J5YVc1bkxITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVmZhWE56ZFdWeVgzTjBZWFIxY3loaFpHUnlaWE56TEdKdmIyd3BkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYMmx6YzNWbGNsOXpkR0YwZFhNb1lXUmtjbVZ6Y3lsemRISnBibWNpTENCdFpYUm9iMlFnSW5OMVltMXBkRjkyWlhKcFptbGpZWFJwYjI1ZmNtVnhkV1Z6ZENoMWFXNTBOalFzWVdSa2NtVnpjeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltMWhjbXRmZFc1a1pYSmZjbVYyYVdWM0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZjbVZ4ZFdWemRDaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYW1WamRGOXlaWEYxWlhOMEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhadmEyVmZZM0psWkdWdWRHbGhiQ2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXlaWEYxWlhOMFgzTjBZWFIxY3loMWFXNTBOalFwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSZlkzSmxaR1Z1ZEdsaGJGOXpkR0YwZFhNb2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFgzSmxjWFZsYzNRb2RXbHVkRFkwS1NoaFpHUnlaWE56TEdGa1pISmxjM01zYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYUdWc2JHOGdjbVZuYVhOMFpYSmZhWE56ZFdWeUlIVndaR0YwWlY5cGMzTjFaWEpmYzNSaGRIVnpJR2RsZEY5cGMzTjFaWEpmYzNSaGRIVnpJSE4xWW0xcGRGOTJaWEpwWm1sallYUnBiMjVmY21WeGRXVnpkQ0J0WVhKclgzVnVaR1Z5WDNKbGRtbGxkeUIyWlhKcFpubGZjbVZ4ZFdWemRDQnlaV3BsWTNSZmNtVnhkV1Z6ZENCeVpYWnZhMlZmWTNKbFpHVnVkR2xoYkNCblpYUmZjbVZ4ZFdWemRGOXpkR0YwZFhNZ1oyVjBYMk55WldSbGJuUnBZV3hmYzNSaGRIVnpJR2RsZEY5eVpYRjFaWE4wQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qRTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXMXZYM050TG1OdmJuUnlZV04wTGtSbGJXOVRiUzVvWld4c2IxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWhsYkd4dk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCeVpYUjFjbTRnSWtobGJHeHZMQ0FpSUNzZ2JtRnRaUW9nSUNBZ2NIVnphR0o1ZEdWeklDSklaV3hzYnl3Z0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUbzBPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXMXZYM050TG1OdmJuUnlZV04wTGtSbGJXOVRiUzV5WldkcGMzUmxjbDlwYzNOMVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxjbDlwYzNOMVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QnpaV3htTGw5dmJteDVYM0psWjJsemRISjVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyOXViSGxmY21WbmFYTjBjbmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJ6Wld4bUxtbHpjM1ZsY2w5aFkzUnBkbVZiYVhOemRXVnlYU0E5SUZSeWRXVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltbGhJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCelpXeG1MbWx6YzNWbGNsOXZjbWRoYm1sNllYUnBiMjViYVhOemRXVnlYU0E5SUc5eVoyRnVhWHBoZEdsdmJnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKcGJ5SUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJ6Wld4bUxtbHpjM1ZsY2w5elkyOXdaVnRwYzNOMVpYSmRJRDBnYzJOdmNHVUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltbHpJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJsYlc5ZmMyMHVZMjl1ZEhKaFkzUXVSR1Z0YjFOdExuVndaR0YwWlY5cGMzTjFaWEpmYzNSaGRIVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYMmx6YzNWbGNsOXpkR0YwZFhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklITmxiR1l1WDI5dWJIbGZjbVZuYVhOMGNua29LUW9nSUNBZ1kyRnNiSE4xWWlCZmIyNXNlVjl5WldkcGMzUnllUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBjM04xWlhJZ2FXNGdjMlZzWmk1cGMzTjFaWEpmWVdOMGFYWmxDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnBZU0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z2MyVnNaaTVwYzNOMVpYSmZZV04wYVhabFcybHpjM1ZsY2wwZ1BTQmhZM1JwZG1VS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnRiMTl6YlM1amIyNTBjbUZqZEM1RVpXMXZVMjB1WjJWMFgybHpjM1ZsY2w5emRHRjBkWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZhWE56ZFdWeVgzTjBZWFIxY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdhV1lnYm05MElITmxiR1l1YVhOemRXVnlYMkZqZEdsMlpTNW5aWFFvYVhOemRXVnlMQ0JrWldaaGRXeDBQVVpoYkhObEtUb0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltbGhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSnVlaUJuWlhSZmFYTnpkV1Z5WDNOMFlYUjFjMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKSlRrRkRWRWxXUlNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtsT1FVTlVTVlpGSWdvS1oyVjBYMmx6YzNWbGNsOXpkR0YwZFhOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVaR1Z0YjE5emJTNWpiMjUwY21GamRDNUVaVzF2VTIwdVoyVjBYMmx6YzNWbGNsOXpkR0YwZFhOQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYMmx6YzNWbGNsOXpkR0YwZFhOZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29Ja0ZEVkVsV1JTSXBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSkJRMVJKVmtVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZmFYTnpkV1Z5WDNOMFlYUjFjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1a1pXMXZYM050TG1OdmJuUnlZV04wTGtSbGJXOVRiUzVuWlhSZmFYTnpkV1Z5WDNOMFlYUjFjMEEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiVzlmYzIwdVkyOXVkSEpoWTNRdVJHVnRiMU50TG5OMVltMXBkRjkyWlhKcFptbGpZWFJwYjI1ZmNtVnhkV1Z6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFZbTFwZEY5MlpYSnBabWxqWVhScGIyNWZjbVZ4ZFdWemREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTNDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTV5WlhGMVpYTjBYMlY0YVhOMGN5NW5aWFFvY21WeGRXVnpkRjlwWkN3Z1pHVm1ZWFZzZEQxR1lXeHpaU2tLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWNtVWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YVhOemRXVnlYMkZqZEdsMlpTNW5aWFFvYVhOemRXVnlMQ0JrWldaaGRXeDBQVVpoYkhObEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWFXRWlDaUFnSUNCa2FXY2dPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpjM1ZsY2w5elkyOXdaVnRwYzNOMVpYSmRJRDA5SUdObGNuUnBabWxqWVhSbFgzUjVjR1VLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbWx6SWdvZ0lDQWdaR2xuSURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE56ZFdWeVgzTmpiM0JsSUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklEY0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QnpaV3htTG5KbGNYVmxjM1JmWlhocGMzUnpXM0psY1hWbGMzUmZhV1JkSUQwZ1ZISjFaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxjWFZsYzNSZmMzUmhkSFZ6VzNKbGNYVmxjM1JmYVdSZElEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnljeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBYM04wZFdSbGJuUmJjbVZ4ZFdWemRGOXBaRjBnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p5YzNSMUlnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUhObGJHWXVjbVZ4ZFdWemRGOXBjM04xWlhKYmNtVnhkV1Z6ZEY5cFpGMGdQU0JwYzNOMVpYSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luSnBjM01pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUmZZMlZ5ZEdsbWFXTmhkR1ZmZEhsd1pWdHlaWEYxWlhOMFgybGtYU0E5SUdObGNuUnBabWxqWVhSbFgzUjVjR1VLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0p5WTNSd0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJSE5sYkdZdWNtVnhkV1Z6ZEY5alpYSjBhV1pwWTJGMFpWOXVZVzFsVzNKbGNYVmxjM1JmYVdSZElEMGdZMlZ5ZEdsbWFXTmhkR1ZmYm1GdFpRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0luSmpibTBpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBYMk5sY25ScFptbGpZWFJsWDJsa1czSmxjWFZsYzNSZmFXUmRJRDBnWTJWeWRHbG1hV05oZEdWZmFXUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSnlZMmxrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkRjl2Y21kaGJtbDZZWFJwYjI1YmNtVnhkV1Z6ZEY5cFpGMGdQU0J2Y21kaGJtbDZZWFJwYjI0S0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKeWIzSm5JZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUhObGJHWXVjbVZ4ZFdWemRGOWxkbWxrWlc1alpWOW9ZWE5vVzNKbGNYVmxjM1JmYVdSZElEMGdaWFpwWkdWdVkyVmZhR0Z6YUFvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW5KbGRtZ2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1SbGJXOWZjMjB1WTI5dWRISmhZM1F1UkdWdGIxTnRMbTFoY210ZmRXNWtaWEpmY21WMmFXVjNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldGeWExOTFibVJsY2w5eVpYWnBaWGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdjMlZzWmk1ZmNtVnhkV1Z6ZEY5dGRYTjBYMlY0YVhOMEtISmxjWFZsYzNSZmFXUXBDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDNKbGNYVmxjM1JmYlhWemRGOWxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2T1RrS0lDQWdJQzh2SUhObGJHWXVYMjl1YkhsZllYTnphV2R1WldSZmFYTnpkV1Z5S0hKbGNYVmxjM1JmYVdRcENpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdYMjl1YkhsZllYTnphV2R1WldSZmFYTnpkV1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuSmxjWFZsYzNSZmMzUmhkSFZ6VzNKbGNYVmxjM1JmYVdSZElEMDlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWljbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVnhkV1Z6ZEY5emRHRjBkWE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUmZjM1JoZEhWelczSmxjWFZsYzNSZmFXUmRJRDBnVlVsdWREWTBLRElwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrWlcxdlgzTnRMbU52Ym5SeVlXTjBMa1JsYlc5VGJTNTJaWEpwWm5sZmNtVnhkV1Z6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVY5eVpYRjFaWE4wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z2MyVnNaaTVmY21WeGRXVnpkRjl0ZFhOMFgyVjRhWE4wS0hKbGNYVmxjM1JmYVdRcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJmY21WeGRXVnpkRjl0ZFhOMFgyVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUhObGJHWXVYMjl1YkhsZllYTnphV2R1WldSZmFYTnpkV1Z5S0hKbGNYVmxjM1JmYVdRcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJmYjI1c2VWOWhjM05wWjI1bFpGOXBjM04xWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1OeVpXUmxiblJwWVd4ZlpYaHBjM1J6TG1kbGRDaGpjbVZrWlc1MGFXRnNYMmxrTENCa1pXWmhkV3gwUFVaaGJITmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpWTJVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Y21WeGRXVnpkRjl6ZEdGMGRYTmJjbVZ4ZFdWemRGOXBaRjBnUFQwZ1ZVbHVkRFkwS0RFcElHOXlJSE5sYkdZdWNtVnhkV1Z6ZEY5emRHRjBkWE5iY21WeGRXVnpkRjlwWkYwZ1BUMGdWVWx1ZERZMEtESXBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYRjFaWE4wWDNOMFlYUjFjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSFpsY21sbWVWOXlaWEYxWlhOMFgySnZiMnhmZEhKMVpVQXpDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY1hWbGMzUmZjM1JoZEhWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JpZWlCMlpYSnBabmxmY21WeGRXVnpkRjlpYjI5c1gyWmhiSE5sUURRS0NuWmxjbWxtZVY5eVpYRjFaWE4wWDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NuWmxjbWxtZVY5eVpYRjFaWE4wWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1Y21WeGRXVnpkRjl6ZEdGMGRYTmJjbVZ4ZFdWemRGOXBaRjBnUFQwZ1ZVbHVkRFkwS0RFcElHOXlJSE5sYkdZdWNtVnhkV1Z6ZEY5emRHRjBkWE5iY21WeGRXVnpkRjlwWkYwZ1BUMGdWVWx1ZERZMEtESXBDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakV4TUFvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMFgzTjBZWFIxYzF0eVpYRjFaWE4wWDJsa1hTQTlJRlZKYm5RMk5DZ3pLUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZNVEV4Q2lBZ0lDQXZMeUJ6Wld4bUxtTnlaV1JsYm5ScFlXeGZaWGhwYzNSelcyTnlaV1JsYm5ScFlXeGZhV1JkSUQwZ1ZISjFaUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCelpXeG1MbU55WldSbGJuUnBZV3hmWVdOMGFYWmxXMk55WldSbGJuUnBZV3hmYVdSZElEMGdWSEoxWlFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWTJFaUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TURNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkbVZ5YVdaNVgzSmxjWFZsYzNSZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2RtVnlhV1o1WDNKbGNYVmxjM1JmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJsYlc5ZmMyMHVZMjl1ZEhKaFkzUXVSR1Z0YjFOdExuSmxhbVZqZEY5eVpYRjFaWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnFaV04wWDNKbGNYVmxjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZNVEUyQ2lBZ0lDQXZMeUJ6Wld4bUxsOXlaWEYxWlhOMFgyMTFjM1JmWlhocGMzUW9jbVZ4ZFdWemRGOXBaQ2tLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCZmNtVnhkV1Z6ZEY5dGRYTjBYMlY0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklITmxiR1l1WDI5dWJIbGZZWE56YVdkdVpXUmZhWE56ZFdWeUtISmxjWFZsYzNSZmFXUXBDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWDI5dWJIbGZZWE56YVdkdVpXUmZhWE56ZFdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbkpsY1hWbGMzUmZjM1JoZEhWelczSmxjWFZsYzNSZmFXUmRJRDA5SUZWSmJuUTJOQ2d4S1NCdmNpQnpaV3htTG5KbGNYVmxjM1JmYzNSaGRIVnpXM0psY1hWbGMzUmZhV1JkSUQwOUlGVkpiblEyTkNneUtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WeGRXVnpkRjl6ZEdGMGRYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaV3BsWTNSZmNtVnhkV1Z6ZEY5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWEYxWlhOMFgzTjBZWFIxY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WcVpXTjBYM0psY1hWbGMzUmZZbTl2YkY5bVlXeHpaVUEwQ2dweVpXcGxZM1JmY21WeGRXVnpkRjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dweVpXcGxZM1JmY21WeGRXVnpkRjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbkpsY1hWbGMzUmZjM1JoZEhWelczSmxjWFZsYzNSZmFXUmRJRDA5SUZWSmJuUTJOQ2d4S1NCdmNpQnpaV3htTG5KbGNYVmxjM1JmYzNSaGRIVnpXM0psY1hWbGMzUmZhV1JkSUQwOUlGVkpiblEyTkNneUtRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUb3hNVGtLSUNBZ0lDOHZJSE5sYkdZdWNtVnhkV1Z6ZEY5emRHRjBkWE5iY21WeGRXVnpkRjlwWkYwZ1BTQlZTVzUwTmpRb05Da0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXhOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXcGxZM1JmY21WeGRXVnpkRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ5WldwbFkzUmZjbVZ4ZFdWemRGOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnRiMTl6YlM1amIyNTBjbUZqZEM1RVpXMXZVMjB1Y21WMmIydGxYMk55WldSbGJuUnBZV3hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYWnZhMlZmWTNKbFpHVnVkR2xoYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRveE1qTUtJQ0FnSUM4dklITmxiR1l1WDJOeVpXUmxiblJwWVd4ZmJYVnpkRjlsZUdsemRDaGpjbVZrWlc1MGFXRnNYMmxrS1FvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdYMk55WldSbGJuUnBZV3hmYlhWemRGOWxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2TVRJMENpQWdJQ0F2THlCelpXeG1MbDl5WlhGMVpYTjBYMjExYzNSZlpYaHBjM1FvY21WeGRXVnpkRjlwWkNrS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQmZjbVZ4ZFdWemRGOXRkWE4wWDJWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJSE5sYkdZdVgyOXViSGxmWVhOemFXZHVaV1JmYVhOemRXVnlLSEpsY1hWbGMzUmZhV1FwQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gyOXViSGxmWVhOemFXZHVaV1JmYVhOemRXVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUb3hNallLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5KbGNYVmxjM1JmYzNSaGRIVnpXM0psY1hWbGMzUmZhV1JkSUQwOUlGVkpiblEyTkNnektRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNuTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WeGRXVnpkRjl6ZEdGMGRYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXlOd29nSUNBZ0x5OGdjMlZzWmk1amNtVmtaVzUwYVdGc1gyRmpkR2wyWlZ0amNtVmtaVzUwYVdGc1gybGtYU0E5SUVaaGJITmxDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pFeU9Bb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBYM04wWVhSMWMxdHlaWEYxWlhOMFgybGtYU0E5SUZWSmJuUTJOQ2cxS1FvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TWpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrWlcxdlgzTnRMbU52Ym5SeVlXTjBMa1JsYlc5VGJTNW5aWFJmY21WeGRXVnpkRjl6ZEdGMGRYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNtVnhkV1Z6ZEY5emRHRjBkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TXpBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiVzlmYzIwdVkyOXVkSEpoWTNRdVJHVnRiMU50TG1kbGRGOXlaWEYxWlhOMFgzTjBZWFIxY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnRiMTl6YlM1amIyNTBjbUZqZEM1RVpXMXZVMjB1WjJWMFgyTnlaV1JsYm5ScFlXeGZjM1JoZEhWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJOeVpXUmxiblJwWVd4ZmMzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5ZmMyMHZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklITmxiR1l1WDJOeVpXUmxiblJwWVd4ZmJYVnpkRjlsZUdsemRDaGpjbVZrWlc1MGFXRnNYMmxrS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOWpjbVZrWlc1MGFXRnNYMjExYzNSZlpYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakV6T0FvZ0lDQWdMeThnYVdZZ2MyVnNaaTVqY21Wa1pXNTBhV0ZzWDJGamRHbDJaVnRqY21Wa1pXNTBhV0ZzWDJsa1hUb0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltTmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amNtVmtaVzUwYVdGc1gyRmpkR2wyWlNCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdKMGIya0tJQ0FnSUdKNklHZGxkRjlqY21Wa1pXNTBhV0ZzWDNOMFlYUjFjMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXpPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVFVTlVTVlpGSWlrS0lDQWdJR0o1ZEdWaklEY2dMeThnSWtGRFZFbFdSU0lLQ21kbGRGOWpjbVZrWlc1MGFXRnNYM04wWVhSMWMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVrWlcxdlgzTnRMbU52Ym5SeVlXTjBMa1JsYlc5VGJTNW5aWFJmWTNKbFpHVnVkR2xoYkY5emRHRjBkWE5BTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGOWpjbVZrWlc1MGFXRnNYM04wWVhSMWMxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRveE5EQUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWxKRlZrOUxSVVFpS1FvZ0lDQWdZbmwwWldNZ01UWWdMeThnSWxKRlZrOUxSVVFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDJOeVpXUmxiblJwWVd4ZmMzUmhkSFZ6WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiVzlmYzIwdVkyOXVkSEpoWTNRdVJHVnRiMU50TG1kbGRGOWpjbVZrWlc1MGFXRnNYM04wWVhSMWMwQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1SbGJXOWZjMjB1WTI5dWRISmhZM1F1UkdWdGIxTnRMbWRsZEY5eVpYRjFaWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM0psY1hWbGMzUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakUwTmdvZ0lDQWdMeThnYzJWc1ppNWZjbVZ4ZFdWemRGOXRkWE4wWDJWNGFYTjBLSEpsY1hWbGMzUmZhV1FwQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gzSmxjWFZsYzNSZmJYVnpkRjlsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk1UUTRDaUFnSUNBdkx5QnpaV3htTG5KbGNYVmxjM1JmYzNSMVpHVnVkRnR5WlhGMVpYTjBYMmxrWFN3S0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY25OMGRTSUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbGNYVmxjM1JmYzNSMVpHVnVkQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pFME9Rb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBYMmx6YzNWbGNsdHlaWEYxWlhOMFgybGtYU3dLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkpwYzNNaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WlhGMVpYTjBYMmx6YzNWbGNpQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMFgyTmxjblJwWm1sallYUmxYM1I1Y0dWYmNtVnhkV1Z6ZEY5cFpGMHNDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljbU4wY0NJS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY1hWbGMzUmZZMlZ5ZEdsbWFXTmhkR1ZmZEhsd1pTQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakUxTVFvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMFgyTmxjblJwWm1sallYUmxYMjVoYldWYmNtVnhkV1Z6ZEY5cFpGMHNDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWljbU51YlNJS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY1hWbGMzUmZZMlZ5ZEdsbWFXTmhkR1ZmYm1GdFpTQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakUxTWdvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMFgyTmxjblJwWm1sallYUmxYMmxrVzNKbGNYVmxjM1JmYVdSZExBb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0luSmphV1FpQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWEYxWlhOMFgyTmxjblJwWm1sallYUmxYMmxrSUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk1UVXpDaUFnSUNBdkx5QnpaV3htTG5KbGNYVmxjM1JmYjNKbllXNXBlbUYwYVc5dVczSmxjWFZsYzNSZmFXUmRMQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbkp2Y21jaUNpQWdJQ0JrYVdjZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WlhGMVpYTjBYMjl5WjJGdWFYcGhkR2x2YmlCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdjMlZzWmk1eVpYRjFaWE4wWDJWMmFXUmxibU5sWDJoaGMyaGJjbVZ4ZFdWemRGOXBaRjBzQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpY21WMmFDSUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWEYxWlhOMFgyVjJhV1JsYm1ObFgyaGhjMmdnWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklITmxiR1l1WjJWMFgzSmxjWFZsYzNSZmMzUmhkSFZ6S0hKbGNYVmxjM1JmYVdRcExBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXMXZYM050TG1OdmJuUnlZV04wTGtSbGJXOVRiUzVuWlhSZmNtVnhkV1Z6ZEY5emRHRjBkWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakUwTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURZS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFJqQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOellLSUNBZ0lDc0tJQ0FnSUdScFp5QTNDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FyQ2lBZ0lDQmthV2NnTndvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnWkdsbklEY0tJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0JrYVdjZ053b2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdWdGIxOXpiUzVqYjI1MGNtRmpkQzVFWlcxdlUyMHVYMjl1YkhsZmNtVm5hWE4wY25rb0tTQXRQaUIyYjJsa09ncGZiMjVzZVY5eVpXZHBjM1J5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG5KbFoybHpkSEo1TG5aaGJIVmxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpY21WbmFYTjBjbmtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVm5hWE4wY25rZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR1Z0YjE5emJTNWpiMjUwY21GamRDNUVaVzF2VTIwdVgzSmxjWFZsYzNSZmJYVnpkRjlsZUdsemRDaHlaWEYxWlhOMFgybGtPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbDl5WlhGMVpYTjBYMjExYzNSZlpYaHBjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG95TndvZ0lDQWdMeThnWkdWbUlGOXlaWEYxWlhOMFgyMTFjM1JmWlhocGMzUW9jMlZzWml3Z2NtVnhkV1Z6ZEY5cFpEb2dWVWx1ZERZMEtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWNtVnhkV1Z6ZEY5bGVHbHpkSE11WjJWMEtISmxjWFZsYzNSZmFXUXNJR1JsWm1GMWJIUTlSbUZzYzJVcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5KbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiVzlmYzIwdVkyOXVkSEpoWTNRdVJHVnRiMU50TGw5amNtVmtaVzUwYVdGc1gyMTFjM1JmWlhocGMzUW9ZM0psWkdWdWRHbGhiRjlwWkRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwZlkzSmxaR1Z1ZEdsaGJGOXRkWE4wWDJWNGFYTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR1JsWmlCZlkzSmxaR1Z1ZEdsaGJGOXRkWE4wWDJWNGFYTjBLSE5sYkdZc0lHTnlaV1JsYm5ScFlXeGZhV1E2SUZWSmJuUTJOQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk16RUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbU55WldSbGJuUnBZV3hmWlhocGMzUnpMbWRsZENoamNtVmtaVzUwYVdGc1gybGtMQ0JrWldaaGRXeDBQVVpoYkhObEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaVkyVWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR1Z0YjE5emJTNWpiMjUwY21GamRDNUVaVzF2VTIwdVgyOXViSGxmWVhOemFXZHVaV1JmYVhOemRXVnlLSEpsY1hWbGMzUmZhV1E2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWDI5dWJIbGZZWE56YVdkdVpXUmZhWE56ZFdWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk16TUtJQ0FnSUM4dklHUmxaaUJmYjI1c2VWOWhjM05wWjI1bFpGOXBjM04xWlhJb2MyVnNaaXdnY21WeGRXVnpkRjlwWkRvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUb3pOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXlaWEYxWlhOMFgybHpjM1ZsY2x0eVpYRjFaWE4wWDJsa1hRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p5YVhOeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WlhGMVpYTjBYMmx6YzNWbGNpQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMzTjFaWEpmWVdOMGFYWmxMbWRsZENoVWVHNHVjMlZ1WkdWeUxDQmtaV1poZFd4MFBVWmhiSE5sS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYVdFaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZWE56WlhKMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdWdGIxOXpiUzVqYjI1MGNtRmpkQzVFWlcxdlUyMHVaMlYwWDNKbGNYVmxjM1JmYzNSaGRIVnpLSEpsY1hWbGMzUmZhV1E2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25OdFlYSjBYMk52Ym5SeVlXTjBjeTVrWlcxdlgzTnRMbU52Ym5SeVlXTjBMa1JsYlc5VGJTNW5aWFJmY21WeGRXVnpkRjl6ZEdGMGRYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUb3hNekF0TVRNeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYM0psY1hWbGMzUmZjM1JoZEhWektITmxiR1lzSUhKbGNYVmxjM1JmYVdRNklGVkpiblEyTkNrZ0xUNGdVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG94TXpJS0lDQWdJQzh2SUhObGJHWXVYM0psY1hWbGMzUmZiWFZ6ZEY5bGVHbHpkQ2h5WlhGMVpYTjBYMmxrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOXlaWEYxWlhOMFgyMTFjM1JmWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WDNOMFlYUjFjMTl1WVcxbEtITmxiR1l1Y21WeGRXVnpkRjl6ZEdGMGRYTmJjbVZ4ZFdWemRGOXBaRjBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWEYxWlhOMFgzTjBZWFIxY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklHbG1JSE4wWVhSMWN5QTlQU0JWU1c1ME5qUW9NU2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXMXZYM050TG1OdmJuUnlZV04wTGtSbGJXOVRiUzVuWlhSZmNtVnhkV1Z6ZEY5emRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMTl6YlM5amIyNTBjbUZqZEM1d2VUb3pPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVVFVk9SRWxPUnlJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxCRlRrUkpUa2NpQ2dwemJXRnlkRjlqYjI1MGNtRmpkSE11WkdWdGIxOXpiUzVqYjI1MGNtRmpkQzVFWlcxdlUyMHVaMlYwWDNKbGNYVmxjM1JmYzNSaGRIVnpYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1SbGJXOWZjMjB1WTI5dWRISmhZM1F1UkdWdGIxTnRMbDl6ZEdGMGRYTmZibUZ0WlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WDNOMFlYUjFjMTl1WVcxbEtITmxiR1l1Y21WeGRXVnpkRjl6ZEdGMGRYTmJjbVZ4ZFdWemRGOXBaRjBwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NuTnRZWEowWDJOdmJuUnlZV04wY3k1a1pXMXZYM050TG1OdmJuUnlZV04wTGtSbGJXOVRiUzVuWlhSZmNtVnhkV1Z6ZEY5emRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJR2xtSUhOMFlYUjFjeUE5UFNCVlNXNTBOalFvTWlrNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaWVpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnRiMTl6YlM1amIyNTBjbUZqZEM1RVpXMXZVMjB1WjJWMFgzSmxjWFZsYzNSZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlmYzIwdlkyOXVkSEpoWTNRdWNIazZOREVLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsVk9SRVZTSUZKRlZrbEZWeUlwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFZPUkVWU0lGSkZWa2xGVnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVYM04wWVhSMWMxOXVZVzFsS0hObGJHWXVjbVZ4ZFdWemRGOXpkR0YwZFhOYmNtVnhkV1Z6ZEY5cFpGMHBDaUFnSUNCaUlITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXMXZYM050TG1OdmJuUnlZV04wTGtSbGJXOVRiUzVuWlhSZmNtVnhkV1Z6ZEY5emRHRjBkWE5mWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnRiMTl6YlM1amIyNTBjbUZqZEM1RVpXMXZVMjB1WDNOMFlYUjFjMTl1WVcxbFFERXdDZ3B6YldGeWRGOWpiMjUwY21GamRITXVaR1Z0YjE5emJTNWpiMjUwY21GamRDNUVaVzF2VTIwdVoyVjBYM0psY1hWbGMzUmZjM1JoZEhWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlgzTnRMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCcFppQnpkR0YwZFhNZ1BUMGdWVWx1ZERZMEtETXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHSjZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWtaVzF2WDNOdExtTnZiblJ5WVdOMExrUmxiVzlUYlM1blpYUmZjbVZ4ZFdWemRGOXpkR0YwZFhOZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjE5emJTOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lWa1ZTU1VaSlJVUWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSldSVkpKUmtsRlJDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WDNOMFlYUjFjMTl1WVcxbEtITmxiR1l1Y21WeGRXVnpkRjl6ZEdGMGRYTmJjbVZ4ZFdWemRGOXBaRjBwQ2lBZ0lDQmlJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWtaVzF2WDNOdExtTnZiblJ5WVdOMExrUmxiVzlUYlM1blpYUmZjbVZ4ZFdWemRGOXpkR0YwZFhOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVaR1Z0YjE5emJTNWpiMjUwY21GamRDNUVaVzF2VTIwdVgzTjBZWFIxYzE5dVlXMWxRREV3Q2dwemJXRnlkRjlqYjI1MGNtRmpkSE11WkdWdGIxOXpiUzVqYjI1MGNtRmpkQzVFWlcxdlUyMHVaMlYwWDNKbGNYVmxjM1JmYzNSaGRIVnpYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZYM050TDJOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QnBaaUJ6ZEdGMGRYTWdQVDBnVlVsdWREWTBLRFFwT2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUFQwS0lDQWdJR0o2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrWlcxdlgzTnRMbU52Ym5SeVlXTjBMa1JsYlc5VGJTNW5aWFJmY21WeGRXVnpkRjl6ZEdGMGRYTmZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIxOXpiUzlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVWtWS1JVTlVSVVFpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pTUlVwRlExUkZSQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPakV6TXdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVgzTjBZWFIxYzE5dVlXMWxLSE5sYkdZdWNtVnhkV1Z6ZEY5emRHRjBkWE5iY21WeGRXVnpkRjlwWkYwcENpQWdJQ0JpSUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrWlcxdlgzTnRMbU52Ym5SeVlXTjBMa1JsYlc5VGJTNW5aWFJmY21WeGRXVnpkRjl6ZEdGMGRYTmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WkdWdGIxOXpiUzVqYjI1MGNtRmpkQzVFWlcxdlUyMHVYM04wWVhSMWMxOXVZVzFsUURFd0NncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnRiMTl6YlM1amIyNTBjbUZqZEM1RVpXMXZVMjB1WjJWMFgzSmxjWFZsYzNSZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WDNOdEwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlNSVlpQUzBWRUlpa0tJQ0FnSUdKNWRHVmpJREUySUM4dklDSlNSVlpQUzBWRUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWZjMjB2WTI5dWRISmhZM1F1Y0hrNk1UTXpDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVmYzNSaGRIVnpYMjVoYldVb2MyVnNaaTV5WlhGMVpYTjBYM04wWVhSMWMxdHlaWEYxWlhOMFgybGtYU2tLSUNBZ0lHSWdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiVzlmYzIwdVkyOXVkSEpoWTNRdVJHVnRiMU50TG1kbGRGOXlaWEYxWlhOMFgzTjBZWFIxYzE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWtaVzF2WDNOdExtTnZiblJ5WVdOMExrUmxiVzlUYlM1ZmMzUmhkSFZ6WDI1aGJXVkFNVEFLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUNDQ1lSQW5KekJCVWZmSFVDYVdFRWNtbHpjd0pqWVFoeVpXZHBjM1J5ZVFKcGN3WkJRMVJKVmtVQ2NtVUVjbk4wZFFSeVkzUndCSEpqYm0wRWNtTnBaQVJ5YjNKbkJISmxkbWdDWTJVSFVrVldUMHRGUkRFWVFBQUZKd1V4QUdjeEcwRUFZekVaRkVReEdFU0NEQVFDdnM0UkJIb0NYcmtFRXJ0OFBRUVRLOVBBQkNaWUNNc0VJdFk4MlFTanBiU2NCUHVKQmlrRW1oMm5VUVRaMUhUM0JPc3h2ZWdFWk1JdkdEWWFBSTRNQUFrQU1nQitBS0lBMWdHMEFkVUNPUUp2QXFrQ3d3THdBREVaRkRFWUZCQkROaG9CU1NOWkpBaExBUlVTUkZjQ0FJQUhTR1ZzYkc4c0lFeFFTUlVXVndZQ1RGQXBURkN3SWtNMkdnRkpGWUVnRWtRMkdnSkpJMWtrQ0VzQkZSSkVWd0lBTmhvRFNTTlpKQWhMQVJVU1JGY0NBSWdEZ3lwTEExQWlGcitBQW1sdlN3TlFTYnhJVHdLL0p3WlBBbEJKdkVoTXZ5SkROaG9CU1JXQklCSkVOaG9DU1JVaUVrUWpVNGdEVFNwUEFsQkp2VVVCUkV3V3Z5SkROaG9CU1JXQklCSkVLa3hRdmt3WEkweFBBazFBQUJpQUNFbE9RVU5VU1ZaRlNSVVdWd1lDVEZBcFRGQ3dJa01uQjBMLzdUWWFBVWtWSlJKRUZ6WWFBa2tWZ1NBU1JEWWFBMGtqV1NRSVN3RVZFa1JYQWdBMkdnUkpJMWtrQ0VzQkZSSkVWd0lBTmhvRlNTTlpKQWhMQVJVU1JGY0NBRFlhQmtraldTUUlTd0VWRWtSWEFnQTJHZ2RKSTFra0NFc0JGUkpFVndJQVR3WVdKd2hMQVZCSnZrd1hJMHhQQWswVVJDcExDRkMrVEJjalRFOENUVVFuQmtzSVVMNUVTd2NTUkNJV3Z5aExBVkFpRnI4eEFDY0pTd0pRVEw4clN3RlFUd2UvSndwTEFWQkp2RWhQQnI4bkMwc0JVRW04U0U4RnZ5Y01Td0ZRU2J4SVR3Uy9KdzFMQVZCSnZFaFBBNzhuRGt4UVNieElUTDhpUXpZYUFVa1ZKUkpFRjBtSUFpcEppQUpPRmloTVVFbStSQmNpRWtRa0ZyOGlRellhQVVrVkpSSkVGellhQWtrVkpSSkVGMHNCaUFIL1N3R0lBaUlXU1U0Q0p3OU1VRWxPQXI1TUZ5Tk1Ud0pORkVRV0tFeFFTYjVFRnlJU1FBQUpTYjVFRnlRU1FRQVpJa1NCQXhaTEFVeS9JaFpMQWtzQnZ5Y0VTd1JRVEw4aVF5TkMvK1EyR2dGSkZTVVNSQmRKaUFHbFNZZ0J5UllvVEZCSnZrUVhJaEpBQUFsSnZrUVhKQkpCQUFzaVJJRUVGa3NCVEw4aVF5TkMvL0kyR2dGSkZTVVNSQmMyR2dKSkZTVVNSQmRMQVlnQmVVbUlBV0ZKaUFHRkZpaE1VRW0rUkJlQkF4SkVUQlluQkV4UUl4YS9nUVVXdnlKRE5ob0JTUlVsRWtRWGlBRjdTUlVXVndZQ1RGQXBURkN3SWtNMkdnRkpGU1VTUkJkSmlBRXZGaWNFVEZDK1JCZEJBQkFuQjBrVkZsY0dBa3hRS1V4UXNDSkRKeEJDLyswMkdnRkpGU1VTUkJkSmlBRHVTUlluQ1VzQlVMNUVLMHNDVUw1RUp3cExBMUMrUkNjTFN3UlF2a1FuREVzRlVMNUVKdzFMQmxDK1JDY09Ud2RRdmtSUEI0Z0EvRThIVHdkUVN3WVZGbGNHQWs4SFVFeUFBZ0JNVUVzQkZZRk1DRXNIRlJaWEJnSlBDRkJMQVJaWEJnSlBBMHhRU3dFVlR3TUlTd2NWRmxjR0FrOElVRXNCRmxjR0FrOERURkJMQVJWUEF3aExCeFVXVndZQ1R3aFFTd0VXVndZQ1R3Tk1VRXNCRlU4RENFc0hGUlpYQmdKUENGQkxBUlpYQmdKUEEweFFTd0VWVHdNSVN3Y1ZGbGNHQWs4SVVFd1dWd1lDVHdKTVVFOEdVRThGVUU4RVVFOERVRThDVUV4UUtVeFFzQ0pETVFBakp3VmxSQkpFaVlvQkFJdi9GaWNJVEZDK1RCY2pURThDVFVTSmlnRUFpLzhXSnc5TVVMNU1GeU5NVHdKTlJJbUtBUUF4QUl2L0ZpdE1VTDVFRWtRcU1RQlF2a3dYSTB4UEFrMUVpWW9CQVl2L2lQK3ppLzhXS0V4UXZrUVhTU0lTUVFBTGdBZFFSVTVFU1U1SFRJbUxBQ1FTUVFBUmdBeFZUa1JGVWlCU1JWWkpSVmRDLythTEFJRURFa0VBRFlBSVZrVlNTVVpKUlVSQy85R0xBSUVFRWtFQURZQUlVa1ZLUlVOVVJVUkMvN3duRUVML3R3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
