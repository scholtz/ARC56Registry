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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.Governor_d951d705
{


    public class GovernorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GovernorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetProposalReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public bool Field4 { get; set; }

                public bool Field5 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetProposalReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetProposalReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is bool vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is bool vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetProposalReturn);
                }
                public bool Equals(GetProposalReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetProposalReturn left, GetProposalReturn right)
                {
                    return EqualityComparer<GetProposalReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetProposalReturn left, GetProposalReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetReceiptReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
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

                public static GetReceiptReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetReceiptReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetReceiptReturn);
                }
                public bool Equals(GetReceiptReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetReceiptReturn left, GetReceiptReturn right)
                {
                    return EqualityComparer<GetReceiptReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetReceiptReturn left, GetReceiptReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create a new proposal. Proposer must have enough voting power.
        ///</summary>
        /// <param name="description"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> Propose(string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 120, 152, 198 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            var result = await base.CallApp(new List<object> { abiHandle, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Propose_Transactions(string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 120, 152, 198 };
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            return await base.MakeTransactionList(new List<object> { abiHandle, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cast a vote. Support: 0=Against, 1=For, 2=Abstain.
        ///</summary>
        /// <param name="proposalId"> </param>
        /// <param name="support"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> CastVote(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, ulong support, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 50, 191, 201 };
            var supportAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supportAbi.From(support);

            var result = await base.CallApp(new List<object> { abiHandle, proposalId, supportAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> CastVote_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, ulong support, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 50, 191, 201 };
            var supportAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); supportAbi.From(support);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalId, supportAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute a succeeded proposal.
        ///</summary>
        /// <param name="proposalId"> </param>
        public async Task Execute(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 49, 162, 85 };

            var result = await base.CallApp(new List<object> { abiHandle, proposalId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Execute_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 49, 162, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel a proposal. Only proposer or admin can cancel.
        ///</summary>
        /// <param name="proposalId"> </param>
        public async Task Cancel(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 191, 66, 11 };

            var result = await base.CallApp(new List<object> { abiHandle, proposalId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Cancel_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 191, 66, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposalId"> </param>
        public async Task<Structs.GetProposalReturn> GetProposal(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 203, 179, 170 };

            var result = await base.SimApp(new List<object> { abiHandle, proposalId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetProposalReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProposal_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 203, 179, 170 };

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposalId"> </param>
        /// <param name="voter"> </param>
        public async Task<Structs.GetReceiptReturn> GetReceipt(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 246, 109, 134 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            var result = await base.SimApp(new List<object> { abiHandle, proposalId, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetReceiptReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetReceipt_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 proposalId, Algorand.Address voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 246, 109, 134 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalId, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> GetProposalCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 60, 164, 107 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetProposalCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 60, 164, 107 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR292ZXJub3IiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0UHJvcG9zYWxSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6ImJvb2wifV0sIkdldFJlY2VpcHRSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ1MTIifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicHJvcG9zZSIsImRlc2MiOiJDcmVhdGUgYSBuZXcgcHJvcG9zYWwuIFByb3Bvc2VyIG11c3QgaGF2ZSBlbm91Z2ggdm90aW5nIHBvd2VyLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYXN0Vm90ZSIsImRlc2MiOiJDYXN0IGEgdm90ZS4gU3VwcG9ydDogMD1BZ2FpbnN0LCAxPUZvciwgMj1BYnN0YWluLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3VwcG9ydCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleGVjdXRlIiwiZGVzYyI6IkV4ZWN1dGUgYSBzdWNjZWVkZWQgcHJvcG9zYWwuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbCIsImRlc2MiOiJDYW5jZWwgYSBwcm9wb3NhbC4gT25seSBwcm9wb3NlciBvciBhZG1pbiBjYW4gY2FuY2VsLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NTEyLHVpbnQ1MTIsdWludDUxMixib29sLGJvb2wpIiwic3RydWN0IjoiR2V0UHJvcG9zYWxSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlY2VpcHQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiR2V0UmVjZWlwdFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UHJvcG9zYWxDb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6NX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTk2XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSBjYW5jZWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTAsOTc4XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSBleGVjdXRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5MF0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgdm90ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDVdLCJlcnJvck1lc3NhZ2UiOiJiZWxvdyBwcm9wb3NhbCB0aHJlc2hvbGQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQ5LDU0MCw4MTQsOTQzLDEzMDBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwcm9wb3NhbENvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHByb3Bvc2FsVGhyZXNob2xkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHF1b3J1bVZvdGVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxMSw1OTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0b2tlbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTYsODA0LDkzMywxMDU3LDEyMDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NTEyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ4LDgyMiw5NTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHByb3Bvc2FsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB2b3RlIHR5cGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzJdLCJlcnJvck1lc3NhZ2UiOiJubyB2b3RpbmcgcG93ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI2XSwiZXJyb3JNZXNzYWdlIjoibm90IHByb3Bvc2VyIG9yIGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk3LDcyNywxMTQzLDExNTgsMTE3MCwxMjczLDEyODUsMTMwNV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODY1XSwiZXJyb3JNZXNzYWdlIjoicHJvcG9zYWwgY2FuY2VsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg5XSwiZXJyb3JNZXNzYWdlIjoicHJvcG9zYWwgbm90IHN1Y2NlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwN10sImVycm9yTWVzc2FnZSI6InF1b3J1bSBub3QgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WjI5MlpYSnVZVzVqWlM5amIyNTBjbUZqZEhNdlIyOTJaWEp1YjNJdWMyOXNMa2R2ZG1WeWJtOXlMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQTJOQ0F4SURJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnZ0luQnliM0J2YzJGc1EyOTFiblFpSURCNE1UVXhaamRqTnpVZ0luUnZhMlZ1SWlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQWdJbUZrYldsdUlpQWljWFZ2Y25WdFZtOTBaWE1pSUNKd2NtOXdiM05oYkZSb2NtVnphRzlzWkNJZ0lsOXdjbTl3YjNOaGJGQnliM0J2YzJWeUlpQWlYM0psWTJWcGNIUklZWE5XYjNSbFpDSWdJbDl3Y205d2IzTmhiRUZuWVdsdWMzUldiM1JsY3lJZ0lsOXdjbTl3YjNOaGJFWnZjbFp2ZEdWeklpQWlYM0J5YjNCdmMyRnNRV0p6ZEdGcGJsWnZkR1Z6SWlBaVgzQnliM0J2YzJGc1JYaGxZM1YwWldRaUlDSmZjSEp2Y0c5ellXeERZVzVqWld4c1pXUWlJREI0T0daa1pEaGlNamNnSWw5eVpXTmxhWEIwVTNWd2NHOXlkQ0lnSWw5eVpXTmxhWEIwVm05MFpYTWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIydGxiaUlLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5CeWIzQnZjMkZzUTI5MWJuUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTmlBdkx5QWljWFZ2Y25WdFZtOTBaWE1pQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ055QXZMeUFpY0hKdmNHOXpZV3hVYUhKbGMyaHZiR1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5clpXNGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpY1hWdmNuVnRWbTkwWlhNaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p3Y205d2IzTmhiRlJvY21WemFHOXNaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEY3hOemc1T0dNMklEQjRZemN6TW1KbVl6a2dNSGcxWXpNeFlUSTFOU0F3ZURVeFltWTBNakJpSURCNE1tVmpZbUl6WVdFZ01IZ3pObVkyTm1RNE5pQXdlRGRrTTJOaE5EWmlJQzh2SUcxbGRHaHZaQ0FpY0hKdmNHOXpaU2h6ZEhKcGJtY3BkV2x1ZERVeE1pSXNJRzFsZEdodlpDQWlZMkZ6ZEZadmRHVW9kV2x1ZERVeE1peDFhVzUwTmpRcGRXbHVkRFV4TWlJc0lHMWxkR2h2WkNBaVpYaGxZM1YwWlNoMWFXNTBOVEV5S1hadmFXUWlMQ0J0WlhSb2IyUWdJbU5oYm1ObGJDaDFhVzUwTlRFeUtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGQnliM0J2YzJGc0tIVnBiblExTVRJcEtHRmtaSEpsYzNNc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzWW05dmJDeGliMjlzS1NJc0lHMWxkR2h2WkNBaVoyVjBVbVZqWldsd2RDaDFhVzUwTlRFeUxHRmtaSEpsYzNNcEtHSnZiMndzZFdsdWREVXhNaXgxYVc1ME5URXlLU0lzSUcxbGRHaHZaQ0FpWjJWMFVISnZjRzl6WVd4RGIzVnVkQ2dwZFdsdWREVXhNaUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhCeWIzQnZjMlVnWTJGemRGWnZkR1VnWlhobFkzVjBaU0JqWVc1alpXd2daMlYwVUhKdmNHOXpZV3dnWjJWMFVtVmpaV2x3ZENCblpYUlFjbTl3YjNOaGJFTnZkVzUwQ2lBZ0lDQmxjbklLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdloyOTJaWEp1WVc1alpTOWpiMjUwY21GamRITXZSMjkyWlhKdWIzSXVjMjlzTGtkdmRtVnlibTl5TG5CeWIzQnZjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd2NtOXdiM05sT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiMnRsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEc5clpXNGdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXhOU0F2THlCdFpYUm9iMlFnSW1kbGRGWnZkR2x1WjFCdmQyVnlLR0ZrWkhKbGMzTXBkV2x1ZERVeE1pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSndjbTl3YjNOaGJGUm9jbVZ6YUc5c1pDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NISnZjRzl6WVd4VWFISmxjMmh2YkdRZ1pYaHBjM1J6Q2lBZ0lDQmlQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmlaV3h2ZHlCd2NtOXdiM05oYkNCMGFISmxjMmh2YkdRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRU52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCd2NtOXdiM05oYkVOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRU52ZFc1MElnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVgzQnliM0J2YzJGc1VISnZjRzl6WlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE56VTROV1kwTmpjS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bmIzWmxjbTVoYm1ObEwyTnZiblJ5WVdOMGN5OUhiM1psY201dmNpNXpiMnd1UjI5MlpYSnViM0l1WTJGemRGWnZkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwallYTjBWbTkwWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFV4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0krQ2lBZ0lDQmllaUJqWVhOMFZtOTBaVjlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRU52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCd2NtOXdiM05oYkVOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnWkdsbklETUtJQ0FnSUdJK1BRb2dJQ0FnWW5vZ1kyRnpkRlp2ZEdWZlltOXZiRjltWVd4elpVQTBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb0tZMkZ6ZEZadmRHVmZZbTl2YkY5dFpYSm5aVUExT2dvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdjSEp2Y0c5ellXd0tJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkbTkwWlNCMGVYQmxDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dPQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGNLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbDl5WldObGFYQjBTR0Z6Vm05MFpXUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdGc2NtVmhaSGtnZG05MFpXUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiMnRsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEc5clpXNGdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QXhOU0F2THlCdFpYUm9iMlFnSW1kbGRGWnZkR2x1WjFCdmQyVnlLR0ZrWkhKbGMzTXBkV2x1ZERVeE1pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlQZ29nSUNBZ1lYTnpaWEowSUM4dklHNXZJSFp2ZEdsdVp5QndiM2RsY2dvZ0lDQWdaR2xuSURFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKZmNtVmpaV2x3ZEVoaGMxWnZkR1ZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ1pHbG5JRElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUFpWDNKbFkyVnBjSFJUZFhCd2IzSjBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldNZ01UY2dMeThnSWw5eVpXTmxhWEIwVm05MFpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpYm5vZ1kyRnpkRlp2ZEdWZlpXeHpaVjlpYjJSNVFEZ0tJQ0FnSUdScFp5QTBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0pmY0hKdmNHOXpZV3hCWjJGcGJuTjBWbTkwWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWWlzS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLQ21OaGMzUldiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEk2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5WXpsa1pXSXpPQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTJDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZMkZ6ZEZadmRHVmZaV3h6WlY5aWIyUjVRRGc2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQmpZWE4wVm05MFpWOWxiSE5sWDJKdlpIbEFNVEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKZmNISnZjRzl6WVd4R2IzSldiM1JsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBMUNpQWdJQ0JpS3dvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lpQmpZWE4wVm05MFpWOWhablJsY2w5cFpsOWxiSE5sUURFeUNncGpZWE4wVm05MFpWOWxiSE5sWDJKdlpIbEFNVEE2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVgzQnliM0J2YzJGc1FXSnpkR0ZwYmxadmRHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHSXJDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUdOaGMzUldiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ21OaGMzUldiM1JsWDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdOaGMzUldiM1JsWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTluYjNabGNtNWhibU5sTDJOdmJuUnlZV04wY3k5SGIzWmxjbTV2Y2k1emIyd3VSMjkyWlhKdWIzSXVaWGhsWTNWMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVY0WldOMWRHVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpUGdvZ0lDQWdZbm9nWlhobFkzVjBaVjlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205d2IzTmhiRU52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCd2NtOXdiM05oYkVOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUdJK1BRb2dJQ0FnWW5vZ1pYaGxZM1YwWlY5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENncGxlR1ZqZFhSbFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIQnliM0J2YzJGc0NpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSmZjSEp2Y0c5ellXeEZlR1ZqZFhSbFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWVd4eVpXRmtlU0JsZUdWamRYUmxaQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJbDl3Y205d2IzTmhiRU5oYm1ObGJHeGxaQ0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklIQnliM0J2YzJGc0lHTmhibU5sYkd4bFpBb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lsOXdjbTl3YjNOaGJFWnZjbFp2ZEdWeklnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlYM0J5YjNCdmMyRnNRV2RoYVc1emRGWnZkR1Z6SWdvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWp3S0lDQWdJR0Z6YzJWeWRDQXZMeUJ3Y205d2IzTmhiQ0J1YjNRZ2MzVmpZMlZsWkdWa0NpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVgzQnliM0J2YzJGc1FXSnpkR0ZwYmxadmRHVnpJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWWlzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p4ZFc5eWRXMVdiM1JsY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY1hWdmNuVnRWbTkwWlhNZ1pYaHBjM1J6Q2lBZ0lDQmlQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnhkVzl5ZFcwZ2JtOTBJSEpsWVdOb1pXUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzNNVEpoWlRFek9Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGxlR1ZqZFhSbFgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHVjRaV04xZEdWZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJkdmRtVnlibUZ1WTJVdlkyOXVkSEpoWTNSekwwZHZkbVZ5Ym05eUxuTnZiQzVIYjNabGNtNXZjaTVqWVc1alpXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVc1alpXdzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZajRLSUNBZ0lHSjZJR05oYm1ObGJGOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndjbTl3YjNOaGJFTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3Y205d2IzTmhiRU52ZFc1MElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJR0krUFFvZ0lDQWdZbm9nWTJGdVkyVnNYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ21OaGJtTmxiRjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J3Y205d2IzTmhiQW9nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWDNCeWIzQnZjMkZzUlhobFkzVjBaV1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhiSEpsWVdSNUlHVjRaV04xZEdWa0NpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVgzQnliM0J2YzJGc1EyRnVZMlZzYkdWa0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdGc2NtVmhaSGtnWTJGdVkyVnNiR1ZrQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUE0SUM4dklDSmZjSEp2Y0c5ellXeFFjbTl3YjNObGNpSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdOaGJtTmxiRjlpYjI5c1gzUnlkV1ZBTndvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmllaUJqWVc1alpXeGZZbTl2YkY5bVlXeHpaVUE0Q2dwallXNWpaV3hmWW05dmJGOTBjblZsUURjNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvS1kyRnVZMlZzWDJKdmIyeGZiV1Z5WjJWQU9Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjSEp2Y0c5elpYSWdiM0lnWVdSdGFXNEtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROREUyWlRZMk9XTUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tZMkZ1WTJWc1gySnZiMnhmWm1Gc2MyVkFPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHTmhibU5sYkY5aWIyOXNYMjFsY21kbFFEa0tDbU5oYm1ObGJGOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQmpZVzVqWld4ZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDJkdmRtVnlibUZ1WTJVdlkyOXVkSEpoWTNSekwwZHZkbVZ5Ym05eUxuTnZiQzVIYjNabGNtNXZjaTVuWlhSUWNtOXdiM05oYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRkJ5YjNCdmMyRnNPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTlRFeUNpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNBdENpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbDl3Y205d2IzTmhiRkJ5YjNCdmMyVnlJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZbmwwWldNZ01URWdMeThnSWw5d2NtOXdiM05oYkVadmNsWnZkR1Z6SWdvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVgzQnliM0J2YzJGc1FXZGhhVzV6ZEZadmRHVnpJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpWDNCeWIzQnZjMkZzUVdKemRHRnBibFp2ZEdWeklnb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlYM0J5YjNCdmMyRnNSWGhsWTNWMFpXUWlDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pmY0hKdmNHOXpZV3hEWVc1alpXeHNaV1FpQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWkdsbklEWUtJQ0FnSUdKOENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JpZkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bmIzWmxjbTVoYm1ObEwyTnZiblJ5WVdOMGN5OUhiM1psY201dmNpNXpiMnd1UjI5MlpYSnViM0l1WjJWMFVtVmpaV2x3ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRkpsWTJWcGNIUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblExTVRJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTmpRS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QTJOQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklEa2dMeThnSWw5eVpXTmxhWEIwU0dGelZtOTBaV1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKZmNtVmpaV2x3ZEZOMWNIQnZjblFpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKZmNtVmpaV2x3ZEZadmRHVnpJZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lITmxkR0pwZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5bmIzWmxjbTVoYm1ObEwyTnZiblJ5WVdOMGN5OUhiM1psY201dmNpNXpiMnd1UjI5MlpYSnViM0l1WjJWMFVISnZjRzl6WVd4RGIzVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGQnliM0J2YzJGc1EyOTFiblE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljSEp2Y0c5ellXeERiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY0hKdmNHOXpZV3hEYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12WjI5MlpYSnVZVzVqWlM5amIyNTBjbUZqZEhNdlIyOTJaWEp1YjNJdWMyOXNMa2R2ZG1WeWJtOXlMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFFQUJBaVlTQUExd2NtOXdiM05oYkVOdmRXNTBCQlVmZkhVRmRHOXJaVzRnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZZV1J0YVc0TGNYVnZjblZ0Vm05MFpYTVJjSEp2Y0c5ellXeFVhSEpsYzJodmJHUVJYM0J5YjNCdmMyRnNVSEp2Y0c5elpYSVFYM0psWTJWcGNIUklZWE5XYjNSbFpCVmZjSEp2Y0c5ellXeEJaMkZwYm5OMFZtOTBaWE1SWDNCeWIzQnZjMkZzUm05eVZtOTBaWE1WWDNCeWIzQnZjMkZzUVdKemRHRnBibFp2ZEdWekVWOXdjbTl3YjNOaGJFVjRaV04xZEdWa0VsOXdjbTl3YjNOaGJFTmhibU5sYkd4bFpBU1AzWXNuRDE5eVpXTmxhWEIwVTNWd2NHOXlkQTFmY21WalpXbHdkRlp2ZEdWek1SaEFBQzhySndSbkp3VW5CR2NwS0djbkJpaG5Kd2NvWnpZYUFUWWFBaXMyR2dCbkp3VXhBR2NuQms4Q1p5Y0hUR2NrUXpFWkZFUXhHRVNDQndSeGVKakdCTWN5djhrRVhER2lWUVJSdjBJTEJDN0xzNm9FTnZadGhnUjlQS1JyTmhvQWpnY0FBUUIxQVpnQ0dBS1dBeWNEalFBMkdnRkpJbGtsQ0VzQkZSSkVWd0lBc1RFQUlpdGxSSUVZVzRFR3NoQWlzaGtpc2dHeUdDY1BzaHF5R3JPMFBsY0VBQ0luQjJWRXAwUWlLV1ZFSkJhZ0tVc0JaekVBSTY5SlN3TlFTUlVqQ1NOWUFTY0lURkJQQXIrQUJIV0Y5R2N4QUZCUEExQ3dTd0VWSXc1RXF5cE1VTEFrUXlKSEF6WWFBVWNDRlNNU1JEWWFBa2tWZ1FnU1JCZE1JaFpKVGdLbFFRRC9JaWxsUkVzRHAwRUE5U1JFU3dGSkpRNUVJNjlKUlFoTEJGQkpGU01KSTFoSlJRZEpNUUJRQVNjSlRGQytUQmNpVEU4Q1RSUkVzVEVBSWl0bFJJRVlXNEVHc2hBaXNoa2lzZ0d5R0NjUHNocXlHck8wUGxjRUFFbEZCMGxMQktWRVN3RXhBRkFCSndsTVVDUVd2MHNDRmtsRkMwc0NNUUJRQVNjUVRGQkp2RWhNdnpFQVR3Sk1VQUVuRVV4UVNieElUTDlBQUROTEJBRW5Da3hRU2I0b1RnSk5Td1dnU3dHOFNMK0FCQ3lkNnpoTEIxQkxCRWxPQWxDd1NSVWpEa1JMQnFzcVRGQ3dKRU5MQVNRU1FRQVlTd1FCSnd0TVVFbStLRTRDVFVzRm9Fc0J2RWkvUXYvRFN3UUJKd3hNVUVtK0tFNENUVXNGb0VzQnZFaS9RditySWtML0NEWWFBVWNDRlNNU1JDSVdwVUVBYlNJcFpVUkxBYWRCQUdNa1JDT3ZTd0ZRU1JVakNTTllBU2NOU3dGUVNiNU1GeUpNVHdKTkZFUW5Ea3NDVUw1TUZ5Sk1Ud0pORkVRbkMwc0NVTDRvVGdKTkp3cExBMUMrS0U0Q1RVc0JwRVFuREU4RFVMNG9UZ0pOb0NJbkJtVkVwMFFrRnIrQUJIRXE0VGl3SkVNaVF2K2FJallhQVVjQ0ZTTVNSQ0lXcFVFQWFpSXBaVVJMQWFkQkFHQWtSQ092U3dGUVNSVWpDU05ZQVNjTlN3RlF2a3dYSWt4UEFrMFVSQ2NPU3dGUVNVVUV2a3dYSWt4UEFrMFVSREVBSndoUEFsQytKd1JPQWswU1FBQUxNUUFpSndWbFJCSkJBQkVrUkNRV1N3Sk12NEFFUVc1bW5MQWtReUpDLyt3aVF2K2ROaG9CU1JVakVrUWpyMGxQQWxCSkZTTUpJMWdCSndoTEFWQytKd1JPQWswbkMwc0NVTDRvVGdKTkp3cExBMUMrS0U0Q1RTY01Td1JRdmloT0FrMG5EVXNGVUw1TUZ5Sk1Ud0pOSnc1UEJsQytUQmNpVEU4Q1RVc0VGU01PUkU4RVN3YXJUd1ZNVUVzRUZTTU9SRThFU3dXclVFc0RGU01PUkU4RFR3U3JVSUFCQUNKUEJGUWtUd05VVUNwTVVMQWtRellhQVVrVkl4SkVOaG9DU1JXQklCSkVJNjlKVHdOUVNSVWpDU05ZVHdKUUFTY0pTd0ZRdmt3WElreFBBazBuRUVzQ1VMNG9UZ0pOSnhGUEExQytLRTRDVFlBQkFDSlBCRlJMQWhVakRrUlBBa3NEcTFCTEFSVWpEa1JNVHdLclVDcE1VTEFrUXlJcFpVUkpGU01PUkNPdnF5cE1VTEFrUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
