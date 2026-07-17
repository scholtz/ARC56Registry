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

namespace Arc56.Generated.mtank0205.Money_Muling_Detection.AmlRegistry_6cd150d1
{


    //
    // 
    //    Anti-Money Laundering Registry Smart Contract
    //    Stores minimal flags on-chain with IPFS references to detailed data
    //    Privacy-preserving: Uses SHA-256 hashed IDs + stores detailed data on IPFS
    //    
    //
    public class AmlRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AmlRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class WalletRiskProfile : AVMObjectType
            {
                public ulong RiskScore { get; set; }

                public ulong TransactionCount { get; set; }

                public ulong FlaggedConnections { get; set; }

                public ulong LastUpdated { get; set; }

                public ulong IsFlagged { get; set; }

                public ulong IpfsHashLength { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRiskScore.From(RiskScore);
                    ret.AddRange(vRiskScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTransactionCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTransactionCount.From(TransactionCount);
                    ret.AddRange(vTransactionCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlaggedConnections = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFlaggedConnections.From(FlaggedConnections);
                    ret.AddRange(vFlaggedConnections.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdated.From(LastUpdated);
                    ret.AddRange(vLastUpdated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsFlagged = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIsFlagged.From(IsFlagged);
                    ret.AddRange(vIsFlagged.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHashLength = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIpfsHashLength.From(IpfsHashLength);
                    ret.AddRange(vIpfsHashLength.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static WalletRiskProfile Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new WalletRiskProfile();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRiskScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRiskScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRiskScore = vRiskScore.ToValue();
                    if (valueRiskScore is ulong vRiskScoreValue) { ret.RiskScore = vRiskScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTransactionCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTransactionCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTransactionCount = vTransactionCount.ToValue();
                    if (valueTransactionCount is ulong vTransactionCountValue) { ret.TransactionCount = vTransactionCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFlaggedConnections = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFlaggedConnections.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFlaggedConnections = vFlaggedConnections.ToValue();
                    if (valueFlaggedConnections is ulong vFlaggedConnectionsValue) { ret.FlaggedConnections = vFlaggedConnectionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdated = vLastUpdated.ToValue();
                    if (valueLastUpdated is ulong vLastUpdatedValue) { ret.LastUpdated = vLastUpdatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsFlagged = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIsFlagged.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsFlagged = vIsFlagged.ToValue();
                    if (valueIsFlagged is ulong vIsFlaggedValue) { ret.IsFlagged = vIsFlaggedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHashLength = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIpfsHashLength.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIpfsHashLength = vIpfsHashLength.ToValue();
                    if (valueIpfsHashLength is ulong vIpfsHashLengthValue) { ret.IpfsHashLength = vIpfsHashLengthValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as WalletRiskProfile);
                }
                public bool Equals(WalletRiskProfile? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(WalletRiskProfile left, WalletRiskProfile right)
                {
                    return EqualityComparer<WalletRiskProfile>.Default.Equals(left, right);
                }
                public static bool operator !=(WalletRiskProfile left, WalletRiskProfile right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Register a new wallet with its risk profile and IPFS pointer
        ///</summary>
        /// <param name="hashed_id">SHA-256 hash of the account ID (or salted PAN) </param>
        /// <param name="risk_score">0-100 risk score </param>
        /// <param name="transaction_count">Number of transactions </param>
        /// <param name="flagged_connections">Number of flagged connections </param>
        /// <param name="ipfs_hash">IPFS hash (CID) pointing to detailed mule data </param>
        public async Task<string> RegisterWallet(byte[] hashed_id, ulong risk_score, ulong transaction_count, ulong flagged_connections, string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 67, 168, 25 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var transaction_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); transaction_countAbi.From(transaction_count);
            var flagged_connectionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); flagged_connectionsAbi.From(flagged_connections);
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            var result = await base.CallApp(new List<object> { abiHandle, hashed_idAbi, risk_scoreAbi, transaction_countAbi, flagged_connectionsAbi, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RegisterWallet_Transactions(byte[] hashed_id, ulong risk_score, ulong transaction_count, ulong flagged_connections, string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 67, 168, 25 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var transaction_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); transaction_countAbi.From(transaction_count);
            var flagged_connectionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); flagged_connectionsAbi.From(flagged_connections);
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashed_idAbi, risk_scoreAbi, transaction_countAbi, flagged_connectionsAbi, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update risk score for an existing wallet
        ///</summary>
        /// <param name="hashed_id"> </param>
        /// <param name="new_risk_score"> </param>
        public async Task<string> UpdateRiskScore(byte[] hashed_id, ulong new_risk_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 189, 206, 48 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);
            var new_risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_risk_scoreAbi.From(new_risk_score);

            var result = await base.CallApp(new List<object> { abiHandle, hashed_idAbi, new_risk_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateRiskScore_Transactions(byte[] hashed_id, ulong new_risk_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 189, 206, 48 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);
            var new_risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_risk_scoreAbi.From(new_risk_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashed_idAbi, new_risk_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve risk profile for a wallet by its hashed ID
        ///</summary>
        /// <param name="hashed_id"> </param>
        public async Task<Structs.WalletRiskProfile> GetRiskProfile(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 246, 192, 74 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            var result = await base.CallApp(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.WalletRiskProfile.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRiskProfile_Transactions(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 246, 192, 74 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve IPFS hash (CID) for detailed mule data
        ///Returns the IPFS hash where full transaction history and analysis are stored Frontend can fetch this to display graph visualizations
        ///</summary>
        /// <param name="hashed_id"> </param>
        public async Task<string> GetIpfsHash(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 129, 173, 135 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            var result = await base.CallApp(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetIpfsHash_Transactions(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 129, 173, 135 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Manually flag a wallet for suspicious activity
        ///</summary>
        /// <param name="hashed_id"> </param>
        public async Task<string> FlagWallet(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 31, 99, 253 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            var result = await base.CallApp(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> FlagWallet_Transactions(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 31, 99, 253 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a wallet is flagged (returns 1 for true, 0 for false)
        ///Used by Bank B to screen new customers
        ///</summary>
        /// <param name="hashed_id"> </param>
        public async Task<ulong> IsWalletFlagged(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 211, 126, 67 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            var result = await base.CallApp(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsWalletFlagged_Transactions(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 211, 126, 67 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get just the risk score for a wallet (0-100)
        ///</summary>
        /// <param name="hashed_id"> </param>
        public async Task<ulong> GetRiskScore(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 133, 141, 160 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            var result = await base.CallApp(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRiskScore_Transactions(byte[] hashed_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 133, 141, 160 };
            var hashed_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hashed_idAbi.From(hashed_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, hashed_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Simple hello method for testing
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQW1sUmVnaXN0cnkiLCJkZXNjIjoiXG4gICAgQW50aS1Nb25leSBMYXVuZGVyaW5nIFJlZ2lzdHJ5IFNtYXJ0IENvbnRyYWN0XG4gICAgU3RvcmVzIG1pbmltYWwgZmxhZ3Mgb24tY2hhaW4gd2l0aCBJUEZTIHJlZmVyZW5jZXMgdG8gZGV0YWlsZWQgZGF0YVxuICAgIFByaXZhY3ktcHJlc2VydmluZzogVXNlcyBTSEEtMjU2IGhhc2hlZCBJRHMgKyBzdG9yZXMgZGV0YWlsZWQgZGF0YSBvbiBJUEZTXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IldhbGxldFJpc2tQcm9maWxlIjpbeyJuYW1lIjoicmlza19zY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0cmFuc2FjdGlvbl9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmbGFnZ2VkX2Nvbm5lY3Rpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RfdXBkYXRlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc19mbGFnZ2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlwZnNfaGFzaF9sZW5ndGgiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InJlZ2lzdGVyX3dhbGxldCIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyB3YWxsZXQgd2l0aCBpdHMgcmlzayBwcm9maWxlIGFuZCBJUEZTIHBvaW50ZXIiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGFzaGVkX2lkIiwiZGVzYyI6IlNIQS0yNTYgaGFzaCBvZiB0aGUgYWNjb3VudCBJRCAob3Igc2FsdGVkIFBBTikiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJpc2tfc2NvcmUiLCJkZXNjIjoiMC0xMDAgcmlzayBzY29yZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJhbnNhY3Rpb25fY291bnQiLCJkZXNjIjoiTnVtYmVyIG9mIHRyYW5zYWN0aW9ucyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmxhZ2dlZF9jb25uZWN0aW9ucyIsImRlc2MiOiJOdW1iZXIgb2YgZmxhZ2dlZCBjb25uZWN0aW9ucyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBmc19oYXNoIiwiZGVzYyI6IklQRlMgaGFzaCAoQ0lEKSBwb2ludGluZyB0byBkZXRhaWxlZCBtdWxlIGRhdGEiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfcmlza19zY29yZSIsImRlc2MiOiJVcGRhdGUgcmlzayBzY29yZSBmb3IgYW4gZXhpc3Rpbmcgd2FsbGV0IiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imhhc2hlZF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3Jpc2tfc2NvcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmlza19wcm9maWxlIiwiZGVzYyI6IlJldHJpZXZlIHJpc2sgcHJvZmlsZSBmb3IgYSB3YWxsZXQgYnkgaXRzIGhhc2hlZCBJRCIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJoYXNoZWRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IldhbGxldFJpc2tQcm9maWxlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2lwZnNfaGFzaCIsImRlc2MiOiJSZXRyaWV2ZSBJUEZTIGhhc2ggKENJRCkgZm9yIGRldGFpbGVkIG11bGUgZGF0YVxuUmV0dXJucyB0aGUgSVBGUyBoYXNoIHdoZXJlIGZ1bGwgdHJhbnNhY3Rpb24gaGlzdG9yeSBhbmQgYW5hbHlzaXMgYXJlIHN0b3JlZCBGcm9udGVuZCBjYW4gZmV0Y2ggdGhpcyB0byBkaXNwbGF5IGdyYXBoIHZpc3VhbGl6YXRpb25zIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imhhc2hlZF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZsYWdfd2FsbGV0IiwiZGVzYyI6Ik1hbnVhbGx5IGZsYWcgYSB3YWxsZXQgZm9yIHN1c3BpY2lvdXMgYWN0aXZpdHkiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGFzaGVkX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfd2FsbGV0X2ZsYWdnZWQiLCJkZXNjIjoiQ2hlY2sgaWYgYSB3YWxsZXQgaXMgZmxhZ2dlZCAocmV0dXJucyAxIGZvciB0cnVlLCAwIGZvciBmYWxzZSlcblVzZWQgYnkgQmFuayBCIHRvIHNjcmVlbiBuZXcgY3VzdG9tZXJzIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imhhc2hlZF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9yaXNrX3Njb3JlIiwiZGVzYyI6IkdldCBqdXN0IHRoZSByaXNrIHNjb3JlIGZvciBhIHdhbGxldCAoMC0xMDApIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imhhc2hlZF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImhlbGxvIiwiZGVzYyI6IlNpbXBsZSBoZWxsbyBtZXRob2QgZm9yIHRlc3RpbmciLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY4LDMxMl0sImVycm9yTWVzc2FnZSI6IlJpc2sgc2NvcmUgbXVzdCBiZSBiZXR3ZWVuIDAgYW5kIDEwMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwOSwxNTIsMjg3LDM2OCwzOTIsNDI2LDUxMiw1MzksNTY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE2LDE1OSwyOTQsMzc1LDM5OSw0MzMsNTE5LDU0Niw1NzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI3LDEzNiwxNDUsMzA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdNU0E0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnTUhnMVpqWTVOekEyTmpjekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxc1gzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUxQ2lBZ0lDQXZMeUJqYkdGemN5QkJiV3hTWldkcGMzUnllU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1JoTkROaE9ERTVJREI0TlRSaVpHTmxNekFnTUhnMVlXWTJZekEwWVNBd2VHUXhPREZoWkRnM0lEQjRZamt4WmpZelptUWdNSGcwTVdRek4yVTBNeUF3ZUdNNE9EVTRaR0V3SURCNE1ESmlaV05sTVRFZ0x5OGdiV1YwYUc5a0lDSnlaV2RwYzNSbGNsOTNZV3hzWlhRb1lubDBaVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjl5YVhOclgzTmpiM0psS0dKNWRHVmJYU3gxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJmY21semExOXdjbTltYVd4bEtHSjVkR1ZiWFNrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUmZhWEJtYzE5b1lYTm9LR0o1ZEdWYlhTbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltWnNZV2RmZDJGc2JHVjBLR0o1ZEdWYlhTbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltbHpYM2RoYkd4bGRGOW1iR0ZuWjJWa0tHSjVkR1ZiWFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOXlhWE5yWDNOamIzSmxLR0o1ZEdWYlhTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltaGxiR3h2S0hOMGNtbHVaeWx6ZEhKcGJtY2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J5WldkcGMzUmxjbDkzWVd4c1pYUWdkWEJrWVhSbFgzSnBjMnRmYzJOdmNtVWdaMlYwWDNKcGMydGZjSEp2Wm1sc1pTQm5aWFJmYVhCbWMxOW9ZWE5vSUdac1lXZGZkMkZzYkdWMElHbHpYM2RoYkd4bGRGOW1iR0ZuWjJWa0lHZGxkRjl5YVhOclgzTmpiM0psSUdobGJHeHZDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRVNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYld4ZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXMXNVbVZuYVhOMGNua3VjbVZuYVhOMFpYSmZkMkZzYkdWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSmZkMkZzYkdWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUTBMVFExQ2lBZ0lDQXZMeUFqSUZaaGJHbGtZWFJsSUhKcGMyc2djMk52Y21VZ2FYTWdhVzRnY21GdVoyVUtJQ0FnSUM4dklHRnpjMlZ5ZENCeWFYTnJYM05qYjNKbElEdzlJREV3TUN3Z0lsSnBjMnNnYzJOdmNtVWdiWFZ6ZENCaVpTQmlaWFIzWldWdUlEQWdZVzVrSURFd01DSUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURFd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJTYVhOcklITmpiM0psSUcxMWMzUWdZbVVnWW1WMGQyVmxiaUF3SUdGdVpDQXhNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiV3hmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EY3RORGdLSUNBZ0lDOHZJQ01nUTNKbFlYUmxJSGRoYkd4bGRDQnlhWE5ySUhCeWIyWnBiR1VLSUNBZ0lDOHZJR2x6WDJac1lXZG5aV1JmZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tnYVdZZ2NtbHphMTl6WTI5eVpTQStQU0EzTUNCbGJITmxJRlZKYm5RMk5DZ3dLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ056QUtJQ0FnSUQ0OUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxc1gzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJzWVhOMFgzVndaR0YwWldROVIyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QnBjR1p6WDJoaGMyaGZiR1Z1WjNSb1BXbHdabk5mYUdGemFDNWllWFJsY3k1c1pXNW5kR2dzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVXdMVFUzQ2lBZ0lDQXZMeUJ3Y205bWFXeGxJRDBnVjJGc2JHVjBVbWx6YTFCeWIyWnBiR1VvQ2lBZ0lDQXZMeUFnSUNBZ2NtbHphMTl6WTI5eVpUMXlhWE5yWDNOamIzSmxMQW9nSUNBZ0x5OGdJQ0FnSUhSeVlXNXpZV04wYVc5dVgyTnZkVzUwUFhSeVlXNXpZV04wYVc5dVgyTnZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWnNZV2RuWldSZlkyOXVibVZqZEdsdmJuTTlabXhoWjJkbFpGOWpiMjV1WldOMGFXOXVjeXdLSUNBZ0lDOHZJQ0FnSUNCc1lYTjBYM1Z3WkdGMFpXUTlSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBc0NpQWdJQ0F2THlBZ0lDQWdhWE5mWm14aFoyZGxaRDFwYzE5bWJHRm5aMlZrWDNaaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdsd1puTmZhR0Z6YUY5c1pXNW5kR2c5YVhCbWMxOW9ZWE5vTG1KNWRHVnpMbXhsYm1kMGFDd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8xT1MwMk1Bb2dJQ0FnTHk4Z0l5QlRkRzl5WlNCd2NtOW1hV3hsSUdsdUlHSnZlQ0J6ZEc5eVlXZGxJQ2hyWlhrNklHaGhjMmhsWkY5cFpDa0tJQ0FnSUM4dklHOXdMa0p2ZUM1d2RYUW9hR0Z6YUdWa1gybGtMQ0J3Y205bWFXeGxMbUo1ZEdWektRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiV3hmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qSXROak1LSUNBZ0lDOHZJQ01nVTNSdmNtVWdTVkJHVXlCb1lYTm9JR2x1SUdFZ2MyVndZWEpoZEdVZ1ltOTRJQ2hyWlhrNklHaGhjMmhsWkY5cFpDQXJJQ0pmYVhCbWN5SXBDaUFnSUNBdkx5QnBjR1p6WDJ0bGVTQTlJRzl3TG1OdmJtTmhkQ2hvWVhOb1pXUmZhV1FzSUVKNWRHVnpLR0lpWDJsd1puTWlLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcxWmpZNU56QTJOamN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYld4ZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJRzl3TGtKdmVDNXdkWFFvYVhCbWMxOXJaWGtzSUdsd1puTmZhR0Z6YUM1aWVYUmxjeWtLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYld4ZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNaklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREF6WkRVM05qRTJZelpqTmpVM05ESXdOalkyWXpZeE5qYzJOelkxTmpReU1ESmtNakExTXpabU56VTJZekl3TkRJMlpqYzFObVUyTkRJd05UUTJaalppTmpVMlpUSXdOak0zTWpZMU5qRTNORFkxTmpReU1EYzNOamszTkRZNE1qQTBPVFV3TkRZMU16SXdOekkyTlRZMk5qVTNNalkxTm1VMk16WTFDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVcxc1gzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrRnRiRkpsWjJsemRISjVMblZ3WkdGMFpWOXlhWE5yWDNOamIzSmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYM0pwYzJ0ZmMyTnZjbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxc1gzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJoYzNObGNuUWdibVYzWDNKcGMydGZjMk52Y21VZ1BEMGdNVEF3TENBaVVtbHpheUJ6WTI5eVpTQnRkWE4wSUdKbElHSmxkSGRsWlc0Z01DQmhibVFnTVRBd0lnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNhWE5ySUhOamIzSmxJRzExYzNRZ1ltVWdZbVYwZDJWbGJpQXdJR0Z1WkNBeE1EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXeGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnprdE9EQUtJQ0FnSUM4dklDTWdVbVYwY21sbGRtVWdaWGhwYzNScGJtY2djSEp2Wm1sc1pRb2dJQ0FnTHk4Z2NISnZabWxzWlY5aWVYUmxjeXdnWDJWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb2FHRnphR1ZrWDJsa0tRb2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE15MDROQW9nSUNBZ0x5OGdJeUJWY0dSaGRHVWdjbWx6YXlCelkyOXlaU0JoYm1RZ1pteGhaeUJ6ZEdGMGRYTUtJQ0FnSUM4dklIQnliMlpwYkdVdWNtbHphMTl6WTI5eVpTQTlJRzVsZDE5eWFYTnJYM05qYjNKbENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXeGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUhCeWIyWnBiR1V1YVhOZlpteGhaMmRsWkNBOUlGVkpiblEyTkNneEtTQnBaaUJ1WlhkZmNtbHphMTl6WTI5eVpTQStQU0EzTUNCbGJITmxJRlZKYm5RMk5DZ3dLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBM01Bb2dJQ0FnUGowS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRE15Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QndjbTltYVd4bExteGhjM1JmZFhCa1lYUmxaQ0E5SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBeU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG80T0MwNE9Rb2dJQ0FnTHk4Z0l5QlRZWFpsSUhWd1pHRjBaV1FnY0hKdlptbHNaUW9nSUNBZ0x5OGdiM0F1UW05NExuQjFkQ2hvWVhOb1pXUmZhV1FzSUhCeWIyWnBiR1V1WW5sMFpYTXBDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNVEkxTWpZNU56TTJZakl3TnpNMk16Wm1OekkyTlRJd056VTNNRFkwTmpFM05EWTFOalFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJXeGZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRVzFzVW1WbmFYTjBjbmt1WjJWMFgzSnBjMnRmY0hKdlptbHNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXlhWE5yWDNCeWIyWnBiR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YkY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdjSEp2Wm1sc1pWOWllWFJsY3l3Z1gyVjRhWE4wY3lBOUlHOXdMa0p2ZUM1blpYUW9hR0Z6YUdWa1gybGtLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GdGJGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUJiV3hTWldkcGMzUnllUzVuWlhSZmFYQm1jMTlvWVhOb1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJsd1puTmZhR0Z6YURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYld4ZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUdsd1puTmZhMlY1SUQwZ2IzQXVZMjl1WTJGMEtHaGhjMmhsWkY5cFpDd2dRbmwwWlhNb1lpSmZhWEJtY3lJcEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEVm1OamszTURZMk56TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1UQUtJQ0FnSUM4dklHbHdabk5mYUdGemFGOWllWFJsY3l3Z1gyVjRhWE4wY3lBOUlHOXdMa0p2ZUM1blpYUW9hWEJtYzE5clpYa3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiV3hmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYld4ZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXMXNVbVZuYVhOMGNua3VabXhoWjE5M1lXeHNaWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWJHRm5YM2RoYkd4bGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXeGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXNYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeE9Bb2dJQ0FnTHk4Z2NISnZabWxzWlY5aWVYUmxjeXdnWDJWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb2FHRnphR1ZrWDJsa0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXNYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU1TMHhNaklLSUNBZ0lDOHZJQ01nVTJWMElHWnNZV2NnZEc4Z2RISjFaUW9nSUNBZ0x5OGdjSEp2Wm1sc1pTNXBjMTltYkdGbloyVmtJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ016SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXeGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCd2NtOW1hV3hsTG14aGMzUmZkWEJrWVhSbFpDQTlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF5TkFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzFzWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXlOUzB4TWpZS0lDQWdJQzh2SUNNZ1NXWWdibTkwSUdGc2NtVmhaSGtnYUdsbmFDQnlhWE5yTENCelpYUWdkRzhnTnpBZ0tHWnNZV2RuWldRZ2RHaHlaWE5vYjJ4a0tRb2dJQ0FnTHk4Z2FXWWdjSEp2Wm1sc1pTNXlhWE5yWDNOamIzSmxJRHdnTnpBNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdOekFLSUNBZ0lEd0tJQ0FnSUdKNklHWnNZV2RmZDJGc2JHVjBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUhCeWIyWnBiR1V1Y21semExOXpZMjl5WlNBOUlGVkpiblEyTkNnM01Da0tJQ0FnSUhCMWMyaHBiblFnTnpBS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREFLQ21ac1lXZGZkMkZzYkdWMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYld4ZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEk1Q2lBZ0lDQXZMeUJ2Y0M1Q2IzZ3VjSFYwS0doaGMyaGxaRjlwWkN3Z2NISnZabWxzWlM1aWVYUmxjeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxc1gzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURGa05UYzJNVFpqTm1NMk5UYzBNakEyTmpaak5qRTJOelkzTmpVMk5ESXdOalkyWmpjeU1qQTBNVFJrTkdNeU1EY3lOalUzTmpZNU5qVTNOd29nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GdGJGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUJiV3hTWldkcGMzUnllUzVwYzE5M1lXeHNaWFJmWm14aFoyZGxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selgzZGhiR3hsZEY5bWJHRm5aMlZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YkY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxc1gzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV6T1FvZ0lDQWdMeThnY0hKdlptbHNaVjlpZVhSbGN5d2dYMlY0YVhOMGN5QTlJRzl3TGtKdmVDNW5aWFFvYUdGemFHVmtYMmxrS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxc1gzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUwTVFvZ0lDQWdMeThnY21WMGRYSnVJSEJ5YjJacGJHVXVhWE5mWm14aFoyZGxaQW9nSUNBZ1pYaDBjbUZqZENBek1pQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXNYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYld4ZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXMXNVbVZuYVhOMGNua3VaMlYwWDNKcGMydGZjMk52Y21WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmY21semExOXpZMjl5WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYld4ZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFF6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUhCeWIyWnBiR1ZmWW5sMFpYTXNJRjlsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0doaGMyaGxaRjlwWkNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUhKbGRIVnliaUJ3Y205bWFXeGxMbkpwYzJ0ZmMyTnZjbVVLSUNBZ0lHVjRkSEpoWTNRZ01DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXNYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoYld4ZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXMXNVbVZuYVhOMGNua3VhR1ZzYkc5YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG9aV3hzYnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYld4ZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRjS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29Ja2hsYkd4dkxDQWlLU0FySUc1aGJXVUtJQ0FnSUhCMWMyaGllWFJsY3lBaVNHVnNiRzhzSUNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUlCQ0NZQ0JCVWZmSFVGWDJsd1puTXhHMEVBUnpFWkZFUXhHRVNDQ0FUYVE2Z1pCRlM5empBRVd2YkFTZ1RSZ2EySEJMa2ZZLzBFUWROK1F3VEloWTJnQkFLK3poRTJHZ0NPQ0FBSkFMc0JEQUVrQVVZQm5BRzNBZElBTVJrVU1SZ1VFRU0yR2dGSklsa2pDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUVhOaG9EU1JVbEVrUVhOaG9FU1JVbEVrUVhOaG9GU1NKWkl3aExBUlVTUkZjQ0FFc0RnV1FPUkVzRGdVWVBNZ2RMQWhWUEJoWlBCaFpRVHdVV1VFOENGbEJQQWhaUVRCWlFTd0pNdjB3cFVFeS9nRU1WSDN4MUFEMVhZV3hzWlhRZ1pteGhaMmRsWkNBdElGTnZkV3dnUW05MWJtUWdWRzlyWlc0Z1kzSmxZWFJsWkNCM2FYUm9JRWxRUmxNZ2NtVm1aWEpsYm1ObHNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FEWWFBa2tWSlJKRVNSZEpnV1FPUkVzQ3ZraFBBbHdBVElGR0R4WmNJRElIRmx3WXY0QVlGUjk4ZFFBU1VtbHpheUJ6WTI5eVpTQjFjR1JoZEdWa3NDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FMNUlLRXhRc0NSRE5ob0JTU0paSXdoTEFSVVNSRmNDQUNsUXZraEpGUlpYQmdKTVVDaE1VTEFrUXpZYUFVa2lXU01JU3dFVkVrUlhBZ0JKdmtna0Zsd2dNZ2NXWEJoSklsdUJSZ3hCQUFXQlJoWmNBRXNCVEwrQUl4VWZmSFVBSFZkaGJHeGxkQ0JtYkdGbloyVmtJR1p2Y2lCQlRVd2djbVYyYVdWM3NDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FMNUlWeUFJS0V4UXNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FMNUlWd0FJS0V4UXNDUkROaG9CU1NKWkl3aExBUlVTUkZjQ0FJQUhTR1ZzYkc4c0lFeFFTUlVXVndZQ1RGQW9URkN3SkVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
