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

namespace Arc56.Generated.compx_labs.flux_access_controls.flux_gate_9fada13f
{


    public class flux-gateProxy : ProxyBase
	{
		public override AppDescriptionArc56 App { get; set; }

    public flux-gateProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
    {
        App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

    }

    public class Structs
    {
        public class FluxRecord : AVMObjectType
        {
            public ulong Tier { get; set; }

            public byte[] ToByteArray()
            {
                var ret = new List<byte>();
                var stringRef = new Dictionary<int, byte[]>();
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vTier.From(Tier);
                ret.AddRange(vTier.Encode());
                foreach (var item in stringRef)
                {
                    var b1 = ret.Count;
                    ret[item.Key] = Convert.ToByte(b1 / 256);
                    ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                    ret.AddRange(item.Value);
                }
                return ret.ToArray();

            }

            public static FluxRecord Parse(byte[] bytes)
            {
                var queue = new Queue<byte>(bytes);
                var ret = new FluxRecord();
                uint count = 0;
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vTier.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueTier = vTier.ToValue();
                if (valueTier is ulong vTierValue) { ret.Tier = vTierValue; }
                return ret;

            }

            public override string ToString()
            {
                return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
            }
            public override bool Equals(object? obj)
            {
                return Equals(obj as FluxRecord);
            }
            public bool Equals(FluxRecord? other)
            {
                return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
            }
            public override int GetHashCode()
            {
                return ToByteArray().GetHashCode();
            }
            public static bool operator ==(FluxRecord left, FluxRecord right)
            {
                return EqualityComparer<FluxRecord>.Default.Equals(left, right);
            }
            public static bool operator !=(FluxRecord left, FluxRecord right)
            {
                return !(left == right);
            }

        }

        public class FluxRecordKey : AVMObjectType
        {
            public Algorand.Address UserAddress { get; set; }

            public byte[] ToByteArray()
            {
                var ret = new List<byte>();
                var stringRef = new Dictionary<int, byte[]>();
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vUserAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                vUserAddress.From(UserAddress);
                ret.AddRange(vUserAddress.Encode());
                foreach (var item in stringRef)
                {
                    var b1 = ret.Count;
                    ret[item.Key] = Convert.ToByte(b1 / 256);
                    ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                    ret.AddRange(item.Value);
                }
                return ret.ToArray();

            }

            public static FluxRecordKey Parse(byte[] bytes)
            {
                var queue = new Queue<byte>(bytes);
                var ret = new FluxRecordKey();
                uint count = 0;
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vUserAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                count = vUserAddress.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueUserAddress = vUserAddress.ToValue();
                if (valueUserAddress is Algorand.Address vUserAddressValue) { ret.UserAddress = vUserAddressValue; }
                return ret;

            }

            public override string ToString()
            {
                return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
            }
            public override bool Equals(object? obj)
            {
                return Equals(obj as FluxRecordKey);
            }
            public bool Equals(FluxRecordKey? other)
            {
                return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
            }
            public override int GetHashCode()
            {
                return ToByteArray().GetHashCode();
            }
            public static bool operator ==(FluxRecordKey left, FluxRecordKey right)
            {
                return EqualityComparer<FluxRecordKey>.Default.Equals(left, right);
            }
            public static bool operator !=(FluxRecordKey left, FluxRecordKey right)
            {
                return !(left == right);
            }

        }

		}

