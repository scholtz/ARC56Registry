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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.c_0e8e0935
{


    public class cProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public cProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SendMessageReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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

                public static SendMessageReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SendMessageReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SendMessageReturn);
                }
                public bool Equals(SendMessageReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SendMessageReturn left, SendMessageReturn right)
                {
                    return EqualityComparer<SendMessageReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(SendMessageReturn left, SendMessageReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Set(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 101, 111, 29 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Set_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 101, 111, 29 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> CheckIfDataIsEmpty(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 108, 188, 193 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CheckIfDataIsEmpty_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 108, 188, 193 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.SendMessageReturn> SendMessage(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 166, 35, 100 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SendMessageReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> SendMessage_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 166, 35, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Fallback(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 249, 136, 43 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Fallback_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 249, 136, 43 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTZW5kTWVzc2FnZVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJ5dGVbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjaGVja0lmRGF0YUlzRW1wdHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2VuZE1lc3NhZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYnl0ZVtdKSIsInN0cnVjdCI6IlNlbmRNZXNzYWdlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19mYWxsYmFjayIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzY1Nl0sImVycm9yTWVzc2FnZSI6Il9fcG9zdEluaXQgYWxyZWFkeSBjYWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQsMjMyLDI3Nyw2ODRdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WTJGc2JHUmhkR0V2WTI5d2VWOW1jbTl0WDJOaGJHeGtZWFJoWDNKbGJXOTJaWE5mWW5sMFpYTmZaR0YwWVM1emIyd3VZeTVoY0hCeWIzWmhiRjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0F5SURNS0lDQWdJR0o1ZEdWallteHZZMnNnSW1SaGRHRWlJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SWdNSGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQnVJREUwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EQTVOZ29nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTlFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnYkc5aFpDQXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dDaUFnSUNCeVpYQnNZV05sTWlBMk5Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ1kyRnNiSE4xWWlCZlgyWmhiR3hpWVdOckNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRElLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdKaFkyTTBPV1V6SURCNE1qSTJOVFptTVdRZ01IaGpPVFpqWW1Oak1TQXdlRGN3WVRZeU16WTBJREI0TVdKbU9UZzRNbUlnTHk4Z2JXVjBhRzlrSUNKZlgzQnZjM1JKYm1sMEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUW9LV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltTm9aV05yU1daRVlYUmhTWE5GYlhCMGVTZ3BZbTl2YkNJc0lHMWxkR2h2WkNBaWMyVnVaRTFsYzNOaFoyVW9LU2hpYjI5c0xHSjVkR1ZiWFNraUxDQnRaWFJvYjJRZ0lsOWZabUZzYkdKaFkyc29LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDE5ZmNHOXpkRWx1YVhSZmNtOTFkR1ZBT1NCdFlXbHVYM05sZEY5eWIzVjBaVUF4TUNCdFlXbHVYMk5vWldOclNXWkVZWFJoU1hORmJYQjBlVjl5YjNWMFpVQXhNU0J0WVdsdVgzTmxibVJOWlhOellXZGxYM0p2ZFhSbFFERXlJRzFoYVc1ZlgxOW1ZV3hzWW1GamExOXliM1YwWlVBeE13b0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFME9nb2dJQ0FnWkdsbklERUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1pIVndDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lHTmhiR3h6ZFdJZ1gxOW1ZV3hzWW1GamF3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0oxY25rZ01Rb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWDE5bVlXeHNZbUZqYTE5eWIzVjBaVUF4TXpvS0lDQWdJR05oYkd4emRXSWdYMTltWVd4c1ltRmphd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKMWNua2dNZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0NtMWhhVzVmYzJWdVpFMWxjM05oWjJWZmNtOTFkR1ZBTVRJNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESXlPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JqWVd4c2MzVmlJRjlmWm1Gc2JHSmhZMnNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFPREF3TURBek1EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW5WeWVTQXlDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXhPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESXlDZ3B0WVdsdVgyTm9aV05yU1daRVlYUmhTWE5GYlhCMGVWOXliM1YwWlVBeE1Ub0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNallLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNamM2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUmhkR0VpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW5WeWVTQXlDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTNDZ3B0WVdsdVgzTmxkRjl5YjNWMFpVQXhNRG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTXpFS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTXpJNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBT0RJS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU16VUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKMWNua2dNVGNLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek5qb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUGdvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNems2Q2lBZ0lDQmthV2NnTVRjS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXhOZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5ERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTWpvS0lDQWdJR1JwWnlBeE5nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eklDOHZJRE1LSUNBZ0lENEtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTBOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRMU9nb2dJQ0FnWkdsbklERTFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lENEtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTBOd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURRNE9nb2dJQ0FnWkdsbklERTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRNS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lENEtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVeE9nb2dJQ0FnWkdsbklERXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRJS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lENEtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVME9nb2dJQ0FnWkdsbklERXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lENEtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVM09nb2dJQ0FnWkdsbklERXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lENEtJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTFPUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURZd09nb2dJQ0FnWkdsbklERXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnT1FvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1Bnb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTVDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpNNkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRGdLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXdDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmpZNkNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRGNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qZ0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXhDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTmprNkNpQWdJQ0JrYVdjZ053b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRFlLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXlDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU56RUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXlDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTnpJNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRFVLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERXpDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU56UUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXpDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTnpVNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRFFLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERTBDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU56Y0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTnpnNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRE1LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERTFDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9EQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERTFDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT0RFNkNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT0RNNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa1lYUmhJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prWVhSaElnb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW5WeWVTQXlDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TkFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEZ3dPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTRNUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjM09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBM09Bb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGMwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEzTlFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEY3hPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNNZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk9Rb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFkxT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTJNd29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk1Bb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFUyT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTndvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEVXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFOQW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVd09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU1Rb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFEzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT0FvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBOUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURReE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME1nb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE00T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T1FvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETTFPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEZ3lPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTRNd29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNeE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURNeUNncHRZV2x1WDE5ZmNHOXpkRWx1YVhSZmNtOTFkR1ZBT1RvS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmZYM0J2YzNSSmJtbDBJR0ZzY21WaFpIa2dZMkZzYkdWa0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKMWNua2dNZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRRS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZZMkZzYkdSaGRHRXZZMjl3ZVY5bWNtOXRYMk5oYkd4a1lYUmhYM0psYlc5MlpYTmZZbmwwWlhOZlpHRjBZUzV6YjJ3dVl5NWZYMlpoYkd4aVlXTnJLQ2tnTFQ0Z2RtOXBaRG9LWDE5bVlXeHNZbUZqYXpvS0lDQWdJSEJ5YjNSdklEQWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdNVFFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NsOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFV6Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRRGM2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lENEtJQ0FnSUdKNklGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUGdvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREV5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2dwZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRNNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6TWdMeThnTXdvZ0lDQWdQZ29nSUNBZ1lub2dYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMlpoYkhObFFERTFDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNVFk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQ0S0lDQWdJR0o2SUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4T0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvS1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURFNU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQStDaUFnSUNCaWVpQmZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU1qRUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtDbDlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXlNam9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnUGdvZ0lDQWdZbm9nWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2dwZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTWpVNkNpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURZS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lENEtJQ0FnSUdKNklGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU53b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b0tYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMjFsY21kbFFESTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTNDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0ErQ2lBZ0lDQmllaUJmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNekFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGdLQ2w5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6TVRvS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnT0FvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURNekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNUNncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU16UTZDaUFnSUNCbWNtRnRaVjlrYVdjZ09Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEa0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0ErQ2lBZ0lDQmllaUJmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFNellLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV3Q2dwZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTXpjNkNpQWdJQ0JtY21GdFpWOWthV2NnT1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFd0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F4TVFvZ0lDQWdQZ29nSUNBZ1lub2dYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMlpoYkhObFFETTVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNUW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRRFF3T2dvZ0lDQWdabkpoYldWZlpHbG5JREV3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTVRFS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQStDaUFnSUNCaWVpQmZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU5ESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXlDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmYldWeVoyVkFORE02Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVEVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F4TWdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJSEIxYzJocGJuUWdNVE1LSUNBZ0lENEtJQ0FnSUdKNklGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UTUtDbDlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTBOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXhNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREV6Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXhOQW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyWmhiSE5sUURRNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE5Bb0tYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMjFsY21kbFFEUTVPZ29nSUNBZ1puSmhiV1ZmWkdsbklERXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNVFFLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElERTFDaUFnSUNBK0NpQWdJQ0JpZWlCZlgyWmhiR3hpWVdOclgzUmxjbTVoY25sZlptRnNjMlZBTlRFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFMUNncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZiV1Z5WjJWQU5USTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01UUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDIxbGNtZGxRRFUwT2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWkdGMFlTSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaR0YwWVNJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFV4T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTFNZ29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFE0T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTBPUW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFExT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTBOZ29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRFF5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTBNd29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRE01T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQTBNQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRE0yT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXpOd29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRE16T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXpOQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRE13T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXpNUW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREkzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXlPQW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREkwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXlOUW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREl4T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXlNZ29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREU0T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXhPUW9LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREUxT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXhOZ29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRREV5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjlmWm1Gc2JHSmhZMnRmZEdWeWJtRnllVjl0WlhKblpVQXhNd29LWDE5bVlXeHNZbUZqYTE5MFpYSnVZWEo1WDJaaGJITmxRRGs2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMTltWVd4c1ltRmphMTkwWlhKdVlYSjVYMjFsY21kbFFERXdDZ3BmWDJaaGJHeGlZV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFOam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaUlGOWZabUZzYkdKaFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBM0NncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU5UTTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gxOW1ZV3hzWW1GamExOTBaWEp1WVhKNVgyMWxjbWRsUURVMENncGZYMlpoYkd4aVlXTnJYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUY5ZlptRnNiR0poWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WTJGc2JHUmhkR0V2WTI5d2VWOW1jbTl0WDJOaGJHeGtZWFJoWDNKbGJXOTJaWE5mWW5sMFpYTmZaR0YwWVM1emIyd3VZeTVqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBRUNBeVlEQkdSaGRHRU9YMTlqZEc5eVgzQmxibVJwYm1jQUlrY09La21CZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBQVVwSTJjalF6RWJRQUFGaUFJMEkwTWlSUUl4R1JSRU1SaEJBQ3FDQlFTNnpFbmpCQ0psYngwRXlXeTh3UVJ3cGlOa0JCdjVpQ3MyR2dDT0JRSHdBR3NBUGdBWUFBOUxBVVVCU1VBQUJvZ0I4U05GQVVPSUFlb2pSUUpDLytneEZrRUFIVEVXSXdrNENCUkVpQUhVZ0FrVkgzeDFnQUFEQUFDd0kwVUNRdi9HSWtMLzVURVdRUUFrTVJZakNUZ0lGRVFvdlVnV0txaUFBUUFpVHdKVWdBUVZIM3gxVEZDd0kwVUNRditaSWtMLzNqRVdRUUY4TVJZakNUZ0lGRVF4RzBFQmFqRWJRUUZlTmhvQVJSRXhHeU1OUVFGTk5ob0JTeEZNVUVVUU1Sc2tEVUVCT0RZYUFrc1FURkJGRHpFYkpRMUJBU00yR2dOTEQweFFSUTR4RzRFRURVRUJEVFlhQkVzT1RGQkZEVEViZ1FVTlFRRDNOaG9GU3cxTVVFVU1NUnVCQmcxQkFPRTJHZ1pMREV4UVJRc3hHNEVIRFVFQXl6WWFCMHNMVEZCRkNqRWJnUWdOUVFDMU5ob0lTd3BNVUVVSk1SdUJDUTFCQUo4MkdnbExDVXhRUlFneEc0RUtEVUVBaVRZYUNrc0lURkJGQnpFYmdRc05RUUJ6TmhvTFN3ZE1VRVVHTVJ1QkRBMUJBRjAyR2d4TEJreFFSUVV4RzRFTkRVRUFSellhRFVzRlRGQkZCREViZ1E0TlFRQXhOaG9PU3dSTVVFVURNUnVCRHcxQkFCczJHZzlMQTB4UUtMeElLRXkvZ0FVVkgzeDFnTEFqUlFKQy9tc2lyMEwvNHlLdlF2L05JcTlDLzdjaXIwTC9vU0t2UXYrTElxOUMvM1VpcjBML1h5S3ZRdjlKSXE5Qy96TWlyMEwvSFNLdlF2OEhJcTlDL3ZFaXIwTCsyeUt2UXY3R0lxOUMvckVpcjBVUlF2NmdJcTlDLzVVaVF2NkdLV1JFS1NKbkkwVUNRdjRFaWdBQUlrY09NUlpCQVc4eEZpTUpPQWdVUkRFYlFRRmRNUnRCQVZFMkdnQ01BREViSXcxQkFVQTJHZ0dMQUV4UWpBRXhHeVFOUVFFck5ob0Npd0ZNVUl3Q01Sc2xEVUVCRmpZYUE0c0NURkNNQXpFYmdRUU5RUUVBTmhvRWl3Tk1VSXdFTVJ1QkJRMUJBT28yR2dXTEJFeFFqQVV4RzRFR0RVRUExRFlhQm9zRlRGQ01CakViZ1FjTlFRQytOaG9IaXdaTVVJd0hNUnVCQ0ExQkFLZzJHZ2lMQjB4UWpBZ3hHNEVKRFVFQWtqWWFDWXNJVEZDTUNURWJnUW9OUVFCOE5ob0tpd2xNVUl3S01SdUJDdzFCQUdZMkdndUxDa3hRakFzeEc0RU1EVUVBVURZYURJc0xURkNNRERFYmdRME5RUUE2TmhvTml3eE1VSXdOTVJ1QkRnMUJBQ1EyR2c2TERVeFFqQTR4RzRFUERVRUFEallhRDRzT1RGQW92RWdvVEwrSklxOUMvL0FpcjBMLzJpS3ZRdi9FSXE5Qy82NGlyMEwvbUNLdlF2K0NJcTlDLzJ3aXIwTC9WaUt2UXY5QUlxOUMveW9pcjBML0ZDS3ZRdjcrSXE5Qy91Z2lyMEwrMHlLdlF2NitJcStNQUVMK3JTS3ZRditpSWtMK2t3PT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
