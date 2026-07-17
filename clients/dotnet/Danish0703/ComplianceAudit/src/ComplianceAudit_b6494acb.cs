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

namespace Arc56.Generated.Danish0703.ComplianceAudit.ComplianceAudit_b6494acb
{


    public class ComplianceAuditProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ComplianceAuditProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetWalletMetricsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public string Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
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

                public static GetWalletMetricsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetWalletMetricsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetWalletMetricsReturn);
                }
                public bool Equals(GetWalletMetricsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetWalletMetricsReturn left, GetWalletMetricsReturn right)
                {
                    return EqualityComparer<GetWalletMetricsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetWalletMetricsReturn left, GetWalletMetricsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetReportReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public Algorand.Address Field5 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetReportReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetReportReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is Algorand.Address vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetReportReturn);
                }
                public bool Equals(GetReportReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetReportReturn left, GetReportReturn right)
                {
                    return EqualityComparer<GetReportReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetReportReturn left, GetReportReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetOrganizationVerificationReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetOrganizationVerificationReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetOrganizationVerificationReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as GetOrganizationVerificationReturn);
                }
                public bool Equals(GetOrganizationVerificationReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetOrganizationVerificationReturn left, GetOrganizationVerificationReturn right)
                {
                    return EqualityComparer<GetOrganizationVerificationReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetOrganizationVerificationReturn left, GetOrganizationVerificationReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="consented"> </param>
        public async Task SetDpdpConsent(Address wallet, bool consented, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 120, 148, 49, 58 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var consentedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); consentedAbi.From(consented);

            var result = await base.CallApp(new List<object> { abiHandle, walletRefIndex, consentedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetDpdpConsent_Transactions(Address wallet, bool consented, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 120, 148, 49, 58 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var consentedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); consentedAbi.From(consented);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex, consentedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<bool> HasDpdpConsent(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 51, 171, 54, 82 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasDpdpConsent_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 51, 171, 54, 82 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="risk_score"> </param>
        /// <param name="is_suspicious"> </param>
        /// <param name="reason"> </param>
        /// <param name="tx_reference"> </param>
        /// <param name="evidence_hash"> </param>
        public async Task RecordTransactionAssessment(Address wallet, ulong risk_score, bool is_suspicious, string reason, string tx_reference, string evidence_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 75, 187, 79, 98 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var is_suspiciousAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_suspiciousAbi.From(is_suspicious);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);
            var tx_referenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tx_referenceAbi.From(tx_reference);
            var evidence_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_hashAbi.From(evidence_hash);

            var result = await base.CallApp(new List<object> { abiHandle, walletRefIndex, risk_scoreAbi, is_suspiciousAbi, reasonAbi, tx_referenceAbi, evidence_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordTransactionAssessment_Transactions(Address wallet, ulong risk_score, bool is_suspicious, string reason, string tx_reference, string evidence_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 75, 187, 79, 98 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var is_suspiciousAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_suspiciousAbi.From(is_suspicious);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);
            var tx_referenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tx_referenceAbi.From(tx_reference);
            var evidence_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidence_hashAbi.From(evidence_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex, risk_scoreAbi, is_suspiciousAbi, reasonAbi, tx_referenceAbi, evidence_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.GetWalletMetricsReturn> GetWalletMetrics(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 136, 176, 86, 0 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetWalletMetricsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetWalletMetrics_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 136, 176, 86, 0 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tx_reference"> </param>
        public async Task<string> GetTxEvidence(string tx_reference, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 129, 52, 29 };
            var tx_referenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tx_referenceAbi.From(tx_reference);

            var result = await base.SimApp(new List<object> { abiHandle, tx_referenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetTxEvidence_Transactions(string tx_reference, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 129, 52, 29 };
            var tx_referenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tx_referenceAbi.From(tx_reference);

            return await base.MakeTransactionList(new List<object> { abiHandle, tx_referenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="period_label"> </param>
        /// <param name="report_hash"> </param>
        /// <param name="total_transactions"> </param>
        /// <param name="suspicious_transactions"> </param>
        public async Task<ulong> SubmitComplianceReport(string period_label, string report_hash, ulong total_transactions, ulong suspicious_transactions, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 122, 235, 146 };
            var period_labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); period_labelAbi.From(period_label);
            var report_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); report_hashAbi.From(report_hash);
            var total_transactionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_transactionsAbi.From(total_transactions);
            var suspicious_transactionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); suspicious_transactionsAbi.From(suspicious_transactions);

            var result = await base.CallApp(new List<object> { abiHandle, period_labelAbi, report_hashAbi, total_transactionsAbi, suspicious_transactionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SubmitComplianceReport_Transactions(string period_label, string report_hash, ulong total_transactions, ulong suspicious_transactions, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 122, 235, 146 };
            var period_labelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); period_labelAbi.From(period_label);
            var report_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); report_hashAbi.From(report_hash);
            var total_transactionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_transactionsAbi.From(total_transactions);
            var suspicious_transactionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); suspicious_transactionsAbi.From(suspicious_transactions);

            return await base.MakeTransactionList(new List<object> { abiHandle, period_labelAbi, report_hashAbi, total_transactionsAbi, suspicious_transactionsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="report_id"> </param>
        public async Task<Structs.GetReportReturn> GetReport(ulong report_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 241, 68, 130 };
            var report_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); report_idAbi.From(report_id);

            var result = await base.SimApp(new List<object> { abiHandle, report_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetReportReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetReport_Transactions(ulong report_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 241, 68, 130 };
            var report_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); report_idAbi.From(report_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, report_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="organization_wallet"> </param>
        /// <param name="certificate_asset_id"> </param>
        public async Task RegisterVerifiedOrganization(Address organization_wallet, ulong certificate_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { organization_wallet });
            byte organization_walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 249, 227, 200, 21 };
            var organization_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organization_walletAbi.From(organization_wallet);
            var certificate_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_asset_idAbi.From(certificate_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, organization_walletRefIndex, certificate_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterVerifiedOrganization_Transactions(Address organization_wallet, ulong certificate_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { organization_wallet });
            byte organization_walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 249, 227, 200, 21 };
            var organization_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organization_walletAbi.From(organization_wallet);
            var certificate_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); certificate_asset_idAbi.From(certificate_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, organization_walletRefIndex, certificate_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="organization_wallet"> </param>
        public async Task RevokeVerifiedOrganization(Address organization_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { organization_wallet });
            byte organization_walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 119, 231, 14, 185 };
            var organization_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organization_walletAbi.From(organization_wallet);

            var result = await base.CallApp(new List<object> { abiHandle, organization_walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeVerifiedOrganization_Transactions(Address organization_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { organization_wallet });
            byte organization_walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 119, 231, 14, 185 };
            var organization_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organization_walletAbi.From(organization_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, organization_walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="organization_wallet"> </param>
        public async Task<Structs.GetOrganizationVerificationReturn> GetOrganizationVerification(Address organization_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { organization_wallet });
            byte organization_walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 215, 96, 153, 15 };
            var organization_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organization_walletAbi.From(organization_wallet);

            var result = await base.SimApp(new List<object> { abiHandle, organization_walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetOrganizationVerificationReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetOrganizationVerification_Transactions(Address organization_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { organization_wallet });
            byte organization_walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 215, 96, 153, 15 };
            var organization_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); organization_walletAbi.From(organization_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, organization_walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29tcGxpYW5jZUF1ZGl0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFdhbGxldE1ldHJpY3NSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoic3RyaW5nIn1dLCJHZXRSZXBvcnRSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJhZGRyZXNzIn1dLCJHZXRPcmdhbml6YXRpb25WZXJpZmljYXRpb25SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoic2V0X2RwZHBfY29uc2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29uc2VudGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc19kcGRwX2NvbnNlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF90cmFuc2FjdGlvbl9hc3Nlc3NtZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJpc2tfc2NvcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc19zdXNwaWNpb3VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFzb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR4X3JlZmVyZW5jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZpZGVuY2VfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfd2FsbGV0X21ldHJpY3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IkdldFdhbGxldE1ldHJpY3NSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90eF9ldmlkZW5jZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eF9yZWZlcmVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF9jb21wbGlhbmNlX3JlcG9ydCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJpb2RfbGFiZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcG9ydF9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbF90cmFuc2FjdGlvbnMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN1c3BpY2lvdXNfdHJhbnNhY3Rpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlcG9ydCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBvcnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsdWludDY0LHVpbnQ2NCx1aW50NjQsYWRkcmVzcykiLCJzdHJ1Y3QiOiJHZXRSZXBvcnRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX3ZlcmlmaWVkX29yZ2FuaXphdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemF0aW9uX3dhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2VydGlmaWNhdGVfYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlX3ZlcmlmaWVkX29yZ2FuaXphdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemF0aW9uX3dhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfb3JnYW5pemF0aW9uX3ZlcmlmaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnYW5pemF0aW9uX3dhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQpIiwic3RydWN0IjoiR2V0T3JnYW5pemF0aW9uVmVyaWZpY2F0aW9uUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyMThdLCJlcnJvck1lc3NhZ2UiOiJDZXJ0aWZpY2F0ZSBhc3NldCBpZCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OSwzMzEsMzQ5LDM3MSw0NTIsNDg5LDUxOSw1NzUsNjIwLDY0OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gcmVjb3JkIGFzc2Vzc21lbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxNV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gcmVnaXN0ZXIgb3JnYW5pemF0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIHJldm9rZSBvcmdhbml6YXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTg2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBzdWJtaXQgcmVwb3J0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwMF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgd2FsbGV0IG9yIGNyZWF0b3IgY2FuIHNldCBjb25zZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTkwXSwiZXJyb3JNZXNzYWdlIjoiUGVyaW9kIGxhYmVsIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY1XSwiZXJyb3JNZXNzYWdlIjoiUmVhc29uIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTk0XSwiZXJyb3JNZXNzYWdlIjoiUmVwb3J0IGhhc2ggcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjFdLCJlcnJvck1lc3NhZ2UiOiJSaXNrIHNjb3JlIG11c3QgYmUgPD0gMTAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwMF0sImVycm9yTWVzc2FnZSI6IlN1c3BpY2lvdXMgY291bnQgbXVzdCBiZSA8PSB0b3RhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2OV0sImVycm9yTWVzc2FnZSI6IlRyYW5zYWN0aW9uIHJlZmVyZW5jZSByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3N10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMiwzMzQsMzUyLDM3NCw0NTUsNDkyLDUyMiw1NzgsNjIzLDY1Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDA0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uZXh0X3JlcG9ydF9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXRjR3hwWVc1alpWOWhkV1JwZEM1amIyNTBjbUZqZEM1RGIyMXdiR2xoYm1ObFFYVmthWFF1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0lpSWdJbTVsZUhSZmNtVndiM0owWDJsa0lpQWlZMkZmYjNKblgzWmxjbWxtYVdWa1h5SWdJbU5oWDI5eVoxOWhjM05sZEY4aUlDSmpZVjlqYjI1elpXNTBYeUlnSW1OaFgzUjRYeUlnSW1OaFgzTjFjM0JmSWlBaVkyRmZjbWx6YTE4aUlDSmpZVjl5WldGemIyNWZJaUFpWTJGZlpYWnBaR1Z1WTJWZklpQWlZMkZmY21Wd1gzQmxjbWx2WkY4aUlDSmpZVjl5WlhCZmFHRnphRjhpSUNKallWOXlaWEJmZEc5MFlXeGZJaUFpWTJGZmNtVndYM04xYzNCZklpQWlZMkZmY21Wd1gzSnZkVzVrWHlJZ0ltTmhYM0psY0Y5elpXNWtaWEpmSWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJSE5sYkdZdWJtVjRkRjl5WlhCdmNuUmZhV1FnUFNCVlNXNTBOalFvTVNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW01bGVIUmZjbVZ3YjNKMFgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRU52YlhCc2FXRnVZMlZCZFdScGRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFMUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE56ZzVORE14TTJFZ01IZ3pNMkZpTXpZMU1pQXdlRFJpWW1JMFpqWXlJREI0T0RoaU1EVTJNREFnTUhnMk16Z3hNelF4WkNBd2VHSXlOMkZsWWpreUlEQjROV1JtTVRRME9ESWdNSGhtT1dVell6Z3hOU0F3ZURjM1pUY3daV0k1SURCNFpEYzJNRGs1TUdZZ0x5OGdiV1YwYUc5a0lDSnpaWFJmWkhCa2NGOWpiMjV6Wlc1MEtHRmpZMjkxYm5Rc1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm9ZWE5mWkhCa2NGOWpiMjV6Wlc1MEtHRmpZMjkxYm5RcFltOXZiQ0lzSUcxbGRHaHZaQ0FpY21WamIzSmtYM1J5WVc1ellXTjBhVzl1WDJGemMyVnpjMjFsYm5Rb1lXTmpiM1Z1ZEN4MWFXNTBOalFzWW05dmJDeHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmZDJGc2JHVjBYMjFsZEhKcFkzTW9ZV05qYjNWdWRDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzYzNSeWFXNW5LU0lzSUcxbGRHaHZaQ0FpWjJWMFgzUjRYMlYyYVdSbGJtTmxLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTjFZbTFwZEY5amIyMXdiR2xoYm1ObFgzSmxjRzl5ZENoemRISnBibWNzYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZjbVZ3YjNKMEtIVnBiblEyTkNrb2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aFpHUnlaWE56S1NJc0lHMWxkR2h2WkNBaWNtVm5hWE4wWlhKZmRtVnlhV1pwWldSZmIzSm5ZVzVwZW1GMGFXOXVLR0ZqWTI5MWJuUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGRtOXJaVjkyWlhKcFptbGxaRjl2Y21kaGJtbDZZWFJwYjI0b1lXTmpiM1Z1ZENsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmIzSm5ZVzVwZW1GMGFXOXVYM1psY21sbWFXTmhkR2x2YmloaFkyTnZkVzUwS1NoaWIyOXNMSFZwYm5RMk5Da2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzTmxkRjlrY0dSd1gyTnZibk5sYm5SZmNtOTFkR1ZBTlNCdFlXbHVYMmhoYzE5a2NHUndYMk52Ym5ObGJuUmZjbTkxZEdWQU5pQnRZV2x1WDNKbFkyOXlaRjkwY21GdWMyRmpkR2x2Ymw5aGMzTmxjM050Wlc1MFgzSnZkWFJsUURjZ2JXRnBibDluWlhSZmQyRnNiR1YwWDIxbGRISnBZM05mY205MWRHVkFPQ0J0WVdsdVgyZGxkRjkwZUY5bGRtbGtaVzVqWlY5eWIzVjBaVUE1SUcxaGFXNWZjM1ZpYldsMFgyTnZiWEJzYVdGdVkyVmZjbVZ3YjNKMFgzSnZkWFJsUURFd0lHMWhhVzVmWjJWMFgzSmxjRzl5ZEY5eWIzVjBaVUF4TVNCdFlXbHVYM0psWjJsemRHVnlYM1psY21sbWFXVmtYMjl5WjJGdWFYcGhkR2x2Ymw5eWIzVjBaVUF4TWlCdFlXbHVYM0psZG05clpWOTJaWEpwWm1sbFpGOXZjbWRoYm1sNllYUnBiMjVmY205MWRHVkFNVE1nYldGcGJsOW5aWFJmYjNKbllXNXBlbUYwYVc5dVgzWmxjbWxtYVdOaGRHbHZibDl5YjNWMFpVQXhOQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dGNHeHBZVzVqWlVGMVpHbDBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXZjbWRoYm1sNllYUnBiMjVmZG1WeWFXWnBZMkYwYVc5dVgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRU52YlhCc2FXRnVZMlZCZFdScGRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pFMk1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmYjNKbllXNXBlbUYwYVc5dVgzWmxjbWxtYVdOaGRHbHZiZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxkbTlyWlY5MlpYSnBabWxsWkY5dmNtZGhibWw2WVhScGIyNWZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hOVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5QkRiMjF3YkdsaGJtTmxRWFZrYVhRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TlRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ5WlhadmEyVmZkbVZ5YVdacFpXUmZiM0puWVc1cGVtRjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psWjJsemRHVnlYM1psY21sbWFXVmtYMjl5WjJGdWFYcGhkR2x2Ymw5eWIzVjBaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pFME53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUVOdmJYQnNhV0Z1WTJWQmRXUnBkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlISmxaMmx6ZEdWeVgzWmxjbWxtYVdWa1gyOXlaMkZ1YVhwaGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmY21Wd2IzSjBYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUVOdmJYQnNhV0Z1WTJWQmRXUnBkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5eVpYQnZjblFLSUNBZ0lHUnBaeUExQ2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEVUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURZd0lDOHZJRFl3Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpZd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMzVmliV2wwWDJOdmJYQnNhV0Z1WTJWZmNtVndiM0owWDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJEYjIxd2JHbGhibU5sUVhWa2FYUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnpkV0p0YVhSZlkyOXRjR3hwWVc1alpWOXlaWEJ2Y25RS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzUjRYMlYyYVdSbGJtTmxYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJEYjIxd2JHbGhibU5sUVhWa2FYUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZkSGhmWlhacFpHVnVZMlVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjkzWVd4c1pYUmZiV1YwY21samMxOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdRMjl0Y0d4cFlXNWpaVUYxWkdsMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM2RoYkd4bGRGOXRaWFJ5YVdOekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREZoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5eVpXTnZjbVJmZEhKaGJuTmhZM1JwYjI1ZllYTnpaWE56YldWdWRGOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk5ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyMXdiR2xoYm1ObFFYVmthWFFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSEpsWTI5eVpGOTBjbUZ1YzJGamRHbHZibDloYzNObGMzTnRaVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhoYzE5a2NHUndYMk52Ym5ObGJuUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRU52YlhCc2FXRnVZMlZCZFdScGRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHaGhjMTlrY0dSd1gyTnZibk5sYm5RS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjMlYwWDJSd1pIQmZZMjl1YzJWdWRGOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk16TUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyMXdiR2xoYm1ObFFYVmthWFFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlITmxkRjlrY0dSd1gyTnZibk5sYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1EyOXRjR3hwWVc1alpVRjFaR2wwS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjF3YkdsaGJtTmxYMkYxWkdsMExtTnZiblJ5WVdOMExrTnZiWEJzYVdGdVkyVkJkV1JwZEM1elpYUmZaSEJrY0Y5amIyNXpaVzUwS0hkaGJHeGxkRG9nWW5sMFpYTXNJR052Ym5ObGJuUmxaRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3B6WlhSZlpIQmtjRjlqYjI1elpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNek10TXpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JSE5sZEY5a2NHUndYMk52Ym5ObGJuUW9jMlZzWml3Z2QyRnNiR1YwT2lCQlkyTnZkVzUwTENCamIyNXpaVzUwWldRNklHSnZiMndwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QmhjM05sY25RZ2QyRnNiR1YwSUQwOUlGUjRiaTV6Wlc1a1pYSWdiM0lnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVQyNXNlU0IzWVd4c1pYUWdiM0lnWTNKbFlYUnZjaUJqWVc0Z2MyVjBJR052Ym5ObGJuUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYzJWMFgyUndaSEJmWTI5dWMyVnVkRjlpYjI5c1gzUnlkV1ZBTWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MyVjBYMlJ3WkhCZlkyOXVjMlZ1ZEY5aWIyOXNYMlpoYkhObFFETUtDbk5sZEY5a2NHUndYMk52Ym5ObGJuUmZZbTl2YkY5MGNuVmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9LYzJWMFgyUndaSEJmWTI5dWMyVnVkRjlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvek5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhkaGJHeGxkQ0E5UFNCVWVHNHVjMlZ1WkdWeUlHOXlJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dkMkZzYkdWMElHOXlJR055WldGMGIzSWdZMkZ1SUhObGRDQmpiMjV6Wlc1MElnb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dkMkZzYkdWMElHOXlJR055WldGMGIzSWdZMkZ1SUhObGRDQmpiMjV6Wlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z2MyVnNaaTUzWVd4c1pYUmZaSEJrY0Y5amIyNXpaVzUwVzNkaGJHeGxkRjBnUFNCVlNXNTBOalFvTVNrZ2FXWWdZMjl1YzJWdWRHVmtJR1ZzYzJVZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKallWOWpiMjV6Wlc1MFh5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS2MyVjBYMlJ3WkhCZlkyOXVjMlZ1ZEY5aWIyOXNYMlpoYkhObFFETTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCelpYUmZaSEJrY0Y5amIyNXpaVzUwWDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjIxd2JHbGhibU5sWDJGMVpHbDBMbU52Ym5SeVlXTjBMa052YlhCc2FXRnVZMlZCZFdScGRDNW9ZWE5mWkhCa2NGOWpiMjV6Wlc1MEtIZGhiR3hsZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2FHRnpYMlJ3WkhCZlkyOXVjMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pNNExUTTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdhR0Z6WDJSd1pIQmZZMjl1YzJWdWRDaHpaV3htTENCM1lXeHNaWFE2SUVGalkyOTFiblFwSUMwK0lHSnZiMnc2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QmpiMjV6Wlc1MExDQmxlR2x6ZEhNZ1BTQnpaV3htTG5kaGJHeGxkRjlrY0dSd1gyTnZibk5sYm5RdWJXRjVZbVVvZDJGc2JHVjBLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZMkZmWTI5dWMyVnVkRjhpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklISmxkSFZ5YmlCbGVHbHpkSE1nWVc1a0lHTnZibk5sYm5RZ1BUMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVpQm9ZWE5mWkhCa2NGOWpiMjV6Wlc1MFgySnZiMnhmWm1Gc2MyVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nYUdGelgyUndaSEJmWTI5dWMyVnVkRjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwb1lYTmZaSEJrY0Y5amIyNXpaVzUwWDJKdmIyeGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QnlaWFIxY200Z1pYaHBjM1J6SUdGdVpDQmpiMjV6Wlc1MElEMDlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwb1lYTmZaSEJrY0Y5amIyNXpaVzUwWDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUdoaGMxOWtjR1J3WDJOdmJuTmxiblJmWW05dmJGOXRaWEpuWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52YlhCc2FXRnVZMlZmWVhWa2FYUXVZMjl1ZEhKaFkzUXVRMjl0Y0d4cFlXNWpaVUYxWkdsMExuSmxZMjl5WkY5MGNtRnVjMkZqZEdsdmJsOWhjM05sYzNOdFpXNTBLSGRoYkd4bGREb2dZbmwwWlhNc0lISnBjMnRmYzJOdmNtVTZJSFZwYm5RMk5Dd2dhWE5mYzNWemNHbGphVzkxY3pvZ2RXbHVkRFkwTENCeVpXRnpiMjQ2SUdKNWRHVnpMQ0IwZUY5eVpXWmxjbVZ1WTJVNklHSjVkR1Z6TENCbGRtbGtaVzVqWlY5b1lYTm9PaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tjbVZqYjNKa1gzUnlZVzV6WVdOMGFXOXVYMkZ6YzJWemMyMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8wTXkwMU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnY21WamIzSmtYM1J5WVc1ellXTjBhVzl1WDJGemMyVnpjMjFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQjNZV3hzWlhRNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjbWx6YTE5elkyOXlaVG9nVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUdselgzTjFjM0JwWTJsdmRYTTZJR0p2YjJ3c0NpQWdJQ0F2THlBZ0lDQWdjbVZoYzI5dU9pQlRkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkSGhmY21WbVpYSmxibU5sT2lCVGRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1pYWnBaR1Z1WTJWZmFHRnphRG9nVTNSeWFXNW5MQW9nSUNBZ0x5OGdLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTmlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dZM0psWVhSdmNpQmpZVzRnY21WamIzSmtJR0Z6YzJWemMyMWxiblJ6SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNpQmpZVzRnY21WamIzSmtJR0Z6YzJWemMyMWxiblJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnWVhOelpYSjBJSEpwYzJ0ZmMyTnZjbVVnUEQwZ1ZVbHVkRFkwS0RFd01Da3NJQ0pTYVhOcklITmpiM0psSUcxMWMzUWdZbVVnUEQwZ01UQXdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCd2RYTm9hVzUwSURFd01DQXZMeUF4TURBS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbWx6YXlCelkyOXlaU0J0ZFhOMElHSmxJRHc5SURFd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXRnpiMjR1WW5sMFpYTXViR1Z1WjNSb0lENGdWVWx1ZERZMEtEQXBMQ0FpVW1WaGMyOXVJSEpsY1hWcGNtVmtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXRnpiMjRnY21WeGRXbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJoYzNObGNuUWdkSGhmY21WbVpYSmxibU5sTG1KNWRHVnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3dLU3dnSWxSeVlXNXpZV04wYVc5dUlISmxabVZ5Wlc1alpTQnlaWEYxYVhKbFpDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnVkhKaGJuTmhZM1JwYjI0Z2NtVm1aWEpsYm1ObElISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z2RIaGZZMjkxYm5Rc0lIUjRYMlY0YVhOMGN5QTlJSE5sYkdZdWQyRnNiR1YwWDNSNFgyTnZkVzUwTG0xaGVXSmxLSGRoYkd4bGRDa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltTmhYM1I0WHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnpaV3htTG5kaGJHeGxkRjkwZUY5amIzVnVkRnQzWVd4c1pYUmRJRDBnZEhoZlkyOTFiblFnS3lCVlNXNTBOalFvTVNrZ2FXWWdkSGhmWlhocGMzUnpJR1ZzYzJVZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZWlCeVpXTnZjbVJmZEhKaGJuTmhZM1JwYjI1ZllYTnpaWE56YldWdWRGOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b0tjbVZqYjNKa1gzUnlZVzV6WVdOMGFXOXVYMkZ6YzJWemMyMWxiblJmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZOVGtLSUNBZ0lDOHZJSE5sYkdZdWQyRnNiR1YwWDNSNFgyTnZkVzUwVzNkaGJHeGxkRjBnUFNCMGVGOWpiM1Z1ZENBcklGVkpiblEyTkNneEtTQnBaaUIwZUY5bGVHbHpkSE1nWld4elpTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdjM1Z6Y0dsamFXOTFjMTlqYjNWdWRDd2djM1Z6Y0dsamFXOTFjMTlsZUdsemRITWdQU0J6Wld4bUxuZGhiR3hsZEY5emRYTndhV05wYjNWelgyTnZkVzUwTG0xaGVXSmxLSGRoYkd4bGRDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltTmhYM04xYzNCZklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklHbG1JR2x6WDNOMWMzQnBZMmx2ZFhNNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR0o2SUhKbFkyOXlaRjkwY21GdWMyRmpkR2x2Ymw5aGMzTmxjM050Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUhObGJHWXVkMkZzYkdWMFgzTjFjM0JwWTJsdmRYTmZZMjkxYm5SYmQyRnNiR1YwWFNBOUlITjFjM0JwWTJsdmRYTmZZMjkxYm5RZ0t5QlZTVzUwTmpRb01Ta2dhV1lnYzNWemNHbGphVzkxYzE5bGVHbHpkSE1nWld4elpTQlZTVzUwTmpRb01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JpZWlCeVpXTnZjbVJmZEhKaGJuTmhZM1JwYjI1ZllYTnpaWE56YldWdWRGOTBaWEp1WVhKNVgyWmhiSE5sUURZS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b0tjbVZqYjNKa1gzUnlZVzV6WVdOMGFXOXVYMkZ6YzJWemMyMWxiblJmZEdWeWJtRnllVjl0WlhKblpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJSE5sYkdZdWQyRnNiR1YwWDNOMWMzQnBZMmx2ZFhOZlkyOTFiblJiZDJGc2JHVjBYU0E5SUhOMWMzQnBZMmx2ZFhOZlkyOTFiblFnS3lCVlNXNTBOalFvTVNrZ2FXWWdjM1Z6Y0dsamFXOTFjMTlsZUdsemRITWdaV3h6WlNCVlNXNTBOalFvTVNrS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENncHlaV052Y21SZmRISmhibk5oWTNScGIyNWZZWE56WlhOemJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdjMlZzWmk1M1lXeHNaWFJmYkdGemRGOXlhWE5yVzNkaGJHeGxkRjBnUFNCeWFYTnJYM05qYjNKbENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKallWOXlhWE5yWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QnpaV3htTG5kaGJHeGxkRjlzWVhOMFgzSmxZWE52Ymx0M1lXeHNaWFJkSUQwZ2NtVmhjMjl1Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0pqWVY5eVpXRnpiMjVmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QnBaaUJsZG1sa1pXNWpaVjlvWVhOb0xtSjVkR1Z6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2d3S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQmllaUJ5WldOdmNtUmZkSEpoYm5OaFkzUnBiMjVmWVhOelpYTnpiV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnYzJWc1ppNTBlRjlsZG1sa1pXNWpaVjlvWVhOb1czUjRYM0psWm1WeVpXNWpaVjBnUFNCbGRtbGtaVzVqWlY5b1lYTm9DaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlZMkZmWlhacFpHVnVZMlZmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p2ZUY5d2RYUUtDbkpsWTI5eVpGOTBjbUZ1YzJGamRHbHZibDloYzNObGMzTnRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEE2Q2lBZ0lDQnlaWFJ6ZFdJS0NuSmxZMjl5WkY5MGNtRnVjMkZqZEdsdmJsOWhjM05sYzNOdFpXNTBYM1JsY201aGNubGZabUZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QnpaV3htTG5kaGJHeGxkRjl6ZFhOd2FXTnBiM1Z6WDJOdmRXNTBXM2RoYkd4bGRGMGdQU0J6ZFhOd2FXTnBiM1Z6WDJOdmRXNTBJQ3NnVlVsdWREWTBLREVwSUdsbUlITjFjM0JwWTJsdmRYTmZaWGhwYzNSeklHVnNjMlVnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lpQnlaV052Y21SZmRISmhibk5oWTNScGIyNWZZWE56WlhOemJXVnVkRjkwWlhKdVlYSjVYMjFsY21kbFFEY0tDbkpsWTI5eVpGOTBjbUZ1YzJGamRHbHZibDloYzNObGMzTnRaVzUwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJ6Wld4bUxuZGhiR3hsZEY5MGVGOWpiM1Z1ZEZ0M1lXeHNaWFJkSUQwZ2RIaGZZMjkxYm5RZ0t5QlZTVzUwTmpRb01Ta2dhV1lnZEhoZlpYaHBjM1J6SUdWc2MyVWdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWWlCeVpXTnZjbVJmZEhKaGJuTmhZM1JwYjI1ZllYTnpaWE56YldWdWRGOTBaWEp1WVhKNVgyMWxjbWRsUURNS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl0Y0d4cFlXNWpaVjloZFdScGRDNWpiMjUwY21GamRDNURiMjF3YkdsaGJtTmxRWFZrYVhRdVoyVjBYM2RoYkd4bGRGOXRaWFJ5YVdOektIZGhiR3hsZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUdKNWRHVnpPZ3BuWlhSZmQyRnNiR1YwWDIxbGRISnBZM002Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG8zTVMwM01nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjkzWVd4c1pYUmZiV1YwY21samN5aHpaV3htTENCM1lXeHNaWFE2SUVGalkyOTFiblFwSUMwK0lIUjFjR3hsVzFWSmJuUTJOQ3dnVlVsdWREWTBMQ0JWU1c1ME5qUXNJRk4wY21sdVoxMDZDaUFnSUNCd2NtOTBieUF4SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCMGVGOWpiM1Z1ZEN3Z2RIaGZaWGhwYzNSeklEMGdjMlZzWmk1M1lXeHNaWFJmZEhoZlkyOTFiblF1YldGNVltVW9kMkZzYkdWMEtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyRmZkSGhmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QnpkWE53YVdOcGIzVnpYMk52ZFc1MExDQnpkWE53YVdOcGIzVnpYMlY0YVhOMGN5QTlJSE5sYkdZdWQyRnNiR1YwWDNOMWMzQnBZMmx2ZFhOZlkyOTFiblF1YldGNVltVW9kMkZzYkdWMEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVkyRmZjM1Z6Y0Y4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TnpVS0lDQWdJQzh2SUhKcGMyc3NJSEpwYzJ0ZlpYaHBjM1J6SUQwZ2MyVnNaaTUzWVd4c1pYUmZiR0Z6ZEY5eWFYTnJMbTFoZVdKbEtIZGhiR3hsZENrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1OaFgzSnBjMnRmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPamMyQ2lBZ0lDQXZMeUJ5WldGemIyNHNJSEpsWVhOdmJsOWxlR2x6ZEhNZ1BTQnpaV3htTG5kaGJHeGxkRjlzWVhOMFgzSmxZWE52Ymk1dFlYbGlaU2gzWVd4c1pYUXBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmpZVjl5WldGemIyNWZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnBaaUJ1YjNRZ2RIaGZaWGhwYzNSek9nb2dJQ0FnWW01NklHZGxkRjkzWVd4c1pYUmZiV1YwY21samMxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCMGVGOWpiM1Z1ZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS1oyVjBYM2RoYkd4bGRGOXRaWFJ5YVdOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCcFppQnViM1FnYzNWemNHbGphVzkxYzE5bGVHbHpkSE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltNTZJR2RsZEY5M1lXeHNaWFJmYldWMGNtbGpjMTloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qZ3hDaUFnSUNBdkx5QnpkWE53YVdOcGIzVnpYMk52ZFc1MElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNncG5aWFJmZDJGc2JHVjBYMjFsZEhKcFkzTmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklHbG1JRzV2ZENCeWFYTnJYMlY0YVhOMGN6b0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JpYm5vZ1oyVjBYM2RoYkd4bGRGOXRaWFJ5YVdOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhKcGMyc2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtDbWRsZEY5M1lXeHNaWFJmYldWMGNtbGpjMTloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzROQW9nSUNBZ0x5OGdhV1lnYm05MElISmxZWE52Ymw5bGVHbHpkSE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1ltNTZJR2RsZEY5M1lXeHNaWFJmYldWMGNtbGpjMTloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QnlaV0Z6YjI0Z1BTQlRkSEpwYm1jb0lpSXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSWlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtDbWRsZEY5M1lXeHNaWFJmYldWMGNtbGpjMTloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdjbVYwZFhKdUlIUjRYMk52ZFc1MExDQnpkWE53YVdOcGIzVnpYMk52ZFc1MExDQnlhWE5yTENCeVpXRnpiMjRLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyMXdiR2xoYm1ObFgyRjFaR2wwTG1OdmJuUnlZV04wTGtOdmJYQnNhV0Z1WTJWQmRXUnBkQzVuWlhSZmRIaGZaWFpwWkdWdVkyVW9kSGhmY21WbVpYSmxibU5sT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGOTBlRjlsZG1sa1pXNWpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPamc1TFRrd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYM1I0WDJWMmFXUmxibU5sS0hObGJHWXNJSFI0WDNKbFptVnlaVzVqWlRvZ1UzUnlhVzVuS1NBdFBpQlRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJsZG1sa1pXNWpaU3dnWlhocGMzUnpJRDBnYzJWc1ppNTBlRjlsZG1sa1pXNWpaVjlvWVhOb0xtMWhlV0psS0hSNFgzSmxabVZ5Wlc1alpTa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmpZVjlsZG1sa1pXNWpaVjhpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHbG1JR1Y0YVhOMGN6b0tJQ0FnSUdKNklHZGxkRjkwZUY5bGRtbGtaVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdaWFpwWkdWdVkyVUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbWRsZEY5MGVGOWxkbWxrWlc1alpWOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpSWlrS0lDQWdJR0o1ZEdWalh6RWdMeThnSWlJS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjIxd2JHbGhibU5sWDJGMVpHbDBMbU52Ym5SeVlXTjBMa052YlhCc2FXRnVZMlZCZFdScGRDNXpkV0p0YVhSZlkyOXRjR3hwWVc1alpWOXlaWEJ2Y25Rb2NHVnlhVzlrWDJ4aFltVnNPaUJpZVhSbGN5d2djbVZ3YjNKMFgyaGhjMmc2SUdKNWRHVnpMQ0IwYjNSaGJGOTBjbUZ1YzJGamRHbHZibk02SUhWcGJuUTJOQ3dnYzNWemNHbGphVzkxYzE5MGNtRnVjMkZqZEdsdmJuTTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3B6ZFdKdGFYUmZZMjl0Y0d4cFlXNWpaVjl5WlhCdmNuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUbzVOaTB4TURNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JSE4xWW0xcGRGOWpiMjF3YkdsaGJtTmxYM0psY0c5eWRDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJSEJsY21sdlpGOXNZV0psYkRvZ1UzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lISmxjRzl5ZEY5b1lYTm9PaUJUZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkSEpoYm5OaFkzUnBiMjV6T2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2MzVnpjR2xqYVc5MWMxOTBjbUZ1YzJGamRHbHZibk02SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z05DQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pQYm14NUlHTnlaV0YwYjNJZ1kyRnVJSE4xWW0xcGRDQnlaWEJ2Y25Seklnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2MzVmliV2wwSUhKbGNHOXlkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakV3TlFvZ0lDQWdMeThnWVhOelpYSjBJSEJsY21sdlpGOXNZV0psYkM1aWVYUmxjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NQ2tzSUNKUVpYSnBiMlFnYkdGaVpXd2djbVZ4ZFdseVpXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUZCbGNtbHZaQ0JzWVdKbGJDQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UQTJDaUFnSUNBdkx5QmhjM05sY25RZ2NtVndiM0owWDJoaGMyZ3VZbmwwWlhNdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RBcExDQWlVbVZ3YjNKMElHaGhjMmdnY21WeGRXbHlaV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklGSmxjRzl5ZENCb1lYTm9JSEpsY1hWcGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hNRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkWE53YVdOcGIzVnpYM1J5WVc1ellXTjBhVzl1Y3lBOFBTQjBiM1JoYkY5MGNtRnVjMkZqZEdsdmJuTXNJQ0pUZFhOd2FXTnBiM1Z6SUdOdmRXNTBJRzExYzNRZ1ltVWdQRDBnZEc5MFlXd2lDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUZFhOd2FXTnBiM1Z6SUdOdmRXNTBJRzExYzNRZ1ltVWdQRDBnZEc5MFlXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdjbVZ3YjNKMFgybGtJRDBnYzJWc1ppNXVaWGgwWDNKbGNHOXlkRjlwWkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTVsZUhSZmNtVndiM0owWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTVsZUhSZmNtVndiM0owWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRFeENpQWdJQ0F2THlCelpXeG1MbkpsY0c5eWRGOXdaWEpwYjJSYmNtVndiM0owWDJsa1hTQTlJSEJsY21sdlpGOXNZV0psYkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWTJGZmNtVndYM0JsY21sdlpGOGlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklITmxiR1l1Y21Wd2IzSjBYMmhoYzJoYmNtVndiM0owWDJsa1hTQTlJSEpsY0c5eWRGOW9ZWE5vQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWTJGZmNtVndYMmhoYzJoZklnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCelpXeG1MbkpsY0c5eWRGOTBiM1JoYkY5MGVGdHlaWEJ2Y25SZmFXUmRJRDBnZEc5MFlXeGZkSEpoYm5OaFkzUnBiMjV6Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWTJGZmNtVndYM1J2ZEdGc1h5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRFMENpQWdJQ0F2THlCelpXeG1MbkpsY0c5eWRGOXpkWE53YVdOcGIzVnpYM1I0VzNKbGNHOXlkRjlwWkYwZ1BTQnpkWE53YVdOcGIzVnpYM1J5WVc1ellXTjBhVzl1Y3dvZ0lDQWdZbmwwWldNZ01UUWdMeThnSW1OaFgzSmxjRjl6ZFhOd1h5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRFMUNpQWdJQ0F2THlCelpXeG1MbkpsY0c5eWRGOWpjbVZoZEdWa1gzSnZkVzVrVzNKbGNHOXlkRjlwWkYwZ1BTQkhiRzlpWVd3dWNtOTFibVFLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0pqWVY5eVpYQmZjbTkxYm1SZklnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TVRZS0lDQWdJQzh2SUhObGJHWXVjbVZ3YjNKMFgzTjFZbTFwZEhSbGNsdHlaWEJ2Y25SZmFXUmRJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldNZ01UWWdMeThnSW1OaFgzSmxjRjl6Wlc1a1pYSmZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUhObGJHWXVibVY0ZEY5eVpYQnZjblJmYVdRZ1BTQnlaWEJ2Y25SZmFXUWdLeUJWU1c1ME5qUW9NU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6SWdMeThnSW01bGVIUmZjbVZ3YjNKMFgybGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakV4T1FvZ0lDQWdMeThnY21WMGRYSnVJSEpsY0c5eWRGOXBaQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZiWEJzYVdGdVkyVmZZWFZrYVhRdVkyOXVkSEpoWTNRdVEyOXRjR3hwWVc1alpVRjFaR2wwTG1kbGRGOXlaWEJ2Y25Rb2NtVndiM0owWDJsa09pQjFhVzUwTmpRcElDMCtJR0o1ZEdWekxDQmllWFJsY3l3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJOQ3dnWW5sMFpYTTZDbWRsZEY5eVpYQnZjblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TWpFdE1USTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDNKbGNHOXlkQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQ0J5WlhCdmNuUmZhV1E2SUZWSmJuUTJOQW9nSUNBZ0x5OGdLU0F0UGlCMGRYQnNaVnRUZEhKcGJtY3NJRk4wY21sdVp5d2dWVWx1ZERZMExDQlZTVzUwTmpRc0lGVkpiblEyTkN3Z1FXTmpiM1Z1ZEYwNkNpQWdJQ0J3Y205MGJ5QXhJRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakV5TlFvZ0lDQWdMeThnY0dWeWFXOWtMQ0J3WlhKcGIyUmZaWGhwYzNSeklEMGdjMlZzWmk1eVpYQnZjblJmY0dWeWFXOWtMbTFoZVdKbEtISmxjRzl5ZEY5cFpDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltTmhYM0psY0Y5d1pYSnBiMlJmSWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE1qWUtJQ0FnSUM4dklISmxjRjlvWVhOb0xDQm9ZWE5vWDJWNGFYTjBjeUE5SUhObGJHWXVjbVZ3YjNKMFgyaGhjMmd1YldGNVltVW9jbVZ3YjNKMFgybGtLUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbU5oWDNKbGNGOW9ZWE5vWHlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRXlOd29nSUNBZ0x5OGdkRzkwWVd3c0lIUnZkR0ZzWDJWNGFYTjBjeUE5SUhObGJHWXVjbVZ3YjNKMFgzUnZkR0ZzWDNSNExtMWhlV0psS0hKbGNHOXlkRjlwWkNrS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKallWOXlaWEJmZEc5MFlXeGZJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCemRYTndhV05wYjNWekxDQnpkWE53YVdOcGIzVnpYMlY0YVhOMGN5QTlJSE5sYkdZdWNtVndiM0owWDNOMWMzQnBZMmx2ZFhOZmRIZ3ViV0Y1WW1Vb2NtVndiM0owWDJsa0tRb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0ltTmhYM0psY0Y5emRYTndYeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1kzSmxZWFJsWkY5eWIzVnVaQ3dnY205MWJtUmZaWGhwYzNSeklEMGdjMlZzWmk1eVpYQnZjblJmWTNKbFlYUmxaRjl5YjNWdVpDNXRZWGxpWlNoeVpYQnZjblJmYVdRcENpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaVkyRmZjbVZ3WDNKdmRXNWtYeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z2MzVmliV2wwZEdWeUxDQnpkV0p0YVhSMFpYSmZaWGhwYzNSeklEMGdjMlZzWmk1eVpYQnZjblJmYzNWaWJXbDBkR1Z5TG0xaGVXSmxLSEpsY0c5eWRGOXBaQ2tLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0pqWVY5eVpYQmZjMlZ1WkdWeVh5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QnBaaUJ1YjNRZ2NHVnlhVzlrWDJWNGFYTjBjem9LSUNBZ0lHSnVlaUJuWlhSZmNtVndiM0owWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVE16Q2lBZ0lDQXZMeUJ3WlhKcGIyUWdQU0JUZEhKcGJtY29JaUlwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0lpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ21kbGRGOXlaWEJ2Y25SZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52YlhCc2FXRnVZMlZmWVhWa2FYUXZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCcFppQnViM1FnYUdGemFGOWxlR2x6ZEhNNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZbTU2SUdkbGRGOXlaWEJ2Y25SZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUhKbGNGOW9ZWE5vSUQwZ1UzUnlhVzVuS0NJaUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaUlnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNncG5aWFJmY21Wd2IzSjBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRXpOZ29nSUNBZ0x5OGdhV1lnYm05MElIUnZkR0ZzWDJWNGFYTjBjem9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaWJub2daMlYwWDNKbGNHOXlkRjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdkRzkwWVd3Z1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0NtZGxkRjl5WlhCdmNuUmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QnBaaUJ1YjNRZ2MzVnpjR2xqYVc5MWMxOWxlR2x6ZEhNNkNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdZbTU2SUdkbGRGOXlaWEJ2Y25SZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TXprS0lDQWdJQzh2SUhOMWMzQnBZMmx2ZFhNZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURZS0NtZGxkRjl5WlhCdmNuUmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UUXdDaUFnSUNBdkx5QnBaaUJ1YjNRZ2NtOTFibVJmWlhocGMzUnpPZ29nSUNBZ1puSmhiV1ZmWkdsbklEY0tJQ0FnSUdKdWVpQm5aWFJmY21Wd2IzSjBYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdZM0psWVhSbFpGOXliM1Z1WkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnT0FvS1oyVjBYM0psY0c5eWRGOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UUXlDaUFnSUNBdkx5QnBaaUJ1YjNRZ2MzVmliV2wwZEdWeVgyVjRhWE4wY3pvS0lDQWdJR1p5WVcxbFgyUnBaeUE1Q2lBZ0lDQmlibm9nWjJWMFgzSmxjRzl5ZEY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TkRNS0lDQWdJQzh2SUhOMVltMXBkSFJsY2lBOUlFZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdabkpoYldWZlluVnllU0F4TUFvS1oyVjBYM0psY0c5eWRGOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UUTFDaUFnSUNBdkx5QnlaWFIxY200Z2NHVnlhVzlrTENCeVpYQmZhR0Z6YUN3Z2RHOTBZV3dzSUhOMWMzQnBZMmx2ZFhNc0lHTnlaV0YwWldSZmNtOTFibVFzSUhOMVltMXBkSFJsY2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURZS0lDQWdJR1p5WVcxbFgyUnBaeUE0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjIxd2JHbGhibU5sWDJGMVpHbDBMbU52Ym5SeVlXTjBMa052YlhCc2FXRnVZMlZCZFdScGRDNXlaV2RwYzNSbGNsOTJaWEpwWm1sbFpGOXZjbWRoYm1sNllYUnBiMjRvYjNKbllXNXBlbUYwYVc5dVgzZGhiR3hsZERvZ1lubDBaWE1zSUdObGNuUnBabWxqWVhSbFgyRnpjMlYwWDJsa09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuSmxaMmx6ZEdWeVgzWmxjbWxtYVdWa1gyOXlaMkZ1YVhwaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakUwTnkweE5EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhKbFoybHpkR1Z5WDNabGNtbG1hV1ZrWDI5eVoyRnVhWHBoZEdsdmJpaHpaV3htTENCdmNtZGhibWw2WVhScGIyNWZkMkZzYkdWME9pQkJZMk52ZFc1MExDQmpaWEowYVdacFkyRjBaVjloYzNObGRGOXBaRG9nVlVsdWREWTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlISmxaMmx6ZEdWeUlHOXlaMkZ1YVhwaGRHbHZibk1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ5WldkcGMzUmxjaUJ2Y21kaGJtbDZZWFJwYjI1ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCalpYSjBhV1pwWTJGMFpWOWhjM05sZEY5cFpDQStJRlZKYm5RMk5DZ3dLU3dnSWtObGNuUnBabWxqWVhSbElHRnpjMlYwSUdsa0lHMTFjM1FnWW1VZ1BpQXdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyVnlkR2xtYVdOaGRHVWdZWE56WlhRZ2FXUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakUxTWdvZ0lDQWdMeThnYzJWc1ppNXZjbWRmZG1WeWFXWnBaV1JiYjNKbllXNXBlbUYwYVc5dVgzZGhiR3hsZEYwZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTmhYMjl5WjE5MlpYSnBabWxsWkY4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRTFNd29nSUNBZ0x5OGdjMlZzWmk1dmNtZGZZMlZ5ZEdsbWFXTmhkR1ZmWVhOelpYUmZhV1JiYjNKbllXNXBlbUYwYVc5dVgzZGhiR3hsZEYwZ1BTQmpaWEowYVdacFkyRjBaVjloYzNObGRGOXBaQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZMkZmYjNKblgyRnpjMlYwWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyMXdiR2xoYm1ObFgyRjFaR2wwTG1OdmJuUnlZV04wTGtOdmJYQnNhV0Z1WTJWQmRXUnBkQzV5WlhadmEyVmZkbVZ5YVdacFpXUmZiM0puWVc1cGVtRjBhVzl1S0c5eVoyRnVhWHBoZEdsdmJsOTNZV3hzWlhRNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dweVpYWnZhMlZmZG1WeWFXWnBaV1JmYjNKbllXNXBlbUYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJYQnNhV0Z1WTJWZllYVmthWFF2WTI5dWRISmhZM1F1Y0hrNk1UVTFMVEUxTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdjbVYyYjJ0bFgzWmxjbWxtYVdWa1gyOXlaMkZ1YVhwaGRHbHZiaWh6Wld4bUxDQnZjbWRoYm1sNllYUnBiMjVmZDJGc2JHVjBPaUJCWTJOdmRXNTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlISmxkbTlyWlNCdmNtZGhibWw2WVhScGIyNXpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdjbVYyYjJ0bElHOXlaMkZ1YVhwaGRHbHZibk1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakUxT1FvZ0lDQWdMeThnYzJWc1ppNXZjbWRmZG1WeWFXWnBaV1JiYjNKbllXNXBlbUYwYVc5dVgzZGhiR3hsZEYwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTmhYMjl5WjE5MlpYSnBabWxsWkY4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXRjR3hwWVc1alpWOWhkV1JwZEM5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJSE5sYkdZdWIzSm5YMk5sY25ScFptbGpZWFJsWDJGemMyVjBYMmxrVzI5eVoyRnVhWHBoZEdsdmJsOTNZV3hzWlhSZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmpZVjl2Y21kZllYTnpaWFJmSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyMXdiR2xoYm1ObFgyRjFaR2wwTG1OdmJuUnlZV04wTGtOdmJYQnNhV0Z1WTJWQmRXUnBkQzVuWlhSZmIzSm5ZVzVwZW1GMGFXOXVYM1psY21sbWFXTmhkR2x2YmlodmNtZGhibWw2WVhScGIyNWZkMkZzYkdWME9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZMExDQjFhVzUwTmpRNkNtZGxkRjl2Y21kaGJtbDZZWFJwYjI1ZmRtVnlhV1pwWTJGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiWEJzYVdGdVkyVmZZWFZrYVhRdlkyOXVkSEpoWTNRdWNIazZNVFl5TFRFMk13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjl2Y21kaGJtbDZZWFJwYjI1ZmRtVnlhV1pwWTJGMGFXOXVLSE5sYkdZc0lHOXlaMkZ1YVhwaGRHbHZibDkzWVd4c1pYUTZJRUZqWTI5MWJuUXBJQzArSUhSMWNHeGxXMkp2YjJ3c0lGVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXhJRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnZG1WeWFXWnBaV1FzSUhabGNtbG1hV1ZrWDJWNGFYTjBjeUE5SUhObGJHWXViM0puWDNabGNtbG1hV1ZrTG0xaGVXSmxLRzl5WjJGdWFYcGhkR2x2Ymw5M1lXeHNaWFFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pqWVY5dmNtZGZkbVZ5YVdacFpXUmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjIxd2JHbGhibU5sWDJGMVpHbDBMMk52Ym5SeVlXTjBMbkI1T2pFMk5Rb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRc0lHRnpjMlYwWDJWNGFYTjBjeUE5SUhObGJHWXViM0puWDJObGNuUnBabWxqWVhSbFgyRnpjMlYwWDJsa0xtMWhlV0psS0c5eVoyRnVhWHBoZEdsdmJsOTNZV3hzWlhRcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKallWOXZjbWRmWVhOelpYUmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyMXdiR2xoYm1ObFgyRjFaR2wwTDJOdmJuUnlZV04wTG5CNU9qRTJOd29nSUNBZ0x5OGdhWE5mZG1WeWFXWnBaV1FnUFNCMlpYSnBabWxsWkY5bGVHbHpkSE1nWVc1a0lIWmxjbWxtYVdWa0lEMDlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lub2daMlYwWDI5eVoyRnVhWHBoZEdsdmJsOTJaWEpwWm1sallYUnBiMjVmWW05dmJGOW1ZV3h6WlVBekNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQm5aWFJmYjNKbllXNXBlbUYwYVc5dVgzWmxjbWxtYVdOaGRHbHZibDlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ21kbGRGOXZjbWRoYm1sNllYUnBiMjVmZG1WeWFXWnBZMkYwYVc5dVgySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjF3YkdsaGJtTmxYMkYxWkdsMEwyTnZiblJ5WVdOMExuQjVPakUyT0FvZ0lDQWdMeThnYVdZZ2JtOTBJR0Z6YzJWMFgyVjRhWE4wY3pvS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlibm9nWjJWMFgyOXlaMkZ1YVhwaGRHbHZibDkyWlhKcFptbGpZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl0Y0d4cFlXNWpaVjloZFdScGRDOWpiMjUwY21GamRDNXdlVG94TmprS0lDQWdJQzh2SUdGemMyVjBYMmxrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F6Q2dwblpYUmZiM0puWVc1cGVtRjBhVzl1WDNabGNtbG1hV05oZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dGNHeHBZVzVqWlY5aGRXUnBkQzlqYjI1MGNtRmpkQzV3ZVRveE56RUtJQ0FnSUM4dklISmxkSFZ5YmlCcGMxOTJaWEpwWm1sbFpDd2dZWE56WlhSZmFXUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1oyVjBYMjl5WjJGdWFYcGhkR2x2Ymw5MlpYSnBabWxqWVhScGIyNWZZbTl2YkY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQm5aWFJmYjNKbllXNXBlbUYwYVc5dVgzWmxjbWxtYVdOaGRHbHZibDlpYjI5c1gyMWxjbWRsUURRSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUVRUVZIM3gxQUE1dVpYaDBYM0psY0c5eWRGOXBaQkJqWVY5dmNtZGZkbVZ5YVdacFpXUmZEV05oWDI5eVoxOWhjM05sZEY4TFkyRmZZMjl1YzJWdWRGOEdZMkZmZEhoZkNHTmhYM04xYzNCZkNHTmhYM0pwYzJ0ZkNtTmhYM0psWVhOdmJsOE1ZMkZmWlhacFpHVnVZMlZmRG1OaFgzSmxjRjl3WlhKcGIyUmZER05oWDNKbGNGOW9ZWE5vWHcxallWOXlaWEJmZEc5MFlXeGZER05oWDNKbGNGOXpkWE53WHcxallWOXlaWEJmY205MWJtUmZEbU5oWDNKbGNGOXpaVzVrWlhKZk1SaEFBQU1xSW1jeEcwRUJ4SUlLQkhpVU1Ub0VNNnMyVWdSTHUwOWlCSWl3VmdBRVk0RTBIUVN5ZXV1U0JGM3hSSUlFK2VQSUZRUjM1dzY1Qk5kZ21RODJHZ0NPQ2dGZ0FVTUJGZ0RlQU1BQW13QktBRFFBSWdBQ0kwTXhHUlJFTVJoRU5ob0JGOEFjaUFPM2dBRUFJMDhEVkV3V1VDaE1VTEFpUXpFWkZFUXhHRVEyR2dFWHdCeUlBM3dpUXpFWkZFUXhHRVEyR2dFWHdCdzJHZ0lYaUFOSklrTXhHUlJFTVJoRU5ob0JGNGdDc0VzRkZSWlhCZ0pQQmxCTEJSVVdWd1lDVHdaUVR3VVdUd1VXVHdVV1N3UVZnVHdJRmxjR0FvQUNBRHhNVUU4RFVFOENVRXhRVHdOUVR3SlFURkFvVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9ERnpZYUJCZUlBZk1XS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQUlnQnlVa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVJmQUhJZ0JVMDhERms4REZrOERGa3NERlJaWEJnSlBCRkJQQTA4RFVFOENVSUFDQUJwUVRGQW9URkN3SWtNeEdSUkVNUmhFTmhvQkY4QWNOaG9DRnpZYUF5TlROaG9FVndJQU5ob0ZWd0lBTmhvR1Z3SUFpQUNCSWtNeEdSUkVNUmhFTmhvQkY4QWNpQUJTZ0FFQUkwOENWQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRVh3QncyR2dJalU0Z0FEU0pETVJsQS9vUXhHQlJFSWtPS0FnQ0wvakVBRWtBQUNERUFNZ2tTUVFBTUlrUW5CWXYrVUl2L0ZyK0pJMEwvOFlvQkFTY0ZpLzlRdmt3WFRFRUFDb3NBSWhKQkFBTWlUSWtqUXYvNmlnWUFJeWxKTVFBeUNSSkVpL3VCWkE1RWkvMFZSSXYrRlVRbkJvdjZVRW0rVEJkTVFRQlVpd1FpQ0JhTEEweS9Kd2VMK2xCSmpBQytqQUlYakFHTC9FRUFEb3NDUVFBdml3RWlDQmFMQUV5L0p3aUwrbENMK3hhL0p3bUwrbEJKdkVpTC9iK0wveFZCQUFzbkNvditVRW04U0l2L3Y0a2lRdi9SSWtML3JJb0JCQ2NHaS85UXZrd1hUQ2NIaS85UXZrNENGMHduQ0l2L1VMNU9BaGRNSndtTC8xQytUZ0pNUUFBREk0d0Fpd0ZBQUFNampBS0xBMEFBQXlPTUJJc0ZRQUFES1l3R2l3Q0xBb3NFaXdhTUE0d0NqQUdNQUltS0FRRW5Db3YvVUw1QkFBU0xBRXlKS1V5SmlnUUJNUUF5Q1JKRWkvd1ZSSXY5RlVTTC80ditEa1FqS21WRVNSWW5DMHNCVUVtOFNJdjh2eWNNU3dGUVNieElpLzIvSncxTEFWQ0wvaGEvSnc1TEFWQ0wveGEvSnc5TEFWQXlCaGEvSnhCTVVERUF2MGtpQ0NwTVo0bUtBUWFML3hZbkMwc0JVTDVQQWljTVN3RlF2azREVGdJbkRVc0JVTDVPQXhkT0FpY09Td0ZRdms0REYwNENKdzlMQVZDK1RnTVhUZ0luRUV4UXZrNENURUFBQXltTUFJc0JRQUFES1l3Q2l3TkFBQU1qakFTTEJVQUFBeU9NQm9zSFFBQURJNHdJaXdsQUFBUXlBNHdLaXdDTEFvc0Vpd2FMQ0lzS2pBV01CSXdEakFLTUFZd0FpWW9DQURFQU1na1NSSXYvUkN1TC9sQWlGcjhuQkl2K1VJdi9GcitKaWdFQU1RQXlDUkpFSzR2L1VDTVdURXNCdnljRWkvOVFUTCtKaWdFQ0tTdUwvMUMrVEJkTUp3U0wvMUMrVGdJWFRFRUFHNHNCSWhKQkFCUWlqQUNMQWtBQUF5T01BNHNBaXdPTUFZd0FpU09NQUVMLzZRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
