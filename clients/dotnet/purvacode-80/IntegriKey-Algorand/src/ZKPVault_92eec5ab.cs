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

namespace Arc56.Generated.purvacode_80.IntegriKey_Algorand.ZKPVault_92eec5ab
{


    //
    // 
    //    IntegriKey Smart Contract
    //    Privacy-preserving AI proctoring on Algorand
    //    
    //    Simplified version using global state for demo purposes
    //    
    //
    public class ZKPVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ZKPVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ExamConfig : AVMObjectType
            {
                public Algorand.Address Creator { get; set; }

                public ulong DurationMinutes { get; set; }

                public ulong MinTrustScore { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreator.From(Creator);
                    ret.AddRange(vCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDurationMinutes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDurationMinutes.From(DurationMinutes);
                    ret.AddRange(vDurationMinutes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinTrustScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinTrustScore.From(MinTrustScore);
                    ret.AddRange(vMinTrustScore.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ExamConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ExamConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreator = vCreator.ToValue();
                    if (valueCreator is Algorand.Address vCreatorValue) { ret.Creator = vCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDurationMinutes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDurationMinutes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDurationMinutes = vDurationMinutes.ToValue();
                    if (valueDurationMinutes is ulong vDurationMinutesValue) { ret.DurationMinutes = vDurationMinutesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinTrustScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinTrustScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinTrustScore = vMinTrustScore.ToValue();
                    if (valueMinTrustScore is ulong vMinTrustScoreValue) { ret.MinTrustScore = vMinTrustScoreValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ExamConfig);
                }
                public bool Equals(ExamConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ExamConfig left, ExamConfig right)
                {
                    return EqualityComparer<ExamConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(ExamConfig left, ExamConfig right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the contract
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 44, 58, 192 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 44, 58, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new exam registry.
        ///</summary>
        /// <param name="exam_id"> </param>
        /// <param name="duration"> </param>
        /// <param name="min_score"> </param>
        public async Task CreateExam(string exam_id, ulong duration, ulong min_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 24, 75, 16 };
            var exam_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); exam_idAbi.From(exam_id);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var min_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_scoreAbi.From(min_score);

            var result = await base.CallApp(new List<object> { abiHandle, exam_idAbi, durationAbi, min_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateExam_Transactions(string exam_id, ulong duration, ulong min_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 24, 75, 16 };
            var exam_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); exam_idAbi.From(exam_id);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var min_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_scoreAbi.From(min_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, exam_idAbi, durationAbi, min_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit exam proof for a student
        ///</summary>
        /// <param name="exam_id">The exam identifier </param>
        /// <param name="student_hash">Hashed student identity </param>
        /// <param name="trust_score">Final trust score (0-100) </param>
        /// <param name="proof_hash">SHA-256 hash of the proof data </param>
        /// <param name="ipfs_cid">IPFS Content Identifier for the incident timeline </param>
        /// <param name="zk_proof">Raw bytes emitted by the ZK Plonk frontend circuit </param>
        /// <param name="public_inputs">Public constraints mapped into the circuit math </param>
        public async Task<string> SubmitProof(string exam_id, string student_hash, ulong trust_score, string proof_hash, string ipfs_cid, byte[] zk_proof, ulong[] public_inputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 155, 114, 7 };
            var exam_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); exam_idAbi.From(exam_id);
            var student_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); student_hashAbi.From(student_hash);
            var trust_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); trust_scoreAbi.From(trust_score);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proof_hashAbi.From(proof_hash);
            var ipfs_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_cidAbi.From(ipfs_cid);
            var zk_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zk_proofAbi.From(zk_proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); public_inputsAbi.From(public_inputs);

            var result = await base.CallApp(new List<object> { abiHandle, exam_idAbi, student_hashAbi, trust_scoreAbi, proof_hashAbi, ipfs_cidAbi, zk_proofAbi, public_inputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SubmitProof_Transactions(string exam_id, string student_hash, ulong trust_score, string proof_hash, string ipfs_cid, byte[] zk_proof, ulong[] public_inputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 155, 114, 7 };
            var exam_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); exam_idAbi.From(exam_id);
            var student_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); student_hashAbi.From(student_hash);
            var trust_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); trust_scoreAbi.From(trust_score);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proof_hashAbi.From(proof_hash);
            var ipfs_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_cidAbi.From(ipfs_cid);
            var zk_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zk_proofAbi.From(zk_proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); public_inputsAbi.From(public_inputs);

            return await base.MakeTransactionList(new List<object> { abiHandle, exam_idAbi, student_hashAbi, trust_scoreAbi, proof_hashAbi, ipfs_cidAbi, zk_proofAbi, public_inputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify that a proof submission is valid
        ///</summary>
        /// <param name="exam_id">The exam identifier </param>
        /// <param name="student_hash">Hashed student identity </param>
        /// <param name="trust_score">Final trust score (0-100) </param>
        /// <param name="proof_hash">SHA-256 hash of the proof data </param>
        public async Task<bool> VerifySubmission(string exam_id, string student_hash, ulong trust_score, string proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 189, 147, 159 };
            var exam_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); exam_idAbi.From(exam_id);
            var student_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); student_hashAbi.From(student_hash);
            var trust_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); trust_scoreAbi.From(trust_score);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proof_hashAbi.From(proof_hash);

            var result = await base.CallApp(new List<object> { abiHandle, exam_idAbi, student_hashAbi, trust_scoreAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifySubmission_Transactions(string exam_id, string student_hash, ulong trust_score, string proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 189, 147, 159 };
            var exam_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); exam_idAbi.From(exam_id);
            var student_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); student_hashAbi.From(student_hash);
            var trust_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); trust_scoreAbi.From(trust_score);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proof_hashAbi.From(proof_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, exam_idAbi, student_hashAbi, trust_scoreAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///AlgoPlonk SNARK verification (Simulated for Hackathon MVP)
        ///In a production network, this utilizes algopy.op.EC pairing algorithms to mathematically enforce the privacy computations.
        ///</summary>
        /// <param name="zk_proof"> </param>
        /// <param name="public_inputs"> </param>
        public async Task<bool> VerifyZkSnark(byte[] zk_proof, ulong[] public_inputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 144, 198, 157 };
            var zk_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zk_proofAbi.From(zk_proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); public_inputsAbi.From(public_inputs);

            var result = await base.CallApp(new List<object> { abiHandle, zk_proofAbi, public_inputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyZkSnark_Transactions(byte[] zk_proof, ulong[] public_inputs, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 144, 198, 157 };
            var zk_proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zk_proofAbi.From(zk_proof);
            var public_inputsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); public_inputsAbi.From(public_inputs);

            return await base.MakeTransactionList(new List<object> { abiHandle, zk_proofAbi, public_inputsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract information
        ///</summary>
        public async Task<string> GetContractInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 238, 187, 185 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetContractInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 46, 238, 187, 185 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWktQVmF1bHQiLCJkZXNjIjoiXG4gICAgSW50ZWdyaUtleSBTbWFydCBDb250cmFjdFxuICAgIFByaXZhY3ktcHJlc2VydmluZyBBSSBwcm9jdG9yaW5nIG9uIEFsZ29yYW5kXG4gICAgXG4gICAgU2ltcGxpZmllZCB2ZXJzaW9uIHVzaW5nIGdsb2JhbCBzdGF0ZSBmb3IgZGVtbyBwdXJwb3Nlc1xuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJFeGFtQ29uZmlnIjpbeyJuYW1lIjoiY3JlYXRvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZHVyYXRpb25fbWludXRlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5fdHJ1c3Rfc2NvcmUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBjb250cmFjdCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfZXhhbSIsImRlc2MiOiJDcmVhdGUgYSBuZXcgZXhhbSByZWdpc3RyeS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhhbV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbl9zY29yZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfcHJvb2YiLCJkZXNjIjoiU3VibWl0IGV4YW0gcHJvb2YgZm9yIGEgc3R1ZGVudCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleGFtX2lkIiwiZGVzYyI6IlRoZSBleGFtIGlkZW50aWZpZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0dWRlbnRfaGFzaCIsImRlc2MiOiJIYXNoZWQgc3R1ZGVudCBpZGVudGl0eSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJ1c3Rfc2NvcmUiLCJkZXNjIjoiRmluYWwgdHJ1c3Qgc2NvcmUgKDAtMTAwKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2ZfaGFzaCIsImRlc2MiOiJTSEEtMjU2IGhhc2ggb2YgdGhlIHByb29mIGRhdGEiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlwZnNfY2lkIiwiZGVzYyI6IklQRlMgQ29udGVudCBJZGVudGlmaWVyIGZvciB0aGUgaW5jaWRlbnQgdGltZWxpbmUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InprX3Byb29mIiwiZGVzYyI6IlJhdyBieXRlcyBlbWl0dGVkIGJ5IHRoZSBaSyBQbG9uayBmcm9udGVuZCBjaXJjdWl0IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YmxpY19pbnB1dHMiLCJkZXNjIjoiUHVibGljIGNvbnN0cmFpbnRzIG1hcHBlZCBpbnRvIHRoZSBjaXJjdWl0IG1hdGgiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnlfc3VibWlzc2lvbiIsImRlc2MiOiJWZXJpZnkgdGhhdCBhIHByb29mIHN1Ym1pc3Npb24gaXMgdmFsaWQiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhhbV9pZCIsImRlc2MiOiJUaGUgZXhhbSBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdHVkZW50X2hhc2giLCJkZXNjIjoiSGFzaGVkIHN0dWRlbnQgaWRlbnRpdHkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRydXN0X3Njb3JlIiwiZGVzYyI6IkZpbmFsIHRydXN0IHNjb3JlICgwLTEwMCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mX2hhc2giLCJkZXNjIjoiU0hBLTI1NiBoYXNoIG9mIHRoZSBwcm9vZiBkYXRhIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUcnVlIGlmIHZhbGlkIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5X3prX3NuYXJrIiwiZGVzYyI6IkFsZ29QbG9uayBTTkFSSyB2ZXJpZmljYXRpb24gKFNpbXVsYXRlZCBmb3IgSGFja2F0aG9uIE1WUClcbkluIGEgcHJvZHVjdGlvbiBuZXR3b3JrLCB0aGlzIHV0aWxpemVzIGFsZ29weS5vcC5FQyBwYWlyaW5nIGFsZ29yaXRobXMgdG8gbWF0aGVtYXRpY2FsbHkgZW5mb3JjZSB0aGUgcHJpdmFjeSBjb21wdXRhdGlvbnMuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InprX3Byb29mIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1YmxpY19pbnB1dHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbnRyYWN0X2luZm8iLCJkZXNjIjoiR2V0IGNvbnRyYWN0IGluZm9ybWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IkNvbnRyYWN0IG5hbWUgYW5kIHZlcnNpb24ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6IkV4YW0gYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDddLCJlcnJvck1lc3NhZ2UiOiJFeGFtIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBaSyBQcm9vZiBieXRlIGRpbWVuc2lvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTJdLCJlcnJvck1lc3NhZ2UiOiJNaXNzaW5nIG1hdGhlbWF0aWNhbCBwdWJsaWMgaW5wdXRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIxXSwiZXJyb3JNZXNzYWdlIjoiVHJ1c3Qgc2NvcmUgY2Fubm90IGV4Y2VlZCAxMDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTVdLCJlcnJvck1lc3NhZ2UiOiJaSy1TTkFSSyBQcm90b2NvbCBWZXJpZmllciBSZWplY3RlZCBQcm9vZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NiwyMTAsMjIzLDI0MywyNTgsMjcwLDI4Myw0MzYsNDQ4LDQ2OCw1MDMsNTE2LDU0Myw1NTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTIsNTI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjMsMjE3LDIyOSwyNDksMjY0LDI3Nyw0NDIsNDU0LDQ3NCw1MTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxLDE3OSwyMzcsNDYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNU0E0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0psZUdGdGN5SWdNSGd3TUNBd2VERTFNV1kzWXpjMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10d1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRTRDaUFnSUNBdkx5QmpiR0Z6Y3lCYVMxQldZWFZzZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEWTRNVGcwWWpFd0lEQjRPREU1WWpjeU1EY2dNSGhrT0dKa09UTTVaaUF3ZUdNNU9UQmpOamxrSURCNE1tVmxaV0ppWWprZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWZlpYaGhiU2h6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZFdKdGFYUmZjSEp2YjJZb2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME5qUXNjM1J5YVc1bkxITjBjbWx1Wnl4aWVYUmxXMTBzZFdsdWREWTBXMTBwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0oyWlhKcFpubGZjM1ZpYldsemMybHZiaWh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4emRISnBibWNwWW05dmJDSXNJRzFsZEdodlpDQWlkbVZ5YVdaNVgzcHJYM051WVhKcktHSjVkR1ZiWFN4MWFXNTBOalJiWFNsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSZlkyOXVkSEpoWTNSZmFXNW1ieWdwYzNSeWFXNW5JZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYMlY0WVcwZ2MzVmliV2wwWDNCeWIyOW1JSFpsY21sbWVWOXpkV0p0YVhOemFXOXVJSFpsY21sbWVWOTZhMTl6Ym1GeWF5QnRZV2x1WDJkbGRGOWpiMjUwY21GamRGOXBibVp2WDNKdmRYUmxRRGtLSUNBZ0lHVnljZ29LYldGcGJsOW5aWFJmWTI5dWRISmhZM1JmYVc1bWIxOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwcmNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01ETXlORGsyWlRjME5qVTJOemN5TmprMFlqWTFOemt5TURjMk16RXlaVE13TWpBeVpESXdOVEEzTWpZNU56WTJNVFl6TnpreVpEVXdOekkyTlRjek5qVTNNamMyTmprMlpUWTNNakEwTVRRNU1qQTFNRGN5Tm1ZMk16YzBObVkzTWpZNU5tVTJOd29nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE9Bb2dJQ0FnTHk4Z1kyeGhjM01nV2t0UVZtRjFiSFFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEYzFNbU16WVdNd0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTVRJS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZZWEJ3YkdsallYUnBiMjVmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXR3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVtdHdYM1poZFd4MExtTnZiblJ5WVdOMExscExVRlpoZFd4MExtTnlaV0YwWlY5bGVHRnRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYMlY0WVcwNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10d1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmEzQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJR3RsZVNBOUlHVjRZVzFmYVdRdWJtRjBhWFpsQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10d1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QmhjM05sY25RZ2EyVjVJRzV2ZENCcGJpQnpaV3htTG1WNFlXMXpMQ0FpUlhoaGJTQmhiSEpsWVdSNUlHVjRhWE4wY3lJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WNFlXMXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVY0WVcwZ1lXeHlaV0ZrZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhM0JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmEzQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZORGN0TlRFS0lDQWdJQzh2SUhObGJHWXVaWGhoYlhOYmEyVjVYU0E5SUVWNFlXMURiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR1IxY21GMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUcxcGJsOXpZMjl5WlFvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXR3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pNMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVtdHdYM1poZFd4MExtTnZiblJ5WVdOMExscExVRlpoZFd4MExuTjFZbTFwZEY5d2NtOXZabHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMVltMXBkRjl3Y205dlpqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmEzQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkQ0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTNCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56WUtJQ0FnSUM4dklHdGxlU0E5SUdWNFlXMWZhV1F1Ym1GMGFYWmxDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk2YTNCZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCclpYa2dhVzRnYzJWc1ppNWxlR0Z0Y3l3Z0lrVjRZVzBnWkc5bGN5QnViM1FnWlhocGMzUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxlR0Z0Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdSWGhoYlNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8zT1MwNE1Bb2dJQ0FnTHk4Z0l5QXhMaUJhU3kxVFRrRlNTeUJXUlZKSlJrbERRVlJKVDA0S0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuWmxjbWxtZVY5NmExOXpibUZ5YXloNmExOXdjbTl2Wml3Z2NIVmliR2xqWDJsdWNIVjBjeWtzSUNKYVN5MVRUa0ZTU3lCUWNtOTBiMk52YkNCV1pYSnBabWxsY2lCU1pXcGxZM1JsWkNCUWNtOXZaaUlLSUNBZ0lHTmhiR3h6ZFdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TG5wcmNGOTJZWFZzZEM1amIyNTBjbUZqZEM1YVMxQldZWFZzZEM1MlpYSnBabmxmZW10ZmMyNWhjbXNLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd0NpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRnBMTFZOT1FWSkxJRkJ5YjNSdlkyOXNJRlpsY21sbWFXVnlJRkpsYW1WamRHVmtJRkJ5YjI5bUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10d1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qZ3lMVGd6Q2lBZ0lDQXZMeUFqSUZabGNtbG1lU0IwY25WemRDQnpZMjl5WlNCcGN5QjJZV3hwWkNBb01DMHhNREFwQ2lBZ0lDQXZMeUJoYzNObGNuUWdkSEoxYzNSZmMyTnZjbVV1Ym1GMGFYWmxJRHc5SUZWSmJuUTJOQ2d4TURBcExDQWlWSEoxYzNRZ2MyTnZjbVVnWTJGdWJtOTBJR1Y0WTJWbFpDQXhNREFpQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZSeWRYTjBJSE5qYjNKbElHTmhibTV2ZENCbGVHTmxaV1FnTVRBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10d1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qZzJMVGc0Q2lBZ0lDQXZMeUFqSUVsbUlIUm9aU0IwY25WemRDQnpZMjl5WlNCcGN5QmxlSFJ5WlcxbGJIa2dhR2xuYUN3Z1lYVjBiMjFoZEdsallXeHNlU0J0YVc1MElHRnVDaUFnSUNBdkx5QWpJRWx1ZEdWbmNtbDBlU0JEWlhKMGFXWnBZMkYwWlNCQlUwRWdkWE5wYm1jZ1lXNGdhVzV1WlhJZ2RISmhibk5oWTNScGIyNHVDaUFnSUNBdkx5QnBaaUIwY25WemRGOXpZMjl5WlM1dVlYUnBkbVVnUGowZ1ZVbHVkRFkwS0Rrd0tUb0tJQ0FnSUhCMWMyaHBiblFnT1RBS0lDQWdJRDQ5Q2lBZ0lDQmllaUJ6ZFdKdGFYUmZjSEp2YjJaZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXR3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnNUxUazVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyNWhiV1U5VTNSeWFXNW5LQ0pKYm5SbFozSnBTMlY1SUMwZ0lpa2dLeUJyWlhrc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQVk4wY21sdVp5Z2lTVXREUlZKVUlpa3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlNU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQxcGNHWnpYMk5wWkM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1jbVZsZW1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z1lYTnpaWFJmYm1GdFpUMVRkSEpwYm1jb0lrbHVkR1ZuY21sTFpYa2dMU0FpS1NBcklHdGxlU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTVzUwWldkeWFVdGxlU0F0SUNJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmEzQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJSFZ5YkQxcGNHWnpYMk5wWkM1dVlYUnBkbVVzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhM0JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXR3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2prMkxUazRDaUFnSUNBdkx5QnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlCbWNtVmxlbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCa2RYQnVJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJEYkdGM1ltRmphd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVp5WldWNlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlZKTUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZW10d1gzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QmtaV05wYldGc2N6MHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNwcmNGOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdkRzkwWVd3OU1Td0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTZhM0JmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQxVGRISnBibWNvSWtsTFEwVlNWQ0lwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pKUzBORlVsUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXR3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnNUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SUdGalptY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM3ByY0Y5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE9TMDVPUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFZOMGNtbHVaeWdpU1c1MFpXZHlhVXRsZVNBdElDSXBJQ3NnYTJWNUxBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFUZEhKcGJtY29Ja2xMUTBWU1ZDSXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQVEVzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOU1Dd0tJQ0FnSUM4dklDQWdJQ0IxY213OWFYQm1jMTlqYVdRdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncHpkV0p0YVhSZmNISnZiMlpmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNV00xTURjeU5tWTJaalkyTWpBM016YzFOakkyWkRZNU56UTNORFkxTmpReU1EY3pOelUyTXpZek5qVTNNemN6TmpZM05UWmpObU0zT1FvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxucHJjRjkyWVhWc2RDNWpiMjUwY21GamRDNWFTMUJXWVhWc2RDNTJaWEpwWm5sZmMzVmliV2x6YzJsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWOXpkV0p0YVhOemFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TURNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWpVS0lDQWdJQzh2SUhSeWRYTjBYM05qYjNKbExtNWhkR2wyWlNBOFBTQlZTVzUwTmpRb01UQXdLU0JoYm1RS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQThQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWpVdE1USTJDaUFnSUNBdkx5QjBjblZ6ZEY5elkyOXlaUzV1WVhScGRtVWdQRDBnVlVsdWREWTBLREV3TUNrZ1lXNWtDaUFnSUNBdkx5QjBjblZ6ZEY5elkyOXlaUzV1WVhScGRtVWdQajBnVlVsdWREWTBLREFwQ2lBZ0lDQmllaUIyWlhKcFpubGZjM1ZpYldsemMybHZibDlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwMlpYSnBabmxmYzNWaWJXbHpjMmx2Ymw5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdHdYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV5T1FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hwYzE5MllXeHBaQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdHdYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AyWlhKcFpubGZjM1ZpYldsemMybHZibDlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUIyWlhKcFpubGZjM1ZpYldsemMybHZibDlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlbXR3WDNaaGRXeDBMbU52Ym5SeVlXTjBMbHBMVUZaaGRXeDBMblpsY21sbWVWOTZhMTl6Ym1GeWExdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblpsY21sbWVWOTZhMTl6Ym1GeWF6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NmEzQmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERZMFBnb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXVlbXR3WDNaaGRXeDBMbU52Ym5SeVlXTjBMbHBMVUZaaGRXeDBMblpsY21sbWVWOTZhMTl6Ym1GeWF3b2dJQ0FnY0c5d2JpQXlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5wcmNGOTJZWFZzZEM1amIyNTBjbUZqZEM1YVMxQldZWFZzZEM1MlpYSnBabmxmZW10ZmMyNWhjbXNvZW10ZmNISnZiMlk2SUdKNWRHVnpMQ0J3ZFdKc2FXTmZhVzV3ZFhSek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6TENCaWVYUmxjem9LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbnByY0Y5MllYVnNkQzVqYjI1MGNtRmpkQzVhUzFCV1lYVnNkQzUyWlhKcFpubGZlbXRmYzI1aGNtczZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVtdHdYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV6TVMweE16WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlIWmxjbWxtZVY5NmExOXpibUZ5YXlnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lIcHJYM0J5YjI5bU9pQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDQWdJQ0J3ZFdKc2FXTmZhVzV3ZFhSek9pQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGxWSmJuUTJORjBLSUNBZ0lDOHZJQ2tnTFQ0Z1lYSmpOQzVDYjI5c09nb2dJQ0FnY0hKdmRHOGdNaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXR3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFME1pMHhORE1LSUNBZ0lDOHZJQ01nVm1Gc2FXUmhkR1VnZEdoaGRDQjBhR1VnWW5sMFpTMWhjbkpoZVNCdFlYUmphR1Z6SUhSNWNHbGpZV3dnV2tzdFUwNUJVa3NnWkdsdFpXNXphVzl1Y3dvZ0lDQWdMeThnWVhOelpYSjBJSHByWDNCeWIyOW1MbXhsYm1kMGFDQStQU0JWU1c1ME5qUW9OalFwTENBaVNXNTJZV3hwWkNCYVN5QlFjbTl2WmlCaWVYUmxJR1JwYldWdWMybHZibk1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ1drc2dVSEp2YjJZZ1lubDBaU0JrYVcxbGJuTnBiMjV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlbXR3WDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFME5TMHhORFlLSUNBZ0lDOHZJQ01nUlc1emRYSmxJSEIxWW14cFl5QnBibkIxZENCamIyNXpkSEpoYVc1MGN5QmxlR2x6ZENBb2RYTjFZV3hzZVNCMGFHVWdkSEoxYzNRZ2MyTnZjbVVnWVc1a0lHVjRZVzBnYUdGemFDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCd2RXSnNhV05mYVc1d2RYUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3dLU3dnSWsxcGMzTnBibWNnYldGMGFHVnRZWFJwWTJGc0lIQjFZbXhwWXlCcGJuQjFkSE1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JoYzNObGNuUWdMeThnVFdsemMybHVaeUJ0WVhSb1pXMWhkR2xqWVd3Z2NIVmliR2xqSUdsdWNIVjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzcHJjRjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBSUJDQ1lEQldWNFlXMXpBUUFFRlI5OGRURVpGRVF4R0VFQWFJSUZCR2dZU3hBRWdadHlCd1RZdlpPZkJNbVF4cDBFTHU2N3VUWWFBSTRGQUU0QWhBRm1BYWtBQVFDQU9CVWZmSFVBTWtsdWRHVm5jbWxMWlhrZ2RqRXVNQ0F0SUZCeWFYWmhZM2t0VUhKbGMyVnlkbWx1WnlCQlNTQlFjbTlqZEc5eWFXNW5zQ1JEZ0FSMUxEckFOaG9BamdFQUFRQWtRellhQVVraVdTTUlTd0VWRWtRMkdnSkpGU1VTUkRZYUEwa1ZKUkpFVHdKWEFnQW9URkJKdlVVQkZFUXhBRThEVUU4Q1VMOGtRellhQVVraVdTTUlTd0VWRWtRMkdnSkpJbGtqQ0V3VkVrUTJHZ05KRlNVU1JEWWFCRWtpV1NNSVRCVVNSRFlhQlVsT0Ewa2lXU01JVEJVU1JEWWFCa2tpV1NNSVN3RVZFa1EyR2dkSklsa2xDeU1JU3dFVkVrUlBBMWNDQUVsT0JDaE1VTDFGQVVTSUFPSkdBaWtUUkJkSmdXUU9SSUZhRDBFQVFMR0FEVWx1ZEdWbmNtbExaWGtnTFNCTEFWQkxBbGNDQURJS1J3T3lMTElyc2lxeUtiSW5JcklqSkxJaWdBWkpTME5GVWxTeUpiSW1nUU95RUNLeUFiT0FJaFVmZkhVQUhGQnliMjltSUhOMVltMXBkSFJsWkNCemRXTmpaWE56Wm5Wc2JIbXdKRU0yR2dGSklsa2pDRXdWRWtRMkdnSkpJbGtqQ0V3VkVrUTJHZ05KRlNVU1JEWWFCRWtpV1NNSVRCVVNSQmVCWkE1QkFBd2tLU0pQQWxRcVRGQ3dKRU1pUXYveE5ob0JTU0paSXdoTEFSVVNSRFlhQWtraVdTVUxJd2hMQVJVU1JJZ0FDRVlDS2t4UXNDUkRpZ0lEaS80aVdZRkFEMFNML3lKWlJJQUJnSXYraS8rSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
