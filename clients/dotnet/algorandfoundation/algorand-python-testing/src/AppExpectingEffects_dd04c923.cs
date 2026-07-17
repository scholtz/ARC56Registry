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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.AppExpectingEffects_dd04c923
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXBwRXhwZWN0aW5nRWZmZWN0cyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDcmVhdGVHcm91cFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9ncm91cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2ZnIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfY3JlYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2NyZWF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJDcmVhdGVHcm91cFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ19ncm91cCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2NhbGwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTVdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBsb2cgdmFsdWUgaXMgbm90IHRoZSByZXN1bHQgb2YgYW4gQUJJIHJldHVybiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXBwIGNyZWF0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFzc2V0IGNyZWF0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDVdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBjb3JyZWN0IGFwcCBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgY29ycmVjdCBhc3NldCBpZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGNvcnJlY3QgbWV0aG9kIGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGxvZ3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYWNmZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1LDEyNl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJRFlLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnlaV0YwWldSQmNIQkJjM05sZEM5amIyNTBjbUZqZEM1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCQmNIQkZlSEJsWTNScGJtZEZabVpsWTNSektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBNUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMlpETmhNRFF6T1NBd2VEWXlZVEJsWmpZeUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgyZHliM1Z3S0dGalptY3NZWEJ3YkNrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW14dloxOW5jbTkxY0NoaGNIQnNLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWZlozSnZkWEFnYkc5blgyZHliM1Z3Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU9Ub0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE11WVhKMGFXWmhZM1J6TGtOeVpXRjBaV1JCY0hCQmMzTmxkQzVqYjI1MGNtRmpkQzVCY0hCRmVIQmxZM1JwYm1kRlptWmxZM1J6TG1OeVpXRjBaVjluY205MWNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpWOW5jbTkxY0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlEY21WaGRHVmtRWEJ3UVhOelpYUXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElETWdMeThnWVdObVp3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGalptY0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJR0Z3Y0d3S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoY0hCc0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKbFlYUmxaRUZ3Y0VGemMyVjBMMk52Ym5SeVlXTjBMbkI1T2pFeENpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUmZZM0psWVhSbExtTnlaV0YwWldSZllYTnpaWFF1YVdRc0lDSmxlSEJsWTNSbFpDQmhjM05sZENCamNtVmhkR1ZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmhjM05sZENCamNtVmhkR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0psWVhSbFpFRndjRUZ6YzJWMEwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJ2Y0M1bllXbGtLR0Z6YzJWMFgyTnlaV0YwWlM1bmNtOTFjRjlwYm1SbGVDa2dQVDBnWVhOelpYUmZZM0psWVhSbExtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ozUjRibk1nUjNKdmRYQkpibVJsZUFvZ0lDQWdaMkZwWkhNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMME55WldGMFpXUkJjSEJCYzNObGRDOWpiMjUwY21GamRDNXdlVG94TWkweE5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQnZjQzVuWVdsa0tHRnpjMlYwWDJOeVpXRjBaUzVuY205MWNGOXBibVJsZUNrZ1BUMGdZWE56WlhSZlkzSmxZWFJsTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FLSUNBZ0lDOHZJQ2tzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUdGemMyVjBJR2xrSWdvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR052Y25KbFkzUWdZWE56WlhRZ2FXUUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RGNtVmhkR1ZrUVhCd1FYTnpaWFF2WTI5dWRISmhZM1F1Y0hrNk1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGNIQmZZM0psWVhSbExtTnlaV0YwWldSZllYQndMbWxrTENBaVpYaHdaV04wWldRZ1lYQndJR055WldGMFpXUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0Z3Y0NCamNtVmhkR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0psWVhSbFpFRndjRUZ6YzJWMEwyTnZiblJ5WVdOMExuQjVPakUzQ2lBZ0lDQXZMeUJ2Y0M1bllXbGtLR0Z3Y0Y5amNtVmhkR1V1WjNKdmRYQmZhVzVrWlhncElEMDlJR0Z3Y0Y5amNtVmhkR1V1WTNKbFlYUmxaRjloY0hBdWFXUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaM1I0Ym5NZ1IzSnZkWEJKYm1SbGVBb2dJQ0FnWjJGcFpITUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBOeVpXRjBaV1JCY0hCQmMzTmxkQzlqYjI1MGNtRmpkQzV3ZVRveE5pMHhPQW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0J2Y0M1bllXbGtLR0Z3Y0Y5amNtVmhkR1V1WjNKdmRYQmZhVzVrWlhncElEMDlJR0Z3Y0Y5amNtVmhkR1V1WTNKbFlYUmxaRjloY0hBdWFXUUtJQ0FnSUM4dklDa3NJQ0psZUhCbFkzUmxaQ0JqYjNKeVpXTjBJR0Z3Y0NCcFpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCamIzSnlaV04wSUdGd2NDQnBaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnlaV0YwWldSQmNIQkJjM05sZEM5amIyNTBjbUZqZEM1d2VUbzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVEY21WaGRHVmtRWEJ3UVhOelpYUXVZMjl1ZEhKaFkzUXVRWEJ3Ulhod1pXTjBhVzVuUldabVpXTjBjeTVzYjJkZlozSnZkWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwc2IyZGZaM0p2ZFhBNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKbFlYUmxaRUZ3Y0VGemMyVjBMMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUdGd2NHd0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGNIQnNDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlEzSmxZWFJsWkVGd2NFRnpjMlYwTDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QmhjM05sY25RZ1lYQndYMk5oYkd3dVlYQndYMkZ5WjNNb01Da2dQVDBnWVhKak5DNWhjbU0wWDNOcFoyNWhkSFZ5WlNnS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCbmRIaHVjMkZ6SUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnlaV0YwWldSQmNIQkJjM05sZEM5amIyNTBjbUZqZEM1d2VUb3lOQzB5TmdvZ0lDQWdMeThnWVhOelpYSjBJR0Z3Y0Y5allXeHNMbUZ3Y0Y5aGNtZHpLREFwSUQwOUlHRnlZelF1WVhKak5GOXphV2R1WVhSMWNtVW9DaUFnSUNBdkx5QWdJQ0FnSW5OdmJXVmZkbUZzZFdVb0tYVnBiblEyTkNJS0lDQWdJQzh2SUNrc0lDSmxlSEJsWTNSbFpDQmpiM0p5WldOMElHMWxkR2h2WkNCallXeHNaV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrTXpRM09XVTJOU0F2THlCdFpYUm9iMlFnSW5OdmJXVmZkbUZzZFdVb0tYVnBiblEyTkNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZMjl5Y21WamRDQnRaWFJvYjJRZ1kyRnNiR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRM0psWVhSbFpFRndjRUZ6YzJWMEwyTnZiblJ5WVdOMExuQjVPakkzQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEJ3WDJOaGJHd3ViblZ0WDJ4dlozTWdQVDBnTVN3Z0ltVjRjR1ZqZEdWa0lHeHZaM01pQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUU1MWJVeHZaM01LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUd4dlozTUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RGNtVmhkR1ZrUVhCd1FYTnpaWFF2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBMbVp5YjIxZmJHOW5LR0Z3Y0Y5allXeHNMbXhoYzNSZmJHOW5LUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnYkc5bklIWmhiSFZsSUdseklHNXZkQ0IwYUdVZ2NtVnpkV3gwSUc5bUlHRnVJRUZDU1NCeVpYUjFjbTRLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlEzSmxZWFJsWkVGd2NFRnpjMlYwTDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QTlQU0FvWVhCd1gyTmhiR3d1WjNKdmRYQmZhVzVrWlhnZ0t5QXhLU0FxSUVkc2IySmhiQzVuY205MWNGOXphWHBsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdLZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwTnlaV0YwWldSQmNIQkJjM05sZEM5amIyNTBjbUZqZEM1d2VUb3lPUzB6TUFvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRdVpuSnZiVjlzYjJjb1lYQndYMk5oYkd3dWJHRnpkRjlzYjJjcENpQWdJQ0F2THlBOVBTQW9ZWEJ3WDJOaGJHd3VaM0p2ZFhCZmFXNWtaWGdnS3lBeEtTQXFJRWRzYjJKaGJDNW5jbTkxY0Y5emFYcGxDaUFnSUNCcGRHOWlDaUFnSUNCaVBUMEtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5RGNtVmhkR1ZrUVhCd1FYTnpaWFF2WTI5dWRISmhZM1F1Y0hrNk1qZ3RNekVLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRdVpuSnZiVjlzYjJjb1lYQndYMk5oYkd3dWJHRnpkRjlzYjJjcENpQWdJQ0F2THlBZ0lDQWdQVDBnS0dGd2NGOWpZV3hzTG1keWIzVndYMmx1WkdWNElDc2dNU2tnS2lCSGJHOWlZV3d1WjNKdmRYQmZjMmw2WlFvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UTNKbFlYUmxaRUZ3Y0VGemMyVjBMMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQ0FRWW1BUVFWSDN4MU1SdEJBQjB4R1JSRU1SaEVnZ0lFYlRvRU9RUmlvTzlpTmhvQWpnSUFDUUJJQURFWkZERVlGQkJETVJhQkFnbEpPQkNCQXhKRU1SWWlDVWs0RUNNU1JFc0JPRHhKUkU4Q09CWTlTd0VTUkVzQk9EMUpSRThDT0JZOVN3RVNSRXdXVEJaUUtFeFFzQ0pETVJZaUNVazRFQ01TUkVtQkFNSWFnQVRUUjU1bEVrUkpPRHNpRWtSSk9ENUpWd0FFS0JKRVZ3UUFURGdXSWdneUJBc1dxRVFpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
