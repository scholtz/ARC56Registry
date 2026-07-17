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

namespace Arc56.Generated.algorandfoundation.puya.AppExpectingEffects_922ddd5e
{


    public class AppExpectingEffectsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AppExpectingEffectsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CreateGroupReturn : AVMObjectType
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

                public static CreateGroupReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CreateGroupReturn();
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
                    return Equals(obj as CreateGroupReturn);
                }
                public bool Equals(CreateGroupReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CreateGroupReturn left, CreateGroupReturn right)
                {
                    return EqualityComparer<CreateGroupReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(CreateGroupReturn left, CreateGroupReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_create"> </param>
        /// <param name="app_create"> </param>
        public async Task<Structs.CreateGroupReturn> CreateGroup(AssetConfigurationTransaction asset_create, ApplicationCallTransaction app_create, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_create, app_create });
            byte[] abiHandle = { 109, 58, 4, 57 };

            var result = await base.CallApp(new List<object> { abiHandle, asset_create, app_create }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CreateGroupReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CreateGroup_Transactions(AssetConfigurationTransaction asset_create, ApplicationCallTransaction app_create, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_create, app_create });
            byte[] abiHandle = { 109, 58, 4, 57 };

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_create, app_create }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_call"> </param>
        public async Task LogGroup(ApplicationCallTransaction app_call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { app_call });
            byte[] abiHandle = { 98, 160, 239, 98 };

            var result = await base.CallApp(new List<object> { abiHandle, app_call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogGroup_Transactions(ApplicationCallTransaction app_call, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { app_call });
            byte[] abiHandle = { 98, 160, 239, 98 };

            return await base.MakeTransactionList(new List<object> { abiHandle, app_call }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXBwRXhwZWN0aW5nRWZmZWN0cyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDcmVhdGVHcm91cFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9ncm91cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2ZnIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfY3JlYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2NyZWF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJDcmVhdGVHcm91cFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ19ncm91cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2NhbGwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTRdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBsb2cgdmFsdWUgaXMgbm90IHRoZSByZXN1bHQgb2YgYW4gQUJJIHJldHVybiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXBwIGNyZWF0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFzc2V0IGNyZWF0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDVdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBjb3JyZWN0IGFwcCBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgY29ycmVjdCBhc3NldCBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGNvcnJlY3QgbWV0aG9kIGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGxvZ3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYWNmZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1LDEyNl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRFlLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdaM0p2ZFhCZmMybGtaVjlsWm1abFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRS0lDQWdJQzh2SUdOc1lYTnpJRUZ3Y0VWNGNHVmpkR2x1WjBWbVptVmpkSE1vUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRRGtLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFprTTJFd05ETTVJREI0TmpKaE1HVm1OaklnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZmWjNKdmRYQW9ZV05tWnl4aGNIQnNLU2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWliRzluWDJkeWIzVndLR0Z3Y0d3cGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVjluY205MWNDQnNiMmRmWjNKdmRYQUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUE1T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1keWIzVndYM05wWkdWZlpXWm1aV04wY3k1amIyNTBjbUZqZEM1QmNIQkZlSEJsWTNScGJtZEZabVpsWTNSekxtTnlaV0YwWlY5bmNtOTFjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVjluY205MWNEb0tJQ0FnSUM4dklHZHliM1Z3WDNOcFpHVmZaV1ptWldOMGN5OWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ015QXZMeUJoWTJabkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVdObVp3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdZWEJ3YkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Z3Y0d3S0lDQWdJQzh2SUdkeWIzVndYM05wWkdWZlpXWm1aV04wY3k5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwWDJOeVpXRjBaUzVqY21WaGRHVmtYMkZ6YzJWMExtbGtMQ0FpWlhod1pXTjBaV1FnWVhOelpYUWdZM0psWVhSbFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCbmRIaHVjeUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWVhOelpYUWdZM0psWVhSbFpBb2dJQ0FnTHk4Z1ozSnZkWEJmYzJsa1pWOWxabVpsWTNSekwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJ2Y0M1bllXbGtLR0Z6YzJWMFgyTnlaV0YwWlM1bmNtOTFjRjlwYm1SbGVDa2dQVDBnWVhOelpYUmZZM0psWVhSbExtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nUjNKdmRYQkpibVJsZUFvZ0lDQWdaMkZwWkhNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnWjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TDJOdmJuUnlZV04wTG5CNU9qRXlMVEUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUc5d0xtZGhhV1FvWVhOelpYUmZZM0psWVhSbExtZHliM1Z3WDJsdVpHVjRLU0E5UFNCaGMzTmxkRjlqY21WaGRHVXVZM0psWVhSbFpGOWhjM05sZEM1cFpBb2dJQ0FnTHk4Z0tTd2dJbVY0Y0dWamRHVmtJR052Y25KbFkzUWdZWE56WlhRZ2FXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1kyOXljbVZqZENCaGMzTmxkQ0JwWkFvZ0lDQWdMeThnWjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TDJOdmJuUnlZV04wTG5CNU9qRTFDaUFnSUNBdkx5QmhjM05sY25RZ1lYQndYMk55WldGMFpTNWpjbVZoZEdWa1gyRndjQzVwWkN3Z0ltVjRjR1ZqZEdWa0lHRndjQ0JqY21WaGRHVmtJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHZDBlRzV6SUVOeVpXRjBaV1JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoY0hBZ1kzSmxZWFJsWkFvZ0lDQWdMeThnWjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QnZjQzVuWVdsa0tHRndjRjlqY21WaGRHVXVaM0p2ZFhCZmFXNWtaWGdwSUQwOUlHRndjRjlqY21WaGRHVXVZM0psWVhSbFpGOWhjSEF1YVdRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nUjNKdmRYQkpibVJsZUFvZ0lDQWdaMkZwWkhNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnWjNKdmRYQmZjMmxrWlY5bFptWmxZM1J6TDJOdmJuUnlZV04wTG5CNU9qRTJMVEU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdLQW9nSUNBZ0x5OGdJQ0FnSUc5d0xtZGhhV1FvWVhCd1gyTnlaV0YwWlM1bmNtOTFjRjlwYm1SbGVDa2dQVDBnWVhCd1gyTnlaV0YwWlM1amNtVmhkR1ZrWDJGd2NDNXBaQW9nSUNBZ0x5OGdLU3dnSW1WNGNHVmpkR1ZrSUdOdmNuSmxZM1FnWVhCd0lHbGtJZ29nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHTnZjbkpsWTNRZ1lYQndJR2xrQ2lBZ0lDQXZMeUJuY205MWNGOXphV1JsWDJWbVptVmpkSE12WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1keWIzVndYM05wWkdWZlpXWm1aV04wY3k1amIyNTBjbUZqZEM1QmNIQkZlSEJsWTNScGJtZEZabVpsWTNSekxteHZaMTluY205MWNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXh2WjE5bmNtOTFjRG9LSUNBZ0lDOHZJR2R5YjNWd1gzTnBaR1ZmWldabVpXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCaGNIQnNDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYQndiQW9nSUNBZ0x5OGdaM0p2ZFhCZmMybGtaVjlsWm1abFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCaGMzTmxjblFnWVhCd1gyTmhiR3d1WVhCd1gyRnlaM01vTUNrZ1BUMGdZWEpqTkM1aGNtTTBYM05wWjI1aGRIVnlaU2dLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQXZMeUJuY205MWNGOXphV1JsWDJWbVptVmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qUXRNallLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjSEJmWTJGc2JDNWhjSEJmWVhKbmN5Z3dLU0E5UFNCaGNtTTBMbUZ5WXpSZmMybG5ibUYwZFhKbEtBb2dJQ0FnTHk4Z0lDQWdJQ0p6YjIxbFgzWmhiSFZsS0NsMWFXNTBOalFpQ2lBZ0lDQXZMeUFwTENBaVpYaHdaV04wWldRZ1kyOXljbVZqZENCdFpYUm9iMlFnWTJGc2JHVmtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaRE0wTnpsbE5qVWdMeThnYldWMGFHOWtJQ0p6YjIxbFgzWmhiSFZsS0NsMWFXNTBOalFpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHTnZjbkpsWTNRZ2JXVjBhRzlrSUdOaGJHeGxaQW9nSUNBZ0x5OGdaM0p2ZFhCZmMybGtaVjlsWm1abFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCaGMzTmxjblFnWVhCd1gyTmhiR3d1Ym5WdFgyeHZaM01nUFQwZ01Td2dJbVY0Y0dWamRHVmtJR3h2WjNNaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFNTFiVXh2WjNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHeHZaM01LSUNBZ0lDOHZJR2R5YjNWd1gzTnBaR1ZmWldabVpXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUXVabkp2YlY5c2IyY29ZWEJ3WDJOaGJHd3ViR0Z6ZEY5c2IyY3BDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJzYjJjZ2RtRnNkV1VnYVhNZ2JtOTBJSFJvWlNCeVpYTjFiSFFnYjJZZ1lXNGdRVUpKSUhKbGRIVnliZ29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5Qm5jbTkxY0Y5emFXUmxYMlZtWm1WamRITXZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUQwOUlDaGhjSEJmWTJGc2JDNW5jbTkxY0Y5cGJtUmxlQ0FySURFcElDb2dSMnh2WW1Gc0xtZHliM1Z3WDNOcGVtVUtJQ0FnSUhOM1lYQUtJQ0FnSUdkMGVHNXpJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNBcUNpQWdJQ0F2THlCbmNtOTFjRjl6YVdSbFgyVm1abVZqZEhNdlkyOXVkSEpoWTNRdWNIazZNamt0TXpBS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMExtWnliMjFmYkc5bktHRndjRjlqWVd4c0xteGhjM1JmYkc5bktRb2dJQ0FnTHk4Z1BUMGdLR0Z3Y0Y5allXeHNMbWR5YjNWd1gybHVaR1Y0SUNzZ01Ta2dLaUJIYkc5aVlXd3VaM0p2ZFhCZmMybDZaUW9nSUNBZ2FYUnZZZ29nSUNBZ1lqMDlDaUFnSUNBdkx5Qm5jbTkxY0Y5emFXUmxYMlZtWm1WamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpndE16RUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalF1Wm5KdmJWOXNiMmNvWVhCd1gyTmhiR3d1YkdGemRGOXNiMmNwQ2lBZ0lDQXZMeUFnSUNBZ1BUMGdLR0Z3Y0Y5allXeHNMbWR5YjNWd1gybHVaR1Y0SUNzZ01Ta2dLaUJIYkc5aVlXd3VaM0p2ZFhCZmMybDZaUW9nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJuY205MWNGOXphV1JsWDJWbVptVmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUVltQVFRVkgzeDFNUnRCQUIweEdSUkVNUmhFZ2dJRWJUb0VPUVJpb085aU5ob0FqZ0lBQ1FCSUFERVpGREVZRkJCRE1SYUJBZ2xKT0JDQkF4SkVNUllpQ1VrNEVDTVNSRXNCT0R4SlJFOENPQlk5U3dFU1JFc0JPRDFKUkU4Q09CWTlTd0VTUkV3V1RCWlFLRXhRc0NKRE1SWWlDVWs0RUNNU1JFazVHZ0NBQk5OSG5tVVNSRWs0T3lJU1JFazRQa2xYQUFRb0VrUlhCQUJKRllFSUVrUk1PQllpQ0RJRUN4YW9SQ0pEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
