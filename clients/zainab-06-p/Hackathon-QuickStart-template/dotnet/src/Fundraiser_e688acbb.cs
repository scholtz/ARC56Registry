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

namespace Arc56.Generated.zainab_06_p.Hackathon_QuickStart_template.Fundraiser_e688acbb
{


    //
    // 
    //    CampusChain Multi-Signature Fundraiser Contract
    //    Milestone-based crowdfunding with ON-CHAIN decentralized approvals
    //    Requires ALL 3 approvers to sign before milestone release
    //    100% DECENTRALIZED - No Firebase or centralized database!
    //    
    //
    public class FundraiserProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FundraiserProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStatusReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public bool Field5 { get; set; }

                public bool Field6 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStatusReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is bool vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is bool vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetStatusReturn);
                }
                public bool Equals(GetStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStatusReturn left, GetStatusReturn right)
                {
                    return EqualityComparer<GetStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStatusReturn left, GetStatusReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetApproversReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetApproversReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetApproversReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetApproversReturn);
                }
                public bool Equals(GetApproversReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetApproversReturn left, GetApproversReturn right)
                {
                    return EqualityComparer<GetApproversReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetApproversReturn left, GetApproversReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetApprovalStatusReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetApprovalStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetApprovalStatusReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetApprovalStatusReturn);
                }
                public bool Equals(GetApprovalStatusReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetApprovalStatusReturn left, GetApprovalStatusReturn right)
                {
                    return EqualityComparer<GetApprovalStatusReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetApprovalStatusReturn left, GetApprovalStatusReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create campaign with 3 mandatory approvers
        ///All 3 must approve each milestone before funds can be released
        ///</summary>
        /// <param name="goal"> </param>
        /// <param name="milestones"> </param>
        /// <param name="deadline"> </param>
        /// <param name="approver1"> </param>
        /// <param name="approver2"> </param>
        /// <param name="approver3"> </param>
        public async Task<ulong> CreateCampaign(ulong goal, ulong milestones, ulong deadline, Algorand.Address approver1, Algorand.Address approver2, Algorand.Address approver3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 165, 214, 174 };
            var goalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goalAbi.From(goal);
            var milestonesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestonesAbi.From(milestones);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var approver1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver1Abi.From(approver1);
            var approver2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver2Abi.From(approver2);
            var approver3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver3Abi.From(approver3);

            var result = await base.CallApp(new List<object> { abiHandle, goalAbi, milestonesAbi, deadlineAbi, approver1Abi, approver2Abi, approver3Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateCampaign_Transactions(ulong goal, ulong milestones, ulong deadline, Algorand.Address approver1, Algorand.Address approver2, Algorand.Address approver3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 165, 214, 174 };
            var goalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); goalAbi.From(goal);
            var milestonesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestonesAbi.From(milestones);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);
            var approver1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver1Abi.From(approver1);
            var approver2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver2Abi.From(approver2);
            var approver3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver3Abi.From(approver3);

            return await base.MakeTransactionList(new List<object> { abiHandle, goalAbi, milestonesAbi, deadlineAbi, approver1Abi, approver2Abi, approver3Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Donate to the campaign
        ///</summary>
        /// <param name="payment"> </param>
        public async Task<ulong> Donate(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 228, 195, 224, 16 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Donate_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 228, 195, 224, 16 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Store IPFS CID for campaign media (image/video)
        ///Creator only, can be called once Requires box MBR funding: 2500 + 400 * (5 + cid_length) microAlgos Max CID length: 64 characters
        ///</summary>
        /// <param name="cid"> </param>
        public async Task<ulong> SetMediaCid(byte[] cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 255, 64, 125 };
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cidAbi.From(cid);

            var result = await base.CallApp(new List<object> { abiHandle, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetMediaCid_Transactions(byte[] cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 255, 64, 125 };
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); cidAbi.From(cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve IPFS CID for campaign media
        ///Returns empty bytes if no media set
        ///</summary>
        public async Task<byte[]> GetMediaCid(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 16, 141, 248 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetMediaCid_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 16, 141, 248 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///🔐 DECENTRALIZED ON-CHAIN APPROVAL
        ///Approvers call this to approve the current milestone Replaces Firebase - all approvals stored on blockchain! Returns: number of approvals received (1, 2, or 3)
        ///</summary>
        public async Task<ulong> ApproveMilestone(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 62, 238, 18 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApproveMilestone_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 62, 238, 18 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Release funds for current milestone (creator only)
        ///🔒 REQUIRES ALL 3 APPROVERS TO HAVE APPROVED FIRST This ensures multi-signature security on-chain!
        ///</summary>
        public async Task<ulong> ReleaseMilestone(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 33, 192, 81 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReleaseMilestone_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 33, 192, 81 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get campaign status
        ///</summary>
        public async Task<Structs.GetStatusReturn> GetStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 69, 105, 221 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 69, 105, 221 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get campaign creator address
        ///</summary>
        public async Task<Algorand.Address> GetCreator(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 42, 14, 25 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetCreator_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 42, 14, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get campaign deadline
        ///</summary>
        public async Task<ulong> GetDeadline(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 247, 135, 87 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDeadline_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 247, 135, 87 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all approver addresses (on-chain query)
        ///</summary>
        public async Task<Structs.GetApproversReturn> GetApprovers(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 125, 129, 5 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetApproversReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetApprovers_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 125, 129, 5 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current approval status for each approver
        ///Returns (approver1_approved, approver2_approved, approver3_approved) Frontend can use this instead of Firebase!
        ///</summary>
        public async Task<Structs.GetApprovalStatusReturn> GetApprovalStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 166, 19, 42 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetApprovalStatusReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetApprovalStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 166, 19, 42 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a specific address has approved the current milestone
        ///</summary>
        /// <param name="approver_address"> </param>
        public async Task<bool> HasApproved(Algorand.Address approver_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 188, 116, 252 };
            var approver_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver_addressAbi.From(approver_address);

            var result = await base.SimApp(new List<object> { abiHandle, approver_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasApproved_Transactions(Algorand.Address approver_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 188, 116, 252 };
            var approver_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); approver_addressAbi.From(approver_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, approver_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get number of approvals for current milestone
        ///</summary>
        public async Task<ulong> GetApprovalCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 164, 176, 24 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetApprovalCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 164, 176, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if an address is one of the approvers
        ///</summary>
        /// <param name="address"> </param>
        public async Task<bool> IsApprover(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 33, 223, 136 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsApprover_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 33, 223, 136 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRnVuZHJhaXNlciIsImRlc2MiOiJcbiAgICBDYW1wdXNDaGFpbiBNdWx0aS1TaWduYXR1cmUgRnVuZHJhaXNlciBDb250cmFjdFxuICAgIE1pbGVzdG9uZS1iYXNlZCBjcm93ZGZ1bmRpbmcgd2l0aCBPTi1DSEFJTiBkZWNlbnRyYWxpemVkIGFwcHJvdmFsc1xuICAgIFJlcXVpcmVzIEFMTCAzIGFwcHJvdmVycyB0byBzaWduIGJlZm9yZSBtaWxlc3RvbmUgcmVsZWFzZVxuICAgIDEwMCUgREVDRU5UUkFMSVpFRCAtIE5vIEZpcmViYXNlIG9yIGNlbnRyYWxpemVkIGRhdGFiYXNlIVxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRTdGF0dXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6ImJvb2wifV0sIkdldEFwcHJvdmVyc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiR2V0QXBwcm92YWxTdGF0dXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2NhbXBhaWduIiwiZGVzYyI6IkNyZWF0ZSBjYW1wYWlnbiB3aXRoIDMgbWFuZGF0b3J5IGFwcHJvdmVyc1xuQWxsIDMgbXVzdCBhcHByb3ZlIGVhY2ggbWlsZXN0b25lIGJlZm9yZSBmdW5kcyBjYW4gYmUgcmVsZWFzZWQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ29hbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWlsZXN0b25lcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVhZGxpbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlcjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlcjIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlcjMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkb25hdGUiLCJkZXNjIjoiRG9uYXRlIHRvIHRoZSBjYW1wYWlnbiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X21lZGlhX2NpZCIsImRlc2MiOiJTdG9yZSBJUEZTIENJRCBmb3IgY2FtcGFpZ24gbWVkaWEgKGltYWdlL3ZpZGVvKVxuQ3JlYXRvciBvbmx5LCBjYW4gYmUgY2FsbGVkIG9uY2UgUmVxdWlyZXMgYm94IE1CUiBmdW5kaW5nOiAyNTAwICsgNDAwICogKDUgKyBjaWRfbGVuZ3RoKSBtaWNyb0FsZ29zIE1heCBDSUQgbGVuZ3RoOiA2NCBjaGFyYWN0ZXJzIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tZWRpYV9jaWQiLCJkZXNjIjoiUmV0cmlldmUgSVBGUyBDSUQgZm9yIGNhbXBhaWduIG1lZGlhXG5SZXR1cm5zIGVtcHR5IGJ5dGVzIGlmIG5vIG1lZGlhIHNldCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmVfbWlsZXN0b25lIiwiZGVzYyI6IvCflJAgREVDRU5UUkFMSVpFRCBPTi1DSEFJTiBBUFBST1ZBTFxuQXBwcm92ZXJzIGNhbGwgdGhpcyB0byBhcHByb3ZlIHRoZSBjdXJyZW50IG1pbGVzdG9uZSBSZXBsYWNlcyBGaXJlYmFzZSAtIGFsbCBhcHByb3ZhbHMgc3RvcmVkIG9uIGJsb2NrY2hhaW4hIFJldHVybnM6IG51bWJlciBvZiBhcHByb3ZhbHMgcmVjZWl2ZWQgKDEsIDIsIG9yIDMpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVsZWFzZV9taWxlc3RvbmUiLCJkZXNjIjoiUmVsZWFzZSBmdW5kcyBmb3IgY3VycmVudCBtaWxlc3RvbmUgKGNyZWF0b3Igb25seSlcbvCflJIgUkVRVUlSRVMgQUxMIDMgQVBQUk9WRVJTIFRPIEhBVkUgQVBQUk9WRUQgRklSU1QgVGhpcyBlbnN1cmVzIG11bHRpLXNpZ25hdHVyZSBzZWN1cml0eSBvbi1jaGFpbiEiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdHVzIiwiZGVzYyI6IkdldCBjYW1wYWlnbiBzdGF0dXMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6IkdldFN0YXR1c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jcmVhdG9yIiwiZGVzYyI6IkdldCBjYW1wYWlnbiBjcmVhdG9yIGFkZHJlc3MiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZGVhZGxpbmUiLCJkZXNjIjoiR2V0IGNhbXBhaWduIGRlYWRsaW5lIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXBwcm92ZXJzIiwiZGVzYyI6IkdldCBhbGwgYXBwcm92ZXIgYWRkcmVzc2VzIChvbi1jaGFpbiBxdWVyeSkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzKSIsInN0cnVjdCI6IkdldEFwcHJvdmVyc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FwcHJvdmFsX3N0YXR1cyIsImRlc2MiOiJHZXQgY3VycmVudCBhcHByb3ZhbCBzdGF0dXMgZm9yIGVhY2ggYXBwcm92ZXJcblJldHVybnMgKGFwcHJvdmVyMV9hcHByb3ZlZCwgYXBwcm92ZXIyX2FwcHJvdmVkLCBhcHByb3ZlcjNfYXBwcm92ZWQpIEZyb250ZW5kIGNhbiB1c2UgdGhpcyBpbnN0ZWFkIG9mIEZpcmViYXNlISIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiR2V0QXBwcm92YWxTdGF0dXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imhhc19hcHByb3ZlZCIsImRlc2MiOiJDaGVjayBpZiBhIHNwZWNpZmljIGFkZHJlc3MgaGFzIGFwcHJvdmVkIHRoZSBjdXJyZW50IG1pbGVzdG9uZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwcm92ZXJfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hcHByb3ZhbF9jb3VudCIsImRlc2MiOiJHZXQgbnVtYmVyIG9mIGFwcHJvdmFscyBmb3IgY3VycmVudCBtaWxlc3RvbmUiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2FwcHJvdmVyIiwiZGVzYyI6IkNoZWNrIGlmIGFuIGFkZHJlc3MgaXMgb25lIG9mIHRoZSBhcHByb3ZlcnMiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MTIsImJ5dGVzIjo0fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5OTAsMTEzMl0sImVycm9yTWVzc2FnZSI6IkFsbCBtaWxlc3RvbmVzIGNvbXBsZXRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDgsMTA4NCwxMTA1XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBhcHByb3ZlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNDNdLCJlcnJvck1lc3NhZ2UiOiJBcHByb3ZlciAxIGhhcyBub3QgYXBwcm92ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQ4XSwiZXJyb3JNZXNzYWdlIjoiQXBwcm92ZXIgMiBoYXMgbm90IGFwcHJvdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1M10sImVycm9yTWVzc2FnZSI6IkFwcHJvdmVyIDMgaGFzIG5vdCBhcHByb3ZlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzM10sImVycm9yTWVzc2FnZSI6IkNJRCB0b28gbG9uZyAobWF4IDY0IGNoYXJzKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzM10sImVycm9yTWVzc2FnZSI6IkNhbXBhaWduIGVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODI0XSwiZXJyb3JNZXNzYWdlIjoiQ2FtcGFpZ24gbm90IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3OF0sImVycm9yTWVzc2FnZSI6IkNhbm5vdCBhcHByb3ZlIC0gZ29hbCBub3QgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzhdLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgcmVsZWFzZSBmdW5kcyAtIGdvYWwgbm90IHJlYWNoZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzldLCJlcnJvck1lc3NhZ2UiOiJGYWlsZWQgdG8gY3JlYXRlIG1lZGlhIGJveCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0NV0sImVycm9yTWVzc2FnZSI6IkdvYWwgYWxyZWFkeSByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3NV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBiYWxhbmNlIGFmdGVyIE1CUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyNV0sImVycm9yTWVzc2FnZSI6Ik1lZGlhIGFscmVhZHkgc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTY1XSwiZXJyb3JNZXNzYWdlIjoiTWVkaWEgYm94IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2MV0sImVycm9yTWVzc2FnZSI6Ik1pbmltdW0gMC4xIEFMR08gZG9uYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjAsMzg1LDQwMiw0MjcsNDc3LDQ5OCw1MTUsNTMxLDU5OSw2MTYsNjMzLDY1Nyw2ODAsNzA3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA5OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYXBwcm92ZXJzIGNhbiBhcHByb3ZlIG1pbGVzdG9uZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTIwXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiByZWxlYXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTE4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBzZXQgbWVkaWEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTY5XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjMsMzg4LDQwNSw0MzAsNDgwLDUwMSw1MTgsNTM0LDYwMiw2MTksNjM2LDY2MCw2ODNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTk4LDEyNzEsMTMwMywxNDI0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hcHByb3ZlcjEgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwNiwxMDE4LDExNDIsMTI4NiwxMzEzLDEzNThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFwcHJvdmVyMV9hcHByb3ZlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDcyLDEyNzYsMTMxOSwxNDM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hcHByb3ZlcjIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyOCwxMDgyLDExNDcsMTI5MCwxMzI5LDEzNjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFwcHJvdmVyMl9hcHByb3ZlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk1LDEyODEsMTMzNSwxNDUwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hcHByb3ZlcjMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA1MCwxMTAzLDExNTIsMTI5NCwxMzQ1LDEzOTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFwcHJvdmVyM19hcHByb3ZlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NzYsMTI0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29udHJpYnV0b3JfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTE2LDExMTgsMTE4MSwxMjU5LDE0MTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNyZWF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTgzLDExMjUsMTE5NywxMjE3LDEyMzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmN1cnJlbnRfbWlsZXN0b25lIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzMSwxMjY1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZWFkbGluZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDMsODkyLDExNTgsMTIyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ29hbF9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc3LDExMzcsMTI1M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ29hbF9yZWFjaGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyMywxMjQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc19hY3RpdmUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIzLDk1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWVkaWFfY2lkX2xlbmd0aCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODgsMTEzMCwxMTYzLDEyMzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbGVzdG9uZV9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzgsODY2LDg4Nyw5MDUsMTIyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmFpc2VkX2Ftb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTVRBd01EQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdJbUZ3Y0hKdmRtVnlNVjloY0hCeWIzWmxaQ0lnSW1Gd2NISnZkbVZ5TWw5aGNIQnliM1psWkNJZ0ltRndjSEp2ZG1WeU0xOWhjSEJ5YjNabFpDSWdNSGd3TUNBaWNtRnBjMlZrWDJGdGIzVnVkQ0lnSW1OMWNuSmxiblJmYldsc1pYTjBiMjVsSWlBaVkzSmxZWFJ2Y2lJZ0ltZHZZV3hmWVcxdmRXNTBJaUFpYldsc1pYTjBiMjVsWDJOdmRXNTBJaUFpWjI5aGJGOXlaV0ZqYUdWa0lpQWlZWEJ3Y205MlpYSXhJaUFpWVhCd2NtOTJaWEl5SWlBaVlYQndjbTkyWlhJeklpQWlZMjl1ZEhKcFluVjBiM0pmWTI5MWJuUWlJQ0p0WldScFlWOWphV1JmYkdWdVozUm9JaUFpWkdWaFpHeHBibVVpSUNKcGMxOWhZM1JwZG1VaUlEQjRObVEyTlRZME5qazJNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdSblZ1WkhKaGFYTmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1ZtWVRWa05tRmxJREI0WlRSak0yVXdNVEFnTUhnMk1HWm1OREEzWkNBd2VEVXhNVEE0WkdZNElEQjRNelV6WldWbE1USWdNSGhqTWpJeFl6QTFNU0F3ZUdGbU5EVTJPV1JrSURCNE1qQXlZVEJsTVRrZ01IZzJOV1kzT0RjMU55QXdlR001TjJRNE1UQTFJREI0WldKaE5qRXpNbUVnTUhnd1ptSmpOelJtWXlBd2VETXlZVFJpTURFNElEQjRPREF5TVdSbU9EZ2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZZMkZ0Y0dGcFoyNG9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmtiMjVoZEdVb2NHRjVLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljMlYwWDIxbFpHbGhYMk5wWkNoaWVYUmxXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZmJXVmthV0ZmWTJsa0tDbGllWFJsVzEwaUxDQnRaWFJvYjJRZ0ltRndjSEp2ZG1WZmJXbHNaWE4wYjI1bEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxiR1ZoYzJWZmJXbHNaWE4wYjI1bEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjl6ZEdGMGRYTW9LU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3c1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1kbGRGOWpjbVZoZEc5eUtDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSm5aWFJmWkdWaFpHeHBibVVvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyRndjSEp2ZG1WeWN5Z3BLR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOektTSXNJRzFsZEdodlpDQWlaMlYwWDJGd2NISnZkbUZzWDNOMFlYUjFjeWdwS0dKdmIyd3NZbTl2YkN4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpYUdGelgyRndjSEp2ZG1Wa0tHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyRndjSEp2ZG1Gc1gyTnZkVzUwS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1selgyRndjSEp2ZG1WeUtHRmtaSEpsYzNNcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgyTmhiWEJoYVdkdVgzSnZkWFJsUURNZ2JXRnBibDlrYjI1aGRHVmZjbTkxZEdWQU5DQnRZV2x1WDNObGRGOXRaV1JwWVY5amFXUmZjbTkxZEdWQU5TQnRZV2x1WDJkbGRGOXRaV1JwWVY5amFXUmZjbTkxZEdWQU5pQnRZV2x1WDJGd2NISnZkbVZmYldsc1pYTjBiMjVsWDNKdmRYUmxRRGNnYldGcGJsOXlaV3hsWVhObFgyMXBiR1Z6ZEc5dVpWOXliM1YwWlVBNElHMWhhVzVmWjJWMFgzTjBZWFIxYzE5eWIzVjBaVUE1SUcxaGFXNWZaMlYwWDJOeVpXRjBiM0pmY205MWRHVkFNVEFnYldGcGJsOW5aWFJmWkdWaFpHeHBibVZmY205MWRHVkFNVEVnYldGcGJsOW5aWFJmWVhCd2NtOTJaWEp6WDNKdmRYUmxRREV5SUcxaGFXNWZaMlYwWDJGd2NISnZkbUZzWDNOMFlYUjFjMTl5YjNWMFpVQXhNeUJ0WVdsdVgyaGhjMTloY0hCeWIzWmxaRjl5YjNWMFpVQXhOQ0J0WVdsdVgyZGxkRjloY0hCeWIzWmhiRjlqYjNWdWRGOXliM1YwWlVBeE5TQnRZV2x1WDJselgyRndjSEp2ZG1WeVgzSnZkWFJsUURFMkNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNakE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJHZFc1a2NtRnBjMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHpYMkZ3Y0hKdmRtVnlYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpjNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRVoxYm1SeVlXbHpaWElvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakkzT0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCcGMxOWhjSEJ5YjNabGNnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgyRndjSEp2ZG1Gc1gyTnZkVzUwWDNKdmRYUmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qWTJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwWDJGd2NISnZkbUZzWDJOdmRXNTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyaGhjMTloY0hCeWIzWmxaRjl5YjNWMFpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJMU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJHZFc1a2NtRnBjMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG95TlRJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ2FHRnpYMkZ3Y0hKdmRtVmtDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZZWEJ3Y205MllXeGZjM1JoZEhWelgzSnZkWFJsUURFek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNak01Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyRndjSEp2ZG1Gc1gzTjBZWFIxY3dvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNCemQyRndDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDJGd2NISnZkbVZ5YzE5eWIzVjBaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXpNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5aGNIQnliM1psY25NS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5a1pXRmtiR2x1WlY5eWIzVjBaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXlOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5a1pXRmtiR2x1WlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZlkzSmxZWFJ2Y2w5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXlNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5amNtVmhkRzl5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5emRHRjBkWE5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJd053b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzTjBZWFIxY3dvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJSE5sZEdKcGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIQjFjMmhwYm5RZ016SXhJQzh2SURNeU1Rb2dJQ0FnYzNkaGNBb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxiR1ZoYzJWZmJXbHNaWE4wYjI1bFgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlISmxiR1ZoYzJWZmJXbHNaWE4wYjI1bENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGd2NISnZkbVZmYldsc1pYTjBiMjVsWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdGd2NISnZkbVZmYldsc1pYTjBiMjVsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5dFpXUnBZVjlqYVdSZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXhNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMjFsWkdsaFgyTnBaQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBYMjFsWkdsaFgyTnBaRjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCR2RXNWtjbUZwYzJWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ6WlhSZmJXVmthV0ZmWTJsa0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJSdmJtRjBaVjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QmpiR0Z6Y3lCR2RXNWtjbUZwYzJWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdaRzl1WVhSbENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjlqWVcxd1lXbG5ibDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TXpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSjA1dlQzQW5YU3dnWTNKbFlYUmxQU2R5WlhGMWFYSmxKeWtLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJHZFc1a2NtRnBjMlZ5S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNuVG05UGNDZGRMQ0JqY21WaGRHVTlKM0psY1hWcGNtVW5LUW9nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZmWTJGdGNHRnBaMjRLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpuVnVaSEpoYVhObGNpNWpiMjUwY21GamRDNUdkVzVrY21GcGMyVnlMbU55WldGMFpWOWpZVzF3WVdsbmJpaG5iMkZzT2lCMWFXNTBOalFzSUcxcGJHVnpkRzl1WlhNNklIVnBiblEyTkN3Z1pHVmhaR3hwYm1VNklIVnBiblEyTkN3Z1lYQndjbTkyWlhJeE9pQmllWFJsY3l3Z1lYQndjbTkyWlhJeU9pQmllWFJsY3l3Z1lYQndjbTkyWlhJek9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGpjbVZoZEdWZlkyRnRjR0ZwWjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUb3pOUzAwTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNuVG05UGNDZGRMQ0JqY21WaGRHVTlKM0psY1hWcGNtVW5LUW9nSUNBZ0x5OGdaR1ZtSUdOeVpXRjBaVjlqWVcxd1lXbG5iaWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUdkdllXdzZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0J0YVd4bGMzUnZibVZ6T2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmhaR3hwYm1VNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJ5YjNabGNqRTZJRUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhCd2NtOTJaWEl5T2lCQlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRndjSEp2ZG1WeU16b2dRV1JrY21WemN3b2dJQ0FnTHk4Z0tTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUEySURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QnpaV3htTG1kdllXeGZZVzF2ZFc1MElEMGdaMjloYkFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWjI5aGJGOWhiVzkxYm5RaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdjMlZzWmk1eVlXbHpaV1JmWVcxdmRXNTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p5WVdselpXUmZZVzF2ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUbzFNUW9nSUNBZ0x5OGdjMlZzWmk1dGFXeGxjM1J2Ym1WZlkyOTFiblFnUFNCdGFXeGxjM1J2Ym1WekNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKdGFXeGxjM1J2Ym1WZlkyOTFiblFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z2MyVnNaaTVqZFhKeVpXNTBYMjFwYkdWemRHOXVaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTNWeWNtVnVkRjl0YVd4bGMzUnZibVVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCelpXeG1MbVJsWVdSc2FXNWxJRDBnWkdWaFpHeHBibVVLSUNBZ0lHSjVkR1ZqSURFMklDOHZJQ0prWldGa2JHbHVaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCelpXeG1MbWx6WDJGamRHbDJaU0E5SUZSeWRXVUtJQ0FnSUdKNWRHVmpJREUzSUM4dklDSnBjMTloWTNScGRtVWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJ6Wld4bUxtTnlaV0YwYjNJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmpjbVZoZEc5eUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QnpaV3htTG1OdmJuUnlhV0oxZEc5eVgyTnZkVzUwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVkyOXVkSEpwWW5WMGIzSmZZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTNDaUFnSUNBdkx5QnpaV3htTG1kdllXeGZjbVZoWTJobFpDQTlJRVpoYkhObENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVoyOWhiRjl5WldGamFHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG8xT1MwMk1Bb2dJQ0FnTHk4Z0l5QlRkRzl5WlNCaGNIQnliM1psY2lCaFpHUnlaWE56WlhNZ0tHTnZiblpsY25RZ1FWSkROQ0JCWkdSeVpYTnpJSFJ2SUc1aGRHbDJaU0JCWTJOdmRXNTBLUW9nSUNBZ0x5OGdjMlZzWmk1aGNIQnliM1psY2pFZ1BTQmhjSEJ5YjNabGNqRXVibUYwYVhabENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVlYQndjbTkyWlhJeElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZOakVLSUNBZ0lDOHZJSE5sYkdZdVlYQndjbTkyWlhJeUlEMGdZWEJ3Y205MlpYSXlMbTVoZEdsMlpRb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltRndjSEp2ZG1WeU1pSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJ6Wld4bUxtRndjSEp2ZG1WeU15QTlJR0Z3Y0hKdmRtVnlNeTV1WVhScGRtVUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSmhjSEJ5YjNabGNqTWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG8yTkMwMk5Rb2dJQ0FnTHk4Z0l5QkpibWwwYVdGc2FYcGxJR0ZzYkNCaGNIQnliM1poYkhNZ2RHOGdabUZzYzJVS0lDQWdJQzh2SUhObGJHWXVZWEJ3Y205MlpYSXhYMkZ3Y0hKdmRtVmtJRDBnUm1Gc2MyVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRndjSEp2ZG1WeU1WOWhjSEJ5YjNabFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJSE5sYkdZdVlYQndjbTkyWlhJeVgyRndjSEp2ZG1Wa0lEMGdSbUZzYzJVS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Gd2NISnZkbVZ5TWw5aGNIQnliM1psWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklITmxiR1l1WVhCd2NtOTJaWEl6WDJGd2NISnZkbVZrSUQwZ1JtRnNjMlVLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ3Y0hKdmRtVnlNMTloY0hCeWIzWmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUhObGJHWXViV1ZrYVdGZlkybGtYMnhsYm1kMGFDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbTFsWkdsaFgyTnBaRjlzWlc1bmRHZ2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aMWJtUnlZV2x6WlhJdVkyOXVkSEpoWTNRdVJuVnVaSEpoYVhObGNpNWtiMjVoZEdVb2NHRjViV1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNtUnZibUYwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qY3lMVGN6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQmtiMjVoZEdVb2MyVnNaaXdnY0dGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZISmhibk5oWTNScGIyNHBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgyRmpkR2wyWlN3Z0lrTmhiWEJoYVdkdUlHNXZkQ0JoWTNScGRtVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVGNnTHk4Z0ltbHpYMkZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5aFkzUnBkbVVnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1EyRnRjR0ZwWjI0Z2JtOTBJR0ZqZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBOFBTQnpaV3htTG1SbFlXUnNhVzVsTENBaVEyRnRjR0ZwWjI0Z1pXNWtaV1FpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbVJsWVdSc2FXNWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1SbFlXUnNhVzVsSUdWNGFYTjBjd29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCRFlXMXdZV2xuYmlCbGJtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuSmhhWE5sWkY5aGJXOTFiblFnUENCelpXeG1MbWR2WVd4ZllXMXZkVzUwTENBaVIyOWhiQ0JoYkhKbFlXUjVJSEpsWVdOb1pXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNtRnBjMlZrWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVlXbHpaV1JmWVcxdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1kdllXeGZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWR2WVd4ZllXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUVkdllXd2dZV3h5WldGa2VTQnlaV0ZqYUdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNWhiVzkxYm5RZ1BqMGdWVWx1ZERZMEtERXdNREF3TUNrc0lDSk5hVzVwYlhWdElEQXVNU0JCVEVkUElHUnZibUYwYVc5dUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TURBd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJOYVc1cGJYVnRJREF1TVNCQlRFZFBJR1J2Ym1GMGFXOXVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnYzJWc1ppNXlZV2x6WldSZllXMXZkVzUwSUNzOUlIQmhlVzFsYm5RdVlXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWljbUZwYzJWa1gyRnRiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlZV2x6WldSZllXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNtRnBjMlZrWDJGdGIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1MGNtbGlkWFJ2Y2w5amIzVnVkQ0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpWTI5dWRISnBZblYwYjNKZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOXVkSEpwWW5WMGIzSmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0ltTnZiblJ5YVdKMWRHOXlYMk52ZFc1MElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPamcwTFRnMUNpQWdJQ0F2THlBaklFTm9aV05ySUdsbUlHZHZZV3dnYVhNZ2NtVmhZMmhsWkFvZ0lDQWdMeThnYVdZZ2MyVnNaaTV5WVdselpXUmZZVzF2ZFc1MElENDlJSE5sYkdZdVoyOWhiRjloYlc5MWJuUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNtRnBjMlZrWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVlXbHpaV1JmWVcxdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1kdllXeGZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWR2WVd4ZllXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ1BqMEtJQ0FnSUdKNklHUnZibUYwWlY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCelpXeG1MbWR2WVd4ZmNtVmhZMmhsWkNBOUlGUnlkV1VLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0puYjJGc1gzSmxZV05vWldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtUnZibUYwWlY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjbUZwYzJWa1gyRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbkpoYVhObFpGOWhiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbUZwYzJWa1gyRnRiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW1kVzVrY21GcGMyVnlMbU52Ym5SeVlXTjBMa1oxYm1SeVlXbHpaWEl1YzJWMFgyMWxaR2xoWDJOcFpDaGphV1E2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q25ObGRGOXRaV1JwWVY5amFXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG81TUMwNU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnYzJWMFgyMWxaR2xoWDJOcFpDaHpaV3htTENCamFXUTZJRUo1ZEdWektTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtTnlaV0YwYjNJc0lDSlBibXg1SUdOeVpXRjBiM0lnWTJGdUlITmxkQ0J0WldScFlTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pqY21WaGRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OeVpXRjBiM0lnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZM0psWVhSdmNpQmpZVzRnYzJWMElHMWxaR2xoQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXViV1ZrYVdGZlkybGtYMnhsYm1kMGFDQTlQU0JWU1c1ME5qUW9NQ2tzSUNKTlpXUnBZU0JoYkhKbFlXUjVJSE5sZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpYldWa2FXRmZZMmxrWDJ4bGJtZDBhQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dFpXUnBZVjlqYVdSZmJHVnVaM1JvSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUUxbFpHbGhJR0ZzY21WaFpIa2djMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHTnBaRjlzWlc0Z1BTQmphV1F1YkdWdVozUm9DaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZMmxrWDJ4bGJpQThQU0JWU1c1ME5qUW9OalFwTENBaVEwbEVJSFJ2YnlCc2IyNW5JQ2h0WVhnZ05qUWdZMmhoY25NcElnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFkwSUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVOSlJDQjBiMjhnYkc5dVp5QW9iV0Y0SURZMElHTm9ZWEp6S1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UQTBMVEV3TmdvZ0lDQWdMeThnSXlCRGNtVmhkR1VnWW05NElIUnZJSE4wYjNKbElIUm9aU0JEU1VRS0lDQWdJQzh2SUNNZ1FtOTRJRTFDVWpvZ01qVXdNQ0FySURRd01DQXFJQ2cxSUNzZ2JHVnVLR05wWkNrcENpQWdJQ0F2THlCaGMzTmxjblFnYjNBdVFtOTRMbU55WldGMFpTaENlWFJsY3loaUltMWxaR2xoSWlrc0lHTnBaRjlzWlc0cExDQWlSbUZwYkdWa0lIUnZJR055WldGMFpTQnRaV1JwWVNCaWIzZ2lDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QXdlRFprTmpVMk5EWTVOakVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCaGMzTmxjblFnTHk4Z1JtRnBiR1ZrSUhSdklHTnlaV0YwWlNCdFpXUnBZU0JpYjNnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdiM0F1UW05NExuQjFkQ2hDZVhSbGN5aGlJbTFsWkdsaElpa3NJR05wWkNrS0lDQWdJR0o1ZEdWaklERTRJQzh2SURCNE5tUTJOVFkwTmprMk1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUhObGJHWXViV1ZrYVdGZlkybGtYMnhsYm1kMGFDQTlJR05wWkY5c1pXNEtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSnRaV1JwWVY5amFXUmZiR1Z1WjNSb0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUhKbGRIVnliaUJqYVdSZmJHVnVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpuVnVaSEpoYVhObGNpNWpiMjUwY21GamRDNUdkVzVrY21GcGMyVnlMbWRsZEY5dFpXUnBZVjlqYVdRb0tTQXRQaUJpZVhSbGN6b0taMlYwWDIxbFpHbGhYMk5wWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdhV1lnYzJWc1ppNXRaV1JwWVY5amFXUmZiR1Z1WjNSb0lEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWliV1ZrYVdGZlkybGtYMnhsYm1kMGFDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WldScFlWOWphV1JmYkdWdVozUm9JR1Y0YVhOMGN3b2dJQ0FnWW01NklHZGxkRjl0WldScFlWOWphV1JmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUhKbGRIVnliaUJDZVhSbGN5aGlJaUlwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lISmxkSE4xWWdvS1oyVjBYMjFsWkdsaFgyTnBaRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG94TWpFS0lDQWdJQzh2SUdOcFpGOWllWFJsY3l3Z1pYaHBjM1J6SUQwZ2IzQXVRbTk0TG1kbGRDaENlWFJsY3loaUltMWxaR2xoSWlrcENpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBd2VEWmtOalUyTkRZNU5qRUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjeXdnSWsxbFpHbGhJR0p2ZUNCdWIzUWdabTkxYm1RaUNpQWdJQ0JoYzNObGNuUWdMeThnVFdWa2FXRWdZbTk0SUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QnlaWFIxY200Z1kybGtYMko1ZEdWekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Wm5WdVpISmhhWE5sY2k1amIyNTBjbUZqZEM1R2RXNWtjbUZwYzJWeUxtRndjSEp2ZG1WZmJXbHNaWE4wYjI1bEtDa2dMVDRnZFdsdWREWTBPZ3BoY0hCeWIzWmxYMjFwYkdWemRHOXVaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU5TMHhNallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHRndjSEp2ZG1WZmJXbHNaWE4wYjI1bEtITmxiR1lwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklEQWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakV6TXdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVoyOWhiRjl5WldGamFHVmtMQ0FpUTJGdWJtOTBJR0Z3Y0hKdmRtVWdMU0JuYjJGc0lHNXZkQ0J5WldGamFHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSm5iMkZzWDNKbFlXTm9aV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVoyOWhiRjl5WldGamFHVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUVOaGJtNXZkQ0JoY0hCeWIzWmxJQzBnWjI5aGJDQnViM1FnY21WaFkyaGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWpkWEp5Wlc1MFgyMXBiR1Z6ZEc5dVpTQThJSE5sYkdZdWJXbHNaWE4wYjI1bFgyTnZkVzUwTENBaVFXeHNJRzFwYkdWemRHOXVaWE1nWTI5dGNHeGxkR1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbU4xY25KbGJuUmZiV2xzWlhOMGIyNWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OMWNuSmxiblJmYldsc1pYTjBiMjVsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltMXBiR1Z6ZEc5dVpWOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhV3hsYzNSdmJtVmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHNJRzFwYkdWemRHOXVaWE1nWTI5dGNHeGxkR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveE16WXRNVE0zQ2lBZ0lDQXZMeUFqSUVOb1pXTnJJR2xtSUhObGJtUmxjaUJwY3lCdmJtVWdiMllnZEdobElHRndjSEp2ZG1WeWN5QmhibVFnYldGeWF5QjBhR1ZwY2lCaGNIQnliM1poYkFvZ0lDQWdMeThnYzJWdVpHVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG94TkRBS0lDQWdJQzh2SUdsbUlITmxibVJsY2lBOVBTQnpaV3htTG1Gd2NISnZkbVZ5TVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWVhCd2NtOTJaWEl4SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRndjSEp2ZG1WeU1TQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmllaUJoY0hCeWIzWmxYMjFwYkdWemRHOXVaVjlsYkhObFgySnZaSGxBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UUXhDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJSE5sYkdZdVlYQndjbTkyWlhJeFgyRndjSEp2ZG1Wa0xDQWlRV3h5WldGa2VTQmhjSEJ5YjNabFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGNIQnliM1psY2pGZllYQndjbTkyWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWEJ3Y205MlpYSXhYMkZ3Y0hKdmRtVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2dZWEJ3Y205MlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakUwTWdvZ0lDQWdMeThnYzJWc1ppNWhjSEJ5YjNabGNqRmZZWEJ3Y205MlpXUWdQU0JVY25WbENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGNIQnliM1psY2pGZllYQndjbTkyWldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtRndjSEp2ZG1WZmJXbHNaWE4wYjI1bFgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTFOUzB4TlRZS0lDQWdJQzh2SUNNZ1EyOTFiblFnZEc5MFlXd2dZWEJ3Y205MllXeHpDaUFnSUNBdkx5QmhjSEJ5YjNaaGJGOWpiM1Z1ZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UVTNDaUFnSUNBdkx5QnBaaUJ6Wld4bUxtRndjSEp2ZG1WeU1WOWhjSEJ5YjNabFpEb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGNIQnliM1psY2pGZllYQndjbTkyWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWEJ3Y205MlpYSXhYMkZ3Y0hKdmRtVmtJR1Y0YVhOMGN3b2dJQ0FnWW5vZ1lYQndjbTkyWlY5dGFXeGxjM1J2Ym1WZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UVTRDaUFnSUNBdkx5QmhjSEJ5YjNaaGJGOWpiM1Z1ZENBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0NtRndjSEp2ZG1WZmJXbHNaWE4wYjI1bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR2xtSUhObGJHWXVZWEJ3Y205MlpYSXlYMkZ3Y0hKdmRtVmtPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRndjSEp2ZG1WeU1sOWhjSEJ5YjNabFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoY0hCeWIzWmxjakpmWVhCd2NtOTJaV1FnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JpZWlCaGNIQnliM1psWDIxcGJHVnpkRzl1WlY5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5qQUtJQ0FnSUM4dklHRndjSEp2ZG1Gc1gyTnZkVzUwSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbUZ3Y0hKdmRtVmZiV2xzWlhOMGIyNWxYMkZtZEdWeVgybG1YMlZzYzJWQU1UTTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdhV1lnYzJWc1ppNWhjSEJ5YjNabGNqTmZZWEJ3Y205MlpXUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlYQndjbTkyWlhJelgyRndjSEp2ZG1Wa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZ3Y0hKdmRtVnlNMTloY0hCeWIzWmxaQ0JsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWW5vZ1lYQndjbTkyWlY5dGFXeGxjM1J2Ym1WZllXWjBaWEpmYVdaZlpXeHpaVUF4TlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QmhjSEJ5YjNaaGJGOWpiM1Z1ZENBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3BoY0hCeWIzWmxYMjFwYkdWemRHOXVaVjloWm5SbGNsOXBabDlsYkhObFFERTFPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnY21WMGRYSnVJR0Z3Y0hKdmRtRnNYMk52ZFc1MENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tZWEJ3Y205MlpWOXRhV3hsYzNSdmJtVmZaV3h6WlY5aWIyUjVRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5EUUtJQ0FnSUM4dklHVnNhV1lnYzJWdVpHVnlJRDA5SUhObGJHWXVZWEJ3Y205MlpYSXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSmhjSEJ5YjNabGNqSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhCd2NtOTJaWEl5SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNIQnliM1psWDIxcGJHVnpkRzl1WlY5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNVFExQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVZWEJ3Y205MlpYSXlYMkZ3Y0hKdmRtVmtMQ0FpUVd4eVpXRmtlU0JoY0hCeWIzWmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjSEJ5YjNabGNqSmZZWEJ3Y205MlpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhCd2NtOTJaWEl5WDJGd2NISnZkbVZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2NtVmhaSGtnWVhCd2NtOTJaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pFME5nb2dJQ0FnTHk4Z2MyVnNaaTVoY0hCeWIzWmxjakpmWVhCd2NtOTJaV1FnUFNCVWNuVmxDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjSEJ5YjNabGNqSmZZWEJ3Y205MlpXUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdJZ1lYQndjbTkyWlY5dGFXeGxjM1J2Ym1WZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2dwaGNIQnliM1psWDIxcGJHVnpkRzl1WlY5bGJITmxYMkp2WkhsQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakUwT0FvZ0lDQWdMeThnWld4cFppQnpaVzVrWlhJZ1BUMGdjMlZzWmk1aGNIQnliM1psY2pNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UTWdMeThnSW1Gd2NISnZkbVZ5TXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhjSEJ5YjNabGNqTWdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGd2NISnZkbVZ5Y3lCallXNGdZWEJ3Y205MlpTQnRhV3hsYzNSdmJtVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG94TkRrS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTVoY0hCeWIzWmxjak5mWVhCd2NtOTJaV1FzSUNKQmJISmxZV1I1SUdGd2NISnZkbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ3Y0hKdmRtVnlNMTloY0hCeWIzWmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGNIQnliM1psY2pOZllYQndjbTkyWldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCaGNIQnliM1psWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UVXdDaUFnSUNBdkx5QnpaV3htTG1Gd2NISnZkbVZ5TTE5aGNIQnliM1psWkNBOUlGUnlkV1VLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ3Y0hKdmRtVnlNMTloY0hCeWIzWmxaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lpQmhjSEJ5YjNabFgyMXBiR1Z6ZEc5dVpWOWhablJsY2w5cFpsOWxiSE5sUURrS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVablZ1WkhKaGFYTmxjaTVqYjI1MGNtRmpkQzVHZFc1a2NtRnBjMlZ5TG5KbGJHVmhjMlZmYldsc1pYTjBiMjVsS0NrZ0xUNGdkV2x1ZERZME9ncHlaV3hsWVhObFgyMXBiR1Z6ZEc5dVpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakUzTXdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVqY21WaGRHOXlMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJ5Wld4bFlYTmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1OeVpXRjBiM0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkzSmxZWFJ2Y2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCeVpXeGxZWE5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveE56UUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbU4xY25KbGJuUmZiV2xzWlhOMGIyNWxJRHdnYzJWc1ppNXRhV3hsYzNSdmJtVmZZMjkxYm5Rc0lDSkJiR3dnYldsc1pYTjBiMjVsY3lCamIyMXdiR1YwWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTNWeWNtVnVkRjl0YVd4bGMzUnZibVVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkzVnljbVZ1ZEY5dGFXeGxjM1J2Ym1VZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWliV2xzWlhOMGIyNWxYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFwYkdWemRHOXVaVjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiR3dnYldsc1pYTjBiMjVsY3lCamIyMXdiR1YwWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTNOUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WjI5aGJGOXlaV0ZqYUdWa0xDQWlRMkZ1Ym05MElISmxiR1ZoYzJVZ1puVnVaSE1nTFNCbmIyRnNJRzV2ZENCeVpXRmphR1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0puYjJGc1gzSmxZV05vWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaMjloYkY5eVpXRmphR1ZrSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklFTmhibTV2ZENCeVpXeGxZWE5sSUdaMWJtUnpJQzBnWjI5aGJDQnViM1FnY21WaFkyaGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRjM0xURTNPQW9nSUNBZ0x5OGdJeUR3bjVTUUlFTlNTVlJKUTBGTU9pQldaWEpwWm5rZ1FVeE1JR0Z3Y0hKdmRtVnljeUJvWVhabElHRndjSEp2ZG1Wa0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWhjSEJ5YjNabGNqRmZZWEJ3Y205MlpXUXNJQ0pCY0hCeWIzWmxjaUF4SUdoaGN5QnViM1FnWVhCd2NtOTJaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZWEJ3Y205MlpYSXhYMkZ3Y0hKdmRtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Gd2NISnZkbVZ5TVY5aGNIQnliM1psWkNCbGVHbHpkSE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QkJjSEJ5YjNabGNpQXhJR2hoY3lCdWIzUWdZWEJ3Y205MlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakUzT1FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVlYQndjbTkyWlhJeVgyRndjSEp2ZG1Wa0xDQWlRWEJ3Y205MlpYSWdNaUJvWVhNZ2JtOTBJR0Z3Y0hKdmRtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRndjSEp2ZG1WeU1sOWhjSEJ5YjNabFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoY0hCeWIzWmxjakpmWVhCd2NtOTJaV1FnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z1FYQndjbTkyWlhJZ01pQm9ZWE1nYm05MElHRndjSEp2ZG1Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUb3hPREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1Gd2NISnZkbVZ5TTE5aGNIQnliM1psWkN3Z0lrRndjSEp2ZG1WeUlETWdhR0Z6SUc1dmRDQmhjSEJ5YjNabFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaGNIQnliM1psY2pOZllYQndjbTkyWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWEJ3Y205MlpYSXpYMkZ3Y0hKdmRtVmtJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBJQzh2SUVGd2NISnZkbVZ5SURNZ2FHRnpJRzV2ZENCaGNIQnliM1psWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UZ3lMVEU0TXdvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ1lXMXZkVzUwSUhCbGNpQnRhV3hsYzNSdmJtVUtJQ0FnSUM4dklHRnRiM1Z1ZEY5d1pYSmZiV2xzWlhOMGIyNWxJRDBnYzJWc1ppNW5iMkZzWDJGdGIzVnVkQ0F2THlCelpXeG1MbTFwYkdWemRHOXVaVjlqYjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1kdllXeGZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWR2WVd4ZllXMXZkVzUwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltMXBiR1Z6ZEc5dVpWOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhV3hsYzNSdmJtVmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG94T0RjS0lDQWdJQzh2SUdOdmJuUnlZV04wWDJKaGJHRnVZMlVnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG1KaGJHRnVZMlVLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUpoYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRnNENpQWdJQ0F2THlCaGMzTmxjblFnWTI5dWRISmhZM1JmWW1Gc1lXNWpaU0ErUFNCaGJXOTFiblJmY0dWeVgyMXBiR1Z6ZEc5dVpTQXJJRzFwYmw5aVlXeGhibU5sTENBaVNXNXpkV1ptYVdOcFpXNTBJR0poYkdGdVkyVWdZV1owWlhJZ1RVSlNJZ29nSUNBZ1pHbG5JREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pFNE5TMHhPRFlLSUNBZ0lDOHZJQ01nVW1WelpYSjJaU0J0YVc1cGJYVnRJR0poYkdGdVkyVWdLREF1TVNCQlRFZFBLUW9nSUNBZ0x5OGdiV2x1WDJKaGJHRnVZMlVnUFNCVlNXNTBOalFvTVRBd01EQXdLUW9nSUNBZ2FXNTBZMTh5SUM4dklERXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1UZzRDaUFnSUNBdkx5QmhjM05sY25RZ1kyOXVkSEpoWTNSZlltRnNZVzVqWlNBK1BTQmhiVzkxYm5SZmNHVnlYMjFwYkdWemRHOXVaU0FySUcxcGJsOWlZV3hoYm1ObExDQWlTVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVnWVdaMFpYSWdUVUpTSWdvZ0lDQWdLd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdZbUZzWVc1alpTQmhablJsY2lCTlFsSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakU1TUMweE9UVUtJQ0FnSUM4dklDTWdVMlZ1WkNCbWRXNWtjeUIwYnlCamNtVmhkRzl5Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1amNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJXOTFiblJmY0dWeVgyMXBiR1Z6ZEc5dVpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Bb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1Ua3lDaUFnSUNBdkx5QnlaV05sYVhabGNqMXpaV3htTG1OeVpXRjBiM0lzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqY21WaGRHOXlJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakU1TUMweE9URUtJQ0FnSUM4dklDTWdVMlZ1WkNCbWRXNWtjeUIwYnlCamNtVmhkRzl5Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveE9UUUtJQ0FnSUM4dklHWmxaVDB3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pFNU1DMHhPVFVLSUNBZ0lDOHZJQ01nVTJWdVpDQm1kVzVrY3lCMGJ5QmpjbVZoZEc5eUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNWpjbVZoZEc5eUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5SZmNHVnlYMjFwYkdWemRHOXVaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakU1TnkweE9UZ0tJQ0FnSUM4dklDTWdTVzVqY21WdFpXNTBJRzFwYkdWemRHOXVaU0JqYjNWdWRHVnlDaUFnSUNBdkx5QnpaV3htTG1OMWNuSmxiblJmYldsc1pYTjBiMjVsSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OMWNuSmxiblJmYldsc1pYTjBiMjVsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTjFjbkpsYm5SZmJXbHNaWE4wYjI1bElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltTjFjbkpsYm5SZmJXbHNaWE4wYjI1bElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakl3TUMweU1ERUtJQ0FnSUM4dklDTWc4SitVaENCU1JWTkZWQ0JoY0hCeWIzWmhiSE1nWm05eUlHNWxlSFFnYldsc1pYTjBiMjVsQ2lBZ0lDQXZMeUJ6Wld4bUxtRndjSEp2ZG1WeU1WOWhjSEJ5YjNabFpDQTlJRVpoYkhObENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaGNIQnliM1psY2pGZllYQndjbTkyWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXdNZ29nSUNBZ0x5OGdjMlZzWmk1aGNIQnliM1psY2pKZllYQndjbTkyWldRZ1BTQkdZV3h6WlFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhCd2NtOTJaWEl5WDJGd2NISnZkbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1ETUtJQ0FnSUM4dklITmxiR1l1WVhCd2NtOTJaWEl6WDJGd2NISnZkbVZrSUQwZ1JtRnNjMlVLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ3Y0hKdmRtVnlNMTloY0hCeWIzWmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpBMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWpkWEp5Wlc1MFgyMXBiR1Z6ZEc5dVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OMWNuSmxiblJmYldsc1pYTjBiMjVsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTjFjbkpsYm5SZmJXbHNaWE4wYjI1bElHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVoxYm1SeVlXbHpaWEl1WTI5dWRISmhZM1F1Um5WdVpISmhhWE5sY2k1blpYUmZjM1JoZEhWektDa2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwblpYUmZjM1JoZEhWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNakV4Q2lBZ0lDQXZMeUJ6Wld4bUxtZHZZV3hmWVcxdmRXNTBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltZHZZV3hmWVcxdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kdllXeGZZVzF2ZFc1MElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5QnpaV3htTG5KaGFYTmxaRjloYlc5MWJuUXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNtRnBjMlZrWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVlXbHpaV1JmWVcxdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNakV6Q2lBZ0lDQXZMeUJ6Wld4bUxtTjFjbkpsYm5SZmJXbHNaWE4wYjI1bExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1OMWNuSmxiblJmYldsc1pYTjBiMjVsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTjFjbkpsYm5SZmJXbHNaWE4wYjI1bElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qRTBDaUFnSUNBdkx5QnpaV3htTG0xcGJHVnpkRzl1WlY5amIzVnVkQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnRhV3hsYzNSdmJtVmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV2xzWlhOMGIyNWxYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qRTFDaUFnSUNBdkx5QnpaV3htTG1OdmJuUnlhV0oxZEc5eVgyTnZkVzUwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pqYjI1MGNtbGlkWFJ2Y2w5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIyNTBjbWxpZFhSdmNsOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE5nb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5aFkzUnBkbVVzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbWx6WDJGamRHbDJaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMxOWhZM1JwZG1VZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1UY0tJQ0FnSUM4dklITmxiR1l1WjI5aGJGOXlaV0ZqYUdWa0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW1kdllXeGZjbVZoWTJobFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVuYjJGc1gzSmxZV05vWldRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1UQXRNakU0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXVaMjloYkY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaTV5WVdselpXUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZdVkzVnljbVZ1ZEY5dGFXeGxjM1J2Ym1Vc0NpQWdJQ0F2THlBZ0lDQWdjMlZzWmk1dGFXeGxjM1J2Ym1WZlkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaTVqYjI1MGNtbGlkWFJ2Y2w5amIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MbWx6WDJGamRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MbWR2WVd4ZmNtVmhZMmhsWkFvZ0lDQWdMeThnS1FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVoxYm1SeVlXbHpaWEl1WTI5dWRISmhZM1F1Um5WdVpISmhhWE5sY2k1blpYUmZZM0psWVhSdmNpZ3BJQzArSUdKNWRHVnpPZ3BuWlhSZlkzSmxZWFJ2Y2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXlNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WTNKbFlYUnZjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZM0psWVhSdmNpQmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVtZFc1a2NtRnBjMlZ5TG1OdmJuUnlZV04wTGtaMWJtUnlZV2x6WlhJdVoyVjBYMlJsWVdSc2FXNWxLQ2tnTFQ0Z2RXbHVkRFkwT2dwblpYUmZaR1ZoWkd4cGJtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG95TWpnS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtUmxZV1JzYVc1bENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UWWdMeThnSW1SbFlXUnNhVzVsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxZV1JzYVc1bElHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVoxYm1SeVlXbHpaWEl1WTI5dWRISmhZM1F1Um5WdVpISmhhWE5sY2k1blpYUmZZWEJ3Y205MlpYSnpLQ2tnTFQ0Z1lubDBaWE1zSUdKNWRHVnpMQ0JpZVhSbGN6b0taMlYwWDJGd2NISnZkbVZ5Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXpOQW9nSUNBZ0x5OGdRV1JrY21WemN5aHpaV3htTG1Gd2NISnZkbVZ5TVM1aWVYUmxjeWtzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbUZ3Y0hKdmRtVnlNU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGNIQnliM1psY2pFZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveU16VUtJQ0FnSUM4dklFRmtaSEpsYzNNb2MyVnNaaTVoY0hCeWIzWmxjakl1WW5sMFpYTXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSmhjSEJ5YjNabGNqSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhCd2NtOTJaWEl5SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpNMkNpQWdJQ0F2THlCQlpHUnlaWE56S0hObGJHWXVZWEJ3Y205MlpYSXpMbUo1ZEdWektRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKaGNIQnliM1psY2pNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWEJ3Y205MlpYSXpJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNak16TFRJek53b2dJQ0FnTHk4Z2NtVjBkWEp1SUNnS0lDQWdJQzh2SUNBZ0lDQkJaR1J5WlhOektITmxiR1l1WVhCd2NtOTJaWEl4TG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCQlpHUnlaWE56S0hObGJHWXVZWEJ3Y205MlpYSXlMbUo1ZEdWektTd0tJQ0FnSUM4dklDQWdJQ0JCWkdSeVpYTnpLSE5sYkdZdVlYQndjbTkyWlhJekxtSjVkR1Z6S1FvZ0lDQWdMeThnS1FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVoxYm1SeVlXbHpaWEl1WTI5dWRISmhZM1F1Um5WdVpISmhhWE5sY2k1blpYUmZZWEJ3Y205MllXeGZjM1JoZEhWektDa2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Eb0taMlYwWDJGd2NISnZkbUZzWDNOMFlYUjFjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJME53b2dJQ0FnTHk4Z2MyVnNaaTVoY0hCeWIzWmxjakZmWVhCd2NtOTJaV1FzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZWEJ3Y205MlpYSXhYMkZ3Y0hKdmRtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Gd2NISnZkbVZ5TVY5aGNIQnliM1psWkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJME9Bb2dJQ0FnTHk4Z2MyVnNaaTVoY0hCeWIzWmxjakpmWVhCd2NtOTJaV1FzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEJ3Y205MlpYSXlYMkZ3Y0hKdmRtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Gd2NISnZkbVZ5TWw5aGNIQnliM1psWkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJME9Rb2dJQ0FnTHk4Z2MyVnNaaTVoY0hCeWIzWmxjak5mWVhCd2NtOTJaV1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjSEJ5YjNabGNqTmZZWEJ3Y205MlpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhCd2NtOTJaWEl6WDJGd2NISnZkbVZrSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpRMkxUSTFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxtRndjSEp2ZG1WeU1WOWhjSEJ5YjNabFpDd0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxtRndjSEp2ZG1WeU1sOWhjSEJ5YjNabFpDd0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxtRndjSEp2ZG1WeU0xOWhjSEJ5YjNabFpBb2dJQ0FnTHk4Z0tRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aMWJtUnlZV2x6WlhJdVkyOXVkSEpoWTNRdVJuVnVaSEpoYVhObGNpNW9ZWE5mWVhCd2NtOTJaV1FvWVhCd2NtOTJaWEpmWVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LYUdGelgyRndjSEp2ZG1Wa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNalV5TFRJMU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHaGhjMTloY0hCeWIzWmxaQ2h6Wld4bUxDQmhjSEJ5YjNabGNsOWhaR1J5WlhOek9pQkJaR1J5WlhOektTQXRQaUJpYjI5c09nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveU5UY0tJQ0FnSUM4dklHbG1JSE5sYm1SbGNsOWhZMk52ZFc1MElEMDlJSE5sYkdZdVlYQndjbTkyWlhJeE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKaGNIQnliM1psY2pFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWEJ3Y205MlpYSXhJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZbm9nYUdGelgyRndjSEp2ZG1Wa1gyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG95TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtRndjSEp2ZG1WeU1WOWhjSEJ5YjNabFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Gd2NISnZkbVZ5TVY5aGNIQnliM1psWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhjSEJ5YjNabGNqRmZZWEJ3Y205MlpXUWdaWGhwYzNSekNpQWdJQ0J5WlhSemRXSUtDbWhoYzE5aGNIQnliM1psWkY5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakkxT1FvZ0lDQWdMeThnWld4cFppQnpaVzVrWlhKZllXTmpiM1Z1ZENBOVBTQnpaV3htTG1Gd2NISnZkbVZ5TWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWVhCd2NtOTJaWEl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRndjSEp2ZG1WeU1pQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHSjZJR2hoYzE5aGNIQnliM1psWkY5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNall3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aGNIQnliM1psY2pKZllYQndjbTkyWldRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poY0hCeWIzWmxjakpmWVhCd2NtOTJaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlYQndjbTkyWlhJeVgyRndjSEp2ZG1Wa0lHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNncG9ZWE5mWVhCd2NtOTJaV1JmWld4elpWOWliMlI1UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUb3lOakVLSUNBZ0lDOHZJR1ZzYVdZZ2MyVnVaR1Z5WDJGalkyOTFiblFnUFQwZ2MyVnNaaTVoY0hCeWIzWmxjak02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUZ3Y0hKdmRtVnlNeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGNIQnliM1psY2pNZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaWVpQm9ZWE5mWVhCd2NtOTJaV1JmWld4elpWOWliMlI1UURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTJNZ29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WVhCd2NtOTJaWEl6WDJGd2NISnZkbVZrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWEJ3Y205MlpYSXpYMkZ3Y0hKdmRtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Gd2NISnZkbVZ5TTE5aGNIQnliM1psWkNCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS2FHRnpYMkZ3Y0hKdmRtVmtYMlZzYzJWZlltOWtlVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qWTBDaUFnSUNBdkx5QnlaWFIxY200Z1JtRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpuVnVaSEpoYVhObGNpNWpiMjUwY21GamRDNUdkVzVrY21GcGMyVnlMbWRsZEY5aGNIQnliM1poYkY5amIzVnVkQ2dwSUMwK0lIVnBiblEyTkRvS1oyVjBYMkZ3Y0hKdmRtRnNYMk52ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJaMWJtUnlZV2x6WlhJdlkyOXVkSEpoWTNRdWNIazZNalkyTFRJMk53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjloY0hCeWIzWmhiRjlqYjNWdWRDaHpaV3htS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXdJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpZNUNpQWdJQ0F2THlCamIzVnVkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJM01Bb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1aGNIQnliM1psY2pGZllYQndjbTkyWldRNkNpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Gd2NISnZkbVZ5TVY5aGNIQnliM1psWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhjSEJ5YjNabGNqRmZZWEJ3Y205MlpXUWdaWGhwYzNSekNpQWdJQ0JpZWlCblpYUmZZWEJ3Y205MllXeGZZMjkxYm5SZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveU56RUtJQ0FnSUM4dklHTnZkVzUwSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvS1oyVjBYMkZ3Y0hKdmRtRnNYMk52ZFc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTNNZ29nSUNBZ0x5OGdhV1lnYzJWc1ppNWhjSEJ5YjNabGNqSmZZWEJ3Y205MlpXUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlYQndjbTkyWlhJeVgyRndjSEp2ZG1Wa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZ3Y0hKdmRtVnlNbDloY0hCeWIzWmxaQ0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0o2SUdkbGRGOWhjSEJ5YjNaaGJGOWpiM1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1kVzVrY21GcGMyVnlMMk52Ym5SeVlXTjBMbkI1T2pJM013b2dJQ0FnTHk4Z1kyOTFiblFnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb0taMlYwWDJGd2NISnZkbUZzWDJOdmRXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qYzBDaUFnSUNBdkx5QnBaaUJ6Wld4bUxtRndjSEp2ZG1WeU0xOWhjSEJ5YjNabFpEb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaGNIQnliM1psY2pOZllYQndjbTkyWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWEJ3Y205MlpYSXpYMkZ3Y0hKdmRtVmtJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpZWlCblpYUmZZWEJ3Y205MllXeGZZMjkxYm5SZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZablZ1WkhKaGFYTmxjaTlqYjI1MGNtRmpkQzV3ZVRveU56VUtJQ0FnSUM4dklHTnZkVzUwSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbWRsZEY5aGNIQnliM1poYkY5amIzVnVkRjloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG95TnpZS0lDQWdJQzh2SUhKbGRIVnliaUJqYjNWdWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1aMWJtUnlZV2x6WlhJdVkyOXVkSEpoWTNRdVJuVnVaSEpoYVhObGNpNXBjMTloY0hCeWIzWmxjaWhoWkdSeVpYTnpPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BwYzE5aGNIQnliM1psY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltZFc1a2NtRnBjMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTNPQzB5TnprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCcGMxOWhjSEJ5YjNabGNpaHpaV3htTENCaFpHUnlaWE56T2lCQlpHUnlaWE56S1NBdFBpQmliMjlzT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpuVnVaSEpoYVhObGNpOWpiMjUwY21GamRDNXdlVG95T0RNS0lDQWdJQzh2SUdsbUlHRmpZMjkxYm5RZ1BUMGdjMlZzWmk1amNtVmhkRzl5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNKbFlYUnZjaUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUFQwS0lDQWdJR0o2SUdselgyRndjSEp2ZG1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qZzBDaUFnSUNBdkx5QnlaWFIxY200Z1ZISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRITjFZZ29LYVhOZllYQndjbTkyWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMloxYm1SeVlXbHpaWEl2WTI5dWRISmhZM1F1Y0hrNk1qZzJDaUFnSUNBdkx5QnBaaUJoWTJOdmRXNTBJRDA5SUhObGJHWXVZWEJ3Y205MlpYSXhPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSmhjSEJ5YjNabGNqRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhCd2NtOTJaWEl4SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2FYTmZZWEJ3Y205MlpYSmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUb3lPRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQlVjblZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBjM1ZpQ2dwcGMxOWhjSEJ5YjNabGNsOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm5WdVpISmhhWE5sY2k5amIyNTBjbUZqZEM1d2VUb3lPRGdLSUNBZ0lDOHZJR2xtSUdGalkyOTFiblFnUFQwZ2MyVnNaaTVoY0hCeWIzWmxjakk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbUZ3Y0hKdmRtVnlNaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGNIQnliM1psY2pJZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaWVpQnBjMTloY0hCeWIzWmxjbDloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakk0T1FvZ0lDQWdMeThnY21WMGRYSnVJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFJ6ZFdJS0NtbHpYMkZ3Y0hKdmRtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWRXNWtjbUZwYzJWeUwyTnZiblJ5WVdOMExuQjVPakk1TUFvZ0lDQWdMeThnYVdZZ1lXTmpiM1Z1ZENBOVBTQnpaV3htTG1Gd2NISnZkbVZ5TXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWVhCd2NtOTJaWEl6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRndjSEp2ZG1WeU15QmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHSjZJR2x6WDJGd2NISnZkbVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpreENpQWdJQ0F2THlCeVpYUjFjbTRnVkhKMVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhOMVlnb0thWE5mWVhCd2NtOTJaWEpmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWjFibVJ5WVdselpYSXZZMjl1ZEhKaFkzUXVjSGs2TWprekNpQWdJQ0F2THlCeVpYUjFjbTRnUm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBR2dqUVltRXdRVkgzeDFFbUZ3Y0hKdmRtVnlNVjloY0hCeWIzWmxaQkpoY0hCeWIzWmxjakpmWVhCd2NtOTJaV1FTWVhCd2NtOTJaWEl6WDJGd2NISnZkbVZrQVFBTmNtRnBjMlZrWDJGdGIzVnVkQkZqZFhKeVpXNTBYMjFwYkdWemRHOXVaUWRqY21WaGRHOXlDMmR2WVd4ZllXMXZkVzUwRDIxcGJHVnpkRzl1WlY5amIzVnVkQXhuYjJGc1gzSmxZV05vWldRSllYQndjbTkyWlhJeENXRndjSEp2ZG1WeU1nbGhjSEJ5YjNabGNqTVJZMjl1ZEhKcFluVjBiM0pmWTI5MWJuUVFiV1ZrYVdGZlkybGtYMnhsYm1kMGFBaGtaV0ZrYkdsdVpRbHBjMTloWTNScGRtVUZiV1ZrYVdFeEcwRUFhWUlPQk8rbDFxNEU1TVBnRUFSZy8wQjlCRkVRamZnRU5UN3VFZ1RDSWNCUkJLOUZhZDBFSUNvT0dRUmw5NGRYQk1sOWdRVUU2NllUS2dRUHZIVDhCREtrc0JnRWdDSGZpRFlhQUk0T0FWMEJRZ0VyQVJNQkFnRHhBSzBBblFDTUFIY0FSUUFzQUJzQUFpSkRNUmtVUkRFWVJEWWFBWWdFQ2ljRUlrOENWQ2hNVUxBalF6RVpGRVF4R0VTSUE3MFdLRXhRc0NORE1Sa1VSREVZUkRZYUFZZ0RkQ2NFSWs4Q1ZDaE1VTEFqUXpFWkZFUXhHRVNJQTFFbkJDSlBCRlFuQkNKUEJGUW5CQ0pQQkZSTUlsTlBBaU5QQWxSTUlsT0JBa3hVS0V4UXNDTkRNUmtVUkRFWVJJZ0REMDRDVUV4UUtFeFFzQ05ETVJrVVJERVlSSWdDOUJZb1RGQ3dJME14R1JSRU1SaEVpQUxkS0V4UXNDTkRNUmtVUkRFWVJJZ0NxVThHRms4R0ZrOEdGazhHRms4R0ZpY0VJazhJVkNjRUlrOElWRThHVHdaUVR3VlFUd1JRVHdOUVR3SlFUQ0pUZ2NFQ1RGUW9URkN3STBNeEdSUkVNUmhFaUFINkZpaE1VTEFqUXpFWkZFUXhHRVNJQVZnV0tFeFFzQ05ETVJrVVJERVlSSWdCTjBrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBVmNDQUlnQTdSWW9URkN3STBNeEdSUkVNUmhFTVJZakNVazRFQ01TUklnQWR4WW9URkN3STBNeEdSUkVNUmdVUkRZYUFSYzJHZ0lYTmhvREZ6WWFCRFlhQlRZYUJvZ0FCeFlvVEZDd0kwT0tCZ0VuQ0l2Nlp5Y0ZJbWNuQ1l2N1p5Y0dJbWNuRUl2OFp5Y1JJMmNuQnpFQVp5Y09JbWNuQ2lKbkp3dUwvV2NuREl2K1p5Y05pLzluS1NKbktpSm5LeUpuSnc4aVp5T0ppZ0VCSWljUlpVUkVNZ2NpSnhCbFJBNUVJaWNGWlVRaUp3aGxSQXhFaS84NEJ6SUtFa1NML3pnSVNTUVBSQ0luQldWRUNDY0ZUR2NpSnc1bFJDTUlKdzVNWnlJbkJXVkVJaWNJWlVRUFFRQUVKd29qWnlJbkJXVkVpWW9CQVRFQUlpY0haVVFTUkNJbkQyVkVGRVNML3hWSmdVQU9SQ2NTU3dHNVJDY1NpLysvSnc5TEFXZUpJaWNQWlVSQUFBT0FBSWtuRXI1RWlZb0FBWUFBU1NJbkNtVkVSQ0luQm1WRUlpY0paVVFNUkRFQVNTSW5DMlZFRWtFQVFTSXBaVVFVUkNralp5S01BQ0lwWlVSQkFBTWpqQUFpS21WRWl3Q01BVUVBQm9zQUl3aU1BWXNCU1l3QUlpdGxSRXlNQVVFQUJvc0FJd2lNQVlzQmpBQ0pJaWNNWlVTTEFoSkJBQXdpS21WRUZFUXFJMmRDLzdFaUp3MWxSSXNDRWtRaUsyVkVGRVFySTJkQy81d3hBQ0luQjJWRUVrUWlKd1psUkNJbkNXVkVERVFpSndwbFJFUWlLV1ZFUkNJcVpVUkVJaXRsUkVRaUp3aGxSQ0luQ1dWRUNqSUtjd0JFU3dFa0NBOUVzU0luQjJWRXNnZXlDQ095RUNLeUFiTWlKd1psUkNNSUp3Wk1aeWtpWnlvaVp5c2laeUluQm1WRWlTSW5DR1ZFSWljRlpVUWlKd1psUkNJbkNXVkVJaWNPWlVRaUp4RmxSQ0luQ21WRWlTSW5CMlZFaVNJbkVHVkVpU0luQzJWRUlpY01aVVFpSncxbFJJa2lLV1ZFSWlwbFJDSXJaVVNKaWdFQklpY0xaVVNML3hKQkFBVWlLV1ZFaVNJbkRHVkVpLzhTUVFBRklpcGxSSWtpSncxbFJJdi9Fa0VBQlNJclpVU0pJb21LQUFHQUFDSkpLV1ZFUVFBREk0d0JJaXBsUklzQmpBQkJBQWFMQVNNSWpBQ0xBRW1NQVNJclpVUk1qQUJCQUFhTEFTTUlqQUNKaWdFQklpY0haVVNML3hKQkFBSWppU0luQzJWRWkvOFNRUUFDSTRraUp3eGxSSXYvRWtFQUFpT0pJaWNOWlVTTC94SkJBQUlqaVNLSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
