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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_8a944830
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
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Slot { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Offset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSlot = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vSlot.From(Slot);
                    ret.AddRange(vSlot.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOffset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vOffset.From(Offset);
                    ret.AddRange(vOffset.Encode());
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
                    var vSlot = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vSlot.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Slot = vSlot;
                    var vOffset = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vOffset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Offset = vOffset;
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
        /// <param name="i"> </param>
        public async Task<Structs.FReturn> F(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 96, 113, 151 };

            var result = await base.CallApp(new List<object> { abiHandle, i }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> F_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt512 i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 96, 113, 151 };

            return await base.MakeTransactionList(new List<object> { abiHandle, i }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJmUmV0dXJuIjpbeyJuYW1lIjoic2xvdCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoib2Zmc2V0IiwidHlwZSI6InVpbnQ1MTIifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiX19wb3N0SW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiZlJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzA4XSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ1MTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTVdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MCwyNzNdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12YVc1c2FXNWxRWE56WlcxaWJIa3ZjMnh2ZEY5aFkyTmxjM05mZG1saFgyMWhjSEJwYm1kZmNHOXBiblJsY2k1emIyd3VReTVoY0hCeWIzWmhiRjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEQWdNU0EyTkNBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUEzQ2lBZ0lDQndkWE5vYVc1MElEUXdPVFlLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lITjBiM0psSURVS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUd4dllXUWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNQW9nSUNBZ2NtVndiR0ZqWlRJZ05qUUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsOWZZM1J2Y2w5d1pXNWthVzVuSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHSmhZMk0wT1dVeklEQjROVGsyTURjeE9UY2dMeThnYldWMGFHOWtJQ0pmWDNCdmMzUkpibWwwS0NsMmIybGtJaXdnYldWMGFHOWtJQ0ptS0hWcGJuUTFNVElwS0hWcGJuUTFNVElzZFdsdWREVXhNaWtpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMTlmY0c5emRFbHVhWFJmY205MWRHVkFOU0J0WVdsdVgyWmZjbTkxZEdWQU5nb2dJQ0FnWlhKeUNncHRZV2x1WDJaZmNtOTFkR1ZBTmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUEyTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOVEV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0EyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0EwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnNiMkZrSURBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkdsbklEY0tJQ0FnSUdKOENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVNBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdiV0YwWTJnZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY4d1FERTBJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZNVUF4TlFvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBMkNncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRjNkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh5SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYekZBTVRVNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhOd29LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjh3UURFME9nb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QTBDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUF4TndvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXpDZ3B0WVdsdVgxOWZjRzl6ZEVsdWFYUmZjbTkxZEdWQU5Ub0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lsOWZZM1J2Y2w5d1pXNWthVzVuSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJmWDNCdmMzUkpibWwwSUdGc2NtVmhaSGtnWTJGc2JHVmtDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmZYMk4wYjNKZmNHVnVaR2x1WnlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p0TUNJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW0weElnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUhCMWMyaGllWFJsY3lBaWJUSWlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZhVzVzYVc1bFFYTnpaVzFpYkhrdmMyeHZkRjloWTJObGMzTmZkbWxoWDIxaGNIQnBibWRmY0c5cGJuUmxjaTV6YjJ3dVF5NWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFGQUlDWUJEbDlmWTNSdmNsOXdaVzVrYVc1bklrY0hnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUZLQ05uSTBNeEdSUkVNUmhFZ2dJRXVzeEo0d1JaWUhHWE5ob0FqZ0lBd0FBQkFEWWFBVWxGQ0JVa0VrUWlSUVlpUlFVaVJRSWlSUUVpUlFRaVJRTXhGa0VBbWpFV0l3azRDQlJFTkFCRkNDV3ZTd2VyU1JVbENTVllnZ0lnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFKUEFvNENBREFBS2tzRVN3WkxDVFVBVEVrVkpBNUVKSzlNU3dHclR3SkpGU1FPUkU4Q3ExQ0FCQlVmZkhWTVVMQWpRMGxMQWtMLzFFc0NTd1JDLzgwaVF2OW9LR1JFS0NKbmdBSnRNSUVDdVVpQUFtMHhnUUs1U0lBQ2JUS0JBcmxJSTBNPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
