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

namespace Arc56.Generated.AnmayG.datachat.HandshakeApp_2fd9d395
{


    //
    // 
    //    Boxes (per user):
    //      - b"c:" + addr -> DynamicArray[Address]
    //      - b"p:" + addr -> Pending
    //    
    //
    public class HandshakeAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HandshakeAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Pending : AVMObjectType
            {
                public Algorand.Address Other { get; set; }

                public byte[] LocHash { get; set; }

                public ulong Ts { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOther = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOther.From(Other);
                    ret.AddRange(vOther.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vLocHash.From(LocHash);
                    ret.AddRange(vLocHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTs.From(Ts);
                    ret.AddRange(vTs.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Pending Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Pending();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOther = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOther.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOther = vOther.ToValue();
                    if (valueOther is Algorand.Address vOtherValue) { ret.Other = vOtherValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vLocHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocHash = vLocHash.ToValue();
                    if (valueLocHash is byte[] vLocHashValue) { ret.LocHash = vLocHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTs = vTs.ToValue();
                    if (valueTs is ulong vTsValue) { ret.Ts = vTsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Pending);
                }
                public bool Equals(Pending? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Pending left, Pending right)
                {
                    return EqualityComparer<Pending>.Default.Equals(left, right);
                }
                public static bool operator !=(Pending left, Pending right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="other"> </param>
        /// <param name="loc_hash"> </param>
        public async Task<bool> RequestHandshake(Algorand.Address other, byte[] loc_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 108, 49, 222 };
            var otherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); otherAbi.From(other);
            var loc_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); loc_hashAbi.From(loc_hash);

            var result = await base.CallApp(new List<object> { abiHandle, otherAbi, loc_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RequestHandshake_Transactions(Algorand.Address other, byte[] loc_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 108, 49, 222 };
            var otherAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); otherAbi.From(other);
            var loc_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); loc_hashAbi.From(loc_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, otherAbi, loc_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address[]> GetMyConnections(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 62, 9, 84 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> GetMyConnections_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 62, 9, 84 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSGFuZHNoYWtlQXBwIiwiZGVzYyI6IlxuICAgIEJveGVzIChwZXIgdXNlcik6XG4gICAgICAtIGJcImM6XCIgKyBhZGRyIC0+IER5bmFtaWNBcnJheVtBZGRyZXNzXVxuICAgICAgLSBiXCJwOlwiICsgYWRkciAtPiBQZW5kaW5nXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlBlbmRpbmciOlt7Im5hbWUiOiJvdGhlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibG9jX2hhc2giLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoidHMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InJlcXVlc3RfaGFuZHNoYWtlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvdGhlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9jX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X215X2Nvbm5lY3Rpb25zIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMzIsMjEyXSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1Myw2OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2LDcyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NV0sImVycm9yTWVzc2FnZSI6ImNhbm5vdCBoYW5kc2hha2Ugd2l0aCBzZWxmIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0LDI5Myw0NjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNvbm5lY3Rpb25zIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGVuZGluZyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFHRnVaSE5vWVd0bExtTnZiblJ5WVdOMExraGhibVJ6YUdGclpVRndjQzVmWDJGc1oyOXdlVjlsYm5SeWVYQnZhVzUwWDNkcGRHaGZhVzVwZENncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZzJNek5oSURCNE1EQXdNQ0F3ZURFMU1XWTNZemMxSURCNE56QXpZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG94TWdvZ0lDQWdMeThnWTJ4aGMzTWdTR0Z1WkhOb1lXdGxRWEJ3S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFOd29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFprTm1Nek1XUmxJREI0WWpRelpUQTVOVFFnTHk4Z2JXVjBhRzlrSUNKeVpYRjFaWE4wWDJoaGJtUnphR0ZyWlNoaFpHUnlaWE56TEdKNWRHVmJYU2xpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJmYlhsZlkyOXVibVZqZEdsdmJuTW9LV0ZrWkhKbGMzTmJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZjbVZ4ZFdWemRGOW9ZVzVrYzJoaGEyVmZjbTkxZEdWQU5TQnRZV2x1WDJkbGRGOXRlVjlqYjI1dVpXTjBhVzl1YzE5eWIzVjBaVUEyQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZNVElLSUNBZ0lDOHZJR05zWVhOeklFaGhibVJ6YUdGclpVRndjQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZiWGxmWTI5dWJtVmpkR2x2Ym5OZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOXRlVjlqYjI1dVpXTjBhVzl1Y3dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WlhGMVpYTjBYMmhoYm1SemFHRnJaVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG96Tnkwek9Bb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTQnRaWFJvYjJSeklDMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUb3hNZ29nSUNBZ0x5OGdZMnhoYzNNZ1NHRnVaSE5vWVd0bFFYQndLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qTTNMVE00Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0SUcxbGRHaHZaSE1nTFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnlaWEYxWlhOMFgyaGhibVJ6YUdGclpRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZNVElLSUNBZ0lDOHZJR05zWVhOeklFaGhibVJ6YUdGclpVRndjQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1b1lXNWtjMmhoYTJVdVkyOXVkSEpoWTNRdVNHRnVaSE5vWVd0bFFYQndMbDlqYjI1MFlXbHVjeWhoY25JNklHSjVkR1Z6TENCM2FHODZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUXNJR0o1ZEdWek9ncGZZMjl1ZEdGcGJuTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPakl5TFRJMENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdElHaGxiSEJsY25NZ0xTMHRMUzB0TFMwS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYMk52Ym5SaGFXNXpLSE5sYkdZc0lHRnljam9nUkhsdVlXMXBZMEZ5Y21GNVcwRmtaSEpsYzNOZExDQjNhRzg2SUVGa1pISmxjM01wSUMwK0lHSnZiMnc2Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZNalVLSUNBZ0lDOHZJR2tnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pJMkNpQWdJQ0F2THlCdUlEMGdZWEp5TG14bGJtZDBhQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtDbDlqYjI1MFlXbHVjMTkzYUdsc1pWOTBiM0JBTVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk1qY0tJQ0FnSUM4dklIZG9hV3hsSUdrZ1BDQnVPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0E4Q2lBZ0lDQmllaUJmWTI5dWRHRnBibk5mWVdaMFpYSmZkMmhwYkdWQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUb3lPQW9nSUNBZ0x5OGdhV1lnWVhKeVcybGRJRDA5SUhkb2J6b0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JpZWlCZlkyOXVkR0ZwYm5OZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCeVpYUjFjbTRnVkhKMVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEpsZEhOMVlnb0tYMk52Ym5SaGFXNXpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR2tnUFNCcElDc2dWVWx1ZERZMEtERXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQmZZMjl1ZEdGcGJuTmZkMmhwYkdWZmRHOXdRREVLQ2w5amIyNTBZV2x1YzE5aFpuUmxjbDkzYUdsc1pVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnY21WMGRYSnVJRVpoYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWhoYm1SemFHRnJaUzVqYjI1MGNtRmpkQzVJWVc1a2MyaGhhMlZCY0hBdWNtVnhkV1Z6ZEY5b1lXNWtjMmhoYTJVb2IzUm9aWEk2SUdKNWRHVnpMQ0JzYjJOZmFHRnphRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LY21WeGRXVnpkRjlvWVc1a2MyaGhhMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pNM0xUTTVDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRJRzFsZEdodlpITWdMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhKbGNYVmxjM1JmYUdGdVpITm9ZV3RsS0hObGJHWXNJRzkwYUdWeU9pQkJaR1J5WlhOekxDQnNiMk5mYUdGemFEb2dSSGx1WVcxcFkwSjVkR1Z6S1NBdFBpQmliMjlzT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPalF3TFRReENpQWdJQ0F2THlBaklHUnBjMkZzYkc5M0lITmxiR1l0YUdGdVpITm9ZV3RsQ2lBZ0lDQXZMeUJoYzNObGNuUWdiM1JvWlhJdVlubDBaWE1nSVQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3Z0ltTmhibTV2ZENCb1lXNWtjMmhoYTJVZ2QybDBhQ0J6Wld4bUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhibTV2ZENCb1lXNWtjMmhoYTJVZ2QybDBhQ0J6Wld4bUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qUXpDaUFnSUNBdkx5QnRaVjlyWlhrZ1BTQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCdWIzY2dQU0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQWdJeUJoYkdkdmNIa3VWVWx1ZERZMENpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklHeHZaeWdpYm05M0lpd2dibTkzS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbTV2ZHlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qUTRMVFE1Q2lBZ0lDQXZMeUFqSUVsbUlIUm9aU0J2ZEdobGNpQjFjMlZ5SUdoaGN5QmhJSEJsYm1ScGJtY2djbVZ4ZFdWemRDQmhhVzFsWkNCaGRDQnRaU3dnZEhKNUlIUnZJR052YlhCc1pYUmxMZ29nSUNBZ0x5OGdhV1lnYjNSb1pYSmZhMlY1SUdsdUlITmxiR1l1Y0dWdVpHbHVaem9LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGczTUROaENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJSEpsY1hWbGMzUmZhR0Z1WkhOb1lXdGxYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJSEJsYm1RZ1BTQnpaV3htTG5CbGJtUnBibWRiYjNSb1pYSmZhMlY1WFM1amIzQjVLQ2tnSUNNZ1kyOXdlU0IzYUdWdUlIUmhhMmx1WnlCMGJ5QnNiMk5oYkFvZ0lDQWdabkpoYldWZlpHbG5JREV4Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ053b2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHVnVaR2x1WnlCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR2xtSUhCbGJtUXViM1JvWlhJZ1BUMGdRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0JoYm1RZ2NHVnVaQzVzYjJOZmFHRnphQzVpZVhSbGN5QTlQU0JzYjJOZmFHRnphQzVpZVhSbGN6b0tJQ0FnSUdWNGRISmhZM1FnTUNBek1pQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaWEYxWlhOMFgyaGhibVJ6YUdGclpWOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JpZWlCeVpYRjFaWE4wWDJoaGJtUnphR0ZyWlY5aFpuUmxjbDlwWmw5bGJITmxRREUzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pVeUNpQWdJQ0F2THlCcFppQnpaV3htTGw5aFluTmZaR2xtWmlodWIzY3NJSEJsYm1RdWRITXVibUYwYVhabEtTQThQU0JWU1c1ME5qUW9TRUZPUkZOSVFVdEZYMWRKVGtSUFYxOVRSVU5US1RvS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQndkWE5vYVc1MElETTBJQzh2SURNMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QnlaWFIxY200Z1lTQXRJR0lnYVdZZ1lTQStQU0JpSUdWc2MyVWdZaUF0SUdFS0lDQWdJR1p5WVcxbFgyUnBaeUE1Q2lBZ0lDQThQUW9nSUNBZ1lub2djbVZ4ZFdWemRGOW9ZVzVrYzJoaGEyVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1Bb2dJQ0FnWm5KaGJXVmZaR2xuSURrS0lDQWdJSE4zWVhBS0lDQWdJQzBLQ25KbGNYVmxjM1JmYUdGdVpITm9ZV3RsWDNSbGNtNWhjbmxmYldWeVoyVkFNakU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pVeUNpQWdJQ0F2THlCcFppQnpaV3htTGw5aFluTmZaR2xtWmlodWIzY3NJSEJsYm1RdWRITXVibUYwYVhabEtTQThQU0JWU1c1ME5qUW9TRUZPUkZOSVFVdEZYMWRKVGtSUFYxOVRSVU5US1RvS0lDQWdJSEIxYzJocGJuUWdOakFnTHk4Z05qQUtJQ0FnSUR3OUNpQWdJQ0JpZWlCeVpYRjFaWE4wWDJoaGJtUnphR0ZyWlY5aFpuUmxjbDlwWmw5bGJITmxRREUzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCcFppQnRaVjlyWlhrZ2FXNGdjMlZzWmk1amIyNXVaV04wYVc5dWN5QmxiSE5sSUVSNWJtRnRhV05CY25KaGVWdEJaR1J5WlhOelhTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROak16WVFvZ0lDQWdabkpoYldWZlpHbG5JRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzFOQzAxTlFvZ0lDQWdMeThnYzJWc1ppNWpiMjV1WldOMGFXOXVjMXR0WlY5clpYbGRMbU52Y0hrb0tRb2dJQ0FnTHk4Z2FXWWdiV1ZmYTJWNUlHbHVJSE5sYkdZdVkyOXVibVZqZEdsdmJuTWdaV3h6WlNCRWVXNWhiV2xqUVhKeVlYbGJRV1JrY21WemMxMG9LUW9nSUNBZ1lub2djbVZ4ZFdWemRGOW9ZVzVrYzJoaGEyVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QnpaV3htTG1OdmJtNWxZM1JwYjI1elcyMWxYMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dWJtVmpkR2x2Ym5NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbkpsY1hWbGMzUmZhR0Z1WkhOb1lXdGxYM1JsY201aGNubGZiV1Z5WjJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5b1lXNWtjMmhoYTJVdlkyOXVkSEpoWTNRdWNIazZOVGtLSUNBZ0lDOHZJR2xtSUc5MGFHVnlYMnRsZVNCcGJpQnpaV3htTG1OdmJtNWxZM1JwYjI1eklHVnNjMlVnUkhsdVlXMXBZMEZ5Y21GNVcwRmtaSEpsYzNOZEtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNek5oQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUbzFPQzAxT1FvZ0lDQWdMeThnYzJWc1ppNWpiMjV1WldOMGFXOXVjMXR2ZEdobGNsOXJaWGxkTG1OdmNIa29LUW9nSUNBZ0x5OGdhV1lnYjNSb1pYSmZhMlY1SUdsdUlITmxiR1l1WTI5dWJtVmpkR2x2Ym5NZ1pXeHpaU0JFZVc1aGJXbGpRWEp5WVhsYlFXUmtjbVZ6YzEwb0tRb2dJQ0FnWW5vZ2NtVnhkV1Z6ZEY5b1lXNWtjMmhoYTJWZmRHVnlibUZ5ZVY5bVlXeHpaVUE1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCelpXeG1MbU52Ym01bFkzUnBiMjV6VzI5MGFHVnlYMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dWJtVmpkR2x2Ym5NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlpZFhKNUlEVUtDbkpsY1hWbGMzUmZhR0Z1WkhOb1lXdGxYM1JsY201aGNubGZiV1Z5WjJWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJwWmlCdWIzUWdjMlZzWmk1ZlkyOXVkR0ZwYm5Nb2JXVmZiR2x6ZEN3Z2IzUm9aWElwT2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCZlkyOXVkR0ZwYm5NS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJR0p1ZWlCeVpYRjFaWE4wWDJoaGJtUnphR0ZyWlY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCdFpWOXNhWE4wTG1Gd2NHVnVaQ2h2ZEdobGNpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb0tjbVZ4ZFdWemRGOW9ZVzVrYzJoaGEyVmZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklHMWxYMkZrWkhJZ1BTQkJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z2FXWWdibTkwSUhObGJHWXVYMk52Ym5SaGFXNXpLRzkwYUdWeVgyeHBjM1FzSUcxbFgyRmtaSElwT2dvZ0lDQWdabkpoYldWZlpHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gyTnZiblJoYVc1ekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMkNpQWdJQ0JpYm5vZ2NtVnhkV1Z6ZEY5b1lXNWtjMmhoYTJWZllXWjBaWEpmYVdaZlpXeHpaVUF4TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvMk5nb2dJQ0FnTHk4Z2IzUm9aWEpmYkdsemRDNWhjSEJsYm1Rb2JXVmZZV1JrY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnTHdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0EyQ2dweVpYRjFaWE4wWDJoaGJtUnphR0ZyWlY5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TmpndE5qa0tJQ0FnSUM4dklDTWdkM0pwZEdVZ1ltRmpheUJqYjNCcFpYTUtJQ0FnSUM4dklITmxiR1l1WTI5dWJtVmpkR2x2Ym5OYmJXVmZhMlY1WFNBOUlHMWxYMnhwYzNRdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCelpXeG1MbU52Ym01bFkzUnBiMjV6VzI5MGFHVnlYMnRsZVYwZ1BTQnZkR2hsY2w5c2FYTjBMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFHRnVaSE5vWVd0bEwyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTV3Wlc1a2FXNW5XMjkwYUdWeVgydGxlVjBLSUNBZ0lHWnlZVzFsWDJScFp5QXhNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCeVpYUjFjbTRnVkhKMVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncHlaWEYxWlhOMFgyaGhibVJ6YUdGclpWOTBaWEp1WVhKNVgyWmhiSE5sUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QnBaaUJ2ZEdobGNsOXJaWGtnYVc0Z2MyVnNaaTVqYjI1dVpXTjBhVzl1Y3lCbGJITmxJRVI1Ym1GdGFXTkJjbkpoZVZ0QlpHUnlaWE56WFNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTFDaUFnSUNCaUlISmxjWFZsYzNSZmFHRnVaSE5vWVd0bFgzUmxjbTVoY25sZmJXVnlaMlZBTVRBS0NuSmxjWFZsYzNSZmFHRnVaSE5vWVd0bFgzUmxjbTVoY25sZlptRnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHbG1JRzFsWDJ0bGVTQnBiaUJ6Wld4bUxtTnZibTVsWTNScGIyNXpJR1ZzYzJVZ1JIbHVZVzFwWTBGeWNtRjVXMEZrWkhKbGMzTmRLQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR0lnY21WeGRXVnpkRjlvWVc1a2MyaGhhMlZmZEdWeWJtRnllVjl0WlhKblpVQTNDZ3B5WlhGMVpYTjBYMmhoYm1SemFHRnJaVjloWm5SbGNsOXBabDlsYkhObFFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG8zTlMwNE1Bb2dJQ0FnTHk4Z0l5QlBkR2hsY25kcGMyVXNJQ2h5WlNseVpXTnZjbVFnYlhrZ2NHVnVaR2x1WnlCeVpYRjFaWE4wSUNoamIzQjVJRzExZEdGaWJHVWdZWEpuS1FvZ0lDQWdMeThnYzJWc1ppNXdaVzVrYVc1blcyMWxYMnRsZVYwZ1BTQlFaVzVrYVc1bktBb2dJQ0FnTHk4Z0lDQWdJRzkwYUdWeVBXOTBhR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHeHZZMTlvWVhOb1BXeHZZMTlvWVhOb0xtTnZjSGtvS1N3S0lDQWdJQzh2SUNBZ0lDQjBjejFCVlVsdWREWTBLRzV2ZHlrS0lDQWdJQzh2SUNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeVlRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2TnpVdE56WUtJQ0FnSUM4dklDTWdUM1JvWlhKM2FYTmxMQ0FvY21VcGNtVmpiM0prSUcxNUlIQmxibVJwYm1jZ2NtVnhkV1Z6ZENBb1kyOXdlU0J0ZFhSaFlteGxJR0Z5WnlrS0lDQWdJQzh2SUhObGJHWXVjR1Z1WkdsdVoxdHRaVjlyWlhsZElEMGdVR1Z1WkdsdVp5Z0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzNNRE5oQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pjMUxUZ3dDaUFnSUNBdkx5QWpJRTkwYUdWeWQybHpaU3dnS0hKbEtYSmxZMjl5WkNCdGVTQndaVzVrYVc1bklISmxjWFZsYzNRZ0tHTnZjSGtnYlhWMFlXSnNaU0JoY21jcENpQWdJQ0F2THlCelpXeG1MbkJsYm1ScGJtZGJiV1ZmYTJWNVhTQTlJRkJsYm1ScGJtY29DaUFnSUNBdkx5QWdJQ0FnYjNSb1pYSTliM1JvWlhJc0NpQWdJQ0F2THlBZ0lDQWdiRzlqWDJoaGMyZzliRzlqWDJoaGMyZ3VZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJSFJ6UFVGVlNXNTBOalFvYm05M0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUhKbGRIVnliaUJHWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncHlaWEYxWlhOMFgyaGhibVJ6YUdGclpWOTBaWEp1WVhKNVgyWmhiSE5sUURJd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJoaGJtUnphR0ZyWlM5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRWdMU0JpSUdsbUlHRWdQajBnWWlCbGJITmxJR0lnTFNCaENpQWdJQ0JtY21GdFpWOWthV2NnT1FvZ0lDQWdMUW9nSUNBZ1lpQnlaWEYxWlhOMFgyaGhibVJ6YUdGclpWOTBaWEp1WVhKNVgyMWxjbWRsUURJeENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWhoYm1SemFHRnJaUzVqYjI1MGNtRmpkQzVJWVc1a2MyaGhhMlZCY0hBdVoyVjBYMjE1WDJOdmJtNWxZM1JwYjI1ektDa2dMVDRnWW5sMFpYTTZDbWRsZEY5dGVWOWpiMjV1WldOMGFXOXVjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW9ZVzVrYzJoaGEyVXZZMjl1ZEhKaFkzUXVjSGs2T0RNdE9EUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdkbGRGOXRlVjlqYjI1dVpXTjBhVzl1Y3loelpXeG1LU0F0UGlCRWVXNWhiV2xqUVhKeVlYbGJRV1JrY21WemMxMDZDaUFnSUNCd2NtOTBieUF3SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlvWVc1a2MyaGhhMlV2WTI5dWRISmhZM1F1Y0hrNk9EZ0tJQ0FnSUM4dklHbG1JRzFsWDJ0bGVTQnBiaUJ6Wld4bUxtTnZibTVsWTNScGIyNXpJR1ZzYzJVZ1JIbHVZVzFwWTBGeWNtRjVXMEZrWkhKbGMzTmRLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTXpOaENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QnRaVjlyWlhrZ1BTQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhR0Z1WkhOb1lXdGxMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCcFppQnRaVjlyWlhrZ2FXNGdjMlZzWmk1amIyNXVaV04wYVc5dWN5QmxiSE5sSUVSNWJtRnRhV05CY25KaGVWdEJaR1J5WlhOelhTZ3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qZzNMVGc0Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZibTVsWTNScGIyNXpXMjFsWDJ0bGVWMHVZMjl3ZVNncENpQWdJQ0F2THlCcFppQnRaVjlyWlhrZ2FXNGdjMlZzWmk1amIyNXVaV04wYVc5dWN5QmxiSE5sSUVSNWJtRnRhV05CY25KaGVWdEJaR1J5WlhOelhTZ3BDaUFnSUNCaWVpQm5aWFJmYlhsZlkyOXVibVZqZEdsdmJuTmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YUdGdVpITm9ZV3RsTDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QnpaV3htTG1OdmJtNWxZM1JwYjI1elcyMWxYMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dWJtVmpkR2x2Ym5NZ1pXNTBjbmtnWlhocGMzUnpDZ3BuWlhSZmJYbGZZMjl1Ym1WamRHbHZibk5mZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyaGhibVJ6YUdGclpTOWpiMjUwY21GamRDNXdlVG80TmkwNE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTG1OdmJtNWxZM1JwYjI1elcyMWxYMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUFnSUNBZ2FXWWdiV1ZmYTJWNUlHbHVJSE5sYkdZdVkyOXVibVZqZEdsdmJuTWdaV3h6WlNCRWVXNWhiV2xqUVhKeVlYbGJRV1JrY21WemMxMG9LUW9nSUNBZ0x5OGdLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwblpYUmZiWGxmWTI5dWJtVmpkR2x2Ym5OZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmhoYm1SemFHRnJaUzlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z2FXWWdiV1ZmYTJWNUlHbHVJSE5sYkdZdVkyOXVibVZqZEdsdmJuTWdaV3h6WlNCRWVXNWhiV2xqUVhKeVlYbGJRV1JrY21WemMxMG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBS0lDQWdJR0lnWjJWMFgyMTVYMk52Ym01bFkzUnBiMjV6WDNSbGNtNWhjbmxmYldWeVoyVkFNd289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUVnSmdRQ1l6b0NBQUFFRlI5OGRRSndPakViUVFCRWdnSUViV3d4M2dTMFBnbFVOaG9BamdJQUVnQUNJa014R1JSRU1SaEVpQUdGS2t4UXNDTkRNUmtVUkRFWVJEWWFBVFlhQW9nQVVvQUJBQ0pQQWxRcVRGQ3dJME14R1VEL3pERVlGRVFqUTRvQ0FpS0wvaUpaaXdDTEFReEJBQ0tML2xjQ0FJc0FKQXNrV0l2L0VrRUFDQ09ML2s4RFR3T0ppd0FqQ0l3QVF2L1dJb3YrVHdOUEE0bUtBZ0VpUndlTC9qRUFFMFF4QURJSFNSWkpnQU51YjNkTVVMQXJpLzVRU2IxRkFVRUExNHNMdmt4SlRnS01CMFJYQUNBeEFCSkJBTVNMQjBra1dVc0JGVktML3hKQkFMV0xCNEVpVzBtTENRNUJBTU9MQ1V3SmdUd09RUUNmS0lzSVVFbU1BTDFGQVVFQWpJc0F2a1NNQXlpTC9sQkpqQUc5UlFGQkFIT0xBYjVFakFXTEE0ditpUDg3U1U0Q2pBTk1qQVJBQUJTTEExY0NBSXYrVUVrVkpBb1dWd1lDVEZDTUJJc0VqQU14QUVtTUFvc0ZUSWovRFVsT0Fvd0ZUSXdHUUFBVWl3VlhBZ0NMQWxCSkZTUUtGbGNHQWt4UWpBYUxCb3NBU2J4SWl3Ty9pd0ZKdkVoTXY0c0x2RWdqakFDSktZd0ZRditOS1l3RFF2OTBpLzZBQWdBcVVJc0tVSXYvVUN1TENGQkp2RWhNdnlLTUFJbUxDUWxDL3p1S0FBRW9NUUJRU2IxRkFVRUFCb3NBdmtSTWlTbEMvL289IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
