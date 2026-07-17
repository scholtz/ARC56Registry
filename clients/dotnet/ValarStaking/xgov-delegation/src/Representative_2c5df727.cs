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

namespace Arc56.Generated.ValarStaking.xgov_delegation.Representative_2c5df727
{


    public class RepresentativeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RepresentativeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Vote : AVMObjectType
            {
                public ulong Approval { get; set; }

                public ulong Rejection { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApproval.From(Approval);
                    ret.AddRange(vApproval.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRejection = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRejection.From(Rejection);
                    ret.AddRange(vRejection.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Vote Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Vote();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApproval.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApproval = vApproval.ToValue();
                    if (valueApproval is ulong vApprovalValue) { ret.Approval = vApprovalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRejection = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRejection.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRejection = vRejection.ToValue();
                    if (valueRejection is ulong vRejectionValue) { ret.Rejection = vRejectionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Vote);
                }
                public bool Equals(Vote? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Vote left, Vote right)
                {
                    return EqualityComparer<Vote>.Default.Equals(left, right);
                }
                public static bool operator !=(Vote left, Vote right)
                {
                    return !(left == right);
                }

            }

            public class GetVoteBoxReturn : AVMObjectType
            {
                public Structs.Vote Field0 { get; set; } = new Structs.Vote();

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetVoteBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetVoteBoxReturn();
                    uint count = 0;
                    ret.Field0 = Structs.Vote.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetVoteBoxReturn);
                }
                public bool Equals(GetVoteBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetVoteBoxReturn left, GetVoteBoxReturn right)
                {
                    return EqualityComparer<GetVoteBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetVoteBoxReturn left, GetVoteBoxReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create a new representative.
        ///MUST BE CALLED BY THE REGISTRY CONTRACT.
        ///</summary>
        /// <param name="representative_address">Address of the representative. </param>
        public async Task Create(Algorand.Address representative_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 105, 78, 170 };
            var representative_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); representative_addressAbi.From(representative_address);

            var result = await base.CallApp(new List<object> { abiHandle, representative_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address representative_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 105, 78, 170 };
            var representative_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); representative_addressAbi.From(representative_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, representative_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the contract.
        ///MUST BE CALLED BY THE REGISTRY CONTRACT.
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause the representation.
        ///</summary>
        public async Task Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Resume the representation.
        ///</summary>
        public async Task Resume(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 45, 88, 171 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Resume_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 45, 88, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Publish representative's vote.
        ///</summary>
        /// <param name="payment">Payment to cover MBR. </param>
        /// <param name="proposal_id">App ID of proposal to vote on. </param>
        /// <param name="vote">Representative's vote for the proposal. Vote</param>
        public async Task PublishVote(PaymentTransaction payment, ulong proposal_id, Structs.Vote vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 60, 54, 38, 148 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, payment, proposal_idAbi, vote }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PublishVote_Transactions(PaymentTransaction payment, ulong proposal_id, Structs.Vote vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 60, 54, 38, 148 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, proposal_idAbi, vote }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete a representative's vote.
        ///Cannot delete vote during voting stage of a proposal.
        ///</summary>
        /// <param name="proposal_id">App ID of proposal which vote to delete. </param>
        public async Task DeleteVote(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 28, 126, 165 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteVote_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 28, 126, 165 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the representative.
        ///MUST BE CALLED BY THE REGISTRY CONTRACT.
        ///</summary>
        public async Task Delete(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the representative's vote on a proposal.
        ///</summary>
        /// <param name="proposal_id">App ID of the proposal. </param>
        public async Task<Structs.GetVoteBoxReturn> GetVoteBox(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 230, 204, 214 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.SimApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetVoteBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVoteBox_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 230, 204, 214 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the representative's vote on a proposal.
        ///</summary>
        /// <param name="proposal_id">App ID of the proposal. </param>
        public async Task<Structs.GetVoteBoxReturn> GetVote(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 168, 30, 177 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.SimApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetVoteBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVote_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 168, 30, 177 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVwcmVzZW50YXRpdmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVm90ZSI6W3sibmFtZSI6ImFwcHJvdmFsIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlamVjdGlvbiIsInR5cGUiOiJ1aW50NjQifV0sIkdldFZvdGVCb3hSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiVm90ZSJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJDcmVhdGUgYSBuZXcgcmVwcmVzZW50YXRpdmUuXG5NVVNUIEJFIENBTExFRCBCWSBUSEUgUkVHSVNUUlkgQ09OVFJBQ1QuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXByZXNlbnRhdGl2ZV9hZGRyZXNzIiwiZGVzYyI6IkFkZHJlc3Mgb2YgdGhlIHJlcHJlc2VudGF0aXZlLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjoiVXBkYXRlIHRoZSBjb250cmFjdC5cbk1VU1QgQkUgQ0FMTEVEIEJZIFRIRSBSRUdJU1RSWSBDT05UUkFDVC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlIiwiZGVzYyI6IlBhdXNlIHRoZSByZXByZXNlbnRhdGlvbi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzdW1lIiwiZGVzYyI6IlJlc3VtZSB0aGUgcmVwcmVzZW50YXRpb24uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InB1Ymxpc2hfdm90ZSIsImRlc2MiOiJQdWJsaXNoIHJlcHJlc2VudGF0aXZlJ3Mgdm90ZS4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiJQYXltZW50IHRvIGNvdmVyIE1CUi4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6IkFwcCBJRCBvZiBwcm9wb3NhbCB0byB2b3RlIG9uLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVm90ZSIsIm5hbWUiOiJ2b3RlIiwiZGVzYyI6IlJlcHJlc2VudGF0aXZlJ3Mgdm90ZSBmb3IgdGhlIHByb3Bvc2FsLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfdm90ZSIsImRlc2MiOiJEZWxldGUgYSByZXByZXNlbnRhdGl2ZSdzIHZvdGUuXG5DYW5ub3QgZGVsZXRlIHZvdGUgZHVyaW5nIHZvdGluZyBzdGFnZSBvZiBhIHByb3Bvc2FsLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOiJBcHAgSUQgb2YgcHJvcG9zYWwgd2hpY2ggdm90ZSB0byBkZWxldGUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZSIsImRlc2MiOiJEZWxldGUgdGhlIHJlcHJlc2VudGF0aXZlLlxuTVVTVCBCRSBDQUxMRUQgQlkgVEhFIFJFR0lTVFJZIENPTlRSQUNULiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3ZvdGVfYm94IiwiZGVzYyI6IkdldCB0aGUgcmVwcmVzZW50YXRpdmUncyB2b3RlIG9uIGEgcHJvcG9zYWwuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6IkFwcCBJRCBvZiB0aGUgcHJvcG9zYWwuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IigodWludDY0LHVpbnQ2NCksYm9vbCkiLCJzdHJ1Y3QiOiJHZXRWb3RlQm94UmV0dXJuIiwiZGVzYyI6IlJlcHJlc2VudGF0aXZlJ3Mgdm90ZS4gYm9vbDogYFRydWVgIGlmIHJlcHJlc2VudGF0aXZlJ3Mgdm90ZSBleGlzdHMsIGVsc2UgYEZhbHNlYC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF92b3RlIiwiZGVzYyI6IkdldCB0aGUgcmVwcmVzZW50YXRpdmUncyB2b3RlIG9uIGEgcHJvcG9zYWwuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6IkFwcCBJRCBvZiB0aGUgcHJvcG9zYWwuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IigodWludDY0LHVpbnQ2NCksYm9vbCkiLCJzdHJ1Y3QiOiJHZXRWb3RlQm94UmV0dXJuIiwiZGVzYyI6IlJlcHJlc2VudGF0aXZlJ3Mgdm90ZS4gYm9vbDogVHJ1ZSBpZiByZXByZXNlbnRhdGl2ZSdzIHZvdGUgZXhpc3RzIGFuZCByZXByZXNlbnRhdGl2ZSBpc24ndCBwYXVzZWQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MzIsImJ5dGVzIjozMn0sImxvY2FsIjp7ImludHMiOjcsImJ5dGVzIjo5fX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzQ1XSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDkyXSwiZXJyb3JNZXNzYWdlIjoiTm90IGFsbCBib3hlcyBkZWxldGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgRGVsZXRlQXBwbGljYXRpb24gJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBVcGRhdGVBcHBsaWNhdGlvbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQwXSwiZXJyb3JNZXNzYWdlIjoiUHJvcG9zYWwgaXMgaW4gdm90aW5nIHN0YWdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM5XSwiZXJyb3JNZXNzYWdlIjoiUHJvcG9zYWwgaXMgbm90IHBhcnQgb2YgeEdvdiBSZWdpc3RyeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NV0sImVycm9yTWVzc2FnZSI6IlJlcHJlc2VudGF0aXZlIHZvdGUgd2FzIGFscmVhZHkgcHVibGlzaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ2LDQ4M10sImVycm9yTWVzc2FnZSI6IlNlbmRlciBpcyBub3QgYXBwIGNyZWF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjgsMjUyLDI2MSwzMDIsNDE2XSwiZXJyb3JNZXNzYWdlIjoiVW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzLDM3MV0sImVycm9yTWVzc2FnZSI6IlZvdGUgbm90IGluIFBQTSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgR2xvYmFsIEJ5dGVzIGFsbG9jYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3N10sImVycm9yTWVzc2FnZSI6Ildyb25nIEdsb2JhbCBVSW50cyBhbGxvY2F0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBMb2NhbCBCeXRlcyBhbGxvY2F0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODldLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBMb2NhbCBVSW50cyBhbGxvY2F0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg5XSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgUmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTRdLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBwYXltZW50IGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OCwzNzksNDEyLDQ1Myw0ODhdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOSwzMzddLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDMsNTU2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXVzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcm9wb3NhbHNfdm90ZV9ib3ggZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWdpc3RyeV9hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXByZXNlbnRhdGl2ZV9hZGRyZXNzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODQsNDA0LDUyMCw1NDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzLmNvbW1vbi5hYmlfdHlwZXMuVm90ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Nl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6TWlBeE1EQXdNREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TnpBMk1UYzFOek0yTlRZMElEQjROekkyTlRjd056STJOVGN6TmpVMlpUYzBOakUzTkRZNU56WTJOVFZtTmpFMk5EWTBOekkyTlRjek56TWdNSGczTWpZMU5qYzJPVGN6TnpRM01qYzVOV1kyTVRjd056QWdNSGczTURjMklEQjRNVFV4Wmpkak56VUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG8wTUMwME1Rb2dJQ0FnTHk4Z0l5QlFjbVZqYjI1a2FYUnBiMjV6Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG1kc2IySmhiRjl1ZFcxZllubDBaVjl6YkdsalpTQTlQU0JqWm1jdVIweFBRa0ZNWDBKWlZFVlRMQ0JsY25JdVYxSlBUa2RmUjB4UFFrRk1YMEpaVkVWVENpQWdJQ0IwZUc0Z1IyeHZZbUZzVG5WdFFubDBaVk5zYVdObENpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWM0p2Ym1jZ1IyeHZZbUZzSUVKNWRHVnpJR0ZzYkc5allYUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUbzBNZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTVuYkc5aVlXeGZiblZ0WDNWcGJuUWdQVDBnWTJabkxrZE1UMEpCVEY5VlNVNVVVeXdnWlhKeUxsZFNUMDVIWDBkTVQwSkJURjlWU1U1VVV3b2dJQ0FnZEhodUlFZHNiMkpoYkU1MWJWVnBiblFLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWGNtOXVaeUJIYkc5aVlXd2dWVWx1ZEhNZ1lXeHNiMk5oZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxteHZZMkZzWDI1MWJWOWllWFJsWDNOc2FXTmxJRDA5SUdObVp5NU1UME5CVEY5Q1dWUkZVeXdnWlhKeUxsZFNUMDVIWDB4UFEwRk1YMEpaVkVWVENpQWdJQ0IwZUc0Z1RHOWpZV3hPZFcxQ2VYUmxVMnhwWTJVS0lDQWdJSEIxYzJocGJuUWdPU0F2THlBNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRmR5YjI1bklFeHZZMkZzSUVKNWRHVnpJR0ZzYkc5allYUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTVzYjJOaGJGOXVkVzFmZFdsdWRDQTlQU0JqWm1jdVRFOURRVXhmVlVsT1ZGTXNJR1Z5Y2k1WFVrOU9SMTlNVDBOQlRGOVZTVTVVVXdvZ0lDQWdkSGh1SUV4dlkyRnNUblZ0VldsdWRBb2dJQ0FnY0hWemFHbHVkQ0EzSUM4dklEY0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVjNKdmJtY2dURzlqWVd3Z1ZVbHVkSE1nWVd4c2IyTmhkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJyWlhrOVkyWm5Ma2RUWDB0RldWOVNSVkJTUlZORlRsUkJWRWxXUlY5QlJFUlNSVk5UTEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURjeU5qVTNNRGN5TmpVM016WTFObVUzTkRZeE56UTJPVGMyTmpVMVpqWXhOalEyTkRjeU5qVTNNemN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJRUZqWTI5MWJuUW9LU3dLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pRMkxUVXdDaUFnSUNBdkx5QWpJRWRzYjJKaGJDQldZWEpwWVdKc1pYTUtJQ0FnSUM4dklITmxiR1l1Y21Wd2NtVnpaVzUwWVhScGRtVmZZV1JrY21WemN5QTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lFRmpZMjkxYm5Rb0tTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOVkyWm5Ma2RUWDB0RldWOVNSVkJTUlZORlRsUkJWRWxXUlY5QlJFUlNSVk5UTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnYTJWNVBXTm1aeTVIVTE5TFJWbGZVa1ZIU1ZOVVVsbGZRVkJRTEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURjeU5qVTJOelk1TnpNM05EY3lOemsxWmpZeE56QTNNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QkJjSEJzYVdOaGRHbHZiaWdwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUbzFNUzAxTkFvZ0lDQWdMeThnYzJWc1ppNXlaV2RwYzNSeWVWOWhjSEFnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JCY0hCc2FXTmhkR2x2YmlncExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxalptY3VSMU5mUzBWWlgxSkZSMGxUVkZKWlgwRlFVQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJR3RsZVQxalptY3VSMU5mUzBWWlgxQkJWVk5GUkN3S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM01EWXhOelUzTXpZMU5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z1ZVbHVkRFkwS0Nrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPalUyTFRVNUNpQWdJQ0F2THlCelpXeG1MbkJoZFhObFpDQTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNncExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxalptY3VSMU5mUzBWWlgxQkJWVk5GUkN3S0lDQWdJQzh2SUNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3lPUzB6T0FvZ0lDQWdMeThnWTJ4aGMzTWdVbVZ3Y21WelpXNTBZWFJwZG1Vb0NpQWdJQ0F2THlBZ0lDQWdRVkpETkVOdmJuUnlZV04wTEFvZ0lDQWdMeThnSUNBZ0lHRjJiVjkyWlhKemFXOXVQVEV3TEFvZ0lDQWdMeThnSUNBZ0lITjBZWFJsWDNSdmRHRnNjejFUZEdGMFpWUnZkR0ZzY3lnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWjJ4dlltRnNYMko1ZEdWelBXTm1aeTVIVEU5Q1FVeGZRbGxVUlZNc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdkc2IySmhiRjkxYVc1MGN6MWpabWN1UjB4UFFrRk1YMVZKVGxSVExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCc2IyTmhiRjlpZVhSbGN6MWpabWN1VEU5RFFVeGZRbGxVUlZNc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUd4dlkyRnNYM1ZwYm5SelBXTm1aeTVNVDBOQlRGOVZTVTVVVXl3S0lDQWdJQzh2SUNBZ0lDQXBMQW9nSUNBZ0x5OGdLVG9LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhoTUdVNE1UZzNNaUF3ZURJME16YzRaRE5qSUM4dklHMWxkR2h2WkNBaWRYQmtZWFJsS0NsMmIybGtJaXdnYldWMGFHOWtJQ0prWld4bGRHVW9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNWd1pHRjBaVjl5YjNWMFpVQTBJRzFoYVc1ZlpHVnNaWFJsWDNKdmRYUmxRRFVLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qSTVMVE00Q2lBZ0lDQXZMeUJqYkdGemN5QlNaWEJ5WlhObGJuUmhkR2wyWlNnS0lDQWdJQzh2SUNBZ0lDQkJVa00wUTI5dWRISmhZM1FzQ2lBZ0lDQXZMeUFnSUNBZ1lYWnRYM1psY25OcGIyNDlNVEFzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkR1ZmZEc5MFlXeHpQVk4wWVhSbFZHOTBZV3h6S0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JuYkc5aVlXeGZZbmwwWlhNOVkyWm5Ma2RNVDBKQlRGOUNXVlJGVXl3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWjJ4dlltRnNYM1ZwYm5SelBXTm1aeTVIVEU5Q1FVeGZWVWxPVkZNc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUd4dlkyRnNYMko1ZEdWelBXTm1aeTVNVDBOQlRGOUNXVlJGVXl3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYkc5allXeGZkV2x1ZEhNOVkyWm5Ma3hQUTBGTVgxVkpUbFJUTEFvZ0lDQWdMeThnSUNBZ0lDa3NDaUFnSUNBdkx5QXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTFDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNREUzT0dZNU5HSWdNSGd5TkRKa05UaGhZaUF3ZUROak16WXlOamswSURCNFltSXhZemRsWVRVZ01IZzJNMlUyWTJOa05pQXdlRFpsWVRneFpXSXhJQzh2SUcxbGRHaHZaQ0FpY0dGMWMyVW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxjM1Z0WlNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY0hWaWJHbHphRjkyYjNSbEtIQmhlU3gxYVc1ME5qUXNLSFZwYm5RMk5DeDFhVzUwTmpRcEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGJHVjBaVjkyYjNSbEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmRtOTBaVjlpYjNnb2RXbHVkRFkwS1Nnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzWW05dmJDa2lMQ0J0WlhSb2IyUWdJbWRsZEY5MmIzUmxLSFZwYm5RMk5Da29LSFZwYm5RMk5DeDFhVzUwTmpRcExHSnZiMndwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2NHRjFjMlVnY21WemRXMWxJSEIxWW14cGMyaGZkbTkwWlNCa1pXeGxkR1ZmZG05MFpTQm5aWFJmZG05MFpWOWliM2dnWjJWMFgzWnZkR1VLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG95T1Mwek9Bb2dJQ0FnTHk4Z1kyeGhjM01nVW1Wd2NtVnpaVzUwWVhScGRtVW9DaUFnSUNBdkx5QWdJQ0FnUVZKRE5FTnZiblJ5WVdOMExBb2dJQ0FnTHk4Z0lDQWdJR0YyYlY5MlpYSnphVzl1UFRFd0xBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSbFgzUnZkR0ZzY3oxVGRHRjBaVlJ2ZEdGc2N5Z0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1oyeHZZbUZzWDJKNWRHVnpQV05tWnk1SFRFOUNRVXhmUWxsVVJWTXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHZHNiMkpoYkY5MWFXNTBjejFqWm1jdVIweFBRa0ZNWDFWSlRsUlRMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnNiMk5oYkY5aWVYUmxjejFqWm1jdVRFOURRVXhmUWxsVVJWTXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHeHZZMkZzWDNWcGJuUnpQV05tWnk1TVQwTkJURjlWU1U1VVV5d0tJQ0FnSUM4dklDQWdJQ0FwTEFvZ0lDQWdMeThnS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdOak5qazBaV0ZoSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0dGa1pISmxjM01wZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNncHRZV2x1WDJSbGJHVjBaVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qSXlOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05S0NKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlJc0tTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdJZ1pHVnNaWFJsQ2dwdFlXbHVYM1Z3WkdGMFpWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1ZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmlJSFZ3WkdGMFpRb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhCeVpYTmxiblJoZEdsMlpTNWpiMjUwY21GamRDNVNaWEJ5WlhObGJuUmhkR2wyWlM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUVkc2IySmhiQzVqWVd4c1pYSmZZWEJ3YkdsallYUnBiMjVmYVdRZ0lUMGdNQW9nSUNBZ1oyeHZZbUZzSUVOaGJHeGxja0Z3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG80TXkwNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQkhiRzlpWVd3dVkyRnNiR1Z5WDJGd2NHeHBZMkYwYVc5dVgybGtJQ0U5SURBS0lDQWdJQzh2SUNrc0lHVnljaTVWVGtGVlZFaFBVa2xhUlVRZ0lDTWdUMjVzZVNCallXeHNZV0pzWlNCaWVTQmhibTkwYUdWeUlHTnZiblJ5WVdOMENpQWdJQ0JoYzNObGNuUWdMeThnVlc1aGRYUm9iM0pwZW1Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUhObGJHWXVjbVZuYVhOMGNubGZZWEJ3TG5aaGJIVmxJRDBnUVhCd2JHbGpZWFJwYjI0b1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNalkxTmpjMk9UY3pOelEzTWpjNU5XWTJNVGN3TnpBS0lDQWdJR2RzYjJKaGJDQkRZV3hzWlhKQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QnpaV3htTG5KbGNISmxjMlZ1ZEdGMGFYWmxYMkZrWkhKbGMzTXVkbUZzZFdVZ1BTQnlaWEJ5WlhObGJuUmhkR2wyWlY5aFpHUnlaWE56TG01aGRHbDJaUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRGN5TmpVM01EY3lOalUzTXpZMU5tVTNORFl4TnpRMk9UYzJOalUxWmpZeE5qUTJORGN5TmpVM016Y3pDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QnpaV3htTG5CaGRYTmxaQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGN3TmpFM05UY3pOalUyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhCeVpYTmxiblJoZEdsMlpTNWpiMjUwY21GamRDNVNaWEJ5WlhObGJuUmhkR2wyWlM1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZNekEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOWpjbVZoZEc5eUtDa3NJR1Z5Y2k1T1QxUmZRMUpGUVZSUFVnb2dJQ0FnWVhOelpYSjBJQzh2SUZObGJtUmxjaUJwY3lCdWIzUWdZWEJ3SUdOeVpXRjBiM0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUbzVOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WlhCeVpYTmxiblJoZEdsMlpTNWpiMjUwY21GamRDNVNaWEJ5WlhObGJuUmhkR2wyWlM1d1lYVnpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CaGRYTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YVhOZmNtVndjbVZ6Wlc1MFlYUnBkbVVvS1N3Z1pYSnlMbFZPUVZWVVNFOVNTVnBGUkFvZ0lDQWdZMkZzYkhOMVlpQnBjMTl5WlhCeVpYTmxiblJoZEdsMlpRb2dJQ0FnWVhOelpYSjBJQzh2SUZWdVlYVjBhRzl5YVhwbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pFeE5nb2dJQ0FnTHk4Z2MyVnNaaTV3WVhWelpXUXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNRFl4TnpVM016WTFOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21Wd2NtVnpaVzUwWVhScGRtVXVZMjl1ZEhKaFkzUXVVbVZ3Y21WelpXNTBZWFJwZG1VdWNtVnpkVzFsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnpkVzFsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPakV5T0FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWFYTmZjbVZ3Y21WelpXNTBZWFJwZG1Vb0tTd2daWEp5TGxWT1FWVlVTRTlTU1ZwRlJBb2dJQ0FnWTJGc2JITjFZaUJwYzE5eVpYQnlaWE5sYm5SaGRHbDJaUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVZWFYwYUc5eWFYcGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdjMlZzWmk1d1lYVnpaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczTURZeE56VTNNelkxTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPakV5TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVndjbVZ6Wlc1MFlYUnBkbVV1WTI5dWRISmhZM1F1VW1Wd2NtVnpaVzUwWVhScGRtVXVjSFZpYkdsemFGOTJiM1JsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NIVmliR2x6YUY5MmIzUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRXpNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjIxdGIyNHVZV0pwWDNSNWNHVnpMbFp2ZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG94TlRrS0lDQWdJQzh2SUcxaWNsOWlaV1p2Y21VZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtMXBibDlpWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3hOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzSmxjSEpsYzJWdWRHRjBhWFpsS0Nrc0lHVnljaTVWVGtGVlZFaFBVa2xhUlVRS0lDQWdJR05oYkd4emRXSWdhWE5mY21Wd2NtVnpaVzUwWVhScGRtVUtJQ0FnSUdGemMyVnlkQ0F2THlCVmJtRjFkR2h2Y21sNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRvek1qQUtJQ0FnSUM4dklIQnliM0J2YzJGc1gyTnlaV0YwYjNJZ1BTQkJjSEJzYVdOaGRHbHZiaWh3Y205d2IzTmhiRjlwWkM1aGMxOTFhVzUwTmpRb0tTa3VZM0psWVhSdmNnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFTnlaV0YwYjNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3pNVE1LSUNBZ0lDOHZJSE5sYkdZdWNtVm5hWE4wY25sZllYQndMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01qWTFOamMyT1Rjek56UTNNamM1TldZMk1UY3dOekFLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpXZHBjM1J5ZVY5aGNIQWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2TXpFMENpQWdJQ0F2THlCeVpXZGZZMlpuTGtkVFgwdEZXVjlZUjA5V1gxSkZSMGxUVkZKWlgwRlFVQ3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGM0TmpjMlpqYzJOV1kzTWpZMU5qYzJPVGN6TnpRM01qYzVOV1kyTVRjd056QUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRvek1USXRNekUxQ2lBZ0lDQXZMeUI0WjI5MlgzSmxaMmx6ZEhKNVgybGtMQ0JsZUdsemRITWdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBYMlY0WDNWcGJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MbkpsWjJsemRISjVYMkZ3Y0M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZGZZMlpuTGtkVFgwdEZXVjlZUjA5V1gxSkZSMGxUVkZKWlgwRlFVQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG96TWpJS0lDQWdJQzh2SUhobmIzWmZjbVZuYVhOMGNubGZZV1JrY21WemN5QTlJRUZ3Y0d4cFkyRjBhVzl1S0hobmIzWmZjbVZuYVhOMGNubGZhV1FwTG1Ga1pISmxjM01LSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3pNak1LSUNBZ0lDOHZJSEpsZEhWeWJpQndjbTl3YjNOaGJGOWpjbVZoZEc5eUlEMDlJSGhuYjNaZmNtVm5hWE4wY25sZllXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzWmhiR2xrWDNCeWIzQnZjMkZzS0hCeWIzQnZjMkZzWDJsa0tTd2daWEp5TGtsT1ZrRk1TVVJmVUZKUFVFOVRRVXdLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFjbTl3YjNOaGJDQnBjeUJ1YjNRZ2NHRnlkQ0J2WmlCNFIyOTJJRkpsWjJsemRISjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndjbVZ6Wlc1MFlYUnBkbVV2WTI5dWRISmhZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJSE5sYkdZdWNHRjFjMlZrTG5aaGJIVmxMQ0JsY25JdVVFRlZVMFZFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGN3TmpFM05UY3pOalUyTkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyNTBjbUZqZENCcGN5QndZWFZ6WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG94TmpnS0lDQWdJQzh2SUdGemMyVnlkQ0J3Y205d2IzTmhiRjloY0hBZ2JtOTBJR2x1SUhObGJHWXVjSEp2Y0c5ellXeHpYM1p2ZEdWZlltOTRMQ0JsY25JdVZrOVVSVjlCVEZKRlFVUlpYMUJWUWt4SlUwaEZSQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGN3TnpZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pYQnlaWE5sYm5SaGRHbDJaU0IyYjNSbElIZGhjeUJoYkhKbFlXUjVJSEIxWW14cGMyaGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRTNNQW9nSUNBZ0x5OGdZWE56WlhKMElIWnZkR1V1WVhCd2NtOTJZV3d1WVhOZmRXbHVkRFkwS0NrZ1BEMGdZMjl1YzNRdVVGQk5MQ0JsY25JdVZrOVVSVjlPVDFSZlVGQk5DaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QldiM1JsSUc1dmRDQnBiaUJRVUUwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUdGemMyVnlkQ0IyYjNSbExuSmxhbVZqZEdsdmJpNWhjMTkxYVc1ME5qUW9LU0E4UFNCamIyNXpkQzVRVUUwc0lHVnljaTVXVDFSRlgwNVBWRjlRVUUwS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01EQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZadmRHVWdibTkwSUdsdUlGQlFUUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRTNNd29nSUNBZ0x5OGdjMlZzWmk1d2NtOXdiM05oYkhOZmRtOTBaVjlpYjNoYmNISnZjRzl6WVd4ZllYQndYU0E5SUhadmRHVXVZMjl3ZVNncENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG94TnpVS0lDQWdJQzh2SUcxaWNsOWhablJsY2lBOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNdWJXbHVYMkpoYkdGdVkyVUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFMXBia0poYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRTNOZ29nSUNBZ0x5OGdiV0p5WDJabFpTQTlJRzFpY2w5aFpuUmxjaUF0SUcxaWNsOWlaV1p2Y21VS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3hPREFLSUNBZ0lDOHZJSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pHbG5JREVLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3hOemd0TVRneENpQWdJQ0F2THlBaklFTm9aV05ySUhCaGVXMWxiblFLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQXZMeUFwTENCbGNuSXVWMUpQVGtkZlVrVkRSVWxXUlZJS0lDQWdJR0Z6YzJWeWRDQXZMeUJYY205dVp5QlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pFNE1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVcxdmRXNTBJRDA5SUcxaWNsOW1aV1VzSUdWeWNpNVhVazlPUjE5UVFWbE5SVTVVWDBGTlQxVk9WQW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZkeWIyNW5JSEJoZVcxbGJuUWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEJ5WlhObGJuUmhkR2wyWlM1amIyNTBjbUZqZEM1U1pYQnlaWE5sYm5SaGRHbDJaUzVrWld4bGRHVmZkbTkwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlY5MmIzUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3lNRElLSUNBZ0lDOHZJRzFpY2w5aVpXWnZjbVVnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3lNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzSmxjSEpsYzJWdWRHRjBhWFpsS0Nrc0lHVnljaTVWVGtGVlZFaFBVa2xhUlVRS0lDQWdJR05oYkd4emRXSWdhWE5mY21Wd2NtVnpaVzUwWVhScGRtVUtJQ0FnSUdGemMyVnlkQ0F2THlCVmJtRjFkR2h2Y21sNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU1EY0tJQ0FnSUM4dklIQnliM0J2YzJGc1gybGtMbUZ6WDNWcGJuUTJOQ2dwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbTl3YjNOaGJDOTFkR2xzY3k1d2VUb3hNd29nSUNBZ0x5OGdjSEp2Y0Y5alptY3VSMU5mUzBWWlgxTlVRVlJWVXl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURjek56UTJNVGMwTnpVM013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWIzQnZjMkZzTDNWMGFXeHpMbkI1T2pFeExURTBDaUFnSUNBdkx5QnpkR0YwZFhNc0lHVjRhWE4wY3lBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSZlpYaGZkV2x1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNCdmMyRnNYMmxrTEFvZ0lDQWdMeThnSUNBZ0lIQnliM0JmWTJabkxrZFRYMHRGV1Y5VFZFRlVWVk1zQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeWIzQnZjMkZzTDNWMGFXeHpMbkI1T2pFMkNpQWdJQ0F2THlCeVpYUjFjbTRnWlhocGMzUnpJR0Z1WkNCemRHRjBkWE1nUFQwZ1pXNXRMbE5VUVZSVlUxOVdUMVJKVGtjS0lDQWdJR0o2SUdSbGJHVjBaVjkyYjNSbFgySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMUlDOHZJREkxQ2lBZ0lDQTlQUW9nSUNBZ1lub2daR1ZzWlhSbFgzWnZkR1ZmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvS1pHVnNaWFJsWDNadmRHVmZZbTl2YkY5dFpYSm5aVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPakl3TmkweU1EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdkWFJwYkhOZmNISnZjQzVwYzE5d2NtOXdiM05oYkY5MmIzUnBibWNvQ2lBZ0lDQXZMeUFnSUNBZ2NISnZjRzl6WVd4ZmFXUXVZWE5mZFdsdWREWTBLQ2tLSUNBZ0lDOHZJQ2tzSUdWeWNpNVFVazlRVDFOQlRGOVdUMVJKVGtjS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFjbTl3YjNOaGJDQnBjeUJwYmlCMmIzUnBibWNnYzNSaFoyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU1URUtJQ0FnSUM4dklHUmxiQ0J6Wld4bUxuQnliM0J2YzJGc2MxOTJiM1JsWDJKdmVGdHdjbTl3YjNOaGJGOWhjSEJkQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURjd056WUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZNakV6Q2lBZ0lDQXZMeUJ0WW5KZllXWjBaWElnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObENpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSTmFXNUNZV3hoYm1ObENpQWdJQ0JoYzNObGNuUWdMeThnWVdOamIzVnVkQ0JtZFc1a1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU1UVXRNakUyQ2lBZ0lDQXZMeUFqSUZObGJtUWdabkpsWldRZ1RVSlNJSFJ2SUdOeVpXRjBiM0lLSUNBZ0lDOHZJRzFpY2w5bWNtVmxaQ0E5SUcxaWNsOWlaV1p2Y21VZ0xTQnRZbkpmWVdaMFpYSUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2TWpFM0xUSXlNQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBVZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFcxaWNsOW1jbVZsWkN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3lNVGdLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQVWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2TWpFM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG95TVRjdE1qSXdDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVIyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5YldKeVgyWnlaV1ZrTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXlaWEJ5WlhObGJuUmhkR2wyWlM5amIyNTBjbUZqZEM1d2VUb3hPRFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BrWld4bGRHVmZkbTkwWlY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCa1pXeGxkR1ZmZG05MFpWOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVndjbVZ6Wlc1MFlYUnBkbVV1WTI5dWRISmhZM1F1VW1Wd2NtVnpaVzUwWVhScGRtVXVaR1ZzWlhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pNd05Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pJek5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVhWE5mWTNKbFlYUnZjaWdwTENCbGNuSXVUazlVWDBOU1JVRlVUMUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRaVzVrWlhJZ2FYTWdibTkwSUdGd2NDQmpjbVZoZEc5eUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2TWpNNUNpQWdJQ0F2THlCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TG0xcGJsOWlZV3hoYm1ObElEMDlJRWRzYjJKaGJDNXRhVzVmWW1Gc1lXNWpaUW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBUV2x1UW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQm5iRzlpWVd3Z1RXbHVRbUZzWVc1alpRb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG95TXpndE1qUXdDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXViV2x1WDJKaGJHRnVZMlVnUFQwZ1IyeHZZbUZzTG0xcGJsOWlZV3hoYm1ObENpQWdJQ0F2THlBcExDQmxjbkl1VlU1RVJVeEZWRVZFWDBKUFdFVlRDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJR0ZzYkNCaWIzaGxjeUJrWld4bGRHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVndjbVZ6Wlc1MFlYUnBkbVV2WTI5dWRISmhZM1F1Y0hrNk1qUXlMVEkwTmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JqYkc5elpWOXlaVzFoYVc1a1pYSmZkRzg5UjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG95TkRNS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU5EVUtJQ0FnSUM4dklHTnNiM05sWDNKbGJXRnBibVJsY2w5MGJ6MUhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zYjNObFVtVnRZV2x1WkdWeVZHOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU5EUUtJQ0FnSUM4dklHRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG95TkRJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPakkwTWkweU5EWUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyeHZjMlZmY21WdFlXbHVaR1Z5WDNSdlBVZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxjSEpsYzJWdWRHRjBhWFpsTDJOdmJuUnlZV04wTG5CNU9qSXlOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05S0NKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlJc0tTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21Wd2NtVnpaVzUwWVhScGRtVXVZMjl1ZEhKaFkzUXVVbVZ3Y21WelpXNTBZWFJwZG1VdVoyVjBYM1p2ZEdWZlltOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzWnZkR1ZmWW05NE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pJMU1DMHlOVE1LSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRJRWRsZEhSbGNpQnRaWFJvYjJSeklDMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21Wd2NtVnpaVzUwWVhScGRtVXVZMjl1ZEhKaFkzUXVVbVZ3Y21WelpXNTBZWFJwZG1VdVoyVjBYM1p2ZEdWZlltOTRDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21Wd2NtVnpaVzUwWVhScGRtVXVZMjl1ZEhKaFkzUXVVbVZ3Y21WelpXNTBZWFJwZG1VdVoyVjBYM1p2ZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmZG05MFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU56Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPakk1TXdvZ0lDQWdMeThnVzNaaGJDd2daWGhwYzNSelhTQTlJSE5sYkdZdVoyVjBYM1p2ZEdWZlltOTRLSEJ5YjNCdmMyRnNYMmxrS1FvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVndjbVZ6Wlc1MFlYUnBkbVV1WTI5dWRISmhZM1F1VW1Wd2NtVnpaVzUwWVhScGRtVXVaMlYwWDNadmRHVmZZbTk0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZNamsxQ2lBZ0lDQXZMeUJwYzE5MllXeHBaQ0E5SUdWNGFYTjBjeUJoYm1RZ2MyVnNaaTV3WVhWelpXUXVkbUZzZFdVZ1BUMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVpQm5aWFJmZG05MFpWOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROekEyTVRjMU56TTJOVFkwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ1ltNTZJR2RsZEY5MmIzUmxYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ21kbGRGOTJiM1JsWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU56Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFgzWnZkR1ZmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWjJWMFgzWnZkR1ZmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbkpsY0hKbGMyVnVkR0YwYVhabExtTnZiblJ5WVdOMExsSmxjSEpsYzJWdWRHRjBhWFpsTG1kbGRGOTJiM1JsWDJKdmVDaHdjbTl3YjNOaGJGOXBaRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpMQ0IxYVc1ME5qUTZDbk50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEJ5WlhObGJuUmhkR2wyWlM1amIyNTBjbUZqZEM1U1pYQnlaWE5sYm5SaGRHbDJaUzVuWlhSZmRtOTBaVjlpYjNnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21Wd2NtVnpaVzUwWVhScGRtVXZZMjl1ZEhKaFkzUXVjSGs2TWpVd0xUSTFOd29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMGdSMlYwZEdWeUlHMWxkR2h2WkhNZ0xTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDNadmRHVmZZbTk0S0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ2NISnZjRzl6WVd4ZmFXUTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnS1NBdFBpQjBkWEJzWlZ0MGVYQXVWbTkwWlN3Z1ltOXZiRjA2Q2lBZ0lDQndjbTkwYnlBeElESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU5qZ0tJQ0FnSUM4dklIQnliM0J2YzJGc1gyRndjQ0E5SUVGd2NHeHBZMkYwYVc5dUtIQnliM0J2YzJGc1gybGtMbUZ6WDNWcGJuUTJOQ2dwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZ3Y21WelpXNTBZWFJwZG1VdlkyOXVkSEpoWTNRdWNIazZNamN3Q2lBZ0lDQXZMeUJsZUdsemRITWdQU0J3Y205d2IzTmhiRjloY0hBZ2FXNGdjMlZzWmk1d2NtOXdiM05oYkhOZmRtOTBaVjlpYjNnS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnM01EYzJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pJM01Rb2dJQ0FnTHk4Z2FXWWdaWGhwYzNSek9nb2dJQ0FnWW5vZ2MyMWhjblJmWTI5dWRISmhZM1J6TG5KbGNISmxjMlZ1ZEdGMGFYWmxMbU52Ym5SeVlXTjBMbEpsY0hKbGMyVnVkR0YwYVhabExtZGxkRjkyYjNSbFgySnZlRjlsYkhObFgySnZaSGxBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psY0hKbGMyVnVkR0YwYVhabEwyTnZiblJ5WVdOMExuQjVPakkzTWdvZ0lDQWdMeThnZG1Gc0lEMGdjMlZzWmk1d2NtOXdiM05oYkhOZmRtOTBaVjlpYjNoYmNISnZjRzl6WVd4ZllYQndYUzVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbTl3YjNOaGJITmZkbTkwWlY5aWIzZ2daVzUwY25rZ1pYaHBjM1J6Q2dwemJXRnlkRjlqYjI1MGNtRmpkSE11Y21Wd2NtVnpaVzUwWVhScGRtVXVZMjl1ZEhKaFkzUXVVbVZ3Y21WelpXNTBZWFJwZG1VdVoyVjBYM1p2ZEdWZlltOTRYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpYQnlaWE5sYm5SaGRHbDJaUzlqYjI1MGNtRmpkQzV3ZVRveU56WUtJQ0FnSUM4dklISmxkSFZ5YmlCMllXd3VZMjl3ZVNncExDQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjbVYwYzNWaUNncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNtVndjbVZ6Wlc1MFlYUnBkbVV1WTI5dWRISmhZM1F1VW1Wd2NtVnpaVzUwWVhScGRtVXVaMlYwWDNadmRHVmZZbTk0WDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbGNISmxjMlZ1ZEdGMGFYWmxMMk52Ym5SeVlXTjBMbkI1T2pJM05Bb2dJQ0FnTHk4Z2RtRnNJRDBnZEhsd0xsWnZkR1VvWVhCd2NtOTJZV3c5WVhKak5DNVZTVzUwTmpRb01Da3NJSEpsYW1WamRHbHZiajFoY21NMExsVkpiblEyTkNnd0tTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXlaWEJ5WlhObGJuUmhkR2wyWlM1amIyNTBjbUZqZEM1U1pYQnlaWE5sYm5SaGRHbDJaUzVuWlhSZmRtOTBaVjlpYjNoZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuSmxjSEpsYzJWdWRHRjBhWFpsTG1OdmJuUnlZV04wTGxKbGNISmxjMlZ1ZEdGMGFYWmxMbWx6WDNKbGNISmxjMlZ1ZEdGMGFYWmxLQ2tnTFQ0Z2RXbHVkRFkwT2dwcGMxOXlaWEJ5WlhObGJuUmhkR2wyWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WlhCeVpYTmxiblJoZEdsMlpTOWpiMjUwY21GamRDNXdlVG96TURnS0lDQWdJQzh2SUhKbGRIVnliaUJVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1Y21Wd2NtVnpaVzUwWVhScGRtVmZZV1JrY21WemN5NTJZV3gxWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzNNalkxTnpBM01qWTFOek0yTlRabE56UTJNVGMwTmprM05qWTFOV1kyTVRZME5qUTNNalkxTnpNM013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY0hKbGMyVnVkR0YwYVhabFgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQUFFSUlNQ0VQU1lGQm5CaGRYTmxaQlp5WlhCeVpYTmxiblJoZEdsMlpWOWhaR1J5WlhOekRISmxaMmx6ZEhKNVgyRndjQUp3ZGdRVkgzeDFNUmhBQUNBeE5TVVNSREUwSlJKRU1UZUJDUkpFTVRhQkJ4SkVLVElEWnlvaVp5Z2laNElDQktEb0dISUVKRGVOUERZYUFJNENBRlVBU1RFWkZFUXhHRUVBTW9JR0JBRjQrVXNFSkMxWXF3UThOaWFVQkxzY2ZxVUVZK2JNMWdSdXFCNnhOaG9BamdZQVJnQlBBRmdBMmdGT0FXZ0FnQVRNYVU2cU5ob0FqZ0VBR1FBeEdZRUZFakVZRUVSQ0FSQXhHWUVFRWpFWUVFUkNBQmMyR2dGSkZTVVNSRElOUkNveURXY3BUR2NvSW1jalF6RUFNZ2tTUkNORGlBRitSQ2dqWnlORGlBRjFSQ2dpWnlORE1SWWpDVWs0RUNNU1JEWWFBVWtWSkJKRU5ob0NTUldCRUJKRU1ncHpBVVNJQVV4RVR3SVhTWElIUkNJcVpVU0FFWGhuYjNaZmNtVm5hWE4wY25sZllYQndaVWh5Q0VRU1JDSW9aVVFVUkJZclRGQkp2VVVCRkVSTEFpSmJJUVFPUkVzQ0pGc2hCQTVFVHdLL01ncHpBVVJNQ1VzQk9BY3lDaEpFVERnSUVrUWpRellhQVVrVkpCSkVNZ3B6QVV4T0FrU0lBTnBFRjBtQUJuTjBZWFIxYzJWQkFDdEpnUmtTUVFBa0l4UkVTd0VXSzB4UXZFZ3lDbk1CUkVzRFRBbXhNZ215QjdJSUk3SVFJcklCc3lORElrTC8yVEVBTWdrU1JESUtjd0ZFTWdFU1JMRXlDVW15Q1NLeUNMSUhJN0lRSXJJQnN5TkROaG9CU1JVa0VrU0lBRHVBQVFBaVR3SlVVQ2NFVEZDd0kwTTJHZ0ZKRlNRU1JJZ0FJVUVBR2lJb1pVUkFBQk1qZ0FFQUlrOENWRXNCVEZBbkJFeFFzQ05ESWtMLzZvb0JBb3YvRnhZclRGQkp2VWxQQWtoQkFBdUxBTDVFaXdGUEEwOERpWUFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUwvNURFQUlpbGxSQktKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
