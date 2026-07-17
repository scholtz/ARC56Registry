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

namespace Arc56.Generated.VihaShomikha.Kizuna.DisputeArbitration_3524708c
{


    //
    // Handles disputes between users and solvers with proof submission and resolution.
    //
    public class DisputeArbitrationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DisputeArbitrationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DisputeRecord : AVMObjectType
            {
                public Algorand.Address Opener { get; set; }

                public Algorand.Address Respondent { get; set; }

                public byte Reason { get; set; }

                public byte[] OpenerProof { get; set; }

                public byte[] RespondentProof { get; set; }

                public byte Status { get; set; }

                public Algorand.Address Winner { get; set; }

                public ulong OpenedAt { get; set; }

                public ulong ResolvedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpener = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOpener.From(Opener);
                    ret.AddRange(vOpener.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRespondent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRespondent.From(Respondent);
                    ret.AddRange(vRespondent.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vReason.From(Reason);
                    ret.AddRange(vReason.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenerProof = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vOpenerProof.From(OpenerProof);
                    ret.AddRange(vOpenerProof.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRespondentProof = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vRespondentProof.From(RespondentProof);
                    ret.AddRange(vRespondentProof.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vWinner.From(Winner);
                    ret.AddRange(vWinner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOpenedAt.From(OpenedAt);
                    ret.AddRange(vOpenedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolvedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vResolvedAt.From(ResolvedAt);
                    ret.AddRange(vResolvedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DisputeRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DisputeRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpener = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOpener.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOpener = vOpener.ToValue();
                    if (valueOpener is Algorand.Address vOpenerValue) { ret.Opener = vOpenerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRespondent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRespondent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRespondent = vRespondent.ToValue();
                    if (valueRespondent is Algorand.Address vRespondentValue) { ret.Respondent = vRespondentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vReason.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReason = vReason.ToValue();
                    if (valueReason is byte vReasonValue) { ret.Reason = vReasonValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenerProof = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vOpenerProof.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOpenerProof = vOpenerProof.ToValue();
                    if (valueOpenerProof is byte[] vOpenerProofValue) { ret.OpenerProof = vOpenerProofValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRespondentProof = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vRespondentProof.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRespondentProof = vRespondentProof.ToValue();
                    if (valueRespondentProof is byte[] vRespondentProofValue) { ret.RespondentProof = vRespondentProofValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vWinner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWinner = vWinner.ToValue();
                    if (valueWinner is Algorand.Address vWinnerValue) { ret.Winner = vWinnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOpenedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOpenedAt = vOpenedAt.ToValue();
                    if (valueOpenedAt is ulong vOpenedAtValue) { ret.OpenedAt = vOpenedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolvedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vResolvedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResolvedAt = vResolvedAt.ToValue();
                    if (valueResolvedAt is ulong vResolvedAtValue) { ret.ResolvedAt = vResolvedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DisputeRecord);
                }
                public bool Equals(DisputeRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DisputeRecord left, DisputeRecord right)
                {
                    return EqualityComparer<DisputeRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(DisputeRecord left, DisputeRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="resolution_timeout"> </param>
        public async Task Create(ulong resolution_timeout, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var resolution_timeoutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeoutAbi.From(resolution_timeout);

            var result = await base.CallApp(new List<object> { abiHandle, resolution_timeoutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong resolution_timeout, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var resolution_timeoutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_timeoutAbi.From(resolution_timeout);

            return await base.MakeTransactionList(new List<object> { abiHandle, resolution_timeoutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="timeout"> </param>
        public async Task SetResolutionTimeout(ulong timeout, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 87, 140, 199 };
            var timeoutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timeoutAbi.From(timeout);

            var result = await base.CallApp(new List<object> { abiHandle, timeoutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetResolutionTimeout_Transactions(ulong timeout, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 87, 140, 199 };
            var timeoutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timeoutAbi.From(timeout);

            return await base.MakeTransactionList(new List<object> { abiHandle, timeoutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Open a dispute against another party for a given intent.
        ///</summary>
        /// <param name="intent_id"> </param>
        /// <param name="respondent"> </param>
        /// <param name="reason"> </param>
        /// <param name="mbr_pay"> </param>
        public async Task OpenDispute(PaymentTransaction mbr_pay, string intent_id, Algorand.Address respondent, ulong reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 141, 53, 183, 62 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var respondentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); respondentAbi.From(respondent);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reasonAbi.From(reason);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi, respondentAbi, reasonAbi, mbr_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpenDispute_Transactions(PaymentTransaction mbr_pay, string intent_id, Algorand.Address respondent, ulong reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_pay });
            byte[] abiHandle = { 141, 53, 183, 62 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var respondentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); respondentAbi.From(respondent);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reasonAbi.From(reason);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi, respondentAbi, reasonAbi, mbr_pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit evidence hash for a dispute. Called by either opener or respondent.
        ///</summary>
        /// <param name="intent_id"> </param>
        /// <param name="proof_hash"> </param>
        public async Task SubmitProof(string intent_id, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 93, 38, 130 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proof_hashAbi.From(proof_hash);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitProof_Transactions(string intent_id, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 93, 38, 130 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proof_hashAbi.From(proof_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin resolves the dispute and declares a winner.
        ///</summary>
        /// <param name="intent_id"> </param>
        /// <param name="winner"> </param>
        public async Task ResolveDispute(string intent_id, Algorand.Address winner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 51, 240, 57 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var winnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAbi.From(winner);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi, winnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResolveDispute_Transactions(string intent_id, Algorand.Address winner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 51, 240, 57 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);
            var winnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAbi.From(winner);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi, winnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Auto-resolve a dispute if the resolution timeout has passed
        ///and the respondent has not submitted proof. Opener wins by default.
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task AutoResolve(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 113, 202, 81 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.CallApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AutoResolve_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 113, 202, 81 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task<Structs.DisputeRecord> GetDispute(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 192, 49, 163 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.SimApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DisputeRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetDispute_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 192, 49, 163 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="intent_id"> </param>
        public async Task<bool> DisputeExists(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 224, 106, 133 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            var result = await base.SimApp(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DisputeExists_Transactions(string intent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 224, 106, 133 };
            var intent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); intent_idAbi.From(intent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, intent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGlzcHV0ZUFyYml0cmF0aW9uIiwiZGVzYyI6IkhhbmRsZXMgZGlzcHV0ZXMgYmV0d2VlbiB1c2VycyBhbmQgc29sdmVycyB3aXRoIHByb29mIHN1Ym1pc3Npb24gYW5kIHJlc29sdXRpb24uIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkRpc3B1dGVSZWNvcmQiOlt7Im5hbWUiOiJvcGVuZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlc3BvbmRlbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlYXNvbiIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6Im9wZW5lcl9wcm9vZiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJyZXNwb25kZW50X3Byb29mIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6Indpbm5lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3BlbmVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlc29sdmVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzb2x1dGlvbl90aW1lb3V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9yZXNvbHV0aW9uX3RpbWVvdXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZW91dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcGVuX2Rpc3B1dGUiLCJkZXNjIjoiT3BlbiBhIGRpc3B1dGUgYWdhaW5zdCBhbm90aGVyIHBhcnR5IGZvciBhIGdpdmVuIGludGVudC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzcG9uZGVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF9wcm9vZiIsImRlc2MiOiJTdWJtaXQgZXZpZGVuY2UgaGFzaCBmb3IgYSBkaXNwdXRlLiBDYWxsZWQgYnkgZWl0aGVyIG9wZW5lciBvciByZXNwb25kZW50LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzb2x2ZV9kaXNwdXRlIiwiZGVzYyI6IkFkbWluIHJlc29sdmVzIHRoZSBkaXNwdXRlIGFuZCBkZWNsYXJlcyBhIHdpbm5lci4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2lubmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImF1dG9fcmVzb2x2ZSIsImRlc2MiOiJBdXRvLXJlc29sdmUgYSBkaXNwdXRlIGlmIHRoZSByZXNvbHV0aW9uIHRpbWVvdXQgaGFzIHBhc3NlZFxuYW5kIHRoZSByZXNwb25kZW50IGhhcyBub3Qgc3VibWl0dGVkIHByb29mLiBPcGVuZXIgd2lucyBieSBkZWZhdWx0LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnRlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Rpc3B1dGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDgsYnl0ZVtdLGJ5dGVbXSx1aW50OCxhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRGlzcHV0ZVJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGlzcHV0ZV9leGlzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2NThdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHJlc29sdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODM4XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IGF1dG8tcmVzb2x2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3N10sImVycm9yTWVzc2FnZSI6IkRpc3B1dGUgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTgsNjQzXSwiZXJyb3JNZXNzYWdlIjoiRGlzcHV0ZSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDNdLCJlcnJvck1lc3NhZ2UiOiJEaXNwdXRlIG5vdCBvcGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkwXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCByZWFzb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOThdLCJlcnJvck1lc3NhZ2UiOiJNQlIgcGF5IHRvIGFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3NV0sImVycm9yTWVzc2FnZSI6Ik5vdCBhIHBhcnR5IHRvIHRoaXMgZGlzcHV0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMiw2MzFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU3XSwiZXJyb3JNZXNzYWdlIjoiVGltZW91dCBub3QgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4MV0sImVycm9yTWVzc2FnZSI6Ildpbm5lciBtdXN0IGJlIGEgcGFydHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTAsNjI5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MTcsMTAwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGlzcHV0ZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXNvbHV0aW9uX3RpbWVvdXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9kaXNwdXRlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzgsOTY4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZXNvbHZlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjMsMzg1LDQwMiw2MDMsNzk5LDk5MywxMDE5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxLDM5Myw0MDksNjExLDgwNywxMDAxLDEwMjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxLDYyMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODMsMjAyLDI0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOF0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlRFkwTnpNM01EVm1JQ0owYjNSaGJGOXlaWE52YkhabFpDSWdJbkpsYzI5c2RYUnBiMjVmZEdsdFpXOTFkQ0lnSW5SdmRHRnNYMlJwYzNCMWRHVnpJaUFpWVdSdGFXNGlJREI0TURJZ01IZ3dNRGMySURCNE1UVXhaamRqTnpVS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRM0NpQWdJQ0F2THlCelpXeG1MbkpsYzI5c2RYUnBiMjVmZEdsdFpXOTFkQ0E5SUZWSmJuUTJOQ2c0TmpRd01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxjMjlzZFhScGIyNWZkR2x0Wlc5MWRDSUtJQ0FnSUhCMWMyaHBiblFnT0RZME1EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8wT0FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5a2FYTndkWFJsY3lBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmWkdsemNIVjBaWE1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzSmxjMjlzZG1Wa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5eVpYTnZiSFpsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnWTJ4aGMzTWdSR2x6Y0hWMFpVRnlZbWwwY21GMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0Tm1JMU56aGpZemNnTUhnNFpETTFZamN6WlNBd2VEUmxOV1F5TmpneUlEQjRaV1F6TTJZd016a2dNSGhpTkRjeFkyRTFNU0F3ZURnNVl6QXpNV0V6SURCNE1qVmxNRFpoT0RVZ0x5OGdiV1YwYUc5a0lDSnpaWFJmY21WemIyeDFkR2x2Ymw5MGFXMWxiM1YwS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnZjR1Z1WDJScGMzQjFkR1VvYzNSeWFXNW5MR0ZrWkhKbGMzTXNkV2x1ZERZMExIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpkV0p0YVhSZmNISnZiMllvYzNSeWFXNW5MR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYTnZiSFpsWDJScGMzQjFkR1VvYzNSeWFXNW5MR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVlYVjBiMTl5WlhOdmJIWmxLSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZaR2x6Y0hWMFpTaHpkSEpwYm1jcEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBPQ3hpZVhSbFcxMHNZbmwwWlZ0ZExIVnBiblE0TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbVJwYzNCMWRHVmZaWGhwYzNSektITjBjbWx1WnlsaWIyOXNJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFgzSmxjMjlzZFhScGIyNWZkR2x0Wlc5MWRDQnZjR1Z1WDJScGMzQjFkR1VnYzNWaWJXbDBYM0J5YjI5bUlISmxjMjlzZG1WZlpHbHpjSFYwWlNCaGRYUnZYM0psYzI5c2RtVWdaMlYwWDJScGMzQjFkR1VnWkdsemNIVjBaVjlsZUdsemRITUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCamJHRnpjeUJFYVhOd2RYUmxRWEppYVhSeVlYUnBiMjRvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTBNR1F5WmpZM0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk1amIyNTBjbUZqZEM1RWFYTndkWFJsUVhKaWFYUnlZWFJwYjI0dVkzSmxZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFOUW9nSUNBZ0x5OGdjMlZzWmk1eVpYTnZiSFYwYVc5dVgzUnBiV1Z2ZFhRZ1BTQnlaWE52YkhWMGFXOXVYM1JwYldWdmRYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxjMjlzZFhScGIyNWZkR2x0Wlc5MWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1ScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dVkyOXVkSEpoWTNRdVJHbHpjSFYwWlVGeVltbDBjbUYwYVc5dUxuTmxkRjl5WlhOdmJIVjBhVzl1WDNScGJXVnZkWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZjbVZ6YjJ4MWRHbHZibDkwYVcxbGIzVjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxjMjlzZFhScGIyNWZkR2x0Wlc5MWRDQTlJSFJwYldWdmRYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxjMjlzZFhScGIyNWZkR2x0Wlc5MWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8xTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpNWpiMjUwY21GamRDNUVhWE53ZFhSbFFYSmlhWFJ5WVhScGIyNHViM0JsYmw5a2FYTndkWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2IzQmxibDlrYVhOd2RYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TmpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklHRnpjMlZ5ZENCcGJuUmxiblJmYVdRZ2JtOTBJR2x1SUhObGJHWXVaR2x6Y0hWMFpYTXNJQ0pFYVhOd2RYUmxJR0ZzY21WaFpIa2daWGhwYzNSeklnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTBOek0zTURWbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRWFYTndkWFJsSUdGc2NtVmhaSGtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8zTWdvZ0lDQWdMeThnWVhOelpYSjBJSEpsWVhOdmJpQStQU0JWU1c1ME5qUW9NU2tnWVc1a0lISmxZWE52YmlBOFBTQlZTVzUwTmpRb05Da3NJQ0pKYm5aaGJHbGtJSEpsWVhOdmJpSUtJQ0FnSUdKNklHOXdaVzVmWkdsemNIVjBaVjlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEdzlDaUFnSUNCaWVpQnZjR1Z1WDJScGMzQjFkR1ZmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2IzQmxibDlrYVhOd2RYUmxYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qY3lDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmhjMjl1SUQ0OUlGVkpiblEyTkNneEtTQmhibVFnY21WaGMyOXVJRHc5SUZWSmJuUTJOQ2cwS1N3Z0lrbHVkbUZzYVdRZ2NtVmhjMjl1SWdvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdjbVZoYzI5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdZWE56WlhKMElHMWljbDl3WVhrdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJazFDVWlCd1lYa2dkRzhnWVhCd0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTlFsSWdjR0Y1SUhSdklHRndjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUc5d1pXNWxjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdjbVZoYzI5dVBXRnlZelF1VlVsdWREZ29jbVZoYzI5dUtTd0tJQ0FnSUdScFp5QXpDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKcGRHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ055QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnZDJsdWJtVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOektTd0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklHOXdaVzVsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8zTlMwNE5Rb2dJQ0FnTHk4Z2MyVnNaaTVrYVhOd2RYUmxjMXRwYm5SbGJuUmZhV1JkSUQwZ1JHbHpjSFYwWlZKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCdmNHVnVaWEk5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMzQnZibVJsYm5ROVlYSmpOQzVCWkdSeVpYTnpLSEpsYzNCdmJtUmxiblFwTEFvZ0lDQWdMeThnSUNBZ0lISmxZWE52YmoxaGNtTTBMbFZKYm5RNEtISmxZWE52Ymlrc0NpQWdJQ0F2THlBZ0lDQWdiM0JsYm1WeVgzQnliMjltUFdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S0VWTlVGUlpYMUJTVDA5R0tTd0tJQ0FnSUM4dklDQWdJQ0J5WlhOd2IyNWtaVzUwWDNCeWIyOW1QV0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLRVZOVUZSWlgxQlNUMDlHS1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVlYSmpOQzVWU1c1ME9DaEVTVk5RVlZSRlgwOVFSVTRwTEFvZ0lDQWdMeThnSUNBZ0lIZHBibTVsY2oxaGNtTTBMa0ZrWkhKbGMzTW9SMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeWtzQ2lBZ0lDQXZMeUFnSUNBZ2IzQmxibVZrWDJGMFBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0J5WlhOdmJIWmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOell3TURjNE1ERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9EWUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaR2x6Y0hWMFpYTWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gyUnBjM0IxZEdWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyUnBjM0IxZEdWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDJScGMzQjFkR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiM0JsYmw5a2FYTndkWFJsWDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUc5d1pXNWZaR2x6Y0hWMFpWOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpNWpiMjUwY21GamRDNUVhWE53ZFhSbFFYSmlhWFJ5WVhScGIyNHVjM1ZpYldsMFgzQnliMjltVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzVmliV2wwWDNCeWIyOW1PZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCaGMzTmxjblFnYVc1MFpXNTBYMmxrSUdsdUlITmxiR1l1WkdsemNIVjBaWE1zSUNKRWFYTndkWFJsSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5EY3pOekExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRVJwYzNCMWRHVWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG81TmdvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWthWE53ZFhSbGMxdHBiblJsYm5SZmFXUmRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamsyTFRrM0NpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbVJwYzNCMWRHVnpXMmx1ZEdWdWRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RNEtFUkpVMUJWVkVWZlQxQkZUaWtnYjNJZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RNEtBb2dJQ0FnY0hWemFHbHVkQ0EyT1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLRVJKVTFCVlZFVmZUMUJGVGlrZ2IzSWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lHSTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T1RjdE9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb1JFbFRVRlZVUlY5UFVFVk9LU0J2Y2lCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb0NpQWdJQ0F2THlBZ0lDQWdSRWxUVUZWVVJWOVFVazlQUmw5VFZVSk5TVlJVUlVRS0lDQWdJQzh2SUNrc0lDSkVhWE53ZFhSbElHNXZkQ0J2Y0dWdUlnb2dJQ0FnWW01NklITjFZbTFwZEY5d2NtOXZabDlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURJS0lDQWdJR0k5UFFvZ0lDQWdZbm9nYzNWaWJXbDBYM0J5YjI5bVgySnZiMnhmWm1Gc2MyVkFOQW9LYzNWaWJXbDBYM0J5YjI5bVgySnZiMnhmZEhKMVpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbk4xWW0xcGRGOXdjbTl2Wmw5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG81TnkwNU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbFkyOXlaQzV6ZEdGMGRYTWdQVDBnWVhKak5DNVZTVzUwT0NoRVNWTlFWVlJGWDA5UVJVNHBJRzl5SUhKbFkyOXlaQzV6ZEdGMGRYTWdQVDBnWVhKak5DNVZTVzUwT0NnS0lDQWdJQzh2SUNBZ0lDQkVTVk5RVlZSRlgxQlNUMDlHWDFOVlFrMUpWRlJGUkFvZ0lDQWdMeThnS1N3Z0lrUnBjM0IxZEdVZ2JtOTBJRzl3Wlc0aUNpQWdJQ0JoYzNObGNuUWdMeThnUkdsemNIVjBaU0J1YjNRZ2IzQmxiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCcGMxOXZjR1Z1WlhJZ1BTQlVlRzR1YzJWdVpHVnlJRDA5SUhKbFkyOXlaQzV2Y0dWdVpYSXVibUYwYVhabENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCcGMxOXlaWE53YjI1a1pXNTBJRDBnVkhodUxuTmxibVJsY2lBOVBTQnlaV052Y21RdWNtVnpjRzl1WkdWdWRDNXVZWFJwZG1VS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJRDA5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQXpDaUFnSUNBdkx5QmhjM05sY25RZ2FYTmZiM0JsYm1WeUlHOXlJR2x6WDNKbGMzQnZibVJsYm5Rc0lDSk9iM1FnWVNCd1lYSjBlU0IwYnlCMGFHbHpJR1JwYzNCMWRHVWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2ZId0tJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdZU0J3WVhKMGVTQjBieUIwYUdseklHUnBjM0IxZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdibVYzWDI5d1pXNWxjbDl3Y205dlppQTlJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLSEJ5YjI5bVgyaGhjMmdwSUdsbUlHbHpYMjl3Wlc1bGNpQmxiSE5sSUhKbFkyOXlaQzV2Y0dWdVpYSmZjSEp2YjJZdVkyOXdlU2dwQ2lBZ0lDQmllaUJ6ZFdKdGFYUmZjSEp2YjJaZmRHVnlibUZ5ZVY5bVlXeHpaVUEzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZblZ5ZVNBMkNncHpkV0p0YVhSZmNISnZiMlpmZEdWeWJtRnllVjl0WlhKblpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBMkNpQWdJQ0F2THlCdVpYZGZjbVZ6Y0c5dVpHVnVkRjl3Y205dlppQTlJR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpLSEJ5YjI5bVgyaGhjMmdwSUdsbUlHbHpYM0psYzNCdmJtUmxiblFnWld4elpTQnlaV052Y21RdWNtVnpjRzl1WkdWdWRGOXdjbTl2Wmk1amIzQjVLQ2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmllaUJ6ZFdKdGFYUmZjSEp2YjJaZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TUFvZ0lDQWdaR2xuSURNS0NuTjFZbTFwZEY5d2NtOXZabDkwWlhKdVlYSjVYMjFsY21kbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRFeENpQWdJQ0F2THlCeVpXRnpiMjQ5Y21WamIzSmtMbkpsWVhOdmJpd0tJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRFMUNpQWdJQ0F2THlCM2FXNXVaWEk5Y21WamIzSmtMbmRwYm01bGNpd0tJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURjd0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklHOXdaVzVsWkY5aGREMXlaV052Y21RdWIzQmxibVZrWDJGMExBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRBeUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z2NtVnpiMngyWldSZllYUTljbVZqYjNKa0xuSmxjMjlzZG1Wa1gyRjBMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01URXdDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXdPQzB4TVRnS0lDQWdJQzh2SUhObGJHWXVaR2x6Y0hWMFpYTmJhVzUwWlc1MFgybGtYU0E5SUVScGMzQjFkR1ZTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYjNCbGJtVnlQWEpsWTI5eVpDNXZjR1Z1WlhJc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6Y0c5dVpHVnVkRDF5WldOdmNtUXVjbVZ6Y0c5dVpHVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXRnpiMjQ5Y21WamIzSmtMbkpsWVhOdmJpd0tJQ0FnSUM4dklDQWdJQ0J2Y0dWdVpYSmZjSEp2YjJZOWJtVjNYMjl3Wlc1bGNsOXdjbTl2Wmk1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpjRzl1WkdWdWRGOXdjbTl2WmoxdVpYZGZjbVZ6Y0c5dVpHVnVkRjl3Y205dlppNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEhWelBXRnlZelF1VlVsdWREZ29SRWxUVUZWVVJWOVFVazlQUmw5VFZVSk5TVlJVUlVRcExBb2dJQ0FnTHk4Z0lDQWdJSGRwYm01bGNqMXlaV052Y21RdWQybHVibVZ5TEFvZ0lDQWdMeThnSUNBZ0lHOXdaVzVsWkY5aGREMXlaV052Y21RdWIzQmxibVZrWDJGMExBb2dJQ0FnTHk4Z0lDQWdJSEpsYzI5c2RtVmtYMkYwUFhKbFkyOXlaQzV5WlhOdmJIWmxaRjloZEN3S0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBeE13b2dJQ0FnWkdsbklERXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREEzTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01URUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFeE9Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URTBDaUFnSUNBdkx5QnpkR0YwZFhNOVlYSmpOQzVWU1c1ME9DaEVTVk5RVlZSRlgxQlNUMDlHWDFOVlFrMUpWRlJGUkNrc0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1ESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3T0MweE1UZ0tJQ0FnSUM4dklITmxiR1l1WkdsemNIVjBaWE5iYVc1MFpXNTBYMmxrWFNBOUlFUnBjM0IxZEdWU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2IzQmxibVZ5UFhKbFkyOXlaQzV2Y0dWdVpYSXNDaUFnSUNBdkx5QWdJQ0FnY21WemNHOXVaR1Z1ZEQxeVpXTnZjbVF1Y21WemNHOXVaR1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnlaV0Z6YjI0OWNtVmpiM0prTG5KbFlYTnZiaXdLSUNBZ0lDOHZJQ0FnSUNCdmNHVnVaWEpmY0hKdmIyWTlibVYzWDI5d1pXNWxjbDl3Y205dlppNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6Y0c5dVpHVnVkRjl3Y205dlpqMXVaWGRmY21WemNHOXVaR1Z1ZEY5d2NtOXZaaTVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvUkVsVFVGVlVSVjlRVWs5UFJsOVRWVUpOU1ZSVVJVUXBMQW9nSUNBZ0x5OGdJQ0FnSUhkcGJtNWxjajF5WldOdmNtUXVkMmx1Ym1WeUxBb2dJQ0FnTHk4Z0lDQWdJRzl3Wlc1bFpGOWhkRDF5WldOdmNtUXViM0JsYm1Wa1gyRjBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOXNkbVZrWDJGMFBYSmxZMjl5WkM1eVpYTnZiSFpsWkY5aGRDd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwemRXSnRhWFJmY0hKdmIyWmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnYm1WM1gzSmxjM0J2Ym1SbGJuUmZjSEp2YjJZZ1BTQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aHdjbTl2Wmw5b1lYTm9LU0JwWmlCcGMxOXlaWE53YjI1a1pXNTBJR1ZzYzJVZ2NtVmpiM0prTG5KbGMzQnZibVJsYm5SZmNISnZiMll1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZM0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZaUJ6ZFdKdGFYUmZjSEp2YjJaZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TVFvS2MzVmliV2wwWDNCeWIyOW1YM1JsY201aGNubGZabUZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TlFvZ0lDQWdMeThnYm1WM1gyOXdaVzVsY2w5d2NtOXZaaUE5SUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S0hCeWIyOW1YMmhoYzJncElHbG1JR2x6WDI5d1pXNWxjaUJsYkhObElISmxZMjl5WkM1dmNHVnVaWEpmY0hKdmIyWXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFkxQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOamNLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCaWRYSjVJRFlLSUNBZ0lHSWdjM1ZpYldsMFgzQnliMjltWDNSbGNtNWhjbmxmYldWeVoyVkFPQW9LYzNWaWJXbDBYM0J5YjI5bVgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlITjFZbTFwZEY5d2NtOXZabDlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTVqYjI1MGNtRmpkQzVFYVhOd2RYUmxRWEppYVhSeVlYUnBiMjR1Y21WemIyeDJaVjlrYVhOd2RYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WemIyeDJaVjlrYVhOd2RYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpNS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSlBibXg1SUdGa2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCcGJuUmxiblJmYVdRZ2FXNGdjMlZzWmk1a2FYTndkWFJsY3l3Z0lrUnBjM0IxZEdVZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTBOek0zTURWbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFUnBjM0IxZEdVZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNalVLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpHbHpjSFYwWlhOYmFXNTBaVzUwWDJsa1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpVdE1USTJDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1ScGMzQjFkR1Z6VzJsdWRHVnVkRjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBaFBTQmhjbU0wTGxWSmJuUTRLRVJKVTFCVlZFVmZVa1ZUVDB4V1JVUXBMQ0FpUVd4eVpXRmtlU0J5WlhOdmJIWmxaQ0lLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMk9Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJQ0U5SUdGeVl6UXVWVWx1ZERnb1JFbFRVRlZVUlY5U1JWTlBURlpGUkNrc0lDSkJiSEpsWVdSNUlISmxjMjlzZG1Wa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ETUtJQ0FnSUdJaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2NtVmhaSGtnY21WemIyeDJaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeU9Bb2dJQ0FnTHk4Z2QybHVibVZ5SUQwOUlISmxZMjl5WkM1dmNHVnVaWEl1Ym1GMGFYWmxJRzl5SUhkcGJtNWxjaUE5UFNCeVpXTnZjbVF1Y21WemNHOXVaR1Z1ZEM1dVlYUnBkbVVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVnpiMngyWlY5a2FYTndkWFJsWDJKdmIyeGZkSEoxWlVBekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTkFvZ0lDQWdQVDBLSUNBZ0lHSjZJSEpsYzI5c2RtVmZaR2x6Y0hWMFpWOWliMjlzWDJaaGJITmxRRFFLQ25KbGMyOXNkbVZmWkdsemNIVjBaVjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dweVpYTnZiSFpsWDJScGMzQjFkR1ZmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEkzTFRFeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQjNhVzV1WlhJZ1BUMGdjbVZqYjNKa0xtOXdaVzVsY2k1dVlYUnBkbVVnYjNJZ2QybHVibVZ5SUQwOUlISmxZMjl5WkM1eVpYTndiMjVrWlc1MExtNWhkR2wyWlFvZ0lDQWdMeThnS1N3Z0lsZHBibTVsY2lCdGRYTjBJR0psSUdFZ2NHRnlkSGtpQ2lBZ0lDQmhjM05sY25RZ0x5OGdWMmx1Ym1WeUlHMTFjM1FnWW1VZ1lTQndZWEowZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UTXpDaUFnSUNBdkx5QnlaWE53YjI1a1pXNTBQWEpsWTI5eVpDNXlaWE53YjI1a1pXNTBMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNelFLSUNBZ0lDOHZJSEpsWVhOdmJqMXlaV052Y21RdWNtVmhjMjl1TEFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJ2Y0dWdVpYSmZjSEp2YjJZOWNtVmpiM0prTG05d1pXNWxjbDl3Y205dlppNWpiM0I1S0Nrc0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFkxQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOamNLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVE0yQ2lBZ0lDQXZMeUJ5WlhOd2IyNWtaVzUwWDNCeWIyOW1QWEpsWTI5eVpDNXlaWE53YjI1a1pXNTBYM0J5YjI5bUxtTnZjSGtvS1N3S0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnYjNCbGJtVmtYMkYwUFhKbFkyOXlaQzV2Y0dWdVpXUmZZWFFzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQXhNRElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFF3Q2lBZ0lDQXZMeUJ5WlhOdmJIWmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNekV0TVRReENpQWdJQ0F2THlCelpXeG1MbVJwYzNCMWRHVnpXMmx1ZEdWdWRGOXBaRjBnUFNCRWFYTndkWFJsVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUc5d1pXNWxjajF5WldOdmNtUXViM0JsYm1WeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzNCdmJtUmxiblE5Y21WamIzSmtMbkpsYzNCdmJtUmxiblFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmhjMjl1UFhKbFkyOXlaQzV5WldGemIyNHNDaUFnSUNBdkx5QWdJQ0FnYjNCbGJtVnlYM0J5YjI5bVBYSmxZMjl5WkM1dmNHVnVaWEpmY0hKdmIyWXVZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJSEpsYzNCdmJtUmxiblJmY0hKdmIyWTljbVZqYjNKa0xuSmxjM0J2Ym1SbGJuUmZjSEp2YjJZdVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtFUkpVMUJWVkVWZlVrVlRUMHhXUlVRcExBb2dJQ0FnTHk4Z0lDQWdJSGRwYm01bGNqMWhjbU0wTGtGa1pISmxjM01vZDJsdWJtVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCdmNHVnVaV1JmWVhROWNtVmpiM0prTG05d1pXNWxaRjloZEN3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhabFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTndvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEySUM4dklEQjRNREEzTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREV4T0FvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoRVNWTlFWVlJGWDFKRlUwOU1Wa1ZFS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNekV0TVRReENpQWdJQ0F2THlCelpXeG1MbVJwYzNCMWRHVnpXMmx1ZEdWdWRGOXBaRjBnUFNCRWFYTndkWFJsVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUc5d1pXNWxjajF5WldOdmNtUXViM0JsYm1WeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzNCdmJtUmxiblE5Y21WamIzSmtMbkpsYzNCdmJtUmxiblFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmhjMjl1UFhKbFkyOXlaQzV5WldGemIyNHNDaUFnSUNBdkx5QWdJQ0FnYjNCbGJtVnlYM0J5YjI5bVBYSmxZMjl5WkM1dmNHVnVaWEpmY0hKdmIyWXVZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJSEpsYzNCdmJtUmxiblJmY0hKdmIyWTljbVZqYjNKa0xuSmxjM0J2Ym1SbGJuUmZjSEp2YjJZdVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtFUkpVMUJWVkVWZlVrVlRUMHhXUlVRcExBb2dJQ0FnTHk4Z0lDQWdJSGRwYm01bGNqMWhjbU0wTGtGa1pISmxjM01vZDJsdWJtVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCdmNHVnVaV1JmWVhROWNtVmpiM0prTG05d1pXNWxaRjloZEN3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhabFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTBNZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl5WlhOdmJIWmxaQ0FyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZjbVZ6YjJ4MlpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjbVZ6YjJ4MlpXUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmNtVnpiMngyWldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LY21WemIyeDJaVjlrYVhOd2RYUmxYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSEpsYzI5c2RtVmZaR2x6Y0hWMFpWOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpNWpiMjUwY21GamRDNUVhWE53ZFhSbFFYSmlhWFJ5WVhScGIyNHVZWFYwYjE5eVpYTnZiSFpsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYVjBiMTl5WlhOdmJIWmxPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hORFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UUTRDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1ScGMzQjFkR1Z6VzJsdWRHVnVkRjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpRM016Y3dOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVrYVhOd2RYUmxjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTBPQzB4TkRrS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVaR2x6Y0hWMFpYTmJhVzUwWlc1MFgybGtYUzVqYjNCNUtDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb1JFbFRVRlZVUlY5UFVFVk9LU0J2Y2lCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb0NpQWdJQ0J3ZFhOb2FXNTBJRFk1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLRVJKVTFCVlZFVmZUMUJGVGlrZ2IzSWdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lHSTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdWZllYSmlhWFJ5WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRRNUxURTFNUW9nSUNBZ0x5OGdZWE56WlhKMElISmxZMjl5WkM1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DaEVTVk5RVlZSRlgwOVFSVTRwSUc5eUlISmxZMjl5WkM1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DZ0tJQ0FnSUM4dklDQWdJQ0JFU1ZOUVZWUkZYMUJTVDA5R1gxTlZRazFKVkZSRlJBb2dJQ0FnTHk4Z0tTd2dJa05oYm01dmRDQmhkWFJ2TFhKbGMyOXNkbVVpQ2lBZ0lDQmlibm9nWVhWMGIxOXlaWE52YkhabFgySnZiMnhmZEhKMVpVQXpDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNZ29nSUNBZ1lqMDlDaUFnSUNCaWVpQmhkWFJ2WDNKbGMyOXNkbVZmWW05dmJGOW1ZV3h6WlVBMENncGhkWFJ2WDNKbGMyOXNkbVZmWW05dmJGOTBjblZsUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS1lYVjBiMTl5WlhOdmJIWmxYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTBPUzB4TlRFS0lDQWdJQzh2SUdGemMyVnlkQ0J5WldOdmNtUXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvUkVsVFVGVlVSVjlQVUVWT0tTQnZjaUJ5WldOdmNtUXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvQ2lBZ0lDQXZMeUFnSUNBZ1JFbFRVRlZVUlY5UVVrOVBSbDlUVlVKTlNWUlVSVVFLSUNBZ0lDOHZJQ2tzSUNKRFlXNXViM1FnWVhWMGJ5MXlaWE52YkhabElnb2dJQ0FnWVhOelpYSjBJQzh2SUVOaGJtNXZkQ0JoZFhSdkxYSmxjMjlzZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTFNd29nSUNBZ0x5OGdkR2x0WlY5bGJHRndjMlZrSUQwZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnTFNCeVpXTnZjbVF1YjNCbGJtVmtYMkYwTG01aGRHbDJaUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01UQXlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JpZEc5cENpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGFXMWxYMlZzWVhCelpXUWdQaUJ6Wld4bUxuSmxjMjlzZFhScGIyNWZkR2x0Wlc5MWRDd2dJbFJwYldWdmRYUWdibTkwSUhKbFlXTm9aV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljbVZ6YjJ4MWRHbHZibDkwYVcxbGIzVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbGMyOXNkWFJwYjI1ZmRHbHRaVzkxZENCbGVHbHpkSE1LSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCVWFXMWxiM1YwSUc1dmRDQnlaV0ZqYUdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOVFlLSUNBZ0lDOHZJSEpsYzNCdmJtUmxiblJmYUdGelgzQnliMjltSUQwZ2NtVmpiM0prTG5KbGMzQnZibVJsYm5SZmNISnZiMll1Ym1GMGFYWmxJQ0U5SUVKNWRHVnpLRVZOVUZSWlgxQlNUMDlHS1FvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJOd29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURjS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lDRTlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TlRjS0lDQWdJQzh2SUhkcGJtNWxjaUE5SUhKbFkyOXlaQzV5WlhOd2IyNWtaVzUwSUdsbUlISmxjM0J2Ym1SbGJuUmZhR0Z6WDNCeWIyOW1JR1ZzYzJVZ2NtVmpiM0prTG05d1pXNWxjZ29nSUNBZ1lub2dZWFYwYjE5eVpYTnZiSFpsWDNSbGNtNWhjbmxmWm1Gc2MyVkFOd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaWGgwY21GamRBb0tZWFYwYjE5eVpYTnZiSFpsWDNSbGNtNWhjbmxmYldWeVoyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFMk1Bb2dJQ0FnTHk4Z2IzQmxibVZ5UFhKbFkyOXlaQzV2Y0dWdVpYSXNDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UWXhDaUFnSUNBdkx5QnlaWE53YjI1a1pXNTBQWEpsWTI5eVpDNXlaWE53YjI1a1pXNTBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFl5Q2lBZ0lDQXZMeUJ5WldGemIyNDljbVZqYjNKa0xuSmxZWE52Yml3S0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsWDJGeVltbDBjbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUyTXdvZ0lDQWdMeThnYjNCbGJtVnlYM0J5YjI5bVBYSmxZMjl5WkM1dmNHVnVaWEpmY0hKdmIyWXVZMjl3ZVNncExBb2dJQ0FnWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EyTlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UWTRDaUFnSUNBdkx5QnlaWE52YkhabFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5Ua3RNVFk1Q2lBZ0lDQXZMeUJ6Wld4bUxtUnBjM0IxZEdWelcybHVkR1Z1ZEY5cFpGMGdQU0JFYVhOd2RYUmxVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJRzl3Wlc1bGNqMXlaV052Y21RdWIzQmxibVZ5TEFvZ0lDQWdMeThnSUNBZ0lISmxjM0J2Ym1SbGJuUTljbVZqYjNKa0xuSmxjM0J2Ym1SbGJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WaGMyOXVQWEpsWTI5eVpDNXlaV0Z6YjI0c0NpQWdJQ0F2THlBZ0lDQWdiM0JsYm1WeVgzQnliMjltUFhKbFkyOXlaQzV2Y0dWdVpYSmZjSEp2YjJZdVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lISmxjM0J2Ym1SbGJuUmZjSEp2YjJZOWNtVmpiM0prTG5KbGMzQnZibVJsYm5SZmNISnZiMll1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0VSSlUxQlZWRVZmUVZWVVQxOVNSVk5QVEZaRlJDa3NDaUFnSUNBdkx5QWdJQ0FnZDJsdWJtVnlQWGRwYm01bGNpd0tJQ0FnSUM4dklDQWdJQ0J2Y0dWdVpXUmZZWFE5Y21WamIzSmtMbTl3Wlc1bFpGOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpYTnZiSFpsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TnpZS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TVRnS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFMk5Rb2dJQ0FnTHk4Z2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb1JFbFRVRlZVUlY5QlZWUlBYMUpGVTA5TVZrVkVLU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5Ua3RNVFk1Q2lBZ0lDQXZMeUJ6Wld4bUxtUnBjM0IxZEdWelcybHVkR1Z1ZEY5cFpGMGdQU0JFYVhOd2RYUmxVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJRzl3Wlc1bGNqMXlaV052Y21RdWIzQmxibVZ5TEFvZ0lDQWdMeThnSUNBZ0lISmxjM0J2Ym1SbGJuUTljbVZqYjNKa0xuSmxjM0J2Ym1SbGJuUXNDaUFnSUNBdkx5QWdJQ0FnY21WaGMyOXVQWEpsWTI5eVpDNXlaV0Z6YjI0c0NpQWdJQ0F2THlBZ0lDQWdiM0JsYm1WeVgzQnliMjltUFhKbFkyOXlaQzV2Y0dWdVpYSmZjSEp2YjJZdVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lISmxjM0J2Ym1SbGJuUmZjSEp2YjJZOWNtVmpiM0prTG5KbGMzQnZibVJsYm5SZmNISnZiMll1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0VSSlUxQlZWRVZmUVZWVVQxOVNSVk5QVEZaRlJDa3NDaUFnSUNBdkx5QWdJQ0FnZDJsdWJtVnlQWGRwYm01bGNpd0tJQ0FnSUM4dklDQWdJQ0J2Y0dWdVpXUmZZWFE5Y21WamIzSmtMbTl3Wlc1bFpGOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpYTnZiSFpsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVGN3Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNKbGMyOXNkbVZrSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl5WlhOdmJIWmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl5WlhOdmJIWmxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXlaWE52YkhabFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlY5aGNtSnBkSEpoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TkRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwaGRYUnZYM0psYzI5c2RtVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFUzQ2lBZ0lDQXZMeUIzYVc1dVpYSWdQU0J5WldOdmNtUXVjbVZ6Y0c5dVpHVnVkQ0JwWmlCeVpYTndiMjVrWlc1MFgyaGhjMTl3Y205dlppQmxiSE5sSUhKbFkyOXlaQzV2Y0dWdVpYSUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZaUJoZFhSdlgzSmxjMjlzZG1WZmRHVnlibUZ5ZVY5dFpYSm5aVUE0Q2dwaGRYUnZYM0psYzI5c2RtVmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZWFYwYjE5eVpYTnZiSFpsWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TG1OdmJuUnlZV04wTGtScGMzQjFkR1ZCY21KcGRISmhkR2x2Ymk1blpYUmZaR2x6Y0hWMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5a2FYTndkWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVmZZWEppYVhSeVlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UY3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaVjloY21KcGRISmhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOelFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1ScGMzQjFkR1Z6VzJsdWRHVnVkRjlwWkYwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5EY3pOekExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWthWE53ZFhSbGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbFgyRnlZbWwwY21GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFM01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1ScGMzQjFkR1ZmWVhKaWFYUnlZWFJwYjI0dVkyOXVkSEpoWTNRdVJHbHpjSFYwWlVGeVltbDBjbUYwYVc5dUxtUnBjM0IxZEdWZlpYaHBjM1J6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHbHpjSFYwWlY5bGVHbHpkSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxYMkZ5WW1sMGNtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTNPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHbHVkR1Z1ZEY5cFpDQnBiaUJ6Wld4bUxtUnBjM0IxZEdWekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qUTNNemN3TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpWOWhjbUpwZEhKaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ0NDWUlCR1J6Y0Y4T2RHOTBZV3hmY21WemIyeDJaV1FTY21WemIyeDFkR2x2Ymw5MGFXMWxiM1YwRG5SdmRHRnNYMlJwYzNCMWRHVnpCV0ZrYldsdUFRSUNBSFlFRlI5OGRURVlRQUFNS29HQW93Vm5LeUpuS1NKbk1Sa1VSREVZUVFBNWdnY0VhMWVNeHdTTk5iYytCRTVkSm9JRTdUUHdPUVMwY2NwUkJJbkFNYU1FSmVCcWhUWWFBSTRIQUNJQU9RRFdBYlVDZFFNN0ExVUFnQVFrRFM5bk5ob0FqZ0VBQVFBMkdnRkpGU1VTUkJjbkJERUFaeXBNWnlORE5ob0JTUlVsRWtRWE1RQWlKd1JsUkJKRUtreG5JME0yR2dGSklsbUJBZ2hMQVJVU1JEWWFBa2xPQWhVa0VrUTJHZ05KRlNVU1JCZEpUZ0l4RmlNSlNVNERPQkFqRWtRb1R3SlFTVTRDdlVVQkZFUkJBRnBMQW9FRURrRUFVaU5FU3dFNEJ6SUtFa1F4QUVzREZrbVRKUTVFVndjQk1nTXlCeFpQQTBzSFVFOERVSUFGQUhZQWVBRlFUd0pRVEZDQURBQUFBQUFBQUFBQUFBQUFBRkJMQVVtOFNFeS9JaXRsUkNNSUsweG5JME1pUXYrcklrY0NnQUEyR2dGSklsbUJBZ2hMQVJVU1JEWWFBa2xPQWtraVdZRUNDRXdWRWtRb1RGQkhBcjFGQVVSSnZraE1nVVVqdWttQUFRR29RQUFIU1NjRnFFRUFtQ05FTVFCTEEwbE9BaUlrdWtsRkN4SXhBRThDSkVtNlNVVUtFa2xGQjBzQkVVUkJBR0pMQTBVR1N3UkJBRXhMQTBzRFNZRkFJN3BMQVlGR0pMcExBb0ZtSmJwTEE0RnVKYnBMRFVzTlVFOEVVQ2NHVUVzTFNVNENGWUYyQ0JaWEJnSlFKd1ZRVHdSUVR3TlFUd0pRVEZCUEFsQkxBYnhJdnlORFN3RkpnVU5aU3dFVlVrTC9xVXNCU1lGQldVc0JnVU5aVWtVR1F2K1JJa0wvWlRZYUFVa2lXWUVDQ0VzQkZSSkVOaG9DU1U0Q1NSVWtFa1F4QUNJbkJHVkVFa1FvVHdKUVNVNENTYjFGQVVSSnZraE9Ba21CUlNPNmdBRURxVVFpSkxwSlRnSVNRQUFMU3dJa1NicExCQkpCQUdvalJFc0NTU1JKdWtzQmdVQWp1a3NFU1lGQldVc0JnVU5aU3dKUEFrc0NVa3NDRlU4RFR3TlBBbEpMQklGbUpib3lCeFpMQjA4R1VFOEZVQ2NHVUVzRUZZRjJDQlpYQmdKUWdBRURVRXNKVUU4Q1VFeFFUd0pRVEZCTEFieEl2eUlwWlVRakNDbE1aeU5ESWtML2t5SkpnQUEyR2dGSklsbUJBZ2hMQVJVU1JDaE1VRWNDdmt4T0FrU0JSU082U1lBQkFhaEFBQWRKSndXb1FRQ1RJMFF5QjBzRGdXWWx1a2xGQnhjSklpcGxSQTFFU3dGSmdVTlpTVTRDUlFaSkZVeE9BbEpKUlFkWEFnQ0FBQk5CQUZsTEFpUkp1a3NEU1NJa3Vrc0JKRW02U3dLQlFDTzZTd1pKZ1VGWlN3cFNNZ2NXVHdSUEJGQlBBMUFuQmxCTEFoV0JkZ2dXVndZQ1VJQUJCRkJQQkZCTENGQk1VRXhRU3dkUVN3RzhTTDhpS1dWRUl3Z3BUR2NqUTBzQ0lpUzZRditrSWtML2FqWWFBVWtpV1lFQ0NFc0JGUkpFS0V4UXZrUW5CMHhRc0NORE5ob0JTU0paZ1FJSVN3RVZFa1FvVEZDOVJRR0FBUUFpVHdKVUp3ZE1VTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
