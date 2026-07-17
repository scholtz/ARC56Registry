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

namespace Arc56.Generated.algorandfoundation.puya.TicTacToeContract_d60662e2
{


    public class TicTacToeContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TicTacToeContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NewGameArgMove : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NewGameArgMove Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NewGameArgMove();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NewGameArgMove);
                }
                public bool Equals(NewGameArgMove? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NewGameArgMove left, NewGameArgMove right)
                {
                    return EqualityComparer<NewGameArgMove>.Default.Equals(left, right);
                }
                public static bool operator !=(NewGameArgMove left, NewGameArgMove right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="move"> NewGameArgMove</param>
        public async Task NewGame(Structs.NewGameArgMove move, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 169, 113, 129 };

            var result = await base.CallApp(new List<object> { abiHandle, move }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NewGame_Transactions(Structs.NewGameArgMove move, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 169, 113, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle, move }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="move"> NewGameArgMove</param>
        public async Task JoinGame(Structs.NewGameArgMove move, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 160, 121, 179 };

            var result = await base.CallApp(new List<object> { abiHandle, move }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> JoinGame_Transactions(Structs.NewGameArgMove move, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 160, 121, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle, move }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte> WhoseTurn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 159, 17, 71 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> WhoseTurn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 159, 17, 71 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="move"> NewGameArgMove</param>
        public async Task Play(Structs.NewGameArgMove move, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 235, 245, 142 };

            var result = await base.CallApp(new List<object> { abiHandle, move }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Play_Transactions(Structs.NewGameArgMove move, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 235, 245, 142 };

            return await base.MakeTransactionList(new List<object> { abiHandle, move }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGljVGFjVG9lQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTmV3R2FtZUFyZ01vdmUiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJuZXdfZ2FtZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJOZXdHYW1lQXJnTW92ZSIsIm5hbWUiOiJtb3ZlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImpvaW5fZ2FtZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJOZXdHYW1lQXJnTW92ZSIsIm5hbWUiOiJtb3ZlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Indob3NlX3R1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBsYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiTmV3R2FtZUFyZ01vdmUiLCJuYW1lIjoibW92ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI2OV0sImVycm9yTWVzc2FnZSI6IkdhbWUgaXMgYWxyZWFkeSBmaW5pc2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOV0sImVycm9yTWVzc2FnZSI6IkdhbWUgaXNuJ3Qgb3ZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOV0sImVycm9yTWVzc2FnZSI6Ikhvc3QgYWxyZWFkeSBoYXMgYSBjaGFsbGVuZ2VyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA3XSwiZXJyb3JNZXNzYWdlIjoiSXQgaXMgdGhlIGNoYWxsZW5nZXIncyB0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4XSwiZXJyb3JNZXNzYWdlIjoiSXQgaXMgdGhlIGhvc3QncyB0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5LDMzNF0sImVycm9yTWVzc2FnZSI6Ik1vdmUgbXVzdCBiZSBpbiByYW5nZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NV0sImVycm9yTWVzc2FnZSI6IlNxdWFyZSBpcyBhbHJlYWR5IHRha2VuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzLDMzOCwzODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdhbWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ob3N0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNiwyNzMsMzc0LDQzNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHVybnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5LDE3NCwxNzUsMzQ1LDM1MCwzNjAsMzY3LDM5MiwzOTcsNDAxLDQxMyw0NTAsNDU5LDQ2MSw0NzAsNDgwLDQ4Niw0OTgsNTA5LDUyMCw1MjMsNTM4LDU0OSw1NTJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMywxOTUsMjU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8YXJjNC51aW50NjQsYXJjNC51aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNeUF4TmdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWjJGdFpTSWdJblIxY201eklpQWlZMmhoYkd4bGJtZGxjaUlnSW5kcGJtNWxjaUlnTUhnd01TQXdlREF5SUNKb2IzTjBJZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRveE5Rb2dJQ0FnTHk4Z1kyeGhjM01nVkdsalZHRmpWRzlsUTI5dWRISmhZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNU5tRTVOekU0TVNBdkx5QnRaWFJvYjJRZ0ltNWxkMTluWVcxbEtDaDFhVzUwTmpRc2RXbHVkRFkwS1NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYm1WM1gyZGhiV1VLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFPZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRveE5Rb2dJQ0FnTHk4Z1kyeGhjM01nVkdsalZHRmpWRzlsUTI5dWRISmhZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREUzWVRBM09XSXpJREI0WW1JNVpqRXhORGNnTUhnNVpXVmlaalU0WlNBdkx5QnRaWFJvYjJRZ0ltcHZhVzVmWjJGdFpTZ29kV2x1ZERZMExIVnBiblEyTkNrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZDJodmMyVmZkSFZ5YmlncGRXbHVkRGdpTENCdFpYUm9iMlFnSW5Cc1lYa29LSFZwYm5RMk5DeDFhVzUwTmpRcEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCcWIybHVYMmRoYldVZ2QyaHZjMlZmZEhWeWJpQndiR0Y1Q2lBZ0lDQmxjbklLQ2dvdkx5QmxlR0Z0Y0d4bGN5NTBhV04wWVdOMGIyVXVkR2xqZEdGamRHOWxMbFJwWTFSaFkxUnZaVU52Ym5SeVlXTjBMbTVsZDE5bllXMWxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYm1WM1gyZGhiV1U2Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qSXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKaGJHeHZkeUlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblIxY0d4bFBHRnlZelF1ZFdsdWREWTBMR0Z5WXpRdWRXbHVkRFkwUGdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TWpJS0lDQWdJQzh2SUdsbUlGUjRiaTVoY0hCc2FXTmhkR2x2Ymw5cFpEb0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ1WlhkZloyRnRaVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TWpNdE1qVUtJQ0FnSUM4dklDTWdhV1lnWVNCamFHRnNiR1Z1WjJWeUlHaGhjeUJxYjJsdVpXUXNJR1J2YmlkMElHRnNiRzkzSUhOMFlYSjBhVzVuSUdFZ2JtVjNJR2RoYldVS0lDQWdJQzh2SUNNZ2RXNTBhV3dnZEdocGN5QnZibVVnYVhNZ1kyOXRjR3hsZEdVS0lDQWdJQzh2SUdsbUlITmxiR1l1WTJoaGJHeGxibWRsY2pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pqYUdGc2JHVnVaMlZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dibVYzWDJkaGJXVmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPakkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1M2FXNXVaWElzSUNKSFlXMWxJR2x6YmlkMElHOTJaWElpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkMmx1Ym1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRWRoYldVZ2FYTnVKM1FnYjNabGNnb0tibVYzWDJkaGJXVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG95TnkweU9Bb2dJQ0FnTHk4Z0l5QnlaWE5sZENCamFHRnNiR1Z1WjJWeUlHRnVaQ0IzYVc1dVpYSUtJQ0FnSUM4dklHUmxiQ0J6Wld4bUxtTm9ZV3hzWlc1blpYSXVkbUZzZFdVS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ob1lXeHNaVzVuWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJSbGJBb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG95T1FvZ0lDQWdMeThnWkdWc0lITmxiR1l1ZDJsdWJtVnlMblpoYkhWbENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKM2FXNXVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMlJsYkFvS2JtVjNYMmRoYldWZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUb3pNQW9nSUNBZ0x5OGdjMlZzWmk1b2IzTjBJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdZbmwwWldNZ05pQXZMeUFpYUc5emRDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPak14Q2lBZ0lDQXZMeUJ6Wld4bUxtZGhiV1VnUFNCSFlXMWxMbVp5YjIxZllubDBaWE1vYjNBdVlucGxjbThvT1NrcENpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puWVcxbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0JqYjJ4MWJXNGdQQ0F6SUdGdVpDQnliM2NnUENBekxDQWlUVzkyWlNCdGRYTjBJR0psSUdsdUlISmhibWRsSWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQnVaWGRmWjJGdFpWOWliMjlzWDJaaGJITmxRRGdLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUR3S0lDQWdJR0o2SUc1bGQxOW5ZVzFsWDJKdmIyeGZabUZzYzJWQU9Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtNWxkMTluWVcxbFgySnZiMnhmYldWeVoyVkFPVG9LSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk16TUtJQ0FnSUM4dklHRnpjMlZ5ZENCamIyeDFiVzRnUENBeklHRnVaQ0J5YjNjZ1BDQXpMQ0FpVFc5MlpTQnRkWE4wSUdKbElHbHVJSEpoYm1kbElnb2dJQ0FnWVhOelpYSjBJQzh2SUUxdmRtVWdiWFZ6ZENCaVpTQnBiaUJ5WVc1blpRb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG96TkFvZ0lDQWdMeThnYzJWc1ppNW5ZVzFsVzNKdmQxMWJZMjlzZFcxdVhTQTlJR0Z5WXpRdVZVbHVkRGdvU0U5VFZDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbllXMWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kaGJXVWdaWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTXdvZ0lDQWdLZ29nSUNBZ1pIVndNZ29nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERUtJQ0FnSUhKbGNHeGhZMlV6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2NtVndiR0ZqWlRNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puWVcxbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TXpVS0lDQWdJQzh2SUhObGJHWXVkSFZ5Ym5NZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUjFjbTV6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qSXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKaGJHeHZkeUlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdVpYZGZaMkZ0WlY5aWIyOXNYMlpoYkhObFFEZzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdVpYZGZaMkZ0WlY5aWIyOXNYMjFsY21kbFFEa0tDZ292THlCbGVHRnRjR3hsY3k1MGFXTjBZV04wYjJVdWRHbGpkR0ZqZEc5bExsUnBZMVJoWTFSdlpVTnZiblJ5WVdOMExtcHZhVzVmWjJGdFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXB2YVc1ZloyRnRaVG9LSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk16Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUwZFhCc1pUeGhjbU0wTG5WcGJuUTJOQ3hoY21NMExuVnBiblEyTkQ0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QjBhV04wWVdOMGIyVXZkR2xqZEdGamRHOWxMbkI1T2pNNUNpQWdJQ0F2THlCaGMzTmxjblFnYm05MElITmxiR1l1WTJoaGJHeGxibWRsY2l3Z0lraHZjM1FnWVd4eVpXRmtlU0JvWVhNZ1lTQmphR0ZzYkdWdVoyVnlJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTm9ZV3hzWlc1blpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdTRzl6ZENCaGJISmxZV1I1SUdoaGN5QmhJR05vWVd4c1pXNW5aWElLSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk5EQUtJQ0FnSUM4dklITmxiR1l1WTJoaGJHeGxibWRsY2k1MllXeDFaU0E5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ob1lXeHNaVzVuWlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1dFlXdGxYMjF2ZG1Vb1lYSmpOQzVWU1c1ME9DaERTRUZNVEVWT1IwVlNLU3dnYlc5MlpTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQnRZV3RsWDIxdmRtVUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TXpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHVjRZVzF3YkdWekxuUnBZM1JoWTNSdlpTNTBhV04wWVdOMGIyVXVWR2xqVkdGalZHOWxRMjl1ZEhKaFkzUXVkMmh2YzJWZmRIVnlibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25kb2IzTmxYM1IxY200NkNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBPQ2hJVDFOVUtTQnBaaUJ6Wld4bUxuUjFjbTV6SUNVZ01pQmxiSE5sSUdGeVl6UXVWVWx1ZERnb1EwaEJURXhGVGtkRlVpa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGRYSnVjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGRYSnVjeUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdKUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF5Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qUXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1Y0WVcxd2JHVnpMblJwWTNSaFkzUnZaUzUwYVdOMFlXTjBiMlV1VkdsalZHRmpWRzlsUTI5dWRISmhZM1F1Y0d4aGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJzWVhrNkNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwTmpRc1lYSmpOQzUxYVc1ME5qUStDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUbzBPUW9nSUNBZ0x5OGdZWE56WlhKMElHNXZkQ0J6Wld4bUxuZHBibTVsY2l3Z0lrZGhiV1VnYVhNZ1lXeHlaV0ZrZVNCbWFXNXBjMmhsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ozYVc1dVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSMkZ0WlNCcGN5QmhiSEpsWVdSNUlHWnBibWx6YUdWa0NpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalV3Q2lBZ0lDQXZMeUJwWmlCelpXeG1MblIxY201eklDVWdNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBkWEp1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBkWEp1Y3lCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnSlFvZ0lDQWdZbm9nY0d4aGVWOWxiSE5sWDJKdlpIbEFNd29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1b2IzTjBMQ0FpU1hRZ2FYTWdkR2hsSUdodmMzUW5jeUIwZFhKdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbWh2YzNRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhRzl6ZENCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NYUWdhWE1nZEdobElHaHZjM1FuY3lCMGRYSnVDaUFnSUNBdkx5QjBhV04wWVdOMGIyVXZkR2xqZEdGamRHOWxMbkI1T2pVeUNpQWdJQ0F2THlCd2JHRjVaWElnUFNCaGNtTTBMbFZKYm5RNEtFaFBVMVFwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFS0NuQnNZWGxmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvMU9Bb2dJQ0FnTHk4Z2MyVnNaaTV0WVd0bFgyMXZkbVVvY0d4aGVXVnlMQ0J0YjNabEtRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCdFlXdGxYMjF2ZG1VS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZORGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjR3hoZVY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WTJoaGJHeGxibWRsY2k1blpYUW9DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalUxQ2lBZ0lDQXZMeUJrWldaaGRXeDBQVUZqWTI5MWJuUW9LUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbU5vWVd4c1pXNW5aWEl1WjJWMEtBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ob1lXeHNaVzVuWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvMU5DMDFOZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWphR0ZzYkdWdVoyVnlMbWRsZENnS0lDQWdJQzh2SUNBZ0lDQmtaV1poZFd4MFBVRmpZMjkxYm5Rb0tRb2dJQ0FnTHk4Z0tTd2dJa2wwSUdseklIUm9aU0JqYUdGc2JHVnVaMlZ5SjNNZ2RIVnliaUlLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpkQ0JwY3lCMGFHVWdZMmhoYkd4bGJtZGxjaWR6SUhSMWNtNEtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRjS0lDQWdJQzh2SUhCc1lYbGxjaUE5SUdGeVl6UXVWVWx1ZERnb1EwaEJURXhGVGtkRlVpa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNZ29nSUNBZ1lpQndiR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklHVjRZVzF3YkdWekxuUnBZM1JoWTNSdlpTNTBhV04wWVdOMGIyVXVWR2xqVkdGalZHOWxRMjl1ZEhKaFkzUXViV0ZyWlY5dGIzWmxLSEJzWVhsbGNqb2dZbmwwWlhNc0lHMXZkbVV1TURvZ2RXbHVkRFkwTENCdGIzWmxMakU2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LYldGclpWOXRiM1psT2dvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUbzJNQzAyTVFvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQnRZV3RsWDIxdmRtVW9jMlZzWml3Z2NHeGhlV1Z5T2lCaGNtTTBMbFZKYm5RNExDQnRiM1psT2lCTmIzWmxLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBMENpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPall6Q2lBZ0lDQXZMeUJoYzNObGNuUWdZMjlzZFcxdUlEd2dNeUJoYm1RZ2NtOTNJRHdnTXl3Z0lrMXZkbVVnYlhWemRDQmlaU0JwYmlCeVlXNW5aU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUR3S0lDQWdJR0o2SUcxaGEyVmZiVzkyWlY5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYTJWZmJXOTJaVjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwdFlXdGxYMjF2ZG1WZlltOXZiRjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvMk13b2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJIVnRiaUE4SURNZ1lXNWtJSEp2ZHlBOElETXNJQ0pOYjNabElHMTFjM1FnWW1VZ2FXNGdjbUZ1WjJVaUNpQWdJQ0JoYzNObGNuUWdMeThnVFc5MlpTQnRkWE4wSUdKbElHbHVJSEpoYm1kbENpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bllXMWxXM0p2ZDExYlkyOXNkVzF1WFNBOVBTQkZUVkJVV1N3Z0lsTnhkV0Z5WlNCcGN5QmhiSEpsWVdSNUlIUmhhMlZ1SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWRoYldVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaMkZ0WlNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh5SUM4dklETUtJQ0FnSUNvS0lDQWdJR1IxY0RJS0lDQWdJR2x1ZEdOZk1pQXZMeUF6Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVM0YxWVhKbElHbHpJR0ZzY21WaFpIa2dkR0ZyWlc0S0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZOalVLSUNBZ0lDOHZJSE5sYkdZdVoyRnRaVnR5YjNkZFcyTnZiSFZ0YmwwZ1BTQndiR0Y1WlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnlaWEJzWVdObE15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY21Wd2JHRmpaVE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5ZVzFsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZOallLSUNBZ0lDOHZJSE5sYkdZdWRIVnlibk1nS3owZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SMWNtNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SMWNtNXpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblIxY201eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TnpRS0lDQWdJQzh2SUdjZ1BTQnpaV3htTG1kaGJXVXVZMjl3ZVNncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWjJGdFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WjJGdFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZOellLSUNBZ0lDOHZJR2xtSUdkYmNtOTNYVnN3WFNBOVBTQm5XM0p2ZDExYk1WMGdQVDBnWjF0eWIzZGRXekpkT2dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE1LSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lERWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREVnTVNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCaVBUMEtJQ0FnSUdKNklHMWhhMlZmYlc5MlpWOWhablJsY2w5cFpsOWxiSE5sUURFekNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXlJREVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWWowOUNpQWdJQ0JpZWlCdFlXdGxYMjF2ZG1WZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUbzNOd29nSUNBZ0x5OGdjbVYwZFhKdUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3B0WVd0bFgyMXZkbVZmWVdaMFpYSmZhVzVzYVc1bFpGOWxlR0Z0Y0d4bGN5NTBhV04wWVdOMGIyVXVkR2xqZEdGamRHOWxMbFJwWTFSaFkxUnZaVU52Ym5SeVlXTjBMbVJwWkY5M2FXNUFNalU2Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qWTNDaUFnSUNBdkx5QnBaaUJ6Wld4bUxtUnBaRjkzYVc0b2NHeGhlV1Z5TENCamIyeDFiVzQ5WTI5c2RXMXVMQ0J5YjNjOWNtOTNLVG9LSUNBZ0lHSjZJRzFoYTJWZmJXOTJaVjlsYkhObFgySnZaSGxBTmdvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUbzJPQW9nSUNBZ0x5OGdjMlZzWmk1M2FXNXVaWEl1ZG1Gc2RXVWdQU0J3YkdGNVpYSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luZHBibTVsY2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhMlZmYlc5MlpWOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0J5WlhSemRXSUtDbTFoYTJWZmJXOTJaVjlsYkhObFgySnZaSGxBTmpvS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZOamtLSUNBZ0lDOHZJR1ZzYVdZZ2MyVnNaaTUwZFhKdWN5QTlQU0E1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblIxY201eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblIxY201eklHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQTVDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JXRnJaVjl0YjNabFgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUbzNNQW9nSUNBZ0x5OGdjMlZzWmk1M2FXNXVaWEl1ZG1Gc2RXVWdQU0JoY21NMExsVkpiblE0S0VSU1FWY3BDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjNhVzV1WlhJaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LYldGclpWOXRiM1psWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE02Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qYzVDaUFnSUNBdkx5QnBaaUJuV3pCZFcyTnZiSFZ0YmwwZ1BUMGdaMXN4WFZ0amIyeDFiVzVkSUQwOUlHZGJNbDFiWTI5c2RXMXVYVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBeklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeklETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0k5UFFvZ0lDQWdZbm9nYldGclpWOXRiM1psWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbGVIUnlZV04wSURZZ015QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSTlQUW9nSUNBZ1lub2diV0ZyWlY5dGIzWmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UWUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG80TUFvZ0lDQWdMeThnY21WMGRYSnVJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qWTNDaUFnSUNBdkx5QnBaaUJ6Wld4bUxtUnBaRjkzYVc0b2NHeGhlV1Z5TENCamIyeDFiVzQ5WTI5c2RXMXVMQ0J5YjNjOWNtOTNLVG9LSUNBZ0lHSWdiV0ZyWlY5dGIzWmxYMkZtZEdWeVgybHViR2x1WldSZlpYaGhiWEJzWlhNdWRHbGpkR0ZqZEc5bExuUnBZM1JoWTNSdlpTNVVhV05VWVdOVWIyVkRiMjUwY21GamRDNWthV1JmZDJsdVFESTFDZ3B0WVd0bFgyMXZkbVZmWVdaMFpYSmZhV1pmWld4elpVQXhOam9LSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk9ESXRPRE1LSUNBZ0lDOHZJQ01nYVdZZ2NHeGhlV1Z5SUc5M2JuTWdZMlZ1ZEdWeUxDQmphR1ZqYXlCa2FXRm5iMjVoYkhNS0lDQWdJQzh2SUdsbUlIQnNZWGxsY2lBOVBTQm5XekZkV3pGZE9nb2dJQ0FnWlhoMGNtRmpkQ0F4SURFZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSTlQUW9nSUNBZ1lub2diV0ZyWlY5dGIzWmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qUUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2T0RRS0lDQWdJQzh2SUdsbUlHZGJNRjFiTUYwZ1BUMGdjR3hoZVdWeUlEMDlJR2RiTWwxYk1sMDZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F3SURFZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSTlQUW9nSUNBZ1lub2diV0ZyWlY5dGIzWmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qQUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JsZUhSeVlXTjBJRFlnTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXhJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JpUFQwS0lDQWdJR0o2SUcxaGEyVmZiVzkyWlY5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qZzFDaUFnSUNBdkx5QnlaWFIxY200Z1ZISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TmpjS0lDQWdJQzh2SUdsbUlITmxiR1l1Wkdsa1gzZHBiaWh3YkdGNVpYSXNJR052YkhWdGJqMWpiMngxYlc0c0lISnZkejF5YjNjcE9nb2dJQ0FnWWlCdFlXdGxYMjF2ZG1WZllXWjBaWEpmYVc1c2FXNWxaRjlsZUdGdGNHeGxjeTUwYVdOMFlXTjBiMlV1ZEdsamRHRmpkRzlsTGxScFkxUmhZMVJ2WlVOdmJuUnlZV04wTG1ScFpGOTNhVzVBTWpVS0NtMWhhMlZmYlc5MlpWOWhablJsY2w5cFpsOWxiSE5sUURJd09nb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG80TmdvZ0lDQWdMeThnYVdZZ1oxc3dYVnN5WFNBOVBTQndiR0Y1WlhJZ1BUMGdaMXN5WFZzd1hUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRElnTVNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lqMDlDaUFnSUNCaWVpQnRZV3RsWDIxdmRtVmZZV1owWlhKZmFXWmZaV3h6WlVBeU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdOaUF6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pYaDBjbUZqZENBd0lERWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0k5UFFvZ0lDQWdZbm9nYldGclpWOXRiM1psWDJGbWRHVnlYMmxtWDJWc2MyVkFNalFLSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCVWNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8yTndvZ0lDQWdMeThnYVdZZ2MyVnNaaTVrYVdSZmQybHVLSEJzWVhsbGNpd2dZMjlzZFcxdVBXTnZiSFZ0Yml3Z2NtOTNQWEp2ZHlrNkNpQWdJQ0JpSUcxaGEyVmZiVzkyWlY5aFpuUmxjbDlwYm14cGJtVmtYMlY0WVcxd2JHVnpMblJwWTNSaFkzUnZaUzUwYVdOMFlXTjBiMlV1VkdsalZHRmpWRzlsUTI5dWRISmhZM1F1Wkdsa1gzZHBia0F5TlFvS2JXRnJaVjl0YjNabFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpRNkNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPamc0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdSbUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qWTNDaUFnSUNBdkx5QnBaaUJ6Wld4bUxtUnBaRjkzYVc0b2NHeGhlV1Z5TENCamIyeDFiVzQ5WTI5c2RXMXVMQ0J5YjNjOWNtOTNLVG9LSUNBZ0lHSWdiV0ZyWlY5dGIzWmxYMkZtZEdWeVgybHViR2x1WldSZlpYaGhiWEJzWlhNdWRHbGpkR0ZqZEc5bExuUnBZM1JoWTNSdlpTNVVhV05VWVdOVWIyVkRiMjUwY21GamRDNWthV1JmZDJsdVFESTFDZ3B0WVd0bFgyMXZkbVZmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGclpWOXRiM1psWDJKdmIyeGZiV1Z5WjJWQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFREVDWUhCR2RoYldVRmRIVnlibk1LWTJoaGJHeGxibWRsY2daM2FXNXVaWElCQVFFQ0JHaHZjM1F4R1JSRWdBU1dxWEdCTmhvQWpnRUFJREVZUklJREJCZWdlYk1FdTU4UlJ3U2U2L1dPTmhvQWpnTUFYUUNBQUprQU5ob0JTUlVsRWtSSklsdE1nUWhiTVJoQkFCSWlLbVZGQVVFQUJpSXJaVVVCUkNwcEsya25CakVBWjRFSnJ5aE1aMHNCSkF4QkFDQkpKQXhCQUJvalJDSW9aVVJNSkF0S0pGaFBBeWNFWFYwb1RHY3BJbWNqUXlKQy8rTTJHZ0ZKRlNVU1JFa2lXMHlCQ0ZzaUttVkZBUlJFS2pFQVp5Y0ZUZ0tJQUZ3alF5SXBaVVNCQWhnbkJTY0VUd0pOZ0FRVkgzeDFURkN3STBNMkdnRkpGU1VTUkVraVcweUJDRnNpSzJWRkFSUkVJaWxsUklFQ0dFRUFFakVBSWljR1pVUVNSQ2NFVGdLSUFCRWpRekVBTWdNaUttVk5Fa1FuQlVMLzZvb0RBQ0pIQkl2K0pBeEJBUE9ML3lRTVFRRHNJMFFpS0dWRWkvOGtDMG9rV0VtTC9pTllnQUVBcUVTTC9vdjlYVThDU3dKUEFsMG9UR2NpS1dWRUl3Z3BUR2NpS0dWTVNVNENqQVJFVENSWVNZd0JTVmNBQVV4WEFRRkpqQUtvUVFBa2l3RlhBZ0dMQXFoQkFCa2pRUUFGSzR2OVo0a2lLV1ZFZ1FrU1FmLzFLNEFCQTJlSml3UkpWd0FEU1l3RGkvNGpXRXhYQXdOSlRnS0wvaU5ZU1l3QXFFRUFGSXNFVndZRGkvNGpXSXNBcUVFQUJVZ2pRdisxVndFQmkvMm9RUUE2aXdOWEFBR0wvYWhCQUJLTEJGY0dBMWNDQVl2OXFFRUFCQ05DLzQrTEExY0NBWXY5cUVFQUVvc0VWd1lEVndBQmkvMm9RUUFFSTBML2NpSkMvMjRpUXY4UiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
