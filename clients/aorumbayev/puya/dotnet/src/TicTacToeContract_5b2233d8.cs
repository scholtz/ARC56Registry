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

namespace Arc56.Generated.aorumbayev.puya.TicTacToeContract_5b2233d8
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGljVGFjVG9lQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTmV3R2FtZUFyZ01vdmUiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJuZXdfZ2FtZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJOZXdHYW1lQXJnTW92ZSIsIm5hbWUiOiJtb3ZlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImpvaW5fZ2FtZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJOZXdHYW1lQXJnTW92ZSIsIm5hbWUiOiJtb3ZlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Indob3NlX3R1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBsYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiTmV3R2FtZUFyZ01vdmUiLCJuYW1lIjoibW92ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjR9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMxMl0sImVycm9yTWVzc2FnZSI6IkdhbWUgaXMgYWxyZWFkeSBmaW5pc2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6IkdhbWUgaXNuJ3Qgb3ZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3M10sImVycm9yTWVzc2FnZSI6Ikhvc3QgYWxyZWFkeSBoYXMgYSBjaGFsbGVuZ2VyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM4LDI0MSwyNTEsMzkyLDM5Niw0MTAsNDEzLDQyMyw0NTIsNDU3LDQ2MSw0NzMsNTEwLDUxOSw1MjEsNTMwLDU0MCw1NDYsNTU5LDU3MCw1ODEsNTg0LDU5OSw2MTAsNjEzXSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTFdLCJlcnJvck1lc3NhZ2UiOiJJdCBpcyB0aGUgY2hhbGxlbmdlcidzIHR1cm4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzFdLCJlcnJvck1lc3NhZ2UiOiJJdCBpcyB0aGUgaG9zdCdzIHR1cm4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjcsMzc5XSwiZXJyb3JNZXNzYWdlIjoiTW92ZSBtdXN0IGJlIGluIHJhbmdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIsMTEzLDEzNCwxNTVdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDFdLCJlcnJvck1lc3NhZ2UiOiJTcXVhcmUgaXMgYWxyZWFkeSB0YWtlbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1LDExNiwxMzddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMxLDM4Myw0MDUsNDQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nYW1lIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaG9zdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTEsMzE2LDQzNCw0OTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnR1cm5zIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCbGVHRnRjR3hsY3k1MGFXTjBZV04wYjJVdWRHbGpkR0ZqZEc5bExsUnBZMVJoWTFSdlpVTnZiblJ5WVdOMExsOWZZV3huYjNCNVgyVnVkSEo1Y0c5cGJuUmZkMmwwYUY5cGJtbDBLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0F6SURnS0lDQWdJR0o1ZEdWallteHZZMnNnSW1kaGJXVWlJQ0owZFhKdWN5SWdJbU5vWVd4c1pXNW5aWElpSUNKM2FXNXVaWElpSURCNE1ERWdNSGd3TWlBaWFHOXpkQ0lLSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk1UVUtJQ0FnSUM4dklHTnNZWE56SUZScFkxUmhZMVJ2WlVOdmJuUnlZV04wS0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEazJZVGszTVRneElEQjRNVGRoTURjNVlqTWdNSGhpWWpsbU1URTBOeUF3ZURsbFpXSm1OVGhsSUM4dklHMWxkR2h2WkNBaWJtVjNYMmRoYldVb0tIVnBiblEyTkN4MWFXNTBOalFwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbXB2YVc1ZloyRnRaU2dvZFdsdWREWTBMSFZwYm5RMk5Da3BkbTlwWkNJc0lHMWxkR2h2WkNBaWQyaHZjMlZmZEhWeWJpZ3BkV2x1ZERnaUxDQnRaWFJvYjJRZ0luQnNZWGtvS0hWcGJuUTJOQ3gxYVc1ME5qUXBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDI1bGQxOW5ZVzFsWDNKdmRYUmxRRFVnYldGcGJsOXFiMmx1WDJkaGJXVmZjbTkxZEdWQU5pQnRZV2x1WDNkb2IzTmxYM1IxY201ZmNtOTFkR1ZBTnlCdFlXbHVYM0JzWVhsZmNtOTFkR1ZBT0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEazZDaUFnSUNBdkx5QjBhV04wWVdOMGIyVXZkR2xqZEdGamRHOWxMbkI1T2pFMUNpQWdJQ0F2THlCamJHRnpjeUJVYVdOVVlXTlViMlZEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0JzWVhsZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZORGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPakUxQ2lBZ0lDQXZMeUJqYkdGemN5QlVhV05VWVdOVWIyVkRiMjUwY21GamRDaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnY0d4aGVRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5M2FHOXpaVjkwZFhKdVgzSnZkWFJsUURjNkNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalF6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUIzYUc5elpWOTBkWEp1Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhbTlwYmw5bllXMWxYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QjBhV04wWVdOMGIyVXZkR2xqZEdGamRHOWxMbkI1T2pNM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRveE5Rb2dJQ0FnTHk4Z1kyeGhjM01nVkdsalZHRmpWRzlsUTI5dWRISmhZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvek53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHcHZhVzVmWjJGdFpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dVpYZGZaMkZ0WlY5eWIzVjBaVUExT2dvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUb3lNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaVlXeHNiM2NpS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG94TlFvZ0lDQWdMeThnWTJ4aGMzTWdWR2xqVkdGalZHOWxRMjl1ZEhKaFkzUW9ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG95TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGlZV3hzYjNjaUtRb2dJQ0FnWTJGc2JITjFZaUJ1WlhkZloyRnRaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHVjRZVzF3YkdWekxuUnBZM1JoWTNSdlpTNTBhV04wWVdOMGIyVXVWR2xqVkdGalZHOWxRMjl1ZEhKaFkzUXVibVYzWDJkaGJXVW9iVzkyWlM0d09pQjFhVzUwTmpRc0lHMXZkbVV1TVRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwdVpYZGZaMkZ0WlRvS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZNakF0TWpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbUZzYkc5M0lpa0tJQ0FnSUM4dklHUmxaaUJ1WlhkZloyRnRaU2h6Wld4bUxDQnRiM1psT2lCTmIzWmxLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZNaklLSUNBZ0lDOHZJR2xtSUZSNGJpNWhjSEJzYVdOaGRHbHZibDlwWkRvS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnVaWGRmWjJGdFpWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZNak10TWpVS0lDQWdJQzh2SUNNZ2FXWWdZU0JqYUdGc2JHVnVaMlZ5SUdoaGN5QnFiMmx1WldRc0lHUnZiaWQwSUdGc2JHOTNJSE4wWVhKMGFXNW5JR0VnYm1WM0lHZGhiV1VLSUNBZ0lDOHZJQ01nZFc1MGFXd2dkR2hwY3lCdmJtVWdhWE1nWTI5dGNHeGxkR1VLSUNBZ0lDOHZJR2xtSUhObGJHWXVZMmhoYkd4bGJtZGxjam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmphR0ZzYkdWdVoyVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ2JtVjNYMmRoYldWZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qSTJDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTUzYVc1dVpYSXNJQ0pIWVcxbElHbHpiaWQwSUc5MlpYSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWQybHVibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFZGhiV1VnYVhOdUozUWdiM1psY2dvS2JtVjNYMmRoYldWZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUb3lOeTB5T0FvZ0lDQWdMeThnSXlCeVpYTmxkQ0JqYUdGc2JHVnVaMlZ5SUdGdVpDQjNhVzV1WlhJS0lDQWdJQzh2SUdSbGJDQnpaV3htTG1Ob1lXeHNaVzVuWlhJdWRtRnNkV1VLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU5vWVd4c1pXNW5aWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMlJsYkFvZ0lDQWdMeThnZEdsamRHRmpkRzlsTDNScFkzUmhZM1J2WlM1d2VUb3lPUW9nSUNBZ0x5OGdaR1ZzSUhObGJHWXVkMmx1Ym1WeUxuWmhiSFZsQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ozYVc1dVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyUmxiQW9LYm1WM1gyZGhiV1ZmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvek1Bb2dJQ0FnTHk4Z2MyVnNaaTVvYjNOMElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlhRzl6ZENJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qTXhDaUFnSUNBdkx5QnpaV3htTG1kaGJXVWdQU0JIWVcxbExtWnliMjFmWW5sMFpYTW9iM0F1WW5wbGNtOG9PU2twQ2lBZ0lDQndkWE5vYVc1MElEa2dMeThnT1FvZ0lDQWdZbnBsY204S0lDQWdJR0o1ZEdWalh6QWdMeThnSW1kaGJXVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvek13b2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJIVnRiaUE4SURNZ1lXNWtJSEp2ZHlBOElETXNJQ0pOYjNabElHMTFjM1FnWW1VZ2FXNGdjbUZ1WjJVaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2x1ZEdOZk1pQXZMeUF6Q2lBZ0lDQThDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWW5vZ2JtVjNYMmRoYldWZlltOXZiRjltWVd4elpVQTNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0E4Q2lBZ0lDQmllaUJ1WlhkZloyRnRaVjlpYjI5c1gyWmhiSE5sUURjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwdVpYZGZaMkZ0WlY5aWIyOXNYMjFsY21kbFFEZzZDaUFnSUNBdkx5QjBhV04wWVdOMGIyVXZkR2xqZEdGamRHOWxMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnWTI5c2RXMXVJRHdnTXlCaGJtUWdjbTkzSUR3Z015d2dJazF2ZG1VZ2JYVnpkQ0JpWlNCcGJpQnlZVzVuWlNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJOYjNabElHMTFjM1FnWW1VZ2FXNGdjbUZ1WjJVS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZNelFLSUNBZ0lDOHZJSE5sYkdZdVoyRnRaVnR5YjNkZFcyTnZiSFZ0YmwwZ1BTQmhjbU0wTGxWSmJuUTRLRWhQVTFRcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWjJGdFpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVuWVcxbElHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ0tnb2dJQ0FnWkhWd01nb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbllXMWxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk16VUtJQ0FnSUM4dklITmxiR1l1ZEhWeWJuTWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblIxY201eklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDbTVsZDE5bllXMWxYMkp2YjJ4ZlptRnNjMlZBTnpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzVsZDE5bllXMWxYMkp2YjJ4ZmJXVnlaMlZBT0FvS0NpOHZJR1Y0WVcxd2JHVnpMblJwWTNSaFkzUnZaUzUwYVdOMFlXTjBiMlV1VkdsalZHRmpWRzlsUTI5dWRISmhZM1F1YW05cGJsOW5ZVzFsS0cxdmRtVXVNRG9nZFdsdWREWTBMQ0J0YjNabExqRTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0thbTlwYmw5bllXMWxPZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvek55MHpPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdhbTlwYmw5bllXMWxLSE5sYkdZc0lHMXZkbVU2SUUxdmRtVXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNWphR0ZzYkdWdVoyVnlMQ0FpU0c5emRDQmhiSEpsWVdSNUlHaGhjeUJoSUdOb1lXeHNaVzVuWlhJaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTJoaGJHeGxibWRsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCSWIzTjBJR0ZzY21WaFpIa2dhR0Z6SUdFZ1kyaGhiR3hsYm1kbGNnb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8wTUFvZ0lDQWdMeThnYzJWc1ppNWphR0ZzYkdWdVoyVnlMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ1lubDBaV05mTWlBdkx5QWlZMmhoYkd4bGJtZGxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBhV04wWVdOMGIyVXZkR2xqZEdGamRHOWxMbkI1T2pReENpQWdJQ0F2THlCelpXeG1MbTFoYTJWZmJXOTJaU2hoY21NMExsVkpiblE0S0VOSVFVeE1SVTVIUlZJcExDQnRiM1psS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQnRZV3RsWDIxdmRtVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHVjRZVzF3YkdWekxuUnBZM1JoWTNSdlpTNTBhV04wWVdOMGIyVXVWR2xqVkdGalZHOWxRMjl1ZEhKaFkzUXVkMmh2YzJWZmRIVnliaWdwSUMwK0lHSjVkR1Z6T2dwM2FHOXpaVjkwZFhKdU9nb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8wTlFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRGdvU0U5VFZDa2dhV1lnYzJWc1ppNTBkWEp1Y3lBbElESWdaV3h6WlNCaGNtTTBMbFZKYm5RNEtFTklRVXhNUlU1SFJWSXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRIVnlibk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRIVnlibk1nWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ0pRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXlDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NTBhV04wWVdOMGIyVXVkR2xqZEdGamRHOWxMbFJwWTFSaFkxUnZaVU52Ym5SeVlXTjBMbkJzWVhrb2JXOTJaUzR3T2lCMWFXNTBOalFzSUcxdmRtVXVNVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3B3YkdGNU9nb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8wTnkwME9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2NHeGhlU2h6Wld4bUxDQnRiM1psT2lCTmIzWmxLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVkMmx1Ym1WeUxDQWlSMkZ0WlNCcGN5QmhiSEpsWVdSNUlHWnBibWx6YUdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5kcGJtNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJIWVcxbElHbHpJR0ZzY21WaFpIa2dabWx1YVhOb1pXUUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRBS0lDQWdJQzh2SUdsbUlITmxiR1l1ZEhWeWJuTWdKU0F5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblIxY201eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblIxY201eklHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQ1VLSUNBZ0lHSjZJSEJzWVhsZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRFS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YUc5emRDd2dJa2wwSUdseklIUm9aU0JvYjNOMEozTWdkSFZ5YmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSm9iM04wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtaHZjM1FnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsMElHbHpJSFJvWlNCb2IzTjBKM01nZEhWeWJnb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8xTWdvZ0lDQWdMeThnY0d4aGVXVnlJRDBnWVhKak5DNVZTVzUwT0NoSVQxTlVLUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF4Q2dwd2JHRjVYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRnS0lDQWdJQzh2SUhObGJHWXViV0ZyWlY5dGIzWmxLSEJzWVhsbGNpd2diVzkyWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlHMWhhMlZmYlc5MlpRb2dJQ0FnY21WMGMzVmlDZ3B3YkdGNVgyVnNjMlZmWW05a2VVQXlPZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1amFHRnNiR1Z1WjJWeUxtZGxkQ2dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRVS0lDQWdJQzh2SUdSbFptRjFiSFE5UVdOamIzVnVkQ2dwQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WTJoaGJHeGxibWRsY2k1blpYUW9DaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyaGhiR3hsYm1kbGNpSUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TlRRdE5UWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVkyaGhiR3hsYm1kbGNpNW5aWFFvQ2lBZ0lDQXZMeUFnSUNBZ1pHVm1ZWFZzZEQxQlkyTnZkVzUwS0NrS0lDQWdJQzh2SUNrc0lDSkpkQ0JwY3lCMGFHVWdZMmhoYkd4bGJtZGxjaWR6SUhSMWNtNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjMlZzWldOMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWwwSUdseklIUm9aU0JqYUdGc2JHVnVaMlZ5SjNNZ2RIVnliZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvMU53b2dJQ0FnTHk4Z2NHeGhlV1Z5SUQwZ1lYSmpOQzVWU1c1ME9DaERTRUZNVEVWT1IwVlNLUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF5Q2lBZ0lDQmlJSEJzWVhsZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2dvS0x5OGdaWGhoYlhCc1pYTXVkR2xqZEdGamRHOWxMblJwWTNSaFkzUnZaUzVVYVdOVVlXTlViMlZEYjI1MGNtRmpkQzV0WVd0bFgyMXZkbVVvY0d4aGVXVnlPaUJpZVhSbGN5d2diVzkyWlM0d09pQjFhVzUwTmpRc0lHMXZkbVV1TVRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwdFlXdGxYMjF2ZG1VNkNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPall3TFRZeENpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRzFoYTJWZmJXOTJaU2h6Wld4bUxDQndiR0Y1WlhJNklHRnlZelF1VlVsdWREZ3NJRzF2ZG1VNklFMXZkbVVwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlEVUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TmpNS0lDQWdJQzh2SUdGemMyVnlkQ0JqYjJ4MWJXNGdQQ0F6SUdGdVpDQnliM2NnUENBekxDQWlUVzkyWlNCdGRYTjBJR0psSUdsdUlISmhibWRsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNd29nSUNBZ1BBb2dJQ0FnWkhWd0NpQWdJQ0JpZWlCdFlXdGxYMjF2ZG1WZlltOXZiRjltWVd4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNaUF2THlBekNpQWdJQ0E4Q2lBZ0lDQmllaUJ0WVd0bFgyMXZkbVZmWW05dmJGOW1ZV3h6WlVBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2JXRnJaVjl0YjNabFgySnZiMnhmYldWeVoyVkFORG9LSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk5qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCamIyeDFiVzRnUENBeklHRnVaQ0J5YjNjZ1BDQXpMQ0FpVFc5MlpTQnRkWE4wSUdKbElHbHVJSEpoYm1kbElnb2dJQ0FnWVhOelpYSjBJQzh2SUUxdmRtVWdiWFZ6ZENCaVpTQnBiaUJ5WVc1blpRb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8yTkFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVoyRnRaVnR5YjNkZFcyTnZiSFZ0YmwwZ1BUMGdSVTFRVkZrc0lDSlRjWFZoY21VZ2FYTWdZV3h5WldGa2VTQjBZV3RsYmlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puWVcxbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWRoYldVZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QXpDaUFnSUNBcUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnVTNGMVlYSmxJR2x6SUdGc2NtVmhaSGtnZEdGclpXNEtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TmpVS0lDQWdJQzh2SUhObGJHWXVaMkZ0WlZ0eWIzZGRXMk52YkhWdGJsMGdQU0J3YkdGNVpYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbllXMWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kaGJXVWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6SWdMeThnTXdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdZWE56WlhKMElDOHZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJRE1LSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0puWVcxbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TmpZS0lDQWdJQzh2SUhObGJHWXVkSFZ5Ym5NZ0t6MGdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUjFjbTV6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUjFjbTV6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SMWNtNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk56UUtJQ0FnSUM4dklHY2dQU0J6Wld4bUxtZGhiV1V1WTI5d2VTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVoyRnRaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVoyRnRaU0JsZUdsemRITUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TnpZS0lDQWdJQzh2SUdsbUlHZGJjbTkzWFZzd1hTQTlQU0JuVzNKdmQxMWJNVjBnUFQwZ1oxdHliM2RkV3pKZE9nb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURNS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREVnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURFZ01TQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJRzFoYTJWZmJXOTJaVjloWm5SbGNsOXBabDlsYkhObFFERXpDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURFZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1lqMDlDaUFnSUNCaWVpQnRZV3RsWDIxdmRtVmZZV1owWlhKZmFXWmZaV3h6WlVBeE13b2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8zTndvZ0lDQWdMeThnY21WMGRYSnVJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwdFlXdGxYMjF2ZG1WZllXWjBaWEpmYVc1c2FXNWxaRjlsZUdGdGNHeGxjeTUwYVdOMFlXTjBiMlV1ZEdsamRHRmpkRzlsTGxScFkxUmhZMVJ2WlVOdmJuUnlZV04wTG1ScFpGOTNhVzVBTWpVNkNpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalkzQ2lBZ0lDQXZMeUJwWmlCelpXeG1MbVJwWkY5M2FXNG9jR3hoZVdWeUxDQmpiMngxYlc0OVkyOXNkVzF1TENCeWIzYzljbTkzS1RvS0lDQWdJR0o2SUcxaGEyVmZiVzkyWlY5bGJITmxYMkp2WkhsQU5nb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG8yT0FvZ0lDQWdMeThnYzJWc1ppNTNhVzV1WlhJdWRtRnNkV1VnUFNCd2JHRjVaWElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbmRwYm01bGNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYTJWZmJXOTJaVjloWm5SbGNsOXBabDlsYkhObFFEazZDaUFnSUNCeVpYUnpkV0lLQ20xaGEyVmZiVzkyWlY5bGJITmxYMkp2WkhsQU5qb0tJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TmprS0lDQWdJQzh2SUdWc2FXWWdjMlZzWmk1MGRYSnVjeUE5UFNBNU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SMWNtNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SMWNtNXpJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0E1SUM4dklEa0tJQ0FnSUQwOUNpQWdJQ0JpZWlCdFlXdGxYMjF2ZG1WZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qY3dDaUFnSUNBdkx5QnpaV3htTG5kcGJtNWxjaTUyWVd4MVpTQTlJR0Z5WXpRdVZVbHVkRGdvUkZKQlZ5a0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luZHBibTVsY2lJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ3B0WVd0bFgyMXZkbVZmWVdaMFpYSmZhV1pmWld4elpVQXhNem9LSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk56a0tJQ0FnSUM4dklHbG1JR2RiTUYxYlkyOXNkVzF1WFNBOVBTQm5XekZkVzJOdmJIVnRibDBnUFQwZ1oxc3lYVnRqYjJ4MWJXNWRPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURNZ015QXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0ExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaVBUMEtJQ0FnSUdKNklHMWhhMlZmYlc5MlpWOWhablJsY2w5cFpsOWxiSE5sUURFMkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaWGgwY21GamRDQTJJRE1nTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpUFQwS0lDQWdJR0o2SUcxaGEyVmZiVzkyWlY5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2lBZ0lDQXZMeUIwYVdOMFlXTjBiMlV2ZEdsamRHRmpkRzlsTG5CNU9qZ3dDaUFnSUNBdkx5QnlaWFIxY200Z1ZISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUM4dklIUnBZM1JoWTNSdlpTOTBhV04wWVdOMGIyVXVjSGs2TmpjS0lDQWdJQzh2SUdsbUlITmxiR1l1Wkdsa1gzZHBiaWh3YkdGNVpYSXNJR052YkhWdGJqMWpiMngxYlc0c0lISnZkejF5YjNjcE9nb2dJQ0FnWWlCdFlXdGxYMjF2ZG1WZllXWjBaWEpmYVc1c2FXNWxaRjlsZUdGdGNHeGxjeTUwYVdOMFlXTjBiMlV1ZEdsamRHRmpkRzlsTGxScFkxUmhZMVJ2WlVOdmJuUnlZV04wTG1ScFpGOTNhVzVBTWpVS0NtMWhhMlZmYlc5MlpWOWhablJsY2w5cFpsOWxiSE5sUURFMk9nb2dJQ0FnTHk4Z2RHbGpkR0ZqZEc5bEwzUnBZM1JoWTNSdlpTNXdlVG80TWkwNE13b2dJQ0FnTHk4Z0l5QnBaaUJ3YkdGNVpYSWdiM2R1Y3lCalpXNTBaWElzSUdOb1pXTnJJR1JwWVdkdmJtRnNjd29nSUNBZ0x5OGdhV1lnY0d4aGVXVnlJRDA5SUdkYk1WMWJNVjA2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBeElERWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0k5UFFvZ0lDQWdZbm9nYldGclpWOXRiM1psWDJGbWRHVnlYMmxtWDJWc2MyVkFNalFLSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk9EUUtJQ0FnSUM4dklHbG1JR2RiTUYxYk1GMGdQVDBnY0d4aGVXVnlJRDA5SUdkYk1sMWJNbDA2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBd0lERWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0k5UFFvZ0lDQWdZbm9nYldGclpWOXRiM1psWDJGbWRHVnlYMmxtWDJWc2MyVkFNakFLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbGVIUnlZV04wSURZZ015QXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF4SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaVBUMEtJQ0FnSUdKNklHMWhhMlZmYlc5MlpWOWhablJsY2w5cFpsOWxiSE5sUURJd0NpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPamcxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDOHZJSFJwWTNSaFkzUnZaUzkwYVdOMFlXTjBiMlV1Y0hrNk5qY0tJQ0FnSUM4dklHbG1JSE5sYkdZdVpHbGtYM2RwYmlod2JHRjVaWElzSUdOdmJIVnRiajFqYjJ4MWJXNHNJSEp2ZHoxeWIzY3BPZ29nSUNBZ1lpQnRZV3RsWDIxdmRtVmZZV1owWlhKZmFXNXNhVzVsWkY5bGVHRnRjR3hsY3k1MGFXTjBZV04wYjJVdWRHbGpkR0ZqZEc5bExsUnBZMVJoWTFSdlpVTnZiblJ5WVdOMExtUnBaRjkzYVc1QU1qVUtDbTFoYTJWZmJXOTJaVjloWm5SbGNsOXBabDlsYkhObFFESXdPZ29nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvNE5nb2dJQ0FnTHk4Z2FXWWdaMXN3WFZzeVhTQTlQU0J3YkdGNVpYSWdQVDBnWjFzeVhWc3dYVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01TQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZajA5Q2lBZ0lDQmllaUJ0WVd0bFgyMXZkbVZmWVdaMFpYSmZhV1pmWld4elpVQXlOQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmlBeklDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaWGgwY21GamRDQXdJREVnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ2JXRnJaVjl0YjNabFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpRS0lDQWdJQzh2SUhScFkzUmhZM1J2WlM5MGFXTjBZV04wYjJVdWNIazZPRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQlVjblZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0x5OGdkR2xqZEdGamRHOWxMM1JwWTNSaFkzUnZaUzV3ZVRvMk53b2dJQ0FnTHk4Z2FXWWdjMlZzWmk1a2FXUmZkMmx1S0hCc1lYbGxjaXdnWTI5c2RXMXVQV052YkhWdGJpd2djbTkzUFhKdmR5azZDaUFnSUNCaUlHMWhhMlZmYlc5MlpWOWhablJsY2w5cGJteHBibVZrWDJWNFlXMXdiR1Z6TG5ScFkzUmhZM1J2WlM1MGFXTjBZV04wYjJVdVZHbGpWR0ZqVkc5bFEyOXVkSEpoWTNRdVpHbGtYM2RwYmtBeU5Rb0tiV0ZyWlY5dGIzWmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qUTZDaUFnSUNBdkx5QjBhV04wWVdOMGIyVXZkR2xqZEdGamRHOWxMbkI1T2pnNENpQWdJQ0F2THlCeVpYUjFjbTRnUm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCMGFXTjBZV04wYjJVdmRHbGpkR0ZqZEc5bExuQjVPalkzQ2lBZ0lDQXZMeUJwWmlCelpXeG1MbVJwWkY5M2FXNG9jR3hoZVdWeUxDQmpiMngxYlc0OVkyOXNkVzF1TENCeWIzYzljbTkzS1RvS0lDQWdJR0lnYldGclpWOXRiM1psWDJGbWRHVnlYMmx1YkdsdVpXUmZaWGhoYlhCc1pYTXVkR2xqZEdGamRHOWxMblJwWTNSaFkzUnZaUzVVYVdOVVlXTlViMlZEYjI1MGNtRmpkQzVrYVdSZmQybHVRREkxQ2dwdFlXdGxYMjF2ZG1WZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnJaVjl0YjNabFgySnZiMnhmYldWeVoyVkFOQW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUVEQ0NZSEJHZGhiV1VGZEhWeWJuTUtZMmhoYkd4bGJtZGxjZ1ozYVc1dVpYSUJBUUVDQkdodmMzUXhHMEVBSTRJRUJKYXBjWUVFRjZCNXN3UzdueEZIQko3cjlZNDJHZ0NPQkFCQkFDd0FGd0FDSWtNeEdSUkVNUmhFTmhvQlNTSmJUQ1ZiaUFEREkwTXhHUlJFTVJoRWlBQ29nQVFWSDN4MVRGQ3dJME14R1JSRU1SaEVOaG9CU1NKYlRDVmJpQUJ5STBNeEdSUkVOaG9CU1NKYlRDVmJpQUFDSTBPS0FnQ0FBREVZUVFBU0lpcGxSUUZCQUFZaUsyVkZBVVFxYVN0cEp3WXhBR2VCQ2E4b1RHZUwvaVFNU1l3QVFRQXBpLzhrREVFQUlpTkVJaWhsUkl2L0pBdEtKRmlMQUVTTC9pY0VYWXYvSkF4RVhTaE1aeWtpWjRraVF2L2JpZ0lBSWlwbFJRRVVSQ294QUdjbkJZditpLytJQUVhSklpbGxSSUVDR0NjRkp3UlBBazJKaWdJQUlpdGxSUUVVUkNJcFpVU0JBaGhCQUJNeEFDSW5CbVZFRWtRbkJJditpLytJQUJDSk1RQXlBeUlxWlUwU1JDY0ZRdi9waWdNQUlrY0ZpLzRrREVsQkFRT0wveVFNUVFEOEkwUWlLR1ZFaS84a0MweExBU1JZaS80aldJQUJBS2hFSWlobFJFbExBaVJZaXdaRWkvNkwvVjJML3lRTVJFc0NURjBvVEdjaUtXVkVJd2dwVEdjaUtHVk1TVTRDakFKRVRDUllTWXdEU1ZjQUFVeFhBUUZKakFDb1FRQWtpd05YQWdHTEFLaEJBQmtqUVFBRks0djlaNGtpS1dWRWdRa1NRZi8xSzRBQkEyZUppd0pKVndBRFNZd0VpLzRqV0V4WEF3TkpqQVdML2lOWVNZd0JxRUVBRTRzQ1Z3WURpLzRqV0lzQnFFRUFCQ05DLzdhTEJWY0JBWXY5cUVFQU9vc0VWd0FCaS8yb1FRQVNpd0pYQmdOWEFnR0wvYWhCQUFRalF2K09pd1JYQWdHTC9haEJBQktMQWxjR0ExY0FBWXY5cUVFQUJDTkMvM0VpUXY5dElrTC9BUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
