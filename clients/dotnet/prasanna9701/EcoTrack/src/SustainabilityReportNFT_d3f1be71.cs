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

namespace Arc56.Generated.prasanna9701.EcoTrack.SustainabilityReportNFT_d3f1be71
{


    public class SustainabilityReportNFTProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SustainabilityReportNFTProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReportMetadata : AVMObjectType
            {
                public ulong AssetId { get; set; }

                public ulong TotalEmissions { get; set; }

                public ulong Offsets { get; set; }

                public ulong Timestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalEmissions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalEmissions.From(TotalEmissions);
                    ret.AddRange(vTotalEmissions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOffsets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOffsets.From(Offsets);
                    ret.AddRange(vOffsets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReportMetadata Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReportMetadata();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalEmissions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalEmissions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalEmissions = vTotalEmissions.ToValue();
                    if (valueTotalEmissions is ulong vTotalEmissionsValue) { ret.TotalEmissions = vTotalEmissionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOffsets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOffsets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOffsets = vOffsets.ToValue();
                    if (valueOffsets is ulong vOffsetsValue) { ret.Offsets = vOffsetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReportMetadata);
                }
                public bool Equals(ReportMetadata? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReportMetadata left, ReportMetadata right)
                {
                    return EqualityComparer<ReportMetadata>.Default.Equals(left, right);
                }
                public static bool operator !=(ReportMetadata left, ReportMetadata right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class ReportIssuedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 176, 147, 85, 74 };
                public const string Signature = "ReportIssued(byte[32],uint64,byte[],uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field0 { get; set; }
                public ulong Field1 { get; set; }
                public byte[] Field2 { get; set; }
                public ulong Field3 { get; set; }
                public ulong Field4 { get; set; }
                public ulong Field5 { get; set; }

                public static ReportIssuedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ReportIssuedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Called on application creation.
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
        ///Issue a sustainability report as an ARC-69 NFT.
        ///One report per address per period (enforced via box key).
        ///</summary>
        /// <param name="reportHash">- SHA-256 hash of the report data </param>
        /// <param name="reportPeriod">- Human-readable period string (e.g., "FY2025-26") </param>
        /// <param name="reportPeriodHash">- Hash of the period (used as box key component) </param>
        /// <param name="totalEmissionsMT">- Total emissions in metric tons </param>
        /// <param name="offsetsMT">- Total offsets in metric tons </param>
        /// <param name="mbrPay">- Payment for box MBR + ASA MBR </param>
        public async Task<ulong> IssueReport(PaymentTransaction mbrPay, byte[] reportHash, string reportPeriod, byte[] reportPeriodHash, ulong totalEmissionsMT, ulong offsetsMT, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 197, 163, 248, 246 };
            var reportHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); reportHashAbi.From(reportHash);
            var reportPeriodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reportPeriodAbi.From(reportPeriod);
            var reportPeriodHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); reportPeriodHashAbi.From(reportPeriodHash);
            var totalEmissionsMTAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalEmissionsMTAbi.From(totalEmissionsMT);
            var offsetsMTAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetsMTAbi.From(offsetsMT);

            var result = await base.CallApp(new List<object> { abiHandle, reportHashAbi, reportPeriodAbi, reportPeriodHashAbi, totalEmissionsMTAbi, offsetsMTAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IssueReport_Transactions(PaymentTransaction mbrPay, byte[] reportHash, string reportPeriod, byte[] reportPeriodHash, ulong totalEmissionsMT, ulong offsetsMT, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 197, 163, 248, 246 };
            var reportHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); reportHashAbi.From(reportHash);
            var reportPeriodAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reportPeriodAbi.From(reportPeriod);
            var reportPeriodHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); reportPeriodHashAbi.From(reportPeriodHash);
            var totalEmissionsMTAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalEmissionsMTAbi.From(totalEmissionsMT);
            var offsetsMTAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetsMTAbi.From(offsetsMT);

