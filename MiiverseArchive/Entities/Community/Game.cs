﻿using MiiverseArchive.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiiverseArchive.Entities.Community
{
    public class Game
    {
        public Game()
        {

        }

        public Game(string id, string title, string titleUrl, Uri iconUri, string platform, string type)
        {
            Id = id;
            Title = title;
            TitleUrl = titleUrl;
            IconUri = iconUri;
            Platform = GamePlatformHelper.DetectPlatformFromImageName(platform);
            Type = type;
        }

        public Game(string id, string title, string titleUrl, Uri iconUri, Uri communityUri, string platform, string type)
        {
            Id = id;
            Title = title;
            TitleUrl = titleUrl;
            IconUri = iconUri;
            CommunityListIcon = communityUri;
            Platform = GamePlatformHelper.DetectPlatformFromImageName(platform);
            Type = type;
        }

        public string Id { get; set; }

        public string Title { get; set; }

        public string TitleUrl { get; set; }

        public Uri IconUri { get; set; }

        public Uri CommunityListIcon { get; set; }

        public Platform Platform { get; set; }

        public string Type { get; set; }

        public ViewRegion ViewRegion { get; set; }
    }

    public class CommunityItem
    {
        public CommunityItem()
        {

        }

        public CommunityItem(string id, string section, string communityBadge, string title, string titleUrl, Uri iconUri, string platform, string type)
        {
            Id = id;
            Section = section;
            CommunityBadge = communityBadge;
            Title = title;
            TitleUrl = titleUrl;
            IconUri = iconUri;
            Platform = GamePlatformHelper.DetectPlatformFromImageName(platform);
            Type = type;
        }

        public CommunityItem(string id, string section, string communityBadge, string title, string titleUrl, Uri iconUri, Uri communityUri, string platform, string type)
        {
            Id = id;
            Section = section;
            CommunityBadge = communityBadge;
            Title = title;
            TitleUrl = titleUrl;
            IconUri = iconUri;
            CommunityListIcon = communityUri;
            Platform = GamePlatformHelper.DetectPlatformFromImageName(platform);
            Type = type;
        }

        public string Id { get; set; }

        public string Section { get; set; }

        public string CommunityBadge { get; set; }

        public string Title { get; set; }

        public string TitleUrl { get; set; }

        public Uri IconUri { get; set; }

        public Uri CommunityListIcon { get; set; }

        public Platform Platform { get; set; }

        public string Type { get; set; }

        public ViewRegion ViewRegion { get; set; }
    }
}
