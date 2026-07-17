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

namespace Arc56.Generated.hariomphulre.Escrow_Based_Transcation_System.EscrowFactory_151a8db4
{


    public class EscrowFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetPlatformConfigReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public Algorand.Address Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetPlatformConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPlatformConfigReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPlatformConfigReturn);
                }
                public bool Equals(GetPlatformConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPlatformConfigReturn left, GetPlatformConfigReturn right)
                {
                    return EqualityComparer<GetPlatformConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPlatformConfigReturn left, GetPlatformConfigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the platform with treasury address, fee, and arbiter.
        ///</summary>
        /// <param name="treasury">- AlgoEscrow fee wallet (receives platform fees) </param>
        /// <param name="feeBps">- Platform fee in basis points (50 = 0.5%) </param>
        /// <param name="arbiter">- Address authorized to resolve disputes </param>
        public async Task CreateApplication(Algorand.Address treasury, ulong feeBps, Algorand.Address arbiter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 18, 235, 209 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);
            var arbiterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); arbiterAbi.From(arbiter);

            var result = await base.CallApp(new List<object> { abiHandle, treasuryAbi, feeBpsAbi, arbiterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address treasury, ulong feeBps, Algorand.Address arbiter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 18, 235, 209 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);
            var arbiterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); arbiterAbi.From(arbiter);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasuryAbi, feeBpsAbi, arbiterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="seller"> </param>
        /// <param name="itemName"> </param>
        /// <param name="escrowType"> </param>
        /// <param name="deadlineRounds"> </param>
        /// <param name="requirementsHash"> </param>
        /// <param name="escrowContractApp"> </param>
        public async Task<ulong> CreateEscrow(Algorand.Address seller, byte[] itemName, ulong escrowType, ulong deadlineRounds, byte[] requirementsHash, ulong escrowContractApp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 174, 3, 20 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var itemNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); itemNameAbi.From(itemName);
            var escrowTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowTypeAbi.From(escrowType);
            var deadlineRoundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineRoundsAbi.From(deadlineRounds);
            var requirementsHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); requirementsHashAbi.From(requirementsHash);
            var escrowContractAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowContractAppAbi.From(escrowContractApp);

            var result = await base.CallApp(new List<object> { abiHandle, sellerAbi, itemNameAbi, escrowTypeAbi, deadlineRoundsAbi, requirementsHashAbi, escrowContractAppAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateEscrow_Transactions(Algorand.Address seller, byte[] itemName, ulong escrowType, ulong deadlineRounds, byte[] requirementsHash, ulong escrowContractApp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 174, 3, 20 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var itemNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); itemNameAbi.From(itemName);
            var escrowTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowTypeAbi.From(escrowType);
            var deadlineRoundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineRoundsAbi.From(deadlineRounds);
            var requirementsHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); requirementsHashAbi.From(requirementsHash);
            var escrowContractAppAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrowContractAppAbi.From(escrowContractApp);

            return await base.MakeTransactionList(new List<object> { abiHandle, sellerAbi, itemNameAbi, escrowTypeAbi, deadlineRoundsAbi, requirementsHashAbi, escrowContractAppAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetPlatformConfigReturn> GetPlatformConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 67, 250, 51 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPlatformConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPlatformConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 67, 250, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newFeeBps"> </param>
        public async Task UpdateFee(ulong newFeeBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 248, 141, 34 };
            var newFeeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newFeeBpsAbi.From(newFeeBps);

            var result = await base.CallApp(new List<object> { abiHandle, newFeeBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateFee_Transactions(ulong newFeeBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 248, 141, 34 };
            var newFeeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newFeeBpsAbi.From(newFeeBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, newFeeBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newArbiter"> </param>
        public async Task UpdateArbiter(Algorand.Address newArbiter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 11, 147, 208 };
            var newArbiterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newArbiterAbi.From(newArbiter);

            var result = await base.CallApp(new List<object> { abiHandle, newArbiterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateArbiter_Transactions(Algorand.Address newArbiter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 11, 147, 208 };
            var newArbiterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newArbiterAbi.From(newArbiter);

            return await base.MakeTransactionList(new List<object> { abiHandle, newArbiterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93RmFjdG9yeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRQbGF0Zm9ybUNvbmZpZ1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBwbGF0Zm9ybSB3aXRoIHRyZWFzdXJ5IGFkZHJlc3MsIGZlZSwgYW5kIGFyYml0ZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmVhc3VyeSIsImRlc2MiOiItIEFsZ29Fc2Nyb3cgZmVlIHdhbGxldCAocmVjZWl2ZXMgcGxhdGZvcm0gZmVlcykiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZUJwcyIsImRlc2MiOiItIFBsYXRmb3JtIGZlZSBpbiBiYXNpcyBwb2ludHMgKDUwID0gMC41JSkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmJpdGVyIiwiZGVzYyI6Ii0gQWRkcmVzcyBhdXRob3JpemVkIHRvIHJlc29sdmUgZGlzcHV0ZXMiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlRXNjcm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZW1OYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWFkbGluZVJvdW5kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWlyZW1lbnRzSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93Q29udHJhY3RBcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQbGF0Zm9ybUNvbmZpZyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyx1aW50NjQsdWludDY0LGFkZHJlc3MpIiwic3RydWN0IjoiR2V0UGxhdGZvcm1Db25maWdSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUZlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdGZWVCcHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQXJiaXRlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QXJiaXRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUzNF0sImVycm9yTWVzc2FnZSI6IkFyYml0ZXIgYWRkcmVzcyBtdXN0IGJlIHZhbGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM0XSwiZXJyb3JNZXNzYWdlIjoiRGVhZGxpbmUgcm91bmRzIG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTBdLCJlcnJvck1lc3NhZ2UiOiJGZWUgY2Fubm90IGV4Y2VlZCAxMDAwIGJhc2lzIHBvaW50cyAoMTAlKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgZXNjcm93IHR5cGUgKG11c3QgYmUgMCwgMSwgb3IgMikiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI5XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgY3JlYXRvciBjYW4gdXBkYXRlIHRoZSBhcmJpdGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA0XSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgY3JlYXRvciBjYW4gdXBkYXRlIHRoZSBwbGF0Zm9ybSBmZWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDBdLCJlcnJvck1lc3NhZ2UiOiJTZWxsZXIgYWRkcmVzcyBtdXN0IGJlIHByb3ZpZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUxLDM1Nl0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2NiwzNzEsMzc1LDQ0MCw0NTcsNDYxLDQ2NSw0NjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzAsMzA1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc4LDMxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjMsMjQwLDI2NCw1MjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxLDI4OSwyOTgsMzI0LDQ5N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBNElERWdNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbkJzWVhSbWIzSnRYMlpsWlY5aWNITWlJQ0owYjNSaGJGOWxjMk55YjNkeklpQWlZWEppYVhSbGNsOWhaR1J5WlhOeklpQWljR3hoZEdadmNtMWZkSEpsWVhOMWNua2lJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QndiR0YwWm05eWJWOTBjbVZoYzNWeWVTQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJCWTJOdmRXNTBLQ2tnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5Cc1lYUm1iM0p0WDNSeVpXRnpkWEo1SWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSEJzWVhSbWIzSnRYMlpsWlY5aWNITWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUExTUNCaGN5QjFhVzUwTmpRZ2ZTa2dMeThnWkdWbVlYVnNkQ0F3TGpVbENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2JHRjBabTl5YlY5bVpXVmZZbkJ6SWdvZ0lDQWdjSFZ6YUdsdWRDQTFNQ0F2THlBMU1Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QjBiM1JoYkY5bGMyTnliM2R6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01DQmhjeUIxYVc1ME5qUWdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyVnpZM0p2ZDNNaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlptRmpkRzl5ZVM1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCaGNtSnBkR1Z5WDJGa1pISmxjM01nUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1FXTmpiM1Z1ZENncElIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhjbUpwZEdWeVgyRmtaSEpsYzNNaUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWlhOamNtOTNYMk52Ym5SeVlXTjBYMkZ3Y0hKdmRtRnNYMnhsYmlBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklEQWdZWE1nZFdsdWREWTBJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbVZ6WTNKdmQxOWpiMjUwY21GamRGOWhjSEJ5YjNaaGJGOXNaVzRpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE55WXk5bGMyTnliM2RmWm1GamRHOXllUzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJsYzJOeWIzZGZZMjl1ZEhKaFkzUmZZWEJ3WDJsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCQmNIQnNhV05oZEdsdmJpZ3BJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbVZ6WTNKdmQxOWpiMjUwY21GamRGOWhjSEJmYVdRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRmMyTnliM2RHWVdOMGIzSjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRabU5oWlRBek1UUWdNSGcwTWpRelptRXpNeUF3ZURZM1pqZzRaREl5SURCNE5qQXdZamt6WkRBZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWRmMyTnliM2NvWVdSa2NtVnpjeXhpZVhSbFcxMHNkV2x1ZERZMExIVnBiblEyTkN4aWVYUmxXMTBzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwVUd4aGRHWnZjbTFEYjI1bWFXY29LU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3lraUxDQnRaWFJvYjJRZ0luVndaR0YwWlVabFpTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxRWEppYVhSbGNpaGhaR1J5WlhOektYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1ZGYzJOeWIzY2daMlYwVUd4aGRHWnZjbTFEYjI1bWFXY2dkWEJrWVhSbFJtVmxJSFZ3WkdGMFpVRnlZbWwwWlhJS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Eb0tJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhOamNtOTNSbUZqZEc5eWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWTVNVEpsWW1ReElDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZV1JrY21WemN5eDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHVnljZ29LQ2k4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qcEZjMk55YjNkR1lXTjBiM0o1TG1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owNXZUM0FuTENCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSEJzWVhSbWIzSnRYM1J5WldGemRYSjVJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUVGalkyOTFiblFvS1NCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHeGhkR1p2Y20xZmRISmxZWE4xY25raUNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2RHaHBjeTV3YkdGMFptOXliVjkwY21WaGMzVnllUzUyWVd4MVpTQTlJSFJ5WldGemRYSjVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NHeGhkR1p2Y20xZlptVmxYMkp3Y3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklEVXdJR0Z6SUhWcGJuUTJOQ0I5S1NBdkx5QmtaV1poZFd4MElEQXVOU1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJzWVhSbWIzSnRYMlpsWlY5aWNITWlDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdkR2hwY3k1d2JHRjBabTl5YlY5bVpXVmZZbkJ6TG5aaGJIVmxJRDBnWm1WbFFuQnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z1lYSmlhWFJsY2w5aFpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJwYm1sMGFXRnNWbUZzZFdVNklFRmpZMjkxYm5Rb0tTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEppYVhSbGNsOWhaR1J5WlhOeklnb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIUm9hWE11WVhKaWFYUmxjbDloWkdSeVpYTnpMblpoYkhWbElEMGdZWEppYVhSbGNnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QjBiM1JoYkY5bGMyTnliM2R6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01DQmhjeUIxYVc1ME5qUWdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyVnpZM0p2ZDNNaUNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGOWxjMk55YjNkekxuWmhiSFZsSUQwZ01DQmhjeUIxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3Snl3Z2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qcEZjMk55YjNkR1lXTjBiM0o1TG1OeVpXRjBaVVZ6WTNKdmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpVVnpZM0p2ZHpvS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlptRmpkRzl5ZVM1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdZWE56WlhKMEtHVnpZM0p2ZDFSNWNHVWdQRDBnS0RJZ1lYTWdkV2x1ZERZMEtTd2dKMGx1ZG1Gc2FXUWdaWE5qY205M0lIUjVjR1VnS0cxMWMzUWdZbVVnTUN3Z01Td2diM0lnTWlrbktRb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWlhOamNtOTNJSFI1Y0dVZ0tHMTFjM1FnWW1VZ01Dd2dNU3dnYjNJZ01pa0tJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QmhjM05sY25Rb1pHVmhaR3hwYm1WU2IzVnVaSE1nUGlBb01DQmhjeUIxYVc1ME5qUXBMQ0FuUkdWaFpHeHBibVVnY205MWJtUnpJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SURBbktRb2dJQ0FnWkdsbklESUtJQ0FnSUdGemMyVnlkQ0F2THlCRVpXRmtiR2x1WlNCeWIzVnVaSE1nYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHRnpjMlZ5ZENoelpXeHNaWElnSVQwOUlFRmpZMjkxYm5Rb0tTd2dKMU5sYkd4bGNpQmhaR1J5WlhOeklHMTFjM1FnWW1VZ2NISnZkbWxrWldRbktRb2dJQ0FnWkdsbklEVUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRaV3hzWlhJZ1lXUmtjbVZ6Y3lCdGRYTjBJR0psSUhCeWIzWnBaR1ZrQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem81TndvZ0lDQWdMeThnWTI5dWMzUWdaR1ZoWkd4cGJtVlNiM1Z1WkRvZ2RXbHVkRFkwSUQwZ1IyeHZZbUZzTG5KdmRXNWtJQ3NnWkdWaFpHeHBibVZTYjNWdVpITUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hNREV0TVRJekNpQWdJQ0F2THlCamIyNXpkQ0J1WlhkRmMyTnliM2NnUFNCcGRIaHVDaUFnSUNBdkx5QWdJQzVoY0hCc2FXTmhkR2x2YmtOaGJHd29ld29nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzVUhKdlozSmhiVG9nWlhOamNtOTNRMjl1ZEhKaFkzUkJjSEF1WVhCd2NtOTJZV3hRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0FnSUdOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0T2lCbGMyTnliM2REYjI1MGNtRmpkRUZ3Y0M1amJHVmhjbE4wWVhSbFVISnZaM0poYlN3S0lDQWdJQzh2SUNBZ0lDQm5iRzlpWVd4T2RXMVZhVzUwT2lBeE1pQmhjeUIxYVc1ME5qUXNJQ0FnTHk4Z2JuVnRZbVZ5SUc5bUlIVnBiblEyTkNCbmJHOWlZV3dnYzNSaGRHVWdjMnh2ZEhNS0lDQWdJQzh2SUNBZ0lDQm5iRzlpWVd4T2RXMUNlWFJsY3pvZ09DQmhjeUIxYVc1ME5qUXNJQzh2SUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJuYkc5aVlXd2djM1JoZEdVZ2MyeHZkSE1LSUNBZ0lDOHZJQ0FnSUNCc2IyTmhiRTUxYlZWcGJuUTZJREFnWVhNZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHeHZZMkZzVG5WdFFubDBaWE02SURBZ1lYTWdkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01DQmhjeUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1FYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lDQWdMeThnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRnWVhKbmN5QndZV05yWldRZ1ptOXlJSFJvWlNCamFHbHNaQ0JqYjI1MGNtRmpkQW9nSUNBZ0x5OGdJQ0FnSUNBZ2MyVnNiR1Z5TG1KNWRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2FYUmxiVTVoYldVc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLR1Z6WTNKdmQxUjVjR1VwTEFvZ0lDQWdMeThnSUNBZ0lDQWdiM0F1YVhSdllpaGtaV0ZrYkdsdVpWSnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQWdJSEpsY1hWcGNtVnRaVzUwYzBoaGMyZ3NDaUFnSUNBdkx5QWdJQ0FnSUNCdmNDNXBkRzlpS0hSb2FYTXVjR3hoZEdadmNtMWZabVZsWDJKd2N5NTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0IwYUdsekxuQnNZWFJtYjNKdFgzUnlaV0Z6ZFhKNUxuWmhiSFZsTG1KNWRHVnpMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2RHaHBjeTVoY21KcGRHVnlYMkZrWkhKbGMzTXVkbUZzZFdVdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1hTd0tJQ0FnSUM4dklDQWdJQ0JoWTJOdmRXNTBjem9nVzNObGJHeGxjaXdnZEdocGN5NXdiR0YwWm05eWJWOTBjbVZoYzNWeWVTNTJZV3gxWlN3Z2RHaHBjeTVoY21KcGRHVnlYMkZrWkhKbGMzTXVkbUZzZFdWZExBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdZWEJ3Y205MllXeFFjbTluY21GdE9pQmxjMk55YjNkRGIyNTBjbUZqZEVGd2NDNWhjSEJ5YjNaaGJGQnliMmR5WVcwc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVhCd2NtOTJZV3hRY205bmNtRnRDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pveE1EUUtJQ0FnSUM4dklHTnNaV0Z5VTNSaGRHVlFjbTluY21GdE9pQmxjMk55YjNkRGIyNTBjbUZqZEVGd2NDNWpiR1ZoY2xOMFlYUmxVSEp2WjNKaGJTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlptRmpkRzl5ZVM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z2IzQXVhWFJ2WWlobGMyTnliM2RVZVhCbEtTd0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCdmNDNXBkRzlpS0dSbFlXUnNhVzVsVW05MWJtUXBMQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pveE1UY0tJQ0FnSUM4dklHOXdMbWwwYjJJb2RHaHBjeTV3YkdGMFptOXliVjltWldWZlluQnpMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NHeGhkR1p2Y20xZlptVmxYMkp3Y3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklEVXdJR0Z6SUhWcGJuUTJOQ0I5S1NBdkx5QmtaV1poZFd4MElEQXVOU1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJzWVhSbWIzSnRYMlpsWlY5aWNITWlDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hNVGNLSUNBZ0lDOHZJRzl3TG1sMGIySW9kR2hwY3k1d2JHRjBabTl5YlY5bVpXVmZZbkJ6TG5aaGJIVmxLU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hNVGdLSUNBZ0lDOHZJSFJvYVhNdWNHeGhkR1p2Y20xZmRISmxZWE4xY25rdWRtRnNkV1V1WW5sMFpYTXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIQnNZWFJtYjNKdFgzUnlaV0Z6ZFhKNUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRUZqWTI5MWJuUW9LU0I5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0d4aGRHWnZjbTFmZEhKbFlYTjFjbmtpQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUhSb2FYTXVjR3hoZEdadmNtMWZkSEpsWVhOMWNua3VkbUZzZFdVdVlubDBaWE1zQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZNVEU1Q2lBZ0lDQXZMeUIwYUdsekxtRnlZbWwwWlhKZllXUmtjbVZ6Y3k1MllXeDFaUzVpZVhSbGN5d0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z1lYSmlhWFJsY2w5aFpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJwYm1sMGFXRnNWbUZzZFdVNklFRmpZMjkxYm5Rb0tTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZWEppYVhSbGNsOWhaR1J5WlhOeklnb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QjBhR2x6TG1GeVltbDBaWEpmWVdSa2NtVnpjeTUyWVd4MVpTNWllWFJsY3l3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnT1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCWTJOdmRXNTBjd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRV05qYjNWdWRITUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQlkyTnZkVzUwY3dvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem94TURZS0lDQWdJQzh2SUdkc2IySmhiRTUxYlVKNWRHVnpPaUE0SUdGeklIVnBiblEyTkN3Z0x5OGdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHZHNiMkpoYkNCemRHRjBaU0J6Ykc5MGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR2wwZUc1ZlptbGxiR1FnUjJ4dlltRnNUblZ0UW5sMFpWTnNhV05sQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUdkc2IySmhiRTUxYlZWcGJuUTZJREV5SUdGeklIVnBiblEyTkN3Z0lDQXZMeUJ1ZFcxaVpYSWdiMllnZFdsdWREWTBJR2RzYjJKaGJDQnpkR0YwWlNCemJHOTBjd29nSUNBZ2NIVnphR2x1ZENBeE1pQXZMeUF4TWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JIYkc5aVlXeE9kVzFWYVc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc1pXRnlVM1JoZEdWUWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qRXdNUzB4TWpJS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDBWelkzSnZkeUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ3Y0d4cFkyRjBhVzl1UTJGc2JDaDdDaUFnSUNBdkx5QWdJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRPaUJsYzJOeWIzZERiMjUwY21GamRFRndjQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMHNDaUFnSUNBdkx5QWdJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUdWelkzSnZkME52Ym5SeVlXTjBRWEJ3TG1Oc1pXRnlVM1JoZEdWUWNtOW5jbUZ0TEFvZ0lDQWdMeThnSUNBZ0lHZHNiMkpoYkU1MWJWVnBiblE2SURFeUlHRnpJSFZwYm5RMk5Dd2dJQ0F2THlCdWRXMWlaWElnYjJZZ2RXbHVkRFkwSUdkc2IySmhiQ0J6ZEdGMFpTQnpiRzkwY3dvZ0lDQWdMeThnSUNBZ0lHZHNiMkpoYkU1MWJVSjVkR1Z6T2lBNElHRnpJSFZwYm5RMk5Dd2dMeThnYm5WdFltVnlJRzltSUdKNWRHVnpJR2RzYjJKaGJDQnpkR0YwWlNCemJHOTBjd29nSUNBZ0x5OGdJQ0FnSUd4dlkyRnNUblZ0VldsdWREb2dNQ0JoY3lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2JHOWpZV3hPZFcxQ2VYUmxjem9nTUNCaGN5QjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0lHRnpJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiQ2lBZ0lDQXZMeUFnSUNBZ0lDQXZMeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaUJoY21keklIQmhZMnRsWkNCbWIzSWdkR2hsSUdOb2FXeGtJR052Ym5SeVlXTjBDaUFnSUNBdkx5QWdJQ0FnSUNCelpXeHNaWEl1WW5sMFpYTXNDaUFnSUNBdkx5QWdJQ0FnSUNCcGRHVnRUbUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQWdJRzl3TG1sMGIySW9aWE5qY205M1ZIbHdaU2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQnZjQzVwZEc5aUtHUmxZV1JzYVc1bFVtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lDQWdjbVZ4ZFdseVpXMWxiblJ6U0dGemFDd0tJQ0FnSUM4dklDQWdJQ0FnSUc5d0xtbDBiMklvZEdocGN5NXdiR0YwWm05eWJWOW1aV1ZmWW5CekxuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQWdJSFJvYVhNdWNHeGhkR1p2Y20xZmRISmxZWE4xY25rdWRtRnNkV1V1WW5sMFpYTXNDaUFnSUNBdkx5QWdJQ0FnSUNCMGFHbHpMbUZ5WW1sMFpYSmZZV1JrY21WemN5NTJZV3gxWlM1aWVYUmxjeXdLSUNBZ0lDOHZJQ0FnSUNCZExBb2dJQ0FnTHk4Z0lDQWdJR0ZqWTI5MWJuUnpPaUJiYzJWc2JHVnlMQ0IwYUdsekxuQnNZWFJtYjNKdFgzUnlaV0Z6ZFhKNUxuWmhiSFZsTENCMGFHbHpMbUZ5WW1sMFpYSmZZV1JrY21WemN5NTJZV3gxWlYwc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk1UQTVDaUFnSUNBdkx5Qm1aV1U2SURBZ1lYTWdkV2x1ZERZMExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pveE1ERXRNVEl6Q2lBZ0lDQXZMeUJqYjI1emRDQnVaWGRGYzJOeWIzY2dQU0JwZEhodUNpQWdJQ0F2THlBZ0lDNWhjSEJzYVdOaGRHbHZia05oYkd3b2V3b2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJUb2daWE5qY205M1EyOXVkSEpoWTNSQmNIQXVZWEJ3Y205MllXeFFjbTluY21GdExBb2dJQ0FnTHk4Z0lDQWdJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJsYzJOeWIzZERiMjUwY21GamRFRndjQzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU3dLSUNBZ0lDOHZJQ0FnSUNCbmJHOWlZV3hPZFcxVmFXNTBPaUF4TWlCaGN5QjFhVzUwTmpRc0lDQWdMeThnYm5WdFltVnlJRzltSUhWcGJuUTJOQ0JuYkc5aVlXd2djM1JoZEdVZ2MyeHZkSE1LSUNBZ0lDOHZJQ0FnSUNCbmJHOWlZV3hPZFcxQ2VYUmxjem9nT0NCaGN5QjFhVzUwTmpRc0lDOHZJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm5iRzlpWVd3Z2MzUmhkR1VnYzJ4dmRITUtJQ0FnSUM4dklDQWdJQ0JzYjJOaGJFNTFiVlZwYm5RNklEQWdZWE1nZFdsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUd4dlkyRnNUblZ0UW5sMFpYTTZJREFnWVhNZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUNCaGN5QjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUNBZ0x5OGdZM0psWVhSbFFYQndiR2xqWVhScGIyNGdZWEpuY3lCd1lXTnJaV1FnWm05eUlIUm9aU0JqYUdsc1pDQmpiMjUwY21GamRBb2dJQ0FnTHk4Z0lDQWdJQ0FnYzJWc2JHVnlMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQWdJQ0FnYVhSbGJVNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQnZjQzVwZEc5aUtHVnpZM0p2ZDFSNWNHVXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ2IzQXVhWFJ2WWloa1pXRmtiR2x1WlZKdmRXNWtLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lISmxjWFZwY21WdFpXNTBjMGhoYzJnc0NpQWdJQ0F2THlBZ0lDQWdJQ0J2Y0M1cGRHOWlLSFJvYVhNdWNHeGhkR1p2Y20xZlptVmxYMkp3Y3k1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQjBhR2x6TG5Cc1lYUm1iM0p0WDNSeVpXRnpkWEo1TG5aaGJIVmxMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQWdJQ0FnZEdocGN5NWhjbUpwZEdWeVgyRmtaSEpsYzNNdWRtRnNkV1V1WW5sMFpYTXNDaUFnSUNBdkx5QWdJQ0FnWFN3S0lDQWdJQzh2SUNBZ0lDQmhZMk52ZFc1MGN6b2dXM05sYkd4bGNpd2dkR2hwY3k1d2JHRjBabTl5YlY5MGNtVmhjM1Z5ZVM1MllXeDFaU3dnZEdocGN5NWhjbUpwZEdWeVgyRmtaSEpsYzNNdWRtRnNkV1ZkTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hNallLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hmWlhOamNtOTNjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hmWlhOamNtOTNjeTUyWVd4MVpTQXJJQ2d4SUdGeklIVnBiblEyTkNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnZEc5MFlXeGZaWE5qY205M2N5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnWVhNZ2RXbHVkRFkwSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjlsYzJOeWIzZHpJZ29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZNVEkyQ2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzWDJWelkzSnZkM011ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzWDJWelkzSnZkM011ZG1Gc2RXVWdLeUFvTVNCaGN5QjFhVzUwTmpRcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QjBiM1JoYkY5bGMyTnliM2R6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01DQmhjeUIxYVc1ME5qUWdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gyVnpZM0p2ZDNNaUNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pveE1qWUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeGZaWE5qY205M2N5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeGZaWE5qY205M2N5NTJZV3gxWlNBcklDZ3hJR0Z6SUhWcGJuUTJOQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA1dlQzQW5JSDBwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZPa1Z6WTNKdmQwWmhZM1J2Y25rdVoyVjBVR3hoZEdadmNtMURiMjVtYVdkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJRYkdGMFptOXliVU52Ym1acFp6b0tJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qRTBNQW9nSUNBZ0x5OGdkR2hwY3k1d2JHRjBabTl5YlY5MGNtVmhjM1Z5ZVM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdjR3hoZEdadmNtMWZkSEpsWVhOMWNua2dQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nUVdOamIzVnVkQ2dwSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd2JHRjBabTl5YlY5MGNtVmhjM1Z5ZVNJS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlptRmpkRzl5ZVM1aGJHZHZMblJ6T2pFME1Bb2dJQ0FnTHk4Z2RHaHBjeTV3YkdGMFptOXliVjkwY21WaGMzVnllUzUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pveE5ERUtJQ0FnSUM4dklIUm9hWE11Y0d4aGRHWnZjbTFmWm1WbFgySndjeTUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NHeGhkR1p2Y20xZlptVmxYMkp3Y3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklEVXdJR0Z6SUhWcGJuUTJOQ0I5S1NBdkx5QmtaV1poZFd4MElEQXVOU1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJzWVhSbWIzSnRYMlpsWlY5aWNITWlDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hOREVLSUNBZ0lDOHZJSFJvYVhNdWNHeGhkR1p2Y20xZlptVmxYMkp3Y3k1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hORElLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hmWlhOamNtOTNjeTUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2RHOTBZV3hmWlhOamNtOTNjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SURBZ1lYTWdkV2x1ZERZMElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5bGMyTnliM2R6SWdvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRReUNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1gyVnpZM0p2ZDNNdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZNVFF6Q2lBZ0lDQXZMeUIwYUdsekxtRnlZbWwwWlhKZllXUmtjbVZ6Y3k1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdZWEppYVhSbGNsOWhaR1J5WlhOeklEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRUZqWTI5MWJuUW9LU0I5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVhKaWFYUmxjbDloWkdSeVpYTnpJZ29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTltWVdOMGIzSjVMbUZzWjI4dWRITTZNVFF6Q2lBZ0lDQXZMeUIwYUdsekxtRnlZbWwwWlhKZllXUmtjbVZ6Y3k1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hNemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5d2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6bzZSWE5qY205M1JtRmpkRzl5ZVM1MWNHUmhkR1ZHWldWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWR1pXVTZDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMlpoWTNSdmNua3VZV3huYnk1MGN6b3hOVE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ2RPYjA5d0p5QjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRVMkNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TENBblQyNXNlU0IwYUdVZ1kzSmxZWFJ2Y2lCallXNGdkWEJrWVhSbElIUm9aU0J3YkdGMFptOXliU0JtWldVbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnZEdobElHTnlaV0YwYjNJZ1kyRnVJSFZ3WkdGMFpTQjBhR1VnY0d4aGRHWnZjbTBnWm1WbENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyWmhZM1J2Y25rdVlXeG5ieTUwY3pveE5Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENodVpYZEdaV1ZDY0hNZ1BEMGdLREV3TURBZ1lYTWdkV2x1ZERZMEtTd2dKMFpsWlNCallXNXViM1FnWlhoalpXVmtJREV3TURBZ1ltRnphWE1nY0c5cGJuUnpJQ2d4TUNVcEp5a0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd0lDOHZJREV3TURBS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSbVZsSUdOaGJtNXZkQ0JsZUdObFpXUWdNVEF3TUNCaVlYTnBjeUJ3YjJsdWRITWdLREV3SlNrS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlptRmpkRzl5ZVM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCd2JHRjBabTl5YlY5bVpXVmZZbkJ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ05UQWdZWE1nZFdsdWREWTBJSDBwSUM4dklHUmxabUYxYkhRZ01DNDFKUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljR3hoZEdadmNtMWZabVZsWDJKd2N5SUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qRTJNUW9nSUNBZ0x5OGdkR2hwY3k1d2JHRjBabTl5YlY5bVpXVmZZbkJ6TG5aaGJIVmxJRDBnYm1WM1JtVmxRbkJ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem82UlhOamNtOTNSbUZqZEc5eWVTNTFjR1JoZEdWQmNtSnBkR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUVhKaWFYUmxjam9LSUNBZ0lDOHZJSE55WXk5bGMyTnliM2RmWm1GamRHOXllUzVoYkdkdkxuUnpPakUyT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA1dlQzQW5JSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE55WXk5bGMyTnliM2RmWm1GamRHOXllUzVoYkdkdkxuUnpPakUzTWdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlFZHNiMkpoYkM1amNtVmhkRzl5UVdSa2NtVnpjeXdnSjA5dWJIa2dkR2hsSUdOeVpXRjBiM0lnWTJGdUlIVndaR0YwWlNCMGFHVWdZWEppYVhSbGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMGFHVWdZM0psWVhSdmNpQmpZVzRnZFhCa1lYUmxJSFJvWlNCaGNtSnBkR1Z5Q2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJaaFkzUnZjbmt1WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkQmNtSnBkR1Z5SUNFOVBTQkJZMk52ZFc1MEtDa3NJQ2RCY21KcGRHVnlJR0ZrWkhKbGMzTWdiWFZ6ZENCaVpTQjJZV3hwWkNjcENpQWdJQ0JrZFhBS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQmNtSnBkR1Z5SUdGa1pISmxjM01nYlhWemRDQmlaU0IyWVd4cFpBb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOW1ZV04wYjNKNUxtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklHRnlZbWwwWlhKZllXUmtjbVZ6Y3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQkJZMk52ZFc1MEtDa2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ5WW1sMFpYSmZZV1JrY21WemN5SUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZabUZqZEc5eWVTNWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdkR2hwY3k1aGNtSnBkR1Z5WDJGa1pISmxjM011ZG1Gc2RXVWdQU0J1WlhkQmNtSnBkR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5bVlXTjBiM0o1TG1Gc1oyOHVkSE02TVRZNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBZ0JJQ1lGRUhCc1lYUm1iM0p0WDJabFpWOWljSE1OZEc5MFlXeGZaWE5qY205M2N3OWhjbUpwZEdWeVgyRmtaSEpsYzNNUmNHeGhkR1p2Y20xZmRISmxZWE4xY25rRUZSOThkVEVZUUFCSkt6SURaeWlCTW1jcEltY3FNZ05uZ0J4bGMyTnliM2RmWTI5dWRISmhZM1JmWVhCd2NtOTJZV3hmYkdWdUltZUFGbVZ6WTNKdmQxOWpiMjUwY21GamRGOWhjSEJmYVdRaVp6RVpGRVF4R0VFQUpJSUVCUHl1QXhRRVFrUDZNd1JuK0kwaUJHQUxrOUEyR2dDT0JBQTRBUDBCSVFFN0FJQUUrUkxyMFRZYUFJNEJBQUVBTmhvQlNSVWxFa1EyR2dKSkZTTVNSQmMyR2dOSkZTVVNSQ3RQQTJjb1R3Sm5La3huS1NKbkpFTTJHZ0ZKRlNVU1JEWWFBa2tpV1lFQ0NFc0JGUkpFVndJQU5ob0RTUlVqRWtRWE5ob0VTUlVqRWtRWE5ob0ZTU0paZ1FJSVN3RVZFa1JYQWdBMkdnWkpGU01TUkJkTEE0RUNEa1JMQWtSTEJUSURFMFF5Qms4RENMRkxBWElBUkU4Q2NnRkVUd1FXVHdNV0lpaGxSQllpSzJWRUlpcGxSRXNKc2h4TEFiSWNTYkljVHdteUdrOElzaHBQQkxJYVR3T3lHazhGc2hwUEFySWFUTElhc2hvanNqV0JETEkwc2tLeVFJRUdzaEFpc2dHenREMGlLV1ZFSkFncFRHY1dKd1JNVUxBa1F5SXJaVVFpS0dWRUlpbGxSQ0lxWlVSUEFoWlBBMHhRVHdJV1VFeFFKd1JNVUxBa1F6WWFBVWtWSXhKRUZ6RUFNZ2tTUkVtQjZBY09SQ2hNWnlSRE5ob0JTUlVsRWtReEFESUpFa1JKTWdNVFJDcE1aeVJEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
