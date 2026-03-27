#region USINGS

using CoopKit.Core;
using Steamworks;
using UnityEngine;

#endregion

namespace CoopKit.Steam
{
    public static class SteamUserService
    {
        public static PlayerProfile GetLocalPlayer()
        {
            if (!SteamManager.Initialized)
            {
                return null;
            }

            var profile = new PlayerProfile
            {
                Id = SteamUser.GetSteamID().m_SteamID,
                Name = SteamFriends.GetPersonaName(),
                Avatar = GetLocalPlayerAvatar()
            };

            return profile;
        }

        public static Texture2D GetLocalPlayerAvatar()
        {
            var imageId = SteamFriends.GetMediumFriendAvatar(SteamUser.GetSteamID());

            Texture2D result = null;

            var isValid = SteamUtils.GetImageSize(imageId, out var imageWidth, out var imageHeight);

            if (isValid)
            {
                var image = new byte[imageWidth * imageHeight * 4];

                isValid = SteamUtils.GetImageRGBA(imageId, image, (int)(imageWidth * imageHeight * 4));

                if (isValid)
                {
                    result = new Texture2D((int)imageWidth, (int)imageHeight, TextureFormat.RGBA32, false, true);
                    result.LoadRawTextureData(image);
                    result.Apply();
                }
            }

            return result;
        }
    }
}