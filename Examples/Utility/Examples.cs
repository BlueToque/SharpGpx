﻿using SharpGPX;
using SharpGPX.GPX1_1;

namespace Utility
{
    public static class Examples
    {
        public static GpxClass CreateTrack()
        {
            GpxClass track = new GpxClass()
            {
                Metadata = new metadataType()
                {
                    author = new personType("Michael Coyle", "Michael.Coyle@BlueToque.ca"),
                    link = new linkTypeCollection().AddLink(new linkType("www.BlueToque.ca", "Blue Toque Software")),
                    name = "Test Track",
                    desc = "Test track generated by SharpGPX",
                    copyright = new copyrightType("Blue Toque Software", "2020"),

                },
            };

            track.Tracks.Add(new trkType()
            {
                name = "11-AUG-11 18:18:27",
                trkseg = new trksegTypeCollection().AddItem(
                    new trksegType()
                    {
                        trkpt = new wptTypeCollection()
                            .AddItem(new wptType(49.706482, -123.111961, 38.11))
                            .AddItem(new wptType(49.706417, -123.112190, 38.11))
                            .AddItem(new wptType(49.706348, -123.112495, 76.08))
                            .AddItem(new wptType(49.706242, -123.111961, 74.16))
                            .AddItem(new wptType(49.705872, -123.111961, 38.11))
                    })
            });

            track.Metadata.bounds = track.GetBounds();
            return track;
        }

        public static GpxClass CreateTrackNoMetadata()
        {
            GpxClass track = new GpxClass();

            track.Tracks.Add(new trkType()
            {
                name = "11-AUG-11 18:18:27",
                trkseg = new trksegTypeCollection().AddItem(
                    new trksegType()
                    {
                        trkpt = new wptTypeCollection()
                            .AddItem(new wptType(49.706482, -123.111961, 38.11))
                            .AddItem(new wptType(49.706417, -123.112190, 38.11))
                            .AddItem(new wptType(49.706348, -123.112495, 76.08))
                            .AddItem(new wptType(49.706242, -123.111961, 74.16))
                            .AddItem(new wptType(49.705872, -123.111961, 38.11))
                    })
            });

            track.Metadata.bounds = track.GetBounds();
            return track;
        }
    }
}