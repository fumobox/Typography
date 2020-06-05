﻿//MIT, 2016-present, WinterDev

namespace Typography.OpenFont
{
    
    //https://docs.microsoft.com/en-us/typography/opentype/spec/os2#ulunicoderange1-bits-031ulunicoderange2-bits-3263ulunicoderange3-bits-6495ulunicoderange4-bits-96127

    public enum UnicodeLangBits : long
    {
        Unset = 0,

        //AUTOGEN
        Basic_Latin = (0L << 32) | (0x0000 << 16) | 0x007F,
        Latin_1_Supplement = (1L << 32) | (0x0080 << 16) | 0x00FF,
        Latin_Extended_A = (2L << 32) | (0x0100 << 16) | 0x017F,
        Latin_Extended_B = (3L << 32) | (0x0180 << 16) | 0x024F,
        IPA_Extensions = (4L << 32) | (0x0250 << 16) | 0x02AF,
        Phonetic_Extensions = (4L << 32) | (0x1D00 << 16) | 0x1D7F,
        Phonetic_Extensions_Supplement = (4L << 32) | (0x1D80 << 16) | 0x1DBF,
        Spacing_Modifier_Letters = (5L << 32) | (0x02B0 << 16) | 0x02FF,
        Modifier_Tone_Letters = (5L << 32) | (0xA700 << 16) | 0xA71F,
        Combining_Diacritical_Marks = (6L << 32) | (0x0300 << 16) | 0x036F,
        Combining_Diacritical_Marks_Supplement = (6L << 32) | (0x1DC0 << 16) | 0x1DFF,
        Greek_and_Coptic = (7L << 32) | (0x0370 << 16) | 0x03FF,
        Coptic = (8L << 32) | (0x2C80 << 16) | 0x2CFF,
        Cyrillic = (9L << 32) | (0x0400 << 16) | 0x04FF,
        Cyrillic_Supplement = (9L << 32) | (0x0500 << 16) | 0x052F,
        Cyrillic_Extended_A = (9L << 32) | (0x2DE0 << 16) | 0x2DFF,
        Cyrillic_Extended_B = (9L << 32) | (0xA640 << 16) | 0xA69F,
        Armenian = (10L << 32) | (0x0530 << 16) | 0x058F,
        Hebrew = (11L << 32) | (0x0590 << 16) | 0x05FF,
        Vai = (12L << 32) | (0xA500 << 16) | 0xA63F,
        Arabic = (13L << 32) | (0x0600 << 16) | 0x06FF,
        Arabic_Supplement = (13L << 32) | (0x0750 << 16) | 0x077F,
        NKo = (14L << 32) | (0x07C0 << 16) | 0x07FF,
        Devanagari = (15L << 32) | (0x0900 << 16) | 0x097F,
        Bengali = (16L << 32) | (0x0980 << 16) | 0x09FF,
        Gurmukhi = (17L << 32) | (0x0A00 << 16) | 0x0A7F,
        Gujarati = (18L << 32) | (0x0A80 << 16) | 0x0AFF,
        Oriya = (19L << 32) | (0x0B00 << 16) | 0x0B7F,
        Tamil = (20L << 32) | (0x0B80 << 16) | 0x0BFF,
        Telugu = (21L << 32) | (0x0C00 << 16) | 0x0C7F,
        Kannada = (22L << 32) | (0x0C80 << 16) | 0x0CFF,
        Malayalam = (23L << 32) | (0x0D00 << 16) | 0x0D7F,
        Thai = (24L << 32) | (0x0E00 << 16) | 0x0E7F,
        Lao = (25L << 32) | (0x0E80 << 16) | 0x0EFF,
        Georgian = (26L << 32) | (0x10A0 << 16) | 0x10FF,
        Georgian_Supplement = (26L << 32) | (0x2D00 << 16) | 0x2D2F,
        Balinese = (27L << 32) | (0x1B00 << 16) | 0x1B7F,
        Hangul_Jamo = (28L << 32) | (0x1100 << 16) | 0x11FF,
        Latin_Extended_Additional = (29L << 32) | (0x1E00 << 16) | 0x1EFF,
        Latin_Extended_C = (29L << 32) | (0x2C60 << 16) | 0x2C7F,
        Latin_Extended_D = (29L << 32) | (0xA720 << 16) | 0xA7FF,
        Greek_Extended = (30L << 32) | (0x1F00 << 16) | 0x1FFF,
        General_Punctuation = (31L << 32) | (0x2000 << 16) | 0x206F,
        Supplemental_Punctuation = (31L << 32) | (0x2E00 << 16) | 0x2E7F,
        Superscripts_And_Subscripts = (32L << 32) | (0x2070 << 16) | 0x209F,
        Currency_Symbols = (33L << 32) | (0x20A0 << 16) | 0x20CF,
        Combining_Diacritical_Marks_For_Symbols = (34L << 32) | (0x20D0 << 16) | 0x20FF,
        Letterlike_Symbols = (35L << 32) | (0x2100 << 16) | 0x214F,
        Number_Forms = (36L << 32) | (0x2150 << 16) | 0x218F,
        Arrows = (37L << 32) | (0x2190 << 16) | 0x21FF,
        Supplemental_Arrows_A = (37L << 32) | (0x27F0 << 16) | 0x27FF,
        Supplemental_Arrows_B = (37L << 32) | (0x2900 << 16) | 0x297F,
        Miscellaneous_Symbols_and_Arrows = (37L << 32) | (0x2B00 << 16) | 0x2BFF,
        Mathematical_Operators = (38L << 32) | (0x2200 << 16) | 0x22FF,
        Supplemental_Mathematical_Operators = (38L << 32) | (0x2A00 << 16) | 0x2AFF,
        Miscellaneous_Mathematical_Symbols_A = (38L << 32) | (0x27C0 << 16) | 0x27EF,
        Miscellaneous_Mathematical_Symbols_B = (38L << 32) | (0x2980 << 16) | 0x29FF,
        Miscellaneous_Technical = (39L << 32) | (0x2300 << 16) | 0x23FF,
        Control_Pictures = (40L << 32) | (0x2400 << 16) | 0x243F,
        Optical_Character_Recognition = (41L << 32) | (0x2440 << 16) | 0x245F,
        Enclosed_Alphanumerics = (42L << 32) | (0x2460 << 16) | 0x24FF,
        Box_Drawing = (43L << 32) | (0x2500 << 16) | 0x257F,
        Block_Elements = (44L << 32) | (0x2580 << 16) | 0x259F,
        Geometric_Shapes = (45L << 32) | (0x25A0 << 16) | 0x25FF,
        Miscellaneous_Symbols = (46L << 32) | (0x2600 << 16) | 0x26FF,
        Dingbats = (47L << 32) | (0x2700 << 16) | 0x27BF,
        CJK_Symbols_And_Punctuation = (48L << 32) | (0x3000 << 16) | 0x303F,
        Hiragana = (49L << 32) | (0x3040 << 16) | 0x309F,
        Katakana = (50L << 32) | (0x30A0 << 16) | 0x30FF,
        Katakana_Phonetic_Extensions = (50L << 32) | (0x31F0 << 16) | 0x31FF,
        Bopomofo = (51L << 32) | (0x3100 << 16) | 0x312F,
        Bopomofo_Extended = (51L << 32) | (0x31A0 << 16) | 0x31BF,
        Hangul_Compatibility_Jamo = (52L << 32) | (0x3130 << 16) | 0x318F,
        Phags_pa = (53L << 32) | (0xA840 << 16) | 0xA87F,
        Enclosed_CJK_Letters_And_Months = (54L << 32) | (0x3200 << 16) | 0x32FF,
        CJK_Compatibility = (55L << 32) | (0x3300 << 16) | 0x33FF,
        Hangul_Syllables = (56L << 32) | (0xAC00 << 16) | 0xD7AF,
        Non_Plane_0 = (57L << 32) | (0x10000 << 16) | 0x10FFFF,
        Phoenician = (58L << 32) | (0x10900 << 16) | 0x1091F,
        CJK_Unified_Ideographs = (59L << 32) | (0x4E00 << 16) | 0x9FFF,
        CJK_Radicals_Supplement = (59L << 32) | (0x2E80 << 16) | 0x2EFF,
        Kangxi_Radicals = (59L << 32) | (0x2F00 << 16) | 0x2FDF,
        Ideographic_Description_Characters = (59L << 32) | (0x2FF0 << 16) | 0x2FFF,
        CJK_Unified_Ideographs_Extension_A = (59L << 32) | (0x3400 << 16) | 0x4DBF,
        CJK_Unified_Ideographs_Extension_B = (59L << 32) | (0x20000 << 16) | 0x2A6DF,
        Kanbun = (59L << 32) | (0x3190 << 16) | 0x319F,
        Private_Use_Area__plane_0_ = (60L << 32) | (0xE000 << 16) | 0xF8FF,
        CJK_Strokes = (61L << 32) | (0x31C0 << 16) | 0x31EF,
        CJK_Compatibility_Ideographs = (61L << 32) | (0xF900 << 16) | 0xFAFF,
        CJK_Compatibility_Ideographs_Supplement = (61L << 32) | (0x2F800 << 16) | 0x2FA1F,
        Alphabetic_Presentation_Forms = (62L << 32) | (0xFB00 << 16) | 0xFB4F,
        Arabic_Presentation_Forms_A = (63L << 32) | (0xFB50 << 16) | 0xFDFF,
        Combining_Half_Marks = (64L << 32) | (0xFE20 << 16) | 0xFE2F,
        Vertical_Forms = (65L << 32) | (0xFE10 << 16) | 0xFE1F,
        CJK_Compatibility_Forms = (65L << 32) | (0xFE30 << 16) | 0xFE4F,
        Small_Form_Variants = (66L << 32) | (0xFE50 << 16) | 0xFE6F,
        Arabic_Presentation_Forms_B = (67L << 32) | (0xFE70 << 16) | 0xFEFF,
        Halfwidth_And_Fullwidth_Forms = (68L << 32) | (0xFF00 << 16) | 0xFFEF,
        Specials = (69L << 32) | (0xFFF0 << 16) | 0xFFFF,
        Tibetan = (70L << 32) | (0x0F00 << 16) | 0x0FFF,
        Syriac = (71L << 32) | (0x0700 << 16) | 0x074F,
        Thaana = (72L << 32) | (0x0780 << 16) | 0x07BF,
        Sinhala = (73L << 32) | (0x0D80 << 16) | 0x0DFF,
        Myanmar = (74L << 32) | (0x1000 << 16) | 0x109F,
        Ethiopic = (75L << 32) | (0x1200 << 16) | 0x137F,
        Ethiopic_Supplement = (75L << 32) | (0x1380 << 16) | 0x139F,
        Ethiopic_Extended = (75L << 32) | (0x2D80 << 16) | 0x2DDF,
        Cherokee = (76L << 32) | (0x13A0 << 16) | 0x13FF,
        Unified_Canadian_Aboriginal_Syllabics = (77L << 32) | (0x1400 << 16) | 0x167F,
        Ogham = (78L << 32) | (0x1680 << 16) | 0x169F,
        Runic = (79L << 32) | (0x16A0 << 16) | 0x16FF,
        Khmer = (80L << 32) | (0x1780 << 16) | 0x17FF,
        Khmer_Symbols = (80L << 32) | (0x19E0 << 16) | 0x19FF,
        Mongolian = (81L << 32) | (0x1800 << 16) | 0x18AF,
        Braille_Patterns = (82L << 32) | (0x2800 << 16) | 0x28FF,
        Yi_Syllables = (83L << 32) | (0xA000 << 16) | 0xA48F,
        Yi_Radicals = (83L << 32) | (0xA490 << 16) | 0xA4CF,
        Tagalog = (84L << 32) | (0x1700 << 16) | 0x171F,
        Hanunoo = (84L << 32) | (0x1720 << 16) | 0x173F,
        Buhid = (84L << 32) | (0x1740 << 16) | 0x175F,
        Tagbanwa = (84L << 32) | (0x1760 << 16) | 0x177F,
        Old_Italic = (85L << 32) | (0x10300 << 16) | 0x1032F,
        Gothic = (86L << 32) | (0x10330 << 16) | 0x1034F,
        Deseret = (87L << 32) | (0x10400 << 16) | 0x1044F,
        Byzantine_Musical_Symbols = (88L << 32) | (0x1D000 << 16) | 0x1D0FF,
        Musical_Symbols = (88L << 32) | (0x1D100 << 16) | 0x1D1FF,
        Ancient_Greek_Musical_Notation = (88L << 32) | (0x1D200 << 16) | 0x1D24F,
        Mathematical_Alphanumeric_Symbols = (89L << 32) | (0x1D400 << 16) | 0x1D7FF,
        Private_Use__plane_15_ = (90L << 32) | (0xF0000 << 16) | 0xFFFFD,
        Private_Use__plane_16_ = (90L << 32) | (0x100000 << 16) | 0x10FFFD,
        Variation_Selectors = (91L << 32) | (0xFE00 << 16) | 0xFE0F,
        Variation_Selectors_Supplement = (91L << 32) | (0xE0100 << 16) | 0xE01EF,
        Tags = (92L << 32) | (0xE0000 << 16) | 0xE007F,
        Limbu = (93L << 32) | (0x1900 << 16) | 0x194F,
        Tai_Le = (94L << 32) | (0x1950 << 16) | 0x197F,
        New_Tai_Lue = (95L << 32) | (0x1980 << 16) | 0x19DF,
        Buginese = (96L << 32) | (0x1A00 << 16) | 0x1A1F,
        Glagolitic = (97L << 32) | (0x2C00 << 16) | 0x2C5F,
        Tifinagh = (98L << 32) | (0x2D30 << 16) | 0x2D7F,
        Yijing_Hexagram_Symbols = (99L << 32) | (0x4DC0 << 16) | 0x4DFF,
        Syloti_Nagri = (100L << 32) | (0xA800 << 16) | 0xA82F,
        Linear_B_Syllabary = (101L << 32) | (0x10000 << 16) | 0x1007F,
        Linear_B_Ideograms = (101L << 32) | (0x10080 << 16) | 0x100FF,
        Aegean_Numbers = (101L << 32) | (0x10100 << 16) | 0x1013F,
        Ancient_Greek_Numbers = (102L << 32) | (0x10140 << 16) | 0x1018F,
        Ugaritic = (103L << 32) | (0x10380 << 16) | 0x1039F,
        Old_Persian = (104L << 32) | (0x103A0 << 16) | 0x103DF,
        Shavian = (105L << 32) | (0x10450 << 16) | 0x1047F,
        Osmanya = (106L << 32) | (0x10480 << 16) | 0x104AF,
        Cypriot_Syllabary = (107L << 32) | (0x10800 << 16) | 0x1083F,
        Kharoshthi = (108L << 32) | (0x10A00 << 16) | 0x10A5F,
        Tai_Xuan_Jing_Symbols = (109L << 32) | (0x1D300 << 16) | 0x1D35F,
        Cuneiform = (110L << 32) | (0x12000 << 16) | 0x123FF,
        Cuneiform_Numbers_and_Punctuation = (110L << 32) | (0x12400 << 16) | 0x1247F,
        Counting_Rod_Numerals = (111L << 32) | (0x1D360 << 16) | 0x1D37F,
        Sundanese = (112L << 32) | (0x1B80 << 16) | 0x1BBF,
        Lepcha = (113L << 32) | (0x1C00 << 16) | 0x1C4F,
        Ol_Chiki = (114L << 32) | (0x1C50 << 16) | 0x1C7F,
        Saurashtra = (115L << 32) | (0xA880 << 16) | 0xA8DF,
        Kayah_Li = (116L << 32) | (0xA900 << 16) | 0xA92F,
        Rejang = (117L << 32) | (0xA930 << 16) | 0xA95F,
        Cham = (118L << 32) | (0xAA00 << 16) | 0xAA5F,
        Ancient_Symbols = (119L << 32) | (0x10190 << 16) | 0x101CF,
        Phaistos_Disc = (120L << 32) | (0x101D0 << 16) | 0x101FF,
        Carian = (121L << 32) | (0x102A0 << 16) | 0x102DF,
        Lycian = (121L << 32) | (0x10280 << 16) | 0x1029F,
        Lydian = (121L << 32) | (0x10920 << 16) | 0x1093F,
        Domino_Tiles = (122L << 32) | (0x1F030 << 16) | 0x1F09F,
        Mahjong_Tiles = (122L << 32) | (0x1F000 << 16) | 0x1F02F,
        Reserved123 = (123L << 32) | (0x0 << 16) | 0x0,
        Reserved124 = (124L << 32) | (0x0 << 16) | 0x0,
        Reserved125 = (125L << 32) | (0x0 << 16) | 0x0,
        Reserved126 = (126L << 32) | (0x0 << 16) | 0x0,
        Reserved127 = (127L << 32) | (0x0 << 16) | 0x0,
    }

}
