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

namespace Arc56.Generated.aarushchaudhary.afterlife.AfterlifeVault_6f5d3388
{


    public class AfterlifeVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AfterlifeVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class VaultData : AVMObjectType
            {
                public bool IsActive { get; set; }

                public bool IsUnlocked { get; set; }

                public bool HospitalApproved { get; set; }

                public bool GovApproved { get; set; }

                public bool VerifierApproved { get; set; }

                public Algorand.Address DesignatedHospital { get; set; }

                public Algorand.Address DesignatedGov { get; set; }

                public Algorand.Address DesignatedVerifier { get; set; }

                public Structs.GetBeneficiariesReturn[] Beneficiaries { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsUnlocked.From(IsUnlocked);
                    ret.AddRange(vIsUnlocked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHospitalApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vHospitalApproved.From(HospitalApproved);
                    ret.AddRange(vHospitalApproved.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGovApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vGovApproved.From(GovApproved);
                    ret.AddRange(vGovApproved.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifierApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vVerifierApproved.From(VerifierApproved);
                    ret.AddRange(vVerifierApproved.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDesignatedHospital = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDesignatedHospital.From(DesignatedHospital);
                    ret.AddRange(vDesignatedHospital.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDesignatedGov = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDesignatedGov.From(DesignatedGov);
                    ret.AddRange(vDesignatedGov.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDesignatedVerifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDesignatedVerifier.From(DesignatedVerifier);
                    ret.AddRange(vDesignatedVerifier.Encode());
                    var arrBeneficiaries = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetBeneficiariesReturn>(x => Structs.GetBeneficiariesReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrBeneficiaries.Value = (Beneficiaries ?? Array.Empty<Structs.GetBeneficiariesReturn>()).ToList();
                    stringRef[ret.Count] = arrBeneficiaries.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VaultData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new VaultData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is bool vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsUnlocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsUnlocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsUnlocked = vIsUnlocked.ToValue();
                    if (valueIsUnlocked is bool vIsUnlockedValue) { ret.IsUnlocked = vIsUnlockedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHospitalApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vHospitalApproved.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHospitalApproved = vHospitalApproved.ToValue();
                    if (valueHospitalApproved is bool vHospitalApprovedValue) { ret.HospitalApproved = vHospitalApprovedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGovApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vGovApproved.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGovApproved = vGovApproved.ToValue();
                    if (valueGovApproved is bool vGovApprovedValue) { ret.GovApproved = vGovApprovedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifierApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vVerifierApproved.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifierApproved = vVerifierApproved.ToValue();
                    if (valueVerifierApproved is bool vVerifierApprovedValue) { ret.VerifierApproved = vVerifierApprovedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDesignatedHospital = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDesignatedHospital.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDesignatedHospital = vDesignatedHospital.ToValue();
                    if (valueDesignatedHospital is Algorand.Address vDesignatedHospitalValue) { ret.DesignatedHospital = vDesignatedHospitalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDesignatedGov = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDesignatedGov.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDesignatedGov = vDesignatedGov.ToValue();
                    if (valueDesignatedGov is Algorand.Address vDesignatedGovValue) { ret.DesignatedGov = vDesignatedGovValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDesignatedVerifier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDesignatedVerifier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDesignatedVerifier = vDesignatedVerifier.ToValue();
                    if (valueDesignatedVerifier is Algorand.Address vDesignatedVerifierValue) { ret.DesignatedVerifier = vDesignatedVerifierValue; }
                    var indexBeneficiaries = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrBeneficiaries = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetBeneficiariesReturn>(x => Structs.GetBeneficiariesReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrBeneficiaries.Decode(bytes.Skip(indexBeneficiaries + prefixOffset).ToArray());
                    ret.Beneficiaries = arrBeneficiaries.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VaultData);
                }
                public bool Equals(VaultData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VaultData left, VaultData right)
                {
                    return EqualityComparer<VaultData>.Default.Equals(left, right);
                }
                public static bool operator !=(VaultData left, VaultData right)
                {
                    return !(left == right);
                }

            }

            public class GetBeneficiariesReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetBeneficiariesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetBeneficiariesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBeneficiariesReturn);
                }
                public bool Equals(GetBeneficiariesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBeneficiariesReturn left, GetBeneficiariesReturn right)
                {
                    return EqualityComparer<GetBeneficiariesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBeneficiariesReturn left, GetBeneficiariesReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initializes a new Afterlife Vault with multiple beneficiaries.
        ///</summary>
        /// <param name="heir_wallets"> </param>
        /// <param name="percentages"> </param>
        /// <param name="hospital"> </param>
        /// <param name="gov"> </param>
        /// <param name="verifier"> </param>
        public async Task CreateVault(Algorand.Address[] heir_wallets, ulong[] percentages, Algorand.Address hospital, Algorand.Address gov, Algorand.Address verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 48, 208, 95 };
            var heir_walletsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); heir_walletsAbi.From(heir_wallets);
            var percentagesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); percentagesAbi.From(percentages);
            var hospitalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); hospitalAbi.From(hospital);
            var govAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); govAbi.From(gov);
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAbi.From(verifier);

            var result = await base.CallApp(new List<object> { abiHandle, heir_walletsAbi, percentagesAbi, hospitalAbi, govAbi, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateVault_Transactions(Algorand.Address[] heir_wallets, ulong[] percentages, Algorand.Address hospital, Algorand.Address gov, Algorand.Address verifier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 48, 208, 95 };
            var heir_walletsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); heir_walletsAbi.From(heir_wallets);
            var percentagesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); percentagesAbi.From(percentages);
            var hospitalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); hospitalAbi.From(hospital);
            var govAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); govAbi.From(gov);
            var verifierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); verifierAbi.From(verifier);

            return await base.MakeTransactionList(new List<object> { abiHandle, heir_walletsAbi, percentagesAbi, hospitalAbi, govAbi, verifierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Hospital triggers the protocol (1/3).
        ///</summary>
        /// <param name="owner"> </param>
        public async Task InitiateDeath(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 141, 170, 62 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitiateDeath_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 141, 170, 62 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Gov or Verifier provides consensus (2/3 and 3/3).
        ///</summary>
        /// <param name="owner"> </param>
        public async Task ApproveDeath(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 170, 152, 41 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveDeath_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 170, 152, 41 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner's Dead Man Switch to cancel false alarm.
        ///</summary>
        public async Task CancelDeathProtocol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 75, 211, 241 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelDeathProtocol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 75, 211, 241 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///View function for the frontend to retrieve the heirs array.
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<Structs.GetBeneficiariesReturn[]> GetBeneficiaries(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 147, 37, 172 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetBeneficiariesReturn>(x => Structs.GetBeneficiariesReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetBeneficiaries_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 147, 37, 172 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///View function to check unlock status.
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<bool> IsVaultUnlocked(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 132, 190, 93 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsVaultUnlocked_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 132, 190, 93 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWZ0ZXJsaWZlVmF1bHQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVmF1bHREYXRhIjpbeyJuYW1lIjoiaXNfYWN0aXZlIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJpc191bmxvY2tlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiaG9zcGl0YWxfYXBwcm92ZWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Imdvdl9hcHByb3ZlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoidmVyaWZpZXJfYXBwcm92ZWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImRlc2lnbmF0ZWRfaG9zcGl0YWwiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImRlc2lnbmF0ZWRfZ292IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJkZXNpZ25hdGVkX3ZlcmlmaWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJiZW5lZmljaWFyaWVzIiwidHlwZSI6IkdldEJlbmVmaWNpYXJpZXNSZXR1cm5bXSJ9XSwiR2V0QmVuZWZpY2lhcmllc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfdmF1bHQiLCJkZXNjIjoiSW5pdGlhbGl6ZXMgYSBuZXcgQWZ0ZXJsaWZlIFZhdWx0IHdpdGggbXVsdGlwbGUgYmVuZWZpY2lhcmllcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGVpcl93YWxsZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBlcmNlbnRhZ2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaG9zcGl0YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnb3YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJpZmllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0aWF0ZV9kZWF0aCIsImRlc2MiOiJIb3NwaXRhbCB0cmlnZ2VycyB0aGUgcHJvdG9jb2wgKDEvMykuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX2RlYXRoIiwiZGVzYyI6IkdvdiBvciBWZXJpZmllciBwcm92aWRlcyBjb25zZW5zdXMgKDIvMyBhbmQgMy8zKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbF9kZWF0aF9wcm90b2NvbCIsImRlc2MiOiJPd25lcidzIERlYWQgTWFuIFN3aXRjaCB0byBjYW5jZWwgZmFsc2UgYWxhcm0uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9iZW5lZmljaWFyaWVzIiwiZGVzYyI6IlZpZXcgZnVuY3Rpb24gZm9yIHRoZSBmcm9udGVuZCB0byByZXRyaWV2ZSB0aGUgaGVpcnMgYXJyYXkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQpW10iLCJzdHJ1Y3QiOiJHZXRCZW5lZmljaWFyaWVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfdmF1bHRfdW5sb2NrZWQiLCJkZXNjIjoiVmlldyBmdW5jdGlvbiB0byBjaGVjayB1bmxvY2sgc3RhdHVzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNjhdLCJlcnJvck1lc3NhZ2UiOiJBcnJheXMgbGVuZ3RoIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA5XSwiZXJyb3JNZXNzYWdlIjoiUGVyY2VudGFnZXMgbXVzdCBlcXVhbCAxMDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTZdLCJlcnJvck1lc3NhZ2UiOiJQcm90b2NvbCBub3QgaW5pdGlhdGVkIGJ5IGhvc3BpdGFsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIxXSwiZXJyb3JNZXNzYWdlIjoiVW5hdXRob3JpemVkOiBOb3QgR292IG9yIFZlcmlmaWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ1XSwiZXJyb3JNZXNzYWdlIjoiVW5hdXRob3JpemVkOiBOb3QgdGhlIGRlc2lnbmF0ZWQgaG9zcGl0YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzldLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBhbHJlYWR5IHBlcm1hbmVudGx5IHVubG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM2LDM4Niw1MjhdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBpcyBub3QgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcxLDUxMiw1NzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZhdWx0cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzksMjUyXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDAsMTIyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDYsMTU2LDE2NiwzMTgsMzYxLDU2NSw1OTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU5XSwiZXJyb3JNZXNzYWdlIjoibWF4IGFycmF5IGxlbmd0aCBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEQXdJQ0oyWVhWc2RITWlJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNekF0TXpFS0lDQWdJQzh2SUNNZ015NGdWR2hsSUUxaGFXNGdRMjl1ZEhKaFkzUUtJQ0FnSUM4dklHTnNZWE56SUVGbWRHVnliR2xtWlZaaGRXeDBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROVGt6TUdRd05XWWdNSGcwTmpoa1lXRXpaU0F3ZURJNVlXRTVPREk1SURCNFpUVTBZbVF6WmpFZ01IZzFPVGt6TWpWaFl5QXdlR0kwT0RSaVpUVmtJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYM1poZFd4MEtHRmtaSEpsYzNOYlhTeDFhVzUwTmpSYlhTeGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0pwYm1sMGFXRjBaVjlrWldGMGFDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVZmWkdWaGRHZ29ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKallXNWpaV3hmWkdWaGRHaGZjSEp2ZEc5amIyd29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjlpWlc1bFptbGphV0Z5YVdWektHRmtaSEpsYzNNcEtHRmtaSEpsYzNNc2RXbHVkRFkwS1Z0ZElpd2diV1YwYUc5a0lDSnBjMTkyWVhWc2RGOTFibXh2WTJ0bFpDaGhaR1J5WlhOektXSnZiMndpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1ZmZG1GMWJIUWdhVzVwZEdsaGRHVmZaR1ZoZEdnZ1lYQndjbTkyWlY5a1pXRjBhQ0JqWVc1alpXeGZaR1ZoZEdoZmNISnZkRzlqYjJ3Z1oyVjBYMkpsYm1WbWFXTnBZWEpwWlhNZ2FYTmZkbUYxYkhSZmRXNXNiMk5yWldRS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRm1kR1Z5YkdsbVpWOTJZWFZzZEM1amIyNTBjbUZqZEM1QlpuUmxjbXhwWm1WV1lYVnNkQzVqY21WaGRHVmZkbUYxYkhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWZmRtRjFiSFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm1kR1Z5YkdsbVpWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajQrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREWTBQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGbWRHVnliR2xtWlY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdobGFYSmZkMkZzYkdWMGN5NXNaVzVuZEdnZ1BUMGdjR1Z5WTJWdWRHRm5aWE11YkdWdVozUm9MQ0FpUVhKeVlYbHpJR3hsYm1kMGFDQnRhWE50WVhSamFDSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUVhKeVlYbHpJR3hsYm1kMGFDQnRhWE50WVhSamFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGbWRHVnliR2xtWlY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvME9DMDBPUW9nSUNBZ0x5OGdJeUJXWlhKcFpua2djR1Z5WTJWdWRHRm5aWE1nWlhGMVlXd2dNVEF3Q2lBZ0lDQXZMeUIwYjNSaGJGOXdaWEpqWlc1MFlXZGxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm1kR1Z5YkdsbVpWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtIQmxjbU5sYm5SaFoyVnpMbXhsYm1kMGFDazZJQ01nUEMwdElFTklRVTVIUlVRZ1ZFOGdWVkpCVGtkRkNpQWdJQ0JrZFhBS0NtTnlaV0YwWlY5MllYVnNkRjltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvY0dWeVkyVnVkR0ZuWlhNdWJHVnVaM1JvS1RvZ0l5QThMUzBnUTBoQlRrZEZSQ0JVVHlCVlVrRk9SMFVLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFlLSUNBZ0lEd0tJQ0FnSUdKNklHTnlaV0YwWlY5MllYVnNkRjloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnZEc5MFlXeGZjR1Z5WTJWdWRHRm5aU0FyUFNCd1pYSmpaVzUwWVdkbGMxdHBYUzV1WVhScGRtVUtJQ0FnSUdScFp5QTJDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0FxQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8xTUFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLSEJsY21ObGJuUmhaMlZ6TG14bGJtZDBhQ2s2SUNNZ1BDMHRJRU5JUVU1SFJVUWdWRThnVlZKQlRrZEZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUdOeVpXRjBaVjkyWVhWc2RGOW1iM0pmYUdWaFpHVnlRRElLQ21OeVpXRjBaVjkyWVhWc2RGOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBiM1JoYkY5d1pYSmpaVzUwWVdkbElEMDlJREV3TUN3Z0lsQmxjbU5sYm5SaFoyVnpJRzExYzNRZ1pYRjFZV3dnTVRBd0lnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRBd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJsY21ObGJuUmhaMlZ6SUcxMWMzUWdaWEYxWVd3Z01UQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVTBMVFUxQ2lBZ0lDQXZMeUFqSUVOdmJuTjBjblZqZENCMGFHVWdZbVZ1WldacFkybGhjbWxsY3lCaGNuSmhlUW9nSUNBZ0x5OGdZbVZ1WldacFkybGhjbmxmYkdsemRDQTlJR0Z5WXpRdVJIbHVZVzFwWTBGeWNtRjVXMEpsYm1WbWFXTnBZWEo1VkdGeVoyVjBYU2dwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd0NpQWdJQ0JpZFhKNUlERXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2FHVnBjbDkzWVd4c1pYUnpMbXhsYm1kMGFDazZJQ01nUEMwdElFTklRVTVIUlVRZ1ZFOGdWVkpCVGtkRkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBeENncGpjbVZoZEdWZmRtRjFiSFJmWm05eVgyaGxZV1JsY2tBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGbWRHVnliR2xtWlY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0dobGFYSmZkMkZzYkdWMGN5NXNaVzVuZEdncE9pQWpJRHd0TFNCRFNFRk9SMFZFSUZSUElGVlNRVTVIUlFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnT0FvZ0lDQWdQQW9nSUNBZ1lub2dZM0psWVhSbFgzWmhkV3gwWDJGbWRHVnlYMlp2Y2tBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCM1lXeHNaWFE5YUdWcGNsOTNZV3hzWlhSelcybGRMQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QndaWEpqWlc1MFlXZGxQWEJsY21ObGJuUmhaMlZ6VzJsZENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pVM0xUWXdDaUFnSUNBdkx5QjBZWEpuWlhRZ1BTQkNaVzVsWm1samFXRnllVlJoY21kbGRDZ0tJQ0FnSUM4dklDQWdJQ0IzWVd4c1pYUTlhR1ZwY2w5M1lXeHNaWFJ6VzJsZExBb2dJQ0FnTHk4Z0lDQWdJSEJsY21ObGJuUmhaMlU5Y0dWeVkyVnVkR0ZuWlhOYmFWMEtJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm1kR1Z5YkdsbVpWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdZbVZ1WldacFkybGhjbmxmYkdsemRDNWhjSEJsYm1Rb2RHRnlaMlYwTG1OdmNIa29LU2tLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQ0F2THlCdmJpQmxjbkp2Y2pvZ2JXRjRJR0Z5Y21GNUlHeGxibWQwYUNCbGVHTmxaV1JsWkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hvWldseVgzZGhiR3hsZEhNdWJHVnVaM1JvS1RvZ0l5QThMUzBnUTBoQlRrZEZSQ0JVVHlCVlVrRk9SMFVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1kzSmxZWFJsWDNaaGRXeDBYMlp2Y2w5b1pXRmtaWEpBTmdvS1kzSmxZWFJsWDNaaGRXeDBYMkZtZEdWeVgyWnZja0E1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8yTXkwM05Bb2dJQ0FnTHk4Z0l5QlRZWFpsSUhSdklFSnZlQ0JUZEc5eVlXZGxJQ2hWYzJWeUozTWdWbUYxYkhRcENpQWdJQ0F2THlCelpXeG1MblpoZFd4MGMxdFVlRzR1YzJWdVpHVnlYU0E5SUZaaGRXeDBSR0YwWVNnS0lDQWdJQzh2SUNBZ0lDQnBjMTloWTNScGRtVTlZWEpqTkM1Q2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDNWdWJHOWphMlZrUFdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FHOXpjR2wwWVd4ZllYQndjbTkyWldROVlYSmpOQzVDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNBZ0lDQm5iM1pmWVhCd2NtOTJaV1E5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ0FnSUNCMlpYSnBabWxsY2w5aGNIQnliM1psWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnSUNBZ0lHUmxjMmxuYm1GMFpXUmZhRzl6Y0dsMFlXdzlZWEpqTkM1QlpHUnlaWE56S0dodmMzQnBkR0ZzS1N3S0lDQWdJQzh2SUNBZ0lDQmtaWE5wWjI1aGRHVmtYMmR2ZGoxaGNtTTBMa0ZrWkhKbGMzTW9aMjkyS1N3S0lDQWdJQzh2SUNBZ0lDQmtaWE5wWjI1aGRHVmtYM1psY21sbWFXVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loMlpYSnBabWxsY2lrc0NpQWdJQ0F2THlBZ0lDQWdZbVZ1WldacFkybGhjbWxsY3oxaVpXNWxabWxqYVdGeWVWOXNhWE4wTG1OdmNIa29LUW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TmpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZOak10TmpRS0lDQWdJQzh2SUNNZ1UyRjJaU0IwYnlCQ2IzZ2dVM1J2Y21GblpTQW9WWE5sY2lkeklGWmhkV3gwS1FvZ0lDQWdMeThnYzJWc1ppNTJZWFZzZEhOYlZIaHVMbk5sYm1SbGNsMGdQU0JXWVhWc2RFUmhkR0VvQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oyWVhWc2RITWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFpuUmxjbXhwWm1WZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk5qTXROelFLSUNBZ0lDOHZJQ01nVTJGMlpTQjBieUJDYjNnZ1UzUnZjbUZuWlNBb1ZYTmxjaWR6SUZaaGRXeDBLUW9nSUNBZ0x5OGdjMlZzWmk1MllYVnNkSE5iVkhodUxuTmxibVJsY2wwZ1BTQldZWFZzZEVSaGRHRW9DaUFnSUNBdkx5QWdJQ0FnYVhOZllXTjBhWFpsUFdGeVl6UXVRbTl2YkNoVWNuVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOTFibXh2WTJ0bFpEMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0lDQWdJR2h2YzNCcGRHRnNYMkZ3Y0hKdmRtVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnWjI5MlgyRndjSEp2ZG1Wa1BXRnlZelF1UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0F2THlBZ0lDQWdkbVZ5YVdacFpYSmZZWEJ3Y205MlpXUTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDQWdJQ0JrWlhOcFoyNWhkR1ZrWDJodmMzQnBkR0ZzUFdGeVl6UXVRV1JrY21WemN5aG9iM053YVhSaGJDa3NDaUFnSUNBdkx5QWdJQ0FnWkdWemFXZHVZWFJsWkY5bmIzWTlZWEpqTkM1QlpHUnlaWE56S0dkdmRpa3NDaUFnSUNBdkx5QWdJQ0FnWkdWemFXZHVZWFJsWkY5MlpYSnBabWxsY2oxaGNtTTBMa0ZrWkhKbGMzTW9kbVZ5YVdacFpYSXBMQW9nSUNBZ0x5OGdJQ0FnSUdKbGJtVm1hV05wWVhKcFpYTTlZbVZ1WldacFkybGhjbmxmYkdsemRDNWpiM0I1S0NrS0lDQWdJQzh2SUNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qTTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV1owWlhKc2FXWmxYM1poZFd4MExtTnZiblJ5WVdOMExrRm1kR1Z5YkdsbVpWWmhkV3gwTG1sdWFYUnBZWFJsWDJSbFlYUm9XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1cGRHbGhkR1ZmWkdWaGRHZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG8zT1FvZ0lDQWdMeThnZG1GMWJIUWdQU0J6Wld4bUxuWmhkV3gwYzF0dmQyNWxjbDB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjJZWFZzZEhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFpuUmxjbXhwWm1WZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk56a3RPREFLSUNBZ0lDOHZJSFpoZFd4MElEMGdjMlZzWmk1MllYVnNkSE5iYjNkdVpYSmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z1lYTnpaWEowSUhaaGRXeDBMbWx6WDJGamRHbDJaUzV1WVhScGRtVXNJQ0pXWVhWc2RDQnBjeUJ1YjNRZ1lXTjBhWFpsSWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVhWc2RDNXBjMTloWTNScGRtVXVibUYwYVhabExDQWlWbUYxYkhRZ2FYTWdibTkwSUdGamRHbDJaU0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFnTHk4Z1ZtRjFiSFFnYVhNZ2JtOTBJR0ZqZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGbWRHVnliR2xtWlY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdkbUYxYkhRdVpHVnphV2R1WVhSbFpGOW9iM053YVhSaGJDNXVZWFJwZG1Vc0lDSlZibUYxZEdodmNtbDZaV1E2SUU1dmRDQjBhR1VnWkdWemFXZHVZWFJsWkNCb2IzTndhWFJoYkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1GMWRHaHZjbWw2WldRNklFNXZkQ0IwYUdVZ1pHVnphV2R1WVhSbFpDQm9iM053YVhSaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGbWRHVnliR2xtWlY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRvNE15MDROQW9nSUNBZ0x5OGdkbUYxYkhRdWFHOXpjR2wwWVd4ZllYQndjbTkyWldRZ1BTQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJQzh2SUhObGJHWXVkbUYxYkhSelcyOTNibVZ5WFNBOUlIWmhkV3gwTG1OdmNIa29LU0FqSUR3dExTQkJSRVJGUkNBdVEwOVFXU2dwSUVaUFVpQlRRVVpGSUVGVFUwbEhUazFGVGxRS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV1owWlhKc2FXWmxYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUIyWVhWc2RDNW9iM053YVhSaGJGOWhjSEJ5YjNabFpDQTlJR0Z5WXpRdVFtOXZiQ2hVY25WbEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T0RNdE9EUUtJQ0FnSUM4dklIWmhkV3gwTG1odmMzQnBkR0ZzWDJGd2NISnZkbVZrSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQXZMeUJ6Wld4bUxuWmhkV3gwYzF0dmQyNWxjbDBnUFNCMllYVnNkQzVqYjNCNUtDa2dJeUE4TFMwZ1FVUkVSVVFnTGtOUFVGa29LU0JHVDFJZ1UwRkdSU0JCVTFOSlIwNU5SVTVVQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm1kR1Z5YkdsbVpWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZtZEdWeWJHbG1aVjkyWVhWc2RDNWpiMjUwY21GamRDNUJablJsY214cFptVldZWFZzZEM1aGNIQnliM1psWDJSbFlYUm9XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhCd2NtOTJaVjlrWldGMGFEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFpuUmxjbXhwWm1WZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk9EWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV1owWlhKc2FXWmxYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamc1Q2lBZ0lDQXZMeUIyWVhWc2RDQTlJSE5sYkdZdWRtRjFiSFJ6VzI5M2JtVnlYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luWmhkV3gwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd2JpQXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MllYVnNkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnNUxUa3dDaUFnSUNBdkx5QjJZWFZzZENBOUlITmxiR1l1ZG1GMWJIUnpXMjkzYm1WeVhTNWpiM0I1S0NrS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVhWc2RDNXBjMTloWTNScGRtVXVibUYwYVhabExDQWlWbUYxYkhRZ2FYTWdibTkwSUdGamRHbDJaU0lLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV1owWlhKc2FXWmxYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUWdkbUYxYkhRdWFYTmZZV04wYVhabExtNWhkR2wyWlN3Z0lsWmhkV3gwSUdseklHNXZkQ0JoWTNScGRtVWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWVhOelpYSjBJQzh2SUZaaGRXeDBJR2x6SUc1dmRDQmhZM1JwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUdGemMyVnlkQ0IyWVhWc2RDNW9iM053YVhSaGJGOWhjSEJ5YjNabFpDNXVZWFJwZG1Vc0lDSlFjbTkwYjJOdmJDQnViM1FnYVc1cGRHbGhkR1ZrSUdKNUlHaHZjM0JwZEdGc0lnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJRY205MGIyTnZiQ0J1YjNRZ2FXNXBkR2xoZEdWa0lHSjVJR2h2YzNCcGRHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qa3pMVGswQ2lBZ0lDQXZMeUFqSUVOb1pXTnJJR05oYkd4bGNpQnBaR1Z1ZEdsMGVRb2dJQ0FnTHk4Z2FYTmZaMjkySUQwZ1ZIaHVMbk5sYm1SbGNpQTlQU0IyWVhWc2RDNWtaWE5wWjI1aGRHVmtYMmR2ZGk1dVlYUnBkbVVLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURNekNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm1kR1Z5YkdsbVpWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUbzVOUW9nSUNBZ0x5OGdhWE5mZG1WeWFXWnBaWElnUFNCVWVHNHVjMlZ1WkdWeUlEMDlJSFpoZFd4MExtUmxjMmxuYm1GMFpXUmZkbVZ5YVdacFpYSXVibUYwYVhabENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTmpVS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lEMDlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBjMTluYjNZZ2IzSWdhWE5mZG1WeWFXWnBaWElzSUNKVmJtRjFkR2h2Y21sNlpXUTZJRTV2ZENCSGIzWWdiM0lnVm1WeWFXWnBaWElpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdmSHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibUYxZEdodmNtbDZaV1E2SUU1dmRDQkhiM1lnYjNJZ1ZtVnlhV1pwWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2T1RnS0lDQWdJQzh2SUdsbUlHbHpYMmR2ZGpvS0lDQWdJR0o2SUdGd2NISnZkbVZmWkdWaGRHaGZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCMllYVnNkQzVuYjNaZllYQndjbTkyWldRZ1BTQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjFjbmtnTWdvS1lYQndjbTkyWlY5a1pXRjBhRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdhV1lnYVhOZmRtVnlhV1pwWlhJNkNpQWdJQ0JrZFhBS0lDQWdJR0o2SUdGd2NISnZkbVZmWkdWaGRHaGZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFd01Rb2dJQ0FnTHk4Z2RtRjFiSFF1ZG1WeWFXWnBaWEpmWVhCd2NtOTJaV1FnUFNCaGNtTTBMa0p2YjJ3b1ZISjFaU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKMWNua2dNZ29LWVhCd2NtOTJaVjlrWldGMGFGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFd015MHhNRFFLSUNBZ0lDOHZJQ01nU1dZZ015OHpJR052Ym5ObGJuTjFjeUJ5WldGamFHVmtMQ0IxYm14dlkyc2dkR2hsSUhaaGRXeDBDaUFnSUNBdkx5QnBaaUIyWVhWc2RDNW9iM053YVhSaGJGOWhjSEJ5YjNabFpDNXVZWFJwZG1VZ1lXNWtJSFpoZFd4MExtZHZkbDloY0hCeWIzWmxaQzV1WVhScGRtVWdZVzVrSUhaaGRXeDBMblpsY21sbWFXVnlYMkZ3Y0hKdmRtVmtMbTVoZEdsMlpUb0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5vZ1lYQndjbTkyWlY5a1pXRjBhRjloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o2SUdGd2NISnZkbVZmWkdWaGRHaGZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllaUJoY0hCeWIzWmxYMlJsWVhSb1gyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUhaaGRXeDBMbWx6WDNWdWJHOWphMlZrSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHUjFjQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmlkWEo1SURJS0NtRndjSEp2ZG1WZlpHVmhkR2hmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm1kR1Z5YkdsbVpWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNRGNLSUNBZ0lDOHZJSE5sYkdZdWRtRjFiSFJ6VzI5M2JtVnlYU0E5SUhaaGRXeDBMbU52Y0hrb0tTQWpJRHd0TFNCQlJFUkZSQ0F1UTA5UVdTZ3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXWjBaWEpzYVdabFgzWmhkV3gwTG1OdmJuUnlZV04wTGtGbWRHVnliR2xtWlZaaGRXeDBMbU5oYm1ObGJGOWtaV0YwYUY5d2NtOTBiMk52YkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTmhibU5sYkY5a1pXRjBhRjl3Y205MGIyTnZiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUIyWVhWc2RDQTlJSE5sYkdZdWRtRjFiSFJ6VzI5M2JtVnlYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luWmhkV3gwY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCdmQyNWxjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEV6Q2lBZ0lDQXZMeUIyWVhWc2RDQTlJSE5sYkdZdWRtRjFiSFJ6VzI5M2JtVnlYUzVqYjNCNUtDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyWVhWc2RITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV1owWlhKc2FXWmxYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnWVhOelpYSjBJSFpoZFd4MExtbHpYMkZqZEdsMlpTNXVZWFJwZG1Vc0lDSldZWFZzZENCcGN5QnViM1FnWVdOMGFYWmxJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QldZWFZzZENCcGN5QnViM1FnWVdOMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXhOZ29nSUNBZ0x5OGdZWE56WlhKMElHNXZkQ0IyWVhWc2RDNXBjMTkxYm14dlkydGxaQzV1WVhScGRtVXNJQ0pXWVhWc2RDQmhiSEpsWVdSNUlIQmxjbTFoYm1WdWRHeDVJSFZ1Ykc5amEyVmtJZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJXWVhWc2RDQmhiSEpsWVdSNUlIQmxjbTFoYm1WdWRHeDVJSFZ1Ykc5amEyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXhPQzB4TVRrS0lDQWdJQzh2SUNNZ1VtVnpaWFFnZEdobElHRndjSEp2ZG1Gc2N3b2dJQ0FnTHk4Z2RtRjFiSFF1YUc5emNHbDBZV3hmWVhCd2NtOTJaV1FnUFNCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm1kR1Z5YkdsbVpWOTJZWFZzZEM5amIyNTBjbUZqZEM1d2VUb3hNakFLSUNBZ0lDOHZJSFpoZFd4MExtZHZkbDloY0hCeWIzWmxaQ0E5SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGbWRHVnliR2xtWlY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1UZ3RNVEU1Q2lBZ0lDQXZMeUFqSUZKbGMyVjBJSFJvWlNCaGNIQnliM1poYkhNS0lDQWdJQzh2SUhaaGRXeDBMbWh2YzNCcGRHRnNYMkZ3Y0hKdmRtVmtJRDBnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFpuUmxjbXhwWm1WZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QjJZWFZzZEM1bmIzWmZZWEJ3Y205MlpXUWdQU0JoY21NMExrSnZiMndvUm1Gc2MyVXBDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUIyWVhWc2RDNTJaWEpwWm1sbGNsOWhjSEJ5YjNabFpDQTlJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TVRndE1URTVDaUFnSUNBdkx5QWpJRkpsYzJWMElIUm9aU0JoY0hCeWIzWmhiSE1LSUNBZ0lDOHZJSFpoZFd4MExtaHZjM0JwZEdGc1gyRndjSEp2ZG1Wa0lEMGdZWEpqTkM1Q2IyOXNLRVpoYkhObEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCMllYVnNkQzUyWlhKcFptbGxjbDloY0hCeWIzWmxaQ0E5SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TWpNS0lDQWdJQzh2SUhObGJHWXVkbUYxYkhSelcyOTNibVZ5WFNBOUlIWmhkV3gwTG1OdmNIa29LU0FqSUR3dExTQkJSRVJGUkNBdVEwOVFXU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZtZEdWeWJHbG1aVjkyWVhWc2RDNWpiMjUwY21GamRDNUJablJsY214cFptVldZWFZzZEM1blpYUmZZbVZ1WldacFkybGhjbWxsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlpWlc1bFptbGphV0Z5YVdWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGbWRHVnliR2xtWlY5MllYVnNkQzlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV1owWlhKc2FXWmxYM1poZFd4MEwyTnZiblJ5WVdOMExuQjVPakV5T0FvZ0lDQWdMeThnZG1GMWJIUWdQU0J6Wld4bUxuWmhkV3gwYzF0dmQyNWxjbDB1WTI5d2VTZ3BJQ01nUEMwdElFRkVSRVZFSUM1RFQxQlpLQ2tnVkU4Z1VrVkJSQ0JXUVV4VlJRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRtRjFiSFJ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJZWFZzZEhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIWmhkV3gwTG1KbGJtVm1hV05wWVhKcFpYTUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E1TndvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhablJsY214cFptVmZkbUYxYkhRdlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdaMFpYSnNhV1psWDNaaGRXeDBMbU52Ym5SeVlXTjBMa0ZtZEdWeWJHbG1aVlpoZFd4MExtbHpYM1poZFd4MFgzVnViRzlqYTJWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE5mZG1GMWJIUmZkVzVzYjJOclpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXWjBaWEpzYVdabFgzWmhkV3gwTDJOdmJuUnlZV04wTG5CNU9qRXpNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWm5SbGNteHBabVZmZG1GMWJIUXZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCMllYVnNkQ0E5SUhObGJHWXVkbUYxYkhSelcyOTNibVZ5WFM1amIzQjVLQ2tnSXlBOExTMGdRVVJFUlVRZ0xrTlBVRmtvS1NCVVR5QlNSVUZFSUZaQlRGVkZDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjJZWFZzZEhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFpuUmxjbXhwWm1WZmRtRjFiSFF2WTI5dWRISmhZM1F1Y0hrNk1UTTBMVEV6TlFvZ0lDQWdMeThnZG1GMWJIUWdQU0J6Wld4bUxuWmhkV3gwYzF0dmQyNWxjbDB1WTI5d2VTZ3BJQ01nUEMwdElFRkVSRVZFSUM1RFQxQlpLQ2tnVkU4Z1VrVkJSQ0JXUVV4VlJRb2dJQ0FnTHk4Z2NtVjBkWEp1SUhaaGRXeDBMbWx6WDNWdWJHOWphMlZrTG01aGRHbDJaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZtZEdWeWJHbG1aVjkyWVhWc2RDOWpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUhKbGRIVnliaUIyWVhWc2RDNXBjMTkxYm14dlkydGxaQzV1WVhScGRtVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdaMFpYSnNhV1psWDNaaGRXeDBMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQWlZREFRQUdkbUYxYkhSekJCVWZmSFV4RzBFQU9URVpGRVF4R0VTQ0JnUlpNTkJmQkVhTnFqNEVLYXFZS1FUbFM5UHhCRm1USmF3RXRJUytYVFlhQUk0R0FBa0E0d0VPQWFZQjJnSDFBREVaRkRFWUZCQkRJallhQVVjQ0lsbEpUZ0pKSkFzbENFOENGUkpFTmhvQ1NVNENTU0paU1U0RFNZRUlDeVVJVHdJVkVrUTJHZ05KVGdNVkpCSkVOaG9FU1U0REZTUVNSRFlhQlVsT0F4VWtFa1FTUkNKSlNVc0dERUVBR2tzR1Z3SUFTd0ZKVGdLQkNBdGJTd01JUlFNakNFVUJRdi9mU3dHQlpCSkVnQUlBQUVVS0lrVUJTVXNJREVFQU5rc0lWd0lBU3dGSlRnSWtDeVJZU3doWEFnQkxBb0VJQzRFSVdGQkxDMGxQQWxCTUlsa2pDQlpYQmdKY0FFVUxJd2hGQVVML3c0QUJnRXNGVUVzRVVFc0RVSUFDQUdOUVN3cFFLVEVBVUVtOFNFeS9JME0yR2dGSkZTUVNSQ2xNVUVraUk3cEpJbE1vSWs4Q1ZDSlRSREVBU3dJakpMb1NSQ1VqVkNKTXV5TkROaG9CU1JVa0VrUXBURkJIQXI1TVRnSkVTU0lqdWtraVV5Z2lUd0pVSWxORUpWTW9JazhDVkNKVFJERUFTd0dCSVNTNkVqRUFUd0tCUVNTNkVrbE9Ba3NCRVVSQkFBaExBWUVESTFSRkFrbEJBQWhMQVlFRUkxUkZBa3NCSlZNb0lrOENWQ0pUUVFBbFN3R0JBMU1vSWs4Q1ZDSlRRUUFXU3dHQkJGTW9JazhDVkNKVFFRQUhTd0VqU1ZSRkFrc0NTYnhJU3dLL0kwTXBNUUJRU2I1RVN3RWlJN3BKSWxNb0lrOENWQ0pUUkNOVEtDSlBBbFFpVXhSRUpTSlVnUU1pVklFRUlsUkxBYnhJdnlORE5ob0JTUlVrRWtRcFRGQytSRW1CWVZsTEFSVlNLa3hRc0NORE5ob0JTUlVrRWtRcFRGQWlJN29qVXlnaVR3SlVLa3hRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
