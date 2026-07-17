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

namespace Arc56.Generated.EggsLeggs.algobounty.BountyEscrow_b97dfcf7
{


    public class BountyEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BountyEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BountyRecord : AVMObjectType
            {
                public ulong TotalFunded { get; set; }

                public ulong TotalClaimed { get; set; }

                public bool IsClosed { get; set; }

                public bool IsClaimed { get; set; }

                public Algorand.Address AuthorizedClaimer { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalFunded = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalFunded.From(TotalFunded);
                    ret.AddRange(vTotalFunded.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalClaimed.From(TotalClaimed);
                    ret.AddRange(vTotalClaimed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsClosed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsClosed.From(IsClosed);
                    ret.AddRange(vIsClosed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsClaimed.From(IsClaimed);
                    ret.AddRange(vIsClaimed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorizedClaimer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAuthorizedClaimer.From(AuthorizedClaimer);
                    ret.AddRange(vAuthorizedClaimer.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BountyRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BountyRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalFunded = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalFunded.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalFunded = vTotalFunded.ToValue();
                    if (valueTotalFunded is ulong vTotalFundedValue) { ret.TotalFunded = vTotalFundedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalClaimed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalClaimed = vTotalClaimed.ToValue();
                    if (valueTotalClaimed is ulong vTotalClaimedValue) { ret.TotalClaimed = vTotalClaimedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsClosed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsClosed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsClosed = vIsClosed.ToValue();
                    if (valueIsClosed is bool vIsClosedValue) { ret.IsClosed = vIsClosedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsClaimed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsClaimed = vIsClaimed.ToValue();
                    if (valueIsClaimed is bool vIsClaimedValue) { ret.IsClaimed = vIsClaimedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthorizedClaimer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAuthorizedClaimer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuthorizedClaimer = vAuthorizedClaimer.ToValue();
                    if (valueAuthorizedClaimer is Algorand.Address vAuthorizedClaimerValue) { ret.AuthorizedClaimer = vAuthorizedClaimerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BountyRecord);
                }
                public bool Equals(BountyRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BountyRecord left, BountyRecord right)
                {
                    return EqualityComparer<BountyRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(BountyRecord left, BountyRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAdmin"> </param>
        public async Task UpdateAdmin(Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { newAdmin });
            byte newAdminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 130, 171, 30, 196 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newAdminRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAdmin_Transactions(Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { newAdmin });
            byte newAdminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 130, 171, 30, 196 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAdminRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        /// <param name="paymentTxnIndex"> </param>
        public async Task FundBounty(string bountyKey, ulong paymentTxnIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 56, 130, 63 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var paymentTxnIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentTxnIndexAbi.From(paymentTxnIndex);

            var result = await base.CallApp(new List<object> { abiHandle, bountyKeyAbi, paymentTxnIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundBounty_Transactions(string bountyKey, ulong paymentTxnIndex, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 56, 130, 63 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var paymentTxnIndexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentTxnIndexAbi.From(paymentTxnIndex);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi, paymentTxnIndexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        /// <param name="claimer"> </param>
        public async Task MarkIssueClosed(Address claimer, string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { claimer });
            byte claimerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 155, 181, 183, 231 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var claimerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); claimerAbi.From(claimer);

            var result = await base.CallApp(new List<object> { abiHandle, bountyKeyAbi, claimerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkIssueClosed_Transactions(Address claimer, string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { claimer });
            byte claimerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 155, 181, 183, 231 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var claimerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); claimerAbi.From(claimer);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi, claimerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        /// <param name="claimer"> </param>
        public async Task AssignClaimer(Address claimer, string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { claimer });
            byte claimerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 78, 255, 10, 186 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var claimerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); claimerAbi.From(claimer);

            var result = await base.CallApp(new List<object> { abiHandle, bountyKeyAbi, claimerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AssignClaimer_Transactions(Address claimer, string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { claimer });
            byte claimerRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 78, 255, 10, 186 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var claimerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); claimerAbi.From(claimer);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi, claimerRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        /// <param name="recipient"> </param>
        public async Task ClaimBounty(Address recipient, string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 136, 135, 106, 79 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, bountyKeyAbi, recipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimBounty_Transactions(Address recipient, string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { recipient });
            byte recipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 136, 135, 106, 79 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi, recipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        public async Task<ulong> GetTotalFunded(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 188, 49, 194 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            var result = await base.SimApp(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalFunded_Transactions(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 188, 49, 194 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        public async Task<ulong> GetTotalClaimed(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 182, 221, 142 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            var result = await base.SimApp(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalClaimed_Transactions(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 182, 221, 142 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        public async Task<bool> IsBountyClosed(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 49, 202, 65 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            var result = await base.SimApp(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBountyClosed_Transactions(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 49, 202, 65 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        public async Task<bool> IsBountyClaimed(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 186, 197, 33 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            var result = await base.SimApp(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBountyClaimed_Transactions(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 186, 197, 33 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bountyKey"> </param>
        public async Task<byte[]> GetAuthorizedClaimer(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 177, 124, 110 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            var result = await base.SimApp(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetAuthorizedClaimer_Transactions(string bountyKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 177, 124, 110 };
            var bountyKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyKeyAbi.From(bountyKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyKeyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm91bnR5RXNjcm93IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkJvdW50eVJlY29yZCI6W3sibmFtZSI6InRvdGFsRnVuZGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQ2xhaW1lZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc0Nsb3NlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiaXNDbGFpbWVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJhdXRob3JpemVkQ2xhaW1lciIsInR5cGUiOiJhZGRyZXNzIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InVwZGF0ZUFkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kQm91bnR5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvdW50eUtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudFR4bkluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtJc3N1ZUNsb3NlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3VudHlLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjbGFpbWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFzc2lnbkNsYWltZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5S2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xhaW1lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbUJvdW50eSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3VudHlLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxGdW5kZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5S2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb3RhbENsYWltZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5S2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0JvdW50eUNsb3NlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3VudHlLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0JvdW50eUNsYWltZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5S2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QXV0aG9yaXplZENsYWltZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5S2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwMjldLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2NF0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0LDE3NCwyMTEsMjQ4LDI4MSwzMTQsMzUzLDM5Miw0MzEsNDY5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExOV0sImVycm9yTWVzc2FnZSI6ImFkbWluIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQyXSwiZXJyb3JNZXNzYWdlIjoiYW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODMyXSwiZXJyb3JNZXNzYWdlIjoiYm91bnR5IGFscmVhZHkgY2xhaW1lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1Nyw3NDMsODI5XSwiZXJyb3JNZXNzYWdlIjoiYm91bnR5IG5vdCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzBdLCJlcnJvck1lc3NhZ2UiOiJib3VudHkgc3RpbGwgb3BlbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5N10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNywxNzcsMjE0LDI1MSwyODQsMzE3LDM1NiwzOTUsNDM0LDQ3Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzIsODgzLDExMTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjldLCJlcnJvck1lc3NhZ2UiOiJmdW5kaW5nIGluZGV4IGludmFsaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDMsMTgzLDIyMCwyNTcsMjkwLDMyMywzNjIsNDAxLDQ0MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCwxOTAsMjI3LDI2NCwyOTcsMzMwLDM2OSw0MDgsNDQ3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MSwzODAsNDE5LDQ4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU1XSwiZXJyb3JNZXNzYWdlIjoibm90aGluZyB0byBjbGFpbSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1MF0sImVycm9yTWVzc2FnZSI6InBheW1lbnQgbXVzdCB0YXJnZXQgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDRdLCJlcnJvck1lc3NhZ2UiOiJyZWNpcGllbnQgbm90IGF1dGhvcml6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NThdLCJlcnJvck1lc3NhZ2UiOiJzZW5kZXIgbWlzbWF0Y2ggYmV0d2VlbiB0eG5zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnTVRJNUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1EQWdJblJ2ZEdGc1gyeHZZMnRsWkNJZ01IZ3hOVEZtTjJNM05TQWlZam9pSUNKaFpHMXBiaUlLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEIxWW14cFl5QjBiM1JoYkV4dlkydGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkMGIzUmhiRjlzYjJOclpXUW5MQ0JwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmJHOWphMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ2IzVnVkSGxGYzJOeWIzY2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVGNLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0TW1GaU1XVmpOQ0F3ZURZd016ZzRNak5tSURCNE9XSmlOV0kzWlRjZ01IZzBaV1ptTUdGaVlTQXdlRGc0T0RjMllUUm1JREI0WkROaVl6TXhZeklnTUhnM1kySTJaR1E0WlNBd2VHVTVNekZqWVRReElEQjRNMlJpWVdNMU1qRWdNSGhrT0dJeE4yTTJaU0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVUZrYldsdUtHRmpZMjkxYm5RcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWm5WdVpFSnZkVzUwZVNoemRISnBibWNzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltMWhjbXRKYzNOMVpVTnNiM05sWkNoemRISnBibWNzWVdOamIzVnVkQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjM05wWjI1RGJHRnBiV1Z5S0hOMGNtbHVaeXhoWTJOdmRXNTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTnNZV2x0UW05MWJuUjVLSE4wY21sdVp5eGhZMk52ZFc1MEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGUnZkR0ZzUm5WdVpHVmtLSE4wY21sdVp5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRlJ2ZEdGc1EyeGhhVzFsWkNoemRISnBibWNwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pwYzBKdmRXNTBlVU5zYjNObFpDaHpkSEpwYm1jcFltOXZiQ0lzSUcxbGRHaHZaQ0FpYVhOQ2IzVnVkSGxEYkdGcGJXVmtLSE4wY21sdVp5bGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUkJkWFJvYjNKcGVtVmtRMnhoYVcxbGNpaHpkSEpwYm1jcFlubDBaVnRkSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDkxY0dSaGRHVkJaRzFwYmw5eWIzVjBaVUExSUcxaGFXNWZablZ1WkVKdmRXNTBlVjl5YjNWMFpVQTJJRzFoYVc1ZmJXRnlhMGx6YzNWbFEyeHZjMlZrWDNKdmRYUmxRRGNnYldGcGJsOWhjM05wWjI1RGJHRnBiV1Z5WDNKdmRYUmxRRGdnYldGcGJsOWpiR0ZwYlVKdmRXNTBlVjl5YjNWMFpVQTVJRzFoYVc1ZloyVjBWRzkwWVd4R2RXNWtaV1JmY205MWRHVkFNVEFnYldGcGJsOW5aWFJVYjNSaGJFTnNZV2x0WldSZmNtOTFkR1ZBTVRFZ2JXRnBibDlwYzBKdmRXNTBlVU5zYjNObFpGOXliM1YwWlVBeE1pQnRZV2x1WDJselFtOTFiblI1UTJ4aGFXMWxaRjl5YjNWMFpVQXhNeUJ0WVdsdVgyZGxkRUYxZEdodmNtbDZaV1JEYkdGcGJXVnlYM0p2ZFhSbFFERTBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW05MWJuUjVSWE5qY205M0lHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUkJkWFJvYjNKcGVtVmtRMnhoYVcxbGNsOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0wQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUp2ZFc1MGVVVnpZM0p2ZHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEVGMWRHaHZjbWw2WldSRGJHRnBiV1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjMEp2ZFc1MGVVTnNZV2x0WldSZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNiM1Z1ZEhsRmMyTnliM2NnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZMkZzYkhOMVlpQnBjMEp2ZFc1MGVVTnNZV2x0WldRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmx6UW05MWJuUjVRMnh2YzJWa1gzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNalFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbTkxYm5SNVJYTmpjbTkzSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR05oYkd4emRXSWdhWE5DYjNWdWRIbERiRzl6WldRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZSdmRHRnNRMnhoYVcxbFpGOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUp2ZFc1MGVVVnpZM0p2ZHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4T1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEZSdmRHRnNRMnhoYVcxbFpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlViM1JoYkVaMWJtUmxaRjl5YjNWMFpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVKdmRXNTBlVVZ6WTNKdmR5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCallXeHNjM1ZpSUdkbGRGUnZkR0ZzUm5WdVpHVmtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnNZV2x0UW05MWJuUjVYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUp2ZFc1MGVVVnpZM0p2ZHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTJ4aGFXMUNiM1Z1ZEhrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhOemFXZHVRMnhoYVcxbGNsOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNiM1Z1ZEhsRmMyTnliM2NnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTRDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR0Z6YzJsbmJrTnNZV2x0WlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYldGeWEwbHpjM1ZsUTJ4dmMyVmtYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUp2ZFc1MGVVVnpZM0p2ZHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRGdLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYldGeWEwbHpjM1ZsUTJ4dmMyVmtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyWjFibVJDYjNWdWRIbGZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbTkxYm5SNVJYTmpjbTkzSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCbWRXNWtRbTkxYm5SNUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWd1pHRjBaVUZrYldsdVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFSnZkVzUwZVVWelkzSnZkeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FXTmpiM1Z1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCMWNHUmhkR1ZCWkcxcGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbTkxYm5SNVJYTmpjbTkzSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnUUdKaGNtVnRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKdmRXNTBlVVZ6WTNKdmR5NWpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BJQzArSUhadmFXUTZDbU55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY0hWaWJHbGpJR0ZrYldsdUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ2RoWkcxcGJpY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYjNWdWRIbEZjMk55YjNjdWRYQmtZWFJsUVdSdGFXNG9ibVYzUVdSdGFXNDZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDFjR1JoZEdWQlpHMXBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprdE5EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdkWEJrWVhSbFFXUnRhVzRvYm1WM1FXUnRhVzQ2SUVGalkyOTFiblFwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnZEdocGN5NWhjM05sY25SQlpHMXBiaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlZ5ZEVGa2JXbHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMkZrYldsdUp5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QjBhR2x6TG1Ga2JXbHVMblpoYkhWbElEMGdibVYzUVdSdGFXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0p2ZFc1MGVVVnpZM0p2ZHk1bWRXNWtRbTkxYm5SNUtHSnZkVzUwZVV0bGVUb2dZbmwwWlhNc0lIQmhlVzFsYm5SVWVHNUpibVJsZURvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwbWRXNWtRbTkxYm5SNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOUzAwTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCbWRXNWtRbTkxYm5SNUtHSnZkVzUwZVV0bGVUb2djM1J5YVc1bkxDQndZWGx0Wlc1MFZIaHVTVzVrWlhnNklIVnBiblEyTkNrZ2V3b2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hCaGVXMWxiblJVZUc1SmJtUmxlQ0E4SUZSNGJpNW5jbTkxY0VsdVpHVjRMQ0FuWm5WdVpHbHVaeUJwYm1SbGVDQnBiblpoYkdsa0p5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJtZFc1a2FXNW5JR2x1WkdWNElHbHVkbUZzYVdRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXhDaUFnSUNBdkx5QmpiMjV6ZENCd1lYbHRaVzUwVkhodUlEMGdaM1I0Ymk1UVlYbHRaVzUwVkhodUtIQmhlVzFsYm5SVWVHNUpibVJsZUNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXlDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEZSNGJpNWhiVzkxYm5RZ1BpQlZhVzUwTmpRb01Da3NJQ2RoYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFuS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklHRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFFLSUNBZ0lDOHZJSEJoZVcxbGJuUlVlRzR1Y21WalpXbDJaWEl1WW5sMFpYTXVaWEYxWVd4ektFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TG1KNWRHVnpLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRNdE1UUTJDaUFnSUNBdkx5QmhjM05sY25Rb0NpQWdJQ0F2THlBZ0lIQmhlVzFsYm5SVWVHNHVjbVZqWldsMlpYSXVZbmwwWlhNdVpYRjFZV3h6S0Vkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMbUo1ZEdWektTd0tJQ0FnSUM4dklDQWdKM0JoZVcxbGJuUWdiWFZ6ZENCMFlYSm5aWFFnWTI5dWRISmhZM1FuTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVcxbGJuUWdiWFZ6ZENCMFlYSm5aWFFnWTI5dWRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRM0NpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXVaWEYxWVd4ektGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNcExDQW5jMlZ1WkdWeUlHMXBjMjFoZEdOb0lHSmxkSGRsWlc0Z2RIaHVjeWNwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ2dZbVYwZDJWbGJpQjBlRzV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCamIyNXpkQ0J5WldOdmNtUWdQU0IwYUdsekxuSmxZV1JTWldOdmNtUW9ZbTkxYm5SNVMyVjVLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUhKbFlXUlNaV052Y21RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIUnZkR0ZzUm5WdVpHVmtPaUJWYVc1ME5qUW9jbVZqYjNKa0xuUnZkR0ZzUm5WdVpHVmtJQ3NnY0dGNWJXVnVkQzVoYlc5MWJuUXBMQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1nb2dJQ0FnTHk4Z2NIVmliR2xqSUhSdmRHRnNURzlqYTJWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1J2ZEdGc1gyeHZZMnRsWkNjc0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZiRzlqYTJWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeE1iMk5yWldRdWRtRnNkV1VnUFNCVmFXNTBOalFvZEdocGN5NTBiM1JoYkV4dlkydGxaQzUyWVd4MVpTQXJJSEJoZVcxbGJuUXVZVzF2ZFc1MEtRb2dJQ0FnWkdsbklEWUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRXh2WTJ0bFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QwYjNSaGJGOXNiMk5yWldRbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmYkc5amEyVmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkV4dlkydGxaQzUyWVd4MVpTQTlJRlZwYm5RMk5DaDBhR2x6TG5SdmRHRnNURzlqYTJWa0xuWmhiSFZsSUNzZ2NHRjViV1Z1ZEM1aGJXOTFiblFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2NISnBkbUYwWlNCeVpXRmtiMjVzZVNCaWIzVnVkSGxRYjNSeklEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z1FtOTFiblI1VW1WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0oySTZKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWWpvaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYQmtZWFJsWkZKbFkyOXlaRG9nUW05MWJuUjVVbVZqYjNKa0lEMGdld29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhSb2FYTXVZbTkxYm5SNVVHOTBjeWhpYjNWdWRIbExaWGtwTG5aaGJIVmxJRDBnZFhCa1lYUmxaRkpsWTI5eVpBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1qa0tJQ0FnSUhOM1lYQUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUd4dlp5Z25ZbTkxYm5SNVgyWjFibVJsWkNjc0lFSjVkR1Z6S0dKdmRXNTBlVXRsZVNrc0lIQmhlVzFsYm5RdVlXMXZkVzUwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ppYjNWdWRIbGZablZ1WkdWa0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYjNWdWRIbEZjMk55YjNjdWJXRnlhMGx6YzNWbFEyeHZjMlZrS0dKdmRXNTBlVXRsZVRvZ1lubDBaWE1zSUdOc1lXbHRaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3B0WVhKclNYTnpkV1ZEYkc5elpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalU1TFRZd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHMWhjbXRKYzNOMVpVTnNiM05sWkNoaWIzVnVkSGxMWlhrNklITjBjbWx1Wnl3Z1kyeGhhVzFsY2pvZ1FXTmpiM1Z1ZENrZ2V3b2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWeWRFRmtiV2x1S0NrS0lDQWdJR05oYkd4emRXSWdZWE56WlhKMFFXUnRhVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNENpQWdJQ0F2THlCamIyNXpkQ0J5WldOdmNtUWdQU0IwYUdsekxuSmxZV1JTWldOdmNtUW9ZbTkxYm5SNVMyVjVLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUhKbFlXUlNaV052Y21RS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxT1FvZ0lDQWdMeThnWVhOelpYSjBLSEpsWTI5eVpDNTBiM1JoYkVaMWJtUmxaQ0ErSUZWcGJuUTJOQ2d3S1N3Z0oySnZkVzUwZVNCdWIzUWdablZ1WkdWa0p5a0tJQ0FnSUdGemMyVnlkQ0F2THlCaWIzVnVkSGtnYm05MElHWjFibVJsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklISmxkSFZ5YmlCaFkyTnZkVzUwTG1KNWRHVnpMbVZ4ZFdGc2N5aDBhR2x6TG5wbGNtOUJZMk52ZFc1MEtDa3VZbmwwWlhNcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazFDaUFnSUNBdkx5QnlaWFIxY200Z1FXTmpiM1Z1ZENncENpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCeVpYUjFjbTRnWVdOamIzVnVkQzVpZVhSbGN5NWxjWFZoYkhNb2RHaHBjeTU2WlhKdlFXTmpiM1Z1ZENncExtSjVkR1Z6S1FvZ0lDQWdQVDBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdGMWRHaHZjbWw2WldSRGJHRnBiV1Z5T2lCMGFHbHpMbWx6V21WeWIwRmpZMjkxYm5Rb1kyeGhhVzFsY2lrZ1B5QnlaV052Y21RdVlYVjBhRzl5YVhwbFpFTnNZV2x0WlhJZ09pQmpiR0ZwYldWeUxBb2dJQ0FnWW5vZ2JXRnlhMGx6YzNWbFEyeHZjMlZrWDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtDbTFoY210SmMzTjFaVU5zYjNObFpGOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QndjbWwyWVhSbElISmxZV1J2Ym14NUlHSnZkVzUwZVZCdmRITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkNiM1Z1ZEhsU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5Zam9uSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaU9pSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJqYjI1emRDQjFjR1JoZEdWa1VtVmpiM0prT2lCQ2IzVnVkSGxTWldOdmNtUWdQU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJSFJvYVhNdVltOTFiblI1VUc5MGN5aGliM1Z1ZEhsTFpYa3BMblpoYkhWbElEMGdkWEJrWVhSbFpGSmxZMjl5WkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJqYjI1emRDQjFjR1JoZEdWa1VtVmpiM0prT2lCQ2IzVnVkSGxTWldOdmNtUWdQU0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNWdWRIbFFiM1J6S0dKdmRXNTBlVXRsZVNrdWRtRnNkV1VnUFNCMWNHUmhkR1ZrVW1WamIzSmtDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHbHVkR05mTXlBdkx5QXhNamtLSUNBZ0lITjNZWEFLSUNBZ0lITmxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHeHZaeWduWW05MWJuUjVYMk5zYjNObFpDY3NJRUo1ZEdWektHSnZkVzUwZVV0bGVTa3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltSnZkVzUwZVY5amJHOXpaV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnlaWFJ6ZFdJS0NtMWhjbXRKYzNOMVpVTnNiM05sWkY5MFpYSnVZWEo1WDJaaGJITmxRREk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSWdiV0Z5YTBsemMzVmxRMnh2YzJWa1gzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKdmRXNTBlVVZ6WTNKdmR5NWhjM05wWjI1RGJHRnBiV1Z5S0dKdmRXNTBlVXRsZVRvZ1lubDBaWE1zSUdOc1lXbHRaWEk2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BoYzNOcFoyNURiR0ZwYldWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNeTAzTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCaGMzTnBaMjVEYkdGcGJXVnlLR0p2ZFc1MGVVdGxlVG9nYzNSeWFXNW5MQ0JqYkdGcGJXVnlPaUJCWTJOdmRXNTBLU0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSFJvYVhNdVlYTnpaWEowUVdSdGFXNG9LUW9nSUNBZ1kyRnNiSE4xWWlCaGMzTmxjblJCWkcxcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVGdLSUNBZ0lDOHZJR052Ym5OMElISmxZMjl5WkNBOUlIUm9hWE11Y21WaFpGSmxZMjl5WkNoaWIzVnVkSGxMWlhrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdjbVZoWkZKbFkyOXlaQW9nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPUW9nSUNBZ0x5OGdZWE56WlhKMEtISmxZMjl5WkM1MGIzUmhiRVoxYm1SbFpDQStJRlZwYm5RMk5DZ3dLU3dnSjJKdmRXNTBlU0J1YjNRZ1puVnVaR1ZrSnlrS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJR0p2ZFc1MGVTQnViM1FnWm5WdVpHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJSEpsWVdSdmJteDVJR0p2ZFc1MGVWQnZkSE1nUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JDYjNWdWRIbFNaV052Y21RK0tIc2dhMlY1VUhKbFptbDRPaUFuWWpvbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmlPaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCamIyNXpkQ0IxY0dSaGRHVmtVbVZqYjNKa09pQkNiM1Z1ZEhsU1pXTnZjbVFnUFNCN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdkR2hwY3k1aWIzVnVkSGxRYjNSektHSnZkVzUwZVV0bGVTa3VkbUZzZFdVZ1BTQjFjR1JoZEdWa1VtVmpiM0prQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdhVzUwWTE4eklDOHZJREV5T1FvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnYkc5bktDZGpiR0ZwYldWeVgyRnpjMmxuYm1Wa0p5d2dRbmwwWlhNb1ltOTFiblI1UzJWNUtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVkyeGhhVzFsY2w5aGMzTnBaMjVsWkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZkVzUwZVVWelkzSnZkeTVqYkdGcGJVSnZkVzUwZVNoaWIzVnVkSGxMWlhrNklHSjVkR1Z6TENCeVpXTnBjR2xsYm5RNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwamJHRnBiVUp2ZFc1MGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFl0T0RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1kyeGhhVzFDYjNWdWRIa29ZbTkxYm5SNVMyVjVPaUJ6ZEhKcGJtY3NJSEpsWTJsd2FXVnVkRG9nUVdOamIzVnVkQ2tnZXdvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxT0FvZ0lDQWdMeThnWTI5dWMzUWdjbVZqYjNKa0lEMGdkR2hwY3k1eVpXRmtVbVZqYjNKa0tHSnZkVzUwZVV0bGVTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJ5WldGa1VtVmpiM0prQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ05Rb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hKbFkyOXlaQzUwYjNSaGJFWjFibVJsWkNBK0lGVnBiblEyTkNnd0tTd2dKMkp2ZFc1MGVTQnViM1FnWm5WdVpHVmtKeWtLSUNBZ0lHRnpjMlZ5ZENBdkx5QmliM1Z1ZEhrZ2JtOTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdZWE56WlhKMEtISmxZMjl5WkM1cGMwTnNiM05sWkN3Z0oySnZkVzUwZVNCemRHbHNiQ0J2Y0dWdUp5a0tJQ0FnSUdGemMyVnlkQ0F2THlCaWIzVnVkSGtnYzNScGJHd2diM0JsYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0NGeVpXTnZjbVF1YVhORGJHRnBiV1ZrTENBblltOTFiblI1SUdGc2NtVmhaSGtnWTJ4aGFXMWxaQ2NwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1ltOTFiblI1SUdGc2NtVmhaSGtnWTJ4aGFXMWxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUhKbGRIVnliaUJCWTJOdmRXNTBLQ2tLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhZMk52ZFc1MExtSjVkR1Z6TG1WeGRXRnNjeWgwYUdsekxucGxjbTlCWTJOdmRXNTBLQ2t1WW5sMFpYTXBDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOalVLSUNBZ0lDOHZJR2xtSUNob1lYTkJjM05wWjI1bFpFTnNZV2x0WlhJcElIc0tJQ0FnSUdKdWVpQmpiR0ZwYlVKdmRXNTBlVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0p2ZFc1MGVVVnpZM0p2ZHk1bGJuTjFjbVZEYkdGcGJVRjFkR2h2Y21sNllYUnBiMjVBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qY0tJQ0FnSUM4dklISmxZMjl5WkM1aGRYUm9iM0pwZW1Wa1EyeGhhVzFsY2k1aWVYUmxjeTVsY1hWaGJITW9jbVZqYVhCcFpXNTBMbUo1ZEdWektTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5pMHhOamtLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdjbVZqYjNKa0xtRjFkR2h2Y21sNlpXUkRiR0ZwYldWeUxtSjVkR1Z6TG1WeGRXRnNjeWh5WldOcGNHbGxiblF1WW5sMFpYTXBMQW9nSUNBZ0x5OGdJQ0FuY21WamFYQnBaVzUwSUc1dmRDQmhkWFJvYjNKcGVtVmtKeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QnlaV05wY0dsbGJuUWdibTkwSUdGMWRHaHZjbWw2WldRS0NtTnNZV2x0UW05MWJuUjVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRbTkxYm5SNVJYTmpjbTkzTG1WdWMzVnlaVU5zWVdsdFFYVjBhRzl5YVhwaGRHbHZia0ExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnY21WdFlXbHVhVzVuSUQwZ1ZXbHVkRFkwS0hKbFkyOXlaQzUwYjNSaGJFWjFibVJsWkNBdElISmxZMjl5WkM1MGIzUmhiRU5zWVdsdFpXUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMUNpQWdJQ0F2THlCaGMzTmxjblFvY21WdFlXbHVhVzVuSUQ0Z1ZXbHVkRFkwS0RBcExDQW5ibTkwYUdsdVp5QjBieUJqYkdGcGJTY3BDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUm9hVzVuSUhSdklHTnNZV2x0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prM0xURXdNUW9nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ2MyVnVaR1Z5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCeVpXMWhhVzVwYm1jc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z2MyVnVaR1Z5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGN0TVRBeENpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0J6Wlc1a1pYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2djbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSEpsYldGcGJtbHVaeXdLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklIUnZkR0ZzUTJ4aGFXMWxaRG9nVldsdWREWTBLSEpsWTI5eVpDNTBiM1JoYkVOc1lXbHRaV1FnS3lCeVpXMWhhVzVwYm1jcExBb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRXh2WTJ0bFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QwYjNSaGJGOXNiMk5yWldRbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYMnh2WTJ0bFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPUW9nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRXh2WTJ0bFpDNTJZV3gxWlNBOUlGVnBiblEyTkNoMGFHbHpMblJ2ZEdGc1RHOWphMlZrTG5aaGJIVmxJQzBnY21WdFlXbHVhVzVuS1FvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhCMVlteHBZeUIwYjNSaGJFeHZZMnRsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZDBiM1JoYkY5c2IyTnJaV1FuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZiRzlqYTJWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hNYjJOclpXUXVkbUZzZFdVZ1BTQlZhVzUwTmpRb2RHaHBjeTUwYjNSaGJFeHZZMnRsWkM1MllXeDFaU0F0SUhKbGJXRnBibWx1WnlrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QndjbWwyWVhSbElISmxZV1J2Ym14NUlHSnZkVzUwZVZCdmRITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkNiM1Z1ZEhsU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5Zam9uSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaU9pSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnWTI5dWMzUWdkWEJrWVhSbFpGSmxZMjl5WkRvZ1FtOTFiblI1VW1WamIzSmtJRDBnZXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXdDaUFnSUNBdkx5QjBhR2x6TG1KdmRXNTBlVkJ2ZEhNb1ltOTFiblI1UzJWNUtTNTJZV3gxWlNBOUlIVndaR0YwWldSU1pXTnZjbVFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYek1nTHk4Z01USTVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYzJWMFltbDBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE1Rb2dJQ0FnTHk4Z2JHOW5LQ2RpYjNWdWRIbGZZMnhoYVcxbFpDY3NJRUo1ZEdWektHSnZkVzUwZVV0bGVTa3NJSEpsYldGcGJtbHVaeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZbTkxYm5SNVgyTnNZV2x0WldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0p2ZFc1MGVVVnpZM0p2ZHk1blpYUlViM1JoYkVaMWJtUmxaQ2hpYjNWdWRIbExaWGs2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q21kbGRGUnZkR0ZzUm5WdVpHVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRdE1URTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lDOHZJR2RsZEZSdmRHRnNSblZ1WkdWa0tHSnZkVzUwZVV0bGVUb2djM1J5YVc1bktUb2dkV2x1ZERZMElIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkpsWVdSU1pXTnZjbVFvWW05MWJuUjVTMlY1S1M1MGIzUmhiRVoxYm1SbFpBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJSEpsWVdSU1pXTnZjbVFLSUNBZ0lIQnZjRzRnTkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTFiblI1UlhOamNtOTNMbWRsZEZSdmRHRnNRMnhoYVcxbFpDaGliM1Z1ZEhsTFpYazZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbWRsZEZSdmRHRnNRMnhoYVcxbFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEU1TFRFeU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNBdkx5Qm5aWFJVYjNSaGJFTnNZV2x0WldRb1ltOTFiblI1UzJWNU9pQnpkSEpwYm1jcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjbVZoWkZKbFkyOXlaQ2hpYjNWdWRIbExaWGtwTG5SdmRHRnNRMnhoYVcxbFpBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJSEpsWVdSU1pXTnZjbVFLSUNBZ0lIQnZjRzRnTXdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM1Z1ZEhsRmMyTnliM2N1YVhOQ2IzVnVkSGxEYkc5elpXUW9ZbTkxYm5SNVMyVjVPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BwYzBKdmRXNTBlVU5zYjNObFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwTFRFeU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNBdkx5QnBjMEp2ZFc1MGVVTnNiM05sWkNoaWIzVnVkSGxMWlhrNklITjBjbWx1WnlrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjbVZoWkZKbFkyOXlaQ2hpYjNWdWRIbExaWGtwTG1selEyeHZjMlZrQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ2NtVmhaRkpsWTI5eVpBb2dJQ0FnY0c5d2JpQXlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndiM0J1SURJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZkVzUwZVVWelkzSnZkeTVwYzBKdmRXNTBlVU5zWVdsdFpXUW9ZbTkxYm5SNVMyVjVPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BwYzBKdmRXNTBlVU5zWVdsdFpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5T1MweE16QUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ0x5OGdhWE5DYjNWdWRIbERiR0ZwYldWa0tHSnZkVzUwZVV0bGVUb2djM1J5YVc1bktUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV5WldGa1VtVmpiM0prS0dKdmRXNTBlVXRsZVNrdWFYTkRiR0ZwYldWa0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdjbVZoWkZKbFkyOXlaQW9nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQndiM0J1SURNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZkVzUwZVVWelkzSnZkeTVuWlhSQmRYUm9iM0pwZW1Wa1EyeGhhVzFsY2loaWIzVnVkSGxMWlhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBRWFYwYUc5eWFYcGxaRU5zWVdsdFpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TkMweE16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ0x5OGdaMlYwUVhWMGFHOXlhWHBsWkVOc1lXbHRaWElvWW05MWJuUjVTMlY1T2lCemRISnBibWNwT2lCaWVYUmxjeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0yQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1eVpXRmtVbVZqYjNKa0tHSnZkVzUwZVV0bGVTa3VZWFYwYUc5eWFYcGxaRU5zWVdsdFpYSXVZbmwwWlhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQnlaV0ZrVW1WamIzSmtDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQndiM0J1SURRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnZkVzUwZVVWelkzSnZkeTV5WldGa1VtVmpiM0prS0dKdmRXNTBlVXRsZVRvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJOQ3dnWW5sMFpYTTZDbkpsWVdSU1pXTnZjbVE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z2NISnBkbUYwWlNCeVpXRmtVbVZqYjNKa0tHSnZkVzUwZVV0bGVUb2djM1J5YVc1bktUb2dRbTkxYm5SNVVtVmpiM0prSUhzS0lDQWdJSEJ5YjNSdklERWdOUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnWkhWd2JpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJSEpsWVdSdmJteDVJR0p2ZFc1MGVWQnZkSE1nUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JDYjNWdWRIbFNaV052Y21RK0tIc2dhMlY1VUhKbFptbDRPaUFuWWpvbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmlPaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCamIyNXpkQ0JpYjNnZ1BTQjBhR2x6TG1KdmRXNTBlVkJ2ZEhNb1ltOTFiblI1UzJWNUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QndjbWwyWVhSbElISmxZV1J2Ym14NUlHSnZkVzUwZVZCdmRITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkNiM1Z1ZEhsU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5Zam9uSUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV6Q2lBZ0lDQXZMeUJqYjI1emRDQmliM2dnUFNCMGFHbHpMbUp2ZFc1MGVWQnZkSE1vWW05MWJuUjVTMlY1S1FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdKdmVDNWxlR2x6ZEhNZ1B5QmliM2d1ZG1Gc2RXVWdPaUIwYUdsekxtVnRjSFI1VW1WamIzSmtLQ2tLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ2NtVmhaRkpsWTI5eVpGOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEZ2dMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREV5T0NBdkx5QXhNamdLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEk1Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdWNGRISmhZM1FnTVRjZ016SWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LQ25KbFlXUlNaV052Y21SZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UUUtJQ0FnSUM4dklISmxkSFZ5YmlCaWIzZ3VaWGhwYzNSeklEOGdZbTk0TG5aaGJIVmxJRG9nZEdocGN5NWxiWEIwZVZKbFkyOXlaQ2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lISmxkSE4xWWdvS2NtVmhaRkpsWTI5eVpGOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNPQW9nSUNBZ0x5OGdkRzkwWVd4R2RXNWtaV1E2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUVGalkyOTFiblFvS1FvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzT1FvZ0lDQWdMeThnZEc5MFlXeERiR0ZwYldWa09pQlZhVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNQW9nSUNBZ0x5OGdhWE5EYkc5elpXUTZJR1poYkhObExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ERUtJQ0FnSUM4dklHbHpRMnhoYVcxbFpEb2dabUZzYzJVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSWdjbVZoWkZKbFkyOXlaRjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM1Z1ZEhsRmMyTnliM2N1WVhOelpYSjBRV1J0YVc0b0tTQXRQaUIyYjJsa09ncGhjM05sY25SQlpHMXBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnM0NpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeTVsY1hWaGJITW9kR2hwY3k1aFpHMXBiaTUyWVd4MVpTNWllWFJsY3lrc0lDZGhaRzFwYmlCeVpYRjFhWEpsWkNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCd2RXSnNhV01nWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjJGa2JXbHVKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzNDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3k1bGNYVmhiSE1vZEdocGN5NWhaRzFwYmk1MllXeDFaUzVpZVhSbGN5a3NJQ2RoWkcxcGJpQnlaWEYxYVhKbFpDY3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGa2JXbHVJSEpsY1hWcGNtVmtDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFFQ2dRRW1CUUVBREhSdmRHRnNYMnh2WTJ0bFpBUVZIM3gxQW1JNkJXRmtiV2x1TVJoQUFBTXBJbWN4RzBFQnRZSUtCSUtySHNRRVlEaUNQd1NidGJmbkJFNy9Dcm9FaUlkcVR3VFR2REhDQkh5MjNZNEU2VEhLUVFROXVzVWhCTml4Zkc0MkdnQ09DZ0ZSQVNzQkJBRGRBTFlBbFFCMEFFOEFLZ0FDSWtNeEdSUkVNUmhFTmhvQlNTSlpKQWhMQVJVU1JGY0NBSWdEUlVrVkZsY0dBa3hRS2t4UXNDTkRNUmtVUkRFWVJEWWFBVWtpV1NRSVN3RVZFa1JYQWdDSUF3OG9JazhDVkNwTVVMQWpRekVaRkVReEdFUTJHZ0ZKSWxra0NFc0JGUkpFVndJQWlBTGJLQ0pQQWxRcVRGQ3dJME14R1JSRU1SaEVOaG9CU1NKWkpBaExBUlVTUkZjQ0FJZ0NxUllxVEZDd0kwTXhHUlJFTVJoRU5ob0JTU0paSkFoTEFSVVNSRmNDQUlnQ2ZSWXFURkN3STBNeEdSUkVNUmhFTmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtrVkl4SkVGOEFjaUFISUkwTXhHUlJFTVJoRU5ob0JTU0paSkFoTEFSVVNSRmNDQURZYUFra1ZJeEpFRjhBY2lBRlNJME14R1JSRU1SaEVOaG9CU1NKWkpBaExBUlVTUkZjQ0FEWWFBa2tWSXhKRUY4QWNpQURWSTBNeEdSUkVNUmhFTmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtrVmdRZ1NSQmVJQURralF6RVpGRVF4R0VRMkdnRkpGU01TUkJmQUhJZ0FGaU5ETVJsQS9wTXhHQlJFaUFBQ0kwTW5CREVBWjRtS0FRQ0lBbFFuQkl2L1o0bUtBZ0NML3pFV0RFU0wvemdRSXhKRWkvODRDRWxFaS84NEJ6SUtFa1NML3pnQU1RQVNSSXYraUFHN1R3UkxCUWdpS1dWRVN3WUlLVXhuSzR2K1VFd1dUd1VXS0NKUEIxUW9JazhIVkU4RFR3TlFUd0pRVENKVEpVeFVUd0pRdjRBTlltOTFiblI1WDJaMWJtUmxaSXYrVUV3V1VMQ0ppZ0lBaUFIU2kvNklBV1ZPQkU0RFNFeEpSSXYvTWdNU1FRQTJpd0FyaS81UWl3TVdpd0lXS0NLTEFWUk9BbENBQVlCUVRDSlRKVXhVVHdKUXY0QU5ZbTkxYm5SNVgyTnNiM05sWkl2K1VMQ0ppLzlDLzhlS0FnQ0lBWHlML29nQkQwaE9BMDRDVEVsRUs0ditVRXdXVHdJV0tDSlBCVlFvSWs4R1ZFOERUd05RVHdKUVRDSlRKVXhVaS85UXY0QVFZMnhoYVcxbGNsOWhjM05wWjI1bFpJditVTENKaWdJQWkvNklBTU5KVGdWT0JVNERTVTREVGdWT0JFbE9CRVJFRkVReUF4SkFBQWFMQUl2L0VrU0xBMG1MQWtsT0FnbEpSTEV5Q2tzQnNnaUwvN0lIc2dBanNoQWlzZ0d6VEVzQkNDSXBaVVJMQWdrcFRHY3JpLzVRVHdNV1R3SVdLQ0tMQVZST0FsQk1VQ1VqVklzQVVMK0FEbUp2ZFc1MGVWOWpiR0ZwYldWa2kvNVFUQlpRc0ltS0FRR0wvNGdBT2tZRWlZb0JBWXYvaUFBdlJnTkZBWW1LQVFHTC80Z0FJa1lDVGdKR0FvbUtBUUdMLzRnQUUwaE9BMFlEaVlvQkFZdi9pQUFGVGdSR0JJbUtBUVVpZ0FCSEFpdUwvMUJKdlVVQlFRQkVpd1MrUkVraVcwc0JnUWhiU3dLQmdBRlRLQ0pQQWxRaVUwc0RKVk1vSWs4Q1ZDSlRUd1JYRVNDTUFJd0JqQUtNQTRzRGl3S0xBWXNBVHdsUENVOEpUd2xQQ1lraU1nTWlqQU1pakFJaWpBR01BRUwvM0RFQUlpY0VaVVFTUklrPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjExLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
