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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_38943258
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class FReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
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

                public static FReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FReturn);
                }
                public bool Equals(FReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FReturn left, FReturn right)
                {
                    return EqualityComparer<FReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(FReturn left, FReturn right)
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
        public async Task<Structs.FReturn> F(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 75, 56, 199 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> F_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 75, 56, 199 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> X(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 16, 114, 175 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> X_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 16, 114, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Y(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 94, 59, 188 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Y_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 94, 59, 188 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJGUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50MjU2In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Il9fcG9zdEluaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiRlJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IngiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NDRdLCJlcnJvck1lc3NhZ2UiOiJfX3Bvc3RJbml0IGFscmVhZHkgY2FsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB4IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1LDIyMCwyNTZdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NCwyMzAsMzk0LDQxMCw0MjNdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YVcxdGRYUmhZbXhsTDIxMWJIUnBYMk55WldGMGFXOXVMbk52YkM1RExtRndjSEp2ZG1Gc1gzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRFlnTVRBd01EQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlR05rTnpoaU16VTBJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SWdJbmtpSURCNE1UVXhaamRqTnpVZ0luZ2lJQ0poSWlCVVRWQk1YMEZRVUZKUFZrRk1YMEVnVkUxUVRGOURURVZCVWw5QklGUk5VRXhmUVZCUVVrOVdRVXhmUWlCVVRWQk1YME5NUlVGU1gwSUtJQ0FnSUhCMWMyaHBiblFnTkRBNU5nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnYzNSdmNtVWdOUW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdiRzloWkNBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURnd0NpQWdJQ0J5WlhCc1lXTmxNaUEyTkFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WW1Gall6UTVaVE1nTUhoaU16UmlNemhqTnlBd2VEZGpNVEEzTW1GbUlEQjROV00xWlROaVltTWdMeThnYldWMGFHOWtJQ0pmWDNCdmMzUkpibWwwS0NsMmIybGtJaXdnYldWMGFHOWtJQ0ptS0Nrb2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwSWl3Z2JXVjBhRzlrSUNKNEtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSjVLQ2wxYVc1ME1qVTJJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWZYM0J2YzNSSmJtbDBYM0p2ZFhSbFFEVWdiV0ZwYmw5bVgzSnZkWFJsUURZZ2JXRnBibDk0WDNKdmRYUmxRRGNnYldGcGJsOTVYM0p2ZFhSbFFEZ0tJQ0FnSUdWeWNnb0tiV0ZwYmw5NVgzSnZkWFJsUURnNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTFPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZVNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRVS0NtMWhhVzVmZUY5eWIzVjBaVUEzT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbmdpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSGdnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREU1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREl3Q2dwdFlXbHVYMlpmY205MWRHVkFOam9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpVNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdKNWRHVmpJRFlnTHk4Z1ZFMVFURjlCVUZCU1QxWkJURjlCQ2lBZ0lDQmllWFJsWXlBM0lDOHZJRlJOVUV4ZlEweEZRVkpmUVFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUjJ4dlltRnNUblZ0VldsdWRBb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JIYkc5aVlXeE9kVzFDZVhSbFUyeHBZMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVWNGRISmhVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnY0c5d0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QnRaWFJvYjJRZ0ltWW9LWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdKNWRHVmpJRGdnTHk4Z1ZFMVFURjlCVUZCU1QxWkJURjlDQ2lBZ0lDQmllWFJsWXlBNUlDOHZJRlJOVUV4ZlEweEZRVkpmUWdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUjJ4dlltRnNUblZ0VldsdWRBb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JIYkc5aVlXeE9kVzFDZVhSbFUyeHBZMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVWNGRISmhVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjSEp2ZG1Gc1VISnZaM0poYlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnY0c5d0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QnRaWFJvYjJRZ0ltWW9LWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmhJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZbndLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpVS0NtMWhhVzVmWDE5d2IzTjBTVzVwZEY5eWIzVjBaVUExT2dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklGOWZjRzl6ZEVsdWFYUWdZV3h5WldGa2VTQmpZV3hzWldRS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTkNBdkx5QWllQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbmtpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWW5sMFpXTWdOaUF2THlCVVRWQk1YMEZRVUZKUFZrRk1YMEVLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdWRTFRVEY5RFRFVkJVbDlCQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JIYkc5aVlXeE9kVzFWYVc1MENpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRWRzYjJKaGJFNTFiVUo1ZEdWVGJHbGpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUlhoMGNtRlFjbTluY21GdFVHRm5aWE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0J3YjNBS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklHMWxkR2h2WkNBaVppZ3BkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWVDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUZSTlVFeGZRVkJRVWs5V1FVeGZRZ29nSUNBZ1lubDBaV01nT1NBdkx5QlVUVkJNWDBOTVJVRlNYMElLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRWRzYjJKaGJFNTFiVlZwYm5RS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSMnh2WW1Gc1RuVnRRbmwwWlZOc2FXTmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JGZUhSeVlWQnliMmR5WVcxUVlXZGxjd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiR1ZoY2xOMFlYUmxVSEp2WjNKaGJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnliM1poYkZCeWIyZHlZVzBLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRU55WldGMFpXUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmtkWEFLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJSEJ2Y0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FXNTBZeUEwSUM4dklERXdNREF3TURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z2JXVjBhRzlrSUNKbUtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKNUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdmFXMXRkWFJoWW14bEwyMTFiSFJwWDJOeVpXRjBhVzl1TG5OdmJDNURMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRkFBRWdCc0NFUFNZS0JNMTRzMVFPWDE5amRHOXlYM0JsYm1ScGJtY0JlUVFWSDN4MUFYZ0JZUVlDS09LbEF4d0dBaWppcFFNY0JnSW80cVVESEFZQ0tPS2xBeHlCZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBQVVwSTJjalF6RVpGRVF4R0VTQ0JBUzZ6RW5qQkxOTE9NY0VmQkJ5cndSY1hqdThOaG9BamdRQkRnQklBQ1FBQVFBeEZrRUFHakVXSXdrNENCUkVJaXBsUkVrVkpBNUVKSytySzB4UXNDTkRJa0wvNkRFV1FRQWJNUllqQ1RnSUZFUWlKd1JsUkVrVkpBNUVKSytySzB4UXNDTkRJa0wvNXpFV1FRQzlNUllqQ1RnSUZFU3hKd1luQnlXeUVJRVFzalNCRUxJMUlySUJnUU95T0xJZnNoNnp0RDFKY2doSXNTT3lFTElISXJJQklRU3lDTE94SmJJUUlySVpJcklCc2hnb3NocXpzU2NJSndrbHNoQ0JFTEkwZ1JDeU5TS3lBWUVEc2ppeUg3SWVzN1E5U1hJSVNMRWpzaEN5QnlLeUFTRUVzZ2l6c1NXeUVDS3lHU0t5QWJJWUtMSWFzeUluQldWRVNSVWtEa1FrcjB4TEFhdTBQbGNFQUVrVkpBNUVTd0tydEQ1WEJBQkpGU1FPUkU4RHEwNENVRXhRSzB4UXNDTkRJa0wvUlNsa1JDa2laeWNGZ0FCbkp3U0FBR2NxZ0FCbmdRTVdKd1ZNWjdFbkJpY0hKYklRZ1JDeU5JRVFzalVpc2dHQkE3STRzaCt5SHJPMFBVbHlDRWl4STdJUXNnY2lzZ0VoQkxJSXM3RWxzaEFpc2hraXNnR3lHQ2l5R3JPMFBsY0VBQ2NFVEdleEp3Z25DU1d5RUlFUXNqU0JFTEkxSXJJQmdRT3lPTElmc2g2enREMUpjZ2hJc1NPeUVMSUhJcklCSVFTeUNMT3hKYklRSXJJWklySUJzaGdvc2hxenRENVhCQUFxVEdjalF3PT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJBUFBST1ZBTF9BIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjoiQWlqaXBRTWMifSwiQ0xFQVJfQSI6eyJ0eXBlIjoiQVZNQnl0ZXMiLCJ2YWx1ZSI6IkFpamlwUU1jIn0sIkFQUFJPVkFMX0IiOnsidHlwZSI6IkFWTUJ5dGVzIiwidmFsdWUiOiJBaWppcFFNYyJ9LCJDTEVBUl9CIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjoiQWlqaXBRTWMifX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
