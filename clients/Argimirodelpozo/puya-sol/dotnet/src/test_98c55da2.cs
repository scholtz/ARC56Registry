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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.test_98c55da2
{


    public class testProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public testProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class S1 : AVMObjectType
            {
                public byte X { get; set; }

                public bool Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static S1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new S1();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is byte vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is bool vYValue) { ret.Y = vYValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as S1);
                }
                public bool Equals(S1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(S1 left, S1 right)
                {
                    return EqualityComparer<S1>.Default.Equals(left, right);
                }
                public static bool operator !=(S1 left, S1 right)
                {
                    return !(left == right);
                }

            }

            public class S2 : AVMObjectType
            {
                public uint Z { get; set; }

                public Structs.S1 S1Data { get; set; } = new Structs.S1();

                public byte[] Recursive { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZ = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vZ.From(Z);
                    ret.AddRange(vZ.Encode());
                    ret.AddRange(S1Data.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecursive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vRecursive.From(Recursive);
                    ret.AddRange(vRecursive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static S2 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new S2();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZ = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vZ.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueZ = vZ.ToValue();
                    if (valueZ is uint vZValue) { ret.Z = vZValue; }
                    ret.S1Data = Structs.S1.Parse(queue.ToArray());
                    { var consumedS1Data = ret.S1Data.ToByteArray().Length; for (int i = 0; i < consumedS1Data && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecursive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vRecursive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecursive = vRecursive.ToValue();
                    if (valueRecursive is byte[] vRecursiveValue) { ret.Recursive = vRecursiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as S2);
                }
                public bool Equals(S2? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(S2 left, S2 right)
                {
                    return EqualityComparer<S2>.Default.Equals(left, right);
                }
                public static bool operator !=(S2 left, S2 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Check(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 52, 221, 27 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Check_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 52, 221, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Set(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 118, 32, 90 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Set_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 118, 32, 90 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJzMSI6W3sibmFtZSI6IngiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJ5IiwidHlwZSI6ImJvb2wifV0sInMyIjpbeyJuYW1lIjoieiIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJzMWRhdGEiLCJ0eXBlIjoiczEifSx7Im5hbWUiOiJyZWN1cnNpdmUiLCJ0eXBlIjoiYnl0ZVtdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNoZWNrIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1Myw2NjVdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YzNSeWRXTjBjeTl6ZEhKMVkzUnpMbk52YkM1MFpYTjBMbUZ3Y0hKdmRtRnNYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRFlnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURBd01EQXdNREF3TURBd01EQXdNRGd3TURBd0lDSmtZWFJoSWlBd2VEY3lOalUyTXpjMU56STNNelk1TnpZMk5UZ3dNRFZtTURKa05ETm1ZVEEyWlRka01EVTROV1ppTmpSak9UWXhaRFUzWlRNeE9HSXlOMkV4TkRWak9EVTNZbU5rTTJFMlltUmlOREV6Wm1ZM1ptTWdNSGd3TURBNElEQjRNREFnTUhnM01qWTFOak0zTlRjeU56TTJPVGMyTmpWa05UWTRPR0UxTW1RMU5XRXdNbVZqTkdGbFlUVmxZekZsWVdSbVptWmxNV001WlRCbFpUWmhOR1JrWW1VeU16YzNaams0TXpJMlpEUXlaR1pqT1RjMUlEQjROekkyTlRZek56VTNNamN6TmprM05qWTFZV1kxTlRjd1pqVmhNVGd4TUdJM1lXWTNPR05oWmpSaVl6Y3dZVFkyTUdZd1pHWTFNV1UwTW1KaFpqa3haRFJrWlRWaU1qTXlPR1JsTUdVNE0yUm1Zd29nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0ZsTXpSa1pERmlJREI0TUdZM05qSXdOV0VnTHk4Z2JXVjBhRzlrSUNKamFHVmpheWdwWW05dmJDSXNJRzFsZEdodlpDQWljMlYwS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWphR1ZqYTE5eWIzVjBaVUExSUcxaGFXNWZjMlYwWDNKdmRYUmxRRFlLSUNBZ0lHVnljZ29LYldGcGJsOXpaWFJmY205MWRHVkFOam9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVJoZEdFaUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd09EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQTBJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdNRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKa1lYUmhJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prWVhSaElnb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURRZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3T0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltUmhkR0VpQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1SaGRHRWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ05DQXlDaUFnSUNCbGVIUnlZV04wSURBZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaR0YwWVNJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpHRjBZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01qWTFOak0zTlRjeU56TTJPVGMyTmpVNE1EQTFaakF5WkRRelptRXdObVUzWkRBMU9EVm1ZalkwWXprMk1XUTFOMlV6TVRoaU1qZGhNVFExWXpnMU4ySmpaRE5oTm1Ka1lqUXhNMlptTjJaakNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd09EQXdNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQTBJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQTFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdNRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56STJOVFl6TnpVM01qY3pOamszTmpZMU9EQXdOV1l3TW1RME0yWmhNRFpsTjJRd05UZzFabUkyTkdNNU5qRmtOVGRsTXpFNFlqSTNZVEUwTldNNE5UZGlZMlF6WVRaaVpHSTBNVE5tWmpkbVl3b2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekkyTlRZek56VTNNamN6TmprM05qWTFPREF3TldZd01tUTBNMlpoTURabE4yUXdOVGcxWm1JMk5HTTVOakZrTlRkbE16RTRZakkzWVRFME5XTTROVGRpWTJRellUWmlaR0kwTVRObVpqZG1Zd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjeU5qVTJNemMxTnpJM016WTVOelkyTldRMU5qZzRZVFV5WkRVMVlUQXlaV00wWVdWaE5XVmpNV1ZoWkdabVptVXhZemxsTUdWbE5tRTBaR1JpWlRJek56ZG1PVGd6TWpaa05ESmtabU01TnpVS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBNE1EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUEyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURJS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQXdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnM01qWTFOak0zTlRjeU56TTJPVGMyTmpWa05UWTRPR0UxTW1RMU5XRXdNbVZqTkdGbFlUVmxZekZsWVdSbVptWmxNV001WlRCbFpUWmhOR1JrWW1VeU16YzNaams0TXpJMlpEUXlaR1pqT1RjMUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzNNalkxTmpNM05UY3lOek0yT1RjMk5qVmtOVFk0T0dFMU1tUTFOV0V3TW1Wak5HRmxZVFZsWXpGbFlXUm1abVpsTVdNNVpUQmxaVFpoTkdSa1ltVXlNemMzWmprNE16STJaRFF5Wkdaak9UYzFDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TnpJMk5UWXpOelUzTWpjek5qazNOalkxWVdZMU5UY3daalZoTVRneE1HSTNZV1kzT0dOaFpqUmlZemN3WVRZMk1HWXdaR1kxTVdVME1tSmhaamt4WkRSa1pUVmlNak15T0dSbE1HVTRNMlJtWXdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURnd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNZ29nSUNBZ1pYaDBjbUZqZENBd0lERUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TnpJMk5UWXpOelUzTWpjek5qazNOalkxWVdZMU5UY3daalZoTVRneE1HSTNZV1kzT0dOaFpqUmlZemN3WVRZMk1HWXdaR1kxTVdVME1tSmhaamt4WkRSa1pUVmlNak15T0dSbE1HVTRNMlJtWXdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE56STJOVFl6TnpVM01qY3pOamszTmpZMVlXWTFOVGN3WmpWaE1UZ3hNR0kzWVdZM09HTmhaalJpWXpjd1lUWTJNR1l3WkdZMU1XVTBNbUpoWmpreFpEUmtaVFZpTWpNeU9HUmxNR1U0TTJSbVl3b2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRGN5TmpVMk16YzFOekkzTXpZNU56WTJOVGd3TURWbU1ESmtORE5tWVRBMlpUZGtNRFU0TldaaU5qUmpPVFl4WkRVM1pUTXhPR0l5TjJFeE5EVmpPRFUzWW1Oa00yRTJZbVJpTkRFelptWTNabU1LSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREE0TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURRZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGczTWpZMU5qTTNOVGN5TnpNMk9UYzJOalU0TURBMVpqQXlaRFF6Wm1Fd05tVTNaREExT0RWbVlqWTBZemsyTVdRMU4yVXpNVGhpTWpkaE1UUTFZemcxTjJKalpETmhObUprWWpReE0yWm1OMlpqQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01qWTFOak0zTlRjeU56TTJPVGMyTmpVNE1EQTFaakF5WkRRelptRXdObVUzWkRBMU9EVm1ZalkwWXprMk1XUTFOMlV6TVRoaU1qZGhNVFExWXpnMU4ySmpaRE5oTm1Ka1lqUXhNMlptTjJaakNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNS0NtMWhhVzVmWTJobFkydGZjbTkxZEdWQU5Ub0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVGc2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltUmhkR0VpQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3T0RBd01EQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRE15Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklHMWhhVzVmWW05dmJGOW1ZV3h6WlVBeU5nb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpHRjBZU0lLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREE0TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSjVkR1VLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJR0o2SUcxaGFXNWZZbTl2YkY5bVlXeHpaVUF5TmdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWkdGMFlTSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQTRNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbGVIUnlZV04wSURRZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5aWIyOXNYMlpoYkhObFFESTJDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekkyTlRZek56VTNNamN6TmprM05qWTFPREF3TldZd01tUTBNMlpoTURabE4yUXdOVGcxWm1JMk5HTTVOakZrTlRkbE16RTRZakkzWVRFME5XTTROVGRpWTJRellUWmlaR0kwTVRObVpqZG1Zd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNRGd3TURBd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXpNZ29nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0E5UFFvZ0lDQWdZbm9nYldGcGJsOWliMjlzWDJaaGJITmxRREkyQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TnpJMk5UWXpOelUzTWpjek5qazNOalkxWkRVMk9EaGhOVEprTlRWaE1ESmxZelJoWldFMVpXTXhaV0ZrWm1abVpURmpPV1V3WldVMllUUmtaR0psTWpNM04yWTVPRE15Tm1RME1tUm1ZemszTlFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURnd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF6TWdvZ0lDQWdhVzUwWTE4eUlDOHZJRFlLSUNBZ0lEMDlDaUFnSUNCaWVpQnRZV2x1WDJKdmIyeGZabUZzYzJWQU1qWUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzNNalkxTmpNM05UY3lOek0yT1RjMk5qVmhaalUxTnpCbU5XRXhPREV3WWpkaFpqYzRZMkZtTkdKak56QmhOall3WmpCa1pqVXhaVFF5WW1GbU9URmtOR1JsTldJeU16STRaR1V3WlRnelpHWmpDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdPREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pYaDBjbUZqZENBMElESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpYm5vZ2JXRnBibDlpYjI5c1gyWmhiSE5sUURJMkNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56STJOVFl6TnpVM01qY3pOamszTmpZMU9EQXdOV1l3TW1RME0yWmhNRFpsTjJRd05UZzFabUkyTkdNNU5qRmtOVGRsTXpFNFlqSTNZVEUwTldNNE5UZGlZMlF6WVRaaVpHSTBNVE5tWmpkbVl3b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EZ3dNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5Rek1nb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQTlQUW9nSUNBZ1lub2diV0ZwYmw5aWIyOXNYMlpoYkhObFFESTJDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tiV0ZwYmw5aWIyOXNYMjFsY21kbFFESTNPZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aWIyOXNYMlpoYkhObFFESTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDlpYjI5c1gyMWxjbWRsUURJM0NncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGM2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVGdLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZjM1J5ZFdOMGN5OXpkSEoxWTNSekxuTnZiQzUwWlhOMExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFFR0NDWUhDZ0FBQUFBQUFBQUlBQUFFWkdGMFlTbHlaV04xY25OcGRtV0FCZkF0US9vRzU5QllYN1pNbGgxWDR4aXllaFJjaFh2Tk9tdmJRVC8zL0FJQUNBRUFLWEpsWTNWeWMybDJaZFZvaWxMVldnTHNTdXBld2VyZi8rSEo0TzVxVGR2aU4zK1lNbTFDMzhsMUtYSmxZM1Z5YzJsMlphOVZjUFdoZ1F0Njk0eXZTOGNLWmc4TjlSNUN1dmtkVGVXeU1vM2c2RDM4Z1lBZ3IwazFCVFVBTkFDQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNBWEVBMUFERVlRQUFDSTBNeEdSUkVNUmhFZ2dJRXJqVGRHd1FQZGlCYU5ob0FqZ0lCblFBQkFERVdRUUdUTVJZakNUZ0lGRVFwdmloT0FrMUpKRmxMQVJWTEFrNENVbGNDQUV4WEJBS0FCQUFBQUFGTVVFc0JGUlpYQmdKUEFsQk1LMUJNVUNtOFNDbExBYjlKSkZsTEFSVkxBazRDVWxjQ0FFc0JWd1FDSlZNbkJDSlBBbFNBQVFKTVVFOENWd0FFVEZCTEFSVVdWd1lDVHdKUVRDdFFURkFwdkVncFN3Ry9TU1JaU3dFVlN3Sk9BbEpYQWdCTEFWY0VBbGNBQVlBQmdGQlBBbGNBQkV4UVN3RVZGbGNHQWs4Q1VFd3JVRXhRS2J4SUtVeS9LcjRvVGdKTlNTUlpTd0VWU3dKT0FsSlhBZ0JNVndRQ2dBUUFBQUFGVEZCTEFSVVdWd1lDVHdKUVRDdFFURkFxdkVncVRMOG5CYjRvVGdKTlNTUlpTd0VWU3dKT0FsSlhBZ0JNVndRQ2dBUUFBQUFHVEZCTEFSVVdWd1lDVHdKUVRDdFFURkFuQmJ4SUp3Vk12eWNHdmloT0FrMUpKRmxMQVJWTEFrNENVbGNDQUVzQlZ3UUNWd0FCSndSUVR3SlhBQVJNVUVzQkZSWlhCZ0pQQWxCTUsxQk1VQ2NHdkVnbkJreS9LcjRvVGdKTlNTUlpTd0VWU3dKT0FsSlhBZ0JNVndRQ2dBUUFBQUFKVEZCTEFSVVdWd1lDVHdKUVRDdFFURkFxdkVncVRMOGpReUpDL204eEZrRUFsVEVXSXdrNENCUkVLYjRvVGdKTklsb2pFa0VBZkNtK0tFNENUVmNFQWlKVmdRSVNRUUJyS2I0b1RnSk5Wd1FDSlZNbkJDSlBBbFFpVXlNU1FRQlRLcjRvVGdKTklscUJCUkpCQUVVbkJiNG9UZ0pOSWxva0VrRUFOeWNHdmloT0FrMVhCQUlsVXljRUlrOENWQ0pUUUFBZ0tyNG9UZ0pOSWxxQkNSSkJBQklqSndRaVR3SlVnQVFWSDN4MVRGQ3dJME1pUXYvcklrTC9iUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
