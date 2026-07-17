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

namespace Arc56.Generated.AdityaWagh19.Credencia.KYCRegistry_efe06b61
{


    //
    // 
    //    On-chain KYC status registry.
    //
    //    Access control:
    //        - register / update_tier: oracle only
    //        - revoke: admin only
    //        - is_verified / get_record: anyone (read-only)
    //    
    //
    public class KYCRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public KYCRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class KycRecord : AVMObjectType
            {
                public byte KycTier { get; set; }

                public byte Role { get; set; }

                public ulong VerifiedAt { get; set; }

                public byte[] KycHash { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKycTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vKycTier.From(KycTier);
                    ret.AddRange(vKycTier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vRole.From(Role);
                    ret.AddRange(vRole.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifiedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVerifiedAt.From(VerifiedAt);
                    ret.AddRange(vVerifiedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKycHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vKycHash.From(KycHash);
                    ret.AddRange(vKycHash.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static KycRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new KycRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKycTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vKycTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueKycTier = vKycTier.ToValue();
                    if (valueKycTier is byte vKycTierValue) { ret.KycTier = vKycTierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRole = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vRole.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRole = vRole.ToValue();
                    if (valueRole is byte vRoleValue) { ret.Role = vRoleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifiedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVerifiedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifiedAt = vVerifiedAt.ToValue();
                    if (valueVerifiedAt is ulong vVerifiedAtValue) { ret.VerifiedAt = vVerifiedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKycHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vKycHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueKycHash = vKycHash.ToValue();
                    if (valueKycHash is byte[] vKycHashValue) { ret.KycHash = vKycHashValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as KycRecord);
                }
                public bool Equals(KycRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(KycRecord left, KycRecord right)
                {
                    return EqualityComparer<KycRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(KycRecord left, KycRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the contract. Called once at deployment.
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="oracle"> </param>
        public async Task Create(Algorand.Address admin, Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address admin, Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register or update a KYC record. Oracle-only.
        ///The caller must include a payment transaction covering the box MBR if this is a new registration (box doesn't exist yet).
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="role"> </param>
        /// <param name="kyc_hash"> </param>
        public async Task Register(Algorand.Address address, byte role, byte[] kyc_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 87, 5, 71 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); roleAbi.From(role);
            var kyc_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); kyc_hashAbi.From(kyc_hash);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi, roleAbi, kyc_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(Algorand.Address address, byte role, byte[] kyc_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 87, 5, 71 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); roleAbi.From(role);
            var kyc_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); kyc_hashAbi.From(kyc_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, roleAbi, kyc_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Upgrade KYC tier (e.g., basic → enhanced). Oracle-only.
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="new_tier"> </param>
        public async Task UpdateTier(Algorand.Address address, byte new_tier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 239, 180, 201 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var new_tierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); new_tierAbi.From(new_tier);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi, new_tierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateTier_Transactions(Algorand.Address address, byte new_tier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 239, 180, 201 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var new_tierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); new_tierAbi.From(new_tier);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, new_tierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke KYC for an address. Admin-only.
        ///</summary>
        /// <param name="address"> </param>
        public async Task Revoke(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 131, 21, 151 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Revoke_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 131, 21, 151 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the oracle address. Admin-only.
        ///</summary>
        /// <param name="new_oracle"> </param>
        public async Task SetOracle(Algorand.Address new_oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var new_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_oracleAbi.From(new_oracle);

            var result = await base.CallApp(new List<object> { abiHandle, new_oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOracle_Transactions(Algorand.Address new_oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var new_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_oracleAbi.From(new_oracle);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if an address has a valid KYC record.
        ///</summary>
        /// <param name="address"> </param>
        public async Task<bool> IsVerified(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 97, 71, 252 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsVerified_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 97, 71, 252 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the full KYC record for an address. Reverts if not found.
        ///</summary>
        /// <param name="address"> </param>
        public async Task<Structs.KycRecord> GetRecord(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 133, 4, 114 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.KycRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRecord_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 133, 4, 114 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the role for an address. Returns 0 if not registered.
        ///</summary>
        /// <param name="address"> </param>
        public async Task<byte> GetRole(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 221, 95, 223 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> GetRole_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 221, 95, 223 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the total number of verified accounts.
        ///</summary>
        public async Task<ulong> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 235, 41, 54 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 235, 41, 54 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS1lDUmVnaXN0cnkiLCJkZXNjIjoiXG4gICAgT24tY2hhaW4gS1lDIHN0YXR1cyByZWdpc3RyeS5cblxuICAgIEFjY2VzcyBjb250cm9sOlxuICAgICAgICAtIHJlZ2lzdGVyIC8gdXBkYXRlX3RpZXI6IG9yYWNsZSBvbmx5XG4gICAgICAgIC0gcmV2b2tlOiBhZG1pbiBvbmx5XG4gICAgICAgIC0gaXNfdmVyaWZpZWQgLyBnZXRfcmVjb3JkOiBhbnlvbmUgKHJlYWQtb25seSlcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiS1lDUmVjb3JkIjpbeyJuYW1lIjoia3ljX3RpZXIiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJyb2xlIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoidmVyaWZpZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoia3ljX2hhc2giLCJ0eXBlIjoiYnl0ZVszMl0ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGNvbnRyYWN0LiBDYWxsZWQgb25jZSBhdCBkZXBsb3ltZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmFjbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjoiUmVnaXN0ZXIgb3IgdXBkYXRlIGEgS1lDIHJlY29yZC4gT3JhY2xlLW9ubHkuXG5UaGUgY2FsbGVyIG11c3QgaW5jbHVkZSBhIHBheW1lbnQgdHJhbnNhY3Rpb24gY292ZXJpbmcgdGhlIGJveCBNQlIgaWYgdGhpcyBpcyBhIG5ldyByZWdpc3RyYXRpb24gKGJveCBkb2Vzbid0IGV4aXN0IHlldCkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoia3ljX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3RpZXIiLCJkZXNjIjoiVXBncmFkZSBLWUMgdGllciAoZS5nLiwgYmFzaWMg4oaSIGVuaGFuY2VkKS4gT3JhY2xlLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld190aWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZSIsImRlc2MiOiJSZXZva2UgS1lDIGZvciBhbiBhZGRyZXNzLiBBZG1pbi1vbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfb3JhY2xlIiwiZGVzYyI6IlVwZGF0ZSB0aGUgb3JhY2xlIGFkZHJlc3MuIEFkbWluLW9ubHkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3JhY2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX3ZlcmlmaWVkIiwiZGVzYyI6IkNoZWNrIGlmIGFuIGFkZHJlc3MgaGFzIGEgdmFsaWQgS1lDIHJlY29yZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVjb3JkIiwiZGVzYyI6IkdldCB0aGUgZnVsbCBLWUMgcmVjb3JkIGZvciBhbiBhZGRyZXNzLiBSZXZlcnRzIGlmIG5vdCBmb3VuZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ4LHVpbnQ2NCxieXRlWzMyXSkiLCJzdHJ1Y3QiOiJLWUNSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9yb2xlIiwiZGVzYyI6IkdldCB0aGUgcm9sZSBmb3IgYW4gYWRkcmVzcy4gUmV0dXJucyAwIGlmIG5vdCByZWdpc3RlcmVkLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdHMiLCJkZXNjIjoiUmV0dXJuIHRoZSB0b3RhbCBudW1iZXIgb2YgdmVyaWZpZWQgYWNjb3VudHMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI4NywzMTgsMzk2XSwiZXJyb3JNZXNzYWdlIjoiYWRkcmVzcyBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOCwzNDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NCwyNzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9yYWNsZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlY29yZHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQzLDMyNCw0NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3ZlcmlmaWVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDAsMTQ4LDE2OSwxODgsMjYyLDMwMSwzMzksMzYxLDM4OCw0MTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc4LDI3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCByb2xlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEwXSwiZXJyb3JNZXNzYWdlIjoib25seSBhZG1pbiBjYW4gcmV2b2tlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ4XSwiZXJyb3JNZXNzYWdlIjoib25seSBhZG1pbiBjYW4gc2V0IG9yYWNsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5Nl0sImVycm9yTWVzc2FnZSI6Im9ubHkgb3JhY2xlIGNhbiByZWdpc3RlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OF0sImVycm9yTWVzc2FnZSI6Im9ubHkgb3JhY2xlIGNhbiB1cGRhdGUgdGllciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnSW5SdmRHRnNYM1psY21sbWFXVmtJaUF3ZURaaU56azJNelZtSUNKdmNtRmpiR1VpSURCNE1UVXhaamRqTnpVZ0ltRmtiV2x1SWdvZ0lDQWdMeThnWTJGa1pXNWphV0V2YTNsalgzSmxaMmx6ZEhKNUxuQjVPalUxQ2lBZ0lDQXZMeUJqYkdGemN5QkxXVU5TWldkcGMzUnllU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TkFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZM05UY3dOVFEzSURCNE1ESmxabUkwWXprZ01IZ3lNemd6TVRVNU55QXdlRE16TmpobU5UVTJJREI0TXpZMk1UUTNabU1nTUhnek5qZzFNRFEzTWlBd2VERTNaR1ExWm1SbUlEQjRaakpsWWpJNU16WWdMeThnYldWMGFHOWtJQ0p5WldkcGMzUmxjaWhoWkdSeVpYTnpMSFZwYm5RNExHSjVkR1ZiTXpKZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjkwYVdWeUtHRmtaSEpsYzNNc2RXbHVkRGdwZG05cFpDSXNJRzFsZEdodlpDQWljbVYyYjJ0bEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFgyOXlZV05zWlNoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWx6WDNabGNtbG1hV1ZrS0dGa1pISmxjM01wWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwWDNKbFkyOXlaQ2hoWkdSeVpYTnpLU2gxYVc1ME9DeDFhVzUwT0N4MWFXNTBOalFzWW5sMFpWc3pNbDBwSWl3Z2JXVjBhRzlrSUNKblpYUmZjbTlzWlNoaFpHUnlaWE56S1hWcGJuUTRJaXdnYldWMGFHOWtJQ0puWlhSZmMzUmhkSE1vS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhKbFoybHpkR1Z5SUhWd1pHRjBaVjkwYVdWeUlISmxkbTlyWlNCelpYUmZiM0poWTJ4bElHbHpYM1psY21sbWFXVmtJR2RsZEY5eVpXTnZjbVFnWjJWMFgzSnZiR1VnWjJWMFgzTjBZWFJ6Q2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRRNkNpQWdJQ0F2THlCallXUmxibU5wWVM5cmVXTmZjbVZuYVhOMGNua3VjSGs2TlRVS0lDQWdJQzh2SUdOc1lYTnpJRXRaUTFKbFoybHpkSEo1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRZVGsyT1Rnd1pTQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpTaGhaR1J5WlhOekxHRmtaSEpsYzNNcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaUW9nSUNBZ1pYSnlDZ29LTHk4Z1kyRmtaVzVqYVdFdWEzbGpYM0psWjJsemRISjVMa3RaUTFKbFoybHpkSEo1TG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUbzNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTJGa1pXNWphV0V2YTNsalgzSmxaMmx6ZEhKNUxuQjVPamd3Q2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1TG5aaGJIVmxJRDBnWVdSdGFXNEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZhM2xqWDNKbFoybHpkSEo1TG5CNU9qZ3hDaUFnSUNBdkx5QnpaV3htTG05eVlXTnNaUzUyWVd4MVpTQTlJRzl5WVdOc1pRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWIzSmhZMnhsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJ0NVkxOXlaV2RwYzNSeWVTNXdlVG80TWdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5MlpYSnBabWxsWkM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZkbVZ5YVdacFpXUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwydDVZMTl5WldkcGMzUnllUzV3ZVRvM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMkZrWlc1amFXRXVhM2xqWDNKbFoybHpkSEo1TGt0WlExSmxaMmx6ZEhKNUxuSmxaMmx6ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXJlV05mY21WbmFYTjBjbmt1Y0hrNk9EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREZ0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZhM2xqWDNKbFoybHpkSEo1TG5CNU9qazNDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOXlZV05zWlM1MllXeDFaU3dnSW05dWJIa2diM0poWTJ4bElHTmhiaUJ5WldkcGMzUmxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdmNtRmpiR1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzSmhZMnhsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJRzl5WVdOc1pTQmpZVzRnY21WbmFYTjBaWElLSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUbzVPUW9nSUNBZ0x5OGdjbTlzWlY5MllXd2dQU0J5YjJ4bExtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVEF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbTlzWlY5MllXd2dQajBnTVNCaGJtUWdjbTlzWlY5MllXd2dQRDBnTXl3Z0ltbHVkbUZzYVdRZ2NtOXNaU0lLSUNBZ0lHSjZJSEpsWjJsemRHVnlYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUR3OUNpQWdJQ0JpZWlCeVpXZHBjM1JsY2w5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENncHlaV2RwYzNSbGNsOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVEF3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbTlzWlY5MllXd2dQajBnTVNCaGJtUWdjbTlzWlY5MllXd2dQRDBnTXl3Z0ltbHVkbUZzYVdRZ2NtOXNaU0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lISnZiR1VLSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUb3hNRFVLSUNBZ0lDOHZJSFpsY21sbWFXVmtYMkYwUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUb3hNRE1LSUNBZ0lDOHZJR3Q1WTE5MGFXVnlQV0Z5WXpRdVZVbHVkRGdvTVNrc0lDQWpJRlJKUlZKZlFrRlRTVU1nWm05eUlFMVdVQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUb3hNREl0TVRBM0NpQWdJQ0F2THlCeVpXTnZjbVFnUFNCTFdVTlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdhM2xqWDNScFpYSTlZWEpqTkM1VlNXNTBPQ2d4S1N3Z0lDTWdWRWxGVWw5Q1FWTkpReUJtYjNJZ1RWWlFDaUFnSUNBdkx5QWdJQ0FnY205c1pUMXliMnhsTEFvZ0lDQWdMeThnSUNBZ0lIWmxjbWxtYVdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnYTNsalgyaGhjMmc5YTNsalgyaGhjMmd1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXJlV05mY21WbmFYTjBjbmt1Y0hrNk1UQTVDaUFnSUNBdkx5QnBjMTl1WlhjZ1BTQmhaR1J5WlhOeklHNXZkQ0JwYmlCelpXeG1MbkpsWTI5eVpITUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJZamM1TmpNMVpnb2dJQ0FnWkdsbklEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJ0NVkxOXlaV2RwYzNSeWVTNXdlVG94TVRBS0lDQWdJQzh2SUhObGJHWXVjbVZqYjNKa2MxdGhaR1J5WlhOelhTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTJGa1pXNWphV0V2YTNsalgzSmxaMmx6ZEhKNUxuQjVPakV4TWdvZ0lDQWdMeThnYVdZZ2FYTmZibVYzT2dvZ0lDQWdZbTU2SUhKbFoybHpkR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdZMkZrWlc1amFXRXZhM2xqWDNKbFoybHpkSEo1TG5CNU9qRXhNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjkyWlhKcFptbGxaQzUyWVd4MVpTQXJQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5MlpYSnBabWxsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5MlpYSnBabWxsWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjkyWlhKcFptbGxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dweVpXZHBjM1JsY2w5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZPRFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZuYVhOMFpYSmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdjbVZuYVhOMFpYSmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdZMkZrWlc1amFXRXVhM2xqWDNKbFoybHpkSEo1TGt0WlExSmxaMmx6ZEhKNUxuVndaR0YwWlY5MGFXVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYM1JwWlhJNkNpQWdJQ0F2THlCallXUmxibU5wWVM5cmVXTmZjbVZuYVhOMGNua3VjSGs2TVRFMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblE0Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVEU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbTl5WVdOc1pTNTJZV3gxWlN3Z0ltOXViSGtnYjNKaFkyeGxJR05oYmlCMWNHUmhkR1VnZEdsbGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p2Y21GamJHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNKaFkyeGxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlHOXlZV05zWlNCallXNGdkWEJrWVhSbElIUnBaWElLSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUb3hNVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhaR1J5WlhOeklHbHVJSE5sYkdZdWNtVmpiM0prY3l3Z0ltRmtaSEpsYzNNZ2JtOTBJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1JM09UWXpOV1lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZrWkhKbGMzTWdibTkwSUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJ0NVkxOXlaV2RwYzNSeWVTNXdlVG94TWpJdE1USXpDaUFnSUNBdkx5QnlaV052Y21RdWEzbGpYM1JwWlhJZ1BTQnVaWGRmZEdsbGNnb2dJQ0FnTHk4Z2MyVnNaaTV5WldOdmNtUnpXMkZrWkhKbGMzTmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJ0NVkxOXlaV2RwYzNSeWVTNXdlVG94TVRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTmhaR1Z1WTJsaExtdDVZMTl5WldkcGMzUnllUzVMV1VOU1pXZHBjM1J5ZVM1eVpYWnZhMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYWnZhMlU2Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVEkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmEzbGpYM0psWjJsemRISjVMbkI1T2pFeU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJbTl1YkhrZ1lXUnRhVzRnWTJGdUlISmxkbTlyWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JoWkcxcGJpQmpZVzRnY21WMmIydGxDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXJlV05mY21WbmFYTjBjbmt1Y0hrNk1USTVDaUFnSUNBdkx5QmhjM05sY25RZ1lXUmtjbVZ6Y3lCcGJpQnpaV3htTG5KbFkyOXlaSE1zSUNKaFpHUnlaWE56SUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFppTnprMk16Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnWVdSa2NtVnpjeUJ1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmEzbGpYM0psWjJsemRISjVMbkI1T2pFek1Rb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdWNtVmpiM0prYzF0aFpHUnlaWE56WFFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCallXUmxibU5wWVM5cmVXTmZjbVZuYVhOMGNua3VjSGs2TVRNeUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzWmxjbWxtYVdWa0xuWmhiSFZsSUMwOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYM1psY21sbWFXVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM1psY21sbWFXVmtJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gzWmxjbWxtYVdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwydDVZMTl5WldkcGMzUnllUzV3ZVRveE1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR05oWkdWdVkybGhMbXQ1WTE5eVpXZHBjM1J5ZVM1TFdVTlNaV2RwYzNSeWVTNXpaWFJmYjNKaFkyeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgyOXlZV05zWlRvS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJ0NVkxOXlaV2RwYzNSeWVTNXdlVG94TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXJlV05mY21WbmFYTjBjbmt1Y0hrNk1UTTNDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpYjI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUc5eVlXTnNaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUc5eVlXTnNaUW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZhM2xqWDNKbFoybHpkSEo1TG5CNU9qRXpPQW9nSUNBZ0x5OGdjMlZzWmk1dmNtRmpiR1V1ZG1Gc2RXVWdQU0J1WlhkZmIzSmhZMnhsQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p2Y21GamJHVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZhM2xqWDNKbFoybHpkSEo1TG5CNU9qRXpOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTJGa1pXNWphV0V1YTNsalgzSmxaMmx6ZEhKNUxrdFpRMUpsWjJsemRISjVMbWx6WDNabGNtbG1hV1ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTmZkbVZ5YVdacFpXUTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXJlV05mY21WbmFYTjBjbmt1Y0hrNk1UUXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMkZrWlc1amFXRXZhM2xqWDNKbFoybHpkSEo1TG5CNU9qRTBNd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaGhaR1J5WlhOeklHbHVJSE5sYkdZdWNtVmpiM0prY3lrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMllqYzVOak0xWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklHTmhaR1Z1WTJsaEwydDVZMTl5WldkcGMzUnllUzV3ZVRveE5EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTmhaR1Z1WTJsaExtdDVZMTl5WldkcGMzUnllUzVMV1VOU1pXZHBjM1J5ZVM1blpYUmZjbVZqYjNKa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNKbFkyOXlaRG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUb3hORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVFE0Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV1JrY21WemN5QnBiaUJ6Wld4bUxuSmxZMjl5WkhNc0lDSmhaR1J5WlhOeklHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURaaU56azJNelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1lXUmtjbVZ6Y3lCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZMkZrWlc1amFXRXZhM2xqWDNKbFoybHpkSEo1TG5CNU9qRTBPUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Y21WamIzSmtjMXRoWkdSeVpYTnpYUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVFExQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqWVdSbGJtTnBZUzVyZVdOZmNtVm5hWE4wY25rdVMxbERVbVZuYVhOMGNua3VaMlYwWDNKdmJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNtOXNaVG9LSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUb3hOVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVFUwQ2lBZ0lDQXZMeUJwWmlCaFpHUnlaWE56SUdsdUlITmxiR1l1Y21WamIzSmtjem9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyWWpjNU5qTTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1oyVjBYM0p2YkdWZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJqWVdSbGJtTnBZUzlyZVdOZmNtVm5hWE4wY25rdWNIazZNVFUxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1eVpXTnZjbVJ6VzJGa1pISmxjM05kTG5KdmJHVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZqYjNKa2N5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lHVjRkSEpoWTNRZ01TQXhDZ3BuWlhSZmNtOXNaVjloWm5SbGNsOXBibXhwYm1Wa1gyTmhaR1Z1WTJsaExtdDVZMTl5WldkcGMzUnllUzVMV1VOU1pXZHBjM1J5ZVM1blpYUmZjbTlzWlVBME9nb2dJQ0FnTHk4Z1kyRmtaVzVqYVdFdmEzbGpYM0psWjJsemRISjVMbkI1T2pFMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSZmNtOXNaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QmpZV1JsYm1OcFlTOXJlV05mY21WbmFYTjBjbmt1Y0hrNk1UVTJDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME9DZ3dLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lDOHZJR05oWkdWdVkybGhMMnQ1WTE5eVpXZHBjM1J5ZVM1d2VUb3hOVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZmNtOXNaVjloWm5SbGNsOXBibXhwYm1Wa1gyTmhaR1Z1WTJsaExtdDVZMTl5WldkcGMzUnllUzVMV1VOU1pXZHBjM1J5ZVM1blpYUmZjbTlzWlVBMENnb0tMeThnWTJGa1pXNWphV0V1YTNsalgzSmxaMmx6ZEhKNUxrdFpRMUpsWjJsemRISjVMbWRsZEY5emRHRjBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXpkR0YwY3pvS0lDQWdJQzh2SUdOaFpHVnVZMmxoTDJ0NVkxOXlaV2RwYzNSeWVTNXdlVG94TmpFS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzWmxjbWxtYVdWa0xuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gzWmxjbWxtYVdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzWmxjbWxtYVdWa0lHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTJGa1pXNWphV0V2YTNsalgzSmxaMmx6ZEhKNUxuQjVPakUxT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBZ0pnVU9kRzkwWVd4ZmRtVnlhV1pwWldRRWEzbGpYd1p2Y21GamJHVUVGUjk4ZFFWaFpHMXBiakVaRkVReEdFRUFRSUlJQlBkWEJVY0VBdSsweVFRamd4V1hCRE5vOVZZRU5tRkgvQVEyaFFSeUJCZmRYOThFOHVzcE5qWWFBSTRJQUN3QWlRQ3dBTllBN0FFSEFSOEJRd0NBQklxV21BNDJHZ0NPQVFBQkFEWWFBVWtWSkJKRU5ob0NTUlVrRWtRbkJFOENaeXBNWnlnalp5SkROaG9CU1JVa0VrUTJHZ0pIQWhVaUVrUTJHZ05KVGdJVkpCSkVNUUFqS21WRUVrUVhTVUVBTVVtQkF3NUJBQ29pUkRJR0ZvQUJBVXNFVUV4UVN3SlFLVXNGVUVtOVRnSklUd0svUUFBSkl5aGxSQ0lJS0V4bklrTWpRdi9UTmhvQlNSVWtFa1EyR2dKSkZTSVNSREVBSXlwbFJCSkVLVThDVUVtOVJRRkVJMDhDdXlKRE5ob0JTUlVrRWtReEFDTW5CR1ZFRWtRcFRGQkp2VVVCUkx4SUl5aGxSQ0lKS0V4bklrTTJHZ0ZKRlNRU1JERUFJeWNFWlVRU1JDcE1aeUpETmhvQlNSVWtFa1FwVEZDOVJRR0FBUUFqVHdKVUsweFFzQ0pETmhvQlNSVWtFa1FwVEZCSnZVVUJSTDVJSzB4UXNDSkROaG9CU1JVa0VrUXBURkJKdlVVQlFRQU1TYjVFVndFQksweFFzQ0pEZ0FFQVF2LzBJeWhsUkJZclRGQ3dJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