		///<summary>
        ///
        ///</summary>
		/// <param name="admin"> </param>
		public async Task CreateApplication(Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { admin });
            byte adminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 83, 254, 254 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { admin });
            byte adminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 83, 254, 254 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbrTxn"> </param>
        public async Task InitApplication(PaymentTransaction mbrTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrTxn });
            byte[] abiHandle = { 249, 39, 169, 246 };

            var result = await base.CallApp(new List<object> { abiHandle, mbrTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitApplication_Transactions(PaymentTransaction mbrTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrTxn });
            byte[] abiHandle = { 249, 39, 169, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tierNumber"> </param>
        /// <param name="minRequired"> </param>
        public async Task AddFluxTier(ulong tierNumber, ulong minRequired, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 71, 177, 142 };
            var tierNumberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tierNumberAbi.From(tierNumber);
            var minRequiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minRequiredAbi.From(minRequired);

            var result = await base.CallApp(new List<object> { abiHandle, tierNumberAbi, minRequiredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddFluxTier_Transactions(ulong tierNumber, ulong minRequired, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 71, 177, 142 };
            var tierNumberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tierNumberAbi.From(tierNumber);
            var minRequiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minRequiredAbi.From(minRequired);

            return await base.MakeTransactionList(new List<object> { abiHandle, tierNumberAbi, minRequiredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tierNumber"> </param>
        public async Task RemoveFluxTier(ulong tierNumber, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 138, 3, 24 };
            var tierNumberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tierNumberAbi.From(tierNumber);

            var result = await base.CallApp(new List<object> { abiHandle, tierNumberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveFluxTier_Transactions(ulong tierNumber, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 138, 3, 24 };
            var tierNumberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tierNumberAbi.From(tierNumber);

            return await base.MakeTransactionList(new List<object> { abiHandle, tierNumberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="tier"> </param>
        public async Task SetUserTier(Algorand.Address user, ulong tier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 125, 0, 207 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var tierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tierAbi.From(tier);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, tierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetUserTier_Transactions(Algorand.Address user, ulong tier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 125, 0, 207 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var tierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tierAbi.From(tier);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, tierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetUserTier(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 215, 170, 92 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUserTier_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 215, 170, 92 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiZmx1eC1nYXRlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkZsdXhSZWNvcmQiOlt7Im5hbWUiOiJ0aWVyIiwidHlwZSI6InVpbnQ2NCJ9XSwiRmx1eFJlY29yZEtleSI6W3sibmFtZSI6InVzZXJBZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXRBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJUeG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkRmx1eFRpZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGllck51bWJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluUmVxdWlyZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlRmx1eFRpZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGllck51bWJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRVc2VyVGllciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVc2VyVGllciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzA4LDM0Nyw0MjVdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEzLDM1Miw0MjZdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNCwxNDgsMTY3LDE4MywyMDIsMjI0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXJ0IHRhcmdldCBpcyBtYXRjaCBmb3IgY29uZGl0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNywxNTEsMTcwLDE4NiwyMDVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk3LDMyNywzNDIsMzgyLDM5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURFd0lERTJDaUFnSUNCaWVYUmxZMkpzYjJOcklDSm1kQ0lnSW1OMWNuSmxiblJmYm5WdFgzUnBaWEp6SWlBaVlXUnRhVzVmWVdOamIzVnVkQ0lnSW1ac2RYaGZjbVZqYjNKa0lpQXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk1qQXRNakVLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUc1aGJXVTZJQ0ptYkhWNExXZGhkR1VpTENCaGRtMVdaWEp6YVc5dU9pQXhNU0I5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFWnNkWGhIWVhSbElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1JoTlRObVpXWmxJREI0WmpreU4yRTVaallnTUhnMVlqUTNZakU0WlNBd2VEWmpPR0V3TXpFNElEQjRZVEEzWkRBd1kyWWdNSGhrTkdRM1lXRTFZeUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0dGalkyOTFiblFwZG05cFpDSXNJRzFsZEdodlpDQWlhVzVwZEVGd2NHeHBZMkYwYVc5dUtIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSmhaR1JHYkhWNFZHbGxjaWgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGJXOTJaVVpzZFhoVWFXVnlLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUlZjMlZ5VkdsbGNpaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSVmMyVnlWR2xsY2loaFpHUnlaWE56S1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU15QnRZV2x1WDJsdWFYUkJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQTBJRzFoYVc1ZllXUmtSbXgxZUZScFpYSmZjbTkxZEdWQU5TQnRZV2x1WDNKbGJXOTJaVVpzZFhoVWFXVnlYM0p2ZFhSbFFEWWdiV0ZwYmw5elpYUlZjMlZ5VkdsbGNsOXliM1YwWlVBM0lHMWhhVzVmWjJWMFZYTmxjbFJwWlhKZmNtOTFkR1ZBT0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnNkWGhmWjJGMFpTOW1iSFY0TFdkaGRHVXVZV3huYnk1MGN6b3lNQzB5TVFvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzZ2JtRnRaVG9nSW1ac2RYZ3RaMkYwWlNJc0lHRjJiVlpsY25OcGIyNDZJREV4SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSbXgxZUVkaGRHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlZ6WlhKVWFXVnlYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpteDFlRjluWVhSbEwyWnNkWGd0WjJGMFpTNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQWlUbTlQY0NJZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJac2RYaGZaMkYwWlM5bWJIVjRMV2RoZEdVdVlXeG5ieTUwY3pveU1DMHlNUW9nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYm1GdFpUb2dJbVpzZFhndFoyRjBaU0lzSUdGMmJWWmxjbk5wYjI0NklERXhJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1JteDFlRWRoZEdVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBaVRtOVBjQ0lnZlNrS0lDQWdJR05oYkd4emRXSWdaMlYwVlhObGNsUnBaWElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJWYzJWeVZHbGxjbDl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnNkWGhmWjJGMFpTOW1iSFY0TFdkaGRHVXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJazV2VDNBaUlIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk1qQXRNakVLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUc1aGJXVTZJQ0ptYkhWNExXZGhkR1VpTENCaGRtMVdaWEp6YVc5dU9pQXhNU0I5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFWnNkWGhIWVhSbElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJac2RYaGZaMkYwWlM5bWJIVjRMV2RoZEdVdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrNXZUM0FpSUgwcENpQWdJQ0JqWVd4c2MzVmlJSE5sZEZWelpYSlVhV1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psYlc5MlpVWnNkWGhVYVdWeVgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBaVRtOVBjQ0lnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem95TUMweU1Rb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2dibUZ0WlRvZ0ltWnNkWGd0WjJGMFpTSXNJR0YyYlZabGNuTnBiMjQ2SURFeElIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUm14MWVFZGhkR1VnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabXgxZUY5bllYUmxMMlpzZFhndFoyRjBaUzVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFpVG05UGNDSWdmU2tLSUNBZ0lHTmhiR3h6ZFdJZ2NtVnRiM1psUm14MWVGUnBaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1JrUm14MWVGUnBaWEpmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ0pPYjA5d0lpQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpteDFlRjluWVhSbEwyWnNkWGd0WjJGMFpTNWhiR2R2TG5Sek9qSXdMVEl4Q2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCdVlXMWxPaUFpWm14MWVDMW5ZWFJsSWl3Z1lYWnRWbVZ5YzJsdmJqb2dNVEVnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkdiSFY0UjJGMFpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSk9iMDl3SWlCOUtRb2dJQ0FnWTJGc2JITjFZaUJoWkdSR2JIVjRWR2xsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYm1sMFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSk9iMDl3SWlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pJd0xUSXhDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ1WVcxbE9pQWlabXgxZUMxbllYUmxJaXdnWVhadFZtVnljMmx2YmpvZ01URWdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCR2JIVjRSMkYwWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnNkWGhmWjJGMFpTOW1iSFY0TFdkaGRHVXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJazV2VDNBaUlIMHBDaUFnSUNCallXeHNjM1ZpSUdsdWFYUkJjSEJzYVdOaGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJac2RYaGZaMkYwWlM5bWJIVjRMV2RoZEdVdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrNXZUM0FpTENCdmJrTnlaV0YwWlRvZ0luSmxjWFZwY21VaUlIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnNkWGhmWjJGMFpTOW1iSFY0TFdkaGRHVXVZV3huYnk1MGN6b3lNQzB5TVFvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzZ2JtRnRaVG9nSW1ac2RYZ3RaMkYwWlNJc0lHRjJiVlpsY25OcGIyNDZJREV4SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSbXgxZUVkaGRHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnNkWGhmWjJGMFpTOW1iSFY0TFdkaGRHVXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJazV2VDNBaUxDQnZia055WldGMFpUb2dJbkpsY1hWcGNtVWlJSDBwQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem82Um14MWVFZGhkR1V1WTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvWVdSdGFXNDZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk16TXRNelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ0pPYjA5d0lpd2diMjVEY21WaGRHVTZJQ0p5WlhGMWFYSmxJaUI5S1FvZ0lDQWdMeThnY0hWaWJHbGpJR055WldGMFpVRndjR3hwWTJGMGFXOXVLR0ZrYldsdU9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJR0ZrYldsdVgyRmpZMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwT3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVdSdGFXNWZZV05qYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklIUm9hWE11WVdSdGFXNWZZV05qYjNWdWRDNTJZV3gxWlNBOUlHRmtiV2x1T3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem82Um14MWVFZGhkR1V1YVc1cGRFRndjR3hwWTJGMGFXOXVLRzFpY2xSNGJqb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncHBibWwwUVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pNNExUTTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQWlUbTlQY0NJZ2ZTa0tJQ0FnSUM4dklIQjFZbXhwWXlCcGJtbDBRWEJ3YkdsallYUnBiMjRvYldKeVZIaHVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2JXSnlWSGh1TENCN0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3Z1lXMXZkVzUwT2lBME1EQmZNREF3SUgwcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpZWlCcGJtbDBRWEJ3YkdsallYUnBiMjVmWW05dmJGOW1ZV3h6WlVBekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdjSFZ6YUdsdWRDQTBNREF3TURBZ0x5OGdOREF3TURBd0NpQWdJQ0E5UFFvZ0lDQWdZbm9nYVc1cGRFRndjR3hwWTJGMGFXOXVYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ21sdWFYUkJjSEJzYVdOaGRHbHZibDlpYjI5c1gyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHRZbkpVZUc0c0lIc2djbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQmhiVzkxYm5RNklEUXdNRjh3TURBZ2ZTazdDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJac2RYaGZaMkYwWlM5bWJIVjRMV2RoZEdVdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1pteDFlRjkwYVdWeWN5QTlJRUp2ZUR4VGRHRjBhV05CY25KaGVUeEdiSFY0VkdsbGNpd2dNVEErUGloN0lHdGxlVG9nSW1aMElpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVowSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnZEdocGN5NW1iSFY0WDNScFpYSnpMbU55WldGMFpTZ3BPd29nSUNBZ2NIVnphR2x1ZENBeE5qQWdMeThnTVRZd0NpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR04xY25KbGJuUmZiblZ0WDNScFpYSnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkzVnljbVZ1ZEY5dWRXMWZkR2xsY25NaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pReUNpQWdJQ0F2THlCMGFHbHpMbU4xY25KbGJuUmZiblZ0WDNScFpYSnpMblpoYkhWbElEMGdNRHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwcGJtbDBRWEJ3YkdsallYUnBiMjVmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYVc1cGRFRndjR3hwWTJGMGFXOXVYMkp2YjJ4ZmJXVnlaMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZPa1pzZFhoSFlYUmxMbUZrWkVac2RYaFVhV1Z5S0hScFpYSk9kVzFpWlhJNklIVnBiblEyTkN3Z2JXbHVVbVZ4ZFdseVpXUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGhaR1JHYkhWNFZHbGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZORFV0TkRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNKT2IwOXdJaUI5S1FvZ0lDQWdMeThnY0hWaWJHbGpJR0ZrWkVac2RYaFVhV1Z5S0hScFpYSk9kVzFpWlhJNklIVnBiblEyTkN3Z2JXbHVVbVZ4ZFdseVpXUTZJRlZwYm5ST05qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnWVhOelpYSjBLRzl3TGxSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzVmWVdOamIzVnVkQzUyWVd4MVpTazdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCaFpHMXBibDloWTJOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tUc0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaFpHMXBibDloWTJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNVVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbUZrYldsdVgyRmpZMjkxYm5RdWRtRnNkV1VwT3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWTI5dWMzUWdibVYzVkdsbGNpQTlJRzVsZHlCR2JIVjRWR2xsY2loN0lIUnBaWEpPZFcxaVpYSTZJRzVsZHlCVmFXNTBUalkwS0hScFpYSk9kVzFpWlhJcExDQnRhVzVTWlhGMWFYSmxaQ0I5S1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdac2RYaGZkR2xsY25NZ1BTQkNiM2c4VTNSaGRHbGpRWEp5WVhrOFJteDFlRlJwWlhJc0lERXdQajRvZXlCclpYazZJQ0ptZENJZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm1kQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSFJvYVhNdVpteDFlRjkwYVdWeWN5NTJZV3gxWlZ0MGFXVnlUblZ0WW1WeVhTQTlJRzVsZDFScFpYSXVZMjl3ZVNncE93b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHlJQzh2SURFd0NpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNBcUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCbWJIVjRYM1JwWlhKeklEMGdRbTk0UEZOMFlYUnBZMEZ5Y21GNVBFWnNkWGhVYVdWeUxDQXhNRDQrS0hzZ2EyVjVPaUFpWm5RaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlablFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabXgxZUY5bllYUmxMMlpzZFhndFoyRjBaUzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUIwYUdsekxtWnNkWGhmZEdsbGNuTXVkbUZzZFdWYmRHbGxjazUxYldKbGNsMGdQU0J1WlhkVWFXVnlMbU52Y0hrb0tUc0tJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR04xY25KbGJuUmZiblZ0WDNScFpYSnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OMWNuSmxiblJmYm5WdFgzUnBaWEp6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJSFJvYVhNdVkzVnljbVZ1ZEY5dWRXMWZkR2xsY25NdWRtRnNkV1VnS3owZ01Uc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabXgxZUY5bllYUmxMMlpzZFhndFoyRjBaUzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJqZFhKeVpXNTBYMjUxYlY5MGFXVnljeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTjFjbkpsYm5SZmJuVnRYM1JwWlhKeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJac2RYaGZaMkYwWlM5bWJIVjRMV2RoZEdVdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTVqZFhKeVpXNTBYMjUxYlY5MGFXVnljeTUyWVd4MVpTQXJQU0F4T3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02T2tac2RYaEhZWFJsTG5KbGJXOTJaVVpzZFhoVWFXVnlLSFJwWlhKT2RXMWlaWEk2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LY21WdGIzWmxSbXgxZUZScFpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpteDFlRjluWVhSbEwyWnNkWGd0WjJGMFpTNWhiR2R2TG5Sek9qVTBMVFUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFpVG05UGNDSWdmU2tLSUNBZ0lDOHZJSEpsYlc5MlpVWnNkWGhVYVdWeUtIUnBaWEpPZFcxaVpYSTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabXgxZUY5bllYUmxMMlpzZFhndFoyRjBaUzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJoYzNObGNuUW9iM0F1VkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1aFpHMXBibDloWTJOdmRXNTBMblpoYkhWbEtUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUdGa2JXbHVYMkZqWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ga2JXbHVYMkZqWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJac2RYaGZaMkYwWlM5bWJIVjRMV2RoZEdVdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z1lYTnpaWEowS0c5d0xsUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV1J0YVc1ZllXTmpiM1Z1ZEM1MllXeDFaU2s3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabXgxZUY5bllYUmxMMlpzZFhndFoyRjBaUzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJtYkhWNFgzUnBaWEp6SUQwZ1FtOTRQRk4wWVhScFkwRnljbUY1UEVac2RYaFVhV1Z5TENBeE1ENCtLSHNnYTJWNU9pQWlablFpSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpteDFlRjluWVhSbEwyWnNkWGd0WjJGMFpTNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QjBhR2x6TG1ac2RYaGZkR2xsY25NdWRtRnNkV1ZiZEdsbGNrNTFiV0psY2wwZ1BTQnVaWGNnUm14MWVGUnBaWElvZXlCMGFXVnlUblZ0WW1WeU9pQnVaWGNnVldsdWRFNDJOQ2d3S1N3Z2JXbHVVbVZ4ZFdseVpXUTZJRzVsZHlCVmFXNTBUalkwS0RBcElIMHBMbU52Y0hrb0tUc0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ0tnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCbWJIVjRYM1JwWlhKeklEMGdRbTk0UEZOMFlYUnBZMEZ5Y21GNVBFWnNkWGhVYVdWeUxDQXhNRDQrS0hzZ2EyVjVPaUFpWm5RaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlablFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabXgxZUY5bllYUmxMMlpzZFhndFoyRjBaUzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUIwYUdsekxtWnNkWGhmZEdsbGNuTXVkbUZzZFdWYmRHbGxjazUxYldKbGNsMGdQU0J1WlhjZ1JteDFlRlJwWlhJb2V5QjBhV1Z5VG5WdFltVnlPaUJ1WlhjZ1ZXbHVkRTQyTkNnd0tTd2diV2x1VW1WeGRXbHlaV1E2SUc1bGR5QlZhVzUwVGpZMEtEQXBJSDBwTG1OdmNIa29LVHNLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUdOMWNuSmxiblJmYm5WdFgzUnBaWEp6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTjFjbkpsYm5SZmJuVnRYM1JwWlhKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhSb2FYTXVZM1Z5Y21WdWRGOXVkVzFmZEdsbGNuTXVkbUZzZFdVZ0xUMGdNVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCamRYSnlaVzUwWDI1MWJWOTBhV1Z5Y3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU4xY25KbGJuUmZiblZ0WDNScFpYSnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnNkWGhmWjJGMFpTOW1iSFY0TFdkaGRHVXVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdkR2hwY3k1amRYSnlaVzUwWDI1MWJWOTBhV1Z5Y3k1MllXeDFaU0F0UFNBeE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk9rWnNkWGhIWVhSbExuTmxkRlZ6WlhKVWFXVnlLSFZ6WlhJNklHSjVkR1Z6TENCMGFXVnlPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbk5sZEZWelpYSlVhV1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem8yTXkwMk5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrNXZUM0FpSUgwcENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFZYTmxjbFJwWlhJb2RYTmxjam9nUVdSa2NtVnpjeXdnZEdsbGNqb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1Ga2JXbHVYMkZqWTI5MWJuUXVkbUZzZFdVcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnWVdSdGFXNWZZV05qYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrN0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVdSdGFXNWZZV05qYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm14MWVGOW5ZWFJsTDJac2RYZ3RaMkYwWlM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWhaRzFwYmw5aFkyTnZkVzUwTG5aaGJIVmxLVHNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iSFY0WDJkaGRHVXZabXgxZUMxbllYUmxMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR052Ym5OMElISmxZMjl5WkNBOUlHNWxkeUJHYkhWNFVtVmpiM0prS0hzZ2RHbGxjam9nYm1WM0lGVnBiblJPTmpRb2RHbGxjaWtnZlNrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUdac2RYaGZjbVZqYjNKa2N5QTlJRUp2ZUUxaGNEeEdiSFY0VW1WamIzSmtTMlY1TENCR2JIVjRVbVZqYjNKa1BpaDdJR3RsZVZCeVpXWnBlRG9nSW1ac2RYaGZjbVZqYjNKa0lpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbVpzZFhoZmNtVmpiM0prSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUhSb2FYTXVabXgxZUY5eVpXTnZjbVJ6S0hKbFkyOXlaRXRsZVNrdWRtRnNkV1VnUFNCeVpXTnZjbVF1WTI5d2VTZ3BPd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlpzZFhoZloyRjBaUzltYkhWNExXZGhkR1V1WVd4bmJ5NTBjem82Um14MWVFZGhkR1V1WjJWMFZYTmxjbFJwWlhJb2RYTmxjam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSVmMyVnlWR2xsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TnpNdE56UUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSk9iMDl3SWlCOUtRb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGVnpaWEpVYVdWeUtIVnpaWEk2SUVGa1pISmxjM01wT2lCVmFXNTBUalkwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnNkWGhmWjJGMFpTOW1iSFY0TFdkaGRHVXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdabXgxZUY5eVpXTnZjbVJ6SUQwZ1FtOTRUV0Z3UEVac2RYaFNaV052Y21STFpYa3NJRVpzZFhoU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQWlabXgxZUY5eVpXTnZjbVFpSUgwcE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVpteDFlRjl5WldOdmNtUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpteDFlRjluWVhSbEwyWnNkWGd0WjJGMFpTNWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QnBaaUFvZEdocGN5NW1iSFY0WDNKbFkyOXlaSE1vY21WamIzSmtTMlY1S1M1bGVHbHpkSE1wSUhzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwVlhObGNsUnBaWEpmWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUdOdmJuTjBJSEpsWTI5eVpDQTlJSFJvYVhNdVpteDFlRjl5WldOdmNtUnpLSEpsWTI5eVpFdGxlU2t1ZG1Gc2RXVXVZMjl3ZVNncE93b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWJIVjRYMmRoZEdVdlpteDFlQzFuWVhSbExtRnNaMjh1ZEhNNk56Z0tJQ0FnSUM4dklISmxkSFZ5YmlCeVpXTnZjbVF1ZEdsbGNqc0tJQ0FnSUdWNGRISmhZM1FnTUNBNElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjbVYwYzNWaUNncG5aWFJWYzJWeVZHbGxjbDlsYkhObFgySnZaSGxBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDFKbFkyOXlaQ0E5SUc1bGR5QkdiSFY0VW1WamIzSmtLSHNnZEdsbGNqb2dibVYzSUZWcGJuUk9OalFvTUNrZ2ZTa3VZMjl3ZVNncE93b2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYkhWNFgyZGhkR1V2Wm14MWVDMW5ZWFJsTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUhSb2FYTXVabXgxZUY5eVpXTnZjbVJ6S0hKbFkyOXlaRXRsZVNrdWRtRnNkV1VnUFNCdVpYZFNaV052Y21RdVkyOXdlU2dwT3dvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJac2RYaGZaMkYwWlM5bWJIVjRMV2RoZEdVdVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGQxSmxZMjl5WkM1MGFXVnlPd29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBS0VDWUZBbVowRVdOMWNuSmxiblJmYm5WdFgzUnBaWEp6RFdGa2JXbHVYMkZqWTI5MWJuUUxabXgxZUY5eVpXTnZjbVFJQUFBQUFBQUFBQUF4RzBFQU1ZSUdCTnBUL3Y0RStTZXA5Z1JiUjdHT0JHeUtBeGdFb0gwQXp3VFUxNnBjTmhvQWpnWUFaZ0JRQUQwQUxRQWFBQUlqUXpFWkZFUXhHRVEyR2dHSUFSU0FCQlVmZkhWTVVMQWlRekVaRkVReEdFUTJHZ0UyR2dJWGlBRGpJa014R1JSRU1SaEVOaG9CRjRnQW5DSkRNUmtVUkRFWVJEWWFBUmMyR2dLSUFGd2lRekVaRkVReEdFUXhGaUlKU1RnUUloSkVpQUFkSWtNeEdSUkVNUmdVUkRZYUFSZkFISWdBQWlKRGlnRUFLb3YvWjRtS0FRQ0wvemdITWdvU1FRQVlpLzg0Q0lHQXRSZ1NRUUFNSWtRb2dhQUJ1VWdwSTJlSkkwTC84WW9DQURFQUl5cGxSQkpFaS80V2kvOVFLTDVFaS80a0RFU0wvaVVMVHdKZEtFeS9JeWxsUkNJSUtVeG5pWW9CQURFQUl5cGxSQkpFS0w1RWkvOGtERVNML3lVTGdCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVhTaE12eU1wWlVRaUNTbE1aNG1LQWdBeEFDTXFaVVFTUkl2L0ZpdUwvbEJNdjRtS0FRRXJpLzlRU2IxRkFVRUFCcjVFVndBSWlTY0V2eWNFaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
