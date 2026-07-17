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

namespace Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.PaymentApp_64e9047a
{


    //
    // 
    //    A modern Algorand Python contract that handles payments with royalty splits.
    //    
    //
    public class PaymentAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PaymentAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CalculatePaymentBreakdownReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CalculatePaymentBreakdownReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CalculatePaymentBreakdownReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CalculatePaymentBreakdownReturn);
                }
                public bool Equals(CalculatePaymentBreakdownReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CalculatePaymentBreakdownReturn left, CalculatePaymentBreakdownReturn right)
                {
                    return EqualityComparer<CalculatePaymentBreakdownReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(CalculatePaymentBreakdownReturn left, CalculatePaymentBreakdownReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment_txn"> </param>
        /// <param name="creator"> </param>
        /// <param name="platform"> </param>
        /// <param name="royalty_recipient"> </param>
        /// <param name="amount"> </param>
        public async Task PayWithRoyaltySplit(PaymentTransaction payment_txn, Algorand.Address creator, Algorand.Address platform, Algorand.Address royalty_recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 175, 105, 128, 57 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var platformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); platformAbi.From(platform);
            var royalty_recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); royalty_recipientAbi.From(royalty_recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn, creatorAbi, platformAbi, royalty_recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayWithRoyaltySplit_Transactions(PaymentTransaction payment_txn, Algorand.Address creator, Algorand.Address platform, Algorand.Address royalty_recipient, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 175, 105, 128, 57 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var platformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); platformAbi.From(platform);
            var royalty_recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); royalty_recipientAbi.From(royalty_recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn, creatorAbi, platformAbi, royalty_recipientAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment_txn"> </param>
        /// <param name="creator"> </param>
        /// <param name="amount"> </param>
        public async Task PayFullToCreator(PaymentTransaction payment_txn, Algorand.Address creator, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 212, 228, 8, 243 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn, creatorAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayFullToCreator_Transactions(PaymentTransaction payment_txn, Algorand.Address creator, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 212, 228, 8, 243 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn, creatorAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<Structs.CalculatePaymentBreakdownReturn> CalculatePaymentBreakdown(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 5, 49, 244 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.SimApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CalculatePaymentBreakdownReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CalculatePaymentBreakdown_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 5, 49, 244 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGF5bWVudEFwcCIsImRlc2MiOiJcbiAgICBBIG1vZGVybiBBbGdvcmFuZCBQeXRob24gY29udHJhY3QgdGhhdCBoYW5kbGVzIHBheW1lbnRzIHdpdGggcm95YWx0eSBzcGxpdHMuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNhbGN1bGF0ZVBheW1lbnRCcmVha2Rvd25SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicGF5X3dpdGhfcm95YWx0eV9zcGxpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbGF0Zm9ybSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJveWFsdHlfcmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5X2Z1bGxfdG9fY3JlYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50X3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVfcGF5bWVudF9icmVha2Rvd24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJDYWxjdWxhdGVQYXltZW50QnJlYWtkb3duUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExOCwyMzBdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IGFtb3VudCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNywyMTldLCJlcnJvck1lc3NhZ2UiOiJSZWNlaXZlciBtdXN0IGJlIHRoaXMgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQsODIsOTAsMjAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5LDIxMSwyNTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NiwxOTRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRE15SURFd01EQXdJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV5Q2lBZ0lDQXZMeUJqYkdGemN5QlFZWGx0Wlc1MFFYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZV1kyT1Rnd016a2dNSGhrTkdVME1EaG1NeUF3ZUdZMk1EVXpNV1kwSUM4dklHMWxkR2h2WkNBaWNHRjVYM2RwZEdoZmNtOTVZV3gwZVY5emNHeHBkQ2h3WVhrc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQmhlVjltZFd4c1gzUnZYMk55WldGMGIzSW9jR0Y1TEdGa1pISmxjM01zZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTmhiR04xYkdGMFpWOXdZWGx0Wlc1MFgySnlaV0ZyWkc5M2JpaDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhCaGVWOTNhWFJvWDNKdmVXRnNkSGxmYzNCc2FYUWdjR0Y1WDJaMWJHeGZkRzlmWTNKbFlYUnZjaUJqWVd4amRXeGhkR1ZmY0dGNWJXVnVkRjlpY21WaGEyUnZkMjRLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CaGVXMWxiblF1WTI5dWRISmhZM1F1VUdGNWJXVnVkRUZ3Y0M1d1lYbGZkMmwwYUY5eWIzbGhiSFI1WDNOd2JHbDBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0dGNVgzZHBkR2hmY205NVlXeDBlVjl6Y0d4cGREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTNDaUFnSUNBdkx5QndZWGx0Wlc1MFgzUjRiaTV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQmthV2NnTkFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpZdE1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWRGOTBlRzR1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z0lsSmxZMlZwZG1WeUlHMTFjM1FnWW1VZ2RHaHBjeUJoY0hBaUNpQWdJQ0JoYzNObGNuUWdMeThnVW1WalpXbDJaWElnYlhWemRDQmlaU0IwYUdseklHRndjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgzUjRiaTVoYlc5MWJuUWdQVDBnWVcxdmRXNTBMbTVoZEdsMlpTd2dJbEJoZVcxbGJuUWdZVzF2ZFc1MElHMXBjMjFoZEdOb0lnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ1lXMXZkVzUwSUcxcGMyMWhkR05vQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG96TVMwek5Bb2dJQ0FnTHk4Z0l5QkdaV1VnWTJGc1kzVnNZWFJwYjI1ek9nb2dJQ0FnTHk4Z0l5QlFiR0YwWm05eWJTQkdaV1U2SURJdU5TVWdLREkxTUNBdklERXdNREF3S1FvZ0lDQWdMeThnSXlCU2IzbGhiSFI1T2lBeE1DVWdiMllnY21WdFlXbHVhVzVuSUNneE1EQXdJQzhnTVRBd01EQXBDaUFnSUNBdkx5QndiR0YwWm05eWJWOW1aV1VnUFNBb1lXMXZkVzUwTG01aGRHbDJaU0FxSUZWSmJuUTJOQ2d5TlRBcEtTQXZMeUJWU1c1ME5qUW9NVEF3TURBcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNalV3Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREFLSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QnlaVzFoYVc1cGJtY2dQU0JoYlc5MWJuUXVibUYwYVhabElDMGdjR3hoZEdadmNtMWZabVZsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZNellLSUNBZ0lDOHZJSEp2ZVdGc2RIa2dQU0FvY21WdFlXbHVhVzVuSUNvZ1ZVbHVkRFkwS0RFd01EQXBLU0F2THlCVlNXNTBOalFvTVRBd01EQXBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBd01Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TURBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnWTNKbFlYUnZjbDloYlhRZ1BTQnlaVzFoYVc1cGJtY2dMU0J5YjNsaGJIUjVDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk16a3RORFFLSUNBZ0lDOHZJQ01nTVM0Z1ZISmhibk5tWlhJZ1VHeGhkR1p2Y20wZ1JtVmxDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWNHeGhkR1p2Y20wdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxd2JHRjBabTl5YlY5bVpXVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk16a3ROREFLSUNBZ0lDOHZJQ01nTVM0Z1ZISmhibk5tWlhJZ1VHeGhkR1p2Y20wZ1JtVmxDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TXprdE5EUUtJQ0FnSUM4dklDTWdNUzRnVkhKaGJuTm1aWElnVUd4aGRHWnZjbTBnUm1WbENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5Y0d4aGRHWnZjbTB1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3YkdGMFptOXliVjltWldVc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG8wTmkwMU1Rb2dJQ0FnTHk4Z0l5QXlMaUJVY21GdWMyWmxjaUJTYjNsaGJIUjVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWNtOTVZV3gwZVY5eVpXTnBjR2xsYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxeWIzbGhiSFI1TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZORFl0TkRjS0lDQWdJQzh2SUNNZ01pNGdWSEpoYm5ObVpYSWdVbTk1WVd4MGVRb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPalEyTFRVeENpQWdJQ0F2THlBaklESXVJRlJ5WVc1elptVnlJRkp2ZVdGc2RIa0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxeWIzbGhiSFI1WDNKbFkybHdhV1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhKdmVXRnNkSGtzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzFNeTAxT0FvZ0lDQWdMeThnSXlBekxpQlVjbUZ1YzJabGNpQkRjbVZoZEc5eUlGTm9ZWEpsQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlZM0psWVhSdmNpNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXTnlaV0YwYjNKZllXMTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk5UTXROVFFLSUNBZ0lDOHZJQ01nTXk0Z1ZISmhibk5tWlhJZ1EzSmxZWFJ2Y2lCVGFHRnlaUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZOVGNLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pVekxUVTRDaUFnSUNBdkx5QWpJRE11SUZSeVlXNXpabVZ5SUVOeVpXRjBiM0lnVTJoaGNtVUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxamNtVmhkRzl5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WTNKbFlYUnZjbDloYlhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CaGVXMWxiblF1WTI5dWRISmhZM1F1VUdGNWJXVnVkRUZ3Y0M1d1lYbGZablZzYkY5MGIxOWpjbVZoZEc5eVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0Y1WDJaMWJHeGZkRzlmWTNKbFlYUnZjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUhCaGVXMWxiblJmZEhodUxuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdScFp5QXlDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzJOeTAyT1FvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCd1lYbHRaVzUwWDNSNGJpNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpDaUFnSUNBdkx5QXBMQ0FpVW1WalpXbDJaWElnYlhWemRDQmlaU0IwYUdseklHRndjQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaV05sYVhabGNpQnRkWE4wSUdKbElIUm9hWE1nWVhCd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvM01Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblJmZEhodUxtRnRiM1Z1ZENBOVBTQmhiVzkxYm5RdWJtRjBhWFpsTENBaVVHRjViV1Z1ZENCaGJXOTFiblFnYldsemJXRjBZMmdpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVUdGNWJXVnVkQ0JoYlc5MWJuUWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qY3lMVGMyQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlZM0psWVhSdmNpNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzNNZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5RdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pjeUxUYzJDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVkzSmxZWFJ2Y2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQmhlVzFsYm5RdVkyOXVkSEpoWTNRdVVHRjViV1Z1ZEVGd2NDNWpZV3hqZFd4aGRHVmZjR0Y1YldWdWRGOWljbVZoYTJSdmQyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqWVd4amRXeGhkR1ZmY0dGNWJXVnVkRjlpY21WaGEyUnZkMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk9ESXRPRE1LSUNBZ0lDOHZJQ01nVUd4aGRHWnZjbTBnUm1WbE9pQXlMalVsQ2lBZ0lDQXZMeUJ3YkdGMFptOXliVjltWldVZ1BTQW9ZVzF2ZFc1MExtNWhkR2wyWlNBcUlGVkpiblEyTkNneU5UQXBLU0F2THlCVlNXNTBOalFvTVRBd01EQXBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpVd0NpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MEwyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJ5WlcxaGFXNXBibWNnUFNCaGJXOTFiblF1Ym1GMGFYWmxJQzBnY0d4aGRHWnZjbTFmWm1WbENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T0RVdE9EWUtJQ0FnSUM4dklDTWdVbTk1WVd4MGVUb2dNVEFsSUc5bUlISmxiV0ZwYm1sdVp3b2dJQ0FnTHk4Z2NtOTVZV3gwZVNBOUlDaHlaVzFoYVc1cGJtY2dLaUJWU1c1ME5qUW9NVEF3TUNrcElDOHZJRlZKYm5RMk5DZ3hNREF3TUNrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREFLSUNBZ0lDOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwTDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QmpjbVZoZEc5eVgyRnRkQ0E5SUhKbGJXRnBibWx1WnlBdElISnZlV0ZzZEhrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRDOWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2NHeGhkR1p2Y20xZlptVmxLU3dLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblF2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSEp2ZVdGc2RIa3BMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWJXVnVkQzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9ZM0psWVhSdmNsOWhiWFFwTEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFTQ1FUZ0F4RzBFQUpERVpGRVF4R0VTQ0F3U3ZhWUE1Qk5Ua0NQTUU5Z1V4OURZYUFJNERBQWtBaVFERkFERVpGREVZRkJCRE1SWWlDVWs0RUNJU1JEWWFBVWtWSXhKRU5ob0NTUlVqRWtRMkdnTkpGU01TUkRZYUJFa1ZnUWdTUkVzRU9BY3lDaEpFVHdRNENFd1hURXNCRWtSSmdmb0JDeVFLVEVzQkNVbUI2QWNMSkFwTVN3RUpzVThDc2doUEE3SUhJcklRSmJJQnM3Rk1zZ2hNc2djaXNoQWxzZ0d6c2JJSXNnY2lzaEFsc2dHeklrTXhGaUlKU1RnUUloSkVOaG9CU1JVakVrUTJHZ0pKRllFSUVrUkxBamdITWdvU1JFOENPQWhNRjB4TEFSSkVzYklJc2djaXNoQWxzZ0d6SWtNMkdnRkpGWUVJRWtRWFNZSDZBUXNrQ2t4TEFRbEpnZWdIQ3lRS1RFc0JDVThDRms4Q0ZrOENGazRDVUV4UWdBUVZIM3gxVEZDd0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
