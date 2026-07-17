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

namespace Arc56.Generated.Danish0703.AlgoEscrow.AlgoEscrowContract_9dba9431
{


    public class AlgoEscrowContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoEscrowContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStatusReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetStatusReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStatusReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
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

            public class GetParticipantsReturn : AVMObjectType
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

                public static GetParticipantsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetParticipantsReturn();
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
                    return Equals(obj as GetParticipantsReturn);
                }
                public bool Equals(GetParticipantsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetParticipantsReturn left, GetParticipantsReturn right)
                {
                    return EqualityComparer<GetParticipantsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetParticipantsReturn left, GetParticipantsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="buyer"> </param>
        /// <param name="seller"> </param>
        /// <param name="arbiter"> </param>
        /// <param name="totalMilestones"> </param>
        public async Task CreateEscrow(Address buyer, Address seller, Address arbiter, ulong totalMilestones, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { buyer, seller, arbiter });
            byte buyerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte sellerRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte arbiterRefIndex = (byte)(_acctRefBase + 2 + 1);
            byte[] abiHandle = { 6, 204, 218, 163 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var arbiterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); arbiterAbi.From(arbiter);
            var totalMilestonesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalMilestonesAbi.From(totalMilestones);

            var result = await base.CallApp(new List<object> { abiHandle, buyerRefIndex, sellerRefIndex, arbiterRefIndex, totalMilestonesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateEscrow_Transactions(Address buyer, Address seller, Address arbiter, ulong totalMilestones, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { buyer, seller, arbiter });
            byte buyerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte sellerRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte arbiterRefIndex = (byte)(_acctRefBase + 2 + 1);
            byte[] abiHandle = { 6, 204, 218, 163 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var arbiterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); arbiterAbi.From(arbiter);
            var totalMilestonesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalMilestonesAbi.From(totalMilestones);

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerRefIndex, sellerRefIndex, arbiterRefIndex, totalMilestonesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="milestoneIndex"> </param>
        public async Task ApproveMilestone(ulong milestoneIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 42, 227, 115 };
            var milestoneIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestoneIndexAbi.From(milestoneIndex);

            var result = await base.CallApp(new List<object> { abiHandle, milestoneIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveMilestone_Transactions(ulong milestoneIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 42, 227, 115 };
            var milestoneIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); milestoneIndexAbi.From(milestoneIndex);

            return await base.MakeTransactionList(new List<object> { abiHandle, milestoneIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OpenDispute(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 57, 134, 231 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpenDispute_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 57, 134, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="releaseToSeller"> </param>
        /// <param name="refundToBuyer"> </param>
        public async Task ResolveDispute(ulong releaseToSeller, ulong refundToBuyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 196, 196, 70 };
            var releaseToSellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); releaseToSellerAbi.From(releaseToSeller);
            var refundToBuyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); refundToBuyerAbi.From(refundToBuyer);

            var result = await base.CallApp(new List<object> { abiHandle, releaseToSellerAbi, refundToBuyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResolveDispute_Transactions(ulong releaseToSeller, ulong refundToBuyer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 196, 196, 70 };
            var releaseToSellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); releaseToSellerAbi.From(releaseToSeller);
            var refundToBuyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); refundToBuyerAbi.From(refundToBuyer);

            return await base.MakeTransactionList(new List<object> { abiHandle, releaseToSellerAbi, refundToBuyerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CancelAndRefund(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 222, 161, 191 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelAndRefund_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 222, 161, 191 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetStatusReturn> GetStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 35, 30, 165 };

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
            byte[] abiHandle = { 159, 35, 30, 165 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetParticipantsReturn> GetParticipants(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 216, 190, 208 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetParticipantsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetParticipants_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 216, 190, 208 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb0VzY3Jvd0NvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFN0YXR1c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0UGFydGljaXBhbnRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUVzY3JvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmJpdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbE1pbGVzdG9uZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZU1pbGVzdG9uZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaWxlc3RvbmVJbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcGVuRGlzcHV0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlRGlzcHV0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWxlYXNlVG9TZWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZnVuZFRvQnV5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FuY2VsQW5kUmVmdW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVtdLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0U3RhdHVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UGFydGljaXBhbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcykiLCJzdHJ1Y3QiOiJHZXRQYXJ0aWNpcGFudHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU3N10sImVycm9yTWVzc2FnZSI6IkFsbCBtaWxlc3RvbmVzIGRvbmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3ODVdLCJlcnJvck1lc3NhZ2UiOiJBbW91bnRzIG11c3QgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxOV0sImVycm9yTWVzc2FnZSI6IkNhbiBkaXNwdXRlIG9ubHkgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODkyXSwiZXJyb3JNZXNzYWdlIjoiRnVuZHMgYWxyZWFkeSByZWxlYXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1OF0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgc3RhdHVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYwXSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBoYXZlIG1pbGVzdG9uZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjhdLCJlcnJvck1lc3NhZ2UiOiJObyBkaXNwdXRlIHRvIHJlc29sdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODZdLCJlcnJvck1lc3NhZ2UiOiJOb3QgYWN0aXZlIGVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOCwyNTAsMzEyLDMyNCwzNTQsMzY2LDM4N10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYXJiaXRlciBjYW4gcmVzb2x2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYnV5ZXIgY2FuIGFwcHJvdmUgbWlsZXN0b25lIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBidXllciBjYW4gY2FuY2VsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBidXllciBjYW4gY3JlYXRlIGVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgcGFydGljaXBhbnRzIGNhbiBkaXNwdXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY5XSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgbWlsZXN0b25lIGluZGV4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQ2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxLDI1MywzMTUsMzI3LDM1NywzNjksMzkwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzNCw1NDAsNTUwLDU2Myw1NzQsNTgyLDU5MCw2MTQsNjI3LDYzMiw2OTQsNzA1LDcxNSw3NTgsNzY0LDc3Myw3NzcsNzk2LDgxOSw4MzcsODczLDg4Miw4OTAsODk4LDk1MCw5NTQsOTYyLDk2Nyw5NzIsOTc2LDk4OSw5OTQsOTk5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM1LDM0NCwzNzcsNDMxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk4LDQwOSw0MjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50OCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luTjBZWFIxY3lJZ0luSmxiR1ZoYzJWa1FXMXZkVzUwSWlBaVluVjVaWElpSUNKc1lYTjBWWEJrWVhSbFpDSWdJbk5sYkd4bGNpSWdJbU52YlhCc1pYUmxaRTFwYkdWemRHOXVaWE1pSUNKMGIzUmhiRUZ0YjNWdWRDSWdJblJ2ZEdGc1RXbHNaWE4wYjI1bGN5SWdJbUZqZEdsMlpTSWdJbUZ5WW1sMFpYSWlJREI0TVRVeFpqZGpOelVnSW0xcGJHVnpkRzl1WlY5amIyMXdiR1YwWldRaUlDSmpiMjF3YkdWMFpXUWlJQ0prYVhOd2RYUmxaQ0lLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV3huYjBWelkzSnZkME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV5Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TURaalkyUmhZVE1nTUhnNVpqSmhaVE0zTXlBd2VEbGlNems0Tm1VM0lEQjRPV05qTkdNME5EWWdNSGc1WTJSbFlURmlaaUF3ZURsbU1qTXhaV0UxSURCNE1qRmtPR0psWkRBZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWRmMyTnliM2NvWVdOamIzVnVkQ3hoWTJOdmRXNTBMR0ZqWTI5MWJuUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVZOYVd4bGMzUnZibVVvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltOXdaVzVFYVhOd2RYUmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWE52YkhabFJHbHpjSFYwWlNoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTmhibU5sYkVGdVpGSmxablZ1WkNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFUzUmhkSFZ6S0Nrb1lubDBaVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUlFZWEowYVdOcGNHRnVkSE1vS1NoaFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeWtpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpVVnpZM0p2ZDE5eWIzVjBaVUF6SUcxaGFXNWZZWEJ3Y205MlpVMXBiR1Z6ZEc5dVpWOXliM1YwWlVBMElHMWhhVzVmYjNCbGJrUnBjM0IxZEdWZmNtOTFkR1ZBTlNCdFlXbHVYM0psYzI5c2RtVkVhWE53ZFhSbFgzSnZkWFJsUURZZ2JXRnBibDlqWVc1alpXeEJibVJTWldaMWJtUmZjbTkxZEdWQU55QnRZV2x1WDJkbGRGTjBZWFIxYzE5eWIzVjBaVUE0SUcxaGFXNWZaMlYwVUdGeWRHbGphWEJoYm5SelgzSnZkWFJsUURrS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV3huYjBWelkzSnZkME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJRWVhKMGFXTnBjR0Z1ZEhOZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhNd29nSUNBZ0x5OGdaMlYwVUdGeWRHbGphWEJoYm5SektDazZJRnRCWkdSeVpYTnpMQ0JCWkdSeVpYTnpMQ0JCWkdSeVpYTnpYU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVR0Z5ZEdsamFYQmhiblJ6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVTNSaGRIVnpYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RRS0lDQWdJQzh2SUdkbGRGTjBZWFIxY3lncE9pQmJZbmwwWlhNc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBYU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVM1JoZEhWekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREpoQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREV3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTmhibU5sYkVGdVpGSmxablZ1WkY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3pDaUFnSUNBdkx5QmpZVzVqWld4QmJtUlNaV1oxYm1Rb0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdZMkZ1WTJWc1FXNWtVbVZtZFc1a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbGMyOXNkbVZFYVhOd2RYUmxYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpNS0lDQWdJQzh2SUhKbGMyOXNkbVZFYVhOd2RYUmxLSEpsYkdWaGMyVlViMU5sYkd4bGNqb2dkV2x1ZERZMExDQnlaV1oxYm1SVWIwSjFlV1Z5T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNek1LSUNBZ0lDOHZJSEpsYzI5c2RtVkVhWE53ZFhSbEtISmxiR1ZoYzJWVWIxTmxiR3hsY2pvZ2RXbHVkRFkwTENCeVpXWjFibVJVYjBKMWVXVnlPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdOaGJHeHpkV0lnY21WemIyeDJaVVJwYzNCMWRHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmIzQmxia1JwYzNCMWRHVmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TndvZ0lDQWdMeThnYjNCbGJrUnBjM0IxZEdVb0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdiM0JsYmtScGMzQjFkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEJ3Y205MlpVMXBiR1Z6ZEc5dVpWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJR0Z3Y0hKdmRtVk5hV3hsYzNSdmJtVW9iV2xzWlhOMGIyNWxTVzVrWlhnNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZzWjI5RmMyTnliM2REYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QmhjSEJ5YjNabFRXbHNaWE4wYjI1bEtHMXBiR1Z6ZEc5dVpVbHVaR1Y0T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1lYQndjbTkyWlUxcGJHVnpkRzl1WlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVkZjMk55YjNkZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNMVFV5Q2lBZ0lDQXZMeUJqY21WaGRHVkZjMk55YjNjb0NpQWdJQ0F2THlBZ0lHSjFlV1Z5T2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCelpXeHNaWEk2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdGeVltbDBaWEk2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNUV2xzWlhOMGIyNWxjem9nZFdsdWREWTBDaUFnSUNBdkx5QXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmJHZHZSWE5qY205M1EyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREZ0tJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTnkwMU1nb2dJQ0FnTHk4Z1kzSmxZWFJsUlhOamNtOTNLQW9nSUNBZ0x5OGdJQ0JpZFhsbGNqb2dRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdjMlZzYkdWeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhjbUpwZEdWeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQjBiM1JoYkUxcGJHVnpkRzl1WlhNNklIVnBiblEyTkFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVWelkzSnZkd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRJNkNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGc1oyOUZjMk55YjNkRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVqY21WaGRHVkZjMk55YjNjb1luVjVaWEk2SUdKNWRHVnpMQ0J6Wld4c1pYSTZJR0o1ZEdWekxDQmhjbUpwZEdWeU9pQmllWFJsY3l3Z2RHOTBZV3hOYVd4bGMzUnZibVZ6T2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVVZ6WTNKdmR6b0tJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEzTFRVeUNpQWdJQ0F2THlCamNtVmhkR1ZGYzJOeWIzY29DaUFnSUNBdkx5QWdJR0oxZVdWeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQnpaV3hzWlhJNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lHRnlZbWwwWlhJNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzVFdsc1pYTjBiMjVsY3pvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCaWRYbGxjaXdnSjA5dWJIa2dZblY1WlhJZ1kyRnVJR055WldGMFpTQmxjMk55YjNjbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdKMWVXVnlJR05oYmlCamNtVmhkR1VnWlhOamNtOTNDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnWVhOelpYSjBLSFJ2ZEdGc1RXbHNaWE4wYjI1bGN5QStJREFzSUNkTmRYTjBJR2hoZG1VZ2JXbHNaWE4wYjI1bGN5Y3BPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGMzTmxjblFnTHk4Z1RYVnpkQ0JvWVhabElHMXBiR1Z6ZEc5dVpYTUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJpZFhsbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWRYbGxjaUlLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCMGFHbHpMbUoxZVdWeUxuWmhiSFZsSUQwZ1luVjVaWEk3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2MyVnNiR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbk5sYkd4bGNpSUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUIwYUdsekxuTmxiR3hsY2k1MllXeDFaU0E5SUhObGJHeGxjanNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCaGNtSnBkR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbUZ5WW1sMFpYSWlDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnZEdocGN5NWhjbUpwZEdWeUxuWmhiSFZsSUQwZ1lYSmlhWFJsY2pzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBiM1JoYkUxcGJHVnpkRzl1WlhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0owYjNSaGJFMXBiR1Z6ZEc5dVpYTWlDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkUxcGJHVnpkRzl1WlhNdWRtRnNkV1VnUFNCMGIzUmhiRTFwYkdWemRHOXVaWE03Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z1kyOXRjR3hsZEdWa1RXbHNaWE4wYjI1bGN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1OdmJYQnNaWFJsWkUxcGJHVnpkRzl1WlhNaUNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdkR2hwY3k1amIyMXdiR1YwWldSTmFXeGxjM1J2Ym1WekxuWmhiSFZsSUQwZ01DQmhjeUIxYVc1ME5qUTdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJ5Wld4bFlYTmxaRUZ0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbGJHVmhjMlZrUVcxdmRXNTBJZ29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUhSb2FYTXVjbVZzWldGelpXUkJiVzkxYm5RdWRtRnNkV1VnUFNBd0lHRnpJSFZwYm5RMk5Ec0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJSE4wWVhSMWN5QTlJRWRzYjJKaGJGTjBZWFJsUEdKNWRHVnpQaWdwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUhSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwZ1FubDBaWE1vSjJGamRHbDJaU2NwT3dvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWVdOMGFYWmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNUNpQWdJQ0F2THlCamNtVmhkR1ZrUVhRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbU55WldGMFpXUkJkQ0lLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCMGFHbHpMbU55WldGMFpXUkJkQzUyWVd4MVpTQTlJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBN0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR3hoYzNSVmNHUmhkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ1lubDBaV05mTXlBdkx5QWliR0Z6ZEZWd1pHRjBaV1FpQ2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2RHaHBjeTVzWVhOMFZYQmtZWFJsWkM1MllXeDFaU0E5SUVkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQTdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUd4dlp5Z25SWE5qY205M1EzSmxZWFJsWkNjcE93b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRmMyTnliM2REY21WaGRHVmtJZ29nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gd2NISnZkbVZOYVd4bGMzUnZibVVvYldsc1pYTjBiMjVsU1c1a1pYZzZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZWEJ3Y205MlpVMXBiR1Z6ZEc5dVpUb0tJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJoY0hCeWIzWmxUV2xzWlhOMGIyNWxLRzFwYkdWemRHOXVaVWx1WkdWNE9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1KMWVXVnlMblpoYkhWbExDQW5UMjVzZVNCaWRYbGxjaUJqWVc0Z1lYQndjbTkyWlNCdGFXeGxjM1J2Ym1VbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QmlkWGxsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZblY1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtSjFlV1Z5TG5aaGJIVmxMQ0FuVDI1c2VTQmlkWGxsY2lCallXNGdZWEJ3Y205MlpTQnRhV3hsYzNSdmJtVW5LVHNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JpZFhsbGNpQmpZVzRnWVhCd2NtOTJaU0J0YVd4bGMzUnZibVVLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCemRHRjBkWE1nUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUhSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwOVBTQkNlWFJsY3lnbllXTjBhWFpsSnlrZ2ZId0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltRmpkR2wyWlNJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM055MDNPQW9nSUNBZ0x5OGdkR2hwY3k1emRHRjBkWE11ZG1Gc2RXVWdQVDA5SUVKNWRHVnpLQ2RoWTNScGRtVW5LU0I4ZkFvZ0lDQWdMeThnSUNCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOVBUMGdRbmwwWlhNb0oyMXBiR1Z6ZEc5dVpWOWpiMjF3YkdWMFpXUW5LU3dLSUNBZ0lHSnVlaUJoY0hCeWIzWmxUV2xzWlhOMGIyNWxYMkp2YjJ4ZmRISjFaVUF5Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOVBUMGdRbmwwWlhNb0oyMXBiR1Z6ZEc5dVpWOWpiMjF3YkdWMFpXUW5LU3dLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0p0YVd4bGMzUnZibVZmWTI5dGNHeGxkR1ZrSWdvZ0lDQWdQVDBLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0xUYzRDaUFnSUNBdkx5QjBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlQVDBnUW5sMFpYTW9KMkZqZEdsMlpTY3BJSHg4Q2lBZ0lDQXZMeUFnSUhSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwOVBTQkNlWFJsY3lnbmJXbHNaWE4wYjI1bFgyTnZiWEJzWlhSbFpDY3BMQW9nSUNBZ1lub2dZWEJ3Y205MlpVMXBiR1Z6ZEc5dVpWOWliMjlzWDJaaGJITmxRRE1LQ21Gd2NISnZkbVZOYVd4bGMzUnZibVZmWW05dmJGOTBjblZsUURJNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS1lYQndjbTkyWlUxcGJHVnpkRzl1WlY5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTmkwNE1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0FvZ0lDQWdMeThnSUNCMGFHbHpMbk4wWVhSMWN5NTJZV3gxWlNBOVBUMGdRbmwwWlhNb0oyRmpkR2wyWlNjcElIeDhDaUFnSUNBdkx5QWdJQ0FnZEdocGN5NXpkR0YwZFhNdWRtRnNkV1VnUFQwOUlFSjVkR1Z6S0NkdGFXeGxjM1J2Ym1WZlkyOXRjR3hsZEdWa0p5a3NDaUFnSUNBdkx5QWdJQ2RKYm5aaGJHbGtJSE4wWVhSMWN5Y0tJQ0FnSUM4dklDazdDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCemRHRjBkWE1LSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCamIyMXdiR1YwWldSTmFXeGxjM1J2Ym1WeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52YlhCc1pYUmxaRTFwYkdWemRHOXVaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUcxcGJHVnpkRzl1WlVsdVpHVjRJRDA5UFNCMGFHbHpMbU52YlhCc1pYUmxaRTFwYkdWemRHOXVaWE11ZG1Gc2RXVXNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZPREV0T0RRS0lDQWdJQzh2SUdGemMyVnlkQ2dLSUNBZ0lDOHZJQ0FnYldsc1pYTjBiMjVsU1c1a1pYZ2dQVDA5SUhSb2FYTXVZMjl0Y0d4bGRHVmtUV2xzWlhOMGIyNWxjeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdKMWR5YjI1bklHMXBiR1Z6ZEc5dVpTQnBibVJsZUNjS0lDQWdJQzh2SUNrN0NpQWdJQ0JoYzNObGNuUWdMeThnVjNKdmJtY2diV2xzWlhOMGIyNWxJR2x1WkdWNENpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdkRzkwWVd4TmFXeGxjM1J2Ym1WeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1RXbHNaWE4wYjI1bGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdkR2hwY3k1amIyMXdiR1YwWldSTmFXeGxjM1J2Ym1WekxuWmhiSFZsSUR3Z2RHaHBjeTUwYjNSaGJFMXBiR1Z6ZEc5dVpYTXVkbUZzZFdVc0NpQWdJQ0JrZFhBeUNpQWdJQ0E4Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE5TMDRPQW9nSUNBZ0x5OGdZWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQjBhR2x6TG1OdmJYQnNaWFJsWkUxcGJHVnpkRzl1WlhNdWRtRnNkV1VnUENCMGFHbHpMblJ2ZEdGc1RXbHNaWE4wYjI1bGN5NTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0owRnNiQ0J0YVd4bGMzUnZibVZ6SUdSdmJtVW5DaUFnSUNBdkx5QXBPd29nSUNBZ1lYTnpaWEowSUM4dklFRnNiQ0J0YVd4bGMzUnZibVZ6SUdSdmJtVUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUIwYjNSaGJFRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiM1JoYkVGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TUMwNU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0dGNWJXVnVkRUZ0YjNWdWREb2dkV2x1ZERZMElEMEtJQ0FnSUM4dklDQWdLSFJvYVhNdWRHOTBZV3hCYlc5MWJuUXVkbUZzZFdVZ0x5QjBhR2x6TG5SdmRHRnNUV2xzWlhOMGIyNWxjeTUyWVd4MVpTa2dZWE1nZFdsdWREWTBPd29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUNoMGFHbHpMblJ2ZEdGc1FXMXZkVzUwTG5aaGJIVmxJQzhnZEdocGN5NTBiM1JoYkUxcGJHVnpkRzl1WlhNdWRtRnNkV1VwSUdGeklIVnBiblEyTkRzS0lDQWdJQzhLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekxUazNDaUFnSUNBdkx5QnBkSGh1TG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTV6Wld4c1pYSXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2NHRjViV1Z1ZEVGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2s3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnYzJWc2JHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKelpXeHNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU15MDVOd29nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklIUm9hWE11YzJWc2JHVnlMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIQmhlVzFsYm5SQmJXOTFiblFzQ2lBZ0lDQXZMeUFnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwT3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJtWldVNklEQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt6TFRrM0NpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nZEdocGN5NXpaV3hzWlhJdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nY0dGNWJXVnVkRUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGtLSUNBZ0lDOHZJSFJvYVhNdVkyOXRjR3hsZEdWa1RXbHNaWE4wYjI1bGN5NTJZV3gxWlNBclBTQXhJR0Z6SUhWcGJuUTJORHNLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdZMjl0Y0d4bGRHVmtUV2xzWlhOMGIyNWxjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltTnZiWEJzWlhSbFpFMXBiR1Z6ZEc5dVpYTWlDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem81T1FvZ0lDQWdMeThnZEdocGN5NWpiMjF3YkdWMFpXUk5hV3hsYzNSdmJtVnpMblpoYkhWbElDczlJREVnWVhNZ2RXbHVkRFkwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QnlaV3hsWVhObFpFRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnlaV3hsWVhObFpFRnRiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklIUm9hWE11Y21Wc1pXRnpaV1JCYlc5MWJuUXVkbUZzZFdVZ0t6MGdjR0Y1YldWdWRFRnRiM1Z1ZERzS0lDQWdJQ3NLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCeVpXeGxZWE5sWkVGdGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxiR1ZoYzJWa1FXMXZkVzUwSWdvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXdDaUFnSUNBdkx5QjBhR2x6TG5KbGJHVmhjMlZrUVcxdmRXNTBMblpoYkhWbElDczlJSEJoZVcxbGJuUkJiVzkxYm5RN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR3hoYzNSVmNHUmhkR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ1lubDBaV05mTXlBdkx5QWliR0Z6ZEZWd1pHRjBaV1FpQ2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1ERUtJQ0FnSUM4dklIUm9hWE11YkdGemRGVndaR0YwWldRdWRtRnNkV1VnUFNCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdPd29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCamIyMXdiR1YwWldSTmFXeGxjM1J2Ym1WeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbU52YlhCc1pYUmxaRTFwYkdWemRHOXVaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSdmRHRnNUV2xzWlhOMGIyNWxjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIzUmhiRTFwYkdWemRHOXVaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCcFppQW9kR2hwY3k1amIyMXdiR1YwWldSTmFXeGxjM1J2Ym1WekxuWmhiSFZsSUQwOVBTQjBhR2x6TG5SdmRHRnNUV2xzWlhOMGIyNWxjeTUyWVd4MVpTa2dld29nSUNBZ1BUMEtJQ0FnSUdKNklHRndjSEp2ZG1WTmFXeGxjM1J2Ym1WZlpXeHpaVjlpYjJSNVFEY0tJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQkNlWFJsY3lnblkyOXRjR3hsZEdWa0p5azdDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlZMjl0Y0d4bGRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2JHOW5LQ2RGYzJOeWIzZERiMjF3YkdWMFpXUW5LVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSWE5qY205M1EyOXRjR3hsZEdWa0lnb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDbUZ3Y0hKdmRtVk5hV3hsYzNSdmJtVmZaV3h6WlY5aWIyUjVRRGM2Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSFJvYVhNdWMzUmhkSFZ6TG5aaGJIVmxJRDBnUW5sMFpYTW9KMjFwYkdWemRHOXVaVjlqYjIxd2JHVjBaV1FuS1RzS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKdGFXeGxjM1J2Ym1WZlkyOXRjR3hsZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3T0FvZ0lDQWdMeThnYkc5bktDZE5hV3hsYzNSdmJtVkJjSEJ5YjNabFpDY3BPd29nSUNBZ2NIVnphR0o1ZEdWeklDSk5hV3hsYzNSdmJtVkJjSEJ5YjNabFpDSUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ3BoY0hCeWIzWmxUV2xzWlhOMGIyNWxYMkp2YjJ4ZlptRnNjMlZBTXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR0Z3Y0hKdmRtVk5hV3hsYzNSdmJtVmZZbTl2YkY5dFpYSm5aVUEwQ2dvS0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1dmNHVnVSR2x6Y0hWMFpTZ3BJQzArSUhadmFXUTZDbTl3Wlc1RWFYTndkWFJsT2dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QlVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbUoxZVdWeUxuWmhiSFZsSUh4OElGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVjMlZzYkdWeUxuWmhiSFZsTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUdKMWVXVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWRYbGxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRrS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVluVjVaWEl1ZG1Gc2RXVWdmSHdnVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1elpXeHNaWEl1ZG1Gc2RXVXNDaUFnSUNBOVBRb2dJQ0FnWW01NklHOXdaVzVFYVhOd2RYUmxYMkp2YjJ4ZmRISjFaVUF5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnYzJWc2JHVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKelpXeHNaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNUNpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtSjFlV1Z5TG5aaGJIVmxJSHg4SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdWMyVnNiR1Z5TG5aaGJIVmxMQW9nSUNBZ1BUMEtJQ0FnSUdKNklHOXdaVzVFYVhOd2RYUmxYMkp2YjJ4ZlptRnNjMlZBTXdvS2IzQmxia1JwYzNCMWRHVmZZbTl2YkY5MGNuVmxRREk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYjNCbGJrUnBjM0IxZEdWZlltOXZiRjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNExURXlNUW9nSUNBZ0x5OGdZWE56WlhKMEtBb2dJQ0FnTHk4Z0lDQlVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbUoxZVdWeUxuWmhiSFZsSUh4OElGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVjMlZzYkdWeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBblQyNXNlU0J3WVhKMGFXTnBjR0Z1ZEhNZ1kyRnVJR1JwYzNCMWRHVW5DaUFnSUNBdkx5QXBPd29nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnY0dGeWRHbGphWEJoYm5SeklHTmhiaUJrYVhOd2RYUmxDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnYzNSaGRIVnpJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWMzUmhkSFZ6TG5aaGJIVmxJRDA5UFNCQ2VYUmxjeWduWVdOMGFYWmxKeWtzSUNkRFlXNGdaR2x6Y0hWMFpTQnZibXg1SUdGamRHbDJaU2NwT3dvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWVdOMGFYWmxJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCRFlXNGdaR2x6Y0hWMFpTQnZibXg1SUdGamRHbDJaUW9nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUhOMFlYUjFjeUE5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGlncE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXpDaUFnSUNBdkx5QjBhR2x6TG5OMFlYUjFjeTUyWVd4MVpTQTlJRUo1ZEdWektDZGthWE53ZFhSbFpDY3BPd29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbVJwYzNCMWRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCc1lYTjBWWEJrWVhSbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW14aGMzUlZjR1JoZEdWa0lnb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUIwYUdsekxteGhjM1JWY0dSaGRHVmtMblpoYkhWbElEMGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0RzS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJR3h2WnlnblJHbHpjSFYwWlU5d1pXNWxaQ2NwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pFYVhOd2RYUmxUM0JsYm1Wa0lnb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDbTl3Wlc1RWFYTndkWFJsWDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUc5d1pXNUVhWE53ZFhSbFgySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1Y21WemIyeDJaVVJwYzNCMWRHVW9jbVZzWldGelpWUnZVMlZzYkdWeU9pQjFhVzUwTmpRc0lISmxablZ1WkZSdlFuVjVaWEk2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LY21WemIyeDJaVVJwYzNCMWRHVTZDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpNS0lDQWdJQzh2SUhKbGMyOXNkbVZFYVhOd2RYUmxLSEpsYkdWaGMyVlViMU5sYkd4bGNqb2dkV2x1ZERZMExDQnlaV1oxYm1SVWIwSjFlV1Z5T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0wQ2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoY21KcGRHVnlMblpoYkhWbExDQW5UMjVzZVNCaGNtSnBkR1Z5SUdOaGJpQnlaWE52YkhabEp5azdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdZWEppYVhSbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpWVhKaWFYUmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1GeVltbDBaWEl1ZG1Gc2RXVXNJQ2RQYm14NUlHRnlZbWwwWlhJZ1kyRnVJSEpsYzI5c2RtVW5LVHNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoY21KcGRHVnlJR05oYmlCeVpYTnZiSFpsQ2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z2MzUmhkSFZ6SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWMzUmhkSFZ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwOVBTQkNlWFJsY3lnblpHbHpjSFYwWldRbktTd2dKMDV2SUdScGMzQjFkR1VnZEc4Z2NtVnpiMngyWlNjcE93b2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltUnBjM0IxZEdWa0lnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCa2FYTndkWFJsSUhSdklISmxjMjlzZG1VS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QjBiM1JoYkVGdGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIzUmhiRUZ0YjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdjbVZzWldGelpXUkJiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZzWldGelpXUkJiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTTRDaUFnSUNBdkx5QW9kR2hwY3k1MGIzUmhiRUZ0YjNWdWRDNTJZV3gxWlNBdElIUm9hWE11Y21Wc1pXRnpaV1JCYlc5MWJuUXVkbUZzZFdVcElHRnpJSFZwYm5RMk5Ec0tJQ0FnSUMwS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNUW9nSUNBZ0x5OGdjbVZzWldGelpWUnZVMlZzYkdWeUlDc2djbVZtZFc1a1ZHOUNkWGxsY2lBOVBUMGdjbVZ0WVdsdWFXNW5MQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EQXRNVFF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJSEpsYkdWaGMyVlViMU5sYkd4bGNpQXJJSEpsWm5WdVpGUnZRblY1WlhJZ1BUMDlJSEpsYldGcGJtbHVaeXdLSUNBZ0lDOHZJQ0FnSjBGdGIzVnVkSE1nYlhWemRDQmlZV3hoYm1ObEp3b2dJQ0FnTHk4Z0tUc0tJQ0FnSUdGemMyVnlkQ0F2THlCQmJXOTFiblJ6SUcxMWMzUWdZbUZzWVc1alpRb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFExQ2lBZ0lDQXZMeUJwWmlBb2NtVnNaV0Z6WlZSdlUyVnNiR1Z5SUQ0Z01Da2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWVpQnlaWE52YkhabFJHbHpjSFYwWlY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME5pMHhOVEFLSUNBZ0lDOHZJR2wwZUc0dWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQjBhR2x6TG5ObGJHeGxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQnlaV3hsWVhObFZHOVRaV3hzWlhJc0NpQWdJQ0F2THlBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklITmxiR3hsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWljMlZzYkdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOaTB4TlRBS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUIwYUdsekxuTmxiR3hsY2k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJ5Wld4bFlYTmxWRzlUWld4c1pYSXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBPUW9nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFl0TVRVd0NpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nZEdocGN5NXpaV3hzWlhJdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nY21Wc1pXRnpaVlJ2VTJWc2JHVnlMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3B5WlhOdmJIWmxSR2x6Y0hWMFpWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVE1LSUNBZ0lDOHZJR2xtSUNoeVpXWjFibVJVYjBKMWVXVnlJRDRnTUNrZ2V3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZWlCeVpYTnZiSFpsUkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTkMweE5UZ0tJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUoxZVdWeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhKbFpuVnVaRlJ2UW5WNVpYSXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJR0oxZVdWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppZFhsbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFF0TVRVNENpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nZEdocGN5NWlkWGxsY2k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJ5WldaMWJtUlViMEoxZVdWeUxBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tUc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UY0tJQ0FnSUM4dklHWmxaVG9nTUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTBMVEUxT0FvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJSFJvYVhNdVluVjVaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2djbVZtZFc1a1ZHOUNkWGxsY2l3S0lDQWdJQzh2SUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS2NtVnpiMngyWlVScGMzQjFkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSdmRHRnNRVzF2ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2ZEdGc1FXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCeVpXeGxZWE5sWkVGdGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxiR1ZoYzJWa1FXMXZkVzUwSWdvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXhDaUFnSUNBdkx5QjBhR2x6TG5KbGJHVmhjMlZrUVcxdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRUZ0YjNWdWRDNTJZV3gxWlRzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdjM1JoZEhWeklEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLQ2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpJS0lDQWdJQzh2SUhSb2FYTXVjM1JoZEhWekxuWmhiSFZsSUQwZ1FubDBaWE1vSjJOdmJYQnNaWFJsWkNjcE93b2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltTnZiWEJzWlhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnYkdGemRGVndaR0YwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pzWVhOMFZYQmtZWFJsWkNJS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNd29nSUNBZ0x5OGdkR2hwY3k1c1lYTjBWWEJrWVhSbFpDNTJZV3gxWlNBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEE3Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTFDaUFnSUNBdkx5QnNiMmNvSjBScGMzQjFkR1ZTWlhOdmJIWmxaQ2NwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pFYVhOd2RYUmxVbVZ6YjJ4MlpXUWlDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WTJGdVkyVnNRVzVrVW1WbWRXNWtLQ2tnTFQ0Z2RtOXBaRG9LWTJGdVkyVnNRVzVrVW1WbWRXNWtPZ29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1aWRYbGxjaTUyWVd4MVpTd2dKMDl1YkhrZ1luVjVaWElnWTJGdUlHTmhibU5sYkNjcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHSjFlV1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmlkWGxsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56UUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtSjFlV1Z5TG5aaGJIVmxMQ0FuVDI1c2VTQmlkWGxsY2lCallXNGdZMkZ1WTJWc0p5azdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0oxZVdWeUlHTmhiaUJqWVc1alpXd0tJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMxQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1emRHRjBkWE11ZG1Gc2RXVWdQVDA5SUVKNWRHVnpLQ2RoWTNScGRtVW5LU3dnSjA1dmRDQmhZM1JwZG1VZ1pYTmpjbTkzSnlrN0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKaFkzUnBkbVVpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0JoWTNScGRtVWdaWE5qY205M0NpQWdJQ0F2THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOUW9nSUNBZ0x5OGdjbVZzWldGelpXUkJiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZzWldGelpXUkJiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzJDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV5Wld4bFlYTmxaRUZ0YjNWdWRDNTJZV3gxWlNBOVBUMGdNQ3dnSjBaMWJtUnpJR0ZzY21WaFpIa2djbVZzWldGelpXUW5LVHNLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCR2RXNWtjeUJoYkhKbFlXUjVJSEpsYkdWaGMyVmtDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpndE1UZ3lDaUFnSUNBdkx5QnBkSGh1TG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTVpZFhsbGNpNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMGFHbHpMblJ2ZEdGc1FXMXZkVzUwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUIwYjNSaGJFRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiM1JoYkVGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjNExURTRNZ29nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklIUm9hWE11WW5WNVpYSXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTUwYjNSaGJFRnRiM1Z1ZEM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdmU2t1YzNWaWJXbDBLQ2s3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1lXeG5iMTlsYzJOeWIzY3ZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGd4Q2lBZ0lDQXZMeUJtWldVNklEQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzT0MweE9ESUtJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbUoxZVdWeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhSb2FYTXVkRzkwWVd4QmJXOTFiblF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ6ZEdGMGRYTWdQU0JIYkc5aVlXeFRkR0YwWlR4aWVYUmxjejRvS1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE5Bb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQkNlWFJsY3lnblkyRnVZMlZzYkdWa0p5azdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltTmhibU5sYkd4bFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnYkdGemRGVndaR0YwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pzWVhOMFZYQmtZWFJsWkNJS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROUW9nSUNBZ0x5OGdkR2hwY3k1c1lYTjBWWEJrWVhSbFpDNTJZV3gxWlNBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEE3Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzJDaUFnSUNBdkx5QnNiMmNvSjBWelkzSnZkME5oYm1ObGJHeGxaQ2NwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGYzJOeWIzZERZVzVqWld4c1pXUWlDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WjJWMFUzUmhkSFZ6S0NrZ0xUNGdZbmwwWlhNc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BuWlhSVGRHRjBkWE02Q2lBZ0lDQXZMeUJoYkdkdlgyVnpZM0p2ZHk5QmJHZHZSWE5qY205M1EyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2RHOTBZV3hCYlc5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZEc5MFlXeEJiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklISmxiR1ZoYzJWa1FXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxiR1ZoYzJWa1FXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU5TMHhPVFlLSUNBZ0lDOHZJR052Ym5OMElISmxiV0ZwYm1sdVp6b2dkV2x1ZERZMElEMEtJQ0FnSUM4dklDQWdLSFJvYVhNdWRHOTBZV3hCYlc5MWJuUXVkbUZzZFdVZ0xTQjBhR2x6TG5KbGJHVmhjMlZrUVcxdmRXNTBMblpoYkhWbEtTQmhjeUIxYVc1ME5qUTdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMkNpQWdJQ0F2THlBb2RHaHBjeTUwYjNSaGJFRnRiM1Z1ZEM1MllXeDFaU0F0SUhSb2FYTXVjbVZzWldGelpXUkJiVzkxYm5RdWRtRnNkV1VwSUdGeklIVnBiblEyTkRzS0lDQWdJQzBLSUNBZ0lDOHZJR0ZzWjI5ZlpYTmpjbTkzTDBGc1oyOUZjMk55YjNkRGIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCemRHRjBkWE1nUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUdOdmJYQnNaWFJsWkUxcGJHVnpkRzl1WlhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZMjl0Y0d4bGRHVmtUV2xzWlhOMGIyNWxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnZEc5MFlXeE5hV3hsYzNSdmJtVnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmRHRnNUV2xzWlhOMGIyNWxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QmhiR2R2WDJWelkzSnZkeTlCYkdkdlJYTmpjbTkzUTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnYkdGemRGVndaR0YwWldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliR0Z6ZEZWd1pHRjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdZV3huYjE5bGMyTnliM2N2UVd4bmIwVnpZM0p2ZDBOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrNExUSXdOUW9nSUNBZ0x5OGdjbVYwZFhKdUlGc0tJQ0FnSUM4dklDQWdkR2hwY3k1emRHRjBkWE11ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJSFJvYVhNdVkyOXRjR3hsZEdWa1RXbHNaWE4wYjI1bGN5NTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2RHaHBjeTUwYjNSaGJFMXBiR1Z6ZEc5dVpYTXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lIUm9hWE11Y21Wc1pXRnpaV1JCYlc5MWJuUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lISmxiV0ZwYm1sdVp5d0tJQ0FnSUM4dklDQWdkR2hwY3k1c1lYTjBWWEJrWVhSbFpDNTJZV3gxWlN3S0lDQWdJQzh2SUYwN0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J5WlhSemRXSUtDZ292THlCaGJHZHZYMlZ6WTNKdmR5OUJiR2R2UlhOamNtOTNRMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV3huYjBWelkzSnZkME52Ym5SeVlXTjBMbWRsZEZCaGNuUnBZMmx3WVc1MGN5Z3BJQzArSUdKNWRHVnpMQ0JpZVhSbGN5d2dZbmwwWlhNNkNtZGxkRkJoY25ScFkybHdZVzUwY3pvS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QmlkWGxsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZblY1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWVd4bmIxOWxjMk55YjNjdlFXeG5iMFZ6WTNKdmQwTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklITmxiR3hsY2lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWljMlZzYkdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUdGc1oyOWZaWE5qY205M0wwRnNaMjlGYzJOeWIzZERiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QmhjbUpwZEdWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0poY21KcGRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklHRnNaMjlmWlhOamNtOTNMMEZzWjI5RmMyTnliM2REYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TkMweU1UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCYkNpQWdJQ0F2THlBZ0lHNWxkeUJCWkdSeVpYTnpLSFJvYVhNdVluVjVaWEl1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0J1WlhjZ1FXUmtjbVZ6Y3loMGFHbHpMbk5sYkd4bGNpNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lHNWxkeUJCWkdSeVpYTnpLSFJvYVhNdVlYSmlhWFJsY2k1MllXeDFaU2tzQ2lBZ0lDQXZMeUJkT3dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVJSmc0R2MzUmhkSFZ6RG5KbGJHVmhjMlZrUVcxdmRXNTBCV0oxZVdWeUMyeGhjM1JWY0dSaGRHVmtCbk5sYkd4bGNoTmpiMjF3YkdWMFpXUk5hV3hsYzNSdmJtVnpDM1J2ZEdGc1FXMXZkVzUwRDNSdmRHRnNUV2xzWlhOMGIyNWxjd1poWTNScGRtVUhZWEppYVhSbGNnUVZIM3gxRTIxcGJHVnpkRzl1WlY5amIyMXdiR1YwWldRSlkyOXRjR3hsZEdWa0NHUnBjM0IxZEdWa01SdEJBUStDQndRR3pOcWpCSjhxNDNNRW16bUc1d1NjeE1SR0JKemVvYjhFbnlNZXBRUWgyTDdRTmhvQWpnY0FvUUNNQUlBQVlnQldBQmdBQWlKRE1Sa1VSREVZUklnQzcwNENVRXhRSndwTVVMQWpRekVaRkVReEdFU0lBckZMQlJVV1Z3WUNUd1pRVHdVV1R3VVdUd1VXVHdVV1R3VVdnQUlBS2s4RlVFOEVVRThEVUU4Q1VFeFFURkFuQ2t4UXNDTkRNUmtVUkRFWVJJZ0NKU05ETVJrVVJERVlSRFlhQVVrVkpCSkVGellhQWtrVkpCSkVGNGdCa0NORE1Sa1VSREVZUklnQlNDTkRNUmtVUkRFWVJEWWFBVWtWSkJKRUY0Z0FrQ05ETVJrVVJERVlSRFlhQVVrVkl4SkVGOEFjTmhvQ1NSVWpFa1FYd0J3MkdnTkpGU01TUkJmQUhEWWFCRWtWSkJKRUY0Z0FEU05ETVJsQS95UXhHQlJFSTBPS0JBQXhBSXY4RWtTTC8wUXFpL3huSndTTC9XY25DWXYrWnljSGkvOW5Kd1VpWnlraVp5Z25DR2VBQ1dOeVpXRjBaV1JCZERJSFp5c3lCMmVBRFVWelkzSnZkME55WldGMFpXU3dpWW9CQURFQUlpcGxSQkpFSWlobFJDY0lFa0FBQ2lJb1pVUW5DeEpCQUlBalJDSW5CV1ZFaS85TEFSSkVJaWNIWlVSS0RFUWlKd1psUkV3S3NTSW5CR1ZFU3dHeUNMSUhJN0lRSXJJQnMwd2pDQ2NGVEdjaUtXVkVDQ2xNWnlzeUIyY2lKd1ZsUkNJbkIyVkVFa0VBRnlnbkRHZUFEMFZ6WTNKdmQwTnZiWEJzWlhSbFpMQ0pLQ2NMWjRBUlRXbHNaWE4wYjI1bFFYQndjbTkyWldTd2lTSkMvMzB4QUNJcVpVUVNRQUFMTVFBaUp3UmxSQkpCQUNNalJDSW9aVVFuQ0JKRUtDY05aeXN5QjJlQURVUnBjM0IxZEdWUGNHVnVaV1N3aVNKQy85cUtBZ0F4QUNJbkNXVkVFa1FpS0dWRUp3MFNSQ0luQm1WRUlpbGxSQW1ML292L0NCSkVpLzVCQUJPeElpY0VaVVNML3JJSXNnY2pzaEFpc2dHemkvOUJBQkt4SWlwbFJJdi9zZ2l5QnlPeUVDS3lBYk1pSndabFJDbE1aeWduREdjck1nZG5nQTlFYVhOd2RYUmxVbVZ6YjJ4MlpXU3dpVEVBSWlwbFJFeExBUkpFSWlobFJDY0lFa1FpS1dWRUZFU3hJaWNHWlVTeUNMSUhJN0lRSXJJQnN5aUFDV05oYm1ObGJHeGxaR2NyTWdkbmdBOUZjMk55YjNkRFlXNWpaV3hzWldTd2lTSW5CbVZFSWlsbFJFeExBUWtpS0dWRUlpY0ZaVVFpSndkbFJDSXJaVVJPQTA4RlR3VlBCWWtpS21WRUlpY0VaVVFpSndsbFJJaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