            return await base.MakeTransactionList(new List<object> { abiHandle, reportHashAbi, reportPeriodAbi, reportPeriodHashAbi, totalEmissionsMTAbi, offsetsMTAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify a report exists for a given address and period.
        ///</summary>
        /// <param name="addr">- The address to check </param>
        /// <param name="reportPeriodHash">- Hash of the period </param>
        public async Task<Structs.ReportMetadata> VerifyReport(byte[] addr, byte[] reportPeriodHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 74, 94, 96 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); addrAbi.From(addr);
            var reportPeriodHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); reportPeriodHashAbi.From(reportPeriodHash);

            var result = await base.CallApp(new List<object> { abiHandle, addrAbi, reportPeriodHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReportMetadata.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> VerifyReport_Transactions(byte[] addr, byte[] reportPeriodHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 74, 94, 96 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); addrAbi.From(addr);
            var reportPeriodHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); reportPeriodHashAbi.From(reportPeriodHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, addrAbi, reportPeriodHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3VzdGFpbmFiaWxpdHlSZXBvcnRORlQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUmVwb3J0TWV0YWRhdGEiOlt7Im5hbWUiOiJhc3NldElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsRW1pc3Npb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im9mZnNldHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOiJDYWxsZWQgb24gYXBwbGljYXRpb24gY3JlYXRpb24uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imlzc3VlUmVwb3J0IiwiZGVzYyI6Iklzc3VlIGEgc3VzdGFpbmFiaWxpdHkgcmVwb3J0IGFzIGFuIEFSQy02OSBORlQuXG5PbmUgcmVwb3J0IHBlciBhZGRyZXNzIHBlciBwZXJpb2QgKGVuZm9yY2VkIHZpYSBib3gga2V5KS4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVwb3J0SGFzaCIsImRlc2MiOiItIFNIQS0yNTYgaGFzaCBvZiB0aGUgcmVwb3J0IGRhdGEiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcG9ydFBlcmlvZCIsImRlc2MiOiItIEh1bWFuLXJlYWRhYmxlIHBlcmlvZCBzdHJpbmcgKGUuZy4sIFwiRlkyMDI1LTI2XCIpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBvcnRQZXJpb2RIYXNoIiwiZGVzYyI6Ii0gSGFzaCBvZiB0aGUgcGVyaW9kICh1c2VkIGFzIGJveCBrZXkgY29tcG9uZW50KSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxFbWlzc2lvbnNNVCIsImRlc2MiOiItIFRvdGFsIGVtaXNzaW9ucyBpbiBtZXRyaWMgdG9ucyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2Zmc2V0c01UIiwiZGVzYyI6Ii0gVG90YWwgb2Zmc2V0cyBpbiBtZXRyaWMgdG9ucyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5IiwiZGVzYyI6Ii0gUGF5bWVudCBmb3IgYm94IE1CUiArIEFTQSBNQlIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGNyZWF0ZWQgTkZUIGFzc2V0IElEIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlcG9ydElzc3VlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiI0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiNSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeVJlcG9ydCIsImRlc2MiOiJWZXJpZnkgYSByZXBvcnQgZXhpc3RzIGZvciBhIGdpdmVuIGFkZHJlc3MgYW5kIHBlcmlvZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkciIsImRlc2MiOiItIFRoZSBhZGRyZXNzIHRvIGNoZWNrIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBvcnRQZXJpb2RIYXNoIiwiZGVzYyI6Ii0gSGFzaCBvZiB0aGUgcGVyaW9kIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUmVwb3J0TWV0YWRhdGEiLCJkZXNjIjoiVGhlIHJlcG9ydCBtZXRhZGF0YSBhcyBhIHR1cGxlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTNdLCJlcnJvck1lc3NhZ2UiOiJSZXBvcnQgYWxyZWFkeSBpc3N1ZWQgZm9yIHRoaXMgcGVyaW9kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEwXSwiZXJyb3JNZXNzYWdlIjoiUmVwb3J0IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOV0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OCw4MSw5MywzNzUsMzkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzUsODcsMTAwLDM4MiwzOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExLDEyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWNpSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFjM1JoYVc1aFltbHNhWFI1WDI1bWRDOVRkWE4wWVdsdVlXSnBiR2wwZVZKbGNHOXlkRTVHVkM1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVM1Z6ZEdGcGJtRmlhV3hwZEhsU1pYQnZjblJPUmxRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTmdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdNMVlUTm1PR1kySURCNFlqWTBZVFZsTmpBZ0x5OGdiV1YwYUc5a0lDSnBjM04xWlZKbGNHOXlkQ2hpZVhSbFcxMHNjM1J5YVc1bkxHSjVkR1ZiWFN4MWFXNTBOalFzZFdsdWREWTBMSEJoZVNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5abGNtbG1lVkpsY0c5eWRDaGllWFJsVzEwc1lubDBaVnRkS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dhWE56ZFdWU1pYQnZjblFnZG1WeWFXWjVVbVZ3YjNKMENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYTjBZV2x1WVdKcGJHbDBlVjl1Wm5RdlUzVnpkR0ZwYm1GaWFXeHBkSGxTWlhCdmNuUk9SbFF1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjFjM1JoYVc1aFltbHNhWFI1VW1Wd2IzSjBUa1pVSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpnME5EZGlNellnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU53b2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z6ZEdGcGJtRmlhV3hwZEhsZmJtWjBMMU4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z6ZEdGcGJtRmlhV3hwZEhsZmJtWjBMMU4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxtRnNaMjh1ZEhNNk9sTjFjM1JoYVc1aFltbHNhWFI1VW1Wd2IzSjBUa1pVTG1semMzVmxVbVZ3YjNKMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE56ZFdWU1pYQnZjblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z6ZEdGcGJtRmlhV3hwZEhsZmJtWjBMMU4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxtRnNaMjh1ZEhNNk5UWXROak1LSUNBZ0lDOHZJSEIxWW14cFl5QnBjM04xWlZKbGNHOXlkQ2dLSUNBZ0lDOHZJQ0FnY21Wd2IzSjBTR0Z6YURvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFnSUhKbGNHOXlkRkJsY21sdlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQnlaWEJ2Y25SUVpYSnBiMlJJWVhOb09pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ2RHOTBZV3hGYldsemMybHZibk5OVkRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCdlptWnpaWFJ6VFZRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JXSnlVR0Y1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzQ2lBZ0lDQXZMeUFwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFjM1JoYVc1aFltbHNhWFI1WDI1bWRDOVRkWE4wWVdsdVlXSnBiR2wwZVZKbGNHOXlkRTVHVkM1aGJHZHZMblJ6T2pZMUxUWTNDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2h0WW5KUVlYa3NJSHNLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z6ZEdGcGJtRmlhV3hwZEhsZmJtWjBMMU4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWemRHRnBibUZpYVd4cGRIbGZibVowTDFOMWMzUmhhVzVoWW1sc2FYUjVVbVZ3YjNKMFRrWlVMbUZzWjI4dWRITTZOalV0TmpjS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHMWljbEJoZVN3Z2V3b2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlCOUtRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z6ZEdGcGJtRmlhV3hwZEhsZmJtWjBMMU4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHTnZibk4wSUdKdmVFdGxlVG9nWW5sMFpYTWdQU0J2Y0M1amIyNWpZWFFvVkhodUxuTmxibVJsY2k1aWVYUmxjeXdnY21Wd2IzSjBVR1Z5YVc5a1NHRnphQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWemRHRnBibUZpYVd4cGRIbGZibVowTDFOMWMzUmhhVzVoWW1sc2FYUjVVbVZ3YjNKMFRrWlVMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJSEpsY0c5eWRITWdQU0JDYjNoTllYQThZbmwwWlhNc0lGSmxjRzl5ZEUxbGRHRmtZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dKM0luSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnpkR0ZwYm1GaWFXeHBkSGxmYm1aMEwxTjFjM1JoYVc1aFltbHNhWFI1VW1Wd2IzSjBUa1pVTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUNGMGFHbHpMbkpsY0c5eWRITW9ZbTk0UzJWNUtTNWxlR2x6ZEhNc0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWMzUmhhVzVoWW1sc2FYUjVYMjVtZEM5VGRYTjBZV2x1WVdKcGJHbDBlVkpsY0c5eWRFNUdWQzVoYkdkdkxuUnpPamN6TFRjMkNpQWdJQ0F2THlCaGMzTmxjblFvQ2lBZ0lDQXZMeUFnSUNGMGFHbHpMbkpsY0c5eWRITW9ZbTk0UzJWNUtTNWxlR2x6ZEhNc0NpQWdJQ0F2THlBZ0lDZFNaWEJ2Y25RZ1lXeHlaV0ZrZVNCcGMzTjFaV1FnWm05eUlIUm9hWE1nY0dWeWFXOWtKeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaWEJ2Y25RZ1lXeHlaV0ZrZVNCcGMzTjFaV1FnWm05eUlIUm9hWE1nY0dWeWFXOWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnpkR0ZwYm1GaWFXeHBkSGxmYm1aMEwxTjFjM1JoYVc1aFltbHNhWFI1VW1Wd2IzSjBUa1pVTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUdOdmJuTjBJSFJwYldWemRHRnRjRG9nZFdsdWREWTBJRDBnUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWMzUmhhVzVoWW1sc2FYUjVYMjVtZEM5VGRYTjBZV2x1WVdKcGJHbDBlVkpsY0c5eWRFNUdWQzVoYkdkdkxuUnpPamt4TFRFd01nb2dJQ0FnTHk4Z1kyOXVjM1FnWTNKbFlYUmxWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUkRiMjVtYVdjb2V3b2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc09pQlZhVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE02SUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEU1aGJXVTZJQ2RGWTI5VWNtRmpheUJTWlhCdmNuUW5MQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUk9ZVzFsT2lBblJVTlBVbEJVSnl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abE9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnViM1JsT2lCdWIzUmxVM1J5TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWemRHRnBibUZpYVd4cGRIbGZibVowTDFOMWMzUmhhVzVoWW1sc2FYUjVVbVZ3YjNKMFRrWlVMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJRzFoYm1GblpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYTjBZV2x1WVdKcGJHbDBlVjl1Wm5RdlUzVnpkR0ZwYm1GaWFXeHBkSGxTWlhCdmNuUk9SbFF1WVd4bmJ5NTBjem81T0FvZ0lDQWdMeThnY21WelpYSjJaVG9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYTjBZV2x1WVdKcGJHbDBlVjl1Wm5RdlUzVnpkR0ZwYm1GaWFXeHBkSGxTWlhCdmNuUk9SbFF1WVd4bmJ5NTBjem81T1FvZ0lDQWdMeThnYm05MFpUb2dibTkwWlZOMGNpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaWUxd2ljM1JoYm1SaGNtUmNJanBjSW1GeVl6WTVYQ0lzWENKa1pYTmpjbWx3ZEdsdmJsd2lPbHdpUldOdlZISmhZMnNnVTNWemRHRnBibUZpYVd4cGRIa2dVbVZ3YjNKMFhDSXNYQ0p0WldScFlWUjVjR1ZjSWpwY0ltRndjR3hwWTJGMGFXOXVMMnB6YjI1Y0luMGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFNXZkR1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJTWlhObGNuWmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWMzUmhhVzVoWW1sc2FYUjVYMjVtZEM5VGRYTjBZV2x1WVdKcGJHbDBlVkpsY0c5eWRFNUdWQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUIxYm1sMFRtRnRaVG9nSjBWRFQxSlFWQ2NzQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZEVDFKUVZDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWMzUmhhVzVoWW1sc2FYUjVYMjVtZEM5VGRYTjBZV2x1WVdKcGJHbDBlVkpsY0c5eWRFNUdWQzVoYkdkdkxuUnpPamsxQ2lBZ0lDQXZMeUJoYzNObGRFNWhiV1U2SUNkRlkyOVVjbUZqYXlCU1pYQnZjblFuTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGWTI5VWNtRmpheUJTWlhCdmNuUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYzNSaGFXNWhZbWxzYVhSNVgyNW1kQzlUZFhOMFlXbHVZV0pwYkdsMGVWSmxjRzl5ZEU1R1ZDNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QmtaV05wYldGc2N6b2dWV2x1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWMzUmhhVzVoWW1sc2FYUjVYMjVtZEM5VGRYTjBZV2x1WVdKcGJHbDBlVkpsY0c5eWRFNUdWQzVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUIwYjNSaGJEb2dWV2x1ZERZMEtERXBMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYzNSaGFXNWhZbWxzYVhSNVgyNW1kQzlUZFhOMFlXbHVZV0pwYkdsMGVWSmxjRzl5ZEU1R1ZDNWhiR2R2TG5Sek9qa3hMVEV3TVFvZ0lDQWdMeThnWTI5dWMzUWdZM0psWVhSbFZIaHVJRDBnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSRGIyNW1hV2NvZXdvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzT2lCVmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRTVoYldVNklDZEZZMjlVY21GamF5QlNaWEJ2Y25RbkxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhST1lXMWxPaUFuUlVOUFVsQlVKeXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxPaUJ1YjNSbFUzUnlMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJSEIxYzJocGJuUWdNeUF2THlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z6ZEdGcGJtRmlhV3hwZEhsZmJtWjBMMU4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxtRnNaMjh1ZEhNNk1UQXdDaUFnSUNBdkx5Qm1aV1U2SURBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZFhOMFlXbHVZV0pwYkdsMGVWOXVablF2VTNWemRHRnBibUZpYVd4cGRIbFNaWEJ2Y25ST1JsUXVZV3huYnk1MGN6bzVNUzB4TURJS0lDQWdJQzh2SUdOdmJuTjBJR055WldGMFpWUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFEyOXVabWxuS0hzS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkRvZ1ZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJPWVcxbE9pQW5SV052VkhKaFkyc2dVbVZ3YjNKMEp5d0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFRtRnRaVG9nSjBWRFQxSlFWQ2NzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlRvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVG9nYm05MFpWTjBjaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGemMyVjBTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWE4wWVdsdVlXSnBiR2wwZVY5dVpuUXZVM1Z6ZEdGcGJtRmlhV3hwZEhsU1pYQnZjblJPUmxRdVlXeG5ieTUwY3pveE1EY3RNVEV5Q2lBZ0lDQXZMeUJqYjI1emRDQnRaWFJoWkdGMFlUb2dVbVZ3YjNKMFRXVjBZV1JoZEdFZ1BTQjdDaUFnSUNBdkx5QWdJR0Z6YzJWMFNXUTZJRzVsZDBGemMyVjBTV1FzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNSVzFwYzNOcGIyNXpPaUIwYjNSaGJFVnRhWE56YVc5dWMwMVVMQW9nSUNBZ0x5OGdJQ0J2Wm1aelpYUnpPaUJ2Wm1aelpYUnpUVlFzQ2lBZ0lDQXZMeUFnSUhScGJXVnpkR0Z0Y0RvZ2RHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z2ZRb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1Z6ZEdGcGJtRmlhV3hwZEhsZmJtWjBMMU4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxtRnNaMjh1ZEhNNk1URXpDaUFnSUNBdkx5QjBhR2x6TG5KbGNHOXlkSE1vWW05NFMyVjVLUzUyWVd4MVpTQTlJR05zYjI1bEtHMWxkR0ZrWVhSaEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWemRHRnBibUZpYVd4cGRIbGZibVowTDFOMWMzUmhhVzVoWW1sc2FYUjVVbVZ3YjNKMFRrWlVMbUZzWjI4dWRITTZNVEUzQ2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5TG1KNWRHVnpMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWMzUmhhVzVoWW1sc2FYUjVYMjVtZEM5VGRYTjBZV2x1WVdKcGJHbDBlVkpsY0c5eWRFNUdWQzVoYkdkdkxuUnpPakV4TmkweE1qTUtJQ0FnSUM4dklHVnRhWFE4VW1Wd2IzSjBTWE56ZFdWa1BpZ25VbVZ3YjNKMFNYTnpkV1ZrSnl3S0lDQWdJQzh2SUNBZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3S0lDQWdJQzh2SUNBZ2JtVjNRWE56WlhSSlpDd0tJQ0FnSUM4dklDQWdjbVZ3YjNKMFNHRnphQ3dLSUNBZ0lDOHZJQ0FnZEc5MFlXeEZiV2x6YzJsdmJuTk5WQ3dLSUNBZ0lDOHZJQ0FnYjJabWMyVjBjMDFVTEFvZ0lDQWdMeThnSUNCMGFXMWxjM1JoYlhBc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZakE1TXpVMU5HRWdMeThnYldWMGFHOWtJQ0pTWlhCdmNuUkpjM04xWldRb1lubDBaVnN6TWwwc2RXbHVkRFkwTEdKNWRHVmJYU3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMWMzUmhhVzVoWW1sc2FYUjVYMjVtZEM5VGRYTjBZV2x1WVdKcGJHbDBlVkpsY0c5eWRFNUdWQzVoYkdkdkxuUnpPalUyTFRZekNpQWdJQ0F2THlCd2RXSnNhV01nYVhOemRXVlNaWEJ2Y25Rb0NpQWdJQ0F2THlBZ0lISmxjRzl5ZEVoaGMyZzZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQnlaWEJ2Y25SUVpYSnBiMlE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnY21Wd2IzSjBVR1Z5YVc5a1NHRnphRG9nWW5sMFpYTXNDaUFnSUNBdkx5QWdJSFJ2ZEdGc1JXMXBjM05wYjI1elRWUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdiMlptYzJWMGMwMVVPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJRzFpY2xCaGVUb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxBb2dJQ0FnTHk4Z0tUb2dkV2x1ZERZMElIc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNWemRHRnBibUZpYVd4cGRIbGZibVowTDFOMWMzUmhhVzVoWW1sc2FYUjVVbVZ3YjNKMFRrWlVMbUZzWjI4dWRITTZPbE4xYzNSaGFXNWhZbWxzYVhSNVVtVndiM0owVGtaVUxuWmxjbWxtZVZKbGNHOXlkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVkpsY0c5eWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRYTjBZV2x1WVdKcGJHbDBlVjl1Wm5RdlUzVnpkR0ZwYm1GaWFXeHBkSGxTWlhCdmNuUk9SbFF1WVd4bmJ5NTBjem94TXpVdE1UTTRDaUFnSUNBdkx5QndkV0pzYVdNZ2RtVnlhV1o1VW1Wd2IzSjBLQW9nSUNBZ0x5OGdJQ0JoWkdSeU9pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ2NtVndiM0owVUdWeWFXOWtTR0Z6YURvZ1lubDBaWE1zQ2lBZ0lDQXZMeUFwT2lCU1pYQnZjblJOWlhSaFpHRjBZU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWE4wWVdsdVlXSnBiR2wwZVY5dVpuUXZVM1Z6ZEdGcGJtRmlhV3hwZEhsU1pYQnZjblJPUmxRdVlXeG5ieTUwY3pveE16a0tJQ0FnSUM4dklHTnZibk4wSUdKdmVFdGxlVG9nWW5sMFpYTWdQU0J2Y0M1amIyNWpZWFFvWVdSa2Npd2djbVZ3YjNKMFVHVnlhVzlrU0dGemFDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjFjM1JoYVc1aFltbHNhWFI1WDI1bWRDOVRkWE4wWVdsdVlXSnBiR2wwZVZKbGNHOXlkRTVHVkM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCeVpYQnZjblJ6SUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JTWlhCdmNuUk5aWFJoWkdGMFlUNG9leUJyWlhsUWNtVm1hWGc2SUNkeUp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04xYzNSaGFXNWhZbWxzYVhSNVgyNW1kQzlUZFhOMFlXbHVZV0pwYkdsMGVWSmxjRzl5ZEU1R1ZDNWhiR2R2TG5Sek9qRTBNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11Y21Wd2IzSjBjeWhpYjNoTFpYa3BMbVY0YVhOMGN5d2dKMUpsY0c5eWRDQnViM1FnWm05MWJtUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWlhCdmNuUWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzVnpkR0ZwYm1GaWFXeHBkSGxmYm1aMEwxTjFjM1JoYVc1aFltbHNhWFI1VW1Wd2IzSjBUa1pVTG1Gc1oyOHVkSE02TVRReENpQWdJQ0F2THlCeVpYUjFjbTRnWTJ4dmJtVW9kR2hwY3k1eVpYQnZjblJ6S0dKdmVFdGxlU2t1ZG1Gc2RXVXBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkWE4wWVdsdVlXSnBiR2wwZVY5dVpuUXZVM1Z6ZEdGcGJtRmlhV3hwZEhsU1pYQnZjblJPUmxRdVlXeG5ieTUwY3pveE16VXRNVE00Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkbVZ5YVdaNVVtVndiM0owS0FvZ0lDQWdMeThnSUNCaFpHUnlPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdjbVZ3YjNKMFVHVnlhVzlrU0dGemFEb2dZbmwwWlhNc0NpQWdJQ0F2THlBcE9pQlNaWEJ2Y25STlpYUmhaR0YwWVNCN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0NZQ0FYSUVGUjk4ZFRFWkZFUXhHRUVBRm9JQ0JNV2orUFlFdGtwZVlEWWFBSTRDQUJFQlJBQ0FCTGhFZXpZMkdnQ09BUUFCQUNORE5ob0JTU0paSkFoTEFSVVNSRFlhQWtraVdTUUlUQlVTUkRZYUEwa2lXU1FJU3dFVkVrUlhBZ0EyR2dSSkZTVVNSRWtYTmhvRlNSVWxFa1JKRnpFV0l3bEpPQkFqRWtRNEJ6SUtFa1F4QUU4RlVDaE1VRW05UlFFVVJESUhzVElLU1lCaWV5SnpkR0Z1WkdGeVpDSTZJbUZ5WXpZNUlpd2laR1Z6WTNKcGNIUnBiMjRpT2lKRlkyOVVjbUZqYXlCVGRYTjBZV2x1WVdKcGJHbDBlU0JTWlhCdmNuUWlMQ0p0WldScFlWUjVjR1VpT2lKaGNIQnNhV05oZEdsdmJpOXFjMjl1SW4yeUJiSXFzaW1BQmtWRFQxSlFWTElsZ0E5RlkyOVVjbUZqYXlCU1pYQnZjblN5SmlLeUl5T3lJb0VEc2hBaXNnR3p0RHdXVHdVV1N3Rk1VRThFRmxCUEFoWk1Td0ZRVHdOTXZ6RUFTd0pRZ0FJQVFsQlBCRkJQQTFCTVVFOENVSUFFc0pOVlNreFFzQ2xNVUxBalF6WWFBVWtpV1NRSVN3RVZFa1JYQWdBMkdnSkpJbGtrQ0VzQkZSSkVWd0lBVUNoTVVFbTlSUUZFdmtncFRGQ3dJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVwb3J0SXNzdWVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiI1IiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
