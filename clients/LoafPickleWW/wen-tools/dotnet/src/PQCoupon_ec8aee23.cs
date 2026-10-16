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

namespace Arc56.Generated.LoafPickleWW.wen_tools.PQCoupon_ec8aee23
{


    public class PQCouponProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PQCouponProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Printer : AVMObjectType
            {
                public Algorand.Address Beneficiary { get; set; }

                public ulong Count { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBeneficiary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBeneficiary.From(Beneficiary);
                    ret.AddRange(vBeneficiary.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCount.From(Count);
                    ret.AddRange(vCount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Printer Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Printer();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBeneficiary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBeneficiary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBeneficiary = vBeneficiary.ToValue();
                    if (valueBeneficiary is Algorand.Address vBeneficiaryValue) { ret.Beneficiary = vBeneficiaryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCount = vCount.ToValue();
                    if (valueCount is ulong vCountValue) { ret.Count = vCountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Printer);
                }
                public bool Equals(Printer? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Printer left, Printer right)
                {
                    return EqualityComparer<Printer>.Default.Equals(left, right);
                }
                public static bool operator !=(Printer left, Printer right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create the coupon ASA, held entirely by this app. Creator only, once.
        ///The app account must be funded first (base MBR + asset MBR + this inner fee).
        ///</summary>
        public async Task<ulong> Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 107, 98, 145 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 107, 98, 145 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register the sender as a PQ printer by revealing the preimage of its address.
        ///</summary>
        /// <param name="pqKey">salt (1 byte) followed by the Falcon-1024 public key (1793 bytes) </param>
        /// <param name="beneficiary">account that receives the coupons on claim; must already be opted in to PQPRINT </param>
        /// <param name="mbrPay">exactly PRINTER_BOX_MBR to this app, refunded on claim </param>
        public async Task Register(PaymentTransaction mbrPay, byte[] pqKey, Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 27, 213, 131, 94 };
            var pqKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); pqKeyAbi.From(pqKey);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            var result = await base.CallApp(new List<object> { abiHandle, pqKeyAbi, beneficiaryAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(PaymentTransaction mbrPay, byte[] pqKey, Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 27, 213, 131, 94 };
            var pqKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); pqKeyAbi.From(pqKey);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            return await base.MakeTransactionList(new List<object> { abiHandle, pqKeyAbi, beneficiaryAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///One coupon per call. The call itself is the PQ transaction being rewarded.
        ///</summary>
        public async Task Print(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 122, 20, 193 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Print_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 122, 20, 193 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pay out all coupons to the beneficiary, delete the printer box and refund its MBR.
        ///If the beneficiary has opted out since registering, the coupons are forfeited
        ///(they stay with the app) so the deposit can never be locked. Returns coupons paid.
        ///The caller covers the two inner transaction fees.
        ///</summary>
        public async Task<ulong> Claim(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 171, 153 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Claim_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 171, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only: coupons owed to a printer that has not claimed yet.
        ///</summary>
        /// <param name="printer"> </param>
        public async Task<ulong> Pending(Algorand.Address printer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 32, 79, 122 };
            var printerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); printerAbi.From(printer);

            var result = await base.SimApp(new List<object> { abiHandle, printerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Pending_Transactions(Algorand.Address printer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 32, 79, 122 };
            var printerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); printerAbi.From(printer);

            return await base.MakeTransactionList(new List<object> { abiHandle, printerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJQUUNvdXBvbiIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJpbnRlciI6W3sibmFtZSI6ImJlbmVmaWNpYXJ5IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJjb3VudCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOiJDcmVhdGUgdGhlIGNvdXBvbiBBU0EsIGhlbGQgZW50aXJlbHkgYnkgdGhpcyBhcHAuIENyZWF0b3Igb25seSwgb25jZS5cblRoZSBhcHAgYWNjb3VudCBtdXN0IGJlIGZ1bmRlZCBmaXJzdCAoYmFzZSBNQlIgKyBhc3NldCBNQlIgKyB0aGlzIGlubmVyIGZlZSkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6IlJlZ2lzdGVyIHRoZSBzZW5kZXIgYXMgYSBQUSBwcmludGVyIGJ5IHJldmVhbGluZyB0aGUgcHJlaW1hZ2Ugb2YgaXRzIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBxS2V5IiwiZGVzYyI6InNhbHQgKDEgYnl0ZSkgZm9sbG93ZWQgYnkgdGhlIEZhbGNvbi0xMDI0IHB1YmxpYyBrZXkgKDE3OTMgYnl0ZXMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZpY2lhcnkiLCJkZXNjIjoiYWNjb3VudCB0aGF0IHJlY2VpdmVzIHRoZSBjb3Vwb25zIG9uIGNsYWltOyBtdXN0IGFscmVhZHkgYmUgb3B0ZWQgaW4gdG8gUFFQUklOVCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5IiwiZGVzYyI6ImV4YWN0bHkgUFJJTlRFUl9CT1hfTUJSIHRvIHRoaXMgYXBwLCByZWZ1bmRlZCBvbiBjbGFpbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicHJpbnQiLCJkZXNjIjoiT25lIGNvdXBvbiBwZXIgY2FsbC4gVGhlIGNhbGwgaXRzZWxmIGlzIHRoZSBQUSB0cmFuc2FjdGlvbiBiZWluZyByZXdhcmRlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNsYWltIiwiZGVzYyI6IlBheSBvdXQgYWxsIGNvdXBvbnMgdG8gdGhlIGJlbmVmaWNpYXJ5LCBkZWxldGUgdGhlIHByaW50ZXIgYm94IGFuZCByZWZ1bmQgaXRzIE1CUi5cbklmIHRoZSBiZW5lZmljaWFyeSBoYXMgb3B0ZWQgb3V0IHNpbmNlIHJlZ2lzdGVyaW5nLCB0aGUgY291cG9ucyBhcmUgZm9yZmVpdGVkXG4odGhleSBzdGF5IHdpdGggdGhlIGFwcCkgc28gdGhlIGRlcG9zaXQgY2FuIG5ldmVyIGJlIGxvY2tlZC4gUmV0dXJucyBjb3Vwb25zIHBhaWQuXG5UaGUgY2FsbGVyIGNvdmVycyB0aGUgdHdvIGlubmVyIHRyYW5zYWN0aW9uIGZlZXMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InBlbmRpbmciLCJkZXNjIjoiUmVhZC1vbmx5OiBjb3Vwb25zIG93ZWQgdG8gYSBwcmludGVyIHRoYXQgaGFzIG5vdCBjbGFpbWVkIHlldC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaW50ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURBZ016SWdPQ0F6TVRjd01DQXpJRFlLWW5sMFpXTmliRzlqYXlBd2VEY3dJREI0TmpNZ01IZ3hOVEZtTjJNM05TQXdlRGMwSURCNENnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXBwYm5SaklEWWdMeThnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS21OeVpXRjBaVjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQW9LS2s1UFZGOUpUVkJNUlUxRlRsUkZSRG9LQ1M4dklGUm9aU0J5WlhGMVpYTjBaV1FnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHbHpJR052Ym5SeVlXTjBMaUJCY21VZ2VXOTFJSFZ6YVc1bklIUm9aU0JqYjNKeVpXTjBJRTl1UTI5dGNHeGxkR1UvSUVScFpDQjViM1VnYzJWMElIbHZkWElnWVhCd0lFbEVQd29KWlhKeUNnb3ZMeUJoYzNObGNuUk9iM1JTWld0bGVXVmtLQ2s2SUhadmFXUUtMeThLTHk4Z1ZHaGxJSE5sYm1SbGNpQnRkWE4wSUhOMGFXeHNJR0psSUdGMWRHaHZjbWw2WldRZ1lua2dhWFJ6SUc5M2JpQW9SbUZzWTI5dUtTQnJaWGt1SUVGalkzUkJkWFJvUVdSa2NpQnBjeUJ5WldGa0NpOHZJR0ZtZEdWeUlIUm9hWE1nZEhKaGJuTmhZM1JwYjI0bmN5QnZkMjRnY21WclpYa2dhWE1nWVhCd2JHbGxaQ3dnYzI4Z1lTQjBjbUZ1YzJGamRHbHZiaUJ6YVdkdVpXUWdZbmtnWVc1dmRHaGxjZ292THlCclpYa2dkR2hoZENCeVpXdGxlWE1nWW1GamF5QjBieUIwYUdVZ2MyVnVaR1Z5SUhkdmRXeGtJR3h2YjJzZ1kyeGxZVzQ2SUhKbGFtVmpkQ0JoYm5rZ1VtVnJaWGxVYnlCaGN5QjNaV3hzTGdwaGMzTmxjblJPYjNSU1pXdGxlV1ZrT2dvSmNISnZkRzhnTUNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEZCUlEyOTFjRzl1TG1Gc1oyOHVkSE02TlRVS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG5SNGJpNXpaVzVrWlhJdVlYVjBhRUZrWkhJZ1BUMDlJR2RzYjJKaGJITXVlbVZ5YjBGa1pISmxjM01wQ2dsMGVHNGdVMlZ1WkdWeUNnbGhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUYxZEdoQlpHUnlDZ2x3YjNBS0NXZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b0pQVDBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFFVVU52ZFhCdmJpNWhiR2R2TG5Sek9qVTJDZ2t2THlCaGMzTmxjblFvZEdocGN5NTBlRzR1Y21WclpYbFVieUE5UFQwZ1oyeHZZbUZzY3k1NlpYSnZRV1JrY21WemN5a0tDWFI0YmlCU1pXdGxlVlJ2Q2dsbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0NUMDlDZ2xoYzNObGNuUUtDWEpsZEhOMVlnb0tMeThnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUUtLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LQ1M4dklHVjRaV04xZEdVZ1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FLQ1dOaGJHeHpkV0lnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR055WldGMFpVRndjR3hwWTJGMGFXOXVLQ2s2SUhadmFXUUtZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2x3Y205MGJ5QXdJREFLQ2drdkx5QmpiMjUwY21GamRITmNVRkZEYjNWd2IyNHVZV3huYnk1MGN6bzJNQW9KTHk4Z2RHaHBjeTUwYjNSaGJGQnlhVzUwY3k1MllXeDFaU0E5SURBS0NXSjVkR1ZqSURNZ0x5OGdJQ0owSWdvSmFXNTBZeUF4SUM4dklEQUtDV0Z3Y0Y5bmJHOWlZV3hmY0hWMENnbHlaWFJ6ZFdJS0NpOHZJR0p2YjNSemRISmhjQ2dwZFdsdWREWTBDaXBoWW1sZmNtOTFkR1ZmWW05dmRITjBjbUZ3T2dvSkx5OGdWR2hsSUVGQ1NTQnlaWFIxY200Z2NISmxabWw0Q2dsaWVYUmxZeUF5SUM4dklEQjRNVFV4Wmpkak56VUtDZ2t2THlCbGVHVmpkWFJsSUdKdmIzUnpkSEpoY0NncGRXbHVkRFkwQ2dsallXeHNjM1ZpSUdKdmIzUnpkSEpoY0FvSmFYUnZZZ29KWTI5dVkyRjBDZ2xzYjJjS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdKdmIzUnpkSEpoY0NncE9pQkJjM05sZEVsRUNpOHZDaTh2SUVOeVpXRjBaU0IwYUdVZ1kyOTFjRzl1SUVGVFFTd2dhR1ZzWkNCbGJuUnBjbVZzZVNCaWVTQjBhR2x6SUdGd2NDNGdRM0psWVhSdmNpQnZibXg1TENCdmJtTmxMZ292THlCVWFHVWdZWEJ3SUdGalkyOTFiblFnYlhWemRDQmlaU0JtZFc1a1pXUWdabWx5YzNRZ0tHSmhjMlVnVFVKU0lDc2dZWE56WlhRZ1RVSlNJQ3NnZEdocGN5QnBibTVsY2lCbVpXVXBMZ3BpYjI5MGMzUnlZWEE2Q2dsd2NtOTBieUF3SURFS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVUZGRGIzVndiMjR1WVd4bmJ5NTBjem8yT0FvSkx5OGdZWE56WlhKMEtIUm9hWE11ZEhodUxuTmxibVJsY2lBOVBUMGdaMnh2WW1Gc2N5NWpjbVZoZEc5eVFXUmtjbVZ6Y3lrS0NYUjRiaUJUWlc1a1pYSUtDV2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvSlBUMEtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2pZNUNna3ZMeUJoYzNObGNuUW9JWFJvYVhNdVkyOTFjRzl1TG1WNGFYTjBjeWtLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjV6SURBS0NXSjVkR1ZqSURFZ0x5OGdJQ0pqSWdvSllYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0NYTjNZWEFLQ1hCdmNBb0pJUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGQlJRMjkxY0c5dUxtRnNaMjh1ZEhNNk56RUtDUzh2SUhSb2FYTXVZMjkxY0c5dUxuWmhiSFZsSUQwZ2MyVnVaRUZ6YzJWMFEzSmxZWFJwYjI0b2V3b0pMeThnSUNBZ0lDQWdZMjl1Wm1sblFYTnpaWFJPWVcxbE9pQW5WMlZ1SUZSdmIyeHpJRkJSSUVOdmRYQnZiaWNzQ2drdkx5QWdJQ0FnSUNCamIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbE9pQW5VRkZRVWtsT1ZDY3NDZ2t2THlBZ0lDQWdJQ0JqYjI1bWFXZEJjM05sZEZWU1REb2dKMmgwZEhCek9pOHZkMlZ1TG5SdmIyeHpMM0J4TFhCeWFXNTBaWEluTEFvSkx5OGdJQ0FnSUNBZ1kyOXVabWxuUVhOelpYUlViM1JoYkRvZ1ZXbHVkRHcyTkQ0b0p6RTRORFEyTnpRME1EY3pOekE1TlRVeE5qRTFKeWtzQ2drdkx5QWdJQ0FnSUNCamIyNW1hV2RCYzNObGRFUmxZMmx0WVd4ek9pQTJMQW9KTHk4Z0lDQWdJQ0FnWTI5dVptbG5RWE56WlhSU1pYTmxjblpsT2lCMGFHbHpMbUZ3Y0M1aFpHUnlaWE56TEFvSkx5OGdJQ0FnSUNBZ1ptVmxPaUF3TEFvSkx5OGdJQ0FnSUgwcENnbGllWFJsWXlBeElDOHZJQ0FpWXlJS0NXbDBlRzVmWW1WbmFXNEtDV2x1ZEdNZ05TQXZMeUFnWVdObVp3b0phWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9LQ1M4dklHTnZiblJ5WVdOMGMxeFFVVU52ZFhCdmJpNWhiR2R2TG5Sek9qY3lDZ2t2THlCamIyNW1hV2RCYzNObGRFNWhiV1U2SUNkWFpXNGdWRzl2YkhNZ1VGRWdRMjkxY0c5dUp3b0pjSFZ6YUdKNWRHVnpJREI0TlRjMk5UWmxNakExTkRabU5tWTJZemN6TWpBMU1EVXhNakEwTXpabU56VTNNRFptTm1VZ0x5OGdJbGRsYmlCVWIyOXNjeUJRVVNCRGIzVndiMjRpQ2dscGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvS0NTOHZJR052Ym5SeVlXTjBjMXhRVVVOdmRYQnZiaTVoYkdkdkxuUnpPamN6Q2drdkx5QmpiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxPaUFuVUZGUVVrbE9WQ2NLQ1hCMWMyaGllWFJsY3lBd2VEVXdOVEUxTURVeU5EazBaVFUwSUM4dklDSlFVVkJTU1U1VUlnb0phWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRkJSUTI5MWNHOXVMbUZzWjI4dWRITTZOelFLQ1M4dklHTnZibVpwWjBGemMyVjBWVkpNT2lBbmFIUjBjSE02THk5M1pXNHVkRzl2YkhNdmNIRXRjSEpwYm5SbGNpY0tDWEIxYzJoaWVYUmxjeUF3ZURZNE56UTNORGN3TnpNellUSm1NbVkzTnpZMU5tVXlaVGMwTm1ZMlpqWmpOek15Wmpjd056RXlaRGN3TnpJMk9UWmxOelEyTlRjeUlDOHZJQ0pvZEhSd2N6b3ZMM2RsYmk1MGIyOXNjeTl3Y1Mxd2NtbHVkR1Z5SWdvSmFYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZTVEFvS0NTOHZJR052Ym5SeVlXTjBjMXhRVVVOdmRYQnZiaTVoYkdkdkxuUnpPamMxQ2drdkx5QmpiMjVtYVdkQmMzTmxkRlJ2ZEdGc09pQlZhVzUwUERZMFBpZ25NVGcwTkRZM05EUXdOek0zTURrMU5URTJNVFVuS1FvSmNIVnphR2x1ZENBeE9EUTBOamMwTkRBM016Y3dPVFUxTVRZeE5Rb0phWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDZ29KTHk4Z1kyOXVkSEpoWTNSelhGQlJRMjkxY0c5dUxtRnNaMjh1ZEhNNk56WUtDUzh2SUdOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNNklEWUtDV2x1ZEdNZ05pQXZMeUEyQ2dscGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSR1ZqYVcxaGJITUtDZ2t2THlCamIyNTBjbUZqZEhOY1VGRkRiM1Z3YjI0dVlXeG5ieTUwY3pvM053b0pMeThnWTI5dVptbG5RWE56WlhSU1pYTmxjblpsT2lCMGFHbHpMbUZ3Y0M1aFpHUnlaWE56Q2dsbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29KYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVUZGRGIzVndiMjR1WVd4bmJ5NTBjem8zT0FvSkx5OGdabVZsT2lBd0NnbHBiblJqSURFZ0x5OGdNQW9KYVhSNGJsOW1hV1ZzWkNCR1pXVUtDZ2t2THlCVGRXSnRhWFFnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRLQ1dsMGVHNWZjM1ZpYldsMENnbHBkSGh1SUVOeVpXRjBaV1JCYzNObGRFbEVDZ2xoY0hCZloyeHZZbUZzWDNCMWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2pnd0Nna3ZMeUJ5WlhSMWNtNGdkR2hwY3k1amIzVndiMjR1ZG1Gc2RXVTdDZ2xpZVhSbFl5QXhJQzh2SUNBaVl5SUtDV0Z3Y0Y5bmJHOWlZV3hmWjJWMENnbHlaWFJ6ZFdJS0NpOHZJSEpsWjJsemRHVnlLR0o1ZEdWYlhTeGhaR1J5WlhOekxIQmhlU2wyYjJsa0NpcGhZbWxmY205MWRHVmZjbVZuYVhOMFpYSTZDZ2t2THlCdFluSlFZWGs2SUhCaGVRb0pkSGh1SUVkeWIzVndTVzVrWlhnS0NXbHVkR01nTUNBdkx5QXhDZ2t0Q2dsa2RYQUtDV2QwZUc1eklGUjVjR1ZGYm5WdENnbHBiblJqSURBZ0x5OGdJSEJoZVFvSlBUMEtDZ2t2THlCaGNtZDFiV1Z1ZENBd0lDaHRZbkpRWVhrcElHWnZjaUJ5WldkcGMzUmxjaUJ0ZFhOMElHSmxJR0VnY0dGNUlIUnlZVzV6WVdOMGFXOXVDZ2xoYzNObGNuUUtDZ2t2THlCaVpXNWxabWxqYVdGeWVUb2dZV1JrY21WemN3b0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvSlpIVndDZ2xzWlc0S0NXbHVkR01nTWlBdkx5QXpNZ29KUFQwS0Nna3ZMeUJoY21kMWJXVnVkQ0F4SUNoaVpXNWxabWxqYVdGeWVTa2dabTl5SUhKbFoybHpkR1Z5SUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QndjVXRsZVRvZ1lubDBaVnRkQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJR1Y0WldOMWRHVWdjbVZuYVhOMFpYSW9ZbmwwWlZ0ZExHRmtaSEpsYzNNc2NHRjVLWFp2YVdRS0NXTmhiR3h6ZFdJZ2NtVm5hWE4wWlhJS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUhKbFoybHpkR1Z5S0hCeFMyVjVPaUJpZVhSbGN5d2dZbVZ1WldacFkybGhjbms2SUVGa1pISmxjM01zSUcxaWNsQmhlVG9nVUdGNVZIaHVLVG9nZG05cFpBb3ZMd292THlCU1pXZHBjM1JsY2lCMGFHVWdjMlZ1WkdWeUlHRnpJR0VnVUZFZ2NISnBiblJsY2lCaWVTQnlaWFpsWVd4cGJtY2dkR2hsSUhCeVpXbHRZV2RsSUc5bUlHbDBjeUJoWkdSeVpYTnpMZ292THdvdkx5QkFjR0Z5WVcwZ2NIRkxaWGtnYzJGc2RDQW9NU0JpZVhSbEtTQm1iMnhzYjNkbFpDQmllU0IwYUdVZ1JtRnNZMjl1TFRFd01qUWdjSFZpYkdsaklHdGxlU0FvTVRjNU15QmllWFJsY3lrS0x5OGdRSEJoY21GdElHSmxibVZtYVdOcFlYSjVJR0ZqWTI5MWJuUWdkR2hoZENCeVpXTmxhWFpsY3lCMGFHVWdZMjkxY0c5dWN5QnZiaUJqYkdGcGJUc2diWFZ6ZENCaGJISmxZV1I1SUdKbElHOXdkR1ZrSUdsdUlIUnZJRkJSVUZKSlRsUUtMeThnUUhCaGNtRnRJRzFpY2xCaGVTQmxlR0ZqZEd4NUlGQlNTVTVVUlZKZlFrOVlYMDFDVWlCMGJ5QjBhR2x6SUdGd2NDd2djbVZtZFc1a1pXUWdiMjRnWTJ4aGFXMEtjbVZuYVhOMFpYSTZDZ2x3Y205MGJ5QXpJREFLQ2drdkx5QmpiMjUwY21GamRITmNVRkZEYjNWd2IyNHVZV3huYnk1MGN6bzVNUW9KTHk4Z1lYTnpaWEowS0hSb2FYTXVZMjkxY0c5dUxtVjRhWE4wY3lrS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1eklEQUtDV0o1ZEdWaklERWdMeThnSUNKaklnb0pZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tDWE4zWVhBS0NYQnZjQW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGQlJRMjkxY0c5dUxtRnNaMjh1ZEhNNk9USUtDUzh2SUdGemMyVnlkQ2doZEdocGN5NXdjbWx1ZEdWeWN5aDBhR2x6TG5SNGJpNXpaVzVrWlhJcExtVjRhWE4wY3lrS0NXSjVkR1ZqSURBZ0x5OGdJQ0p3SWdvSmRIaHVJRk5sYm1SbGNnb0pZMjl1WTJGMENnbGliM2hmYkdWdUNnbHpkMkZ3Q2dsd2IzQUtDU0VLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFFVVU52ZFhCdmJpNWhiR2R2TG5Sek9qa3pDZ2t2THlCaGMzTmxjblFvYkdWdUtIQnhTMlY1S1NBOVBUMGdVRkZmUzBWWlgxQlNSVWxOUVVkRlgweEZUa2RVU0NrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCd2NVdGxlVG9nWW5sMFpYTUtDV3hsYmdvSmNIVnphR2x1ZENBeE56azBDZ2s5UFFvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRkJSUTI5MWNHOXVMbUZzWjI4dWRITTZPVFFLQ1M4dklHRnpjMlZ5ZENoQlpHUnlaWE56TG1aeWIyMUNlWFJsY3loemFHRTFNVEpmTWpVMktHTnZibU5oZENnblVGRkJaakVuTENCd2NVdGxlU2twS1NBOVBUMGdkR2hwY3k1MGVHNHVjMlZ1WkdWeUtRb0pjSFZ6YUdKNWRHVnpJREI0TlRBMU1UUXhOall6TVNBdkx5QWlVRkZCWmpFaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2NIRkxaWGs2SUdKNWRHVnpDZ2xqYjI1allYUUtDWE5vWVRVeE1sOHlOVFlLQ1hSNGJpQlRaVzVrWlhJS0NUMDlDZ2xoYzNObGNuUUtDZ2t2THlCamIyNTBjbUZqZEhOY1VGRkRiM1Z3YjI0dVlXeG5ieTUwY3pvNU5Rb0pMeThnZEdocGN5NWhjM05sY25ST2IzUlNaV3RsZVdWa0tDa0tDV05oYkd4emRXSWdZWE56WlhKMFRtOTBVbVZyWlhsbFpBb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2prMkNna3ZMeUJoYzNObGNuUW9ZbVZ1WldacFkybGhjbmtnSVQwOUlHZHNiMkpoYkhNdWVtVnliMEZrWkhKbGMzTXBDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdZbVZ1WldacFkybGhjbms2SUVGa1pISmxjM01LQ1dkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvSklUMEtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2prM0Nna3ZMeUJoYzNObGNuUW9ZbVZ1WldacFkybGhjbmt1YVhOUGNIUmxaRWx1Vkc5QmMzTmxkQ2gwYUdsekxtTnZkWEJ2Ymk1MllXeDFaU2twQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnWW1WdVpXWnBZMmxoY25rNklFRmtaSEpsYzNNS0NXSjVkR1ZqSURFZ0x5OGdJQ0pqSWdvSllYQndYMmRzYjJKaGJGOW5aWFFLQ1dGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb0pjM2RoY0FvSmNHOXdDZ2xoYzNObGNuUUtDZ2t2THlCamIyNTBjbUZqZEhOY1VGRkRiM1Z3YjI0dVlXeG5ieTUwY3pvNU9Rb0pMeThnZG1WeWFXWjVVR0Y1VkhodUtHMWljbEJoZVN3Z2V3b0pMeThnSUNBZ0lDQWdjbVZqWldsMlpYSTZJSFJvYVhNdVlYQndMbUZrWkhKbGMzTXNDZ2t2THlBZ0lDQWdJQ0JoYlc5MWJuUTZJRkJTU1U1VVJWSmZRazlZWDAxQ1Vpd0tDUzh2SUNBZ0lDQjlLUW9KTHk4Z2RtVnlhV1o1SUhKbFkyVnBkbVZ5Q2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnYldKeVVHRjVPaUJRWVhsVWVHNEtDV2QwZUc1eklGSmxZMlZwZG1WeUNnbG5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvSlBUMEtDZ2t2THlCMGNtRnVjMkZqZEdsdmJpQjJaWEpwWm1sallYUnBiMjRnWm1GcGJHVmtPaUI3SW5SNGJpSTZJbTFpY2xCaGVTSXNJbVpwWld4a0lqb2ljbVZqWldsMlpYSWlMQ0psZUhCbFkzUmxaQ0k2SW5Sb2FYTXVZWEJ3TG1Ga1pISmxjM01pZlFvSllYTnpaWEowQ2dvSkx5OGdkbVZ5YVdaNUlHRnRiM1Z1ZEFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUcxaWNsQmhlVG9nVUdGNVZIaHVDZ2xuZEhodWN5QkJiVzkxYm5RS0NXbHVkR01nTkNBdkx5QXpNVGN3TUFvSlBUMEtDZ2t2THlCMGNtRnVjMkZqZEdsdmJpQjJaWEpwWm1sallYUnBiMjRnWm1GcGJHVmtPaUI3SW5SNGJpSTZJbTFpY2xCaGVTSXNJbVpwWld4a0lqb2lZVzF2ZFc1MElpd2laWGh3WldOMFpXUWlPaUpRVWtsT1ZFVlNYMEpQV0Y5TlFsSWlmUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGQlJRMjkxY0c5dUxtRnNaMjh1ZEhNNk1UQTBDZ2t2THlCMGFHbHpMbkJ5YVc1MFpYSnpLSFJvYVhNdWRIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQjdJR0psYm1WbWFXTnBZWEo1T2lCaVpXNWxabWxqYVdGeWVTd2dZMjkxYm5RNklEQWdmUW9KWW5sMFpXTWdNQ0F2THlBZ0luQWlDZ2wwZUc0Z1UyVnVaR1Z5Q2dsamIyNWpZWFFLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJpWlc1bFptbGphV0Z5ZVRvZ1FXUmtjbVZ6Y3dvSmNIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb0pZMjl1WTJGMENnbGliM2hmY0hWMENnbHlaWFJ6ZFdJS0NpOHZJSEJ5YVc1MEtDbDJiMmxrQ2lwaFltbGZjbTkxZEdWZmNISnBiblE2Q2drdkx5QmxlR1ZqZFhSbElIQnlhVzUwS0NsMmIybGtDZ2xqWVd4c2MzVmlJSEJ5YVc1MENnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCd2NtbHVkQ2dwT2lCMmIybGtDaTh2Q2k4dklFOXVaU0JqYjNWd2IyNGdjR1Z5SUdOaGJHd3VJRlJvWlNCallXeHNJR2wwYzJWc1ppQnBjeUIwYUdVZ1VGRWdkSEpoYm5OaFkzUnBiMjRnWW1WcGJtY2djbVYzWVhKa1pXUXVDbkJ5YVc1ME9nb0pjSEp2ZEc4Z01DQXdDZ29KTHk4Z1kyOXVkSEpoWTNSelhGQlJRMjkxY0c5dUxtRnNaMjh1ZEhNNk1UQTVDZ2t2THlCaGMzTmxjblFvZEdocGN5NXdjbWx1ZEdWeWN5aDBhR2x6TG5SNGJpNXpaVzVrWlhJcExtVjRhWE4wY3lrS0NXSjVkR1ZqSURBZ0x5OGdJQ0p3SWdvSmRIaHVJRk5sYm1SbGNnb0pZMjl1WTJGMENnbGliM2hmYkdWdUNnbHpkMkZ3Q2dsd2IzQUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2pFeE1Bb0pMeThnZEdocGN5NWhjM05sY25ST2IzUlNaV3RsZVdWa0tDa0tDV05oYkd4emRXSWdZWE56WlhKMFRtOTBVbVZyWlhsbFpBb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2pFeE1nb0pMeThnWVhOelpYSjBLSFJvYVhNdWRIaHVMbVpsWlNBK1BTQm5iRzlpWVd4ekxtMXBibFI0YmtabFpTQXFJRkJSWDBaRlJWOU5WVXhVU1ZCTVNVVlNLUW9KZEhodUlFWmxaUW9KWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9KYVc1MFl5QTFJQzh2SURNS0NTb0tDVDQ5Q2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNVRkZEYjNWd2IyNHVZV3huYnk1MGN6b3hNVFFLQ1M4dklIUm9hWE11Y0hKcGJuUmxjbk1vZEdocGN5NTBlRzR1YzJWdVpHVnlLUzUyWVd4MVpTNWpiM1Z1ZENBclBTQXhDZ2xwYm5SaklESWdMeThnSUdobFlXUlBabVp6WlhRS0NXUjFjQW9KYVc1MFl5QXpJQzh2SURnS0NXSjVkR1ZqSURBZ0x5OGdJQ0p3SWdvSmRIaHVJRk5sYm1SbGNnb0pZMjl1WTJGMENnbGpiM1psY2lBeUNnbGliM2hmWlhoMGNtRmpkQW9KWW5SdmFRb0phVzUwWXlBd0lDOHZJREVLQ1NzS0NXbDBiMklLQ1dKNWRHVmpJREFnTHk4Z0lDSndJZ29KZEhodUlGTmxibVJsY2dvSlkyOXVZMkYwQ2dsamIzWmxjaUF5Q2dsaWIzaGZjbVZ3YkdGalpRb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2pFeE5Rb0pMeThnZEdocGN5NTBiM1JoYkZCeWFXNTBjeTUyWVd4MVpTQXJQU0F4Q2dsaWVYUmxZeUF6SUM4dklDQWlkQ0lLQ1dGd2NGOW5iRzlpWVd4ZloyVjBDZ2xwYm5SaklEQWdMeThnTVFvSkt3b0pZbmwwWldNZ015QXZMeUFnSW5RaUNnbHpkMkZ3Q2dsaGNIQmZaMnh2WW1Gc1gzQjFkQW9KY21WMGMzVmlDZ292THlCamJHRnBiU2dwZFdsdWREWTBDaXBoWW1sZmNtOTFkR1ZmWTJ4aGFXMDZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDV0o1ZEdWaklESWdMeThnTUhneE5URm1OMk0zTlFvS0NTOHZJR1Y0WldOMWRHVWdZMnhoYVcwb0tYVnBiblEyTkFvSlkyRnNiSE4xWWlCamJHRnBiUW9KYVhSdllnb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR05zWVdsdEtDazZJSFZwYm5RMk5Bb3ZMd292THlCUVlYa2diM1YwSUdGc2JDQmpiM1Z3YjI1eklIUnZJSFJvWlNCaVpXNWxabWxqYVdGeWVTd2daR1ZzWlhSbElIUm9aU0J3Y21sdWRHVnlJR0p2ZUNCaGJtUWdjbVZtZFc1a0lHbDBjeUJOUWxJdUNpOHZJRWxtSUhSb1pTQmlaVzVsWm1samFXRnllU0JvWVhNZ2IzQjBaV1FnYjNWMElITnBibU5sSUhKbFoybHpkR1Z5YVc1bkxDQjBhR1VnWTI5MWNHOXVjeUJoY21VZ1ptOXlabVZwZEdWa0NpOHZJQ2gwYUdWNUlITjBZWGtnZDJsMGFDQjBhR1VnWVhCd0tTQnpieUIwYUdVZ1pHVndiM05wZENCallXNGdibVYyWlhJZ1ltVWdiRzlqYTJWa0xpQlNaWFIxY201eklHTnZkWEJ2Ym5NZ2NHRnBaQzRLTHk4Z1ZHaGxJR05oYkd4bGNpQmpiM1psY25NZ2RHaGxJSFIzYnlCcGJtNWxjaUIwY21GdWMyRmpkR2x2YmlCbVpXVnpMZ3BqYkdGcGJUb0tDWEJ5YjNSdklEQWdNUW9LQ1M4dklGQjFjMmdnWlcxd2RIa2dZbmwwWlhNZ1lXWjBaWElnZEdobElHWnlZVzFsSUhCdmFXNTBaWElnZEc4Z2NtVnpaWEoyWlNCemNHRmpaU0JtYjNJZ2JHOWpZV3dnZG1GeWFXRmliR1Z6Q2dsaWVYUmxZeUEwSUM4dklEQjRDZ2xrZFhBS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVUZGRGIzVndiMjR1WVd4bmJ5NTBjem94TWpVS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG5CeWFXNTBaWEp6S0hSb2FYTXVkSGh1TG5ObGJtUmxjaWt1WlhocGMzUnpLUW9KWW5sMFpXTWdNQ0F2THlBZ0luQWlDZ2wwZUc0Z1UyVnVaR1Z5Q2dsamIyNWpZWFFLQ1dKdmVGOXNaVzRLQ1hOM1lYQUtDWEJ2Y0FvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRkJSUTI5MWNHOXVMbUZzWjI4dWRITTZNVEkzQ2drdkx5QmlaVzVsWm1samFXRnllU0E5SUhSb2FYTXVjSEpwYm5SbGNuTW9kR2hwY3k1MGVHNHVjMlZ1WkdWeUtTNTJZV3gxWlM1aVpXNWxabWxqYVdGeWVRb0phVzUwWXlBeElDOHZJREFLQ1dsdWRHTWdNaUF2THlBek1nb0pZbmwwWldNZ01DQXZMeUFnSW5BaUNnbDBlRzRnVTJWdVpHVnlDZ2xqYjI1allYUUtDV052ZG1WeUlESUtDV0p2ZUY5bGVIUnlZV04wQ2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnWW1WdVpXWnBZMmxoY25rNklHRmtaSEpsYzNNS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVUZGRGIzVndiMjR1WVd4bmJ5NTBjem94TWpnS0NTOHZJR052ZFc1MElEMGdkR2hwY3k1d2NtbHVkR1Z5Y3loMGFHbHpMblI0Ymk1elpXNWtaWElwTG5aaGJIVmxMbU52ZFc1MENnbHBiblJqSURJZ0x5OGdJR2hsWVdSUFptWnpaWFFLQ1dsdWRHTWdNeUF2THlBNENnbGllWFJsWXlBd0lDOHZJQ0FpY0NJS0NYUjRiaUJUWlc1a1pYSUtDV052Ym1OaGRBb0pZMjkyWlhJZ01nb0pZbTk0WDJWNGRISmhZM1FLQ1dKMGIya0tDV1p5WVcxbFgySjFjbmtnTVNBdkx5QmpiM1Z1ZERvZ2RXbHVkRFkwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRkJSUTI5MWNHOXVMbUZzWjI4dWRITTZNVEk1Q2drdkx5QjBhR2x6TG5CeWFXNTBaWEp6S0hSb2FYTXVkSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLQ1dKNWRHVmpJREFnTHk4Z0lDSndJZ29KZEhodUlGTmxibVJsY2dvSlkyOXVZMkYwQ2dsaWIzaGZaR1ZzQ2dvSkx5OGdLbWxtTUY5amIyNWthWFJwYjI0S0NTOHZJR052Ym5SeVlXTjBjMXhRVVVOdmRYQnZiaTVoYkdkdkxuUnpPakV6TVFvSkx5OGdJV0psYm1WbWFXTnBZWEo1TG1selQzQjBaV1JKYmxSdlFYTnpaWFFvZEdocGN5NWpiM1Z3YjI0dWRtRnNkV1VwQ2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJpWlc1bFptbGphV0Z5ZVRvZ1lXUmtjbVZ6Y3dvSllubDBaV01nTVNBdkx5QWdJbU1pQ2dsaGNIQmZaMnh2WW1Gc1gyZGxkQW9KWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENnbHpkMkZ3Q2dsd2IzQUtDU0VLQ1dKNklDcHBaakJmWlc1a0Nnb0pMeThnS21sbU1GOWpiMjV6WlhGMVpXNTBDZ2t2THlCamIyNTBjbUZqZEhOY1VGRkRiM1Z3YjI0dVlXeG5ieTUwY3pveE16RUtDUzh2SUdOdmRXNTBJRDBnTUFvSmFXNTBZeUF4SUM4dklEQUtDV1p5WVcxbFgySjFjbmtnTVNBdkx5QmpiM1Z1ZERvZ2RXbHVkRFkwQ2dvcWFXWXdYMlZ1WkRvS0NTOHZJQ3BwWmpGZlkyOXVaR2wwYVc5dUNna3ZMeUJqYjI1MGNtRmpkSE5jVUZGRGIzVndiMjR1WVd4bmJ5NTBjem94TXpJS0NTOHZJR052ZFc1MElENGdNQW9KWm5KaGJXVmZaR2xuSURFZ0x5OGdZMjkxYm5RNklIVnBiblEyTkFvSmFXNTBZeUF4SUM4dklEQUtDVDRLQ1dKNklDcHBaakZmWlc1a0Nnb0pMeThnS21sbU1WOWpiMjV6WlhGMVpXNTBDZ2t2THlCamIyNTBjbUZqZEhOY1VGRkRiM1Z3YjI0dVlXeG5ieTUwY3pveE16TUtDUzh2SUhObGJtUkJjM05sZEZSeVlXNXpabVZ5S0hzS0NTOHZJQ0FnSUNBZ0lDQWdlR1psY2tGemMyVjBPaUIwYUdsekxtTnZkWEJ2Ymk1MllXeDFaU3dLQ1M4dklDQWdJQ0FnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWW1WdVpXWnBZMmxoY25rc0Nna3ZMeUFnSUNBZ0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lCamIzVnVkQ0FxSUVOUFZWQlBUbDlWVGtsVVUxOVFSVkpmVUZKSlRsUXNDZ2t2THlBZ0lDQWdJQ0FnSUdabFpUb2dNQ3dLQ1M4dklDQWdJQ0FnSUgwcENnbHBkSGh1WDJKbFoybHVDZ2x3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLQ1dsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVUZGRGIzVndiMjR1WVd4bmJ5NTBjem94TXpRS0NTOHZJSGhtWlhKQmMzTmxkRG9nZEdocGN5NWpiM1Z3YjI0dWRtRnNkV1VLQ1dKNWRHVmpJREVnTHk4Z0lDSmpJZ29KWVhCd1gyZHNiMkpoYkY5blpYUUtDV2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRkJSUTI5MWNHOXVMbUZzWjI4dWRITTZNVE0xQ2drdkx5QmhjM05sZEZKbFkyVnBkbVZ5T2lCaVpXNWxabWxqYVdGeWVRb0pabkpoYldWZlpHbG5JREFnTHk4Z1ltVnVaV1pwWTJsaGNuazZJR0ZrWkhKbGMzTUtDV2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb0tDUzh2SUdOdmJuUnlZV04wYzF4UVVVTnZkWEJ2Ymk1aGJHZHZMblJ6T2pFek5nb0pMeThnWVhOelpYUkJiVzkxYm5RNklHTnZkVzUwSUNvZ1EwOVZVRTlPWDFWT1NWUlRYMUJGVWw5UVVrbE9WQW9KWm5KaGJXVmZaR2xuSURFZ0x5OGdZMjkxYm5RNklIVnBiblEyTkFvSmNIVnphR2x1ZENBeE1EQXdNREF3Q2drcUNnbHBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRkJSUTI5MWNHOXVMbUZzWjI4dWRITTZNVE0zQ2drdkx5Qm1aV1U2SURBS0NXbHVkR01nTVNBdkx5QXdDZ2xwZEhodVgyWnBaV3hrSUVabFpRb0tDUzh2SUZOMVltMXBkQ0JwYm01bGNpQjBjbUZ1YzJGamRHbHZiZ29KYVhSNGJsOXpkV0p0YVhRS0NpcHBaakZmWlc1a09nb0pMeThnWTI5dWRISmhZM1J6WEZCUlEyOTFjRzl1TG1Gc1oyOHVkSE02TVRRd0Nna3ZMeUJ6Wlc1a1VHRjViV1Z1ZENoN0lISmxZMlZwZG1WeU9pQjBhR2x6TG5SNGJpNXpaVzVrWlhJc0lHRnRiM1Z1ZERvZ1VGSkpUbFJGVWw5Q1QxaGZUVUpTTENCbVpXVTZJREFnZlNrS0NXbDBlRzVmWW1WbmFXNEtDV2x1ZEdNZ01DQXZMeUFnY0dGNUNnbHBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDZ29KTHk4Z1kyOXVkSEpoWTNSelhGQlJRMjkxY0c5dUxtRnNaMjh1ZEhNNk1UUXdDZ2t2THlCeVpXTmxhWFpsY2pvZ2RHaHBjeTUwZUc0dWMyVnVaR1Z5Q2dsMGVHNGdVMlZ1WkdWeUNnbHBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDZ29KTHk4Z1kyOXVkSEpoWTNSelhGQlJRMjkxY0c5dUxtRnNaMjh1ZEhNNk1UUXdDZ2t2THlCaGJXOTFiblE2SUZCU1NVNVVSVkpmUWs5WVgwMUNVZ29KYVc1MFl5QTBJQzh2SURNeE56QXdDZ2xwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFFVVU52ZFhCdmJpNWhiR2R2TG5Sek9qRTBNQW9KTHk4Z1ptVmxPaUF3Q2dscGJuUmpJREVnTHk4Z01Bb0phWFI0Ymw5bWFXVnNaQ0JHWldVS0Nna3ZMeUJUZFdKdGFYUWdhVzV1WlhJZ2RISmhibk5oWTNScGIyNEtDV2wwZUc1ZmMzVmliV2wwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRkJSUTI5MWNHOXVMbUZzWjI4dWRITTZNVFF4Q2drdkx5QnlaWFIxY200Z1kyOTFiblE3Q2dsbWNtRnRaVjlrYVdjZ01TQXZMeUJqYjNWdWREb2dkV2x1ZERZMENnb0pMeThnYzJWMElIUm9aU0J6ZFdKeWIzVjBhVzVsSUhKbGRIVnliaUIyWVd4MVpRb0pabkpoYldWZlluVnllU0F3Q2dvSkx5OGdjRzl3SUdGc2JDQnNiMk5oYkNCMllYSnBZV0pzWlhNZ1puSnZiU0IwYUdVZ2MzUmhZMnNLQ1hCdmNHNGdNUW9KY21WMGMzVmlDZ292THlCd1pXNWthVzVuS0dGa1pISmxjM01wZFdsdWREWTBDaXBoWW1sZmNtOTFkR1ZmY0dWdVpHbHVaem9LQ1M4dklGUm9aU0JCUWtrZ2NtVjBkWEp1SUhCeVpXWnBlQW9KWW5sMFpXTWdNaUF2THlBd2VERTFNV1kzWXpjMUNnb0pMeThnY0hKcGJuUmxjam9nWVdSa2NtVnpjd29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0paSFZ3Q2dsc1pXNEtDV2x1ZEdNZ01pQXZMeUF6TWdvSlBUMEtDZ2t2THlCaGNtZDFiV1Z1ZENBd0lDaHdjbWx1ZEdWeUtTQm1iM0lnY0dWdVpHbHVaeUJ0ZFhOMElHSmxJR0VnWVdSa2NtVnpjd29KWVhOelpYSjBDZ29KTHk4Z1pYaGxZM1YwWlNCd1pXNWthVzVuS0dGa1pISmxjM01wZFdsdWREWTBDZ2xqWVd4c2MzVmlJSEJsYm1ScGJtY0tDV2wwYjJJS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QndaVzVrYVc1bktIQnlhVzUwWlhJNklFRmtaSEpsYzNNcE9pQjFhVzUwTmpRS0x5OEtMeThnVW1WaFpDMXZibXg1T2lCamIzVndiMjV6SUc5M1pXUWdkRzhnWVNCd2NtbHVkR1Z5SUhSb1lYUWdhR0Z6SUc1dmRDQmpiR0ZwYldWa0lIbGxkQzRLY0dWdVpHbHVaem9LQ1hCeWIzUnZJREVnTVFvS0NTOHZJQ3BwWmpKZlkyOXVaR2wwYVc5dUNna3ZMeUJqYjI1MGNtRmpkSE5jVUZGRGIzVndiMjR1WVd4bmJ5NTBjem94TkRjS0NTOHZJQ0YwYUdsekxuQnlhVzUwWlhKektIQnlhVzUwWlhJcExtVjRhWE4wY3dvSllubDBaV01nTUNBdkx5QWdJbkFpQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnY0hKcGJuUmxjam9nUVdSa2NtVnpjd29KWTI5dVkyRjBDZ2xpYjNoZmJHVnVDZ2x6ZDJGd0NnbHdiM0FLQ1NFS0NXSjZJQ3BwWmpKZlpXNWtDZ29KTHk4Z0ttbG1NbDlqYjI1elpYRjFaVzUwQ2drdkx5QmpiMjUwY21GamRITmNVRkZEYjNWd2IyNHVZV3huYnk1MGN6b3hORGNLQ1M4dklISmxkSFZ5YmlBd093b0phVzUwWXlBeElDOHZJREFLQ1hKbGRITjFZZ29LS21sbU1sOWxibVE2Q2drdkx5QmpiMjUwY21GamRITmNVRkZEYjNWd2IyNHVZV3huYnk1MGN6b3hORGdLQ1M4dklISmxkSFZ5YmlCMGFHbHpMbkJ5YVc1MFpYSnpLSEJ5YVc1MFpYSXBMblpoYkhWbExtTnZkVzUwT3dvSmFXNTBZeUF5SUM4dklDQm9aV0ZrVDJabWMyVjBDZ2xwYm5SaklETWdMeThnT0FvSllubDBaV01nTUNBdkx5QWdJbkFpQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnY0hKcGJuUmxjam9nUVdSa2NtVnpjd29KWTI5dVkyRjBDZ2xqYjNabGNpQXlDZ2xpYjNoZlpYaDBjbUZqZEFvSlluUnZhUW9KY21WMGMzVmlDZ29xWTNKbFlYUmxYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpjbVZoZEdVZ1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNE56ZzJZall5T1RFZ0x5OGdiV1YwYUc5a0lDSmliMjkwYzNSeVlYQW9LWFZwYm5RMk5DSUtDWEIxYzJoaWVYUmxjeUF3ZURGaVpEVTRNelZsSUM4dklHMWxkR2h2WkNBaWNtVm5hWE4wWlhJb1lubDBaVnRkTEdGa1pISmxjM01zY0dGNUtYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IZ3pOVGRoTVRSak1TQXZMeUJ0WlhSb2IyUWdJbkJ5YVc1MEtDbDJiMmxrSWdvSmNIVnphR0o1ZEdWeklEQjRZMk00TW1GaU9Ua2dMeThnYldWMGFHOWtJQ0pqYkdGcGJTZ3BkV2x1ZERZMElnb0pjSFZ6YUdKNWRHVnpJREI0Wm1JeU1EUm1OMkVnTHk4Z2JXVjBhRzlrSUNKd1pXNWthVzVuS0dGa1pISmxjM01wZFdsdWREWTBJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWliMjkwYzNSeVlYQWdLbUZpYVY5eWIzVjBaVjl5WldkcGMzUmxjaUFxWVdKcFgzSnZkWFJsWDNCeWFXNTBJQ3BoWW1sZmNtOTFkR1ZmWTJ4aGFXMGdLbUZpYVY5eWIzVjBaVjl3Wlc1a2FXNW5DZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjpudWxsLCJjb21waWxlckluZm8iOm51bGwsImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
